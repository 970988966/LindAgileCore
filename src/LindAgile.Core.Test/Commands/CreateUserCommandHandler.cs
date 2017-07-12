using LindAgile.Core.Logger;
using LindAgile.Core.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LindAgile.Core.Test.Commands
{
    /// <summary>
    /// 事件处理程序
    /// </summary>
    public class CreateUserCommandHandler : IBusHandler<CreateUserCommand>
    {
        public void Handle(CreateUserCommand evt)
        {
            LoggerFactory.CreateLog().Logger_Debug(evt.UserName);
            Console.WriteLine("CreateUserCommandHandler");
        }
    }
}
