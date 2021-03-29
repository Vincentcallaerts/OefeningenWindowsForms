
namespace AdvancedOefening
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
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.cbBoxWerknemers = new System.Windows.Forms.ComboBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbBox
            // 
            this.cbBox.FormattingEnabled = true;
            this.cbBox.Location = new System.Drawing.Point(13, 13);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(121, 21);
            this.cbBox.TabIndex = 0;
            this.cbBox.SelectedIndexChanged += new System.EventHandler(this.cbBox_SelectedIndexChanged);
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Location = new System.Drawing.Point(12, 190);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ReadOnly = true;
            this.txtBoxOutput.Size = new System.Drawing.Size(340, 20);
            this.txtBoxOutput.TabIndex = 1;
            // 
            // cbBoxWerknemers
            // 
            this.cbBoxWerknemers.FormattingEnabled = true;
            this.cbBoxWerknemers.Location = new System.Drawing.Point(13, 41);
            this.cbBoxWerknemers.Name = "cbBoxWerknemers";
            this.cbBoxWerknemers.Size = new System.Drawing.Size(121, 21);
            this.cbBoxWerknemers.TabIndex = 2;
            this.cbBoxWerknemers.SelectedIndexChanged += new System.EventHandler(this.cbBoxWerknemers_SelectedIndexChanged);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(183, 41);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(169, 23);
            this.btnToevoegen.TabIndex = 3;
            this.btnToevoegen.Text = "Add Werkgever";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(358, 41);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(203, 23);
            this.btnVerwijderen.TabIndex = 4;
            this.btnVerwijderen.Text = "Verwijder Werkgever";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.cbBoxWerknemers);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.cbBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBox;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.ComboBox cbBoxWerknemers;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}

