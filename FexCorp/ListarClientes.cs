﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FexCorp
{
    public partial class ListarClientes : Form
    {

        public ListarClientes()
        {
            InitializeComponent();
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            SqlConnection cnEnvios = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            cnEnvios = ac.ObtenerConexion();

            GestionClientes gc = new GestionClientes();
            DataTable dtClientes = new DataTable();
            dtClientes = gc.ObtenerTodos();

            grdClientes.DataSource = dtClientes;

            //////////////////////////
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);
        }

        //////////////////////////////////////////////////////////////////////////CONFIGURACION DE BOTONES
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal frm = new MenuPrincipal();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            MenuEnvios frm = new MenuEnvios();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            MenuSucursal frm = new MenuSucursal();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            MenuSeguimiento frm = new MenuSeguimiento();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MenuReportes frm = new MenuReportes();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            MenuConfiguracion frm = new MenuConfiguracion();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuClientes frm = new MenuClientes();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            SqlConnection cnEnvios = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            cnEnvios = ac.ObtenerConexion();

            GestionClientes gc = new GestionClientes();
            DataTable dtClientes = new DataTable();
            dtClientes = gc.ObtenerTodos();

            grdClientes.DataSource = dtClientes;
            txtDni.Text = "";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != "")
            {
                SqlConnection cnEnvios = new SqlConnection();
                AccesoDatos ac = new AccesoDatos();
                cnEnvios = ac.ObtenerConexion();

                GestionClientes gc = new GestionClientes();
                DataTable dtClientes = new DataTable();
                dtClientes = gc.ObtenerDni(txtDni.Text);

                grdClientes.DataSource = dtClientes;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
