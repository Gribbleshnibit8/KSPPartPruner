using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace KSP_Pruner_App
{
	public partial class Pruner : Form
	{

		private readonly String _workingDir = Path.GetDirectoryName(Application.ExecutablePath);
		private readonly String _kspPath = Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath));

		private static bool _creatorOpened = false;

		private readonly String _prunerPath = null;

		[DllImport("user32.dll")]
		static extern bool SetForegroundWindow(IntPtr hWnd);


		public Pruner()
		{
			InitializeComponent();

			_prunerPath = _workingDir + @"\pruners";

			Log("Current path is: " + _workingDir);
			Log("KSP path is: " + _kspPath);
			LogNewEntry();

			if (!Directory.Exists(Path.Combine(_kspPath, "GameData")))
			{
				LogWarning("The GameData folder was not found!");
				LogNewEntry();
			}

			PopulateFileList();
			CreateWatcher();
		}

		private void PopulateFileList()
		{
			if (!Directory.Exists(_prunerPath)) return;

			var files = Directory.GetFiles(_prunerPath);

			foreach (var file in files)
				FileList.Items.Add(Path.GetFileNameWithoutExtension(file));
		}

		private IEnumerable<string> GetSelectedFiles()
		{
			var itemsList = FileList.SelectedItems.Cast<String>().ToList();
			var dirFileList = Directory.GetFiles(_prunerPath);

			if (itemsList.Count == 0)
				Log("No files selected.");

			return dirFileList.Where(file => itemsList.Contains(Path.GetFileNameWithoutExtension(file))).ToArray();
		}

		private String GetGameDataPath(String path)
		{
			var splits = new string[] { @"GameData" + Path.DirectorySeparatorChar };
			var parts = path.Split(splits, StringSplitOptions.None);
			return @"GameData\" + parts[1];
		}

		#region Pruner

		/// <summary>
		/// Takes a list of file and directory paths and adds the .prune extension to all contained files
		/// </summary>
		/// <param name="filesList">List of file and directory paths</param>
		private void PruneFiles(IEnumerable<string> filesList)
		{
			foreach (var file in filesList)
			{
				var lines = new List<string>();

				using (var r = new StreamReader(file))
				{
					string line;
					while ((line = r.ReadLine()) != null)
						lines.Add(line);
				}

				foreach (var line in lines)
				{
					if ( (line[0] == '#') || (String.IsNullOrEmpty(line)) )
						continue;

					var path = _kspPath + @"\GameData\" + line;


					if (File.Exists(path))
						PruneFile(path);

					else if (Directory.Exists(path))
						PruneDirectory(path);

					else
						LogWarning("\"" + GetGameDataPath(path) + "\" is not a file or a directory.");

				}
			}
		}

		private void PruneDirectory(string path)
		{
			try
			{
				Log("Pruning files from " + GetGameDataPath(path));
				var files = Directory.GetFiles(path).ToList();
				files.AddRange(Directory.GetDirectories(path));

				foreach (var file in files)
				{
					if (File.Exists(file))
						PruneFile(file);
					else if (Directory.Exists(file))
						PruneDirectory(file);
				}
			}
			catch (IOException ex)
			{
				LogError(ex.ToString());
			}
			
		}

		private void PruneFile(String file)
		{
			try
			{
				File.Move(file, file + ".prune");
				Log("Pruned: " + GetGameDataPath(file));
			}
			catch (IOException ex)
			{
				LogError(ex.ToString());
			}
		}

		#endregion Pruner


		#region Unpruner

		/// <summary>
		/// Takes a list of file and directory paths and removes the .prune extension from all contained files
		/// </summary>
		/// <param name="filesList">List of file and directory paths</param>
		private void UnpruneFiles(IEnumerable<string> filesList)
		{
			foreach (var file in filesList)
			{
				var lines = new List<string>();

				using (var r = new StreamReader(file))
				{
					string line;
					while ((line = r.ReadLine()) != null)
						lines.Add(line);
				}

				foreach (var line in lines)
				{
					var pruneFile = _kspPath + @"\GameData\" + line + ".prune";
					var path = _kspPath + @"\GameData\" + line;

					if (File.Exists(pruneFile))
						path += ".prune";

					if (File.Exists(path))
						UnpruneFile(path);

					else if (Directory.Exists(path))
						UnpruneDirectory(path);

					else
						LogWarning("\"" + GetGameDataPath(path) + "\" is not a file or a directory.");

				}
			}
		}

		private void UnpruneDirectory(string path)
		{
			try
			{
				Log("Unpruning files from " + GetGameDataPath(path));
				var files = Directory.GetFiles(path).ToList();
				files.AddRange(Directory.GetDirectories(path));

				foreach (var file in files)
				{
					if (File.Exists(file))
						UnpruneFile(file);
					else if (Directory.Exists(file))
						UnpruneDirectory(file);
				}
			}
			catch (IOException ex)
			{
				LogError(ex.ToString());
			}

		}

		private void UnpruneFile(String file)
		{
			try
			{
				var newFile = file.Replace(".prune", "");
				File.Move(file, newFile);
				Log("Unpruned: " + GetGameDataPath(file));
			}
			catch (IOException ex)
			{
				LogError(ex.ToString());
			}
		}

		#endregion Unpruner


		#region Buttons

		private void buttonPruneAll_Click(object sender, EventArgs e)
		{
			LogNewEntry();
			var filesList = Directory.GetFiles(_prunerPath);
			PruneFiles(filesList);
		}

		private void buttonPruneSelected_Click(object sender, EventArgs e)
		{
			LogNewEntry();
			PruneFiles(GetSelectedFiles());
		}

		private void buttonUnpruneAll_Click(object sender, EventArgs e)
		{
			LogNewEntry();
			var filesList = Directory.GetFiles(_prunerPath);
			UnpruneFiles(filesList);
		}

		private void buttonUnpruneSelected_Click(object sender, EventArgs e)
		{
			LogNewEntry();
			UnpruneFiles(GetSelectedFiles());
		}

		private void buttonRescanFolder_Click(object sender, EventArgs e)
		{
			FileList.Items.Clear();
			PopulateFileList();
		}

		#endregion Buttons


		#region Toolstrip Buttons

		private void AboutButton_Click(object sender, EventArgs e)
		{
			AboutBox1.GetInstance().ShowDialog(this);
		}

		private void PrunerCreator_Click(object sender, EventArgs e)
		{
			if (IsCreatorOpen() == true)
			{
				foreach (var process in Process.GetProcessesByName("KSP Pruner File Creator"))
					SetForegroundWindow(process.MainWindowHandle);
			}
			else
			{
				Process.Start("KSP Pruner File Creator");
				_creatorOpened = true;
			}
		}

		private void toolStripButtonEdit_Click(object sender, EventArgs e)
		{
			if (FileList.SelectedItems.Count == 0)
			{
				Log("No items selected for editing");
				return;
			}

			if (IsCreatorOpen() == false)
			{
				var args = "";
				foreach (var item in FileList.SelectedItems)
				{
					var path = "\"" + Path.Combine(_prunerPath, item + ".txt") + "\"";
					args += path + " ";
					Log("Opening " + path);
				}
				//var arg = "\"" + Path.Combine(_prunerPath, FileList.SelectedItem.ToString() + ".txt") + "\"";
				//Log("Trying to open file " + arg);
				
				Process.Start("KSP Pruner File Creator", args.Trim());
				_creatorOpened = true;
			}
		}

		private bool IsCreatorOpen()
		{
			if (Process.GetProcessesByName("KSP Pruner File Creator").Length >= 1)
				return true;
			return _creatorOpened = false;
		}

		#endregion Toolstrip Buttons


		#region Console Logging

		delegate void SetTextCallback(string text);

		private void Log (String line)
		{
			if (this.consoleBox.InvokeRequired)
			{
				var d = new SetTextCallback(LogAddLine);
				this.Invoke(d, new object[] { line + Environment.NewLine });
			}
			else
			{
				LogAddLine(line);
				LogAddLine(Environment.NewLine);
			}
			
		}

		private void LogWarning (String line)
		{
			LogAddLine("Warning: ");
			LogAddLine("\t" + line);
			LogAddLine(Environment.NewLine);
		}

		private void LogError(String line)
		{
			LogAddLine("Error: ");
			LogAddLine("\t" + line);
			LogAddLine(Environment.NewLine);
		}

		private void LogNewEntry()
		{
			LogAddLine(Environment.NewLine);
			LogAddLine("==================================================");
			LogAddLine(Environment.NewLine);
			LogAddLine(Environment.NewLine);
		}

		private void LogAddLine(String line)
		{
			consoleBox.AppendText(line);
		}

		#endregion Console Logging


		#region Split Container

		private void SplitContainer_MouseUp(object sender, MouseEventArgs e)
		{
			statusStrip1.Focus();
		}

		private void SplitterContainer_Paint(object sender, PaintEventArgs e)
		{
			var control = sender as SplitContainer;
			//paint the three dots'
			Point[] points = new Point[3];
			var w = control.Width;
			var h = control.Height;
			var d = control.SplitterDistance;
			var sW = control.SplitterWidth;

			//calculate the position of the points'
			if (control.Orientation == Orientation.Horizontal)
			{
				points[0] = new Point((w / 2), d + (sW / 2));
				points[1] = new Point(points[0].X - 10, points[0].Y);
				points[2] = new Point(points[0].X + 10, points[0].Y);
			}
			else
			{
				points[0] = new Point(d + (sW / 2), (h / 2));
				points[1] = new Point(points[0].X, points[0].Y - 10);
				points[2] = new Point(points[0].X, points[0].Y + 10);
			}

			foreach (Point p in points)
			{
				p.Offset(-2, -2);
				e.Graphics.FillEllipse(SystemBrushes.ControlDark,
					new Rectangle(p, new Size(5, 5)));

				p.Offset(1, 1);
				e.Graphics.FillEllipse(SystemBrushes.ControlLight,
					new Rectangle(p, new Size(5, 5)));
			}
		}

		#endregion Split Container


		#region Folder Watcher

		private Thread _demoThread = null;

		public void CreateWatcher()
		{
			var watcher = new FileSystemWatcher
			{
				Filter = "*.txt"
			};

			watcher.Created += watcher_FilesChanged;
			watcher.Deleted += watcher_FilesChanged;
			watcher.Path = _prunerPath;
			watcher.EnableRaisingEvents = true;
		}

		void watcher_FilesChanged(object sender, FileSystemEventArgs e)
		{
			_demoThread =
				new Thread(Tempmethod);

			_demoThread.Start();
		}

		private void Tempmethod()
		{
			Log("Updating file list.");
		}

		#endregion Folder Watcher


		#region Form Events

		private void Pruner_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_creatorOpened == true)
			{
				foreach (var process in Process.GetProcessesByName("KSP Pruner File Creator"))
				{
					process.Kill();
				}
			}
		}

		#endregion FormEvents


		#region File List Events


		private void FileList_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == (Keys.A | Keys.Control))
				for (int i = 0; i < FileList.Items.Count; i++)
					FileList.SetSelected(i, true);

		}

		private void FileList_SelectedIndexChanged(object sender, EventArgs e)
		{
			//toolStripButtonEdit.Enabled = FileList.SelectedItems.Count <= 1;
		}

		#endregion File List Events




	}
}
