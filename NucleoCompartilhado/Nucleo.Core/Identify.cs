using System;

namespace Nucleo.Core
{
    public class Identify
    {
        public Guid Id { get; private set; }

        public Identify()
        {
            Id = Guid.NewGuid();
        }

        public Identify(Guid id)
        {
            Id = id;
        }
    }
}