using System;
using System.Collections.Generic;
using System.IO; //acceso al sistema
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFormularios
{
    static class Logger
    {
        public static void Mensaje(string msg) {
            msg = DateTime.Now + " | " + msg;
            File.AppendAllText("d:\\Log.txt", msg + Environment.NewLine);
        }
    }
}
