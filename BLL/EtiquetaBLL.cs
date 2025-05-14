using DAL;
using EL;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class EtiquetaBLL
    {
        // ✅ Obtener todas las etiquetas
        public List<Etiqueta> ObtenerTodos()
        {
            using (var db = new AgendaContext())
            {
                return db.Etiquetas.ToList();
            }
        }

        // ✅ Insertar una etiqueta
        public void Insertar(Etiqueta etiqueta)
        {
            using (var db = new AgendaContext())
            {
                db.Etiquetas.Add(etiqueta);
                db.SaveChanges();
            }
        }

        // ✅ Actualizar una etiqueta existente
        public void Actualizar(Etiqueta etiqueta)
        {
            using (var db = new AgendaContext())
            {
                var existente = db.Etiquetas.Find(etiqueta.Id);
                if (existente != null)
                {
                    existente.Nombre = etiqueta.Nombre;
                    db.SaveChanges();
                }
            }
        }

        // ✅ Eliminar una etiqueta por ID
        public void Eliminar(int id)
        {
            using (var db = new AgendaContext())
            {
                var etiqueta = db.Etiquetas.Find(id);
                if (etiqueta != null)
                {
                    db.Etiquetas.Remove(etiqueta);
                    db.SaveChanges();
                }
            }
        }
    }
}
