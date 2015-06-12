using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Runtime;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class AssumeRoleTest : TestBase<AmazonIdentityManagementServiceClient>
    {
        string _now;
        string _roleName;
        string _userName;
        Role _role;
        User _user;
        BasicAWSCredentials _userCredentials;
        string _accessKeyId;

        [ClassCleanup]
        public static void ClassCleanup()
        {
            BaseClean();
        }

        [TestInitialize]
        public void Init()
        {
            _now = DateTime.Now.ToFileTime().ToString();
            _roleName = "assume-role-" + _now;
            _userName = "assume-user-" + _now;

            _role = Client.CreateRole(new CreateRoleRequest
            {
                RoleName = _roleName,
                AssumeRolePolicyDocument = @"{
  ""Statement"":
  [
    {
      ""Principal"":{""AWS"":""{AccountId}""},
      ""Effect"":""Allow"",
      ""Action"":[""sts:AssumeRole""]
    }
  ]
}".Replace("{AccountId}", UtilityMethods.AccountId)
            }).Role;

            Client.PutRolePolicy(new PutRolePolicyRequest
            {
                RoleName = _role.RoleName,
                PolicyName = "god-mode",
                PolicyDocument = @"{
    ""Statement"" : [
        {
            ""Effect"" : ""Allow"",
            ""Action"" : ""*"",
            ""Resource"" : ""*""
        }
    ]
}"
            });

            _user = Client.CreateUser(new CreateUserRequest
            {
                UserName = _userName
            }).User;

            Client.PutUserPolicy(new PutUserPolicyRequest
            {
                UserName = _user.UserName,
                PolicyName = "assume-policy-1",
                PolicyDocument = @"{
        ""Statement"":{
            ""Effect"":""Allow"",
            ""Action"":""sts:AssumeRole"",
            ""Resource"":""*""
        }
    }"
            });

            var accessKey = Client.CreateAccessKey(new CreateAccessKeyRequest
            {
                UserName = _user.UserName
            }).AccessKey;

            _accessKeyId = accessKey.AccessKeyId;
            _userCredentials = new BasicAWSCredentials(accessKey.AccessKeyId, accessKey.SecretAccessKey);
        }

        [TestCleanup]
        public void Cleanup()
        {
            var rolePolicies = Client.ListRolePolicies(new ListRolePoliciesRequest { RoleName = _roleName }).PolicyNames;
            foreach (var policy in rolePolicies)
            {
                Client.DeleteRolePolicy(new DeleteRolePolicyRequest
                {
                    RoleName = _roleName,
                    PolicyName = policy
                });
            }
            Client.DeleteRole(new DeleteRoleRequest { RoleName = _roleName });

            var userPolicies = Client.ListUserPolicies(new ListUserPoliciesRequest { UserName = _userName }).PolicyNames;
            foreach (var policy in userPolicies)
            {
                Client.DeleteUserPolicy(new DeleteUserPolicyRequest
                {
                    UserName = _userName,
                    PolicyName = policy
                });
            }
            Client.DeleteAccessKey(new DeleteAccessKeyRequest
            {
                UserName = _userName,
                AccessKeyId = _accessKeyId
            });
            Client.DeleteUser(new DeleteUserRequest { UserName = _userName });
        }

        [TestMethod]
        [TestCategory("SecurityTokenService")]
        public void TestAssumeRole()
        {
            var clientId = Guid.NewGuid();
            var roleArn = _role.Arn;
            const string sessionName = "NetUser";

            // sleep for IAM data to propagate
            Thread.Sleep(TimeSpan.FromSeconds(10));
            var sts = new AmazonSecurityTokenServiceClient(_userCredentials);
            Thread.Sleep(TimeSpan.FromSeconds(60));
            var result = sts.AssumeRole(new AssumeRoleRequest
            {
                RoleArn = roleArn,
                RoleSessionName = sessionName,
                DurationSeconds = 3600,
                ExternalId = clientId.ToString()
            });

            var credentials = result.Credentials;

            var sessionCredentials = new SessionAWSCredentials(credentials.AccessKeyId, credentials.SecretAccessKey, credentials.SessionToken);
            var client = new AmazonIdentityManagementServiceClient(sessionCredentials);
            var response = client.ListRoles();
            Assert.IsNotNull(response);

            client = new AmazonIdentityManagementServiceClient(credentials);
            response = client.ListRoles();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("SecurityTokenService")]
        public void TestAssumeRoleCredentials()
        {
            var clientId = Guid.NewGuid();
            var roleArn = _role.Arn;
            const string sessionName = "NetUser";

            // sleep for IAM data to propagate
            Thread.Sleep(TimeSpan.FromSeconds(10));
            var sts = new AmazonSecurityTokenServiceClient(_userCredentials);
            Thread.Sleep(TimeSpan.FromSeconds(60));
            var request = new AssumeRoleRequest
            {
                RoleArn = roleArn,
                RoleSessionName = sessionName,
                DurationSeconds = 3600,
                ExternalId = clientId.ToString()
            };

            var credentials = new STSAssumeRoleAWSCredentials(sts, request);

            var client = new AmazonIdentityManagementServiceClient(credentials);
            var response = client.ListRoles();
            Assert.IsNotNull(response);
        }

    }
}
