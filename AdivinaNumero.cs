using System;

Main

 int intento = 7 // guardar los intentos que lleva el usuario
bool adivinado = false // para saber si ya adivino el numero
int numeroSecreto // aquí almaceno el número aleatorio
int intentoJugador //aqui guardo el numero dado por el jugador

escribir en consola "Adivina un numero"
numeroSecreto = Random(0,101)

while (intentos > 0 && !adivinado)
leer intentoJugador

 if (intentoJugador > numeroSecreto && intentoJugador =/ numeroSecreto)
imprimir "Demasiado alto"
--intentos

fin if 

if (intentoJugador < numeroSecreto && intentoJugador =/ numeroSecreto)
imprimir "Numero bajo"
--intentos

fin if


if (intentoJugador = numeroSecreto)
imprimir "Felicidades, lo lograste"
adivinado = true

fin if


fin while

    FinMain
