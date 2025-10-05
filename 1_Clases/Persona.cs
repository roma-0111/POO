namespace _1_Clases
{
    internal class Persona
    {
        //Constructores
        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        public Persona() { }

        //Propiedades
        // Simplicado.
        public string Nombre { get; set; }
        private string DNI { get; set; }
        // Privados.
        private bool adultoSiONo = false;
        private int edad;

        //Setter y Getter
        // semi-Simplificado
        public int Edad
        {
            set { edad = value; }
            get
            {
                //  Edad mayor o igual a 0
                if (edad >= 18)
                {
                    adultoSiONo = true;
                    return edad;
                }
                else
                {
                    adultoSiONo = false;
                    return edad;
                }
            }
        }
        public bool GetADulto()
        {
            /*
             * Agregar posible 2da restricción si cumple en un lugar 
             * con distintas leyes...
             */
            return adultoSiONo;
        }
    }
}
