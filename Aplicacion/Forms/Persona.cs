#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms
{
    internal class Persona
    {
        #region Variables Globales
        string nombre;
        string apellido;
        int edad;
        #endregion

        #region Dar Datos a Objeto Persona
        public Persona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Edad = 0;
        }
        #endregion

        #region Declarar Datos del Objeto Persona
        public Persona(string nombre, string apellido, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }
        #endregion

        #region Get & Set
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        #endregion
    }
}