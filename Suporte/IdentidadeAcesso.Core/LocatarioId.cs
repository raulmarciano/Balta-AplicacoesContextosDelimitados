using System;
using Nucleo.Core;

namespace IdentidadeAcesso.Core
{

    public class LocatarioId : Identify
    {
        public LocatarioId(Guid id):base(id){ }

        public LocatarioId():base(){ }
    }
}