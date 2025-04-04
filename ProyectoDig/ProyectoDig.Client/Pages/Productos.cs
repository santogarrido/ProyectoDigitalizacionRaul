namespace ProyectoDig.Client.Pages
{
    public class Productos
    {
        private int Id { get; set; }

        private string Nombre { get; set; }

        private int Cantidad { get; set; }

        public Productos(int id, string nombre, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
        }
    }
}
