using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drofustask1.Interfaces
{
    public interface ICreditService
    {
        void InsertMoney(int amount);
        void RecallMoney();
    }
}
