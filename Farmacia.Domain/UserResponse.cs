using System;
using System.Collections.Generic;
using System.Text;

namespace Farmacia.Domain
{
    public class UserResponse
    {
        public string token { get; set; }
        public string message { get; set; }
        public string error { get; set; }
        public Usuario usuario { get; set; }
    }
}
