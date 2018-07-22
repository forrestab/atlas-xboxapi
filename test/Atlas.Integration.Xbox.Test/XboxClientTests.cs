using Atlas.Integration.Xbox.Models;
using Moq;
using System.Collections.Generic;
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
            Profile Expected = new Profile() { Id = 1 };

            Client
                .Setup(s => s.GetProfile(1))
                .Returns(Task.FromResult(new Profile() { Id = 1 }));

            Assert.Equal(Expected.Id, (await Client.Object.GetProfile(1)).Id);
        }

        [Fact]
        public async Task GetGamercard_ReturnsGamercard()
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();
            Gamercard Expected = new Gamercard() { Gamertag = "Desugoji" };

            Client
                .Setup(s => s.GetGamercard(1))
                .Returns(Task.FromResult(new Gamercard() { Gamertag = "Desugoji" }));

            Assert.Equal(Expected.Gamertag, (await Client.Object.GetGamercard(1)).Gamertag);
        }

        [Fact]
        public async Task GetPresence_ReturnsPresence()
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();
            Presence Expected = new Presence() { Xuid = 1 };

            Client
                .Setup(s => s.GetPresence(1))
                .Returns(Task.FromResult(new Presence() { Xuid = 1 }));

            Assert.Equal(Expected.Xuid, (await Client.Object.GetPresence(1)).Xuid);
        }

        [Fact]
        public async Task GetGamerActivity_ReturnsGamerActivity()
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();
            GamerActivity Expected = new GamerActivity() { ActivityItems = new List<ActivityItem>() };

            Client
                .Setup(s => s.GetActivity(1, null))
                .Returns(Task.FromResult(new GamerActivity() { ActivityItems = new List<ActivityItem>() }));

            Assert.Equal(Expected.ActivityItems.Count, (await Client.Object.GetActivity(1, null)).ActivityItems.Count);
        }

        [Fact]
        public async Task GetGamerActivity_ReturnsContinuedGamerActivity()
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();
            GamerActivity Expected = new GamerActivity() { ActivityItems = new List<ActivityItem>() };

            Client
                .Setup(s => s.GetActivity(1, 2))
                .Returns(Task.FromResult(new GamerActivity() { ActivityItems = new List<ActivityItem>() }));

            Assert.Equal(Expected.ActivityItems.Count, (await Client.Object.GetActivity(1, 2)).ActivityItems.Count);
        }

        [Fact]
        public async Task GetRecentGamerActivity_ReturnsRecentGamerActivity()
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();
            List<ActivityItem> Expected = new List<ActivityItem>();

            Client
                .Setup(s => s.GetRecentActivity(1))
                .Returns(Task.FromResult(new List<ActivityItem>()));

            Assert.Equal(Expected.Count, (await Client.Object.GetRecentActivity(1)).Count);
        }

        [Fact]
        public async Task GetFriends_ReturnsFriends()
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();
            List<Friend> Expected = new List<Friend>();

            Client
                .Setup(s => s.GetFriends(1))
                .Returns(Task.FromResult(new List<Friend>()));

            Assert.Equal(Expected.Count, (await Client.Object.GetFriends(1)).Count);
        }

        [Fact]
        public async Task GetFollowers_ReturnsFollowers()
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();
            List<Friend> Expected = new List<Friend>();

            Client
                .Setup(s => s.GetFollowers(1))
                .Returns(Task.FromResult(new List<Friend>()));

            Assert.Equal(Expected.Count, (await Client.Object.GetFollowers(1)).Count);
        }

        [Fact]
        public async Task GetGameClips_ReturnsGameClips()
        {
            Mock<IXboxClient> Client = new Mock<IXboxClient>();
            List<GameClip> Expected = new List<GameClip>();

            Client
                .Setup(s => s.GetGameClips(1))
                .Returns(Task.FromResult(new List<GameClip>()));

            Assert.Equal(Expected.Count, (await Client.Object.GetGameClips(1)).Count);
        }
    }
}
