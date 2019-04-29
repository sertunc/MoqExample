using System;
using System.Collections.Generic;
using System.Text;

namespace MoqExample.Core.Model
{
    public class Bar
    {
        public virtual Baz Baz { get; set; }
        public virtual bool Submit() { return false; }
    }
}
