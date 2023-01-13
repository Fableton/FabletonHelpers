using FabletonHelpers.Files;
namespace TestProject
{
    public class FileHelpersTest
    {
        [Fact]
        public void SizeSuffix_EmptyTest()
        {
            string value = FileHelpers.SizeSuffix(0);
            Assert.Equal(value, "0.0 bytes");
        }

        [Fact]
        public void SizeSuffix_NegativeNumber()
        {
            string value = FileHelpers.SizeSuffix(-1);
            Assert.Equal(value, "-1.0 bytes");
        }

        [Fact]
        public void SizeSuffix_Kbytes()
        {
            string value = FileHelpers.SizeSuffix(1024, 3);
            Assert.Equal(value, "1.000 KB");
        }

        [Fact]
        public void SizeSuffix_KbytesMinusOne()
        {
            string value = FileHelpers.SizeSuffix(1023, 3);
            Assert.Equal(value, "0.999 KB");
        }

        [Fact]
        public void SizeSuffix_Mbytes()
        {
            string value = FileHelpers.SizeSuffix(1048576, 20);
            Assert.Equal(value, "1.00000000000000000000 MB");
        }

        [Fact]
        public void SizeSuffix_MbytesMinusOne()
        {
            string value = FileHelpers.SizeSuffix(1048575, 20);
            Assert.Equal(value, "0.99999904632568359375 MB");
        }
    }
}