using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaU
{
    public partial class frmConvert : Form
    {
        public frmConvert()
        {
            InitializeComponent();
        }

       
        private void btnConvert_Click(object sender, EventArgs e)
        {
         
            if (((txtCantidad.Text=="") || (cmbDestino.Text=="") || (cmbOrigen.Text=="")))
            {
                MessageBox.Show("Campo vacio");
            }
            else if ((((cmbOrigen.Text=="--Unidades de Masa--") || (cmbOrigen.Text=="--Unidades de Longitud--") || (cmbOrigen.Text=="--Unidades de Temperatura--")|| (cmbOrigen.Text=="--Unidades de Tiempo---"))))
            {
                 MessageBox.Show("ERROR, Seleccione una Unidad");
            }
            else if ((((cmbDestino.Text == "--Unidades de Masa--") || (cmbDestino.Text == "--Unidades de Longitud--") || (cmbDestino.Text == "--Unidades de Temperatura--") || (cmbDestino.Text == "--Unidades de Tiempo---"))))
            {
                MessageBox.Show("ERROR, Seleccione una Unidad");
            }
            else
            {
                int n = dataGridView1.Rows.Add();
               
                
            String from, to;

            from = cmbOrigen.SelectedItem.ToString();
            to = cmbDestino.SelectedItem.ToString();

            if (from == "Gramo" && to == "Kilogramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.001);
            }
            else
            if (from == "Kilogramo" && to == "Gramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1000);
            }
            if (from == "Onza" && to == "Gramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad) * 28.349);
            }
            if (from == "Gramo" && to == "Onza")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad) * 0.035274);
            }
            if (from == to)
            {
                MessageBox.Show("Has introducido las mismas unidades");
                txtCantidad.Text = "";
                txtRespuesta.Text = "";
                cmbDestino.Text = "";
                cmbOrigen.Text = "";
            }
            ///KILOGRAMO CONTRA TODOS///
            if (from == "Kilogramo" && to == "Tonelada")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.001);
            }
            if (from == "Kilogramo" && to == "Gramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1000);
            }
            if (from == "Kilogramo" && to == "Miligramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1000000);
            }
            if (from == "Kilogramo" && to == "Libra")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 2.20462);
            }
            if (from == "Kilogramo" && to == "Onza")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 35.274);
            }
            ///GRAMO CONTRA TODOS
            if (from == "Gramo" && to == "Tonelada")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.000001);
            }
            if (from == "Gramo" && to == "Kilogramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.001);
            }
            if (from == "Gramo" && to == "Miligramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1000);
            }
            if (from == "Gramo" && to == "Libra")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.00220462);
            }
            if (from == "Gramo" && to == "Onza")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.0352739200000000003);
            }
            ///MILIGRAMO CONTRA TODO
            if (from == "Miligramo" && to == "Tonelada")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.000000001);
            }
            if (from == "Miligramo" && to == "Kilogramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.000001);
            }
            if (from == "Miligramo" && to == "Gramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.001);
            }
            if (from == "Miligramo" && to == "Libra")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.000002204623);
            }
            if (from == "Miligramo" && to == "Onza")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.00003527396);
            }
            ///LIBRAS CONTRA TODOS
            if (from == "Libra" && to == "Tonelada")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.000453592);
            }
            if (from == "Libra" && to == "Kilogramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.453592);
            }
            if (from == "Libra" && to == "Gramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 453.592);
            }
            if (from == "Libra" && to == "Miligramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 453592);
            }
            if (from == "Libra" && to == "Onza")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 16);
            }
            ///ONZA CONTRA TODOS
            if (from == "Onza" && to == "Tonelada")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.00002834952);
            }
            if (from == "Onza" && to == "Kilogramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.0283495);
            }
            if (from == "Onza" && to == "Gramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 28.3495);
            }
            if (from == "Onza" && to == "Miligramo")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 28349.5);
            }
            if (from == "Onza" && to == "Libra")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.0625);
            }
            ///METRO CONTRA TODOS
            if (from == "Metro" && to == "Yarda")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1.09361);
            }
            if (from == "Metro" && to == "Vara")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1.1963081929167);
            }
            if (from == "Metro" && to == "Milla")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.000621371);
            }
            if (from == "Metro" && to == "Kilometro")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1000);
            }
            if (from == "Metro" && to == "Pie")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 3.28084);
            }
            if (from == "Metro" && to == "Pulgada")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 39.3701);
            }
            ///YARDA CONTRA TODOS
            if (from == "Yarda" && to == "Metro")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.9144);
            }
            if (from == "Yarda" && to == "Vara")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1.093904211603);
            }
            if (from == "Yarda" && to == "Milla")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.000568182);
            }
            if (from == "Yarda" && to == "Kilometro")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.0009144);
            }
            if (from == "Yarda" && to == "Pie")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 3);
            }
            if (from == "Yarda" && to == "Pulgada")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 36);
            }
            ///VARA CONTRA TODOS
            if (from == "Vara" && to == "Metro")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.835905);
            }
            if (from == "Vara" && to == "Yarda")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.91415682414698);
            }
            if (from == "Vara" && to == "Milla")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.00051940728644715);
            }
            if (from == "Vara" && to == "Kilometro")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.000835905);
            }
            if (from == "Vara" && to == "Pie")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 2.7424704724409);
            }
            if (from == "Vara" && to == "Pulgada")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 32.909645669291);
            }
            ///MILLA CONTRA TODOS
            if (from == "Milla" && to == "Metro")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1609.344);
            }
            if (from == "Milla" && to == "Yarda")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1760);
            }
            if (from == "Milla" && to == "Vara")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1925.2714124213);
            }
            if (from == "Milla" && to == "Kilometro")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1.609344);
            }
            if (from == "Milla" && to == "Pie")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 5280);
            }
            if (from == "Milla" && to == "Pulgada")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 63360);
            }

            ///HORAS  CONTRA TODOS
            if (from == "Horas" && to == "Minutos")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 60);
            }
            if (from == "Horas" && to == "Segundos")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 3600);
            }
            if (from == "Horas" && to == "Dia")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.0416667);
            }
            ///MINUTOS CONTRA TODOS
            if (from == "Minutos" && to == "Horas")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.0166667);
            }
            if (from == "Minutos" && to == "Segundos")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 60);
            }
            if (from == "Minutos" && to == "Dia")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.000694444);
            }
            ///SEGUDOS CONTRA TODOS
            if (from == "Segundos" && to == "Horas")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.000277778);
            }
            if (from == "Segundos" && to == "Minutos")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.0166667);
            }
            if (from == "Segundos" && to == "Dia")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 0.0000115741);
            }
            ///DIAS CONTRA TODOS
            if (from == "Dia" && to == "Horas")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 24);
            }
            if (from == "Dia" && to == "Minutos")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 1440);
            }
            if (from == "Dia" && to == "Segundos")
            {
                txtRespuesta.Text = Convert.ToString(Convert.ToInt32(txtCantidad.Text) * 86400);
            }
            if (from == to)
            {
                MessageBox.Show("Has introducido las mismas unidades");
            }
            ///
            dataGridView1.Rows[n].Cells[0].Value = cmbOrigen.SelectedItem.ToString();
            dataGridView1.Rows[n].Cells[1].Value = cmbDestino.SelectedItem.ToString();
            dataGridView1.Rows[n].Cells[2].Value = (txtRespuesta.Text);

            txtCantidad.Text = "";
            txtRespuesta.Text = "";
            cmbDestino.Text = "";
            cmbOrigen.Text = "";

            }

        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
