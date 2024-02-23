using QRCoder;
using MaterialSkin;
using MaterialSkin.Controls;

namespace QRCode_Generator
{

    public partial class Form1 : MaterialForm
    {

        String texto = "Texto vazio também funciona =)";

        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple400, Primary.DeepPurple500,
                Primary.DeepPurple500, Accent.Purple400,
                TextShade.WHITE
            );
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Gerador de QR code";
        }

        private void GerarQRcode()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(4);
            pictureBox1.Image = qrCodeImage;
        }
        // Get the text from the textbox
        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
            texto = materialTextBox1.Text;
        }
        private void materialTextBox1_Click(object sender, EventArgs e)
        {
            materialButton1.Show();
            materialFloatingActionButton1.Show();
            materialLabel1.Text = "Insira seu texto";
        }

        // Generate the QR code
        private void materialButton1_Click(object sender, EventArgs e)
        {
            GerarQRcode();
        }

        // Download the QR code 
        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                materialLabel1.Text = "Não há imagem para salvar.";

                return;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivos de Imagem (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            saveFileDialog1.Title = "Salvar Imagem";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
                materialLabel1.Text = "Imagem salva com sucesso.";
            }
        }

    }
}
