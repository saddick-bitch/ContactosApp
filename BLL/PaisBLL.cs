using DAL;
using EL;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class PaisBLL
    {
        public List<Pais> ObtenerTodos()
        {
            using (var db = new AgendaContext())
            {
                return db.Paises.ToList();
            }
        }

        public void Insertar(Pais pais)
        {
            using (var db = new AgendaContext())
            {
                db.Paises.Add(pais);
                db.SaveChanges();
            }
        }

        public void Actualizar(Pais pais)
        {
            using (var db = new AgendaContext())
            {
                var entity = db.Paises.Find(pais.Id);
                if (entity != null)
                {
                    entity.Nombre = pais.Nombre;
                    entity.Codigo = pais.Codigo;
                    db.SaveChanges();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new AgendaContext())
            {
                var entity = db.Paises.Find(id);
                if (entity != null)
                {
                    db.Paises.Remove(entity);
                    db.SaveChanges();
                }
            }
        }
    }
}
