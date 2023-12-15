using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace chat_sv.Models
{
    public class SuhaRoute
    {
        [FromRoute(Name = "id")]
        public string? Id { get; set; }
    }
}