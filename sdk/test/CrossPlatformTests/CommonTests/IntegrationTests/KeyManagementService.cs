using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

using Amazon.KeyManagementService;
using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using System.IO;
using System.Text;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class KeyManagementService : TestBase<AmazonKeyManagementServiceClient>
    {
        private const string keyDescription = ".NET Test Key";
        private const string copyText = " Copy";
        private const int keySize = 1024;
        private const int numberOfRandomBytes = 1023;
        private const string testContents = "This is test data";
        private static string keyAlias = "alias/net_key" + DateTime.Now.ToFileTime();
        private static MemoryStream testData = new MemoryStream(Encoding.UTF8.GetBytes(testContents));
        private static TimeSpan keyMaxWait = TimeSpan.FromSeconds(30);
        private static TimeSpan keyDescribeWait = TimeSpan.FromSeconds(5);
        private static List<string> allOperations = new List<string>
        {
            "Decrypt",
            "Encrypt",
            "GenerateDataKey",
            "GenerateDataKeyWithoutPlaintext",
            "ReEncryptFrom",
            "ReEncryptTo",
            "CreateGrant"
        };

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        // This test is disabled because it creates resources that cannot be removed, KMS keys.
        //[Test]
        [Category("KMS")]
        public void TestService()
        {
            var keys = GetKeys();
            var keysCount = keys.Count;

            var keyMetadata = Client.CreateKeyAsync(new CreateKeyRequest
            {
                KeyUsage = KeyUsageType.ENCRYPT_DECRYPT,
                Description = keyDescription
            }).Result.KeyMetadata;
            ValidateKeyMetadata(keyMetadata, keyEnabled: true);
            var keyId = keyMetadata.KeyId;
            string reEncryptKeyId = null;

            try
            {
                keys = GetKeys();
                Assert.AreEqual(keysCount + 1, keys.Count);

                keyMetadata = Client.DescribeKeyAsync(keyId).Result.KeyMetadata;
                ValidateKeyMetadata(keyMetadata, keyEnabled: true);

                TestAliases(keyId);

                TestGrants(keyId);

                TestEncryption(keyId, out reEncryptKeyId);

                TestGeneration(keyId);

                TestKeyChanges(keyId);

                TestRotation(keyId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
            finally
            {
                if (keyId != null)
                    Client.DisableKeyAsync(keyId).Wait();
                if (reEncryptKeyId != null)
                    Client.DisableKeyAsync(reEncryptKeyId).Wait();
            }
        }

        private void TestGeneration(string keyId)
        {
            var gdkResult = Client.GenerateDataKeyAsync(new GenerateDataKeyRequest
            {
                KeyId = keyId,
                NumberOfBytes = keySize,
            }).Result;
            Assert.IsNotNull(gdkResult.CiphertextBlob);
            Assert.IsNotNull(gdkResult.Plaintext);
            Assert.IsNotNull(gdkResult.KeyId);
            Assert.IsTrue(gdkResult.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.AreEqual(keySize, gdkResult.Plaintext.Length);

            var gdkwpResult = Client.GenerateDataKeyWithoutPlaintextAsync(new GenerateDataKeyWithoutPlaintextRequest
            {
                KeyId = keyId,
                KeySpec = DataKeySpec.AES_256,
            }).Result;
            Assert.IsNotNull(gdkwpResult.CiphertextBlob);
            Assert.IsNotNull(gdkwpResult.KeyId);
            Assert.IsTrue(gdkwpResult.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);

            var random = Client.GenerateRandomAsync(numberOfRandomBytes).Result.Plaintext;
            Assert.IsNotNull(random);
            Assert.AreEqual(numberOfRandomBytes, random.Length);
        }

        private void TestEncryption(string keyId, out string reEncryptKeyId)
        {
            var encryptResponse = Client.EncryptAsync(new EncryptRequest
            {
                KeyId = keyId,
                Plaintext = testData
            }).Result;
            Assert.IsTrue(encryptResponse.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
            var cb = encryptResponse.CiphertextBlob;
            Assert.IsNotNull(cb);
            Assert.AreNotEqual(0, cb.Length);

            var decryptResponse = Client.DecryptAsync(new DecryptRequest
            {
                CiphertextBlob = cb
            }).Result;
            Assert.IsTrue(decryptResponse.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
            var plaintext = decryptResponse.Plaintext;

            ValidateEncryptedData(cb, plaintext);

            reEncryptKeyId = Client.CreateKeyAsync(new CreateKeyRequest
            {
                KeyUsage = KeyUsageType.ENCRYPT_DECRYPT,
                Description = keyDescription + " For ReEncryption"
            }).Result.KeyMetadata.KeyId;

            var reEncryptResponse = Client.ReEncryptAsync(new ReEncryptRequest
            {
                CiphertextBlob = cb,
                DestinationKeyId = reEncryptKeyId
            }).Result;
            Assert.IsTrue(reEncryptResponse.SourceKeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.IsTrue(reEncryptResponse.KeyId.IndexOf(reEncryptKeyId, StringComparison.OrdinalIgnoreCase) >= 0);
            var reEncryptedCb = reEncryptResponse.CiphertextBlob;

            decryptResponse = Client.DecryptAsync(new DecryptRequest
            {
                CiphertextBlob = reEncryptedCb
            }).Result;
            Assert.IsTrue(decryptResponse.KeyId.IndexOf(reEncryptKeyId, StringComparison.OrdinalIgnoreCase) >= 0);
            plaintext = decryptResponse.Plaintext;

            ValidateEncryptedData(cb, plaintext);
        }

        private void TestKeyChanges(string keyId)
        {
            Client.DisableKeyAsync(keyId).Wait();
            ValidateKey(keyId, keyEnabled: false);

            Client.EnableKeyAsync(keyId).Wait();
            ValidateKey(keyId, keyEnabled: true);

            var newKeyDescription = keyDescription + copyText;
            Client.UpdateKeyDescriptionAsync(keyId, newKeyDescription).Wait();
            ValidateKey(keyId, keyEnabled: true, isCopy: true);

            var policyNames = Client.ListKeyPoliciesAsync(new ListKeyPoliciesRequest
            {
                KeyId = keyId
            }).Result.PolicyNames;
            Assert.AreEqual(1, policyNames.Count);
            var policyName = policyNames.First();

            var policy = Client.GetKeyPolicyAsync(keyId, policyName).Result.Policy;
            Assert.IsTrue(policy.Length > 0);
            Client.PutKeyPolicyAsync(keyId, policy, policyName).Wait();
            policyNames = Client.ListKeyPoliciesAsync(new ListKeyPoliciesRequest
            {
                KeyId = keyId
            }).Result.PolicyNames;
            Assert.AreEqual(1, policyNames.Count);
        }

        private void TestGrants(string keyId)
        {
            var accountId = UtilityMethods.AccountId;

            var grants = GetGrants(keyId);
            var grantsCount = grants.Count;

            var createdGrant = Client.CreateGrantAsync(new CreateGrantRequest
            {
                KeyId = keyId,
                GranteePrincipal = accountId,
                Operations = allOperations,
                RetiringPrincipal = accountId
            }).Result;
            var grantId = createdGrant.GrantId;
            var grantToken = createdGrant.GrantToken;

            grants = GetGrants(keyId);
            Assert.AreEqual(grantsCount + 1, grants.Count);

            var grant = GetGrant(keyId, grantId);
            Assert.IsNotNull(grant);

            Client.RetireGrantAsync(grantToken).Wait();
            grant = GetGrant(keyId, grantId);
            Assert.IsNull(grant);

            Client.RevokeGrantAsync(grantId, keyId).Wait();
            grant = GetGrant(keyId, grantId);
            Assert.IsNull(grant);
        }

        private void TestRotation(string keyId)
        {
            var rotationEnabled = Client.GetKeyRotationStatusAsync(keyId).Result.KeyRotationEnabled;
            Assert.IsFalse(rotationEnabled);

            Client.EnableKeyRotationAsync(keyId).Wait();
            rotationEnabled = Client.GetKeyRotationStatusAsync(keyId).Result.KeyRotationEnabled;
            Assert.IsTrue(rotationEnabled);

            Client.DisableKeyRotationAsync(keyId).Wait();
            rotationEnabled = Client.GetKeyRotationStatusAsync(keyId).Result.KeyRotationEnabled;
            Assert.IsFalse(rotationEnabled);
        }

        private void TestAliases(string keyId)
        {
            var aliases = GetAliases();
            var aliasesCount = aliases.Count;

            Client.CreateAliasAsync(keyAlias, keyId).Wait();
            aliases = GetAliases();
            Assert.AreEqual(aliasesCount + 1, aliases.Count);

            Client.DeleteAliasAsync(keyAlias).Wait();
            aliases = GetAliases();
            Assert.AreEqual(aliasesCount, aliases.Count);
        }

        public List<KeyListEntry> GetKeys()
        {
            var keys = new List<KeyListEntry>();
            string nextMarker = null;
            do
            {
                var response = Client.ListKeysAsync(new ListKeysRequest
                {
                    Marker = nextMarker
                }).Result;
                nextMarker = response.NextMarker;
                keys.AddRange(response.Keys);

            } while (!string.IsNullOrEmpty(nextMarker));

            return keys;
        }
        private List<AliasListEntry> GetAliases()
        {
            var aliases = new List<AliasListEntry>();
            string nextMarker = null;
            do
            {
                var response = Client.ListAliasesAsync(new ListAliasesRequest
                {
                    Marker = nextMarker
                }).Result;
                nextMarker = response.NextMarker;
                aliases.AddRange(response.Aliases);

            } while (!string.IsNullOrEmpty(nextMarker));

            return aliases;
        }
        private List<GrantListEntry> GetGrants(string keyId)
        {
            var grants = new List<GrantListEntry>();
            string nextMarker = null;
            do
            {
                var response = Client.ListGrantsAsync(new ListGrantsRequest
                {
                    KeyId = keyId,
                    Marker = nextMarker
                }).Result;
                nextMarker = response.NextMarker;
                grants.AddRange(response.Grants);

            } while (!string.IsNullOrEmpty(nextMarker));

            return grants;
        }
        private GrantListEntry GetGrant(string keyId, string grantId)
        {
            var grants = GetGrants(keyId);
            foreach (var grant in grants)
                if (string.Equals(grant.GrantId, grantId, StringComparison.OrdinalIgnoreCase))
                    return grant;
            return null;
        }

        private void ValidateEncryptedData(MemoryStream cb, MemoryStream plaintext)
        {
            var sourceBytes = testData.ToArray();
            var encryptedBytes = cb.ToArray();
            var decryptedBytes = plaintext.ToArray();

            CollectionAssert.AreEqual(sourceBytes, decryptedBytes);
            CollectionAssert.AreNotEqual(sourceBytes, encryptedBytes);

            var text = Encoding.UTF8.GetString(decryptedBytes);
            Assert.AreEqual(testContents, text);
        }
        private void ValidateKey(string keyId, bool keyEnabled, bool isCopy = false)
        {
            var stopTime = DateTime.Now + keyMaxWait;

            KeyMetadata keyMetadata = null;
            while(DateTime.Now < stopTime)
            {
                try
                {
                    keyMetadata = Client.DescribeKeyAsync(keyId).Result.KeyMetadata;
                    ValidateKeyMetadata(keyMetadata, keyEnabled);
                    break;
                }
                catch(AssertionException)
                {
                    UtilityMethods.Sleep(keyDescribeWait);
                }
            }

            ValidateKeyMetadata(keyMetadata, keyEnabled);
        }
        private static void ValidateKeyMetadata(KeyMetadata keyMetadata, bool keyEnabled, bool isCopy = false)
        {
            Assert.IsNotNull(keyMetadata);
            Assert.IsNotNull(keyMetadata.Arn);
            Assert.IsNotNull(keyMetadata.AWSAccountId);
            Assert.IsNotNull(keyMetadata.Description);
            Assert.IsTrue(keyMetadata.Description.IndexOf(keyDescription, StringComparison.Ordinal) >= 0);
            if (isCopy)
                Assert.IsTrue(keyMetadata.Description.IndexOf(copyText, StringComparison.Ordinal) >= 0);
            Assert.IsNotNull(keyMetadata.KeyId);
            Assert.AreEqual(keyMetadata.KeyUsage, KeyUsageType.ENCRYPT_DECRYPT);
            Assert.AreEqual(keyEnabled, keyMetadata.Enabled);
            Assert.AreNotEqual(DateTime.MinValue, keyMetadata.CreationDate);
        }
    }
}
