namespace Toren_van_Hanoi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aantalSchijvenLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.aantalSchijvenTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.goButton);
            this.groupBox1.Controls.Add(this.aantalSchijvenTextBox);
            this.groupBox1.Controls.Add(this.answerLabel);
            this.groupBox1.Controls.Add(this.aantalSchijvenLabel);
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "For-loop";
            // 
            // aantalSchijvenLabel
            // 
            this.aantalSchijvenLabel.AutoSize = true;
            this.aantalSchijvenLabel.Location = new System.Drawing.Point(50, 40);
            this.aantalSchijvenLabel.Name = "aantalSchijvenLabel";
            this.aantalSchijvenLabel.Size = new System.Drawing.Size(82, 13);
            this.aantalSchijvenLabel.TabIndex = 0;
            this.aantalSchijvenLabel.Text = "Aantal schijven:";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(77, 82);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(55, 13);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "Antwoord:";
            // 
            // aantalSchijvenTextBox
            // 
            this.aantalSchijvenTextBox.Location = new System.Drawing.Point(138, 33);
            this.aantalSchijvenTextBox.Name = "aantalSchijvenTextBox";
            this.aantalSchijvenTextBox.Size = new System.Drawing.Size(117, 20);
            this.aantalSchijvenTextBox.TabIndex = 2;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(261, 31);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(46, 23);
            this.goButton.TabIndex = 3;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(170, 155);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(82, 13);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Tijdsberekening";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 348);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox aantalSchijvenTextBox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label aantalSchijvenLabel;
    }
}

