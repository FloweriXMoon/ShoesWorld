using System;
using System.IO;

Console.WriteLine("=== Содержимое диска C:\\ ===\n");

// Информация о диске
var drive = new DriveInfo("C");
Console.WriteLine($"Всего: {drive.TotalSize / (1024 * 1024 * 1024)} ГБ | " +
                  $"Свободно: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} ГБ\n");

var root = new DirectoryInfo(@"C:\");

// Папки
foreach (var dir in root.GetDirectories())
{
    Console.WriteLine($"[ПАПКА]  {dir.Name}");
}

// Файлы
foreach (var file in root.GetFiles())
{
    Console.WriteLine($"[ФАЙЛ]   {file.Name}  ({file.Length / 1024} КБ)");
}

Console.WriteLine("\nНажмите Enter для выхода...");
Console.ReadLine();