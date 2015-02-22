namespace TPS.ConsoleApp
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IParsable<T> where T : new()
    {
        void Parse(String value);
    }
}
