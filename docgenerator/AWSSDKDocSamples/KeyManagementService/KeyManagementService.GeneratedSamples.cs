using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.KeyManagementService;
using Amazon.KeyManagementService.Model;

namespace AWSSDKDocSamples.Amazon.KeyManagementService.Generated
{
    class KeyManagementServiceSamples : ISample
    {
        public void KeyManagementServiceCancelKeyDeletion()
        {
            #region CancelKeyDeletion-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CancelKeyDeletion(new CancelKeyDeletionRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            string keyId = response.KeyId;

            #endregion
        }

        public void KeyManagementServiceConnectCustomKeyStore()
        {
            #region ConnectCustomKeyStore-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ConnectCustomKeyStore(new ConnectCustomKeyStoreRequest
            {
                CustomKeyStoreId = "cks-1234567890abcdef0"
            });


            #endregion
        }

        public void KeyManagementServiceCreateAlias()
        {
            #region CreateAlias-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateAlias(new CreateAliasRequest
            {
                AliasName = "alias/ExampleAlias",
                TargetKeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });


            #endregion
        }

        public void KeyManagementServiceCreateCustomKeyStore()
        {
            #region CreateCustomKeyStore-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateCustomKeyStore(new CreateCustomKeyStoreRequest
            {
                CloudHsmClusterId = "cluster-234abcdefABC",
                CustomKeyStoreName = "ExampleKeyStore",
                KeyStorePassword = "kmsPswd",
                TrustAnchorCertificate = "<certificate-goes-here>"
            });

            string customKeyStoreId = response.CustomKeyStoreId;

            #endregion
        }

        public void KeyManagementServiceCreateGrant()
        {
            #region CreateGrant-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateGrant(new CreateGrantRequest
            {
                GranteePrincipal = "arn:aws:iam::111122223333:role/ExampleRole",
                KeyId = "arn:aws:kms:us-east-2:444455556666:key/1234abcd-12ab-34cd-56ef-1234567890ab",
                Operations = new List<string> {
                    "Encrypt",
                    "Decrypt"
                }
            });

            string grantId = response.GrantId;
            string grantToken = response.GrantToken;

            #endregion
        }

        public void KeyManagementServiceCreateGrant()
        {
            #region CreateGrant-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateGrant(new CreateGrantRequest
            {
                Constraints = new GrantConstraints { SourceArn = "arn:aws:dynamodb:us-east-2:444455556666:table/ExampleTable" },
                GranteeServicePrincipal = "service-name.amazonaws.com",
                KeyId = "arn:aws:kms:us-east-2:444455556666:key/1234abcd-12ab-34cd-56ef-1234567890ab",
                Operations = new List<string> {
                    "Encrypt",
                    "Decrypt",
                    "GenerateDataKey",
                    "DescribeKey"
                },
                RetiringServicePrincipal = "service-name.amazonaws.com"
            });

            string grantId = response.GrantId;
            string grantToken = response.GrantToken;

            #endregion
        }

        public void KeyManagementServiceDecapsulate()
        {
            #region Decapsulate-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Decapsulate(new DecapsulateRequest
            {
                EncapsulationAlgorithm = "ML_KEM",
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab",
                SharedSecretCiphertextBlob = new MemoryStream(<binary data>)
            });

            EncapsulationAlgorithmSpec encapsulationAlgorithm = response.EncapsulationAlgorithm;
            string keyId = response.KeyId;
            MemoryStream sharedSecret = response.SharedSecret;

            #endregion
        }

        public void KeyManagementServiceDecrypt()
        {
            #region Decrypt-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Decrypt(new DecryptRequest
            {
                CiphertextBlob = new MemoryStream(<binary data>),
                EncryptionAlgorithm = "RSAES_OAEP_SHA_256",
                KeyId = "0987dcba-09fe-87dc-65ba-ab0987654321"
            });

            EncryptionAlgorithmSpec encryptionAlgorithm = response.EncryptionAlgorithm;
            string keyId = response.KeyId;
            MemoryStream plaintext = response.Plaintext;

            #endregion
        }

        public void KeyManagementServiceDecrypt()
        {
            #region Decrypt-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Decrypt(new DecryptRequest
            {
                CiphertextBlob = new MemoryStream(<binary data>),
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            EncryptionAlgorithmSpec encryptionAlgorithm = response.EncryptionAlgorithm;
            string keyId = response.KeyId;
            string keyMaterialId = response.KeyMaterialId;
            MemoryStream plaintext = response.Plaintext;

            #endregion
        }

        public void KeyManagementServiceDeleteAlias()
        {
            #region DeleteAlias-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DeleteAlias(new DeleteAliasRequest
            {
                AliasName = "alias/ExampleAlias"
            });


            #endregion
        }

        public void KeyManagementServiceDeleteCustomKeyStore()
        {
            #region DeleteCustomKeyStore-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DeleteCustomKeyStore(new DeleteCustomKeyStoreRequest
            {
                CustomKeyStoreId = "cks-1234567890abcdef0"
            });


            #endregion
        }

        public void KeyManagementServiceDeleteImportedKeyMaterial()
        {
            #region DeleteImportedKeyMaterial-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DeleteImportedKeyMaterial(new DeleteImportedKeyMaterialRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab",
                KeyMaterialId = "0b7fd7ddbac6eef27907413567cad8c810e2883dc8a7534067a82ee1142fc1e6"
            });


            #endregion
        }

        public void KeyManagementServiceDeriveSharedSecret()
        {
            #region DeriveSharedSecret-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DeriveSharedSecret(new DeriveSharedSecretRequest
            {
                KeyAgreementAlgorithm = "ECDH",
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab",
                PublicKey = new MemoryStream(MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAvH3Yj0wbkLEpUl95Cv1cJVjsVNSjwGq3tCLnzXfhVwVvmzGN8pYj3U8nKwgouaHbBWNJYjP5VutbbkKS4Kv4GojwZBJyHN17kmxo8yTjRmjR15SKIQ8cqRA2uaERMLnpztIXdZp232PQPbWGxDyXYJ0aJ5EFSag)
            });

            KeyAgreementAlgorithmSpec keyAgreementAlgorithm = response.KeyAgreementAlgorithm;
            string keyId = response.KeyId;
            OriginType keyOrigin = response.KeyOrigin;
            MemoryStream sharedSecret = response.SharedSecret;

            #endregion
        }

        public void KeyManagementServiceDescribeCustomKeyStores()
        {
            #region DescribeCustomKeyStores-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeCustomKeyStores(new DescribeCustomKeyStoresRequest
            {
            });

            List<CustomKeyStoresListEntry> customKeyStores = response.CustomKeyStores;

            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region DescribeKey-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeKey(new DescribeKeyRequest
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            KeyMetadata keyMetadata = response.KeyMetadata;

            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region DescribeKey-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeKey(new DescribeKeyRequest
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            KeyMetadata keyMetadata = response.KeyMetadata;

            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region DescribeKey-3

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeKey(new DescribeKeyRequest
            {
                KeyId = "arn:aws:kms:ap-northeast-1:111122223333:key/mrk-1234abcd12ab34cd56ef1234567890ab"
            });

            KeyMetadata keyMetadata = response.KeyMetadata;

            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region DescribeKey-4

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeKey(new DescribeKeyRequest
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            KeyMetadata keyMetadata = response.KeyMetadata;

            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region DescribeKey-5

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeKey(new DescribeKeyRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            KeyMetadata keyMetadata = response.KeyMetadata;

            #endregion
        }

        public void KeyManagementServiceDisableKey()
        {
            #region DisableKey-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DisableKey(new DisableKeyRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });


            #endregion
        }

        public void KeyManagementServiceDisableKeyRotation()
        {
            #region DisableKeyRotation-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DisableKeyRotation(new DisableKeyRotationRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });


            #endregion
        }

        public void KeyManagementServiceDisconnectCustomKeyStore()
        {
            #region DisconnectCustomKeyStore-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DisconnectCustomKeyStore(new DisconnectCustomKeyStoreRequest
            {
                CustomKeyStoreId = "cks-1234567890abcdef0"
            });


            #endregion
        }

        public void KeyManagementServiceEnableKey()
        {
            #region EnableKey-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.EnableKey(new EnableKeyRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });


            #endregion
        }

        public void KeyManagementServiceEnableKeyRotation()
        {
            #region EnableKeyRotation-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.EnableKeyRotation(new EnableKeyRotationRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab",
                RotationPeriodInDays = 365
            });


            #endregion
        }

        public void KeyManagementServiceEncapsulate()
        {
            #region Encapsulate-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Encapsulate(new EncapsulateRequest
            {
                EncapsulationAlgorithm = "ML_KEM",
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            EncapsulationAlgorithmSpec encapsulationAlgorithm = response.EncapsulationAlgorithm;
            string keyId = response.KeyId;
            MemoryStream sharedSecret = response.SharedSecret;
            MemoryStream sharedSecretCiphertextBlob = response.SharedSecretCiphertextBlob;

            #endregion
        }

        public void KeyManagementServiceEncrypt()
        {
            #region Encrypt-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Encrypt(new EncryptRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab",
                Plaintext = new MemoryStream(<binary data>)
            });

            MemoryStream ciphertextBlob = response.CiphertextBlob;
            EncryptionAlgorithmSpec encryptionAlgorithm = response.EncryptionAlgorithm;
            string keyId = response.KeyId;

            #endregion
        }

        public void KeyManagementServiceEncrypt()
        {
            #region Encrypt-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Encrypt(new EncryptRequest
            {
                EncryptionAlgorithm = "RSAES_OAEP_SHA_256",
                KeyId = "0987dcba-09fe-87dc-65ba-ab0987654321",
                Plaintext = new MemoryStream(<binary data>)
            });

            MemoryStream ciphertextBlob = response.CiphertextBlob;
            EncryptionAlgorithmSpec encryptionAlgorithm = response.EncryptionAlgorithm;
            string keyId = response.KeyId;

            #endregion
        }

        public void KeyManagementServiceGenerateDataKey()
        {
            #region GenerateDataKey-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateDataKey(new GenerateDataKeyRequest
            {
                KeyId = "alias/ExampleAlias",
                KeySpec = "AES_256"
            });

            MemoryStream ciphertextBlob = response.CiphertextBlob;
            string keyId = response.KeyId;
            string keyMaterialId = response.KeyMaterialId;
            MemoryStream plaintext = response.Plaintext;

            #endregion
        }

        public void KeyManagementServiceGenerateDataKeyPair()
        {
            #region GenerateDataKeyPair-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateDataKeyPair(new GenerateDataKeyPairRequest
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab",
                KeyPairSpec = "RSA_3072"
            });

            string keyId = response.KeyId;
            string keyMaterialId = response.KeyMaterialId;
            DataKeyPairSpec keyPairSpec = response.KeyPairSpec;
            MemoryStream privateKeyCiphertextBlob = response.PrivateKeyCiphertextBlob;
            MemoryStream privateKeyPlaintext = response.PrivateKeyPlaintext;
            MemoryStream publicKey = response.PublicKey;

            #endregion
        }

        public void KeyManagementServiceGenerateDataKeyPairWithoutPlaintext()
        {
            #region GenerateDataKeyPairWithoutPlaintext-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateDataKeyPairWithoutPlaintext(new GenerateDataKeyPairWithoutPlaintextRequest
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab",
                KeyPairSpec = "ECC_NIST_P521"
            });

            string keyId = response.KeyId;
            string keyMaterialId = response.KeyMaterialId;
            DataKeyPairSpec keyPairSpec = response.KeyPairSpec;
            MemoryStream privateKeyCiphertextBlob = response.PrivateKeyCiphertextBlob;
            MemoryStream publicKey = response.PublicKey;

            #endregion
        }

        public void KeyManagementServiceGenerateDataKeyWithoutPlaintext()
        {
            #region GenerateDataKeyWithoutPlaintext-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateDataKeyWithoutPlaintext(new GenerateDataKeyWithoutPlaintextRequest
            {
                KeyId = "alias/ExampleAlias",
                KeySpec = "AES_256"
            });

            MemoryStream ciphertextBlob = response.CiphertextBlob;
            string keyId = response.KeyId;
            string keyMaterialId = response.KeyMaterialId;

            #endregion
        }

        public void KeyManagementServiceGenerateMac()
        {
            #region GenerateMac-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateMac(new GenerateMacRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab",
                MacAlgorithm = "HMAC_SHA_384",
                Message = new MemoryStream(Hello World)
            });

            string keyId = response.KeyId;
            MemoryStream mac = response.Mac;
            MacAlgorithmSpec macAlgorithm = response.MacAlgorithm;

            #endregion
        }

        public void KeyManagementServiceGenerateRandom()
        {
            #region GenerateRandom-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateRandom(new GenerateRandomRequest
            {
                NumberOfBytes = 32
            });

            MemoryStream plaintext = response.Plaintext;

            #endregion
        }

        public void KeyManagementServiceGetKeyLastUsage()
        {
            #region GetKeyLastUsage-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GetKeyLastUsage(new GetKeyLastUsageRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            DateTime? keyCreationDate = response.KeyCreationDate;
            string keyId = response.KeyId;
            KeyLastUsageData keyLastUsage = response.KeyLastUsage;
            DateTime? trackingStartDate = response.TrackingStartDate;

            #endregion
        }

        public void KeyManagementServiceGetKeyPolicy()
        {
            #region GetKeyPolicy-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GetKeyPolicy(new GetKeyPolicyRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab",
                PolicyName = "default"
            });

            string policy = response.Policy;

            #endregion
        }

        public void KeyManagementServiceGetPublicKey()
        {
            #region GetPublicKey-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GetPublicKey(new GetPublicKeyRequest
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/0987dcba-09fe-87dc-65ba-ab0987654321"
            });

            CustomerMasterKeySpec customerMasterKeySpec = response.CustomerMasterKeySpec;
            List<string> encryptionAlgorithms = response.EncryptionAlgorithms;
            string keyId = response.KeyId;
            KeyUsageType keyUsage = response.KeyUsage;
            MemoryStream publicKey = response.PublicKey;

            #endregion
        }

        public void KeyManagementServiceImportKeyMaterial()
        {
            #region ImportKeyMaterial-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ImportKeyMaterial(new ImportKeyMaterialRequest
            {
                EncryptedKeyMaterial = new MemoryStream(<binary data>),
                ExpirationModel = "KEY_MATERIAL_DOES_NOT_EXPIRE",
                ImportToken = new MemoryStream(<binary data>),
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            string keyId = response.KeyId;
            string keyMaterialId = response.KeyMaterialId;

            #endregion
        }

        public void KeyManagementServiceListAliases()
        {
            #region ListAliases-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ListAliases(new ListAliasesRequest
            {
            });

            List<AliasListEntry> aliases = response.Aliases;
            bool? truncated = response.Truncated;

            #endregion
        }

        public void KeyManagementServiceListKeyPolicies()
        {
            #region ListKeyPolicies-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ListKeyPolicies(new ListKeyPoliciesRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            List<string> policyNames = response.PolicyNames;
            bool? truncated = response.Truncated;

            #endregion
        }

        public void KeyManagementServiceListKeys()
        {
            #region ListKeys-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ListKeys(new ListKeysRequest
            {
            });

            List<KeyListEntry> keys = response.Keys;
            bool? truncated = response.Truncated;

            #endregion
        }

        public void KeyManagementServiceListResourceTags()
        {
            #region ListResourceTags-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ListResourceTags(new ListResourceTagsRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            List<Tag> tags = response.Tags;
            bool? truncated = response.Truncated;

            #endregion
        }

        public void KeyManagementServicePutKeyPolicy()
        {
            #region PutKeyPolicy-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.PutKeyPolicy(new PutKeyPolicyRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab",
                Policy = "{\n    \"Version\": \"2012-10-17\",\n    \"Id\": \"custom-policy-2016-12-07\",\n    \"Statement\": [\n        {\n            \"Sid\": \"Enable IAM User Permissions\",\n            \"Effect\": \"Allow\",\n            \"Principal\": {\n                \"AWS\": \"arn:aws:iam::111122223333:root\"\n            },\n            \"Action\": \"kms:*\",\n            \"Resource\": \"*\"\n        },\n        {\n            \"Sid\": \"Allow access for Key Administrators\",\n            \"Effect\": \"Allow\",\n            \"Principal\": {\n                \"AWS\": [\n                    \"arn:aws:iam::111122223333:user/ExampleAdminUser\",\n                    \"arn:aws:iam::111122223333:role/ExampleAdminRole\"\n                ]\n            },\n            \"Action\": [\n                \"kms:Create*\",\n                \"kms:Describe*\",\n                \"kms:Enable*\",\n                \"kms:List*\",\n                \"kms:Put*\",\n                \"kms:Update*\",\n                \"kms:Revoke*\",\n                \"kms:Disable*\",\n                \"kms:Get*\",\n                \"kms:Delete*\",\n                \"kms:ScheduleKeyDeletion\",\n                \"kms:CancelKeyDeletion\"\n            ],\n            \"Resource\": \"*\"\n        },\n        {\n            \"Sid\": \"Allow use of the key\",\n            \"Effect\": \"Allow\",\n            \"Principal\": {\n                \"AWS\": \"arn:aws:iam::111122223333:role/ExamplePowerUserRole\"\n            },\n            \"Action\": [\n                \"kms:Encrypt\",\n                \"kms:Decrypt\",\n                \"kms:ReEncrypt*\",\n                \"kms:GenerateDataKey*\",\n                \"kms:DescribeKey\"\n            ],\n            \"Resource\": \"*\"\n        },\n        {\n            \"Sid\": \"Allow attachment of persistent resources\",\n            \"Effect\": \"Allow\",\n            \"Principal\": {\n                \"AWS\": \"arn:aws:iam::111122223333:role/ExamplePowerUserRole\"\n            },\n            \"Action\": [\n                \"kms:CreateGrant\",\n                \"kms:ListGrants\",\n                \"kms:RevokeGrant\"\n            ],\n            \"Resource\": \"*\",\n            \"Condition\": {\n                \"Bool\": {\n                    \"kms:GrantIsForAWSResource\": \"true\"\n                }\n            }\n        }\n    ]\n}\n",
                PolicyName = "default"
            });


            #endregion
        }

        public void KeyManagementServiceReEncrypt()
        {
            #region ReEncrypt-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ReEncrypt(new ReEncryptRequest
            {
                CiphertextBlob = new MemoryStream(<binary data>),
                DestinationKeyId = "0987dcba-09fe-87dc-65ba-ab0987654321"
            });

            MemoryStream ciphertextBlob = response.CiphertextBlob;
            EncryptionAlgorithmSpec destinationEncryptionAlgorithm = response.DestinationEncryptionAlgorithm;
            string destinationKeyMaterialId = response.DestinationKeyMaterialId;
            string keyId = response.KeyId;
            EncryptionAlgorithmSpec sourceEncryptionAlgorithm = response.SourceEncryptionAlgorithm;
            string sourceKeyId = response.SourceKeyId;
            string sourceKeyMaterialId = response.SourceKeyMaterialId;

            #endregion
        }

        public void KeyManagementServiceReplicateKey()
        {
            #region ReplicateKey-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ReplicateKey(new ReplicateKeyRequest
            {
                KeyId = "arn:aws:kms:us-east-1:111122223333:key/mrk-1234abcd12ab34cd56ef1234567890ab",
                ReplicaRegion = "us-west-2"
            });

            KeyMetadata replicaKeyMetadata = response.ReplicaKeyMetadata;
            string replicaPolicy = response.ReplicaPolicy;
            List<Tag> replicaTags = response.ReplicaTags;

            #endregion
        }

        public void KeyManagementServiceRetireGrant()
        {
            #region RetireGrant-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.RetireGrant(new RetireGrantRequest
            {
                GrantId = "0c237476b39f8bc44e45212e08498fbe3151305030726c0590dd8d3e9f3d6a60",
                KeyId = "arn:aws:kms:us-east-2:444455556666:key/1234abcd-12ab-34cd-56ef-1234567890ab"
            });


            #endregion
        }

        public void KeyManagementServiceRevokeGrant()
        {
            #region RevokeGrant-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.RevokeGrant(new RevokeGrantRequest
            {
                GrantId = "0c237476b39f8bc44e45212e08498fbe3151305030726c0590dd8d3e9f3d6a60",
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });


            #endregion
        }

        public void KeyManagementServiceRotateKeyOnDemand()
        {
            #region RotateKeyOnDemand-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.RotateKeyOnDemand(new RotateKeyOnDemandRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });

            string keyId = response.KeyId;

            #endregion
        }

        public void KeyManagementServiceSign()
        {
            #region Sign-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Sign(new SignRequest
            {
                KeyId = "alias/RSA_signing_key",
                Message = new MemoryStream(<message digest to be signed>),
                MessageType = "DIGEST",
                SigningAlgorithm = "RSASSA_PKCS1_V1_5_SHA_256"
            });

            string keyId = response.KeyId;
            MemoryStream signature = response.Signature;
            SigningAlgorithmSpec signingAlgorithm = response.SigningAlgorithm;

            #endregion
        }

        public void KeyManagementServiceSign()
        {
            #region Sign-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Sign(new SignRequest
            {
                KeyId = "alias/ECC_signing_key",
                Message = new MemoryStream(<message to be signed>),
                MessageType = "RAW",
                SigningAlgorithm = "ECDSA_SHA_384"
            });

            string keyId = response.KeyId;
            MemoryStream signature = response.Signature;
            SigningAlgorithmSpec signingAlgorithm = response.SigningAlgorithm;

            #endregion
        }

        public void KeyManagementServiceTagResource()
        {
            #region TagResource-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.TagResource(new TagResourceRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab",
                Tags = new List<Tag> {
                    new Tag {
                        TagKey = "Purpose",
                        TagValue = "Test"
                    }
                }
            });


            #endregion
        }

        public void KeyManagementServiceUntagResource()
        {
            #region UntagResource-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UntagResource(new UntagResourceRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab",
                TagKeys = new List<string> {
                    "Purpose",
                    "CostCenter"
                }
            });


            #endregion
        }

        public void KeyManagementServiceUpdateAlias()
        {
            #region UpdateAlias-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateAlias(new UpdateAliasRequest
            {
                AliasName = "alias/ExampleAlias",
                TargetKeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });


            #endregion
        }

        public void KeyManagementServiceUpdateCustomKeyStore()
        {
            #region UpdateCustomKeyStore-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateCustomKeyStore(new UpdateCustomKeyStoreRequest
            {
                CustomKeyStoreId = "cks-1234567890abcdef0",
                NewCustomKeyStoreName = "DevelopmentKeys"
            });


            #endregion
        }

        public void KeyManagementServiceUpdateCustomKeyStore()
        {
            #region UpdateCustomKeyStore-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateCustomKeyStore(new UpdateCustomKeyStoreRequest
            {
                CustomKeyStoreId = "cks-1234567890abcdef0",
                KeyStorePassword = "ExamplePassword"
            });


            #endregion
        }

        public void KeyManagementServiceUpdateCustomKeyStore()
        {
            #region UpdateCustomKeyStore-3

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateCustomKeyStore(new UpdateCustomKeyStoreRequest
            {
                CustomKeyStoreId = "cks-1234567890abcdef0",
                XksProxyConnectivity = "VPC_ENDPOINT_SERVICE",
                XksProxyUriEndpoint = "https://myproxy-private.xks.example.com",
                XksProxyVpcEndpointServiceName = "com.amazonaws.vpce.us-east-1.vpce-svc-example"
            });


            #endregion
        }

        public void KeyManagementServiceUpdateCustomKeyStore()
        {
            #region UpdateCustomKeyStore-4

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateCustomKeyStore(new UpdateCustomKeyStoreRequest
            {
                CustomKeyStoreId = "cks-1234567890abcdef0",
                XksProxyUriPath = "/new-path/kms/xks/v1"
            });


            #endregion
        }

        public void KeyManagementServiceUpdateCustomKeyStore()
        {
            #region UpdateCustomKeyStore-5

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateCustomKeyStore(new UpdateCustomKeyStoreRequest
            {
                CloudHsmClusterId = "cluster-234abcdefABC",
                CustomKeyStoreId = "cks-1234567890abcdef0"
            });


            #endregion
        }

        public void KeyManagementServiceUpdateKeyDescription()
        {
            #region UpdateKeyDescription-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateKeyDescription(new UpdateKeyDescriptionRequest
            {
                Description = "Example description that indicates the intended use of this KMS key.",
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab"
            });


            #endregion
        }

        public void KeyManagementServiceUpdatePrimaryRegion()
        {
            #region UpdatePrimaryRegion-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdatePrimaryRegion(new UpdatePrimaryRegionRequest
            {
                KeyId = "arn:aws:kms:us-west-1:111122223333:key/mrk-1234abcd12ab34cd56ef1234567890ab",
                PrimaryRegion = "eu-central-1"
            });


            #endregion
        }

        public void KeyManagementServiceVerify()
        {
            #region Verify-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Verify(new VerifyRequest
            {
                KeyId = "alias/ECC_signing_key",
                Message = new MemoryStream(<message to be verified>),
                MessageType = "RAW",
                Signature = new MemoryStream(<binary data>),
                SigningAlgorithm = "ECDSA_SHA_384"
            });

            string keyId = response.KeyId;
            bool? signatureValid = response.SignatureValid;
            SigningAlgorithmSpec signingAlgorithm = response.SigningAlgorithm;

            #endregion
        }

        public void KeyManagementServiceVerify()
        {
            #region Verify-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Verify(new VerifyRequest
            {
                KeyId = "arn:aws:kms:us-east-2:111122223333:key/0987dcba-09fe-87dc-65ba-ab0987654321",
                Message = new MemoryStream(<message digest to be verified>),
                MessageType = "DIGEST",
                Signature = new MemoryStream(<binary data>),
                SigningAlgorithm = "RSASSA_PSS_SHA_512"
            });

            string keyId = response.KeyId;
            bool? signatureValid = response.SignatureValid;
            SigningAlgorithmSpec signingAlgorithm = response.SigningAlgorithm;

            #endregion
        }

        public void KeyManagementServiceVerifyMac()
        {
            #region VerifyMac-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.VerifyMac(new VerifyMacRequest
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab",
                Mac = new MemoryStream(<HMAC_TAG>),
                MacAlgorithm = "HMAC_SHA_384",
                Message = new MemoryStream(Hello World)
            });

            string keyId = response.KeyId;
            MacAlgorithmSpec macAlgorithm = response.MacAlgorithm;
            bool? macValid = response.MacValid;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
