using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Atlas.Integration.Xbox.Test
{
    public class XboxClientTests
    {
        [Theory]
        [InlineData("desugoji", 1)]
        public async Task GetXuid_ReturnsXuid(string gamertag, long expected)
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();

            Client
                .Setup(s => s.GetXuid(gamertag))
                .Returns(Task.FromResult(expected));

            Assert.Equal(expected, await Client.Object.GetXuid(gamertag));
        }
    }
}
