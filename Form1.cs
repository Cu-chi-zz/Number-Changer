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
                MessageBox.Show("Number of lines entered is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Int64.Parse(LinesEntered) <= 0)
            {
                MessageBox.Show("Number of lines entered is invalid\nMust be > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProgressOfLines.Visible = true;

            filesCreator();
        }

        private void filesCreator()
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();

            int fileid = 0;
            bool notfinded = true;
            
            while (notfinded)
            {
                fileid += 1;
                string filepath = $@"output-nc-{fileid}.txt";
                if (!File.Exists(filepath))
                {
                    notfinded = false;
                }
            }

            ProgressOfLines.Maximum = Int32.Parse(LinesEntered);

            // Bloque durant les changements durant le processus
            ToChangeTextBox.Enabled = false;
            NumberLinesTextBox.Enabled = false;

            using (StreamWriter file = new StreamWriter($@"output-nc-{fileid}.txt", true))
            {
                for (int i = 0; i != Int64.Parse(LinesEntered) + 1; i++)
                {
                    var replacement = ToChangeEntered.Replace("@(*)", i.ToString());
                    file.WriteLine(replacement);
                    if (ProgressOfLines.Value < ProgressOfLines.Maximum)
                    {
                        ProgressOfLines.Value += 1;
                    }
                }

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;

                TookLabel.Text = "Took "+ elapsedMs.ToString()+"ms";
                ProgressOfLines.Visible = true;
                finishedLabel.Visible = true;
                TookLabel.Visible = true;
                SystemSounds.Exclamation.Play();
            }

            ToChangeTextBox.Enabled = true;
            NumberLinesTextBox.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For example, if you write :\nhi @(*) !\nAnd 3 lines to create\nIn the output file, you will have :\nhi 0 !\nhi 1 !\nhi 2 !\nhi 3 !", "Example", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
