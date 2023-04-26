using memo.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memo
{
    internal class MemoDao
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string baseDeDatos = "leoa_memos";
            string usuario = "root";
            string password = "";

            string cadenaDeConexion = "Database = " + baseDeDatos + "; Data Source = " + servidor + "; User Id =" + usuario + "; Password=" + password + "";
            //string cadenaDeConexion = "Database=leoa_memos; Data Source = http://leontravel.com.ar/; User Id = leoa; Password = Password1.";
            MySqlConnection conexionDb = new MySqlConnection(cadenaDeConexion);
            conexionDb.Open();
            
            return conexionDb;
        }
        

            public List<Memo> LeerBaseDeDatos(string esMemoFinalizado)
           
            {

            List<Memo> listado = new List<Memo>();

            string consulta = "SELECT * FROM `memos` WHERE `memo_finalizado` = "+ esMemoFinalizado +"";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read()) 
            { 
             Memo memo = new Memo();
                memo.id = lectura.GetString("id_memo");
                memo.tituloMemo = lectura.GetString("titulo_memo");
                memo.memo = lectura.GetString("memo");
                memo.fecha = lectura.GetString("fecha_memo");
                memo.memoFinalizado = lectura.GetString("memo_finalizado");
                listado.Add(memo);
              

             };     
            comando.Connection.Close();
                      
            return listado;

        }

        public void Insertar(Memo memo)
        {            
            string cadenaDeTexto = "INSERT INTO `memos` (`id_memo`, `titulo_memo`, `memo`, `fecha_memo`, `memo_finalizado`) " +
                "VALUES (NULL, '"+ memo.tituloMemo +"', '"+ memo.memo +"','"+ memo.fecha +"', '0');";
            MySqlCommand comando = new MySqlCommand(cadenaDeTexto);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();

        }

        public void Modificar(Memo memo)
        {
            string idmemo=(string)memo.id;
            string cadenaDeTexto = "UPDATE `memos` SET `titulo_memo` = '"+ memo.tituloMemo + "', `memo` = '"+ memo.memo + "', `fecha_memo` = '"+ memo.fecha + "', `memo_finalizado` = '"+memo.memoFinalizado+"' WHERE `memos`.`id_memo` ='"+idmemo+"';";
                                   
            MySqlCommand comando = new MySqlCommand(cadenaDeTexto);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();


        }
    }

   
}
