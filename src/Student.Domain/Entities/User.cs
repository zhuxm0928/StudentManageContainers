using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Domain.Entities
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public bool IsDisabled { get; set; }


        #region Public Methods
        public void Disable()
        {
            this.IsDisabled = true;
        }

        public void Enable()
        {
            this.IsDisabled = false;
        }
        #endregion
    }
}
