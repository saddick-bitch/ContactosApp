using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EL;

namespace DAL
{
    public class ContactoDAL
    {
        public void Insertar(Contacto contacto)
        {
            using (var db = new AgendaContext())
            {
                db.Contactos.Add(contacto);
                db.SaveChanges();
            }
        }

        public List<Contacto> ObtenerTodos()
        {
            using (var db = new AgendaContext())
            {
                return db.Contactos
                    .Include(c => c.TipoContacto)
                    .Include(c => c.Pais)
                    .Include(c => c.ContactoEtiquetas.Select(ce => ce.Etiqueta))
                    .ToList();
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new AgendaContext())
            {
                var contacto = db.Contactos.Find(id);
                if (contacto != null)
                {
                    db.Contactos.Remove(contacto);
                    db.SaveChanges();
                }
            }
        }
    }
}
