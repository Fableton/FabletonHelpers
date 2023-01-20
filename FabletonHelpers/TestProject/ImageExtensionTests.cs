
using FabletonImageSharpExtensions;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;

namespace TestProject
{
    public class ImageExtensionTests
    {
        [Fact]
        public void ToByteArray_EmptyTest()
        {
            byte[] bytes = ImageExtension.ToByteArray(null, null);
            Assert.Equal(0, bytes.Length);
        }

        [Fact]
        public void ToByteArray_MinTest()
        {
            Image<Rgba32> logo = Image.Load<Rgba32>("Resources/ImageTest1.jpg");
            byte[] bytes = ImageExtension.ToByteArray(logo, new JpegEncoder() { });
            Assert.Equal(256548, bytes.Length);
        }
    }
}