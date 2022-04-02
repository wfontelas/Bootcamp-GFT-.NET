var path = @"C:\workspace\Bootcamp GFT Start #3 .NET\14- Trabalhando com Arquivos e Streams em C#\DIRECTORY_AND_DIRECTORYINFO\globo";

using var fsw = new FileSystemWatcher(path);
fsw.Created += Oncreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine($"Monitorando evento na pasta {path}");
Console.WriteLine("Pressione [enter] para finaliza...");
Console.ReadLine();

void Oncreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo: {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi excluído o arquivo: {e.Name}");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"O arquivo {e.OldName} foi renomeado para:  {e.Name}");
}