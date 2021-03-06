﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slickflow.Engine.Common
{
    /// <summary>
    /// 流程启动类型
    /// </summary>
    public enum ProcessStartTypeEnum
    {
        /// <summary>
        /// 默认空白
        /// </summary>
        None = 0,

        /// <summary>
        /// 定时启动
        /// </summary>
        Timer = 1,

        /// <summary>
        /// 邮件启动
        /// </summary>
        EMail = 2
    }

    /// <summary>
    /// 流程结束类型
    /// </summary>
    public enum ProcessEndTypeEnum
    {
        /// <summary>
        /// 默认空白
        /// </summary>
        None = 0,

        /// <summary>
        /// 定时启动
        /// </summary>
        Timer = 1,

        /// <summary>
        /// 邮件启动
        /// </summary>
        EMail = 2
    }
}
