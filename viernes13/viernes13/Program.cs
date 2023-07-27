/*
 * Crea una función que sea capaz de detectar si existe un viernes 13 en el mes y el año indicados.
 * - La función recibirá el mes y el año y retornará verdadero o falso.
 */

Console.WriteLine("Ingrese su fecha a validar en el siguiente formato YYYY-MM ");
DateTime fecha = new DateTime();
DateTime.TryParse(Console.ReadLine() + "-13", out fecha);



if (fecha.DayOfWeek.Equals(DayOfWeek.Friday)) Console.WriteLine("si hay viernes 13");
else Console.WriteLine("No hay viernes 13");


