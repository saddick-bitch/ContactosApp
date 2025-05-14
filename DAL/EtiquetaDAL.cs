using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public class EtiquetaDAL
    {
        public void Insertar(Etiqueta etiqueta)
        {
            using (var db = new AgendaContext())
            {
                db.Etiquetas.Add(etiqueta);
                db.SaveChanges();
            }
        }

        public List<Etiqueta> ObtenerTodos()
        {
            using (var db = new AgendaContext())
            {
                return db.Etiquetas.ToList();
            }
        }
    }
}
