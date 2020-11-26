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
using System.Drawing.Text;
using Octokit;

// https://api.github.com/repos/Cu-chi/Number-Changer/releases/latest
namespace Number_Changer
{
    public partial class InterFace : Form
    {
        public InterFace()
        {
            InitializeComponent();
        }

        // Variables par défaut qui seront changé par la suite ou qui seront utilisé plusieurs fois.
        public static string ToChangeEntered = "";
        public static string LinesEntered = "";
        public static string PathAndNameLastFile = "";
        public static string version = "1.2.0";

        private async void InterFace_Load(object sender, EventArgs e)
        {

            var client = new GitHubClient(new ProductHeaderValue("Number-Changer"));
            var releases = await client.Repository.Release.GetAll("Cu-chi", "Number-Changer");
            var latest = releases[0];

            if ("V"+version != latest.TagName)
            {
                DialogResult verResult = MessageBox.Show($"A new version is now available :\nYou are using > V{version}\nNew > {latest.TagName}\nDo you want to install the new version?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (verResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start($"https://github.com/Cu-chi/Number-Changer/releases/download/{latest.TagName}/Number-Changer-{latest.TagName}.zip");
                }
                else
                {
                    version += " (outdated)";
                }
            }

            // Importations des polices personnalisées
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"ui\MasterBlack.otf");
            pfc.AddFontFile(@"ui\Rubik-Bold.ttf");
            buttonStart.Font = new Font(pfc.Families[0], 25, FontStyle.Bold); // Master Black Personal Use; 26,25pt; style = Bold
            ExampleButton.Font = new Font(pfc.Families[1], 9, FontStyle.Bold);
            GoToFolderButton.Font = new Font(pfc.Families[1], 9, FontStyle.Bold);
            seeEnteredTextButton.Font = new Font(pfc.Families[1], 9, FontStyle.Bold);
            CopyCreatedFileButton.Font = new Font(pfc.Families[1], 9, FontStyle.Bold);
            ClearOutputFolderButton.Font = new Font(pfc.Families[1], 9, FontStyle.Bold);

            // Changements des labels contenant la version
            Text = $"Number Changer - {version}";
            Version.Text = $"{version} - Cuchi'";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            finishedLabel.Visible = false;
            TookLabel.Visible = false;

            string ToChangeEnteredcheck = ToChangeTextBox.Text;
            string LinesEnteredcheck = NumberLinesTextBox.Text;

            if (ToChangeEnteredcheck != ToChangeEntered) { ToChangeEntered = ToChangeEnteredcheck; }
            if (LinesEnteredcheck != LinesEntered) { LinesEntered = LinesEnteredcheck; }

            // Retourne false si le nombre de lignes n'est pas un nombre
            bool isNumericLines = int.TryParse(LinesEntered, out int lines);

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
            // Variable par défaut qui seront changés par la suite.
            int fileid = 0;
            bool notfinded = true;
            string path = @".\output\";
            long percent = 0;

            // Changement du nom de la fenêtre afin d'indiquer qu'elle est en cours de travail
            Invoke(new Action(() => Text = $"Number Changer - {version} - [WORKING]"));

            // Update de la progress bar -> on la remet à 0
            ProgressOfLines.Invoke(new Action(() => ProgressOfLines.Value = 0));

            // Si le dossier output n'extiste pas, alors le créer
            if (!IsFolderExisting(path)) { Directory.CreateDirectory(path); }

            // Tant qu'un fichier existe déjà avec ce nombre, ajouter un, une fois inexistant, le séléctionner et l'appliquer.
            while (notfinded)
            {
                fileid += 1;
                string filepath = $@"{path}{fileid}.txt";
                if (!File.Exists(filepath))
                {
                    notfinded = false;
                }
            }

            // Utilisation de StreamWriter afin d'écrire dans le fichier créé au paravant.
            using (StreamWriter file = new StreamWriter($@"{path}{fileid}.txt", true))
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                // Utilisation de la fonction "Invoke()" pour avoir l'autorisation de modifier l'objet
                TookLabel.Invoke(new Action(() => TookLabel.Visible = true));

                // Pour le nombre de lignes entré, créer une nouvelle ligne
                for (int i = 0; i != Int64.Parse(LinesEntered) + 1; i++)
                {
                    // Remplacement (si @(*)) de @(*) par i et/ou laisser phrase normal mais répété sur plusieurs lignes.
                    var replacement = ToChangeEntered.Replace("@(*)", i.ToString());

                    // Appliquer la ligne
                    if (lineBreakCheckBox.Checked) { file.WriteLine(replacement); }
                    else { file.Write(replacement); }

                    // Tant que la progress bar n'est pas à son maximum, lui ajouter 1 a chaque incrémentation de i
                    if (ProgressOfLines.Value < ProgressOfLines.Maximum)
                    {
                        ProgressOfLines.Invoke(new Action(() => ProgressOfLines.Value += 1));
                    }

                    // Calcul du pourcentage
                    percent = (i * 100) / Int64.Parse(LinesEntered);

                    // Refresh de la progress
                    ProgressOfLines.Invoke(new Action(() => ProgressOfLines.Refresh()));
                    // Label contenant le pourcentage | nb de ligne sur le nb total à créer
                    TookLabel.Invoke(new Action(() => TookLabel.Text = $"{percent}% | Times repeated {i}/{Int64.Parse(LinesEntered)}"));
                    // Refresh du label de % ou nb de lignes
                    TookLabel.Invoke(new Action(() => TookLabel.Refresh()));
                }

                // Temps passé pour la création
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                // Remplacement du label par le temps prit
                TookLabel.Invoke(new Action(() => TookLabel.Text = "Took " + elapsedMs.ToString() + "ms"));

            }
            // Remplacement de la variable PathAndNameLastFile par le nom du fichier qui vient d'être créé.
            PathAndNameLastFile = $"{path}{fileid}.txt";
            // Emition d'un son lorsque la création du fichier s'est terminée
            SystemSounds.Exclamation.Play();

            // Réactiver les bouttons à la fin du processus.
            ProgressOfLines.Invoke(new Action(() => ProgressOfLines.Visible = true));
            finishedLabel.Invoke(new Action(() => finishedLabel.Visible = true));
            TookLabel.Invoke(new Action(() => TookLabel.Visible = true));
            CopyCreatedFileButton.Invoke(new Action(() => CopyCreatedFileButton.Enabled = true));
            ToChangeTextBox.Invoke(new Action(() => ToChangeTextBox.Enabled = true));
            NumberLinesTextBox.Invoke(new Action(() => NumberLinesTextBox.Enabled = true));
            buttonStart.Invoke(new Action(() => buttonStart.Enabled = true));
            ClearOutputFolderButton.Invoke(new Action(() => ClearOutputFolderButton.Enabled = true));

            // CHangement du nom de la fenetre qui avait été mise sur Number CHanger - versio - [WORKING]
            Invoke(new Action(() => Text = $"Number Changer - {version}"));
        }

        // Fonctions qui check si le dossier Output existe
        private static bool IsFolderExisting(string path)
        {
            if (Directory.Exists(path)) return true;
            else return false; 
        }

        private void ExampleButton_Click(object sender, EventArgs e)
        {
            // MEssage box lors du click sur le bouton example.
            MessageBox.Show("For example, if you write :\nhi @(*) !\nAnd 3 lines to create\nIn the output file, you will have :\nhi 0 !\nhi 1 !\nhi 2 !\nhi 3 !", "Example", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void seeEnteredTextButton_Click(object sender, EventArgs e)
        {
            // MSGBOX qui indique ce que l'user à entré.
            string a = ToChangeTextBox.Text;
            MessageBox.Show($"{a}", "Your text", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProblemsMsg_Click(object sender, EventArgs e)
        {
            // Redirection vers la page github pour signaler des problèmes
            System.Diagnostics.Process.Start("https://github.com/Cu-chi/Number-Changer/issues/new");
        }

        private void GoToFolderButton_Click(object sender, EventArgs e)
        {
            // Redirection vers le dossier source
            System.Diagnostics.Process.Start(@".\");
        }

        private void ClearOutputFolderButton_Click(object sender, EventArgs e)
        {
            string path = @".\output\";

            // Si le dossier existe, alors supprimer ce qu'il y a dedans
            if (Directory.Exists(path)) 
            {
                // Compte le nombre de fichiers dedans
                int fileInFolder = Directory.GetFiles(path).Length;
                // Validation si jamais missclicl
                DialogResult msgboxResult = MessageBox.Show($"Clear {fileInFolder} files in the output folder?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                // Si le résultat de la validation est Yes, alors supprimer
                if (msgboxResult == DialogResult.Yes)
                {
                    // Bouton mit sur false car le dossier n'existe plus
                    CopyCreatedFileButton.Enabled = false;
                    Directory.Delete(path, true);
                    SystemSounds.Exclamation.Play();
                }
            }
            else
            {
                // Sinon, indiquer que le dossier n'existe par si jamais introuvable
                MessageBox.Show("The directory doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CopyCreatedFileButton_Click(object sender, EventArgs e)
        {
            // Changement du presse papier par l'intérieur du dernier fichier créé
            string InteriorLastFile = File.ReadAllText(PathAndNameLastFile).ToString();
            Clipboard.SetText(InteriorLastFile);
        }
    }
}