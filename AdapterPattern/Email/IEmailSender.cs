using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Email
{
    public interface IEmailSender
    {
        public void Send(string user, string fromEmail, string message);
    }
}
