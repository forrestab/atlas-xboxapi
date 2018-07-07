using Atlas.Integration.Xbox.Net.Http;
using Atlas.Integration.Xbox.Utilities;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Atlas.Integration.Xbox
{
    public class XboxClient : IXboxClient
    {
        private readonly HttpClient client;

        public XboxClient(HttpClient client)
        {
            client.BaseAddress = new Uri("https://xboxapi.com/v2/");
            client.DefaultRequestHeaders.Add("X-Auth", "");

            this.client = client;
        }

        public async Task<long> GetXuid(string gamertag)
        {
            Guard.AgainstNullArgument<string>(nameof(gamertag), gamertag);

            return await this.client.GetAsync<long>($"xuid/{gamertag}");
        }
    }
}
