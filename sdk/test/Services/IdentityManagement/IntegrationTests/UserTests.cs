using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for GetUserTest
    /// </summary>
    [TestClass]
    public class UserTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        public UserTests()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestInitialize]
        public void PreTestRun()
        {
            IAMUtil.DeleteUsersAndGroupsInTestNameSpace(Client);
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestGetUserImplicit()
        {
            GetUserRequest request = new GetUserRequest();

            GetUserResponse response = Client.GetUser(request);
            Assert.IsFalse(string.IsNullOrEmpty(response.User.Arn));

            // The assert will succeed if you run with root credentials.
            //Assert.AreEqual(string.Format("arn:aws:iam::{0}:root", response.User.UserId), response.User.Arn);
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestCreateGetUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            try
            {
                CreateUserRequest request = new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH };
                CreateUserResponse response = Client.CreateUser(request);
                Assert.AreEqual(username, response.User.UserName);
                GetUserResponse getResponse = Client.GetUser(new GetUserRequest() { UserName = username });
                Assert.AreEqual(username, getResponse.User.UserName);
                Assert.AreNotEqual(DateTime.MinValue, getResponse.User.CreateDate);
            }
            finally
            {
                Client.DeleteUser(new DeleteUserRequest() { UserName = username });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestListUsers()
        {
            string username1 = IAMUtil.CreateTestUser(Client);
            string username2 = IAMUtil.CreateTestUser(Client);
            string username3 = IAMUtil.CreateTestUser(Client);
            try
            {
                ListUsersResponse response = Client.ListUsers(new ListUsersRequest() { PathPrefix = IAMUtil.TEST_PATH });

                Assert.AreEqual(3, response.Users.Count());

                int matches = 0;
                foreach(User user in response.Users)
                {
                    if (user.UserName.Equals(username1))
                        matches |= 1;
                    if (user.UserName.Equals(username2))
                        matches |= 2;
                    if (user.UserName.Equals(username3))
                        matches |= 4;
                }
                Assert.AreEqual(7, matches);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username1, username2, username3);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestUserWithPath()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;
            string path = IAMUtil.MakePath("one", "two", "three");
            try
            {
                Client.CreateUser(new CreateUserRequest() { UserName = username, Path = path });
                GetUserResponse response = Client.GetUser(new GetUserRequest() { UserName = username });
                Assert.AreEqual(username, response.User.UserName);
                Assert.AreEqual(path, response.User.Path);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestListUsersByPath()
        {
            string username1 = "sdk-testuser1-" + DateTime.Now.Ticks;
            string username2 = "sdk-testuser2-" + DateTime.Now.Ticks;
            string username3 = "sdk-testuser3-" + DateTime.Now.Ticks;
            string username4 = "sdk-testuser4-" + DateTime.Now.Ticks;

            string pathA = IAMUtil.MakePath("A");
            string pathB = IAMUtil.MakePath("B");

            try
            {
                Client.CreateUser(new CreateUserRequest() { UserName = username1, Path = pathA });
                Client.CreateUser(new CreateUserRequest() { UserName = username2, Path = pathA });
                Client.CreateUser(new CreateUserRequest() { UserName = username3, Path = pathB });
                Client.CreateUser(new CreateUserRequest() { UserName = username4, Path = pathA });

                ListUsersResponse response = Client.ListUsers(new ListUsersRequest() { PathPrefix = pathA });

                Assert.AreEqual(3, response.Users.Count());

                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username4))
                        matches |= 4;
                    if (u.UserName.Equals(username3))
                        Assert.Fail();
                }
                Assert.AreEqual(7, matches);

                response = Client.ListUsers(new ListUsersRequest(){ PathPrefix = pathB });

                Assert.AreEqual(1, response.Users.Count());
               
                matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        Assert.Fail();
                    if (u.UserName.Equals(username2))
                        Assert.Fail();
                    if (u.UserName.Equals(username4))
                        Assert.Fail();
                    if (u.UserName.Equals(username3))
                        matches = 1;
                }
                Assert.AreEqual(1, matches);

                response = Client.ListUsers(new ListUsersRequest(){ PathPrefix = IAMUtil.TEST_PATH });
                Assert.AreEqual(4, response.Users.Count());

            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username1, username2, username3, username4);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestListUsersMaxResults()
        {
            string username1 = IAMUtil.CreateTestUser(Client);
            string username2 = IAMUtil.CreateTestUser(Client);
            string username3 = IAMUtil.CreateTestUser(Client);
            string username4 = IAMUtil.CreateTestUser(Client);

            try
            {
                ListUsersResponse response = Client.ListUsers(new ListUsersRequest() { MaxItems = 2, PathPrefix = IAMUtil.TEST_PATH });

                Assert.AreEqual(2, response.Users.Count());
                Assert.AreEqual(true, response.IsTruncated);

                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username4))
                        matches |= 3;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                }

                string marker = response.Marker;

                response = Client.ListUsers(new ListUsersRequest() { PathPrefix = IAMUtil.TEST_PATH, Marker = marker });

                Assert.AreEqual(2, response.Users.Count());
                Assert.AreEqual(false, response.IsTruncated);

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username4))
                        matches |= 3;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                }

                Assert.AreEqual(7, matches);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username1, username2, username3, username4);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestUpdateUser()
        {
            string
                username    = "sdk-testuser-" + DateTime.Now.Ticks,
                newusername = "sdk-testnewuser-" + DateTime.Now.Ticks;
            string
                firstPath  = IAMUtil.MakePath("first"),
                secondPath = IAMUtil.MakePath("second");

            try
            {
                Client.CreateUser(new CreateUserRequest() { UserName = username, Path = firstPath });

                GetUserResponse response = Client.GetUser(new GetUserRequest() { UserName = username });
                Assert.AreEqual(firstPath, response.User.Path);

                string id = response.User.UserId;

                Client.UpdateUser(new UpdateUserRequest() { UserName = username, NewPath = secondPath, NewUserName = newusername });

                response = Client.GetUser(new GetUserRequest() { UserName = newusername });

                Assert.AreEqual(newusername, response.User.UserName);
                Assert.AreEqual(secondPath, response.User.Path);
                Assert.AreEqual(id, response.User.UserId);
            }
            finally
            {
                Client.DeleteUser(new DeleteUserRequest() { UserName = newusername });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            Client.CreateUser(new CreateUserRequest() {UserName = username, Path = IAMUtil.TEST_PATH });

            GetUserResponse response = Client.GetUser(new GetUserRequest() { UserName = username });
            Assert.AreEqual(username, response.User.UserName);

            Client.DeleteUser(new DeleteUserRequest() { UserName = username });

            Client.GetUser(new GetUserRequest() { UserName = username });
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(EntityAlreadyExistsException))]
        public void TestDoubleCreateUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            try
            {
                Client.CreateUser(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH });
                Client.CreateUser(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH });
            }
            finally
            {
                Client.DeleteUser(new DeleteUserRequest() { UserName = username });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(NoSuchEntityException))]
        public void TestUpdateNonexistantUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            Client.UpdateUser(new UpdateUserRequest() { UserName = username, NewPath = "/lala/" });
        }
        


    }
}
