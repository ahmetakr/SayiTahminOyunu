namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Sayi;
        int Sayac;
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Random rnd=new Random();
            Sayi=rnd.Next(1,100);
            lblBilgi.Text=Sayi.ToString();
            lblBilgi.Text = "1-100 arasýnda sayý tutuldu. Oyun Baþladý. ";
            Sayac = 0;

            btnKontrol.Enabled = true;
            btnBaslat.Enabled= false;
            txtTahmin.Text = "";
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(txtTahmin.Text);      
            Sayac++;
       
            if (tahmin>Sayi) 
            {
                lblSonuc.Text = "Bilemedin aþaðý";
                
            }else if (tahmin<Sayi)
            {
                lblSonuc.Text = "Bilemedin yukarý";
                
            }else
            {
                lblSonuc.Text = "TEBRÝKLER SAYIYI "+Sayac+" TAHMÝNDE BÝLDÝN";
                btnKontrol.Enabled= false;
                btnBaslat.Enabled = true;
                btnBaslat.Text = "Oyunu Tekrar Baþlat";
            }
        }

        private void txtTahmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}