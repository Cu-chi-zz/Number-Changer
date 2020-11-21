namespace Number_Changer
{
    partial class InterFace
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterFace));
            this.buttonStart = new System.Windows.Forms.Button();
            this.ToChangeTextBox = new System.Windows.Forms.TextBox();
            this.NumberLinesTextBox = new System.Windows.Forms.TextBox();
            this.DescLabelInputText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressOfLines = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(84)))), ((int)(((byte)(201)))));
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // ToChangeTextBox
            // 
            this.ToChangeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ToChangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ToChangeTextBox, "ToChangeTextBox");
            this.ToChangeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(84)))), ((int)(((byte)(201)))));
            this.ToChangeTextBox.Name = "ToChangeTextBox";
            // 
            // NumberLinesTextBox
            // 
            this.NumberLinesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(84)))), ((int)(((byte)(201)))));
            this.NumberLinesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.NumberLinesTextBox, "NumberLinesTextBox");
            this.NumberLinesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NumberLinesTextBox.Name = "NumberLinesTextBox";
            // 
            // DescLabelInputText
            // 
            resources.ApplyResources(this.DescLabelInputText, "DescLabelInputText");
            this.DescLabelInputText.Name = "DescLabelInputText";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ProgressOfLines
            // 
            resources.ApplyResources(this.ProgressOfLines, "ProgressOfLines");
            this.ProgressOfLines.Name = "ProgressOfLines";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // InterFace
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(84)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProgressOfLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescLabelInputText);
            this.Controls.Add(this.NumberLinesTextBox);
            this.Controls.Add(this.ToChangeTextBox);
            this.Controls.Add(this.buttonStart);
            this.MaximizeBox = false;
            this.Name = "InterFace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox ToChangeTextBox;
        private System.Windows.Forms.TextBox NumberLinesTextBox;
        private System.Windows.Forms.Label DescLabelInputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ProgressOfLines;
        private System.Windows.Forms.Label label2;
    }
}

