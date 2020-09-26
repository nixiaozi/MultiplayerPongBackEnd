using BoB.BoBConfiguration;
using BoB.ExtendAndHelper.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BoB.HelloWorldApi
{
    public static class BoBConfiguration
    {
        static BoBConfiguration()
        {
            BaseBoBConfiguration.Init(Assembly.GetExecutingAssembly());
        }

        /// <summary>
        /// 游戏服务端的IP地址
        /// </summary>
        [WriteAble]
        public static readonly string GameServerPath = "127.0.0.1";

    }
}
