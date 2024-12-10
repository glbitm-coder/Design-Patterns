// See https://aka.ms/new-console-template for more information
namespace CompressionFormat;

public static class Program
{
    static void Main(String[] args)
    {
        ICompression strategy = new ZipCompression();
        CompressionContext ctx = new CompressionContext(strategy);
        ctx.CreateArchive("DotNetDesignPattern");
        ctx.SetStrategy(new RarCompression());
        ctx.CreateArchive("DotNetDesignPattern");
        Console.Read();
    }
}
