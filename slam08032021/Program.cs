using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slam08032021
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Dictionary<vol, Avion> Dicovol = new Dictionary<vol, Avion>();

            Avion A1 = new Avion(1, "Avion 1", "compagnie 1");
            Avion A2 = new Avion(2, "Avion 2", "compagnie 2");
            Avion A3 = new Avion(3, "Avion 3", "compagnie 3");

            vol V1 = new vol(1, new DateTime(2021, 03, 01), new DateTime(2021, 03, 01, 13, 15, 00), new DateTime(2021, 03, 01, 15, 15, 00));
            vol V2 = new vol(2, new DateTime(2021, 03, 01), new DateTime(2021, 03, 01, 13, 15, 00), new DateTime(2021, 03, 01, 15, 15, 00));

            Dicovol.Add(V1, A2);
            Dicovol.Add(V2, A1);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
