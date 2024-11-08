using System;
using System.IO;
using System.Windows.Forms;

namespace P_FileHider
{
    public partial class Frm_FileHider : Form
    {
        // Champs pour stocker les chemins des fichiers sélectionnés
        private string imagePath;
        private string filePath;

        private int cntClear = 0;
        private int cntClearReversed = 20;

        public Frm_FileHider()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sélectionner l'image originale
        /// </summary>
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fichiers d'image (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    ClWrite("Image sélectionnée : " + imagePath);
                }
            }
        }

        /// <summary>
        /// Sélectionner le fichier à cacher dans l'image
        /// </summary>
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Tous les fichiers (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    ClWrite("Fichier sélectionné : " + filePath);
                }
            }
        }

        /// <summary>
        /// Cacher le fichier sélectionné dans l'image
        /// </summary>
        private void btnHide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath) || string.IsNullOrEmpty(filePath))
            {
                ClWrite("Veuillez sélectionner à la fois une image et un fichier.");
                return;
            }

            string outputFile = Path.Combine(Path.GetDirectoryName(imagePath), "combined_image.jpg");

            try
            {
                // Lire tous les octets de l'image et du fichier
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                byte[] fileBytes = File.ReadAllBytes(filePath);

                // Combiner les octets de l'image et du fichier dans le fichier de sortie
                using (FileStream outputStream = new FileStream(outputFile, FileMode.Create))
                {
                    outputStream.Write(imageBytes, 0, imageBytes.Length);
                    outputStream.Write(fileBytes, 0, fileBytes.Length);
                }
                ClWrite("Fichiers combinés avec succès dans " + outputFile);
            }
            catch (Exception ex)
            {
                ClWrite("Une erreur est survenue : " + ex.Message);
            }
        }

        // Méthode pour écrire un texte dans la console de l'application
        private void ClWrite(string texte)
        {
            lblConsole.Text += "\nSystem/FileHide> " + texte;
        }

        // Réinitialiser la console automatiquement après un certain temps
        private void tmResetConsole_Tick(object sender, EventArgs e)
        {
            cntClear++;
            cntClearReversed--;
            lblClear.Text = $"Time before clear: {cntClearReversed}";
            if (cntClear % 20 == 0)
            {
                lblConsole.Text = "System/FileHide> Console effacée avec succès";
                cntClear = 0;
            }
        }
    }
}
