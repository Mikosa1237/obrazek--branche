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

        private void button_only_green_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;

            Bitmap orginalny = new Bitmap(pictureBox.Image);
            Bitmap zielony = new Bitmap(orginalny.Width, orginalny.Height);

            for (int x = 0; x < orginalny.Width; x++)
            {
                for (int y = 0; y < orginalny.Height; y++)
                {
                    Color pixel = orginalny.GetPixel(x, y);

                    // Sprawdzamy czy piksel jest bardziej zielony niż czerwony i niebieski
                    if (pixel.G > pixel.R && pixel.G > pixel.B)
                    {
                        zielony.SetPixel(x, y, pixel); // Zachowujemy oryginalny kolor
                    }
                    else
                    {
                        zielony.SetPixel(x, y, Color.Black); // Ustawiamy czarny kolor
                    }
                }
            }

            pictureBox.Image = zielony;
            orginalny.Dispose();
        }
    }
}
