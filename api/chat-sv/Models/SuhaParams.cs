using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace chat_sv.Models
{
    public class SuhaParams
    {
        [FromQuery(Name = "id")]
        public string? Id { get; set; }

        [FromQuery(Name = "name")]
        public string? Name { get; set; }
    }
}