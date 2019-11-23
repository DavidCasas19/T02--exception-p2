using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        { 
            //instanciamos 
            var Estudiantes = new List<Estudiante>();
            //hacemos una variable agregar para que el while se pueda utilizar
            var agregar = true;
            //Declaramos variables
            bool Result;
            var E = new Estudiante();
            int M = E.Matricula;
            
            while (agregar)
            {
                //hacemos un try
                try
                {
                    //Le pedimos al usuario que ingrese los datos
                    Console.WriteLine("Escribe tu nombre");
                    E.Nombre = Console.ReadLine();
                    Console.WriteLine("Escribe tu Carrera");
                    E.Carrera = Console.ReadLine();
                    Console.WriteLine("Escribe tu semestre actual");
                    E.Semestre = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escribe tu Matricula");
                    //hacemos un tryparse
                    Result= int.TryParse(Console.ReadLine(), out M);
                    //hacemos por si el usuario ingresa un dato que no es correcto y le pedimos que lo ingrese
                    if (Result == false)
                    {
                        Console.WriteLine("Ingrese un numero");
                        Console.WriteLine("");
                        Result=int.TryParse(Console.ReadLine(),out M);
                        
                    }
                    //agregamos los datos a la lista
                    Estudiantes.Add(E);
                    //le preguntamos al usuario si desea agregar otro alumno
                    Console.WriteLine("Desea agrear otro usuario:\nY/N");
                    if(Console.ReadLine()!="Y")
                    {
                        agregar = false;
                    }
                }
                //Ponemos el catch
                catch(Exception)
                {

                }
                //Conclusion
                /*
                El trycatch es super util que podemos usar cuando el usuario ingrese o haga algo que no deberia de hacer 
                y nos ayuda a prevenir errores 
                */
            }
                
        }
    }
}
