using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using memo.models;


namespace memo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescarlista();

            
            
        }

        public void Refrescarlista()
        {
            MemoDao inicializar = new MemoDao();
            string esMemoFinalizado = "0";
            List<Memo> listadb = inicializar.LeerBaseDeDatos(esMemoFinalizado);

            TxtList.Items.Clear(); // limpiamos el cuadro de texto

            for (int i = 0; i < listadb.Count; i++) // cargamos el cuadro de texto con la BD
            {
                Memo memo = listadb[i];
                //TxtList.Items.Add(memo.tituloMemo);
                TxtList.Items.Add(memo);
            }



        }

        private void txtList_SelectedIndexChanged(object sender, EventArgs e)
        {
                                   
            Memo seleccion = (Memo)TxtList.SelectedItem;
            
            GestionMemos ventana = new GestionMemos();
            ventana.FormularioParaModificar(seleccion);
            Refrescarlista();

        }

        private void txtList_DoubleClick(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionMemos abrirVentana = new GestionMemos();
            abrirVentana.ShowDialog();
            Refrescarlista();

        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
           

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            MemoDao inicializar = new MemoDao();
            string esMemoFinalizado = "1";
            List<Memo> listadb = inicializar.LeerBaseDeDatos(esMemoFinalizado);

            TxtList.Items.Clear(); // limpiamos el cuadro de texto

            for (int i = 0; i < listadb.Count; i++) // cargamos el cuadro de texto con la BD
            {
                Memo memo = listadb[i];
                //TxtList.Items.Add(memo.tituloMemo);
                TxtList.Items.Add(memo);
            }


        }
    }
}
