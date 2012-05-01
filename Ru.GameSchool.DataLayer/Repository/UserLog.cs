//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Ru.GameSchool.DataLayer.Repository
{
    public partial class UserLog
    {
        #region Primitive Properties
    
        public virtual int UserLogId
        {
            get;
            set;
        }
    
        public virtual System.DateTime LoginTime
        {
            get;
            set;
        }
    
        public virtual string IpAddress
        {
            get;
            set;
        }
    
        public virtual int UserInfoId
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual UserInfo UserInfo
        {
            get { return _userInfo; }
            set
            {
                if (!ReferenceEquals(_userInfo, value))
                {
                    var previousValue = _userInfo;
                    _userInfo = value;
                    FixupUserInfo(previousValue);
                }
            }
        }
        private UserInfo _userInfo;

        #endregion
        #region Association Fixup
    
        private void FixupUserInfo(UserInfo previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.UserLog, this))
            {
                previousValue.UserLog = null;
            }
    
            if (UserInfo != null)
            {
                UserInfo.UserLog = this;
            }
        }

        #endregion
    }
}
