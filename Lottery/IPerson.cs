using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryArchive
{
    public interface IPerson
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }

    }
}
