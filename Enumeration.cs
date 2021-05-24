using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace enum_classes
{
    public abstract class Enumeration :  Tuple<int,string>, IComparable
    {
        public int Id => Item1;
        public string Name => Item2;      

        protected Enumeration(int id, string name) : base(id, name) {        }

        public override string ToString() => Name;

        public static bool operator ==(Enumeration lhs, Enumeration rhs) => (lhs is null && rhs is null) || lhs.Equals(rhs);
        public static bool operator !=(Enumeration lhs, Enumeration rhs) => !(lhs == rhs);
    }
}

