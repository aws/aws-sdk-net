using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

using Amazon.KeyManagementService;
using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using System.IO;
using System.Text;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
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
                
        // This test is disabled because it creates resources that cannot be removed, KMS keys.
        //[Fact]
        [Trait(CategoryAttribute,"KMS")]
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
                Assert.Equal(keysCount + 1, keys.Count);

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
            Assert.NotNull(gdkResult.CiphertextBlob);
            Assert.NotNull(gdkResult.Plaintext);
            Assert.NotNull(gdkResult.KeyId);
            Assert.True(gdkResult.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Equal(keySize, gdkResult.Plaintext.Length);

            var gdkwpResult = Client.GenerateDataKeyWithoutPlaintextAsync(new GenerateDataKeyWithoutPlaintextRequest
            {
                KeyId = keyId,
                KeySpec = DataKeySpec.AES_256,
            }).Result;
            Assert.NotNull(gdkwpResult.CiphertextBlob);
            Assert.NotNull(gdkwpResult.KeyId);
            Assert.True(gdkwpResult.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);

            var random = Client.GenerateRandomAsync(numberOfRandomBytes).Result.Plaintext;
            Assert.NotNull(random);
            Assert.Equal(numberOfRandomBytes, random.Length);
        }

        private void TestEncryption(string keyId, out string reEncryptKeyId)
        {
            var encryptResponse = Client.EncryptAsync(new EncryptRequest
            {
                KeyId = keyId,
                Plaintext = testData
            }).Result;
            Assert.True(encryptResponse.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
            var cb = encryptResponse.CiphertextBlob;
            Assert.NotNull(cb);
            Assert.NotEqual(0, cb.Length);

            var decryptResponse = Client.DecryptAsync(new DecryptRequest
            {
                CiphertextBlob = cb
            }).Result;
            Assert.True(decryptResponse.KeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
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
            Assert.True(reEncryptResponse.SourceKeyId.IndexOf(keyId, StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.True(reEncryptResponse.KeyId.IndexOf(reEncryptKeyId, StringComparison.OrdinalIgnoreCase) >= 0);
            var reEncryptedCb = reEncryptResponse.CiphertextBlob;

            decryptResponse = Client.DecryptAsync(new DecryptRequest
            {
                CiphertextBlob = reEncryptedCb
            }).Result;
            Assert.True(decryptResponse.KeyId.IndexOf(reEncryptKeyId, StringComparison.OrdinalIgnoreCase) >= 0);
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
            Assert.Equal(1, policyNames.Count);
            var policyName = policyNames.First();

            var policy = Client.GetKeyPolicyAsync(keyId, policyName).Result.Policy;
            Assert.True(policy.Length > 0);
            Client.PutKeyPolicyAsync(keyId, policy, policyName).Wait();
            policyNames = Client.ListKeyPoliciesAsync(new ListKeyPoliciesRequest
            {
                KeyId = keyId
            }).Result.PolicyNames;
            Assert.Equal(1, policyNames.Count);
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
            Assert.Equal(grantsCount + 1, grants.Count);

            var grant = GetGrant(keyId, grantId);
            Assert.NotNull(grant);

            Client.RetireGrantAsync(grantToken).Wait();
            grant = GetGrant(keyId, grantId);
            Assert.Null(grant);

            Client.RevokeGrantAsync(grantId, keyId).Wait();
            grant = GetGrant(keyId, grantId);
            Assert.Null(grant);
        }

        private void TestRotation(string keyId)
        {
            var rotationEnabled = Client.GetKeyRotationStatusAsync(keyId).Result.KeyRotationEnabled;
            Assert.False(rotationEnabled);

            Client.EnableKeyRotationAsync(keyId).Wait();
            rotationEnabled = Client.GetKeyRotationStatusAsync(keyId).Result.KeyRotationEnabled;
            Assert.True(rotationEnabled);

            Client.DisableKeyRotationAsync(keyId).Wait();
            rotationEnabled = Client.GetKeyRotationStatusAsync(keyId).Result.KeyRotationEnabled;
            Assert.False(rotationEnabled);
        }

        private void TestAliases(string keyId)
        {
            var aliases = GetAliases();
            var aliasesCount = aliases.Count;

            Client.CreateAliasAsync(keyAlias, keyId).Wait();
            aliases = GetAliases();
            Assert.Equal(aliasesCount + 1, aliases.Count);

            Client.DeleteAliasAsync(keyAlias).Wait();
            aliases = GetAliases();
            Assert.Equal(aliasesCount, aliases.Count);
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

            Assert.Equal<byte>(sourceBytes, decryptedBytes);
            Assert.NotEqual<byte>(sourceBytes, encryptedBytes);

            var text = Encoding.UTF8.GetString(decryptedBytes);
            Assert.Equal(testContents, text);
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
                catch(Exception)
                {
                    UtilityMethods.Sleep(keyDescribeWait);
                }
            }

            ValidateKeyMetadata(keyMetadata, keyEnabled);
        }
        private static void ValidateKeyMetadata(KeyMetadata keyMetadata, bool keyEnabled, bool isCopy = false)
        {
            Assert.NotNull(keyMetadata);
            Assert.NotNull(keyMetadata.Arn);
            Assert.NotNull(keyMetadata.AWSAccountId);
            Assert.NotNull(keyMetadata.Description);
            Assert.True(keyMetadata.Description.IndexOf(keyDescription, StringComparison.Ordinal) >= 0);
            if (isCopy)
                Assert.True(keyMetadata.Description.IndexOf(copyText, StringComparison.Ordinal) >= 0);
            Assert.NotNull(keyMetadata.KeyId);
            Assert.Equal(keyMetadata.KeyUsage, KeyUsageType.ENCRYPT_DECRYPT);
            Assert.Equal(keyEnabled, keyMetadata.Enabled);
            Assert.NotEqual(DateTime.MinValue, keyMetadata.CreationDate);
        }
    }
}
