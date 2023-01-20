using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.Formats;

namespace FabletonImageSharpExtensions
{
    public static class ImageExtension
    {
        public static byte[] ToByteArray(this Image image, IImageEncoder encoder)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    image.Save(ms, encoder);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                return new byte[0];
            }
        }
    }
}