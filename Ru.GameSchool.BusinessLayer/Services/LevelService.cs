﻿using System;
using System.Collections.Generic;
using Ru.GameSchool.DataLayer;

namespace Ru.GameSchool.BusinessLayer.Services
{
    public class GameService : BaseService
    {

        public void AddPointsToLevel(int userId, int levelId)
        {
            throw new System.NotImplementedException();
        }

        public int GetPoints(int userId, int levelId)
        {
            throw new System.NotImplementedException();
        }

        public void CalculatePoints()
        {
            throw new System.NotImplementedException();
        }

        public void GetLeaderboard()
        {
            throw new System.NotImplementedException();
        }

        public void GetPointsComparedToUsers(int userId, int courseId)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns a list of the top ranking users for the course.
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns>List of Tuple first item is the rank then the user object.</returns>
        public IEnumerable<Tuple<int,User>> GetTopTenList( int courseId)
        {
            throw new System.NotImplementedException();
        }
    }
}
