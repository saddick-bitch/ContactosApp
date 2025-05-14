using System.Collections.Generic;

namespace EL
{
    public class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public int TipoContactoId { get; set; }
        public virtual TipoContacto TipoContacto { get; set; }

        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }

        public virtual List<ContactoEtiqueta> ContactoEtiquetas { get; set; }
    }
}
