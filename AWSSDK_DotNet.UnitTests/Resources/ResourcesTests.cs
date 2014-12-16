using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;


using Amazon.Runtime;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.IdentityManagement.Resources;
using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ResourcesTests
    {
        static Mock<IAmazonIdentityManagementService> _mock = new Mock<IAmazonIdentityManagementService>();
        static IdentityManagementService _iam = null;


        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _iam = new IdentityManagementService(_mock.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _mock.ResetCalls();
        }

        [TestMethod]
        public void TestServiceAction()
        {
            var createUserRequest = InstantiateClassGenerator.Execute<CreateUserRequest>();
            var userModel = InstantiateClassGenerator.Execute<User>();

            _mock.Setup(iam => iam.CreateUser(It.IsAny<CreateUserRequest>()))
                .Returns(new CreateUserResponse
                {
                    User = userModel
                });

            var user = _iam.CreateUser(createUserRequest);
            InstantiateClassGenerator.ValidateResourceObjectFullyInstantiated(user);  
        }

        [TestMethod]
        public void TestServiceHasMany()
        {
            _mock.Setup(iam => iam.ListUsersEnumerator(It.IsAny<ListUsersRequest>()))
                .Returns((ListUsersRequest request) =>
                {
                    return new List<User>
                    {
                        new User { UserId = "1", UserName = "User1"},
                        new User { UserId = "2", UserName = "User2"},
                        new User { UserId = "3", UserName = "User3"},
                    };
                });

            var users = _iam.GetUsers(new ListUsersRequest());
            _mock.Verify(iam => iam.ListUsersEnumerator(It.IsAny<ListUsersRequest>()),
                Times.Never);
            Assert.AreEqual(3, users.Count());
            var userEnumerator = users.GetEnumerator();
            for (int i = 1; i < 4; i++)
            {
                userEnumerator.MoveNext();
                Assert.AreEqual(i.ToString(), userEnumerator.Current.UserId);
            }
            _mock.Verify(iam => iam.GetUser(It.IsAny<GetUserRequest>()), Times.Never);
        }

        [TestMethod]
        public void TestResourceHasMany()
        {
            var userName = "user1";
            var user = _iam.GetUserByName(userName);
            Assert.AreEqual(userName, user.Name);

            _mock.Verify(iam => iam.GetUser(It.IsAny<GetUserRequest>()), Times.Never);

            _mock.Setup(iam => iam.ListGroupsForUserEnumerator(It.IsAny<ListGroupsForUserRequest>()))
                .Returns((ListGroupsForUserRequest request) =>
                {
                    Assert.AreEqual(userName, request.UserName);
                    return new List<Group>
                    {
                        new Group {  GroupId = "1", GroupName = "Group1"},
                        new Group {  GroupId = "2", GroupName = "Group1"},
                        new Group {  GroupId = "3", GroupName = "Group1"}                        
                    };
                });

            var groups = user.GetGroups(new ListGroupsForUserRequest());
            _mock.Verify(iam => iam.ListGroupsForUserEnumerator(It.IsAny<ListGroupsForUserRequest>()),
                Times.Never);
            Assert.AreEqual(3, groups.Count());
            var groupEnumerator = groups.GetEnumerator();
            for (int i = 1; i < 4; i++)
            {
                groupEnumerator.MoveNext();
                Assert.AreEqual(i.ToString(), groupEnumerator.Current.GroupId);
            }
        }

        [TestMethod]
        public void TestTopLevelResource()
        {
            var userName = "user1";
            var user = _iam.GetUserByName(userName);
            Assert.AreEqual(userName, user.Name);

            _mock.Verify(iam => iam.GetUser(It.IsAny<GetUserRequest>()),Times.Never);

            var getUserRequest = InstantiateClassGenerator.Execute<GetUserRequest>();
            var userModel = InstantiateClassGenerator.Execute<User>();
            userModel.UserName = userName;

            _mock.Setup(iam => iam.GetUser(It.IsAny<GetUserRequest>()))
                .Returns((GetUserRequest request) =>
                {
                    Assert.AreEqual(request.UserName, userName);
                    return new GetUserResponse
                    {
                        User = userModel
                    };
                });

            var createdDate = user.CreateDate;
            _mock.Verify(iam => iam.GetUser(It.IsAny<GetUserRequest>()), Times.Exactly(1));           

            _mock.ResetCalls();
            InstantiateClassGenerator.ValidateResourceObjectFullyInstantiated(user);
            _mock.Verify(iam => iam.GetUser(It.IsAny<GetUserRequest>()), Times.Never);
        }

        [TestMethod]
        public void TestResourceAction()
        {
            var userName = "user1";
            var policyName = "policy1";
            var user = _iam.GetUserByName(userName);
            Assert.AreEqual(userName, user.Name);
            _mock.Verify(iam => iam.GetUser(It.IsAny<GetUserRequest>()), Times.Never);

            _mock.Setup(iam => iam.PutUserPolicy(It.IsAny<PutUserPolicyRequest>()))
                .Returns(new PutUserPolicyResponse());

            var policy = user.CreatePolicy(new PutUserPolicyRequest
            {
                PolicyName = policyName,
                PolicyDocument = "{}"
            });

            Assert.AreEqual(userName, policy.UserName);
            Assert.AreEqual(policyName, policy.Name);

            _mock.Verify(iam => iam.PutUserPolicy(It.IsAny<PutUserPolicyRequest>()), Times.Exactly(1));  

            _mock.Setup(iam => iam.GetUserPolicy(It.IsAny<GetUserPolicyRequest>()))
                .Returns((GetUserPolicyRequest request) =>
                {
                    Assert.AreEqual(request.UserName, userName);
                    Assert.AreEqual(request.PolicyName, policyName);
                    return new GetUserPolicyResponse
                    {
                        PolicyName = policyName,
                        PolicyDocument = "{}"
                    };
                });

            InstantiateClassGenerator.ValidateResourceObjectFullyInstantiated(policy);
            _mock.Verify(iam => iam.GetUserPolicy(It.IsAny<GetUserPolicyRequest>()), Times.Exactly(1));
        }
    }
}
