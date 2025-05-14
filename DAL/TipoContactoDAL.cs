using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public class TipoContactoDAL
    {
        public void Insertar(TipoContacto tipoContacto)
        {
            using (var db = new AgendaContext())
            {
                db.TipoContactos.Add(tipoContacto);
                db.SaveChanges();
            }
        }

        public List<TipoContacto> ObtenerTodos()
        {
            using (var db = new AgendaContext())
            {
                return db.TipoContactos.ToList();
            }
        }
    }
}
