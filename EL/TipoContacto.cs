using System.Collections.Generic;

namespace EL
{
    public class TipoContacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual List<Contacto> Contactos { get; set; }
    }
}
