namespace PrihlasovaniUzivatelu
{
    partial class Form2
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
            pictureSlot1 = new PictureBox();
            pictureSlot2 = new PictureBox();
            pictureSlot3 = new PictureBox();
            RerollButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureSlot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot3).BeginInit();
            SuspendLayout();
            // 
            // pictureSlot1
            // 
            pictureSlot1.Location = new Point(229, 150);
            pictureSlot1.Name = "pictureSlot1";
            pictureSlot1.Size = new Size(113, 106);
            pictureSlot1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot1.TabIndex = 0;
            pictureSlot1.TabStop = false;
            // 
            // pictureSlot2
            // 
            pictureSlot2.Location = new Point(348, 150);
            pictureSlot2.Name = "pictureSlot2";
            pictureSlot2.Size = new Size(113, 106);
            pictureSlot2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot2.TabIndex = 1;
            pictureSlot2.TabStop = false;
            // 
            // pictureSlot3
            // 
            pictureSlot3.Location = new Point(467, 150);
            pictureSlot3.Name = "pictureSlot3";
            pictureSlot3.Size = new Size(113, 106);
            pictureSlot3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot3.TabIndex = 2;
            pictureSlot3.TabStop = false;
            // 
            // RerollButton
            // 
            RerollButton.Location = new Point(333, 275);
            RerollButton.Name = "RerollButton";
            RerollButton.Size = new Size(137, 57);
            RerollButton.TabIndex = 3;
            RerollButton.Text = "Reroll";
            RerollButton.UseVisualStyleBackColor = true;
            RerollButton.Click += RerollButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RerollButton);
            Controls.Add(pictureSlot3);
            Controls.Add(pictureSlot2);
            Controls.Add(pictureSlot1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureSlot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureSlot1;
        private PictureBox pictureSlot2;
        private PictureBox pictureSlot3;
        private Button RerollButton;
    }
}