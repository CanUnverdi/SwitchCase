using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            public Form1()
            {
                InitializeComponent();
            }
           
            private void btnAdminBir_Click(object sender, EventArgs e)
            {
                switch (txtGelenDeger1.Text)
                {
                    case "admin":
                        MessageBox.Show("Hoşgeldiniz.");
                        break;
                    case "burak":
                        MessageBox.Show("Yanlış Şifre");
                        break;
                    default:
                        MessageBox.Show("Onaylanmadı");
                        break;
                }
            }

            private void btnAdminIki_Click(object sender, EventArgs e)
            {
            
                string kullaniciAdi = txtGelenDeger1.Text;
                string sifre = txtGelenDeger2.Text;

                switch (kullaniciAdi)
                {
                    case "admin":
                        switch (sifre)
                        {
                            case "1234":
                                MessageBox.Show("Hoşgeldiniz");
                                break;
                            default:
                                MessageBox.Show("Kullanıcı adınız doğru şifreniz yanlış");
                                break;
                        }
                        break;
                    default:
                        MessageBox.Show("Kullancı adınız yanlış");
                        break;
                }
            }

            private void btnMevsim_Click(object sender, EventArgs e)
            {


                switch (txtGelenDeger1.Text)
                {
                    case "Kış":
                        MessageBox.Show("Aralık - Ocak - Şunbat");
                        break;
                    case "İlkbahar":
                        MessageBox.Show("Mart - Nisan - Mayıs");
                        break;
                    case "Yaz":
                        MessageBox.Show("Haziran - Temmuz - Ağustos");
                        break;
                    case "Sonbahar":
                        MessageBox.Show("Eylül - EKim - Kasım");
                        break;
                    default:
                        MessageBox.Show("Böyle bir mevsim yok");
                        break;
                }
            }

            private void btnAy_Click(object sender, EventArgs e)
            {


                switch (txtGelenDeger1.Text)
                {
                    case "Aralık":
                    case "Ocak":
                    case "Şubat":
                        MessageBox.Show("Kış");
                        break;
                    case "Mart":
                    case "Nisan":
                    case "Mayıs":
                        MessageBox.Show("İlkbahar");
                        break;
                    case "Haziran":
                    case "Temmuz":
                    case "Ağustos":
                        MessageBox.Show("Yaz");
                        break;
                    case "Eylül":
                    case "Ekim":
                    case "Kasım":
                        MessageBox.Show("Sonbahar");
                        break;
                    default:
                        MessageBox.Show("Böyle bir ay hiç duymadım!");
                        break;
                }
            }

            private void btnKullanıcı_Click(object sender, EventArgs e)
            {

                switch (txtGelenDeger1.Text.ToLower())
                {
                    case "admin":
                    case "ceo":
                    case "başkan":
                        MessageBox.Show("Yönetim paneline hoş geldiniz");
                        break;
                    case "üye":
                        MessageBox.Show("Anasayfaya yönelendiriliyorsun");
                        break;
                    default:
                        MessageBox.Show("Yetkiniz bulunmamaktadır.");
                        break;
                }
            }
        }
    }
}
