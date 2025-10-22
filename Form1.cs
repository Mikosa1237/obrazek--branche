namespace obrazek___branche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki graficzne |*.jpg; *.jpeg; *.png; *.bmp|Wszystkie pliki (*.*)|*.*";
            ofd.Title = "Wybierz plik graficzny do wczytania";
            ofd.ShowDialog();

            if (ofd.FileName != "")
            {
                Bitmap bitmapa = new Bitmap(ofd.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = bitmapa;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Funkcja do zaimplementowania w przyszłości
        }

        private void rotate_Click(object sender, EventArgs e)
        {
            if (pictureBox != null)
            {
                Bitmap origin = (Bitmap)pictureBox.Image;
                Bitmap rot = new Bitmap(origin);

                if (rb90.Checked)
                {
                    rot.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                if (rb180.Checked)
                {
                    rot.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                if (rb270.Checked)
                {
                    rot.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }

                pictureBox.Image = rot;
                origin.Dispose();
            }
        }
    }
}
