namespace Reto2ListasSimples
{
    public class Nodo
    {
        public int Id { get; }
        public string Nombre { get; set; }
        public string Pista { get; set; }
        public int Peligro { get; set; }

        // Solo ListaSimple puede cambiar los enlaces entre nodos
        public Nodo? Siguiente { get; internal set; }

        public Nodo(int id, string nombre, string pista, int peligro)
        {
            Id = id;
            Nombre = nombre;
            Pista = pista;
            Peligro = peligro;
            Siguiente = null;
        }
    }
}
