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
            frm.Show();
            this.Close();
        }

        private void MenuEnvios_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);
        }

        private void btnListaTodos_Click(object sender, EventArgs e)
        {
            ListarEnvios frm = new ListarEnvios();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarEnvio frm = new ModificarEnvio();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }
    }
}
