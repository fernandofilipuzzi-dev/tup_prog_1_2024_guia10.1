using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        #region 
        int bici = 0;
        double distanciaBici = 0;//acumulador

        int moto = 0;
        double distanciaMoto = 0;

        int auto = 0;
        int publico = 0;

        void RegistrarEncuesta(int tipoVehiculo, double distancia)
        {
            switch (tipoVehiculo)
            {
                case 1: 
                    {
                        bici++;
                        distanciaBici += distancia;
                    }
                    break;
                case 2:
                    {
                        moto++;
                        distanciaMoto += distancia;
                    }
                    break;
                case 3:
                    {
                        auto++;
                    }
                    break;
                case 4:
                    {
                        publico++;
                    }
                    break;
            }
        }

        int CalcularPoblacion()
        {
            return bici + moto + auto + publico;
        }

        double DistanciaPromedioBicicleta()
        {
            double promedio = 0;
            if (bici > 0)
                promedio = distanciaBici / bici;
            return promedio;
        }

        double DistanciaPromedioMoto()
        {
            double promedio = 0;
            if (moto > 0)
                promedio = distanciaMoto / moto;
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
                bici++;
                distanciaBici += distancia;
            }
            else if (rbMoto.Checked)
            {
                moto++;
                distanciaMoto+= distancia;
            }
            else if (rbAuto.Checked)
            {
                auto++;
            }
            else if (rbPublico.Checked)
            {
                publico++;
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
            listBox1.Items.Add($"- Bicicleta: {bici}");
            listBox1.Items.Add($"- Motocicleta: {moto}");
            listBox1.Items.Add($"- Automovil: {auto}");
            listBox1.Items.Add($"- Transporte público: {publico}");
            
            listBox1.Items.Add("-------------------------------");

            listBox1.Items.Add("Distencia promedio por tipo de vehículo:");
            listBox1.Items.Add($"- Bicicleta: {DistanciaPromedioBicicleta()}");
            listBox1.Items.Add($"- Moto: {DistanciaPromedioMoto()}");
        }
    }
}
