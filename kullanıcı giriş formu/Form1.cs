using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string kullanıcıadı = null;
            if (kullanıadı != "oğuzhan" && şifre != "1234")
            {
            }
            else
                (
             Anaform anaform = new Anaform(kullanıcıadı);
            Anaform.Show();
        }
        else
        (
            //windows form içerisinde nasıl kullanıcıya bir popup gösteririz bunu çok ufak bir şekilde inceleyim )
}           //ayrı bir konu olarak eğitim içerisinde detaylı bulacaksınız.
     
    MessageBox.Show ("Hatalı kullanıcı bilgileri");


