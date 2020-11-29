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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Field));
            this.Head = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Score_Label = new System.Windows.Forms.Label();
            this.Menu_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Head)).BeginInit();
            this.SuspendLayout();
            // 
            // Head
            // 
            this.Head.Image = ((System.Drawing.Image)(resources.GetObject("Head.Image")));
            this.Head.Location = new System.Drawing.Point(217, 151);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(21, 20);
            this.Head.TabIndex = 0;
            this.Head.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 300;
            // 
            // Score_Label
            // 
            this.Score_Label.AutoSize = true;
            this.Score_Label.BackColor = System.Drawing.Color.GreenYellow;
            this.Score_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Score_Label.Location = new System.Drawing.Point(11, 9);
            this.Score_Label.Name = "Score_Label";
            this.Score_Label.Size = new System.Drawing.Size(64, 20);
            this.Score_Label.TabIndex = 1;
            this.Score_Label.Text = "Score:";
            this.Score_Label.Click += new System.EventHandler(this.Score_Label_Click);
            // 
            // Menu_button
            // 
            this.Menu_button.BackColor = System.Drawing.SystemColors.ControlText;
            this.Menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Menu_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu_button.Location = new System.Drawing.Point(1, 365);
            this.Menu_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(97, 35);
            this.Menu_button.TabIndex = 2;
            this.Menu_button.Text = "Menu";
            this.Menu_button.UseVisualStyleBackColor = false;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // Field
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(517, 413);
            this.Controls.Add(this.Menu_button);
            this.Controls.Add(this.Score_Label);
            this.Controls.Add(this.Head);
            this.MaximizeBox = false;
            this.Name = "Field";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            ((System.ComponentModel.ISupportInitialize)(this.Head)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Head;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label Score_Label;
        private System.Windows.Forms.Button Menu_button;
    }
}