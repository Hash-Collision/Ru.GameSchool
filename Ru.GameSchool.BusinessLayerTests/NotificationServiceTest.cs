﻿using Rhino.Mocks;
using Ru.GameSchool.BusinessLayer.Exceptions;
using Ru.GameSchool.BusinessLayer.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Ru.GameSchool.BusinessLayerTests.Classes;
using Ru.GameSchool.DataLayer.Repository;
using System.Collections.Generic;

namespace Ru.GameSchool.BusinessLayerTests
{
    
    
    /// <summary>
    ///This is a test class for NotificationServiceTest and is intended
    ///to contain all NotificationServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NotificationServiceTest
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetNotifications
        ///</summary>
        [TestMethod()]
        public void GetNotificationsTest()
        {
            var mockRepository = MockRepository.GenerateMock<IGameSchoolEntities>();
            var notificationService = new NotificationService();
            notificationService.SetDatasource(mockRepository);

            int userInfoId = 1;

            var list = CreateNotificationList(userInfoId, 20);

            var userData = new FakeObjectSet<UserInfo>();

            var userInfo = new UserInfo();
            userInfo.Fullname = "Davíð Einarsson";
            userInfo.Email = "davide09@ru.is";
            userInfo.StatusId = 1;
            userInfo.Username = "davidein";
            userInfo.UserInfoId = userInfoId;
            userInfo.Password = "Wtf";

            userData.AddObject(userInfo);

            mockRepository.Expect(x => x.UserInfoes).Return(userData);
            mockRepository.Expect(x => x.Notifications).Return(list);

            var actualList = notificationService.GetNotifications(userInfoId);

            Assert.AreEqual(list.Count(), actualList.Count());

            mockRepository.VerifyAllExpectations();
        }

        /// <summary>
        ///A test for GetNotifications
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(GameSchoolException))]
        public void GetNotifications_NotValidUser_Test()
        {
            var mockRepository = MockRepository.GenerateMock<IGameSchoolEntities>();
            var notificationService = new NotificationService();
            notificationService.SetDatasource(mockRepository);

            int userInfoId = 1;

            var list = CreateNotificationList(userInfoId, 20);

            mockRepository.Expect(x => x.UserInfoes).Return(new FakeObjectSet<UserInfo>());
            mockRepository.Expect(x => x.Notifications).Return(list);

            notificationService.GetNotifications(userInfoId);

            mockRepository.VerifyAllExpectations();

            Assert.Fail("The unit test should never get here.");
        }

        private FakeObjectSet<Notification> CreateNotificationList(int userId, int amount)
        {
            FakeObjectSet<Notification> notificationList = new FakeObjectSet<Notification>();

            for (int i = 0; i <= amount; i++)
            {
                var expected = new Notification();
                expected.NotificationId = i+1;
                expected.UserInfoId = userId;
                expected.CreateDateTime = DateTime.Now;
                expected.Url = "http://www.visir.is";
                expected.IsRead = false;
                expected.Description = string.Format("Tester {0} description.", i+1);

                notificationList.AddObject(expected);
            }

            return notificationList;
        }
    }
}
