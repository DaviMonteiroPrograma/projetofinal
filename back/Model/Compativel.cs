using System;
using System.Collections.Generic;

#nullable disable

namespace back.Model
{
    public partial class Compativel
    {
        public int Id { get; set; }
        public int? Peca1Id { get; set; }
        public int? Peca2Id { get; set; }

        public virtual Peca Peca1 { get; set; }
        public virtual Peca Peca2 { get; set; }
    }
}
