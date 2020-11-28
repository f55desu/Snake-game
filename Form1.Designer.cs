namespace Snake
{
    partial class Snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake));
            this.play = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.ControlText;
            this.play.Font = new System.Drawing.Font("Porsche", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.play.ForeColor = System.Drawing.SystemColors.Window;
            this.play.Location = new System.Drawing.Point(517, 265);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(172, 35);
            this.play.TabIndex = 0;
            this.play.Text = "Start";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ControlText;
            this.exit.Font = new System.Drawing.Font("Porsche", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.SystemColors.Window;
            this.exit.Location = new System.Drawing.Point(517, 349);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(172, 37);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.Font = new System.Drawing.Font("Porsche", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(164, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Snake The Game";
            // 
            // options
            // 
            this.options.BackColor = System.Drawing.SystemColors.ControlText;
            this.options.Font = new System.Drawing.Font("Porsche", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.options.ForeColor = System.Drawing.SystemColors.Window;
            this.options.Location = new System.Drawing.Point(517, 306);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(172, 37);
            this.options.TabIndex = 3;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = false;
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 741);
            this.Controls.Add(this.options);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.play);
            this.Name = "Snake";
            this.Text = "Snake The Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button options;
    }
}