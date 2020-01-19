using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPicoPlaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Funcion para limpiar los datos de todos los campos
        void LimpiarCampos()
        {
            txtPlaca.Clear();
            dtpFecha.Text = "";
            dtpHora.Text = "";
            lblResultado.Text = "";
        }

        private bool ComprobarDia(int ultimoNumero, DateTime fecha)
        {
            bool resultadoComprobacion;
            switch (ultimoNumero)
            {
                case 1:
                    if (fecha.DayOfWeek.ToString()=="Monday")
                        resultadoComprobacion = true;
                    else
                        resultadoComprobacion = false;
                    break;
                case 2:
                    if (fecha.DayOfWeek.ToString() == "Monday")
                        resultadoComprobacion = true;
                    else
                        resultadoComprobacion = false;
                    break;
                case 3:
                    if (fecha.DayOfWeek.ToString() == "Tuesday")
                        resultadoComprobacion = true;
                    else
                        resultadoComprobacion = false;
                    break;
                case 4:
                    if (fecha.DayOfWeek.ToString() == "Tuesday")
                        resultadoComprobacion = true;
                    else
                        resultadoComprobacion = false;
                    break;
                case 5:
                    if (fecha.DayOfWeek.ToString()=="Wednesday")
                        resultadoComprobacion = true;
                    else
                        resultadoComprobacion = false;
                    break;
                case 6:
                    if (fecha.DayOfWeek.ToString() == "Wednesday")
                        resultadoComprobacion = true;
                    else
                        resultadoComprobacion = false;
                    break;
                case 7:
                    if (fecha.DayOfWeek.ToString()=="Thursday")
                        resultadoComprobacion = true;
                    else
                        resultadoComprobacion = false;
                    break;
                case 8:
                    if (fecha.DayOfWeek.ToString() == "Thursday")
                        resultadoComprobacion = true;
                    else
                        resultadoComprobacion = false;
                    break;
                case 9:
                    if (fecha.DayOfWeek.ToString() == "Friday")
                        resultadoComprobacion = true;
                    else
                        resultadoComprobacion = false;
                    break;
                case 0:
                    if (fecha.DayOfWeek.ToString() == "Friday")
                        resultadoComprobacion = true;
                    else
                        resultadoComprobacion = false;
                    break;
                default:
                    resultadoComprobacion = false;
                    break;
            }
            return resultadoComprobacion;
        }

        private bool ComprobarHorario(DateTime hora)
        {
            bool resultadoComprobacion = false;
            if (hora >= Convert.ToDateTime("07:00:00") && hora <= Convert.ToDateTime("09:30:00"))
            {
                resultadoComprobacion = true;

            }
            else if (hora >= Convert.ToDateTime("16:00:00") && hora <= Convert.ToDateTime("19:30:00"))
            {
                resultadoComprobacion = true;
            }
            else
            {
                resultadoComprobacion = false;
            }
            return resultadoComprobacion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnPredecir_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            int ultimoNumero = Convert.ToInt32(placa.Substring(placa.Length - 1, 1));
            lblResultado.Text = ultimoNumero.ToString();
            DateTime fecha = dtpFecha.Value.Date;
            DateTime hora = dtpHora.Value;
            Console.WriteLine(ultimoNumero);
            Console.WriteLine(fecha.DayOfWeek);
            if (ComprobarDia(ultimoNumero, fecha) && ComprobarHorario(hora))
            {
                lblResultado.Text = "El auto tiene restricción para circular";
            }
            else
            {
                lblResultado.Text = "El auto puede circular libremente";
            }
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
