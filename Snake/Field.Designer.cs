using System;

namespace Snake
{
	partial class Field
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private EventHandler Field_Load;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Field));
			this.Head = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Head)).BeginInit();
			this.SuspendLayout();
			// 
			// Head
			// 
			this.Head.Image = ((System.Drawing.Image)(resources.GetObject("Head.Image")));
			this.Head.Location = new System.Drawing.Point(217, 151);
			this.Head.Name = "Head";
			this.Head.Size = new System.Drawing.Size(20, 20);
			this.Head.TabIndex = 0;
			this.Head.TabStop = false;
			// 
			// Field
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 420);
			this.Name = "Field";
			this.Text = "Form1";
			this.Controls.Add(Head);
			((System.ComponentModel.ISupportInitialize)(this.Head)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Head;
	}
}