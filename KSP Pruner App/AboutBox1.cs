using System;
using System.Windows.Forms;

namespace KSP_Pruner_App
{
	partial class AboutBox1 : Form
	{
		private static Form _myForm;



		public AboutBox1()
		{
			InitializeComponent();
		}

		private static AboutBox1 _openForm = null;

		// No need for locking - you'll be doing all this on the UI thread...
		public static AboutBox1 GetInstance()
		{
			if (_openForm == null)
			{
				_openForm = new AboutBox1();
				_openForm.FormClosed += delegate { _openForm = null; };
			}
			return _openForm;
		}



		private void AboutBox1_FormClosed(object sender, FormClosedEventArgs e)
		{
			_myForm = null;
		}

		private void AboutBox1_FormShown(object sender, EventArgs e)
		{
			if (_myForm != null)
				_myForm.BringToFront();
			else
				_myForm = this;
		}



	}
}
