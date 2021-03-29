
namespace NogEenOefening1
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
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btVoegToe = new System.Windows.Forms.Button();
            this.lstBoxActief = new System.Windows.Forms.ListBox();
            this.btnToInactief = new System.Windows.Forms.Button();
            this.btnToActief = new System.Windows.Forms.Button();
            this.lstBoxInactief = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(33, 45);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInput.TabIndex = 0;
            // 
            // btVoegToe
            // 
            this.btVoegToe.Location = new System.Drawing.Point(139, 42);
            this.btVoegToe.Name = "btVoegToe";
            this.btVoegToe.Size = new System.Drawing.Size(75, 23);
            this.btVoegToe.TabIndex = 1;
            this.btVoegToe.Text = "Add";
            this.btVoegToe.UseVisualStyleBackColor = true;
            this.btVoegToe.Click += new System.EventHandler(this.btVoegToe_Click);
            // 
            // lstBoxActief
            // 
            this.lstBoxActief.FormattingEnabled = true;
            this.lstBoxActief.Location = new System.Drawing.Point(33, 83);
            this.lstBoxActief.Name = "lstBoxActief";
            this.lstBoxActief.Size = new System.Drawing.Size(181, 147);
            this.lstBoxActief.TabIndex = 2;
            // 
            // btnToInactief
            // 
            this.btnToInactief.Location = new System.Drawing.Point(220, 131);
            this.btnToInactief.Name = "btnToInactief";
            this.btnToInactief.Size = new System.Drawing.Size(44, 23);
            this.btnToInactief.TabIndex = 3;
            this.btnToInactief.Text = "=>";
            this.btnToInactief.UseVisualStyleBackColor = true;
            this.btnToInactief.Click += new System.EventHandler(this.btnToInactief_Click);
            // 
            // btnToActief
            // 
            this.btnToActief.Location = new System.Drawing.Point(220, 160);
            this.btnToActief.Name = "btnToActief";
            this.btnToActief.Size = new System.Drawing.Size(44, 23);
            this.btnToActief.TabIndex = 4;
            this.btnToActief.Text = "<=";
            this.btnToActief.UseVisualStyleBackColor = true;
            this.btnToActief.Click += new System.EventHandler(this.btnToActief_Click);
            // 
            // lstBoxInactief
            // 
            this.lstBoxInactief.FormattingEnabled = true;
            this.lstBoxInactief.Location = new System.Drawing.Point(270, 83);
            this.lstBoxInactief.Name = "lstBoxInactief";
            this.lstBoxInactief.Size = new System.Drawing.Size(181, 147);
            this.lstBoxInactief.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxInactief);
            this.Controls.Add(this.btnToActief);
            this.Controls.Add(this.btnToInactief);
            this.Controls.Add(this.lstBoxActief);
            this.Controls.Add(this.btVoegToe);
            this.Controls.Add(this.txtBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Button btVoegToe;
        private System.Windows.Forms.ListBox lstBoxActief;
        private System.Windows.Forms.Button btnToInactief;
        private System.Windows.Forms.Button btnToActief;
        private System.Windows.Forms.ListBox lstBoxInactief;
    }
}

