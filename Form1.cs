using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int cero = 0;
        string cadena2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\D\\Desktop\\Prueba1\\bin\\Debug\\Recordatorios.accdb";
        string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Recordatorios.accdb";
        OleDbConnection CN;
        OleDbCommand CMANDO;
        OleDbDataAdapter ADAP;

        void Conectar() 
        {
        CN = new OleDbConnection(cadena);
        CN.Open();
        }

        void Desconectar()
        {
            CN = new OleDbConnection(cadena);
            CN.Close();
            CN.Dispose();

        }
        public DataTable editar()
        {
            int id= Convert.ToInt32(TxtId.Text);
            string Nombre = TxtName.Text;
            string importancia = TxtImportancia.Text;
            string hora = TxtHora.Text;
            DateTime fecha = DateTime.Parse(TxtFecha.Text);
            string query = "UPDATE RECORDATORIOS SET NOMBRE=(?),IMPORTANCIA=(?),FECHA=(?),HORA=(?) WHERE ID="+id;
            string query2 = "iNSERT INTO RECORDATORIOS(NOMBRE,IMPORTANCIA,FECHA,HORA) VALUES (?,?,?,?)";
            DataTable dt2 = new DataTable();
            CN = new OleDbConnection(cadena);
            CMANDO = new OleDbCommand(query, CN);
            CMANDO.Parameters.AddWithValue("?", Nombre);
            CMANDO.Parameters.AddWithValue("?", importancia);
            CMANDO.Parameters.AddWithValue("?", fecha);
            CMANDO.Parameters.AddWithValue("?", hora);
            //CMANDO.Parameters.AddWithValue("?", id);
            ADAP = new OleDbDataAdapter(CMANDO);

            try
            {

                Conectar();
                ADAP.Fill(dt2);
                return dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hubo un error al cargar datos", ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return dt2;

        }
        public DataTable Agregar()
        {

            string Nombre =TxtName.Text;
            string importancia= TxtImportancia.Text;
           string hora = TxtHora.Text;
            DateTime fecha =DateTime.Parse(TxtFecha.Text);
            string query = "iNSERT INTO RECORDATORIOS(NOMBRE,IMPORTANCIA,FECHA,HORA) VALUES (?,?,?,?)";
            string query2 = "iNSERT INTO RECORDATORIOS(NOMBRE,IMPORTANCIA,FECHA,HORA) VALUES (?,?,?,?)";
            DataTable dt2 = new DataTable();
            CN = new OleDbConnection(cadena);
            CMANDO = new OleDbCommand(query, CN);
            CMANDO.Parameters.AddWithValue("?", Nombre);
            CMANDO.Parameters.AddWithValue("?",importancia);
            CMANDO.Parameters.AddWithValue("?",fecha);
            CMANDO.Parameters.AddWithValue("?",hora);
            ADAP = new OleDbDataAdapter(CMANDO);

            try
            {
                
                Conectar();
                ADAP.Fill(dt2);
                return dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hubo un error al cargar datos", ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return dt2;

        }

        public DataTable Carga()
        {
            string query = "SELECT * FROM RECORDATORIOS";
            DataTable dt = new DataTable();
            CN = new OleDbConnection(cadena);
            CMANDO = new OleDbCommand(query, CN);
            ADAP = new OleDbDataAdapter(CMANDO);

            try
            {
                
            Conectar();
           ADAP.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("hubo un error al cargar datos",ex.Message);
            }
            finally 
            {
            Desconectar();
            }

            return dt ;

        }
        public DataTable Borrar()
        {
            int ID=Convert.ToInt32(TxtId.Text);
            string query = "DELETE  FROM RECORDATORIOS WHERE iD = ?";
            DataTable dt = new DataTable();
            CN = new OleDbConnection(cadena);
            CMANDO = new OleDbCommand(query, CN);
            CMANDO.Parameters.AddWithValue("?",ID);
            ADAP = new OleDbDataAdapter(CMANDO);

            try
            {

                Conectar();
                ADAP.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hubo un error al cargar datos", ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return dt;

        }
        void Cargargrid()
        {
            DataTable dt = Carga();

            DTGV1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            Cargargrid();
            
        }
        void limpiarTxts()
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtFecha.Text = "";
            TxtHora.Text = "";
            TxtImportancia.Text = "";
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt = Agregar();
           
            DTGV1.DataSource = dt;
            Cargargrid();
            limpiarTxts();
        }

        private void BtnVaciar_Click(object sender, EventArgs e)
        {
            
            DTGV1.DataSource = null;
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Cargargrid();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DataTable dt = Borrar();
            DTGV1.DataSource= dt;
            Cargargrid();
            limpiarTxts();
        }

        private void DTGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cero = e.RowIndex;// contiene el indice de la fila selecionada
            int c = e.ColumnIndex;// contiene el indice de la columna selecionada

            if (cero != -1)//solo hago que aparezca la descripcion si la fila es mayor a -1 //y una columna que exista osea mayor a 0// no funcio no
            {
                var valor4 = DTGV1.Rows[cero].Cells[4].Value;
                var valor3 = DTGV1.Rows[cero].Cells[3].Value;
                var valor2 = DTGV1.Rows[cero].Cells[2].Value;
                var valor1 = DTGV1.Rows[cero].Cells[1].Value;//nombre
                var valor0 = DTGV1.Rows[cero].Cells[0].Value; // ID en columna 0
                if (valor0 != null)
                {
                    TxtId.Text = valor0.ToString(); // Lo convierte a texto 
                    TxtFecha.Text = valor3.ToString();
                    TxtImportancia.Text = valor2.ToString();
                    TxtHora.Text = valor4.ToString();
                    TxtName.Text = valor1.ToString();
                }
            }
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int TeclaInput = e.KeyChar;
            int enter = 13;
            int scape = 27;

            if (TeclaInput == enter)
            {
                BtnAgregar_Click(sender, e);
            }
            else if (TeclaInput == scape)
            {

                BtnEliminar_Click(sender, e);
            }
        }

        private void TxtImportancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            int TeclaInput = e.KeyChar;
            int enter = 13;
            int scape = 27;
            if (TeclaInput == enter)
            {
                BtnAgregar_Click(sender, e);
            }
            else if (TeclaInput == scape)
            {

                BtnEliminar_Click(sender, e);
            }
        }

        private void TxtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            int TeclaInput = e.KeyChar;
            int enter = 13;
            int scape = 27;

            if (TeclaInput == enter)
            {
                BtnAgregar_Click(sender, e);
            }
            else if (TeclaInput == scape)
            {

                BtnEliminar_Click(sender, e);
            }
        }

        private void TxtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            int TeclaInput = e.KeyChar;
            int enter = 13;
            int retroceso = 08;
            int scape = 27;
            if (TeclaInput == enter)
            {
                BtnAgregar_Click(sender, e);
            }
            else if (TeclaInput == scape) 
            {
               
                BtnEliminar_Click(sender, e);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DataTable dt = editar();

            DTGV1.DataSource = dt;
            Cargargrid();
            limpiarTxts();
        }
    }
}
