// Declaración de variables
double comision = 0.1;
double v1, v2, v3;
string mensaje = " Fue la venta que te generó mayor comisión";

//Ingresar las ventas
Console.WriteLine("Ingrese el valor de su primera venta");
v1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor de su segunda venta");
v2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor de su tercera venta");
v3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Su ganancia por comisión es: " + ((v1 + v2 +v3) * comision));
double comisionT = ((v1 + v2 + v3) * comision);
Console.WriteLine("Su ganancia total es de: " + (v1 + v2 + v3 + comisionT));
double GananciaT = (v1 + v2 + v3 + comisionT);
if (v1 * comision > v2 * comision && v2 * comision > v3 * comision)
{
    Console.WriteLine(v1 + mensaje);
}
else if (v2 * comision > v3 * comision && v3 * comision > v1 * comision)
{
    Console.WriteLine(v2 + mensaje);
}
else
{
    Console.WriteLine(v3 + mensaje);
}

//No entendí la última pregunta