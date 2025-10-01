using System;
using System.Collections.Generic;

namespace _1_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcion = 'n';
            List<Persona> personas = new List<Persona>();

            while (opcion == 'n')
            {



                //Pregunta para salir
                Console.Write("¿Desea salir? (n/s): ");
                opcion = Convert.ToChar(Console.ReadLine());

            }

            verLista(personas);


        }

        static void verLista(List<Persona> personas)
        {
            foreach (Persona persona in personas)
            {
                //Console.WriteLine(persona.);
            }
        }
    }

    //Variable Globlal
    class Persona
    {
        //Propiedades
        private string nombre;
        private string apellido;
        private int edad;
        private bool adulto;

        //Getters y Setters:
        // Get y Set de nombre
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        // Get y Set de apellido
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                nombre = value;
            }
        }

        // Get y Set de edad
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value >= 18)
                {
                    edad = value;
                    adulto = true;
                }
                else
                {
                    edad = value;
                    adulto = false;
                }
            }

        }


    }



}
