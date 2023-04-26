using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memo.models
{
    public class Memo

    {
        public string id { get; set; }
        public string tituloMemo { get; set; }
        public string memo { get; set; }
        public string fecha { get; set; }
        public string memoFinalizado { get; set; }

        public string tituloDelMemo 
        { 
            get { return tituloMemo; }
        }


        public override string ToString()
        {
            return tituloDelMemo;
        }





    }
}
