using System.Windows.Forms;

namespace desktop_week2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblStatus.Text = string.Empty; // Initialize label with empty text
        }

        private void btnLoadImages_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder containing images";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    flpThumbnails.Controls.Clear(); // Clear existing thumbnails

                    var path = folderDialog.SelectedPath;
                    string[] files = Directory.GetFiles(path);

                    foreach (string file in files)
                    {
                        string lowerFile = file.ToLower();
                        if (File.Exists(file) && (lowerFile.EndsWith(".jpg") || lowerFile.EndsWith(".png") || lowerFile.EndsWith(".jpeg") || lowerFile.EndsWith(".gif")))
                        {
                            PictureBox thumbnail = new PictureBox
                            {
                                Width = 100,
                                Height = 100,
                                Cursor = Cursors.Hand,
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Tag = file,
                                Margin = new Padding(5)
                            };

                            try
                            {
                                thumbnail.Load(file);
                                thumbnail.Click += Thumbnail_Click;
                                flpThumbnails.Controls.Add(thumbnail);
                            }
                            catch (Exception ex)
                            {
                                // Skip images that couldn't be loaded
                                MessageBox.Show($"Error loading {file}: {ex.Message}");
                            }
                        }
                    }

                    lblStatus.Text = $"Loaded {flpThumbnails.Controls.Count} images";
                }
            }
        }

        private void Thumbnail_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox thumbnail)
            {
                string imgPath = thumbnail.Tag.ToString();

                try
                {
                    pbxMainImage.Load(imgPath);
                    lblStatus.Text = $"Viewing: {Path.GetFileName(imgPath)}";
                }
                catch (Exception ex)
                {
                    lblStatus.Text = $"Error loading image: {ex.Message}";
                }
            }
        }
    }
}
