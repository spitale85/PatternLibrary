using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Sms
{
    public interface ITextSender
    {
        void Notify(string yoNumber, string message);

    }
}
