namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dogru, yanlis, soruno = 0;
        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label5.Visible = false;

            soruno++;
            lblsoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Sherlock Holmes karakterinin yaratýcýsý kimdir?";
                btna.Text = "Agatha Christie";
                btnb.Text = "Arthur Conan Doyle";
                btnc.Text = "Raymond Chandler";
                btnd.Text = "Dashiell Hammett";
                label5.Text = "Arthur Conan Doyle";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "8,849 metre ile dünyanýn en yüksek daðý olan Everest, hangi dað sýrasýnda yer alýr?";
                btna.Text = "And Daðlarý";
                btnb.Text = "Ural Daðlarý";
                btnc.Text = "Himalaya Daðlarý";
                btnd.Text = "Rockies Daðlarý";
                label5.Text = "Himalaya Daðlarý";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "1911 yýlýnda Kimya dalýnda Nobel Ödülü'nü kazanan ilk kadýn kimdir?";
                btna.Text = "Dorothy Crowfoot Hodgkin";
                btnb.Text = "Linus Pauling";
                btnc.Text = "Irène Joliot-Curie";
                btnd.Text = "Marie Curie";
                label5.Text = "Marie Curie";
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Hangi ünlü marka, kendi adýný taþýyan kýrmýzý tabanlý ayakkabýlarýyla tanýnýr?";
                btna.Text = "Gucci";
                btnb.Text = "Christian Louboutin";
                btnc.Text = "Louis Vuitton";
                btnd.Text = "Prada";
                label5.Text = "Christian Louboutin";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Meiji Restorasyonu nerede gerçekleþmiþtir?";
                btna.Text = "Çin";
                btnb.Text = "Japonya";
                btnc.Text = "Hindistan";
                btnd.Text = "Rusya";
                label5.Text = "Japonya";
            }

            if (soruno == 6)
            {
                richTextBox1.Text = "Hangi ünlü þef, \"Moleküler Gastronomi\" adlý akýmýn öncülerinden biridir?";
                btna.Text = "Jamie Oliver";
                btnb.Text = "Ferran Adrià";
                btnc.Text = "Heston Blumenthal";
                btnd.Text = "Gordon Ramsay";
                label5.Text = "Ferran Adrià";
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "2010 Avrupa Kültür Baþkenti hangi Türkiye þehri seçilmiþtir?";
                btna.Text = "Ýzmir";
                btnb.Text = "Þanlýurfa";
                btnc.Text = "Ýstanbul";
                btnd.Text = "Antalya";
                label5.Text = "Ýstanbul";
            }

            if (soruno == 8)
            {
                richTextBox1.Text = "Dünyanýn Çatýsý” neresidir?";
                btna.Text = "Tibet";
                btnb.Text = "Buryatya";
                btnc.Text = "Oslo";
                btnd.Text = "Ottawa";
                label5.Text = "Tibet";
            }

            if (soruno == 9)
            {
                richTextBox1.Text = "Aþaðýdaki eserlerden hangisi Claude Monet’ye aittir?";
                btna.Text = "The Kiss";
                btnb.Text = "The Last Supper";
                btnc.Text = "Guernica";
                btnd.Text = "La Promenade";
                label5.Text = "La Promenade";
            }

            if (soruno == 10)
            {
                richTextBox1.Text = "En çok Grammy kazanmýþ kadýn sanatçý kimdir?";
                btna.Text = "Rihanna";
                btnb.Text = "Alison Krauss";
                btnc.Text = "Beyoncé";
                btnd.Text = "Adele";
                label5.Text = "Beyoncé";
            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label6.Text = btna.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                btndogru.Visible = true;
            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label6.Text = btnb.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                btndogru.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label6.Text = btnc.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                btndogru.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnsonraki.Enabled = true;

            label6.Text = btnd.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                btndogru.Visible = true;
            }
        }

        private void btndogru_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
        }
    }
}
