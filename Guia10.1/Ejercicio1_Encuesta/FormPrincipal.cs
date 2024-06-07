using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Encuesta
{
    public partial class FormPrincipal : Form
    {
        #region variables y metodos del dominio del problema
        int Bici = 0;
        double DistanciaBici = 0;//acumulador

        int Moto = 0;
        double DistanciaMoto = 0;

        int Auto = 0;
        int Publico = 0;

        void RegistrarEncuesta(int tipoVehiculo, double distancia)
        {
            switch (tipoVehiculo)
            {
                case 1: 
                    {
                        Bici++;
                        DistanciaBici += distancia;
                    }
                    break;
                case 2:
                    {
                        Moto++;
                        DistanciaMoto += distancia;
                    }
                    break;
                case 3:
                    {
                        Auto++;
                    }
                    break;
                case 4:
                    {
                        Publico++;
                    }
                    break;
            }
        }

        int CalcularPoblacion()
        {
            return Bici + Moto + Auto + Publico;
        }

        double DistanciaPromedioBicicleta()
        {
            double promedio = 0;
            if (Bici > 0)
                promedio = DistanciaBici / Bici;
            return promedio;
        }

        double DistanciaPromedioMoto()
        {
            double promedio = 0;
            if (Moto > 0)
                promedio = DistanciaMoto / Moto;
            return promedio;
        }

        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            double distancia = Convert.ToInt32(tbDistancia.Text);
            
            int tipoVehiculo = 0;
            if (rbBicicleta.Checked) tipoVehiculo = 1;
            else if (rbMoto.Checked) tipoVehiculo = 2;
            else if (rbAuto.Checked) tipoVehiculo = 3;
            else if (rbPublico.Checked) tipoVehiculo = 4;

            RegistrarEncuesta(tipoVehiculo, distancia );

            #region opcion 2
            /*
             * opción 2
             * 
            double distancia = Convert.ToInt32(tbDistancia.Text);
            if (rbBicicleta.Checked)
            { 
                Bici++;
                DistanciaBici += distancia;
            }
            else if (rbMoto.Checked)
            {
                Moto++;
                DistanciaMoto+= distancia;
            }
            else if (rbAuto.Checked)
            {
                Auto++;
            }
            else if (rbPublico.Checked)
            {
                Publico++;
            }
            */
            #endregion

            #region clear
            rbBicicleta.Checked = false;
            rbMoto.Checked = false;
            rbAuto.Checked = false;
            rbPublico.Checked = false;
            tbDistancia.Clear();
            #endregion
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int poblacion = CalcularPoblacion();
            listBox1.Items.Add($"Población: {poblacion}");
            
            listBox1.Items.Add("-------------------------------");
            
            listBox1.Items.Add("Cantidad de personas que usan:");
            listBox1.Items.Add($"- Bicicleta: {Bici}");
            listBox1.Items.Add($"- Motocicleta: {Moto}");
            listBox1.Items.Add($"- Automovil: {Auto}");
            listBox1.Items.Add($"- Transporte público: {Publico}");
            
            listBox1.Items.Add("-------------------------------");

            listBox1.Items.Add("Distencia promedio por tipo de vehículo:");
            listBox1.Items.Add($"- Bicicleta: {DistanciaPromedioBicicleta():f2}");
            listBox1.Items.Add($"- Moto: {DistanciaPromedioMoto():f2}");
        }
    }
}
