namespace Magic8Ball
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ballButton = new System.Windows.Forms.Button();
            this.fortuneLabel = new System.Windows.Forms.Label();
            this.fortuneOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ballButton
            // 
            this.ballButton.BackColor = System.Drawing.Color.Transparent;
            this.ballButton.FlatAppearance.BorderSize = 0;
            this.ballButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ballButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ballButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ballButton.ForeColor = System.Drawing.Color.Transparent;
            this.ballButton.Image = global::Magic8Ball.Properties.Resources.clickBall1;
            this.ballButton.Location = new System.Drawing.Point(116, 99);
            this.ballButton.Name = "ballButton";
            this.ballButton.Size = new System.Drawing.Size(300, 300);
            this.ballButton.TabIndex = 0;
            this.ballButton.UseVisualStyleBackColor = false;
            this.ballButton.Click += new System.EventHandler(this.ballButton_Click);
            // 
            // fortuneLabel
            // 
            this.fortuneLabel.BackColor = System.Drawing.Color.Transparent;
            this.fortuneLabel.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fortuneLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fortuneLabel.Location = new System.Drawing.Point(96, 27);
            this.fortuneLabel.Name = "fortuneLabel";
            this.fortuneLabel.Size = new System.Drawing.Size(340, 69);
            this.fortuneLabel.TabIndex = 1;
            this.fortuneLabel.Text = "I know your fortune...\r\nAsk me a question\r\n";
            this.fortuneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fortuneOutput
            // 
            this.fortuneOutput.BackColor = System.Drawing.Color.Transparent;
            this.fortuneOutput.Font = new System.Drawing.Font("Onyx", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fortuneOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fortuneOutput.Location = new System.Drawing.Point(96, 422);
            this.fortuneOutput.Name = "fortuneOutput";
            this.fortuneOutput.Size = new System.Drawing.Size(340, 69);
            this.fortuneOutput.TabIndex = 2;
            this.fortuneOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(532, 519);
            this.Controls.Add(this.fortuneOutput);
            this.Controls.Add(this.fortuneLabel);
            this.Controls.Add(this.ballButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Magic Eight Ball";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ballButton;
        private System.Windows.Forms.Label fortuneLabel;
        private System.Windows.Forms.Label fortuneOutput;
    }
}

