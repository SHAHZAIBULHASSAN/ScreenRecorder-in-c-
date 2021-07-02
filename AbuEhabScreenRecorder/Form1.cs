using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AbuEhabScreenRecorder
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}
		
		AbuEhabRecorder.RecorderManager recorder = new AbuEhabRecorder.RecorderManager();
		private void Form1_Load(object sender, EventArgs e)
		{
		if(!Directory.Exists (Application .StartupPath + @"\Videos"))
			{
				Directory.CreateDirectory(Application.StartupPath + @"\Videos");
			}
			btnRecord.Enabled = false;
		}

		private void txtFileName_TextChanged(object sender, EventArgs e)
		{
		 if(string.IsNullOrEmpty(txtFileName .Text))
			{
				btnRecord.Enabled = false;
			}else
			{
				btnRecord.Enabled = true;
			}
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			txtFileName.Focus();
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			recorder.PauseRecorder();
			sw.Stop();
		}

		System.Diagnostics.Stopwatch sw = new Stopwatch();
		private void timer1_Tick(object sender, EventArgs e)
		{
			lblTimer.Text = string.Format("{0}:{1}", sw.Elapsed.Seconds, sw.Elapsed.Minutes);
		}

		private void btnResume_Click(object sender, EventArgs e)
		{
			recorder.ContinueRecorder();
			sw.Start();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			recorder.StopRecorder();
			sw.Stop();
		}

		private void btnRecord_Click(object sender, EventArgs e)
		{
			recorder.StartRecorder(Application.StartupPath + @"\Videos\" + txtFileName.Text);

			sw.Start();
			timer1.Enabled = true;
		
			
		}
	}
	
}
