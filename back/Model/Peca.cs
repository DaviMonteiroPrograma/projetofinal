using System;
using System.Collections.Generic;

#nullable disable

namespace back.Model
{
    public partial class Peca
    {
        public Peca()
        {
            CompativelPeca1s = new HashSet<Compativel>();
            CompativelPeca2s = new HashSet<Compativel>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }

        public virtual ICollection<Compativel> CompativelPeca1s { get; set; }
        public virtual ICollection<Compativel> CompativelPeca2s { get; set; }
    }
}
