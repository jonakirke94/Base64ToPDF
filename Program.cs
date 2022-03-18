using System.Diagnostics;

var base64str = args.AsQueryable().FirstOrDefault();

if (base64str == null)
{
    Console.WriteLine("Please insert a base64 string");
    return;
}

byte[] fileArray = Convert.FromBase64String(base64str);
string path = Directory.GetCurrentDirectory() + "\\" + Guid.NewGuid() + ".pdf";
Console.WriteLine(path);
File.WriteAllBytes(path, fileArray);
new Process
{
    StartInfo = new ProcessStartInfo(path)
    {
        UseShellExecute = true
    }
}.Start();