using System;



class Program

{

&nbsp;   static void Main()

&nbsp;   {

&nbsp;       string\[] opciones = { "piedra", "papel", "tijeras" };

&nbsp;       Random random = new Random();

&nbsp;       bool jugarOtraVez = true;



&nbsp;       Console.WriteLine("=== Juego de Piedra, Papel o Tijeras ===");



&nbsp;       while (jugarOtraVez)

&nbsp;       {

&nbsp;           Console.Write("Elige piedra, papel o tijeras: ");

&nbsp;           string jugador = Console.ReadLine().ToLower();



&nbsp;           if (jugador != "piedra" \&\& jugador != "papel" \&\& jugador != "tijeras")

&nbsp;           {

&nbsp;               Console.WriteLine("Opción no válida, intenta de nuevo.\\n");

&nbsp;               continue;

&nbsp;           }



&nbsp;           string computadora = opciones\[random.Next(opciones.Length)];

&nbsp;           Console.WriteLine("La computadora elige: " + computadora);



&nbsp;           if (jugador == computadora)

&nbsp;           {

&nbsp;               Console.WriteLine("¡Empate!");

&nbsp;           }

&nbsp;           else if (

&nbsp;               (jugador == "piedra" \&\& computadora == "tijeras") ||

&nbsp;               (jugador == "papel" \&\& computadora == "piedra") ||

&nbsp;               (jugador == "tijeras" \&\& computadora == "papel")

&nbsp;           )

&nbsp;           {

&nbsp;               Console.WriteLine("¡Ganaste!");

&nbsp;           }

&nbsp;           else

&nbsp;           {

&nbsp;               Console.WriteLine("Perdiste");

&nbsp;           }



&nbsp;           Console.Write("\\n¿Quieres jugar otra vez? (s/n): ");

&nbsp;           string respuesta = Console.ReadLine().ToLower();

&nbsp;           jugarOtraVez = (respuesta == "s");

&nbsp;           Console.WriteLine();

&nbsp;       }



&nbsp;       Console.WriteLine("Gracias por jugar");

&nbsp;   }

}



