//Declaración de variables
double tren1 = 80, tren2 = 100;
//Declaro una variable "Distancia" para denotar la distancia que hay entre los 2 trenes, el valor de esta variable va a ser la operación
//Distancia = velocidad * tiempo
double distancia = tren1 * 1;
Console.WriteLine("La distancia entre los dos trenes es: " + distancia);
//Hallamos la velocidad relativa entre los 2 trenes
double vr = tren2 - tren1;
Console.WriteLine("La velocidad relativa entre los dos trenes es de: " + vr);
//Tiempo que tardará en alcanzar el primer tren al segundo es: Tiempo = distancia/Velocidad relativa
Console.WriteLine("El tiempo que tardará el primer tren en alcanzar al segundo será de: " + distancia/vr);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("La hora en que el primer tren alcance al segundo será 15:00");
Console.ResetColor();