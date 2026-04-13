using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("========================================");
Console.WriteLine("     SISTEMA DE GESTION DE INVETARIO    ");
Console.WriteLine("========================================");
Console.WriteLine();
Console.WriteLine($"Version: {version}");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET version: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estructura del proyecto:");
Console.WriteLine("configuracion .csproj");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metadatos Configurados");
Console.WriteLine();
Console.WriteLine("Proximo paso: Agregar argumentos CLI y configuracion de repositorio en GitHub");