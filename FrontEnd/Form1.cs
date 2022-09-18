using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace FrontEnd
{
    public partial class Mi_Trabajo_Practico : Form
    {
        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();

    

        public Mi_Trabajo_Practico()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlmacenarRegistro_Click(object sender, EventArgs e)
        {
            //Validar que solo Ingrese un Nombre sin dejar espacios Vacios
            if (TxtNombre.Text=="")
            {
                error502.SetError(TxtNombre, "Error501:Debe ingresar un Nombre");
                TxtNombre.Focus();
                return;
            }
            
            error502.SetError(TxtNombre, "");


            //Validar que solo Ingrese datos Numericos
            decimal Identificacion;
            if (!Decimal.TryParse(TxtIdentificacion.Text, out Identificacion))
            {
                error502.SetError(TxtIdentificacion, "Error502:Debe ingresar un Numero");
                TxtNombre.Focus();
                return;
            }
            error502.SetError(TxtIdentificacion, "");


            //Validar que solo Ingrese datos Numericos
            decimal AsignacionDiario;
            if(!Decimal.TryParse(TxtAsignacionDiario.Text, out AsignacionDiario))
               {
                error502.SetError(TxtAsignacionDiario, "Error502:Debe ingresar un Numero");
                TxtNombre.Focus();
                return;
            }
            error502.SetError(TxtAsignacionDiario, "");


            //Validar que solo Ingrese datos Numericos
            decimal DiasLaburados;
            if (!Decimal.TryParse(TxtDiasLaburados.Text, out DiasLaburados))
            {
                error502.SetError(TxtDiasLaburados, "Error502:Debe ingresar un Numero");
                TxtNombre.Focus();
                return;
            }
            error502.SetError(TxtDiasLaburados, "");






            myEmpleado.Nombre= TxtNombre.Text;
            myEmpleado.Identificacion= TxtIdentificacion.Text;
            myEmpleado.AsignacionDia= Convert.ToDecimal(TxtAsignacionDiario.Text);
            myNomina.DiasLaburados= Convert.ToInt32(TxtDiasLaburados.Text);
            MessageBox.Show("Se guardo correctamente");
     
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            TxtTotalDevengado.Text= myNomina.CalcularSalario (Convert.ToInt32 (myNomina.DiasLaburados),
                Convert.ToDecimal(myEmpleado.AsignacionDia)).ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtIdentificacion.Clear();
            TxtAsignacionDiario.Clear();
            TxtDiasLaburados.Clear();
            TxtTotalDevengado.Clear();
        }
    }
    }

