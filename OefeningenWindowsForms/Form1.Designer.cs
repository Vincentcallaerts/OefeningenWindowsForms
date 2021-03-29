
namespace OefeningenWindowsForms
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(346, 196);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInput.TabIndex = 1;
            this.txtBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxInput_KeyDown);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(36, 117);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(168, 178);
            this.txtBox.TabIndex = 2;
            // 
            // btClick
            // 
            this.btClick.Location = new System.Drawing.Point(359, 222);
            this.btClick.Name = "btClick";
            this.btClick.Size = new System.Drawing.Size(75, 23);
            this.btClick.TabIndex = 3;
            this.btClick.Text = "Click";
            this.btClick.UseVisualStyleBackColor = true;
            this.btClick.Click += new System.EventHandler(this.btClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClick);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.txtBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btClick;
    }
}

