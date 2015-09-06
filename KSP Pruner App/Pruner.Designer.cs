namespace KSP_Pruner_App
{
	partial class Pruner
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pruner));
			this.FileList = new System.Windows.Forms.ListBox();
			this.ContentWindowTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ButtonPanelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.buttonRescanFolder = new System.Windows.Forms.Button();
			this.buttonPruneAll = new System.Windows.Forms.Button();
			this.buttonUnpruneAll = new System.Windows.Forms.Button();
			this.buttonPruneSelected = new System.Windows.Forms.Button();
			this.buttonUnpruneSelected = new System.Windows.Forms.Button();
			this.consoleBox = new System.Windows.Forms.TextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripButtonAbout = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripButtonPrunerCreator = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripButtonEdit = new System.Windows.Forms.ToolStripDropDownButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.ContentWindowTableLayoutPanel.SuspendLayout();
			this.ButtonPanelTableLayoutPanel.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// FileList
			// 
			this.FileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FileList.FormattingEnabled = true;
			this.FileList.Location = new System.Drawing.Point(3, 3);
			this.FileList.Name = "FileList";
			this.FileList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.FileList.Size = new System.Drawing.Size(426, 355);
			this.FileList.TabIndex = 0;
			this.toolTip1.SetToolTip(this.FileList, "Select one or more lines, Ctrl+LMB to select multiple entries");
			this.FileList.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged);
			this.FileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileList_KeyDown);
			// 
			// ContentWindowTableLayoutPanel
			// 
			this.ContentWindowTableLayoutPanel.ColumnCount = 2;
			this.ContentWindowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ContentWindowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.ContentWindowTableLayoutPanel.Controls.Add(this.ButtonPanelTableLayoutPanel, 1, 0);
			this.ContentWindowTableLayoutPanel.Controls.Add(this.FileList, 0, 0);
			this.ContentWindowTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContentWindowTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.ContentWindowTableLayoutPanel.Name = "ContentWindowTableLayoutPanel";
			this.ContentWindowTableLayoutPanel.RowCount = 1;
			this.ContentWindowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ContentWindowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 370F));
			this.ContentWindowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 370F));
			this.ContentWindowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 370F));
			this.ContentWindowTableLayoutPanel.Size = new System.Drawing.Size(732, 370);
			this.ContentWindowTableLayoutPanel.TabIndex = 1;
			// 
			// ButtonPanelTableLayoutPanel
			// 
			this.ButtonPanelTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonPanelTableLayoutPanel.AutoSize = true;
			this.ButtonPanelTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonPanelTableLayoutPanel.ColumnCount = 1;
			this.ButtonPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ButtonPanelTableLayoutPanel.Controls.Add(this.buttonRescanFolder, 0, 4);
			this.ButtonPanelTableLayoutPanel.Controls.Add(this.buttonPruneAll, 0, 0);
			this.ButtonPanelTableLayoutPanel.Controls.Add(this.buttonUnpruneAll, 0, 1);
			this.ButtonPanelTableLayoutPanel.Controls.Add(this.buttonPruneSelected, 0, 2);
			this.ButtonPanelTableLayoutPanel.Controls.Add(this.buttonUnpruneSelected, 0, 3);
			this.ButtonPanelTableLayoutPanel.Location = new System.Drawing.Point(435, 3);
			this.ButtonPanelTableLayoutPanel.Name = "ButtonPanelTableLayoutPanel";
			this.ButtonPanelTableLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
			this.ButtonPanelTableLayoutPanel.RowCount = 5;
			this.ButtonPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ButtonPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ButtonPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ButtonPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ButtonPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ButtonPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.ButtonPanelTableLayoutPanel.Size = new System.Drawing.Size(294, 206);
			this.ButtonPanelTableLayoutPanel.TabIndex = 1;
			// 
			// buttonRescanFolder
			// 
			this.buttonRescanFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRescanFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonRescanFolder.Location = new System.Drawing.Point(11, 163);
			this.buttonRescanFolder.Name = "buttonRescanFolder";
			this.buttonRescanFolder.Size = new System.Drawing.Size(272, 32);
			this.buttonRescanFolder.TabIndex = 4;
			this.buttonRescanFolder.Text = "Rescan Folder";
			this.buttonRescanFolder.UseVisualStyleBackColor = true;
			this.buttonRescanFolder.Click += new System.EventHandler(this.buttonRescanFolder_Click);
			// 
			// buttonPruneAll
			// 
			this.buttonPruneAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPruneAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonPruneAll.Location = new System.Drawing.Point(11, 11);
			this.buttonPruneAll.Name = "buttonPruneAll";
			this.buttonPruneAll.Size = new System.Drawing.Size(272, 32);
			this.buttonPruneAll.TabIndex = 0;
			this.buttonPruneAll.Text = "Prune All";
			this.buttonPruneAll.UseVisualStyleBackColor = true;
			this.buttonPruneAll.Click += new System.EventHandler(this.buttonPruneAll_Click);
			// 
			// buttonUnpruneAll
			// 
			this.buttonUnpruneAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUnpruneAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonUnpruneAll.Location = new System.Drawing.Point(11, 49);
			this.buttonUnpruneAll.Name = "buttonUnpruneAll";
			this.buttonUnpruneAll.Size = new System.Drawing.Size(272, 32);
			this.buttonUnpruneAll.TabIndex = 2;
			this.buttonUnpruneAll.Text = "Unprune All";
			this.buttonUnpruneAll.UseVisualStyleBackColor = true;
			this.buttonUnpruneAll.Click += new System.EventHandler(this.buttonUnpruneAll_Click);
			// 
			// buttonPruneSelected
			// 
			this.buttonPruneSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPruneSelected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonPruneSelected.Location = new System.Drawing.Point(11, 87);
			this.buttonPruneSelected.Name = "buttonPruneSelected";
			this.buttonPruneSelected.Size = new System.Drawing.Size(272, 32);
			this.buttonPruneSelected.TabIndex = 1;
			this.buttonPruneSelected.Text = "Prune Selected";
			this.buttonPruneSelected.UseVisualStyleBackColor = true;
			this.buttonPruneSelected.Click += new System.EventHandler(this.buttonPruneSelected_Click);
			// 
			// buttonUnpruneSelected
			// 
			this.buttonUnpruneSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUnpruneSelected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonUnpruneSelected.Location = new System.Drawing.Point(11, 125);
			this.buttonUnpruneSelected.Name = "buttonUnpruneSelected";
			this.buttonUnpruneSelected.Size = new System.Drawing.Size(272, 32);
			this.buttonUnpruneSelected.TabIndex = 3;
			this.buttonUnpruneSelected.Text = "Unprune Selected";
			this.buttonUnpruneSelected.UseVisualStyleBackColor = true;
			this.buttonUnpruneSelected.Click += new System.EventHandler(this.buttonUnpruneSelected_Click);
			// 
			// consoleBox
			// 
			this.consoleBox.BackColor = System.Drawing.SystemColors.Control;
			this.consoleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.consoleBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleBox.HideSelection = false;
			this.consoleBox.Location = new System.Drawing.Point(0, 0);
			this.consoleBox.Multiline = true;
			this.consoleBox.Name = "consoleBox";
			this.consoleBox.ReadOnly = true;
			this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.consoleBox.Size = new System.Drawing.Size(732, 152);
			this.consoleBox.TabIndex = 2;
			// 
			// statusStrip1
			// 
			this.statusStrip1.AutoSize = false;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAbout,
            this.toolStripButtonPrunerCreator,
            this.toolStripButtonEdit});
			this.statusStrip1.Location = new System.Drawing.Point(0, 534);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(734, 32);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripButtonAbout
			// 
			this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
			this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAbout.Name = "toolStripButtonAbout";
			this.toolStripButtonAbout.ShowDropDownArrow = false;
			this.toolStripButtonAbout.Size = new System.Drawing.Size(60, 30);
			this.toolStripButtonAbout.Text = "About";
			this.toolStripButtonAbout.Click += new System.EventHandler(this.AboutButton_Click);
			// 
			// toolStripButtonPrunerCreator
			// 
			this.toolStripButtonPrunerCreator.Image = global::KSP_Pruner_App.Properties.Resources.CutHS;
			this.toolStripButtonPrunerCreator.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPrunerCreator.Name = "toolStripButtonPrunerCreator";
			this.toolStripButtonPrunerCreator.ShowDropDownArrow = false;
			this.toolStripButtonPrunerCreator.Size = new System.Drawing.Size(104, 30);
			this.toolStripButtonPrunerCreator.Text = "Pruner Creator";
			this.toolStripButtonPrunerCreator.Click += new System.EventHandler(this.PrunerCreator_Click);
			// 
			// toolStripButtonEdit
			// 
			this.toolStripButtonEdit.Image = global::KSP_Pruner_App.Properties.Resources.EditInformationHS;
			this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEdit.Name = "toolStripButtonEdit";
			this.toolStripButtonEdit.ShowDropDownArrow = false;
			this.toolStripButtonEdit.Size = new System.Drawing.Size(47, 30);
			this.toolStripButtonEdit.Text = "Edit";
			this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.ContentWindowTableLayoutPanel);
			this.splitContainer1.Panel1MinSize = 300;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.consoleBox);
			this.splitContainer1.Size = new System.Drawing.Size(734, 534);
			this.splitContainer1.SplitterDistance = 372;
			this.splitContainer1.SplitterWidth = 8;
			this.splitContainer1.TabIndex = 3;
			this.splitContainer1.TabStop = false;
			this.splitContainer1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitterContainer_Paint);
			this.splitContainer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SplitContainer_MouseUp);
			// 
			// Pruner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 566);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "Pruner";
			this.Text = "KSP File Pruner";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pruner_FormClosing);
			this.ContentWindowTableLayoutPanel.ResumeLayout(false);
			this.ContentWindowTableLayoutPanel.PerformLayout();
			this.ButtonPanelTableLayoutPanel.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox FileList;
		private System.Windows.Forms.TableLayoutPanel ContentWindowTableLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel ButtonPanelTableLayoutPanel;
		private System.Windows.Forms.Button buttonPruneAll;
		private System.Windows.Forms.Button buttonUnpruneSelected;
		private System.Windows.Forms.Button buttonUnpruneAll;
		private System.Windows.Forms.TextBox consoleBox;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButtonAbout;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button buttonRescanFolder;
		private System.Windows.Forms.Button buttonPruneSelected;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButtonPrunerCreator;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButtonEdit;
	}
}

