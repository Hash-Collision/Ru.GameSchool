//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace Ru.GameSchool.DataLayer.Repository
{
    public interface IGameSchoolEntities : IDisposable
    {
    
        #region ObjectSet Properties
        IObjectSet<Comment> Comments { get; }
        IObjectSet<CommentLike> CommentLikes { get; }
        IObjectSet<ContentType> ContentTypes { get; }
        IObjectSet<Course> Courses { get; }
        IObjectSet<CourseGrade> CourseGrades { get; }
        IObjectSet<Department> Departments { get; }
        IObjectSet<Level> Levels { get; }
        IObjectSet<LevelExam> LevelExams { get; }
        IObjectSet<LevelExamAnswer> LevelExamAnswers { get; }
        IObjectSet<LevelExamQuestion> LevelExamQuestions { get; }
        IObjectSet<LevelExamResult> LevelExamResults { get; }
        IObjectSet<LevelMaterial> LevelMaterials { get; }
        IObjectSet<LevelProject> LevelProjects { get; }
        IObjectSet<LevelProjectResult> LevelProjectResults { get; }
        IObjectSet<Notification> Notifications { get; }
        IObjectSet<Point> Points { get; }
        IObjectSet<Status> Status { get; }
        IObjectSet<UserInfo> UserInfoes { get; }
        IObjectSet<UserType> UserTypes { get; }
        IObjectSet<UserLog> UserLogs { get; }

        #endregion
        #region Function Imports
        ObjectResult<LevelProject> GetAllUserLevelProjects(Nullable<int> userInfoId);

        #endregion
    
    	int SaveChanges();
    	void AttachTo(string entitySetName ,object entity);
    }
}
