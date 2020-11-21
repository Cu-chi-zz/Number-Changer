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
            this.DescLabelInputLine = new System.Windows.Forms.Label();
            this.ProgressOfLines = new System.Windows.Forms.ProgressBar();
            this.TipVar = new System.Windows.Forms.Label();
            this.ProblemsMsg = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.finishedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Master Black Personal Use", 26.25F, System.Drawing.FontStyle.Bold);
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.buttonStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonStart.Location = new System.Drawing.Point(12, 128);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(540, 36);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // ToChangeTextBox
            // 
            this.ToChangeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.ToChangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToChangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ToChangeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ToChangeTextBox.Location = new System.Drawing.Point(12, 31);
            this.ToChangeTextBox.Name = "ToChangeTextBox";
            this.ToChangeTextBox.Size = new System.Drawing.Size(394, 26);
            this.ToChangeTextBox.TabIndex = 3;
            // 
            // NumberLinesTextBox
            // 
            this.NumberLinesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.NumberLinesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberLinesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NumberLinesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.NumberLinesTextBox.Location = new System.Drawing.Point(412, 31);
            this.NumberLinesTextBox.Name = "NumberLinesTextBox";
            this.NumberLinesTextBox.Size = new System.Drawing.Size(140, 26);
            this.NumberLinesTextBox.TabIndex = 4;
            this.NumberLinesTextBox.Text = "1";
            // 
            // DescLabelInputText
            // 
            this.DescLabelInputText.AutoSize = true;
            this.DescLabelInputText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic);
            this.DescLabelInputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.DescLabelInputText.Location = new System.Drawing.Point(7, -1);
            this.DescLabelInputText.Name = "DescLabelInputText";
            this.DescLabelInputText.Size = new System.Drawing.Size(174, 29);
            this.DescLabelInputText.TabIndex = 5;
            this.DescLabelInputText.Text = "Write your text...";
            // 
            // DescLabelInputLine
            // 
            this.DescLabelInputLine.AutoSize = true;
            this.DescLabelInputLine.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic);
            this.DescLabelInputLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.DescLabelInputLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DescLabelInputLine.Location = new System.Drawing.Point(407, -1);
            this.DescLabelInputLine.Name = "DescLabelInputLine";
            this.DescLabelInputLine.Size = new System.Drawing.Size(151, 29);
            this.DescLabelInputLine.TabIndex = 6;
            this.DescLabelInputLine.Text = "Lines to create";
            // 
            // ProgressOfLines
            // 
            this.ProgressOfLines.Location = new System.Drawing.Point(12, 99);
            this.ProgressOfLines.Name = "ProgressOfLines";
            this.ProgressOfLines.Size = new System.Drawing.Size(540, 23);
            this.ProgressOfLines.TabIndex = 7;
            this.ProgressOfLines.Visible = false;
            // 
            // TipVar
            // 
            this.TipVar.AutoSize = true;
            this.TipVar.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.TipVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TipVar.Location = new System.Drawing.Point(7, 60);
            this.TipVar.Name = "TipVar";
            this.TipVar.Size = new System.Drawing.Size(343, 25);
            this.TipVar.TabIndex = 8;
            this.TipVar.Text = "The variable for the number is @(*)";
            // 
            // ProblemsMsg
            // 
            this.ProblemsMsg.AutoSize = true;
            this.ProblemsMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ProblemsMsg.Location = new System.Drawing.Point(383, 169);
            this.ProblemsMsg.Name = "ProblemsMsg";
            this.ProblemsMsg.Size = new System.Drawing.Size(184, 13);
            this.ProblemsMsg.TabIndex = 9;
            this.ProblemsMsg.Text = "Any problems? Report them on github";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Version.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Version.Location = new System.Drawing.Point(0, 169);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(38, 13);
            this.Version.TabIndex = 10;
            this.Version.Text = "V1.0.2";
            // 
            // finishedLabel
            // 
            this.finishedLabel.AutoSize = true;
            this.finishedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.finishedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.finishedLabel.Location = new System.Drawing.Point(514, 83);
            this.finishedLabel.Name = "finishedLabel";
            this.finishedLabel.Size = new System.Drawing.Size(36, 13);
            this.finishedLabel.TabIndex = 11;
            this.finishedLabel.Text = "Done!";
            this.finishedLabel.Visible = false;
            // 
            // InterFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(564, 185);
            this.Controls.Add(this.finishedLabel);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.ProblemsMsg);
            this.Controls.Add(this.TipVar);
            this.Controls.Add(this.ProgressOfLines);
            this.Controls.Add(this.DescLabelInputLine);
            this.Controls.Add(this.DescLabelInputText);
            this.Controls.Add(this.NumberLinesTextBox);
            this.Controls.Add(this.ToChangeTextBox);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(580, 224);
            this.MinimumSize = new System.Drawing.Size(580, 224);
            this.Name = "InterFace";
            this.Text = "Number Changer - V1.0.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox ToChangeTextBox;
        private System.Windows.Forms.TextBox NumberLinesTextBox;
        private System.Windows.Forms.Label DescLabelInputText;
        private System.Windows.Forms.Label DescLabelInputLine;
        private System.Windows.Forms.ProgressBar ProgressOfLines;
        private System.Windows.Forms.Label TipVar;
        private System.Windows.Forms.Label ProblemsMsg;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label finishedLabel;
    }
}

