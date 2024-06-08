using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_colectivo
{
    public partial class FormPrincipal : Form
    {
        #region dominio del problema
        int TiempoEnMMInicio = 0;
        int TiempoEnMMLLegada = 0;
        int TiempoTotalEnMMDemoras = 0;

        int CantidadPasajerosTransportados = 0;
        int CantidadParadas = 0;

        int CantidadDesciendenTotal = 0;
        int CantidadAsciendenTotal =0;

        int Asientos=0;
        int AsientosOcupados = 0;

        int TiempoEnMMUltimo = 0;//usado para verificar

        void RegistrarInicio(int hh, int mm, int a)
        {
            TiempoEnMMInicio = hh*60 + mm;
            Asientos = a;

            TiempoEnMMUltimo = TiempoEnMMInicio;
        }

        bool RegistrarParada(int HHParada,int MMParada,int descienden,
                                int HHSalida,int MMSalida,int ascienden, 
                                out int HH, out int MM)
        {
            HH = 0;
            MM = 0;
            bool fueRegistrado = false;

            //calculo de la demora en la parada
            int tiempoParadaLLegada=HHParada*60 + MMParada;
            int tiempoParadaSalida=HHSalida*60 + MMSalida;

            int aOcupar = AsientosOcupados + ascienden - descienden;

            //verifico que el tiempo fue bien cargado y la ocupación
            if (tiempoParadaSalida >= tiempoParadaLLegada &&  //salida mayor o igual a la llegada
                    tiempoParadaLLegada >= TiempoEnMMUltimo && //mayor o igual al de la ultima parada o inicio
                    aOcupar>=0 && aOcupar<=Asientos)//que no bajen o suban mas de los que debería
            {
                int tiempoDemora = tiempoParadaSalida-tiempoParadaLLegada;
                HH = tiempoDemora / 60;
                MM = tiempoDemora % 60;

                TiempoTotalEnMMDemoras += tiempoDemora;

                //pasajeros que van ascendiendo y descendiendo
                CantidadDesciendenTotal += descienden;
                CantidadAsciendenTotal += ascienden;

                AsientosOcupados = aOcupar;

                //cantidad de personas transportadas en total
                CantidadPasajerosTransportados += ascienden;
                CantidadParadas++;

                fueRegistrado = true;
                TiempoEnMMUltimo = tiempoParadaSalida;
            }

            return fueRegistrado;
        }

        bool FinalizarViaje(int HHLLegada,int MMLLegada)
        {
            int tiempo = HHLLegada * 60 + MMLLegada;
            bool valido = false;
            if (tiempo>TiempoEnMMUltimo)
            {
                TiempoEnMMLLegada = tiempo;
                valido = true;
            }
                            
            return valido;
        }

        void DuracionViaje(int HHLLegada, int MMLLegada)
        {
            TiempoEnMMLLegada = HHLLegada * 60 + MMLLegada;
        }

        void CalcularDuracionViajeSinDemora(out int HH, out int MM)
        {
            int tiempoDuracion = TiempoEnMMLLegada - TiempoEnMMInicio - TiempoTotalEnMMDemoras;
            HH = tiempoDuracion / 60;
            MM = tiempoDuracion % 60;
        }

        void TiempoTotalEnDemorasHHMM(out int HH, out int MM)
        {
            HH = TiempoTotalEnMMDemoras / 60;
            MM = TiempoTotalEnMMDemoras % 60;
        }

        double PorcentajeAsientosOcupados()
        {
            return AsientosOcupados / Asientos * 100;
        }

        #endregion
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciarRecorrido_Click(object sender, EventArgs e)
        {
            #region inicializo las variables
            TiempoEnMMInicio = 0;
            TiempoEnMMLLegada = 0;
            TiempoTotalEnMMDemoras = 0;
            CantidadPasajerosTransportados = 0;
            CantidadParadas = 0;
            CantidadDesciendenTotal = 0;
            CantidadAsciendenTotal = 0;
            Asientos = 0;
            AsientosOcupados = 0;
            TiempoEnMMUltimo = 0;
            #endregion

            int HH =Convert.ToInt32(tbHHInicio.Text);
            int MM = Convert.ToInt32(tbMMInicio.Text);
            int asientos = Convert.ToInt32(tbCantidadAsientos.Text);

            RegistrarInicio(HH, MM, asientos);

            #region clear
            gbInicioViaje.Enabled = false;
            gbParada.Enabled = true;
            gbLLegadaViaje.Enabled = true;
            //
            tbHHParada.Clear();
            tbMMParada.Clear();
            tbDescienden.Clear();
            tbHHSalida.Clear();
            tbMMSalida.Clear();
            tbAscienden.Clear();
            lbxResultadoParada.Items.Clear();
            //
            tbHHFin.Clear();
            tbMMFin.Clear();
            lbxResultadoFinal.Items.Clear();
            #endregion
        }

        private void btnRegistrarParada_Click(object sender, EventArgs e)
        {
            #region datos de entrada
            int HHParada = Convert.ToInt32(tbHHParada.Text);
            int MMParada = Convert.ToInt32(tbMMParada.Text);
            int descienden = Convert.ToInt32(tbDescienden.Text);

            int HHSalida = Convert.ToInt32(tbHHSalida.Text);
            int MMSalida = Convert.ToInt32(tbMMSalida.Text);
            int ascienden = Convert.ToInt32(tbAscienden.Text);
            #endregion 

            lbxResultadoParada.Items.Clear();

            int HH, MM;
            bool verificacion=RegistrarParada(HHParada, MMParada, descienden, 
                                                HHSalida, MMSalida, ascienden, 
                                                out HH, out MM);

            if (verificacion)
            {
                //-a
                lbxResultadoParada.Items.Add($"* Total de personas durante todo el viaje:");
                lbxResultadoParada.Items.Add($" - Que han descendido: {CantidadDesciendenTotal}");

                //-b
                lbxResultadoParada.Items.Add($" - Que han ascendido: {CantidadAsciendenTotal}");

                //-c
                lbxResultadoParada.Items.Add($"* Demora de la parada: {HH}:{MM}");

                //-d
                lbxResultadoParada.Items.Add($"* Porcentaje de ocupación: {PorcentajeAsientosOcupados():f2}%");
            }
            else
            {
                lbxResultadoParada.Items.Add("* Verifiquen los datos de entrada");
            }
        }

        private void btnFinalizarViaje_Click(object sender, EventArgs e)
        {
            gbParada.Enabled = false;

            int HHLLegada = Convert.ToInt32(tbHHFin.Text);
            int MMLLegada = Convert.ToInt32(tbMMFin.Text);

            bool verificacion=FinalizarViaje(HHLLegada, MMLLegada);

            if (verificacion)
            {

                lbxResultadoFinal.Items.Clear();
                int HH, MM;

                //-a
                lbxResultadoFinal.Items.Add($"*Durante todo el viaje:");
                lbxResultadoFinal.Items.Add($" - Cantidad Pasajeros transportados:{CantidadPasajerosTransportados}");

                //-b
                CalcularDuracionViajeSinDemora(out HH, out MM);
                lbxResultadoFinal.Items.Add($"* Duración del viaje: {HH}:{MM}");

                //-c
                lbxResultadoFinal.Items.Add($"* Cantidad de Paradas: {CantidadParadas}");

                //-d
                TiempoTotalEnDemorasHHMM(out HH, out MM);
                lbxResultadoFinal.Items.Add($"* TiempoTotalEnDemoras: {HH}:{MM}");

                //reinicio para el siguiente viaje
                gbInicioViaje.Enabled = true;
                gbLLegadaViaje.Enabled = false;
            }
            else
            {
                lbxResultadoFinal.Items.Add("Error!: Controle los datos ingresados");
            }
        }
    }
}
