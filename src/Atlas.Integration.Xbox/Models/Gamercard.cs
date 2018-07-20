using Newtonsoft.Json;
using System;

namespace Atlas.Integration.Xbox.Models
{
    public class Gamercard
    {
        public string Gamertag { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Bio { get; set; }
        public long Gamerscore { get; set; }
        public string Tier { get; set; }
        public string Motto { get; set; }
        public Uri AvatarBodyImagePath { get; set; }
        [JsonProperty("GamerPicSmallImagePath")]
        public Uri GamerPictureSmallImagePath { get; set; }
        [JsonProperty("GamerPicLargeImagePath")]
        public Uri GamerPictureLargeImagePath { get; set; }
        [JsonProperty("GamerPicSmallSslImagePath")]
        public Uri GamerPictureSmallSslImagePath { get; set; }
        [JsonProperty("GamerPicLargeSslImagePath")]
        public Uri GamerPictureLargeSslImagePath { get; set; }
        public string AvatarManifest { get; set; }
    }
}
