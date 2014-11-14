using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.KeyManagementService;
using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using System.IO;
using System.Text;
using AWSSDK_DotNet.IntegrationTests.Utils;


namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
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

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        // This test is disabled because it creates resources that cannot be removed, KMS keys.
        //[TestMethod]
        [TestCategory("KMS")]
        public void TestService()
        {
            var keys = GetKeys();
            var keysCount = keys.Count;

            var keyMetadata = Client.CreateKey(new CreateKeyRequest
            {
                KeyUsage = KeyUsageType.ENCRYPT_DECRYPT,
                Description = keyDescription
            }).KeyMetadata;
            ValidateKeyMetadata(keyMetadata, keyEnabled: true);
            var keyId = keyMetadata.KeyId;
            string reEncryptKeyId = null;

            try
            {
                keys = GetKeys();
                Assert.AreEqual(keysCount + 1, keys.Count);

                keyMetadata = Client.DescribeKey(keyId).KeyMetadata;
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
                    Client.DisableKey(keyId);
                if (reEncryptKeyId != null)
                    Client.DisableKey(reEncryptKeyId);
            }
        }

        private void TestGeneration(string keyId)
        {
            var gdkResult = Client.GenerateDataKey(new GenerateDataKeyRequest
            {
                KeyId = keyId,
                NumberOfBytes = keySize,
            });
            Assert.IsNotNull(gdkResult.CiphertextBlob);
            Assert.IsNotNull(gdkResult.Plaintext);
            Assert.IsNotNull(gdkResult.KeyId);
            Assert.IsTrue(gdkResult.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.AreEqual(keySize, gdkResult.Plaintext.Length);

            var gdkwpResult = Client.GenerateDataKeyWithoutPlaintext(new GenerateDataKeyWithoutPlaintextRequest
            {
                KeyId = keyId,
                KeySpec = DataKeySpec.AES_256,
            });
            Assert.IsNotNull(gdkwpResult.CiphertextBlob);
            Assert.IsNotNull(gdkwpResult.KeyId);
            Assert.IsTrue(gdkwpResult.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);

            var random = Client.GenerateRandom(numberOfRandomBytes).Plaintext;
            Assert.IsNotNull(random);
            Assert.AreEqual(numberOfRandomBytes, random.Length);
        }

        private void TestEncryption(string keyId, out string reEncryptKeyId)
        {
            var encryptResponse = Client.Encrypt(new EncryptRequest
            {
                KeyId = keyId,
                Plaintext = testData
            });
            Assert.IsTrue(encryptResponse.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
            var cb = encryptResponse.CiphertextBlob;
            Assert.IsNotNull(cb);
            Assert.AreNotEqual(0, cb.Length);

            var decryptResponse = Client.Decrypt(new DecryptRequest
            {
                CiphertextBlob = cb
            });
            Assert.IsTrue(decryptResponse.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
            var plaintext = decryptResponse.Plaintext;

            ValidateEncryptedData(cb, plaintext);

            reEncryptKeyId = Client.CreateKey(new CreateKeyRequest
            {
                KeyUsage = KeyUsageType.ENCRYPT_DECRYPT,
                Description = keyDescription + " For ReEncryption"
            }).KeyMetadata.KeyId;

            var reEncryptResponse = Client.ReEncrypt(new ReEncryptRequest
            {
                CiphertextBlob = cb,
                DestinationKeyId = reEncryptKeyId
            });
            Assert.IsTrue(reEncryptResponse.SourceKeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.IsTrue(reEncryptResponse.KeyId.IndexOf(reEncryptKeyId, StringComparison.OrdinalIgnoreCase) >= 0);
            var reEncryptedCb = reEncryptResponse.CiphertextBlob;

            decryptResponse = Client.Decrypt(new DecryptRequest
            {
                CiphertextBlob = reEncryptedCb
            });
            Assert.IsTrue(decryptResponse.KeyId.IndexOf(reEncryptKeyId, StringComparison.OrdinalIgnoreCase) >= 0);
            plaintext = decryptResponse.Plaintext;

            ValidateEncryptedData(cb, plaintext);
        }

        private void TestKeyChanges(string keyId)
        {
            Client.DisableKey(keyId);
            ValidateKey(keyId, keyEnabled: false);

            Client.EnableKey(keyId);
            ValidateKey(keyId, keyEnabled: true);

            var newKeyDescription = keyDescription + copyText;
            Client.UpdateKeyDescription(keyId, newKeyDescription);
            ValidateKey(keyId, keyEnabled: true, isCopy: true);

            var policyNames = Client.ListKeyPolicies(new ListKeyPoliciesRequest
            {
                KeyId = keyId
            }).PolicyNames;
            Assert.AreEqual(1, policyNames.Count);
            var policyName = policyNames.First();

            var policy = Client.GetKeyPolicy(keyId, policyName).Policy;
            Assert.IsTrue(policy.Length > 0);
            Client.PutKeyPolicy(keyId, policy, policyName);
            policyNames = Client.ListKeyPolicies(new ListKeyPoliciesRequest
            {
                KeyId = keyId
            }).PolicyNames;
            Assert.AreEqual(1, policyNames.Count);
        }

        private void TestGrants(string keyId)
        {
            var accountId = UtilityMethods.AccountId;

            var grants = GetGrants(keyId);
            var grantsCount = grants.Count;

            var createdGrant = Client.CreateGrant(new CreateGrantRequest
            {
                KeyId = keyId,
                GranteePrincipal = accountId,
                Operations = allOperations,
                RetiringPrincipal = accountId
            });
            var grantId = createdGrant.GrantId;
            var grantToken = createdGrant.GrantToken;

            grants = GetGrants(keyId);
            Assert.AreEqual(grantsCount + 1, grants.Count);

            var grant = GetGrant(keyId, grantId);
            Assert.IsNotNull(grant);

            Client.RetireGrant(grantToken);
            grant = GetGrant(keyId, grantId);
            Assert.IsNull(grant);

            Client.RevokeGrant(grantId, keyId);
            grant = GetGrant(keyId, grantId);
            Assert.IsNull(grant);
        }

        private void TestRotation(string keyId)
        {
            var rotationEnabled = Client.GetKeyRotationStatus(keyId).KeyRotationEnabled;
            Assert.IsFalse(rotationEnabled);

            Client.EnableKeyRotation(keyId);
            rotationEnabled = Client.GetKeyRotationStatus(keyId).KeyRotationEnabled;
            Assert.IsTrue(rotationEnabled);

            Client.DisableKeyRotation(keyId);
            rotationEnabled = Client.GetKeyRotationStatus(keyId).KeyRotationEnabled;
            Assert.IsFalse(rotationEnabled);
        }

        private void TestAliases(string keyId)
        {
            var aliases = GetAliases();
            var aliasesCount = aliases.Count;

            Client.CreateAlias(keyAlias, keyId);
            aliases = GetAliases();
            Assert.AreEqual(aliasesCount + 1, aliases.Count);

            Client.DeleteAlias(keyAlias);
            aliases = GetAliases();
            Assert.AreEqual(aliasesCount, aliases.Count);
        }

        public static List<KeyListEntry> GetKeys()
        {
            var keys = new List<KeyListEntry>();
            string nextMarker = null;
            do
            {
                var response = Client.ListKeys(new ListKeysRequest
                {
                    Marker = nextMarker
                });
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
                var response = Client.ListAliases(new ListAliasesRequest
                {
                    Marker = nextMarker
                });
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
                var response = Client.ListGrants(new ListGrantsRequest
                {
                    KeyId = keyId,
                    Marker = nextMarker
                });
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
                    keyMetadata = Client.DescribeKey(keyId).KeyMetadata;
                    ValidateKeyMetadata(keyMetadata, keyEnabled);
                    break;
                }
                catch(AssertFailedException)
                {
                    Thread.Sleep(keyDescribeWait);
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
