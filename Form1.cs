using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Threading;

namespace Number_Changer
{
    public partial class InterFace : Form
    {
        public InterFace()
        {
            InitializeComponent();
        }

        public static string ToChangeEntered = "";
        public static string LinesEntered = "";
        public static string PathAndNameLastFile = "";

        private void buttonStart_Click(object sender, EventArgs e)
        {
            finishedLabel.Visible = false;
            TookLabel.Visible = false;

            string ToChangeEnteredcheck = ToChangeTextBox.Text;
            string LinesEnteredcheck = NumberLinesTextBox.Text;

            if (ToChangeEnteredcheck != ToChangeEntered) { ToChangeEntered = ToChangeEnteredcheck; }
            if (LinesEnteredcheck != LinesEntered) { LinesEntered = LinesEnteredcheck; }

            int lines;
            // Retourne false si le nombre de lignes n'est pas un nombre
            bool isNumericLines = int.TryParse(LinesEntered, out lines);

            // Message d'erreur si texte empty
            if (ToChangeEntered == "")
            {
                MessageBox.Show("Text entered is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check du nombre de lignes entré
            if (LinesEntered == "")
            {
                MessageBox.Show("Number of lines entered is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!isNumericLines)
            {
                MessageBox.Show("Number of lines entered is not a number or is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Int64.Parse(LinesEntered) <= 0)
            {
                MessageBox.Show("Number of lines entered is invalid\nMust be > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProgressOfLines.Visible = true;
            ProgressOfLines.Maximum = Int32.Parse(LinesEntered);

            var worker = new BackgroundWorker();
            // Création d'une instance qui execute la methodes "filesCreateor" a son demarrage
            worker.DoWork += new DoWorkEventHandler(filesCreator);
            // Exectution de la fonctions filesCreator en mode asynchronisé
            worker.RunWorkerAsync();
            // Bloque les changements & boutons durant durant le processus
            ToChangeTextBox.Enabled = false;
            NumberLinesTextBox.Enabled = false;
            buttonStart.Enabled = false;
            ClearOutputFolderButton.Enabled = false;

        }

        private void filesCreator(object sender, DoWorkEventArgs e)
        {

            int fileid = 0;
            bool notfinded = true;
            string path = @".\output\";
            long percent = 0;

            Invoke(new Action(() => Text = "Number Changer - V1.0.7 - [WORKING]"));
            ProgressOfLines.Invoke(new Action(() => ProgressOfLines.Value = 0));

            if (!IsFolderExisting(path))
            {
                Directory.CreateDirectory(path);
            }

            while (notfinded)
            {
                fileid += 1;
                string filepath = $@"{path}{fileid}.txt";
                if (!File.Exists(filepath))
                {
                    notfinded = false;
                }
            }

            using (StreamWriter file = new StreamWriter($@"{path}{fileid}.txt", true))
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                // Utilisation de la fonction "Invoke()" pour avoir l'autorisation de modifier l'objet
                TookLabel.Invoke(new Action(() => TookLabel.Visible = true));

                for (int i = 0; i != Int64.Parse(LinesEntered) + 1; i++)
                {
                    var replacement = ToChangeEntered.Replace("@(*)", i.ToString());
                    file.WriteLine(replacement);
                    if (ProgressOfLines.Value < ProgressOfLines.Maximum)
                    {
                        ProgressOfLines.Invoke(new Action(() => ProgressOfLines.Value += 1));
                    }
                    percent = (i * 100) / Int64.Parse(LinesEntered);

                    ProgressOfLines.Invoke(new Action(() => ProgressOfLines.Refresh()));
                    TookLabel.Invoke(new Action(() => TookLabel.Text = $"{percent}% | Lines created: {i}/{Int64.Parse(LinesEntered)}"));
                    TookLabel.Invoke(new Action(() => TookLabel.Refresh()));
                }

                // Temps passé pour la création
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                TookLabel.Invoke(new Action(() => TookLabel.Text = "Took " + elapsedMs.ToString() + "ms"));

            }
            PathAndNameLastFile = $"{path}{fileid}.txt";
            SystemSounds.Exclamation.Play();

            ProgressOfLines.Invoke(new Action(() => ProgressOfLines.Visible = true));
            finishedLabel.Invoke(new Action(() => finishedLabel.Visible = true));
            TookLabel.Invoke(new Action(() => TookLabel.Visible = true));
            CopyCreatedFileButton.Invoke(new Action(() => CopyCreatedFileButton.Enabled = true));
            ToChangeTextBox.Invoke(new Action(() => ToChangeTextBox.Enabled = true));
            NumberLinesTextBox.Invoke(new Action(() => NumberLinesTextBox.Enabled = true));
            buttonStart.Invoke(new Action(() => buttonStart.Enabled = true));
            ClearOutputFolderButton.Invoke(new Action(() => ClearOutputFolderButton.Enabled = true));

            Invoke(new Action(() => Text = "Number Changer - V1.0.7"));
        }

        private static bool IsFolderExisting(string path)
        {
            if (Directory.Exists(path)) return true;
            else return false; 
        }

        private void ExampleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For example, if you write :\nhi @(*) !\nAnd 3 lines to create\nIn the output file, you will have :\nhi 0 !\nhi 1 !\nhi 2 !\nhi 3 !", "Example", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void seeEnteredTextButton_Click(object sender, EventArgs e)
        {
            string a = ToChangeTextBox.Text;
            MessageBox.Show($"{a}", "Your text", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProblemsMsg_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Cu-chi/Number-Changer/issues/new");
        }

        private void GoToFolderButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@".\");
        }

        private void ClearOutputFolderButton_Click(object sender, EventArgs e)
        {
            string path = @".\output\";

            if (Directory.Exists(path)) 
            {
                int fileInFolder = Directory.GetFiles(path).Length;
                DialogResult msgboxResult = MessageBox.Show($"Clear {fileInFolder} files in the output folder?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msgboxResult == DialogResult.Yes)
                {
                    CopyCreatedFileButton.Enabled = false;
                    Directory.Delete(path, true);
                    SystemSounds.Exclamation.Play();
                }
            }
            else
            {
                MessageBox.Show("The directory doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CopyCreatedFileButton_Click(object sender, EventArgs e)
        {
            string InteriorLastFile = File.ReadAllText(PathAndNameLastFile).ToString();
            Clipboard.SetText(InteriorLastFile);
        }
    }
}