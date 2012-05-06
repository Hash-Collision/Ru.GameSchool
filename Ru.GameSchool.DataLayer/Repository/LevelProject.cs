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
    public partial class LevelProject
    {
        #region Primitive Properties
    
        public virtual int LevelProjectId
        {
            get;
            set;
        }
    
        public virtual int LevelId
        {
            get { return _levelId; }
            set
            {
                if (_levelId != value)
                {
                    if (Level != null && Level.LevelId != value)
                    {
                        Level = null;
                    }
                    _levelId = value;
                }
            }
        }
        private int _levelId;
    
        public virtual System.DateTime Start
        {
            get;
            set;
        }
    
        public virtual System.DateTime Stop
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual double GradePercentageValue
        {
            get;
            set;
        }
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual string ProjectUrl
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual Level Level
        {
            get { return _level; }
            set
            {
                if (!ReferenceEquals(_level, value))
                {
                    var previousValue = _level;
                    _level = value;
                    FixupLevel(previousValue);
                }
            }
        }
        private Level _level;
    
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
    
        private void FixupLevel(Level previousValue)
        {
            if (previousValue != null && previousValue.LevelProjects.Contains(this))
            {
                previousValue.LevelProjects.Remove(this);
            }
    
            if (Level != null)
            {
                if (!Level.LevelProjects.Contains(this))
                {
                    Level.LevelProjects.Add(this);
                }
                if (LevelId != Level.LevelId)
                {
                    LevelId = Level.LevelId;
                }
            }
        }
    
        private void FixupLevelProjectResults(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (LevelProjectResult item in e.NewItems)
                {
                    item.LevelProject = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (LevelProjectResult item in e.OldItems)
                {
                    if (ReferenceEquals(item.LevelProject, this))
                    {
                        item.LevelProject = null;
                    }
                }
            }
        }

        #endregion
    }
}
