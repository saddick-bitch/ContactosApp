using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public class PaisDAL
    {
        public void Insertar(Pais pais)
        {
            using (var db = new AgendaContext())
            {
                db.Paises.Add(pais);
                db.SaveChanges();
            }
        }

        public List<Pais> ObtenerTodos()
        {
            using (var db = new AgendaContext())
            {
                return db.Paises.ToList();
            }
        }
    }
}
