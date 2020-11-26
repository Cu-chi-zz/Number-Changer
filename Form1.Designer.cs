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
            this.TookLabel = new System.Windows.Forms.Label();
            this.ExampleButton = new System.Windows.Forms.Button();
            this.seeEnteredTextButton = new System.Windows.Forms.Button();
            this.GoToFolderButton = new System.Windows.Forms.Button();
            this.ClearOutputFolderButton = new System.Windows.Forms.Button();
            this.CopyCreatedFileButton = new System.Windows.Forms.Button();
            this.lineBreakCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Master Black Personal Use", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.buttonStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonStart.Location = new System.Drawing.Point(12, 130);
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
            this.ToChangeTextBox.Location = new System.Drawing.Point(12, 30);
            this.ToChangeTextBox.Multiline = true;
            this.ToChangeTextBox.Name = "ToChangeTextBox";
            this.ToChangeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ToChangeTextBox.Size = new System.Drawing.Size(394, 26);
            this.ToChangeTextBox.TabIndex = 3;
            // 
            // NumberLinesTextBox
            // 
            this.NumberLinesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.NumberLinesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberLinesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NumberLinesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.NumberLinesTextBox.Location = new System.Drawing.Point(410, 30);
            this.NumberLinesTextBox.Name = "NumberLinesTextBox";
            this.NumberLinesTextBox.Size = new System.Drawing.Size(54, 26);
            this.NumberLinesTextBox.TabIndex = 4;
            this.NumberLinesTextBox.Text = "1";
            // 
            // DescLabelInputText
            // 
            this.DescLabelInputText.AutoSize = true;
            this.DescLabelInputText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic);
            this.DescLabelInputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.DescLabelInputText.Location = new System.Drawing.Point(7, -2);
            this.DescLabelInputText.Name = "DescLabelInputText";
            this.DescLabelInputText.Size = new System.Drawing.Size(156, 29);
            this.DescLabelInputText.TabIndex = 5;
            this.DescLabelInputText.Text = "Write your text";
            // 
            // DescLabelInputLine
            // 
            this.DescLabelInputLine.AutoSize = true;
            this.DescLabelInputLine.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic);
            this.DescLabelInputLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.DescLabelInputLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DescLabelInputLine.Location = new System.Drawing.Point(407, -2);
            this.DescLabelInputLine.Name = "DescLabelInputLine";
            this.DescLabelInputLine.Size = new System.Drawing.Size(154, 29);
            this.DescLabelInputLine.TabIndex = 6;
            this.DescLabelInputLine.Text = "Repeat X times";
            // 
            // ProgressOfLines
            // 
            this.ProgressOfLines.Location = new System.Drawing.Point(12, 101);
            this.ProgressOfLines.MarqueeAnimationSpeed = 1;
            this.ProgressOfLines.Maximum = 0;
            this.ProgressOfLines.Name = "ProgressOfLines";
            this.ProgressOfLines.Size = new System.Drawing.Size(540, 23);
            this.ProgressOfLines.Step = 1;
            this.ProgressOfLines.TabIndex = 7;
            this.ProgressOfLines.Visible = false;
            // 
            // TipVar
            // 
            this.TipVar.AutoSize = true;
            this.TipVar.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.TipVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TipVar.Location = new System.Drawing.Point(7, 62);
            this.TipVar.Name = "TipVar";
            this.TipVar.Size = new System.Drawing.Size(343, 25);
            this.TipVar.TabIndex = 8;
            this.TipVar.Text = "The variable for the number is @(*)";
            // 
            // ProblemsMsg
            // 
            this.ProblemsMsg.AutoSize = true;
            this.ProblemsMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProblemsMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ProblemsMsg.Location = new System.Drawing.Point(382, 192);
            this.ProblemsMsg.Name = "ProblemsMsg";
            this.ProblemsMsg.Size = new System.Drawing.Size(184, 13);
            this.ProblemsMsg.TabIndex = 9;
            this.ProblemsMsg.Text = "Any problems? Report them on github";
            this.ProblemsMsg.Click += new System.EventHandler(this.ProblemsMsg_Click);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Version.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Version.Location = new System.Drawing.Point(0, 192);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(36, 13);
            this.Version.TabIndex = 10;
            this.Version.Text = "Cuchi\'";
            // 
            // finishedLabel
            // 
            this.finishedLabel.AutoSize = true;
            this.finishedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.finishedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.finishedLabel.Location = new System.Drawing.Point(514, 87);
            this.finishedLabel.Name = "finishedLabel";
            this.finishedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.finishedLabel.Size = new System.Drawing.Size(36, 13);
            this.finishedLabel.TabIndex = 11;
            this.finishedLabel.Text = "Done!";
            this.finishedLabel.Visible = false;
            // 
            // TookLabel
            // 
            this.TookLabel.AutoSize = true;
            this.TookLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TookLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TookLabel.Location = new System.Drawing.Point(9, 87);
            this.TookLabel.Name = "TookLabel";
            this.TookLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TookLabel.Size = new System.Drawing.Size(0, 13);
            this.TookLabel.TabIndex = 12;
            this.TookLabel.Visible = false;
            // 
            // ExampleButton
            // 
            this.ExampleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.ExampleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExampleButton.FlatAppearance.BorderSize = 0;
            this.ExampleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.ExampleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.ExampleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExampleButton.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ExampleButton.Location = new System.Drawing.Point(161, 4);
            this.ExampleButton.Name = "ExampleButton";
            this.ExampleButton.Size = new System.Drawing.Size(70, 22);
            this.ExampleButton.TabIndex = 13;
            this.ExampleButton.Text = "Example";
            this.ExampleButton.UseVisualStyleBackColor = false;
            this.ExampleButton.Click += new System.EventHandler(this.ExampleButton_Click);
            // 
            // seeEnteredTextButton
            // 
            this.seeEnteredTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.seeEnteredTextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeEnteredTextButton.FlatAppearance.BorderSize = 0;
            this.seeEnteredTextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.seeEnteredTextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.seeEnteredTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeEnteredTextButton.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeEnteredTextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.seeEnteredTextButton.Location = new System.Drawing.Point(237, 4);
            this.seeEnteredTextButton.Name = "seeEnteredTextButton";
            this.seeEnteredTextButton.Size = new System.Drawing.Size(169, 22);
            this.seeEnteredTextButton.TabIndex = 14;
            this.seeEnteredTextButton.Text = "See what you\'ve entered";
            this.seeEnteredTextButton.UseVisualStyleBackColor = false;
            this.seeEnteredTextButton.Click += new System.EventHandler(this.seeEnteredTextButton_Click);
            // 
            // GoToFolderButton
            // 
            this.GoToFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.GoToFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToFolderButton.FlatAppearance.BorderSize = 0;
            this.GoToFolderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.GoToFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.GoToFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToFolderButton.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.GoToFolderButton.Location = new System.Drawing.Point(356, 62);
            this.GoToFolderButton.Name = "GoToFolderButton";
            this.GoToFolderButton.Size = new System.Drawing.Size(194, 22);
            this.GoToFolderButton.TabIndex = 15;
            this.GoToFolderButton.Text = "Go to Folder";
            this.GoToFolderButton.UseVisualStyleBackColor = false;
            this.GoToFolderButton.Click += new System.EventHandler(this.GoToFolderButton_Click);
            // 
            // ClearOutputFolderButton
            // 
            this.ClearOutputFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.ClearOutputFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearOutputFolderButton.FlatAppearance.BorderSize = 0;
            this.ClearOutputFolderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.ClearOutputFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.ClearOutputFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearOutputFolderButton.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearOutputFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClearOutputFolderButton.Location = new System.Drawing.Point(285, 169);
            this.ClearOutputFolderButton.Name = "ClearOutputFolderButton";
            this.ClearOutputFolderButton.Size = new System.Drawing.Size(267, 22);
            this.ClearOutputFolderButton.TabIndex = 16;
            this.ClearOutputFolderButton.Text = "CLEAR OUTPUT FOLDER";
            this.ClearOutputFolderButton.UseVisualStyleBackColor = false;
            this.ClearOutputFolderButton.Click += new System.EventHandler(this.ClearOutputFolderButton_Click);
            // 
            // CopyCreatedFileButton
            // 
            this.CopyCreatedFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.CopyCreatedFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyCreatedFileButton.Enabled = false;
            this.CopyCreatedFileButton.FlatAppearance.BorderSize = 0;
            this.CopyCreatedFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.CopyCreatedFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.CopyCreatedFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyCreatedFileButton.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyCreatedFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.CopyCreatedFileButton.Location = new System.Drawing.Point(12, 169);
            this.CopyCreatedFileButton.Name = "CopyCreatedFileButton";
            this.CopyCreatedFileButton.Size = new System.Drawing.Size(267, 22);
            this.CopyCreatedFileButton.TabIndex = 17;
            this.CopyCreatedFileButton.Text = "COPY CREATED FILE";
            this.CopyCreatedFileButton.UseVisualStyleBackColor = false;
            this.CopyCreatedFileButton.Click += new System.EventHandler(this.CopyCreatedFileButton_Click);
            // 
            // lineBreakCheckBox
            // 
            this.lineBreakCheckBox.AutoSize = true;
            this.lineBreakCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.lineBreakCheckBox.FlatAppearance.BorderSize = 0;
            this.lineBreakCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.lineBreakCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.lineBreakCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(146)))), ((int)(((byte)(189)))));
            this.lineBreakCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineBreakCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBreakCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lineBreakCheckBox.Location = new System.Drawing.Point(470, 32);
            this.lineBreakCheckBox.Name = "lineBreakCheckBox";
            this.lineBreakCheckBox.Size = new System.Drawing.Size(92, 22);
            this.lineBreakCheckBox.TabIndex = 18;
            this.lineBreakCheckBox.Text = "Line break";
            this.lineBreakCheckBox.UseVisualStyleBackColor = true;
            // 
            // InterFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(564, 206);
            this.Controls.Add(this.lineBreakCheckBox);
            this.Controls.Add(this.CopyCreatedFileButton);
            this.Controls.Add(this.ClearOutputFolderButton);
            this.Controls.Add(this.GoToFolderButton);
            this.Controls.Add(this.seeEnteredTextButton);
            this.Controls.Add(this.ExampleButton);
            this.Controls.Add(this.TookLabel);
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
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(580, 245);
            this.MinimumSize = new System.Drawing.Size(580, 245);
            this.Name = "InterFace";
            this.Text = "Number Changer";
            this.Load += new System.EventHandler(this.InterFace_Load);
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
        private System.Windows.Forms.Label TookLabel;
        private System.Windows.Forms.Button ExampleButton;
        private System.Windows.Forms.Button seeEnteredTextButton;
        private System.Windows.Forms.Button GoToFolderButton;
        private System.Windows.Forms.Button ClearOutputFolderButton;
        private System.Windows.Forms.Button CopyCreatedFileButton;
        private System.Windows.Forms.CheckBox lineBreakCheckBox;
    }
}

