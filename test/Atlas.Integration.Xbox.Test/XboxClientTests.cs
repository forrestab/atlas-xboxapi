using Atlas.Integration.Xbox.Models;
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

        [Fact]
        public async Task GetProfile_ReturnsProfile()
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();
            Profile Expected = new Profile()
            {
                Id = 1
            };

            Client
                .Setup(s => s.GetProfile(1))
                .Returns(Task.FromResult(new Profile()
                {
                    Id = 1
                }));

            Assert.Equal(Expected.Id, (await Client.Object.GetProfile(1)).Id);
        }

        [Fact]
        public async Task GetGamercard_ReturnsGamercard()
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();
            Gamercard Expected = new Gamercard()
            {
                Gamertag = "Desugoji"
            };

            Client
                .Setup(s => s.GetGamercard(1))
                .Returns(Task.FromResult(new Gamercard()
                {
                    Gamertag = "Desugoji"
                }));

            Assert.Equal(Expected.Gamertag, (await Client.Object.GetGamercard(1)).Gamertag);
        }

        [Fact]
        public async Task GetPresence_ReturnsPresence()
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();
            Presence Expected = new Presence()
            {
                Xuid = 1
            };

            Client
                .Setup(s => s.GetPresence(1))
                .Returns(Task.FromResult(new Presence()
                {
                    Xuid = 1
                }));

            Assert.Equal(Expected.Xuid, (await Client.Object.GetPresence(1)).Xuid);
        }
    }
}
