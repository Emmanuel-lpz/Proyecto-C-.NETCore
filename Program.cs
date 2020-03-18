using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("platzi", 2000, TiposEscuela.Primaria,
                        ciudad:"Clombia"
                        );
            
            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso() 
                                {
                                    Nombre = "101"
                                };

            var curso2 = new Curso() {
                Nombre = "202"
            };
            arregloCursos[1] = curso2;

            arregloCursos[2] = new Curso
                                {
                                    Nombre = "303"
                                };


            Console.WriteLine(escuela);
            System.Console.WriteLine("-------------------");
            Console.WriteLine(arregloCursos[0].Nombre);
            Console.WriteLine("presiona ENTER para continuar");
            Console.ReadLine();
            Console.WriteLine(arregloCursos[2].Nombre);

            ImprimirCursos(arregloCursos);

        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
                contador += 1;
            }
        }
    }
}
