using System;
using System.Threading;
using NUnit.Framework;
using CommonTests.Framework;

using Amazon.Runtime;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestFixture]
    public class AssumeRoleTest : TestBase<AmazonIdentityManagementServiceClient>
    {
        string _now;
        string _roleName;
        string _userName;
        Role _role;
        User _user;
        BasicAWSCredentials _userCredentials;
        string _accessKeyId;

        [OneTimeTearDown]
        public void ClassCleanup()
        {
            BaseClean();
        }

        [SetUp]
        public void Init()
        {
            _now = DateTime.Now.ToFileTime().ToString();
            _roleName = "assume-role-" + _now;
            _userName = "assume-user-" + _now;

            _role = Client.CreateRoleAsync(new CreateRoleRequest
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
            }).Result.Role;

            Client.PutRolePolicyAsync(new PutRolePolicyRequest
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
            }).Wait();

            _user = Client.CreateUserAsync(new CreateUserRequest
            {
                UserName = _userName
            }).Result.User;

            Client.PutUserPolicyAsync(new PutUserPolicyRequest
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
            }).Wait();

            var accessKey = Client.CreateAccessKeyAsync(new CreateAccessKeyRequest
            {
                UserName = _user.UserName
            }).Result.AccessKey;

            _accessKeyId = accessKey.AccessKeyId;
            _userCredentials = new BasicAWSCredentials(accessKey.AccessKeyId, accessKey.SecretAccessKey);
        }

        [TearDown]
        public void Cleanup()
        {
            var rolePolicies = Client.ListRolePoliciesAsync(new ListRolePoliciesRequest { RoleName = _roleName }).Result.PolicyNames;
            foreach (var policy in rolePolicies)
            {
                Client.DeleteRolePolicyAsync(new DeleteRolePolicyRequest
                {
                    RoleName = _roleName,
                    PolicyName = policy
                }).Wait();
            }
            Client.DeleteRoleAsync(new DeleteRoleRequest { RoleName = _roleName }).Wait();

            var userPolicies = Client.ListUserPoliciesAsync(new ListUserPoliciesRequest { UserName = _userName }).Result.PolicyNames;
            foreach (var policy in userPolicies)
            {
                Client.DeleteUserPolicyAsync(new DeleteUserPolicyRequest
                {
                    UserName = _userName,
                    PolicyName = policy
                }).Wait();
            }
            Client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest
            {
                UserName = _userName,
                AccessKeyId = _accessKeyId
            }).Wait();
            Client.DeleteUserAsync(new DeleteUserRequest { UserName = _userName }).Wait();
        }

        [Test]
        [Category("SecurityTokenService")]
        public void TestAssumeRole()
        {
            var clientId = Guid.NewGuid();
            var roleArn = _role.Arn;
            const string sessionName = "NetUser";

            // sleep for IAM data to propagate
            UtilityMethods.Sleep(TimeSpan.FromSeconds(10));
            var sts = new AmazonSecurityTokenServiceClient(_userCredentials);
            UtilityMethods.Sleep(TimeSpan.FromSeconds(60));
            var result = sts.AssumeRoleAsync(new AssumeRoleRequest
            {
                RoleArn = roleArn,
                RoleSessionName = sessionName,
                DurationSeconds = 3600,
                ExternalId = clientId.ToString()
            }).Result;

            var credentials = result.Credentials;

            var sessionCredentials = new SessionAWSCredentials(credentials.AccessKeyId, credentials.SecretAccessKey, credentials.SessionToken);
            var client = new AmazonIdentityManagementServiceClient(sessionCredentials);
            var response = client.ListRolesAsync().Result;
            Assert.IsNotNull(response);

            client = new AmazonIdentityManagementServiceClient(credentials);
            response = client.ListRolesAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("SecurityTokenService")]
        public void TestAssumeRoleCredentials()
        {
            var clientId = Guid.NewGuid();
            var roleArn = _role.Arn;
            const string sessionName = "NetUser";

            // sleep for IAM data to propagate
            UtilityMethods.Sleep(TimeSpan.FromSeconds(10));
            var sts = new AmazonSecurityTokenServiceClient(_userCredentials);
            UtilityMethods.Sleep(TimeSpan.FromSeconds(60));
            var request = new AssumeRoleRequest
            {
                RoleArn = roleArn,
                RoleSessionName = sessionName,
                DurationSeconds = 3600,
                ExternalId = clientId.ToString()
            };

            var credentials = new STSAssumeRoleAWSCredentials(sts, request);

            var client = new AmazonIdentityManagementServiceClient(credentials);
            var response = client.ListRolesAsync().Result;
            Assert.IsNotNull(response);
        }

    }
}
