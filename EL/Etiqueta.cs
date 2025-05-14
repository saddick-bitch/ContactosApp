using System.Collections.Generic;

namespace EL
{
    public class Etiqueta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual List<ContactoEtiqueta> ContactoEtiquetas { get; set; }
    }
}
