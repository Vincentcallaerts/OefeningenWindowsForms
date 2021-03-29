
namespace Oefening_3
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
            this.btKnop = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btKnop
            // 
            this.btKnop.Location = new System.Drawing.Point(325, 190);
            this.btKnop.Name = "btKnop";
            this.btKnop.Size = new System.Drawing.Size(158, 23);
            this.btKnop.TabIndex = 0;
            this.btKnop.Text = "Click";
            this.btKnop.UseVisualStyleBackColor = true;
            this.btKnop.Click += new System.EventHandler(this.btKnop_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(26, 118);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(139, 173);
            this.lstBox.TabIndex = 1;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(350, 164);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btKnop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btKnop;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.TextBox txtBox;
    }
}

