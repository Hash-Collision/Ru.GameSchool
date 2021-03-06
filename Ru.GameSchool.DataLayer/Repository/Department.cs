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
    public partial class Department
    {
        #region Primitive Properties
    
        public virtual int DepartmentId
        {
            get;
            set;
        }
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<Course> Courses
        {
            get
            {
                if (_courses == null)
                {
                    var newCollection = new FixupCollection<Course>();
                    newCollection.CollectionChanged += FixupCourses;
                    _courses = newCollection;
                }
                return _courses;
            }
            set
            {
                if (!ReferenceEquals(_courses, value))
                {
                    var previousValue = _courses as FixupCollection<Course>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCourses;
                    }
                    _courses = value;
                    var newValue = value as FixupCollection<Course>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCourses;
                    }
                }
            }
        }
        private ICollection<Course> _courses;
    
        public virtual ICollection<UserInfo> UserInfoes
        {
            get
            {
                if (_userInfoes == null)
                {
                    var newCollection = new FixupCollection<UserInfo>();
                    newCollection.CollectionChanged += FixupUserInfoes;
                    _userInfoes = newCollection;
                }
                return _userInfoes;
            }
            set
            {
                if (!ReferenceEquals(_userInfoes, value))
                {
                    var previousValue = _userInfoes as FixupCollection<UserInfo>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupUserInfoes;
                    }
                    _userInfoes = value;
                    var newValue = value as FixupCollection<UserInfo>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupUserInfoes;
                    }
                }
            }
        }
        private ICollection<UserInfo> _userInfoes;

        #endregion
        #region Association Fixup
    
        private void FixupCourses(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Course item in e.NewItems)
                {
                    item.Department = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Course item in e.OldItems)
                {
                    if (ReferenceEquals(item.Department, this))
                    {
                        item.Department = null;
                    }
                }
            }
        }
    
        private void FixupUserInfoes(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (UserInfo item in e.NewItems)
                {
                    item.Department = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (UserInfo item in e.OldItems)
                {
                    if (ReferenceEquals(item.Department, this))
                    {
                        item.Department = null;
                    }
                }
            }
        }

        #endregion
    }
}
