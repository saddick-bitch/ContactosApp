using DAL;
using EL;
using System.Collections.Generic;
using System.Data.Entity;   // 👈 Importante para Include()
using System.Linq;

namespace BLL
{
    public class ContactoBLL
    {
        public List<Contacto> ObtenerTodosConRelaciones()
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

        public void Insertar(Contacto contacto, List<int> etiquetaIds)
        {
            using (var db = new AgendaContext())
            {
                db.Contactos.Add(contacto);
                db.SaveChanges();

                foreach (var etiquetaId in etiquetaIds)
                {
                    db.ContactoEtiquetas.Add(new ContactoEtiqueta
                    {
                        ContactoId = contacto.Id,
                        EtiquetaId = etiquetaId
                    });
                }
                db.SaveChanges();
            }
        }

        public void Actualizar(Contacto contacto, List<int> etiquetaIds)
        {
            using (var db = new AgendaContext())
            {
                var original = db.Contactos.Find(contacto.Id);
                if (original != null)
                {
                    original.Nombre = contacto.Nombre;
                    original.Apellido = contacto.Apellido;
                    original.Telefono = contacto.Telefono;
                    original.Correo = contacto.Correo;
                    original.TipoContactoId = contacto.TipoContactoId;
                    original.PaisId = contacto.PaisId;

                    // Eliminar etiquetas anteriores
                    var etiquetasAnteriores = db.ContactoEtiquetas.Where(ce => ce.ContactoId == contacto.Id).ToList();
                    db.ContactoEtiquetas.RemoveRange(etiquetasAnteriores);

                    // Agregar etiquetas nuevas
                    foreach (var etiquetaId in etiquetaIds)
                    {
                        db.ContactoEtiquetas.Add(new ContactoEtiqueta
                        {
                            ContactoId = contacto.Id,
                            EtiquetaId = etiquetaId
                        });
                    }

                    db.SaveChanges();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new AgendaContext())
            {
                var contacto = db.Contactos.Find(id);
                if (contacto != null)
                {
                    // Primero eliminar las etiquetas relacionadas
                    var etiquetas = db.ContactoEtiquetas.Where(ce => ce.ContactoId == id).ToList();
                    db.ContactoEtiquetas.RemoveRange(etiquetas);

                    db.Contactos.Remove(contacto);
                    db.SaveChanges();
                }
            }
        }

        public List<int> ObtenerEtiquetasPorContacto(int contactoId)
        {
            using (var db = new AgendaContext())
            {
                return db.ContactoEtiquetas
                         .Where(ce => ce.ContactoId == contactoId)
                         .Select(ce => ce.EtiquetaId)
                         .ToList();
            }
        }
    }
}
