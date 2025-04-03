namespace desktop_week2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadImages = new Button();
            flpThumbnails = new FlowLayoutPanel();
            pbxMainImage = new PictureBox();
            lblStatus = new Label();
            pnlMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbxMainImage).BeginInit();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoadImages
            // 
            btnLoadImages.Location = new Point(12, 12);
            btnLoadImages.Name = "btnLoadImages";
            btnLoadImages.Size = new Size(120, 30);
            btnLoadImages.TabIndex = 0;
            btnLoadImages.Text = "Load Images";
            btnLoadImages.UseVisualStyleBackColor = true;
            btnLoadImages.Click += btnLoadImages_Click;
            // 
            // flpThumbnails
            // 
            flpThumbnails.Anchor = ((AnchorStyles)(AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right));
            flpThumbnails.AutoScroll = true;
            flpThumbnails.BorderStyle = BorderStyle.FixedSingle;
            flpThumbnails.Location = new Point(12, 55);
            flpThumbnails.Name = "flpThumbnails";
            flpThumbnails.Size = new Size(776, 130);
            flpThumbnails.TabIndex = 1;
            // 
            // pbxMainImage
            // 
            pbxMainImage.Dock = DockStyle.Fill;
            pbxMainImage.Location = new Point(0, 0);
            pbxMainImage.Name = "pbxMainImage";
            pbxMainImage.Size = new Size(776, 226);
            pbxMainImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbxMainImage.TabIndex = 2;
            pbxMainImage.TabStop = false;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = ((AnchorStyles)(AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right));
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 425);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 3;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Controls.Add(pbxMainImage);
            pnlMain.Location = new Point(12, 191);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(776, 226);
            pnlMain.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(lblStatus);
            Controls.Add(flpThumbnails);
            Controls.Add(btnLoadImages);
            MinimumSize = new Size(600, 400);
            Name = "Form1";
            Text = "Image Gallery Viewer";
            ((System.ComponentModel.ISupportInitialize)pbxMainImage).EndInit();
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadImages;
        private FlowLayoutPanel flpThumbnails;
        private PictureBox pbxMainImage;
        private Label lblStatus;
        private Panel pnlMain;
    }
}
