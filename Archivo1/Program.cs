// See https://aka.ms/new-console-template for more information


StreamWriter fichero;
string nombre = "tabla.txt";

//fichero = fila.AppendText(nombre);//crear el archivo o  lo reutiliza 
try
{
    StreamReader milectura= File.OpenText(nombre);//Abrio el archivo 
    Console.WriteLine(milectura);

}catch(Exception nsg)



