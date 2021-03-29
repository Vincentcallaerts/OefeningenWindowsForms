
namespace Oefening_2
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
            this.cbBox = new System.Windows.Forms.ComboBox();
            this.BtKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbBox
            // 
            this.cbBox.FormattingEnabled = true;
            this.cbBox.Items.AddRange(new object[] {
            "Ja",
            "Nee",
            "Nooit",
            "Mss"});
            this.cbBox.Location = new System.Drawing.Point(279, 143);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(217, 21);
            this.cbBox.TabIndex = 0;
            // 
            // BtKnop
            // 
            this.BtKnop.Location = new System.Drawing.Point(279, 206);
            this.BtKnop.Name = "BtKnop";
            this.BtKnop.Size = new System.Drawing.Size(217, 23);
            this.BtKnop.TabIndex = 1;
            this.BtKnop.Text = "Delete";
            this.BtKnop.UseVisualStyleBackColor = true;
            this.BtKnop.Click += new System.EventHandler(this.BtKnop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtKnop);
            this.Controls.Add(this.cbBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBox;
        private System.Windows.Forms.Button BtKnop;
    }
}

