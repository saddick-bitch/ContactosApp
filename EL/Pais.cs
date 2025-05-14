namespace EL
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }   // 👈 este campo es OBLIGATORIO para evitar CS117
    }
}
