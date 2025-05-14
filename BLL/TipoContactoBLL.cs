using DAL;
using EL;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class TipoContactoBLL
    {
        public List<TipoContacto> ObtenerTodos()
        {
            using (var db = new AgendaContext())
            {
                return db.TipoContactos.ToList();
            }
        }

        public void Insertar(TipoContacto tipoContacto)
        {
            using (var db = new AgendaContext())
            {
                db.TipoContactos.Add(tipoContacto);
                db.SaveChanges();
            }
        }

        public void Actualizar(TipoContacto tipoContacto)
        {
            using (var db = new AgendaContext())
            {
                var existente = db.TipoContactos.Find(tipoContacto.Id);
                if (existente != null)
                {
                    existente.Nombre = tipoContacto.Nombre;
                    db.SaveChanges();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new AgendaContext())
            {
                var tipoContacto = db.TipoContactos.Find(id);
                if (tipoContacto != null)
                {
                    db.TipoContactos.Remove(tipoContacto);
                    db.SaveChanges();
                }
            }
        }
    }
}
