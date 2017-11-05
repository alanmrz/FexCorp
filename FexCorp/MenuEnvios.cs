using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FexCorp
{
    public partial class MenuEnvios : Form
    {
        public MenuEnvios()
        {
            InitializeComponent();
        }

        private void btnNuevoEnvio_Click(object sender, EventArgs e)
        {
            NuevoEnvio frm = new NuevoEnvio();
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void MenuEnvios_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);
        }
    }
}
