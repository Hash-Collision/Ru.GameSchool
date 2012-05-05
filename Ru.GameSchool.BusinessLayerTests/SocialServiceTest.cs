﻿using System.Data.Objects;
using Rhino.Mocks;
using Ru.GameSchool.BusinessLayer.Exceptions;
using Ru.GameSchool.BusinessLayer.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ru.GameSchool.BusinessLayerTests.Classes;
using Ru.GameSchool.DataLayer.Repository;

namespace Ru.GameSchool.BusinessLayerTests
{
    
    
    /// <summary>
    ///This is a test class for SocialServiceTest and is intended
    ///to contain all SocialServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SocialServiceTest
    {
        private IGameSchoolEntities _mockRepository;
        private SocialService _socialService;

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

        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            _mockRepository = MockRepository.GenerateMock<IGameSchoolEntities>();
            _socialService = new SocialService();
            _socialService.SetDatasource(_mockRepository);
        }

        /// <summary>
        ///A test for CreateLike
        ///</summary>
        [TestMethod()]
        public void CreateLikeTest()
        {
            var commentData = new FakeObjectSet<Comment>();

            var comment = new Comment();
            comment.CreateDateTime = DateTime.Now;
            comment.Deleted = false;
            comment.CommentId = 1;
            comment.DeletedByUser = null;
            comment.LevelMaterialId = 0;
            comment.UserInfoId = 1;

            commentData.AddObject(comment);


            var userData = new FakeObjectSet<UserInfo>();

            UserInfo userInfo = new UserInfo();
            userInfo.Fullname = "Davíð Einarsson";
            userInfo.Email = "davide09@ru.is";
            userInfo.StatusId = 1;
            userInfo.Username = "davidein";
            userInfo.UserInfoId = 1;
            userInfo.Password = "Wtf";

            userData.AddObject(userInfo);

            var commentLikeData = new FakeObjectSet<CommentLike>();

            _mockRepository.Expect(x => x.Comments).Return(commentData);
            _mockRepository.Expect(x => x.UserInfoes).Return(userData);
            _mockRepository.Expect(x => x.CommentLikes).Return(commentLikeData);
            _mockRepository.Expect(x => x.SaveChanges()).Return(1);

            var commentLike = new CommentLike();

            commentLike.UserInfoId = 1;
            commentLike.CommentId = 1;

            _socialService.CreateLike(commentLike);

            _mockRepository.VerifyAllExpectations();
        }

        /// <summary>
        ///A test for CreateLike
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(GameSchoolException))]
        public void CreateLike_CommentDoesNotExist_Test()
        {
            _mockRepository.Expect(x => x.Comments).Return(new FakeObjectSet<Comment>());
            _mockRepository.Expect(x => x.CommentLikes).Return(new FakeObjectSet<CommentLike>());
         
            var commentLike = new CommentLike();

            commentLike.UserInfoId = 1;
            commentLike.CommentId = 1;

            _socialService.CreateLike(commentLike);

            Assert.Fail("The unit test should never get here.");
        }


        /// <summary>
        ///A test for CreateLike
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(GameSchoolException))]
        public void CreateLike_UserDoesNotExist_Test()
        {
            var commentData = new FakeObjectSet<Comment>();

            var comment = new Comment();
            comment.CreateDateTime = DateTime.Now;
            comment.Deleted = false;
            comment.CommentId = 1;
            comment.DeletedByUser = null;
            comment.LevelMaterialId = 0;
            comment.UserInfoId = 1;

            commentData.AddObject(comment);

            _mockRepository.Expect(x => x.Comments).Return(commentData);
            _mockRepository.Expect(x => x.CommentLikes).Return(new FakeObjectSet<CommentLike>());
            _mockRepository.Expect(x => x.UserInfoes).Return(new FakeObjectSet<UserInfo>());

            var commentLike = new CommentLike();

            commentLike.UserInfoId = 100;
            commentLike.CommentId = 1;

            _socialService.CreateLike(commentLike);

            Assert.Fail("The unit test should never get here.");
        }
    }
}
