using LindAgile.Core.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LindAgile.Core.Test.Commands
{
    /// <summary>
    /// 事件源
    /// </summary>
    public class CreateUserCommand : BusData
    {
        public string UserName { get; set; }
    }

}
