namespace KSPPrunerFileCreator
{
	partial class Form1
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.labelInstructions = new System.Windows.Forms.Label();
			this.listBox = new System.Windows.Forms.ListBox();
			this.contextMenuListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
			this.labelPrunerOpener = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.contextMenuListBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelInstructions, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelPrunerOpener, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.listBox, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 342);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.buttonClose, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.buttonSave, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.buttonClear, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 310);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(454, 29);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonClose.Location = new System.Drawing.Point(340, 3);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 5;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonSave.Location = new System.Drawing.Point(38, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonClear.Location = new System.Drawing.Point(189, 3);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 4;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// labelInstructions
			// 
			this.labelInstructions.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelInstructions.AutoSize = true;
			this.labelInstructions.Location = new System.Drawing.Point(3, 11);
			this.labelInstructions.Name = "labelInstructions";
			this.labelInstructions.Size = new System.Drawing.Size(182, 13);
			this.labelInstructions.TabIndex = 0;
			this.labelInstructions.Text = "Drag and drop files and folders below";
			// 
			// listBox
			// 
			this.listBox.AllowDrop = true;
			this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.listBox, 2);
			this.listBox.ContextMenuStrip = this.contextMenuListBox;
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(3, 38);
			this.listBox.Name = "listBox";
			this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBox.Size = new System.Drawing.Size(454, 264);
			this.listBox.TabIndex = 2;
			this.toolTip1.SetToolTip(this.listBox, "Drag and drop files and folders here to add them to the list");
			this.listBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
			this.listBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
			this.listBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_KeyDown);
			this.listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
			// 
			// contextMenuListBox
			// 
			this.contextMenuListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItem_Delete});
			this.contextMenuListBox.Name = "contextMenuListBox";
			this.contextMenuListBox.Size = new System.Drawing.Size(108, 26);
			// 
			// contextMenuItem_Delete
			// 
			this.contextMenuItem_Delete.Name = "contextMenuItem_Delete";
			this.contextMenuItem_Delete.Size = new System.Drawing.Size(107, 22);
			this.contextMenuItem_Delete.Text = "&Delete";
			this.contextMenuItem_Delete.Click += new System.EventHandler(this.ContextMenuListBox_Delete_Click);
			// 
			// labelPrunerOpener
			// 
			this.labelPrunerOpener.AllowDrop = true;
			this.labelPrunerOpener.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPrunerOpener.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelPrunerOpener.Location = new System.Drawing.Point(230, 0);
			this.labelPrunerOpener.Margin = new System.Windows.Forms.Padding(0);
			this.labelPrunerOpener.Name = "labelPrunerOpener";
			this.labelPrunerOpener.Size = new System.Drawing.Size(230, 35);
			this.labelPrunerOpener.TabIndex = 3;
			this.labelPrunerOpener.Text = "Drop a pruner file here to open the existing files";
			this.labelPrunerOpener.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPrunerOpener.DragDrop += new System.Windows.Forms.DragEventHandler(this.lablePrunerOpener_DragDrop);
			this.labelPrunerOpener.DragEnter += new System.Windows.Forms.DragEventHandler(this.lablePrunerOpener_DragEnter);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOK);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 366);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Form1";
			this.Text = "KSP Pruner File Creator";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.contextMenuListBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelInstructions;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label labelPrunerOpener;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.ContextMenuStrip contextMenuListBox;
		private System.Windows.Forms.ToolStripMenuItem contextMenuItem_Delete;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button buttonClose;
	}
}

