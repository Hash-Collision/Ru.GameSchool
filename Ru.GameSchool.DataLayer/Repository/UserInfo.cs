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
    public partial class UserInfo
    {
        #region Primitive Properties
    
        public virtual int UserInfoId
        {
            get;
            set;
        }
    
        public virtual string Username
        {
            get;
            set;
        }
    
        public virtual string Password
        {
            get;
            set;
        }
    
        public virtual string Email
        {
            get;
            set;
        }
    
        public virtual int UserTypeId
        {
            get { return _userTypeId; }
            set
            {
                if (_userTypeId != value)
                {
                    if (UserType != null && UserType.UserTypeID != value)
                    {
                        UserType = null;
                    }
                    _userTypeId = value;
                }
            }
        }
        private int _userTypeId;
    
        public virtual string Fullname
        {
            get;
            set;
        }
    
        public virtual int DepartmentId
        {
            get { return _departmentId; }
            set
            {
                if (_departmentId != value)
                {
                    if (Department != null && Department.DepartmentId != value)
                    {
                        Department = null;
                    }
                    _departmentId = value;
                }
            }
        }
        private int _departmentId;
    
        public virtual System.DateTime CreateDateTime
        {
            get;
            set;
        }
    
        public virtual int StatusId
        {
            get { return _statusId; }
            set
            {
                if (_statusId != value)
                {
                    if (Status != null && Status.StatusId != value)
                    {
                        Status = null;
                    }
                    _statusId = value;
                }
            }
        }
        private int _statusId;

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<Comment> Comments
        {
            get
            {
                if (_comments == null)
                {
                    var newCollection = new FixupCollection<Comment>();
                    newCollection.CollectionChanged += FixupComments;
                    _comments = newCollection;
                }
                return _comments;
            }
            set
            {
                if (!ReferenceEquals(_comments, value))
                {
                    var previousValue = _comments as FixupCollection<Comment>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupComments;
                    }
                    _comments = value;
                    var newValue = value as FixupCollection<Comment>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupComments;
                    }
                }
            }
        }
        private ICollection<Comment> _comments;
    
        public virtual ICollection<CommentLike> CommentLikes
        {
            get
            {
                if (_commentLikes == null)
                {
                    var newCollection = new FixupCollection<CommentLike>();
                    newCollection.CollectionChanged += FixupCommentLikes;
                    _commentLikes = newCollection;
                }
                return _commentLikes;
            }
            set
            {
                if (!ReferenceEquals(_commentLikes, value))
                {
                    var previousValue = _commentLikes as FixupCollection<CommentLike>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCommentLikes;
                    }
                    _commentLikes = value;
                    var newValue = value as FixupCollection<CommentLike>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCommentLikes;
                    }
                }
            }
        }
        private ICollection<CommentLike> _commentLikes;
    
        public virtual ICollection<CourseGrade> CourseGrades
        {
            get
            {
                if (_courseGrades == null)
                {
                    var newCollection = new FixupCollection<CourseGrade>();
                    newCollection.CollectionChanged += FixupCourseGrades;
                    _courseGrades = newCollection;
                }
                return _courseGrades;
            }
            set
            {
                if (!ReferenceEquals(_courseGrades, value))
                {
                    var previousValue = _courseGrades as FixupCollection<CourseGrade>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCourseGrades;
                    }
                    _courseGrades = value;
                    var newValue = value as FixupCollection<CourseGrade>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCourseGrades;
                    }
                }
            }
        }
        private ICollection<CourseGrade> _courseGrades;
    
        public virtual Department Department
        {
            get { return _department; }
            set
            {
                if (!ReferenceEquals(_department, value))
                {
                    var previousValue = _department;
                    _department = value;
                    FixupDepartment(previousValue);
                }
            }
        }
        private Department _department;
    
        public virtual ICollection<LevelExamResult> LevelExamResults
        {
            get
            {
                if (_levelExamResults == null)
                {
                    var newCollection = new FixupCollection<LevelExamResult>();
                    newCollection.CollectionChanged += FixupLevelExamResults;
                    _levelExamResults = newCollection;
                }
                return _levelExamResults;
            }
            set
            {
                if (!ReferenceEquals(_levelExamResults, value))
                {
                    var previousValue = _levelExamResults as FixupCollection<LevelExamResult>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupLevelExamResults;
                    }
                    _levelExamResults = value;
                    var newValue = value as FixupCollection<LevelExamResult>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupLevelExamResults;
                    }
                }
            }
        }
        private ICollection<LevelExamResult> _levelExamResults;
    
        public virtual ICollection<Notification> Notifications
        {
            get
            {
                if (_notifications == null)
                {
                    var newCollection = new FixupCollection<Notification>();
                    newCollection.CollectionChanged += FixupNotifications;
                    _notifications = newCollection;
                }
                return _notifications;
            }
            set
            {
                if (!ReferenceEquals(_notifications, value))
                {
                    var previousValue = _notifications as FixupCollection<Notification>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupNotifications;
                    }
                    _notifications = value;
                    var newValue = value as FixupCollection<Notification>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupNotifications;
                    }
                }
            }
        }
        private ICollection<Notification> _notifications;
    
        public virtual ICollection<Point> Points
        {
            get
            {
                if (_points == null)
                {
                    var newCollection = new FixupCollection<Point>();
                    newCollection.CollectionChanged += FixupPoints;
                    _points = newCollection;
                }
                return _points;
            }
            set
            {
                if (!ReferenceEquals(_points, value))
                {
                    var previousValue = _points as FixupCollection<Point>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPoints;
                    }
                    _points = value;
                    var newValue = value as FixupCollection<Point>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPoints;
                    }
                }
            }
        }
        private ICollection<Point> _points;
    
        public virtual Status Status
        {
            get { return _status; }
            set
            {
                if (!ReferenceEquals(_status, value))
                {
                    var previousValue = _status;
                    _status = value;
                    FixupStatus(previousValue);
                }
            }
        }
        private Status _status;
    
        public virtual UserType UserType
        {
            get { return _userType; }
            set
            {
                if (!ReferenceEquals(_userType, value))
                {
                    var previousValue = _userType;
                    _userType = value;
                    FixupUserType(previousValue);
                }
            }
        }
        private UserType _userType;
    
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
    
        public virtual ICollection<UserLog> UserLogs
        {
            get
            {
                if (_userLogs == null)
                {
                    var newCollection = new FixupCollection<UserLog>();
                    newCollection.CollectionChanged += FixupUserLogs;
                    _userLogs = newCollection;
                }
                return _userLogs;
            }
            set
            {
                if (!ReferenceEquals(_userLogs, value))
                {
                    var previousValue = _userLogs as FixupCollection<UserLog>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupUserLogs;
                    }
                    _userLogs = value;
                    var newValue = value as FixupCollection<UserLog>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupUserLogs;
                    }
                }
            }
        }
        private ICollection<UserLog> _userLogs;
    
        public virtual ICollection<LevelExamAnswer> LevelExamAnswers
        {
            get
            {
                if (_levelExamAnswers == null)
                {
                    var newCollection = new FixupCollection<LevelExamAnswer>();
                    newCollection.CollectionChanged += FixupLevelExamAnswers;
                    _levelExamAnswers = newCollection;
                }
                return _levelExamAnswers;
            }
            set
            {
                if (!ReferenceEquals(_levelExamAnswers, value))
                {
                    var previousValue = _levelExamAnswers as FixupCollection<LevelExamAnswer>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupLevelExamAnswers;
                    }
                    _levelExamAnswers = value;
                    var newValue = value as FixupCollection<LevelExamAnswer>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupLevelExamAnswers;
                    }
                }
            }
        }
        private ICollection<LevelExamAnswer> _levelExamAnswers;
    
        public virtual ICollection<Announcement> Announcements
        {
            get
            {
                if (_announcements == null)
                {
                    var newCollection = new FixupCollection<Announcement>();
                    newCollection.CollectionChanged += FixupAnnouncements;
                    _announcements = newCollection;
                }
                return _announcements;
            }
            set
            {
                if (!ReferenceEquals(_announcements, value))
                {
                    var previousValue = _announcements as FixupCollection<Announcement>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupAnnouncements;
                    }
                    _announcements = value;
                    var newValue = value as FixupCollection<Announcement>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupAnnouncements;
                    }
                }
            }
        }
        private ICollection<Announcement> _announcements;
    
        public virtual ICollection<LevelProjectResult> LevelProjectResults
        {
            get
            {
                if (_levelProjectResults == null)
                {
                    var newCollection = new FixupCollection<LevelProjectResult>();
                    newCollection.CollectionChanged += FixupLevelProjectResults;
                    _levelProjectResults = newCollection;
                }
                return _levelProjectResults;
            }
            set
            {
                if (!ReferenceEquals(_levelProjectResults, value))
                {
                    var previousValue = _levelProjectResults as FixupCollection<LevelProjectResult>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupLevelProjectResults;
                    }
                    _levelProjectResults = value;
                    var newValue = value as FixupCollection<LevelProjectResult>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupLevelProjectResults;
                    }
                }
            }
        }
        private ICollection<LevelProjectResult> _levelProjectResults;

        #endregion
        #region Association Fixup
    
        private void FixupDepartment(Department previousValue)
        {
            if (previousValue != null && previousValue.UserInfoes.Contains(this))
            {
                previousValue.UserInfoes.Remove(this);
            }
    
            if (Department != null)
            {
                if (!Department.UserInfoes.Contains(this))
                {
                    Department.UserInfoes.Add(this);
                }
                if (DepartmentId != Department.DepartmentId)
                {
                    DepartmentId = Department.DepartmentId;
                }
            }
        }
    
        private void FixupStatus(Status previousValue)
        {
            if (previousValue != null && previousValue.UserInfoes.Contains(this))
            {
                previousValue.UserInfoes.Remove(this);
            }
    
            if (Status != null)
            {
                if (!Status.UserInfoes.Contains(this))
                {
                    Status.UserInfoes.Add(this);
                }
                if (StatusId != Status.StatusId)
                {
                    StatusId = Status.StatusId;
                }
            }
        }
    
        private void FixupUserType(UserType previousValue)
        {
            if (previousValue != null && previousValue.UserInfoes.Contains(this))
            {
                previousValue.UserInfoes.Remove(this);
            }
    
            if (UserType != null)
            {
                if (!UserType.UserInfoes.Contains(this))
                {
                    UserType.UserInfoes.Add(this);
                }
                if (UserTypeId != UserType.UserTypeID)
                {
                    UserTypeId = UserType.UserTypeID;
                }
            }
        }
    
        private void FixupComments(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Comment item in e.NewItems)
                {
                    item.UserInfo = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Comment item in e.OldItems)
                {
                    if (ReferenceEquals(item.UserInfo, this))
                    {
                        item.UserInfo = null;
                    }
                }
            }
        }
    
        private void FixupCommentLikes(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CommentLike item in e.NewItems)
                {
                    item.UserInfo = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CommentLike item in e.OldItems)
                {
                    if (ReferenceEquals(item.UserInfo, this))
                    {
                        item.UserInfo = null;
                    }
                }
            }
        }
    
        private void FixupCourseGrades(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CourseGrade item in e.NewItems)
                {
                    item.UserInfo = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CourseGrade item in e.OldItems)
                {
                    if (ReferenceEquals(item.UserInfo, this))
                    {
                        item.UserInfo = null;
                    }
                }
            }
        }
    
        private void FixupLevelExamResults(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (LevelExamResult item in e.NewItems)
                {
                    item.UserInfo = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (LevelExamResult item in e.OldItems)
                {
                    if (ReferenceEquals(item.UserInfo, this))
                    {
                        item.UserInfo = null;
                    }
                }
            }
        }
    
        private void FixupNotifications(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Notification item in e.NewItems)
                {
                    item.UserInfo = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Notification item in e.OldItems)
                {
                    if (ReferenceEquals(item.UserInfo, this))
                    {
                        item.UserInfo = null;
                    }
                }
            }
        }
    
        private void FixupPoints(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Point item in e.NewItems)
                {
                    item.UserInfo = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Point item in e.OldItems)
                {
                    if (ReferenceEquals(item.UserInfo, this))
                    {
                        item.UserInfo = null;
                    }
                }
            }
        }
    
        private void FixupCourses(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Course item in e.NewItems)
                {
                    if (!item.UserInfoes.Contains(this))
                    {
                        item.UserInfoes.Add(this);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Course item in e.OldItems)
                {
                    if (item.UserInfoes.Contains(this))
                    {
                        item.UserInfoes.Remove(this);
                    }
                }
            }
        }
    
        private void FixupUserLogs(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (UserLog item in e.NewItems)
                {
                    item.UserInfo = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (UserLog item in e.OldItems)
                {
                    if (ReferenceEquals(item.UserInfo, this))
                    {
                        item.UserInfo = null;
                    }
                }
            }
        }
    
        private void FixupLevelExamAnswers(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (LevelExamAnswer item in e.NewItems)
                {
                    if (!item.UserInfoes.Contains(this))
                    {
                        item.UserInfoes.Add(this);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (LevelExamAnswer item in e.OldItems)
                {
                    if (item.UserInfoes.Contains(this))
                    {
                        item.UserInfoes.Remove(this);
                    }
                }
            }
        }
    
        private void FixupAnnouncements(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Announcement item in e.NewItems)
                {
                    item.UserInfo = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Announcement item in e.OldItems)
                {
                    if (ReferenceEquals(item.UserInfo, this))
                    {
                        item.UserInfo = null;
                    }
                }
            }
        }
    
        private void FixupLevelProjectResults(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (LevelProjectResult item in e.NewItems)
                {
                    item.UserInfo = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (LevelProjectResult item in e.OldItems)
                {
                    if (ReferenceEquals(item.UserInfo, this))
                    {
                        item.UserInfo = null;
                    }
                }
            }
        }

        #endregion
    }
}
