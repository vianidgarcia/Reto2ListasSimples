namespace Reto2ListasSimples
{
    public class ListaSimple
    {
        public Nodo? Inicio { get; private set; }

        // Referencia al último nodo para insertar sin recorrer toda la lista
        private Nodo? final;

        public int Cantidad { get; private set; }

        public bool EstaVacia => Inicio == null;

        public bool Insertar(int id, string nombre, string pista, int peligro)
        {
            if (Buscar(id) != null)
                return false;

            Nodo nuevo = new Nodo(id, nombre, pista, peligro);

            if (Inicio == null)
            {
                Inicio = nuevo;
                final = nuevo;
            }
            else
            {
                final!.Siguiente = nuevo;
                final = nuevo;
            }

            Cantidad++;
            return true;
        }

        public Nodo? Buscar(int id)
        {
            Nodo? actual = Inicio;

            while (actual != null)
            {
                if (actual.Id == id)
                    return actual;

                actual = actual.Siguiente;
            }

            return null;
        }

        public bool Modificar(int id, string nombre, string pista, int peligro)
        {
            Nodo? nodo = Buscar(id);

            if (nodo == null)
                return false;

            nodo.Nombre = nombre;
            nodo.Pista = pista;
            nodo.Peligro = peligro;
            return true;
        }

        public bool Eliminar(int id)
        {
            if (Inicio == null)
                return false;

            // El nodo a eliminar es el primero
            if (Inicio.Id == id)
            {
                Inicio = Inicio.Siguiente;

                if (Inicio == null)
                    final = null;

                Cantidad--;
                return true;
            }

            Nodo anterior = Inicio;
            Nodo? actual = Inicio.Siguiente;

            while (actual != null)
            {
                if (actual.Id == id)
                {
                    // Se salta el nodo actual para desconectarlo de la ruta
                    anterior.Siguiente = actual.Siguiente;

                    if (actual == final)
                        final = anterior;

                    Cantidad--;
                    return true;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

            return false;
        }

        public int PeligroTotal()
        {
            int total = 0;
            Nodo? actual = Inicio;

            while (actual != null)
            {
                total += actual.Peligro;
                actual = actual.Siguiente;
            }

            return total;
        }

        // Devuelve la ruta en texto: Inicio → [A] → [B] → NULL
        public string RutaComoTexto()
        {
            string ruta = "Inicio";
            Nodo? actual = Inicio;

            while (actual != null)
            {
                ruta += $" → [{actual.Nombre}]";
                actual = actual.Siguiente;
            }

            return ruta + " → NULL";
        }
    }
}
