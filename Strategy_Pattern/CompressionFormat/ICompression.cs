using System;
namespace CompressionFormat;
public interface ICompression
{
	void CompressFolder(string compressedArchiveFileName);
}
