using Course._3_Mocking;
using Moq;
using NUnit.Framework;

namespace Course.UnitTests._3_Mocking
{
    [TestFixture]
    class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_VideoIsNull_ReturnErrorMesssage()
        {
            //arrange
            var mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(m => m.Read("video.txt")).Returns("");

            var videoService = new VideoService(mockFileReader.Object);

            //act
            var result = videoService.ReadVideoTitle("video.txt");

            //assert
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
