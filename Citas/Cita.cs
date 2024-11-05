namespace Citas
{
    public class Cita
    {
        #region Atributos

        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }

        public long telefono { get; set; }
        #endregion

        #region Constructor
        public Cita(int id,string nombre,string direccion,long telefono){
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;

        }
        #endregion
        // Anotacion mia
    }
}
