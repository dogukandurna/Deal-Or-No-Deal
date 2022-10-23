using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace VarmısınYokmusun
{
    public partial class Form1 : Form
    {
        public static int[] kutular = new int[20];
        public static int[] paralar = { 1, 2, 10, 25, 50, 100, 200, 500, 750, 1000, 10000, 50000, 100000, 150000, 200000, 250000, 375000, 500000, 750000, 1000000 };
        public bool kutusecimkont = true;
        public int teklifkalan = 3;
        public int numara,secilenumara;
        public int teklifdeger=0;

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            karıştır();
            degerata();
            label21.Text = "Lütfen kutunuzu seçiniz...";
            label22.Visible=false;
        }

        public static void karıştır()
        {
            Random rast = new Random();
            for (int i = 0; i < kutular.Length; i++)
            {
                int değiş = rast.Next(kutular.Length);
                if (değiş != i)
                {
                    int tmp = paralar[i];
                    paralar[i] = paralar[değiş];
                    paralar[değiş] = tmp;
                }

            }
        }

        public void degerata()
        {
            button2.Tag = paralar[0];
            button3.Tag = paralar[1];
            button4.Tag = paralar[2];
            button5.Tag = paralar[3];
            button6.Tag = paralar[4];
            button7.Tag = paralar[5];
            button8.Tag = paralar[6];
            button9.Tag = paralar[7];
            button10.Tag = paralar[8];
            button11.Tag = paralar[9];
            button12.Tag = paralar[10];
            button13.Tag = paralar[11];
            button14.Tag = paralar[12];
            button15.Tag = paralar[13];
            button16.Tag = paralar[14];
            button17.Tag = paralar[15];
            button18.Tag = paralar[16];
            button19.Tag = paralar[17];
            button20.Tag = paralar[18];
            button21.Tag = paralar[19];
        }

        public void labelteklifyazdır()
        {
            teklifkalan--;
            label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
        }

        public void labelsildiziyenile(int numara)
        {
            switch (numara)
            {
                case 1:
                    {
                        label1.Enabled = false;
                    }
                    break;
                case 2:
                    {
                        label2.Enabled = false;
                    }
                    break;
                case 10:
                    {
                        label3.Enabled = false;
                    }
                    break;
                case 25:
                    {
                        label4.Enabled = false;
                    }
                    break;
                case 50:
                    {
                        label5.Enabled = false;
                    }
                    break;
                case 100:
                    {
                        label6.Enabled = false;
                    }
                    break;
                case 200:
                    {
                        label7.Enabled = false;
                    }
                    break;
                case 500:
                    {
                        label8.Enabled = false;
                    }
                    break;
                case 750:
                    {
                        label9.Enabled = false;
                    }
                    break;
                case 1000:
                    {
                        label10.Enabled = false;
                    }
                    break;
                case 10000:
                    {
                        label11.Enabled = false;
                    }
                    break;
                case 50000:
                    {
                        label12.Enabled = false;
                    }
                    break;
                case 100000:
                    {
                        label14.Enabled = false;
                    }
                    break;
                case 150000:
                    {
                        label16.Enabled = false;
                    }
                    break;
                case 200000:
                    {
                        label13.Enabled = false;
                    }
                    break;
                case 250000:
                    {
                        label15.Enabled = false;
                    }
                    break;
                case 375000:
                    {
                        label17.Enabled = false;
                    }
                    break;
                case 500000:
                    {
                        label18.Enabled = false;
                    }
                    break;
                case 750000:
                    {
                        label19.Enabled = false;
                    }
                    break;
                case 1000000:
                    {
                        label20.Enabled = false;
                    }
                    break;
            }
            paralar = paralar.Where(x => x != Convert.ToInt32(numara)).ToArray();
        }

        public void teklifhesapla()
        {
            for (int i = 0; i < paralar.Length; i++)
            {
                teklifdeger+=paralar[i];
            }
            teklifdeger = teklifdeger / paralar.Length;
            teklifkalan = 3;
            label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
            if (paralar.Length == 2)
            {
                label21.Text = "Kendi kutunuz ve karşı kutu arasında seçim yapın!";
            }
        }

        public void teklifkalankontrol()
        {
            if (teklifkalan == 0)
            {
                teklifhesapla();
                DialogResult teklifcevap;
                teklifcevap=MessageBox.Show("Teklif= " + teklifdeger + " TL\n\nTeklifi Kabul Ediyor musunuz?", "Hamdi Beyin Teklifi", MessageBoxButtons.YesNo);
                if (teklifcevap==DialogResult.Yes)
                {
                    label21.Text = "";
                    label22.Visible = true;
                    label22.Location = label21.Location;
                    label22.Text = "Tebrikler " + teklifdeger + " TL Kazandınız";
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button18.Enabled = false;
                    button19.Enabled = false;
                    button20.Enabled = false;
                    button21.Enabled = false;
                }
                teklifdeger = 0;
            }
        }

        public void kendikutunuac(int numara)
        {
            if (paralar.Length == 1)
            {
                label21.Text = "";
                label22.Visible = true;
                label22.Location = label21.Location;
                MessageBox.Show("Tebrikler " + numara + " TL Kazandınız", "Kazandığınız Para");
                label22.Text = "Tebrikler " + numara + " TL Kazandınız";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kutusecimkont==true)
            {
                button2.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 1;
            }
            else
            {
                if (paralar.Length!=2 && secilenumara==1)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button2.Text = Convert.ToString(button2.Tag);
                    button2.Enabled = false;
                    MessageBox.Show(button2.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button2.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button3.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 2;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 2)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button3.Text = Convert.ToString(button3.Tag);
                    button3.Enabled = false;
                    MessageBox.Show(button3.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button3.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button4.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 3;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 3)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button4.Text = Convert.ToString(button4.Tag);
                    button4.Enabled = false;
                    MessageBox.Show(button4.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button4.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button5.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 4;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 4)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button5.Text = Convert.ToString(button5.Tag);
                    button5.Enabled = false;
                    MessageBox.Show(button5.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button5.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button6.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 5;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 5)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button6.Text = Convert.ToString(button6.Tag);
                    button6.Enabled = false;
                    MessageBox.Show(button6.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button6.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button7.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 6;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 6)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button7.Text = Convert.ToString(button7.Tag);
                    button7.Enabled = false;
                    MessageBox.Show(button7.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button7.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button8.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 7;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 7)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button8.Text = Convert.ToString(button8.Tag);
                    button8.Enabled = false;
                    MessageBox.Show(button8.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button8.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button9.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 8;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 8)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button9.Text = Convert.ToString(button9.Tag);
                    button9.Enabled = false;
                    MessageBox.Show(button9.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button9.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button10.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 9;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 9)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button10.Text = Convert.ToString(button10.Tag);
                    button10.Enabled = false;
                    MessageBox.Show(button10.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button10.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button11.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 10;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 10)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button11.Text = Convert.ToString(button11.Tag);
                    button11.Enabled = false;
                    MessageBox.Show(button11.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button11.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button12.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 11;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 11)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button12.Text = Convert.ToString(button12.Tag);
                    button12.Enabled = false;
                    MessageBox.Show(button12.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button12.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button13.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 12;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 12)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button13.Text = Convert.ToString(button13.Tag);
                    button13.Enabled = false;
                    MessageBox.Show(button13.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button13.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button14.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 13;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 13)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button14.Text = Convert.ToString(button14.Tag);
                    button14.Enabled = false;
                    MessageBox.Show(button14.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button14.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button15.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 14;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 14)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button15.Text = Convert.ToString(button15.Tag);
                    button15.Enabled = false;
                    MessageBox.Show(button15.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button15.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button16.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 15;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 15)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button16.Text = Convert.ToString(button16.Tag);
                    button16.Enabled = false;
                    MessageBox.Show(button16.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button16.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button17.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 16;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 16)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button17.Text = Convert.ToString(button17.Tag);
                    button17.Enabled = false;
                    MessageBox.Show(button17.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button17.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button18.Location = new Point(375, 275);
                kutusecimkont = false; 
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 17;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 17)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button18.Text = Convert.ToString(button18.Tag);
                    button18.Enabled = false;
                    MessageBox.Show(button18.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button18.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button19.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 18;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 18)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button19.Text = Convert.ToString(button19.Tag);
                    button19.Enabled = false;
                    MessageBox.Show(button19.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button19.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button20.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 19;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 19)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button20.Text = Convert.ToString(button20.Tag);
                    button20.Enabled = false;
                    MessageBox.Show(button20.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button20.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (kutusecimkont == true)
            {
                button21.Location = new Point(375, 275);
                kutusecimkont = false;
                label21.Text = "Bir kutu açınız! Teklife kalan: " + teklifkalan;
                secilenumara = 20;
            }
            else
            {
                if (paralar.Length != 2 && secilenumara == 20)
                {
                    MessageBox.Show("Şuan kendi kutunu açamazsın");
                }
                else
                {
                    button21.Text = Convert.ToString(button21.Tag);
                    button21.Enabled = false;
                    MessageBox.Show(button21.Text + " TL", "Kutudaki Para:");
                    labelteklifyazdır();
                    numara = Convert.ToInt32(button21.Text);
                    labelsildiziyenile(numara);
                    teklifkalankontrol();
                    kendikutunuac(numara);
                }
            }
        }
    }
}