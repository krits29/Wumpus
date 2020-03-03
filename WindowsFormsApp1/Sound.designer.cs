namespace Sound
{
    partial class Sound
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
            this.Create = new System.Windows.Forms.Button();
            this.Bats = new System.Windows.Forms.Button();
            this.Wumpus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(40, 42);
            this.Create.Margin = new System.Windows.Forms.Padding(4);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(211, 68);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create Sound Object";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // Bats
            // 
            this.Bats.Location = new System.Drawing.Point(40, 132);
            this.Bats.Margin = new System.Windows.Forms.Padding(4);
            this.Bats.Name = "Bats";
            this.Bats.Size = new System.Drawing.Size(212, 65);
            this.Bats.TabIndex = 1;
            this.Bats.Text = "Get Bat sound";
            this.Bats.UseVisualStyleBackColor = true;
            this.Bats.Click += new System.EventHandler(this.Bats_Click);
            // 
            // Wumpus
            // 
            this.Wumpus.Location = new System.Drawing.Point(40, 220);
            this.Wumpus.Margin = new System.Windows.Forms.Padding(4);
            this.Wumpus.Name = "Wumpus";
            this.Wumpus.Size = new System.Drawing.Size(205, 68);
            this.Wumpus.TabIndex = 3;
            this.Wumpus.Text = "Get Wumpus Sound";
            this.Wumpus.UseVisualStyleBackColor = true;
            this.Wumpus.Click += new System.EventHandler(this.Wumpus_Click);
            // 
            // Sound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 307);
            this.Controls.Add(this.Wumpus);
            this.Controls.Add(this.Bats);
            this.Controls.Add(this.Create);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sound";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Bats;
        private System.Windows.Forms.Button Wumpus;
    }
}

