using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanıcı_giriş_formu
{
    public partial class Anaform : Form
    {
        public Anaform(string kullanıcıadı)
        {
            InitializeComponent();
            lblselamla.Text = kullanıcıadı;
        }

        private void Anaform_Load(object sender, EventArgs e)
        {

        }
    }
}
