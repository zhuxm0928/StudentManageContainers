﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Domain
{
    /// <summary>
    /// 领域实体接口
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// 当前领域实体的全局唯一标识
        /// </summary>
        int Id { get; }
    }
}
