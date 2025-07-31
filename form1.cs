using System;
using System.Diagnostics;
using System.Windows.Forms;



namespace kullanıcı_giriş_formu
{
    
    public partial class btngirişyap : Form
    {
        public btngirişyap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıadı = txtkullanıcıadı.Text;
            string şifre = txtşifre.Text;
            kullanıcıadı = null;
            if (kullanıcıadı != "oğuzhan taşcı" && şifre != "1234")
            {
                //windows form içerisinde nasıl kullanıcıya bir popup gösteririz bunu çok ufak bir şekilde inceleyim )
                //ayrı bir konu olarak eğitim içerisinde detaylı bulacaksınız.
                MessageBox.Show("Hatalı kullanıcı bilgileri");
            }
            else
            {
                Anaform anaform = new Anaform(kullanıcıadı);
                anaform.ShowDialog();
            }
        }
    }
}
