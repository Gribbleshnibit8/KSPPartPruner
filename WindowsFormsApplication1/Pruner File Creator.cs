using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KSPPrunerFileCreator
{
	public partial class Form1 : Form
	{
		private readonly string[] _args = Environment.GetCommandLineArgs();


		public Form1()
		{
			InitializeComponent();

			if (_args.Length > 1)
			{
				var paths = new List<string>();
				for (int i = 1; i < _args.Length; i++)
				{
					paths.Add(_args[i]);
				}
				PopulateListBox(paths.ToArray());
			}
		}



		#region ListBox

		private ListBox.SelectedObjectCollection _listBoxSelectedItems;

		private void PopulateListBox(string[] files)
		{
			// loop through the string array, adding each filename to the ListBox
			foreach (var file in files)
			{
				try
				{
					using (var sr = new StreamReader(file))
					{
						String line;
						while ((line = sr.ReadLine()) != null)
						{
							listBox.Items.Add(line);
						}

					}
				}
				catch (Exception ex)
				{
					// Handle Exception
				}
				
			}
		}

		private void listBox_DragDrop(object sender, DragEventArgs e)
		{
			// transfer the filenames to a string array
			// (yes, everything to the left of the "=" can be put in the 
			// foreach loop in place of "files", but this is easier to understand.)
			var files = (string[])e.Data.GetData(DataFormats.FileDrop);

			// loop through the string array, adding each filename to the ListBox
			foreach (var file in files)
			{
				var splits = new string[] { @"GameData" + Path.DirectorySeparatorChar };
				var parts = file.Split(splits, StringSplitOptions.None);
				if (!listBox.Items.Contains(parts[1]))
					listBox.Items.Add(parts[1]);
			}
		}

		private void listBox_DragEnter(object sender, DragEventArgs e)
		{
			// make sure they're actually dropping files (not text or anything else)
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
				// allow them to continue
				// (without this, the cursor stays a "NO" symbol
				e.Effect = DragDropEffects.All;
		}

		private void listBox_MouseDown(object sender, MouseEventArgs e)
		{
			// Save the selected items for use in other functions that inexplicably don't have access to this
			_listBoxSelectedItems = ((ListBox)sender).SelectedItems;

			// Only do this if the right mouse button is clicked on the control
			if (e.Button != MouseButtons.Right) return;

			// Get the index of the item clicked upon from the mouse position
			var index = ((ListBox) sender).IndexFromPoint((e.Location));

			// If the index is not a valid item in the list, remove the context menu
			// so it doesn't show up on an empty space, then return
			if (index == ListBox.NoMatches)
			{
				((ListBox) sender).ContextMenuStrip = null;
				return;
			}

			// The index clicked upon was valid, so we need to add the context menu
			// back to the form so that it returns the proper owner later.
			((ListBox)sender).ContextMenuStrip = contextMenuListBox;

			// Go ahead and add the currently moused over index to the selected items
			((ListBox)sender).SelectedIndices.Add(index);

			// Show the context menu where the mouse cursor is positioned (why is this not default?)
			contextMenuListBox.Show(Cursor.Position);
		}

		private void listBox_KeyDown(object sender, KeyEventArgs e)
		{
			var selected = ((ListBox) sender).SelectedItems;
			switch (e.KeyCode)
			{
				case Keys.Delete:
					if (selected.Count > 0)
						while(selected.Count > 0)
							((ListBox)sender).Items.Remove(selected[0]);

					break;
			}
		}

		#endregion Listbox


		#region LabelPrunerOpener

		private void lablePrunerOpener_DragDrop(object sender, DragEventArgs e)
		{
			// transfer the filenames to a string array
			// (yes, everything to the left of the "=" can be put in the 
			// foreach loop in place of "files", but this is easier to understand.)
			var files = (string[])e.Data.GetData(DataFormats.FileDrop);
			PopulateListBox(files);
		}

		private void lablePrunerOpener_DragEnter(object sender, DragEventArgs e)
		{
			// make sure they're actually dropping files (not text or anything else)
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
				// allow them to continue
				// (without this, the cursor stays a "NO" symbol
				e.Effect = DragDropEffects.All;
		}

		#endregion LabelPrunerOpener


		#region Buttons

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var savePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "pruners");

			if (!Directory.Exists(savePath))
				Directory.CreateDirectory(savePath);

			saveFileDialog1.Filter = "Text file|*.txt";
			saveFileDialog1.InitialDirectory = savePath;
			saveFileDialog1.FileName = Path.GetFileName(saveFileDialog1.FileName);
			saveFileDialog1.ShowDialog();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			listBox.Items.Clear();
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void saveFileDialog1_FileOK(object sender, CancelEventArgs e)
		{
			var listItems = listBox.Items.Cast<String>().ToList();

			using (var sw = new StreamWriter(saveFileDialog1.FileName, true))
			{
				foreach (var listItem in listItems)
					sw.Write(listItem + Environment.NewLine);
			}
		}

		#endregion Buttons


		private void ContextMenuListBox_Delete_Click(object sender, EventArgs e)
		{
			// Try to cast the sender to a ToolStripItem
			var menuItem = sender as ToolStripItem;
			if (menuItem != null)
			{
				// Retrieve the ContextMenuStrip that owns this ToolStripItem
				var owner = menuItem.Owner as ContextMenuStrip;
				if (owner != null)
				{
					// Get the control that is displaying this context menu
					Control sourceControl = owner.SourceControl as ListBox;

					if (sourceControl != null)
						while (_listBoxSelectedItems.Count > 0)
							listBox.Items.Remove(_listBoxSelectedItems[0]);
							
				}
			}
		}
	}
}
