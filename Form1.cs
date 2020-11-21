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

            filesCreator();
        }

        private void filesCreator()
        {

            int fileid = 0;
            bool notfinded = true;

            string filepath = $@"output-nc-{fileid}.txt";
            
            while (notfinded)
            {
                fileid += 1;
                filepath = $@"output-nc-{fileid}.txt";
                if (!File.Exists(filepath))
                {
                    notfinded = false;

                }
            }


            using (StreamWriter file = new StreamWriter($@"output-nc-{fileid}.txt", true))
            {
                for (int i = 0; i != Int64.Parse(LinesEntered) + 1; i++)
                {
                    var replacement = ToChangeEntered.Replace("@(*)", i.ToString());
                    file.WriteLine(replacement);
                }
            }

        }
    }
}
