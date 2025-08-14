using System;



class Program

{

&nbsp;   static void Main()

&nbsp;   {

&nbsp;       

&nbsp;       int edad = 40; 

&nbsp;       string nombre = "Alberto"; 

&nbsp;       bool tieneLicencia = true; 



&nbsp;       

&nbsp;       if (edad >= 18)

&nbsp;       {

&nbsp;           Console.WriteLine(nombre + " puede conducir");

&nbsp;       }

&nbsp;       else

&nbsp;       {

&nbsp;           Console.WriteLine(nombre + " es menor de edad");

&nbsp;       }



&nbsp;       // Condición para la licencia

&nbsp;       if (tieneLicencia)

&nbsp;       {

&nbsp;           Console.WriteLine(nombre + " tiene licencia");

&nbsp;       }

&nbsp;       else

&nbsp;       {

&nbsp;           Console.WriteLine(nombre + " no tiene licencia");

&nbsp;       }

&nbsp;   }

}



