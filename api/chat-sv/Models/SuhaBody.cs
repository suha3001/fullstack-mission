using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace chat_sv.Models
{
    public class SuhaBody
    {
        [JsonProperty("user_name")]
        public string? UserName { get; set; }
    }
}