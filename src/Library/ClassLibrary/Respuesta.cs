using System.Collections.Generic;

namespace PII_E13.ClassLibrary
{

    /// <summary>
    /// Clase que representa una respuesta a un mensaje.
    /// DOCUMENTAR PATRONES APLICADOS
    /// </summary>
    public class Respuesta : IRespuesta
    {

        /// <summary>
        /// Crea una instancia de <see cref="Respuesta"/> con un texto asignado y la indicación explícita
        /// sobre si se debe editar el último mensaje.
        /// </summary>
        public Respuesta(string IdUsuario, string texto, bool borrarMensaje)
        {
            this.IdUsuario = IdUsuario;
            this.Texto = texto;
            this.EditarMensaje = borrarMensaje;
            this.Botones = new List<List<IBoton>>();
        }

        /// <summary>
        /// Crea una instancia de <see cref="Respuesta"/> con un texto asignado.
        /// </summary>
        public Respuesta(string texto)
        {
            this.Texto = texto;
            this.EditarMensaje = false;
            this.Botones = new List<List<IBoton>>();
        }

        /// <summary>
        /// Texto del mensaje de la <see cref="Respuesta"/>.
        /// </summary>
        public string Texto { get; set; }

        /// <summary>
        /// Identificador único de un usuario en una plataforma de mensajería.
        /// </summary>
        public string IdUsuario { get; }

        /// <summary>
        /// Indica si el último mensaje debe ser editado, de ser posible.
        /// </summary>
        public bool EditarMensaje { get; set; }

        /// <summary>
        /// Matriz de botones enviados junto al mensaje
        /// </summary>
        public List<List<IBoton>> Botones { get; }
    }
}