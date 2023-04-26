using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using memo.models;


namespace memo
{
    public partial class GestionMemos : Form
    {
        public void FormularioParaModificar(Memo m)
        {
            
            GestionMemos ventana = new GestionMemos();
            if (m.memoFinalizado!="0")
               { ventana.Realizado.Checked = true; };

            ventana.TxtTitulo.Text = m.tituloMemo;
            ventana.TxtMemo.Text = m.memo;
            ventana.TxtFecha.Text = m.fecha;
            ventana.Realizado.Enabled = true;
            ventana.btnGuardar.Text = "Actualizar";
            ventana.labelId.Text = m.id;
            ventana.ShowDialog();




        }

        public GestionMemos()
        { 
             InitializeComponent();
           
        }

        private void txtFecha_Click(object sender, EventArgs e)
        {

        }

        private void GestionMemos_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString();
            TxtFecha.Text = fecha;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GestionMemos.ActiveForm.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Memo memo = new Memo();            
            memo.memo = TxtMemo.Text;
            memo.tituloMemo = TxtTitulo.Text;
            memo.fecha = TxtFecha.Text;
            bool verdadero = Realizado.Checked;

            if (verdadero)
            {
                memo.memoFinalizado = "1";
            }
            else {
                memo.memoFinalizado = "0";
            };

            MemoDao baseDeDatos = new MemoDao();

            if (btnGuardar.Text != "Actualizar")
            {
              baseDeDatos.Insertar(memo);
            }
            else
            {
                memo.id = labelId.Text;
                baseDeDatos.Modificar(memo);
            };
                
            GestionMemos.ActiveForm.Close();



                       
            
            


        }
    }
}
