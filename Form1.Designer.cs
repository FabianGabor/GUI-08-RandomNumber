namespace GUI_08_RandomNumber
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
            this.panelSetup = new System.Windows.Forms.Panel();
            this.buttonSetupDone = new System.Windows.Forms.Button();
            this.textBoxNumberToGuess = new System.Windows.Forms.TextBox();
            this.labelToGuess = new System.Windows.Forms.Label();
            this.panelGuess = new System.Windows.Forms.Panel();
            this.buttonSubmitGuess = new System.Windows.Forms.Button();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.labelGuess = new System.Windows.Forms.Label();
            this.panelSetup.SuspendLayout();
            this.panelGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSetup
            // 
            this.panelSetup.Controls.Add(this.buttonSetupDone);
            this.panelSetup.Controls.Add(this.textBoxNumberToGuess);
            this.panelSetup.Controls.Add(this.labelToGuess);
            this.panelSetup.Location = new System.Drawing.Point(9, 12);
            this.panelSetup.Name = "panelSetup";
            this.panelSetup.Size = new System.Drawing.Size(776, 426);
            this.panelSetup.TabIndex = 0;
            // 
            // buttonSetupDone
            // 
            this.buttonSetupDone.Location = new System.Drawing.Point(322, 226);
            this.buttonSetupDone.Name = "buttonSetupDone";
            this.buttonSetupDone.Size = new System.Drawing.Size(133, 37);
            this.buttonSetupDone.TabIndex = 7;
            this.buttonSetupDone.Text = "Done";
            this.buttonSetupDone.UseVisualStyleBackColor = true;
            this.buttonSetupDone.Click += new System.EventHandler(this.buttonSetupDone_Click);
            // 
            // textBoxNumberToGuess
            // 
            this.textBoxNumberToGuess.Location = new System.Drawing.Point(321, 200);
            this.textBoxNumberToGuess.Name = "textBoxNumberToGuess";
            this.textBoxNumberToGuess.Size = new System.Drawing.Size(134, 20);
            this.textBoxNumberToGuess.TabIndex = 6;
            // 
            // labelToGuess
            // 
            this.labelToGuess.Location = new System.Drawing.Point(320, 180);
            this.labelToGuess.Name = "labelToGuess";
            this.labelToGuess.Size = new System.Drawing.Size(125, 15);
            this.labelToGuess.TabIndex = 5;
            this.labelToGuess.Text = "Enter number to guess";
            // 
            // panelGuess
            // 
            this.panelGuess.Controls.Add(this.buttonSubmitGuess);
            this.panelGuess.Controls.Add(this.textBoxGuess);
            this.panelGuess.Controls.Add(this.labelGuess);
            this.panelGuess.Location = new System.Drawing.Point(12, 12);
            this.panelGuess.Name = "panelGuess";
            this.panelGuess.Size = new System.Drawing.Size(776, 426);
            this.panelGuess.TabIndex = 4;
            this.panelGuess.Visible = false;
            // 
            // buttonSubmitGuess
            // 
            this.buttonSubmitGuess.Location = new System.Drawing.Point(320, 212);
            this.buttonSubmitGuess.Name = "buttonSubmitGuess";
            this.buttonSubmitGuess.Size = new System.Drawing.Size(133, 37);
            this.buttonSubmitGuess.TabIndex = 6;
            this.buttonSubmitGuess.Text = "Done";
            this.buttonSubmitGuess.UseVisualStyleBackColor = true;
            this.buttonSubmitGuess.Click += new System.EventHandler(this.buttonSubmitGuess_Click);
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(320, 186);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(134, 20);
            this.textBoxGuess.TabIndex = 5;
            // 
            // labelGuess
            // 
            this.labelGuess.Location = new System.Drawing.Point(320, 168);
            this.labelGuess.Name = "labelGuess";
            this.labelGuess.Size = new System.Drawing.Size(125, 15);
            this.labelGuess.TabIndex = 4;
            this.labelGuess.Text = "Your guess";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSetup);
            this.Controls.Add(this.panelGuess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSetup.ResumeLayout(false);
            this.panelSetup.PerformLayout();
            this.panelGuess.ResumeLayout(false);
            this.panelGuess.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBoxNumberToGuess;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.Button buttonSubmitGuess;
        private System.Windows.Forms.TextBox textBoxGuess;
        
 
        private System.Windows.Forms.Panel panelGuess;
        
        
        private System.Windows.Forms.Panel panelSetup;
        private System.Windows.Forms.Label labelToGuess;
        private System.Windows.Forms.Button buttonSetupDone;

        #endregion
    }
}