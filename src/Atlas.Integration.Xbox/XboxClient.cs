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
            this.client = client;
            this.client.BaseAddress = new Uri("https://xboxapi.com/v2/");
            this.client.DefaultRequestHeaders.Add("X-Auth", "");
        }

        public async Task<long> GetXuid(string gamertag)
        {
            Guard.AgainstNullArgument<string>(nameof(gamertag), gamertag);

            return await this.client.GetAsync<long>($"xuid/{gamertag}");
        }
    }
}
