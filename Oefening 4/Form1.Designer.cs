
namespace Oefening_4
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
            this.cbNamen = new System.Windows.Forms.ComboBox();
            this.btInput = new System.Windows.Forms.Button();
            this.btAanpassen = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbNamen
            // 
            this.cbNamen.FormattingEnabled = true;
            this.cbNamen.Location = new System.Drawing.Point(12, 97);
            this.cbNamen.Name = "cbNamen";
            this.cbNamen.Size = new System.Drawing.Size(121, 21);
            this.cbNamen.TabIndex = 0;
            // 
            // btInput
            // 
            this.btInput.Location = new System.Drawing.Point(12, 68);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(161, 23);
            this.btInput.TabIndex = 1;
            this.btInput.Text = "Info geselecteerde gebruiker";
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // btAanpassen
            // 
            this.btAanpassen.Location = new System.Drawing.Point(12, 240);
            this.btAanpassen.Name = "btAanpassen";
            this.btAanpassen.Size = new System.Drawing.Size(75, 23);
            this.btAanpassen.TabIndex = 2;
            this.btAanpassen.Text = "Aanpasknop";
            this.btAanpassen.UseVisualStyleBackColor = true;
            this.btAanpassen.Click += new System.EventHandler(this.btAanpassen_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(12, 185);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(100, 20);
            this.txtNewName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Voornaam";
            // 
            // txtNewLastName
            // 
            this.txtNewLastName.Location = new System.Drawing.Point(12, 211);
            this.txtNewLastName.Name = "txtNewLastName";
            this.txtNewLastName.Size = new System.Drawing.Size(100, 20);
            this.txtNewLastName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Achternaam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.btAanpassen);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.cbNamen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNamen;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.Button btAanpassen;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewLastName;
        private System.Windows.Forms.Label label2;
    }
}

