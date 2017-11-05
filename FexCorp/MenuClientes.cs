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
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void MenuClientes_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente frm = new EliminarCliente();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }
    }
}
