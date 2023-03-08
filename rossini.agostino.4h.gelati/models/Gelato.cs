using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace rossini.agostino._4h.gelati
{
    public class Gelato
    {

        public string Tipo { get; set; }

        public string Size { get; set; }

        public string Gusto { get; set; }

        public Gelato() { }

        public Gelato(string riga)
        {
            string[] colonne = riga.Split(";");
            Tipo = colonne[0];
            Size = colonne[1];
            Gusto = colonne[2];
        }
    }

    public class Gelati:List<Gelato> {

        public Gelati() { }

        public Gelati(string nomefile) 
        {
            StreamReader fin = new StreamReader(nomefile);
            fin.ReadLine();
            while(!fin.EndOfStream)
            {
                string riga = fin.ReadLine();
                Gelato g = new Gelato(riga);
                Add(g);
            }
            fin.Close();
        }
    } 
}
