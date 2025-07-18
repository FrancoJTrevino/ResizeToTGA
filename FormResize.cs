using SixLabors.ImageSharp.Formats.Tga;
using SixLabors.ImageSharp.Processing;
using Syroot.Windows.IO;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Security.AccessControl;

namespace ResizeToTGA
{
    public partial class FormResize : Form
    {
        private int targetHeight = 0;
        private int targetWidth = 0;
        private List<ImagesPaths> imagesPath = new List<ImagesPaths>();
        private string outputPath = "";
        public FormResize()
        {
            InitializeComponent();
            if (String.IsNullOrEmpty(Properties.Settings.Default.outputPath)) { outputPath = KnownFolders.PicturesLocalized.Path; }
            else { outputPath = Properties.Settings.Default.outputPath; }
            cmbSize.SelectedItem = "256x256";
            lblOutputPath.Text = outputPath;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (imagesPath.Count > 0)
            {
                lblProgress.Visible = true;
                lblProgress.Text = "Resizing";
                lblProgress.ForeColor = Color.Yellow;
                for (int i = 0; i < imagesPath.Count; i++)
                {
                    byte[] original = System.IO.File.ReadAllBytes(imagesPath[i].path);
                    byte[] output = ResizeImage(original, targetWidth, targetHeight);

                    System.IO.File.WriteAllBytes(outputPath + "\\" + imagesPath[i].filename + ".tga", output);
                }
                lblProgress.Text = "Done";
                lblProgress.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("No images selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            lblProgress.Visible = false;
            grdImages.Rows.Clear();
            grdImages.Refresh();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pictures|*.jpg;*.jpeg;*.jpe;*.png";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ofd.FileNames.Length; i++)
                {
                    ImagesPaths image = new ImagesPaths(ofd.FileNames[i], Path.GetFileNameWithoutExtension(ofd.SafeFileNames[i]));
                    imagesPath.Add(image);
                    grdImages.Rows.Add(ofd.SafeFileNames[i], ofd.FileNames[i]);
                }
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.InitialDirectory = outputPath;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                outputPath = fbd.SelectedPath;
                lblOutputPath.Text = outputPath;
            }
            Properties.Settings.Default.outputPath = outputPath;
            Properties.Settings.Default.Save();
        }

        private void FormResize_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSize.SelectedItem)
            {
                case "16x16":
                    targetHeight = 16;
                    targetWidth = 16;
                    break;
                case "32x32":
                    targetHeight = 32;
                    targetWidth = 32;
                    break;
                case "48x48":
                    targetHeight = 48;
                    targetWidth = 48;
                    break;
                case "64x64":
                    targetHeight = 64;
                    targetWidth = 64;
                    break;
                case "128x128":
                    targetHeight = 128;
                    targetWidth = 128;
                    break;
                case "256x256":
                    targetHeight = 256;
                    targetWidth = 256;
                    break;
            }
        }

        public static byte[] ResizeImage(byte[] inputBytes, int width, int height)
        {
            using (var inputStream = new MemoryStream(inputBytes))
            using (var image = SixLabors.ImageSharp.Image.Load(inputStream))
            {
                image.Mutate(x => x.Resize(new ResizeOptions
                {
                    Mode = ResizeMode.Stretch,
                    Size = new SixLabors.ImageSharp.Size(width, height),
                    Sampler = KnownResamplers.Lanczos3
                }));

                var encoder = new TgaEncoder();

                using (var outputStream = new MemoryStream())
                {
                    image.Save(outputStream, encoder);
                    return outputStream.ToArray();
                }
            }
        }

    }

    public class ImagesPaths
    {
        public string path;
        public string filename;

        public ImagesPaths(string imagePath, string imageFilename)
        {
            path = imagePath; filename = imageFilename;
        }
    }
}
