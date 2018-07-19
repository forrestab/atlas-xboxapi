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

        [Theory]
        [InlineData(1, "desugoji")]
        public async Task GetGamertag_ReturnsGamertag(long xuid, string expected)
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();

            Client
                .Setup(s => s.GetGamertag(xuid))
                .Returns(Task.FromResult(expected));

            Assert.Equal(expected, await Client.Object.GetGamertag(xuid));
        }
    }
}
