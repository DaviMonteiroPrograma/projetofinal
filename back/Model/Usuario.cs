using System;
using System.Collections.Generic;

#nullable disable

namespace back.Model
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Userpass { get; set; }
    }
}
