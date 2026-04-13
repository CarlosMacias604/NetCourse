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
Console.WriteLine("InventarioApp/");
Console.WriteLine("Program.cs");
Console.WriteLine("InventarioApp.csproj");
Console.WriteLine(".gitignore");
Console.WriteLine("README.md");
Console.WriteLine("src/");
Console.WriteLine("Models/");
Console.WriteLine("Metadatos Configurados");
Console.WriteLine();
Console.WriteLine("Proximo paso: Agregar argumentos CLI y configuracion de repositorio en GitHub");