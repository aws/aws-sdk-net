using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.CognitoIdentity;
using Amazon.CognitoIdentity.Model;
using Amazon;
using System.Threading;
using Amazon.Runtime;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CognitoIdentity : TestBase<AmazonCognitoIdentityClient>
    {
        public static int MaxResults = 15;

        // this will be set to your account id of the format "123456789012"
        private static string TestAccountId = UtilityMethods.AccountId;
        private string poolName = null;
        private string poolId = null;
        private static List<string> allPoolIds = new List<string>();
        private const PoolRoles poolRoles = PoolRoles.Unauthenticated | PoolRoles.Authenticated;

        [Flags]
        enum PoolRoles
        {
            None = 0,
            Authenticated = 1,
            Unauthenticated = 2
        }

        [TestCleanup]
        public void Cleanup()
        {
            CleanupIdentityPools();
            CognitoSync.CleanupCreatedRoles();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("CognitoIdentity")]
        public void TestIdentityPools()
        {
            var pools = GetAllPools();
            Assert.IsNotNull(pools);
            int poolCount = pools.Count;

            CreateIdentityPool(out poolId, out poolName);

            pools = GetAllPools();
            Assert.IsNotNull(pools);
            Assert.AreEqual(poolCount + 1, pools.Count);

            Client.DeleteIdentityPool(new DeleteIdentityPoolRequest
            {
                IdentityPoolId = poolId
            });

            pools = GetAllPools();
            Assert.IsNotNull(pools);
            Assert.AreEqual(poolCount, pools.Count);
        }

        [TestMethod]
        [TestCategory("CognitoIdentity")]
        public void TestIdentities()
        {
            CreateIdentityPool(out poolId, out poolName);

            DateTime identityCreationTime = DateTime.UtcNow;
            var identityId = CreateIdentity(poolId, poolName);

            var identity = Client.DescribeIdentity(identityId);
            Assert.AreEqual(identityId, identity.IdentityId);
            Assert.IsTrue((identity.CreationDate - identityCreationTime).GetAbsolute() < TimeSpan.FromMinutes(1));
            Assert.AreEqual(0, identity.Logins.Count);

            Credentials credentials = UtilityMethods.WaitUntilSuccess<Credentials>(() => Client.GetCredentialsForIdentity(identityId).Credentials);
            Assert.IsNotNull(credentials);
            CognitoSync.TestCredentials(credentials);

            var getOpenIdResult = Client.GetOpenIdToken(new GetOpenIdTokenRequest
            {
                IdentityId = identityId,
            });
            Assert.IsFalse(string.IsNullOrEmpty(getOpenIdResult.IdentityId));
            Assert.IsFalse(string.IsNullOrEmpty(getOpenIdResult.Token));

            var identities = GetAllIdentities(poolId);
            Assert.IsNotNull(identities);
            Assert.AreEqual(1, identities.Count);

            identities = GetAllIdentities(poolId);
            Assert.IsNotNull(identities);
            Assert.AreEqual(1, identities.Count);

            var roles = Client.GetIdentityPoolRoles(new GetIdentityPoolRolesRequest
            {
                IdentityPoolId = poolId
            }).Roles;
            Assert.AreEqual(NumberOfPoolRoles, roles.Count);
        }

        #region Public helper methods

        public static void CleanupIdentityPools()
        {
            foreach (var id in allPoolIds)
            {
                DeleteIdentityPool(id);
            }
            allPoolIds.Clear();
        }

        public static string CreateIdentity(string poolId, string poolName)
        {
            if (string.IsNullOrEmpty(TestAccountId))
                Assert.Fail("TestAccountId must be specified to run these tests");

            var identities = GetAllIdentities(poolId);
            Assert.IsNotNull(identities);
            int identitiesCount = identities.Count;

            var request = new GetIdRequest
            {
                IdentityPoolId = poolId,
                AccountId = TestAccountId
            };
            var identityId = Client.GetId(request).IdentityId;
            Assert.IsFalse(string.IsNullOrEmpty(identityId));

            identities = GetAllIdentities(poolId);
            Assert.IsNotNull(identities);
            Assert.AreEqual(identitiesCount + 1, identities.Count);

            return identityId;
        }

        public static List<IdentityPoolShortDescription> GetAllPools()
        {
            return GetAllPoolsHelper().ToList();
        }

        public static List<IdentityDescription> GetAllIdentities(string poolId)
        {
            return GetAllIdentitiesHelper(poolId).ToList();
        }

        public static void DeleteIdentityPool(string poolId)
        {
            if (!string.IsNullOrEmpty(poolId))
            {
                var allPools = GetAllPools();
                var pool = allPools.SingleOrDefault(p => string.Equals(poolId, p.IdentityPoolId, StringComparison.Ordinal));

                if (pool != null)
                {
                    Console.WriteLine("Found pool with id [{0}], deleting", poolId);
                    Client.DeleteIdentityPool(new DeleteIdentityPoolRequest
                    {
                        IdentityPoolId = poolId
                    });
                }
            }
        }

        public static void CreateIdentityPool(out string poolId, out string poolName)
        {
            poolName = "netTestPool" + DateTime.Now.ToFileTime();
            var request = new CreateIdentityPoolRequest
            {
                IdentityPoolName = poolName,
                AllowUnauthenticatedIdentities = true
            };
            var createPoolResult = Client.CreateIdentityPool(request);
            Assert.IsNotNull(createPoolResult.IdentityPoolId);
            Assert.IsNotNull(createPoolResult.IdentityPoolName);
            Assert.AreEqual(request.AllowUnauthenticatedIdentities, createPoolResult.AllowUnauthenticatedIdentities);
            poolId = createPoolResult.IdentityPoolId;
            allPoolIds.Add(poolId);

            var describePoolResult = Client.DescribeIdentityPool(new DescribeIdentityPoolRequest
            {
                IdentityPoolId = poolId
            });
            Assert.AreEqual(poolId, describePoolResult.IdentityPoolId);
            Assert.AreEqual(poolName, describePoolResult.IdentityPoolName);

            var getIdentityPoolRolesResult = Client.GetIdentityPoolRoles(poolId);
            Assert.AreEqual(poolId, getIdentityPoolRolesResult.IdentityPoolId);
            Assert.AreEqual(0, getIdentityPoolRolesResult.Roles.Count);

            var roles = new Dictionary<string, string>(StringComparer.Ordinal);
            if ((poolRoles & PoolRoles.Unauthenticated) == PoolRoles.Unauthenticated)
                roles["unauthenticated"] = CognitoSync.PrepareRole();
            if ((poolRoles & PoolRoles.Authenticated) == PoolRoles.Authenticated)
                roles["authenticated"] = CognitoSync.PrepareRole();

            Client.SetIdentityPoolRoles(new SetIdentityPoolRolesRequest
            {
                IdentityPoolId = poolId,
                Roles = roles
            });

            getIdentityPoolRolesResult = Client.GetIdentityPoolRoles(poolId);
            Assert.AreEqual(poolId, getIdentityPoolRolesResult.IdentityPoolId);
            Assert.AreEqual(NumberOfPoolRoles, getIdentityPoolRolesResult.Roles.Count);
        }

        private static int NumberOfPoolRoles
        {
            get
            {
                int count = 0;
                if ((poolRoles & PoolRoles.Authenticated) == PoolRoles.Authenticated)
                    count++;
                if ((poolRoles & PoolRoles.Unauthenticated) == PoolRoles.Unauthenticated)
                    count++;
                return count;
            }
        }

        public static void UpdateIdentityPool(string poolId, string poolName, Dictionary<string, string> providers)
        {
            var updateRequest = new UpdateIdentityPoolRequest
            {
                IdentityPoolName = poolName,
                IdentityPoolId = poolId,
                AllowUnauthenticatedIdentities = true,
            };
            if (providers != null && providers.Count > 0)
                updateRequest.SupportedLoginProviders = providers;

            Client.UpdateIdentityPool(updateRequest);
        }

        #endregion

        #region Private members

        private static IEnumerable<IdentityPoolShortDescription> GetAllPoolsHelper()
        {
            var request = new ListIdentityPoolsRequest { MaxResults = MaxResults };
            ListIdentityPoolsResponse result;
            do
            {
                result = Client.ListIdentityPools(request);
                foreach (var pool in result.IdentityPools)
                {
                    Assert.IsNotNull(pool);
                    Assert.IsFalse(string.IsNullOrEmpty(pool.IdentityPoolId));
                    Assert.IsFalse(string.IsNullOrEmpty(pool.IdentityPoolName));
                    yield return pool;
                }

                request.NextToken = result.NextToken;
            } while (!string.IsNullOrEmpty(result.NextToken));
        }

        private static IEnumerable<IdentityDescription> GetAllIdentitiesHelper(string poolId)
        {
            var request = new ListIdentitiesRequest
            {
                MaxResults = MaxResults,
                IdentityPoolId = poolId
            };
            ListIdentitiesResponse result;
            do
            {
                result = Client.ListIdentities(request);
                foreach (var ident in result.Identities)
                {
                    Assert.IsNotNull(ident);
                    Assert.IsFalse(string.IsNullOrEmpty(ident.IdentityId));
                    Assert.IsNotNull(ident.Logins);
                    yield return ident;
                }
                request.NextToken = result.NextToken;
            } while (!string.IsNullOrEmpty(result.NextToken));
        }

        #endregion

    }
}
