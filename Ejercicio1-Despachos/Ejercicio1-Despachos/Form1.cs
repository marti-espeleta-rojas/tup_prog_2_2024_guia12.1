using Ejercicio1_Despachos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Despachos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sucursal.RecibirCorrespondencia(47175513, "Martiniano", "Pellegrini 406");
            sucursal.RecibirCorrespondencia(24264435, "Luciana", "Paraguay 107");
            sucursal.RecibirCorrespondencia(12345678, "Javier", "Jamaica 878");
        }

        Despachador sucursal = new Despachador();
        Repartidor camion = null;

        private void btnRecibirCorrespondencia_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = Convert.ToInt32(tbDNI.Text);
                string nombre = tbNombre.Text;
                string direccion = tbDireccion.Text;
                Paquete pack = sucursal.RecibirCorrespondencia(dni, nombre, direccion);
                lbxVerSectorCarga.Items.Add(pack);
            }
            catch (FormatException ez)
            {
                MessageBox.Show(ez.Message, "Error al convertir texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbDNI.Clear();
                tbNombre.Clear();
                tbDireccion.Clear();
            }
        }

        private void btnPrepararCamion_Click(object sender, EventArgs e)
        {
            Form2 laCamio = new Form2();
            int cargaDisp = 0;
            try
            {
                if (laCamio.ShowDialog() == DialogResult.OK)
                {
                    cargaDisp = Convert.ToInt32(laCamio.nudCapacidad.Value);
                    if (cargaDisp > 0)
                    {
                        camion = sucursal.PrepararCamion(cargaDisp);
                    }
                }
                for (int i = 0; i < cargaDisp; i++)
                {
                    Paquete pack = sucursal.CargarPaqueteAlCamion();
                    camion.Cargar(pack);
                    lbxListadoAEntregar.Items.Add(pack);
                }
            }
            //excepción para el Convert.ToInt32
            catch(OverflowException ez)
            {
                MessageBox.Show(ez.Message);
            }
            //Excepción para ShowDialog()
            catch (InvalidOperationException ed)
            {
                MessageBox.Show(ed.Message, "Error al abrir nueva ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                laCamio.Close();
                laCamio.Dispose();
            }
        }

        private void btnIniciarReparto_Click(object sender, EventArgs e)
        {
            Paquete pack = null;
            if(camion != null)
            {
                pack = camion.Revisar();
                tbDNIProximo.Text = Convert.ToString(pack.DNIRemitente);
                tbDireccionProximo.Text = pack.Direccion;
                tbNombreProximo.Text = pack.NombreRemitente;
            }
        }

        private void btnEntregarPaquete_Click(object sender, EventArgs e)
        {
            tbDireccionProximo.Clear();
            tbDNIProximo.Clear();
            tbNombreProximo.Clear();
            Paquete pack = null;
            pack = camion.Descargar();
            lbxListadoAEntregar.Items.Remove(pack);
        }
    }
}
