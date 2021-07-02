namespace AbuEhabScreenRecorder
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.lblTimer);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.btnResume);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRecord);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(226, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shahzaib Screen Recorder";
            // 
            // btnPause
            // 
            this.btnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPause.Image = global::AbuEhabScreenRecorder.Properties.Resources.Player_Pause;
            this.btnPause.Location = new System.Drawing.Point(71, 25);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(37, 43);
            this.btnPause.TabIndex = 8;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTimer.Location = new System.Drawing.Point(67, 120);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(15, 22);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = ".";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(21, 91);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(185, 26);
            this.txtFileName.TabIndex = 6;
            this.txtFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // btnResume
            // 
            this.btnResume.Image = global::AbuEhabScreenRecorder.Properties.Resources.Player_Play;
            this.btnResume.Location = new System.Drawing.Point(115, 26);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(38, 42);
            this.btnResume.TabIndex = 9;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::AbuEhabScreenRecorder.Properties.Resources.Player_Stop;
            this.btnStop.Location = new System.Drawing.Point(159, 26);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(47, 40);
            this.btnStop.TabIndex = 10;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Image = global::AbuEhabScreenRecorder.Properties.Resources.Player_Record;
            this.btnRecord.Location = new System.Drawing.Point(21, 26);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(43, 40);
            this.btnRecord.TabIndex = 11;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(263, 178);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnRecord;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnResume;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Timer timer1;
	}
}

