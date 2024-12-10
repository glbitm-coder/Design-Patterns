using System;
namespace CompressionFormat;

public class CompressionContext
{
	private ICompression _compression;
    public CompressionContext(ICompression compression)
    {
        _compression = compression;
    }
    
    public void SetStrategy(ICompression compression)
    {
        _compression = compression;
    }

    public void CreateArchive(string compressedArchiveFileName)
    {
        _compression.CompressFolder(compressedArchiveFileName);
    }
}
