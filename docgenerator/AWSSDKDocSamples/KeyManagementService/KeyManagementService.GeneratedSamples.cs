using System;
using System.Collections.Generic;
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
            #region to-cancel-deletion-of-a-cmk-1477428535102

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CancelKeyDeletion(new CancelKeyDeletionRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key whose deletion you are canceling. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });

            string keyId = response.KeyId; // The ARN of the KMS key whose deletion you canceled.

            #endregion
        }

        public void KeyManagementServiceConnectCustomKeyStore()
        {
            #region to-connect-a-custom-key-store-1628626947750

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ConnectCustomKeyStore(new ConnectCustomKeyStoreRequest 
            {
                CustomKeyStoreId = "cks-1234567890abcdef0" // The ID of the AWS KMS custom key store.
            });


            #endregion
        }

        public void KeyManagementServiceCreateAlias()
        {
            #region to-create-an-alias-1477505685119

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateAlias(new CreateAliasRequest 
            {
                AliasName = "alias/ExampleAlias", // The alias to create. Aliases must begin with 'alias/'. Do not use aliases that begin with 'alias/aws' because they are reserved for use by AWS.
                TargetKeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key whose alias you are creating. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });


            #endregion
        }

        public void KeyManagementServiceCreateCustomKeyStore()
        {
            #region to-create-an-aws-cloudhsm-custom-key-store-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateCustomKeyStore(new CreateCustomKeyStoreRequest 
            {
                CloudHsmClusterId = "cluster-1a23b4cdefg", // The ID of the CloudHSM cluster.
                CustomKeyStoreName = "ExampleKeyStore", // A friendly name for the custom key store.
                KeyStorePassword = "kmsPswd", // The password for the kmsuser CU account in the specified cluster.
                TrustAnchorCertificate = "<certificate-goes-here>" // The content of the customerCA.crt file that you created when you initialized the cluster.
            });

            string customKeyStoreId = response.CustomKeyStoreId; // The ID of the new custom key store.

            #endregion
        }

        public void KeyManagementServiceCreateCustomKeyStore()
        {
            #region to-create-an-external-custom-key-store-with-vpc-connectivity-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateCustomKeyStore(new CreateCustomKeyStoreRequest 
            {
                CustomKeyStoreName = "ExampleVPCEndpointKeyStore", // A friendly name for the custom key store
                CustomKeyStoreType = "EXTERNAL_KEY_STORE", // For external key stores, the value must be EXTERNAL_KEY_STORE
                XksProxyAuthenticationCredential = <data>, // The access key ID and secret access key that KMS uses to authenticate to your external key store proxy
                XksProxyConnectivity = "VPC_ENDPOINT_SERVICE", // Indicates how AWS KMS communicates with the external key store proxy
                XksProxyUriEndpoint = "https://myproxy-private.xks.example.com", // The URI that AWS KMS uses to connect to the external key store proxy
                XksProxyUriPath = "/example-prefix/kms/xks/v1", // The URI path to the external key store proxy APIs
                XksProxyVpcEndpointServiceName = "com.amazonaws.vpce.us-east-1.vpce-svc-example1" // The VPC endpoint service that KMS uses to communicate with the external key store proxy
            });

            string customKeyStoreId = response.CustomKeyStoreId; // The ID of the new custom key store.

            #endregion
        }

        public void KeyManagementServiceCreateCustomKeyStore()
        {
            #region to-create-an-external-custom-key-store-with-a-public-endpoint-3

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateCustomKeyStore(new CreateCustomKeyStoreRequest 
            {
                CustomKeyStoreName = "ExamplePublicEndpointKeyStore", // A friendly name for the custom key store
                CustomKeyStoreType = "EXTERNAL_KEY_STORE", // For external key stores, the value must be EXTERNAL_KEY_STORE
                XksProxyAuthenticationCredential = <data>, // The access key ID and secret access key that KMS uses to authenticate to your external key store proxy
                XksProxyConnectivity = "PUBLIC_ENDPOINT", // Indicates how AWS KMS communicates with the external key store proxy
                XksProxyUriEndpoint = "https://myproxy.xks.example.com", // The URI that AWS KMS uses to connect to the external key store proxy
                XksProxyUriPath = "/kms/xks/v1" // The URI path to your external key store proxy API
            });

            string customKeyStoreId = response.CustomKeyStoreId; // The ID of the new custom key store.

            #endregion
        }

        public void KeyManagementServiceCreateGrant()
        {
            #region to-create-a-grant-1477972226782

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateGrant(new CreateGrantRequest 
            {
                GranteePrincipal = "arn:aws:iam::111122223333:role/ExampleRole", // The identity that is given permission to perform the operations specified in the grant.
                KeyId = "arn:aws:kms:us-east-2:444455556666:key/1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the KMS key to which the grant applies. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
                Operations = new List<string> {
                    "Encrypt",
                    "Decrypt"
                } // A list of operations that the grant allows.
            });

            string grantId = response.GrantId; // The unique identifier of the grant.
            string grantToken = response.GrantToken; // The grant token.

            #endregion
        }

        public void KeyManagementServiceCreateKey()
        {
            #region to-create-a-cmk-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateKey(new CreateKeyRequest 
            {
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // Detailed information about the KMS key that this operation creates.

            #endregion
        }

        public void KeyManagementServiceCreateKey()
        {
            #region to-create-an-asymmetric-rsa-kms-key-for-encryption-and-decryption-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateKey(new CreateKeyRequest 
            {
                KeySpec = "RSA_4096", // Describes the type of key material in the KMS key.
                KeyUsage = "ENCRYPT_DECRYPT" // The cryptographic operations for which you can use the KMS key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // Detailed information about the KMS key that this operation creates.

            #endregion
        }

        public void KeyManagementServiceCreateKey()
        {
            #region to-create-an-asymmetric-elliptic-curve-kms-key-for-signing-and-verification-3

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateKey(new CreateKeyRequest 
            {
                KeySpec = "ECC_NIST_P521", // Describes the type of key material in the KMS key.
                KeyUsage = "SIGN_VERIFY" // The cryptographic operations for which you can use the KMS key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // Detailed information about the KMS key that this operation creates.

            #endregion
        }

        public void KeyManagementServiceCreateKey()
        {
            #region to-create-an-hmac-kms-key-1630628752841

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateKey(new CreateKeyRequest 
            {
                KeySpec = "HMAC_384", // Describes the type of key material in the KMS key.
                KeyUsage = "GENERATE_VERIFY_MAC" // The cryptographic operations for which you can use the KMS key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // Detailed information about the KMS key that this operation creates.

            #endregion
        }

        public void KeyManagementServiceCreateKey()
        {
            #region to-create-a-multi-region-primary-kms-key-4

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateKey(new CreateKeyRequest 
            {
                MultiRegion = true // Indicates whether the KMS key is a multi-Region (True) or regional (False) key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // Detailed information about the KMS key that this operation creates.

            #endregion
        }

        public void KeyManagementServiceCreateKey()
        {
            #region to-create-a-kms-key-for-imported-key-material-5

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateKey(new CreateKeyRequest 
            {
                Origin = "EXTERNAL" // The source of the key material for the KMS key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // Detailed information about the KMS key that this operation creates.

            #endregion
        }

        public void KeyManagementServiceCreateKey()
        {
            #region to-create-a-kms-key-in-an-aws-cloudhsm-custom-key-store-6

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateKey(new CreateKeyRequest 
            {
                CustomKeyStoreId = "cks-1234567890abcdef0", // Identifies the custom key store that hosts the KMS key.
                Origin = "AWS_CLOUDHSM" // Indicates the source of the key material for the KMS key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // Detailed information about the KMS key that this operation creates.

            #endregion
        }

        public void KeyManagementServiceCreateKey()
        {
            #region to-create-a-kms-key-in-an-external-custom-key-store-7

            var client = new AmazonKeyManagementServiceClient();
            var response = client.CreateKey(new CreateKeyRequest 
            {
                CustomKeyStoreId = "cks-9876543210fedcba9", // Identifies the custom key store that hosts the KMS key.
                Origin = "EXTERNAL_KEY_STORE", // Indicates the source of the key material for the KMS key.
                XksKeyId = "bb8562717f809024" // Identifies the encryption key in your external key manager that is associated with the KMS key
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // Detailed information about the KMS key that this operation creates.

            #endregion
        }

        public void KeyManagementServiceDecrypt()
        {
            #region to-decrypt-data-1478281622886

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Decrypt(new DecryptRequest 
            {
                CiphertextBlob = new MemoryStream(<binary data>), // The encrypted data (ciphertext).
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab" // A key identifier for the KMS key to use to decrypt the data.
            });

            string keyId = response.KeyId; // The Amazon Resource Name (ARN) of the KMS key that was used to decrypt the data.
            MemoryStream plaintext = response.Plaintext; // The decrypted (plaintext) data.

            #endregion
        }

        public void KeyManagementServiceDeleteAlias()
        {
            #region to-delete-an-alias-1478285209338

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DeleteAlias(new DeleteAliasRequest 
            {
                AliasName = "alias/ExampleAlias" // The alias to delete.
            });


            #endregion
        }

        public void KeyManagementServiceDeleteCustomKeyStore()
        {
            #region to-delete-a-custom-key-store-from-aws-kms-1628630837145

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DeleteCustomKeyStore(new DeleteCustomKeyStoreRequest 
            {
                CustomKeyStoreId = "cks-1234567890abcdef0" // The ID of the custom key store to be deleted.
            });


            #endregion
        }

        public void KeyManagementServiceDeleteImportedKeyMaterial()
        {
            #region to-delete-imported-key-material-1478561674507

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DeleteImportedKeyMaterial(new DeleteImportedKeyMaterialRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key whose imported key material you are deleting. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });


            #endregion
        }

        public void KeyManagementServiceDescribeCustomKeyStores()
        {
            #region to-get-detailed-information-about-custom-key-stores-in-the-account-and-region-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeCustomKeyStores(new DescribeCustomKeyStoresRequest 
            {
            });

            List<CustomKeyStoresListEntry> customKeyStores = response.CustomKeyStores; // Details about each custom key store in the account and Region.

            #endregion
        }

        public void KeyManagementServiceDescribeCustomKeyStores()
        {
            #region to-get-detailed-information-about-a-cloudhsm-custom-key-store-by-name-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeCustomKeyStores(new DescribeCustomKeyStoresRequest 
            {
                CustomKeyStoreName = "ExampleKeyStore" // The friendly name of the custom key store.
            });

            List<CustomKeyStoresListEntry> customKeyStores = response.CustomKeyStores; // Detailed information about the specified custom key store.

            #endregion
        }

        public void KeyManagementServiceDescribeCustomKeyStores()
        {
            #region to-get-detailed-information-about-an-external-key-store--3

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeCustomKeyStores(new DescribeCustomKeyStoresRequest 
            {
                CustomKeyStoreId = "cks-9876543210fedcba9" // The ID of the custom key store.
            });

            List<CustomKeyStoresListEntry> customKeyStores = response.CustomKeyStores; // Detailed information about the specified custom key store.

            #endregion
        }

        public void KeyManagementServiceDescribeCustomKeyStores()
        {
            #region to-get-detailed-information-about-an-external-custom-key-store-by-name-4

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeCustomKeyStores(new DescribeCustomKeyStoresRequest 
            {
                CustomKeyStoreName = "VPCExternalKeystore"
            });

            List<CustomKeyStoresListEntry> customKeyStores = response.CustomKeyStores; // Detailed information about the specified custom key store.

            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region get-key-details-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeKey(new DescribeKeyRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // An identifier for the KMS key. You can use the key ID, key ARN, alias name, alias ARN of the KMS key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // An object that contains information about the specified KMS key.

            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region to-get-details-about-an-rsa-asymmetric-kms-key-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeKey(new DescribeKeyRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // An identifier for the KMS key. You can use the key ID, key ARN, alias name, alias ARN of the KMS key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // An object that contains information about the specified KMS key.

            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region to-get-details-about-a-multi-region-key-3

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeKey(new DescribeKeyRequest 
            {
                KeyId = "arn:aws:kms:ap-northeast-1:111122223333:key/mrk-1234abcd12ab34cd56ef1234567890ab" // An identifier for the KMS key. You can use the key ID, key ARN, alias name, alias ARN of the KMS key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // An object that contains information about the specified KMS key.

            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region to-get-details-about-an-hmac-kms-key-4

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeKey(new DescribeKeyRequest 
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab" // An identifier for the KMS key. You can use the key ID, key ARN, alias name, alias ARN of the KMS key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // An object that contains information about the specified KMS key.

            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region to-get-details-about-a-kms-key-in-an-AWS-CloudHSM-key-store-5

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeKey(new DescribeKeyRequest 
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab" // An identifier for the KMS key. You can use the key ID, key ARN, alias name, alias ARN of the KMS key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // An object that contains information about the specified KMS key.

            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region to-get-details-about-a-kms-key-in-an-external-key-store-6

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DescribeKey(new DescribeKeyRequest 
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab" // An identifier for the KMS key. You can use the key ID, key ARN, alias name, alias ARN of the KMS key.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // An object that contains information about the specified KMS key.

            #endregion
        }

        public void KeyManagementServiceDisableKey()
        {
            #region to-disable-a-cmk-1478566583659

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DisableKey(new DisableKeyRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key to disable. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });


            #endregion
        }

        public void KeyManagementServiceDisableKeyRotation()
        {
            #region to-disable-automatic-rotation-of-key-material-1478624396092

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DisableKeyRotation(new DisableKeyRotationRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key whose key material will no longer be rotated. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });


            #endregion
        }

        public void KeyManagementServiceDisconnectCustomKeyStore()
        {
            #region to-disconnect-a-custom-key-store-from-its-cloudhsm-cluster-1628627955156

            var client = new AmazonKeyManagementServiceClient();
            var response = client.DisconnectCustomKeyStore(new DisconnectCustomKeyStoreRequest 
            {
                CustomKeyStoreId = "cks-1234567890abcdef0" // The ID of the custom key store.
            });


            #endregion
        }

        public void KeyManagementServiceEnableKey()
        {
            #region to-enable-a-cmk-1478627501129

            var client = new AmazonKeyManagementServiceClient();
            var response = client.EnableKey(new EnableKeyRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key to enable. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });


            #endregion
        }

        public void KeyManagementServiceEnableKeyRotation()
        {
            #region to-enable-automatic-rotation-of-key-material-1478629109677

            var client = new AmazonKeyManagementServiceClient();
            var response = client.EnableKeyRotation(new EnableKeyRotationRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key whose key material will be rotated annually. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });


            #endregion
        }

        public void KeyManagementServiceEncrypt()
        {
            #region to-encrypt-data-1478906026012

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Encrypt(new EncryptRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the KMS key to use for encryption. You can use the key ID or Amazon Resource Name (ARN) of the KMS key, or the name or ARN of an alias that refers to the KMS key.
                Plaintext = new MemoryStream(<binary data>) // The data to encrypt.
            });

            MemoryStream ciphertextBlob = response.CiphertextBlob; // The encrypted data (ciphertext).
            string keyId = response.KeyId; // The ARN of the KMS key that was used to encrypt the data.

            #endregion
        }

        public void KeyManagementServiceGenerateDataKey()
        {
            #region to-generate-a-data-key-1478912956062

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateDataKey(new GenerateDataKeyRequest 
            {
                KeyId = "alias/ExampleAlias", // The identifier of the KMS key to use to encrypt the data key. You can use the key ID or Amazon Resource Name (ARN) of the KMS key, or the name or ARN of an alias that refers to the KMS key.
                KeySpec = "AES_256" // Specifies the type of data key to return.
            });

            MemoryStream ciphertextBlob = response.CiphertextBlob; // The encrypted data key.
            string keyId = response.KeyId; // The ARN of the KMS key that was used to encrypt the data key.
            MemoryStream plaintext = response.Plaintext; // The unencrypted (plaintext) data key.

            #endregion
        }

        public void KeyManagementServiceGenerateDataKeyPair()
        {
            #region to-generate-an-rsa-key-pair-for-encryption-and-decryption-1628619376878

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateDataKeyPair(new GenerateDataKeyPairRequest 
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab", // The key ID of the symmetric encryption KMS key that encrypts the private RSA key in the data key pair.
                KeyPairSpec = "RSA_3072" // The requested key spec of the RSA data key pair.
            });

            string keyId = response.KeyId; // The key ARN of the symmetric encryption KMS key that was used to encrypt the private key.
            string keyPairSpec = response.KeyPairSpec; // The actual key spec of the RSA data key pair.
            MemoryStream privateKeyCiphertextBlob = response.PrivateKeyCiphertextBlob; // The encrypted private key of the RSA data key pair.
            MemoryStream privateKeyPlaintext = response.PrivateKeyPlaintext; // The plaintext private key of the RSA data key pair.
            MemoryStream publicKey = response.PublicKey; // The public key (plaintext) of the RSA data key pair.

            #endregion
        }

        public void KeyManagementServiceGenerateDataKeyPairWithoutPlaintext()
        {
            #region to-generate-an-asymmetric-data-key-pair-without-a-plaintext-key-1628620971564

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateDataKeyPairWithoutPlaintext(new GenerateDataKeyPairWithoutPlaintextRequest 
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab", // The symmetric encryption KMS key that encrypts the private key of the ECC data key pair.
                KeyPairSpec = "ECC_NIST_P521" // The requested key spec of the ECC asymmetric data key pair.
            });

            string keyId = response.KeyId; // The key ARN of the symmetric encryption KMS key that encrypted the private key in the ECC asymmetric data key pair.
            string keyPairSpec = response.KeyPairSpec; // The actual key spec of the ECC asymmetric data key pair.
            MemoryStream privateKeyCiphertextBlob = response.PrivateKeyCiphertextBlob; // The encrypted private key of the asymmetric ECC data key pair.
            MemoryStream publicKey = response.PublicKey; // The public key (plaintext).

            #endregion
        }

        public void KeyManagementServiceGenerateDataKeyWithoutPlaintext()
        {
            #region to-generate-an-encrypted-data-key-1478914121134

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateDataKeyWithoutPlaintext(new GenerateDataKeyWithoutPlaintextRequest 
            {
                KeyId = "alias/ExampleAlias", // The identifier of the KMS key to use to encrypt the data key. You can use the key ID or Amazon Resource Name (ARN) of the KMS key, or the name or ARN of an alias that refers to the KMS key.
                KeySpec = "AES_256" // Specifies the type of data key to return.
            });

            MemoryStream ciphertextBlob = response.CiphertextBlob; // The encrypted data key.
            string keyId = response.KeyId; // The ARN of the KMS key that was used to encrypt the data key.

            #endregion
        }

        public void KeyManagementServiceGenerateMac()
        {
            #region to-generate-an-hmac-for-a-message-1631570135665

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateMac(new GenerateMacRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The HMAC KMS key input to the HMAC algorithm.
                MacAlgorithm = "HMAC_SHA_384", // The HMAC algorithm requested for the operation.
                Message = new MemoryStream(Hello World) // The message input to the HMAC algorithm.
            });

            string keyId = response.KeyId; // The key ARN of the HMAC KMS key used in the operation.
            MemoryStream mac = response.Mac; // The HMAC tag that results from this operation.
            string macAlgorithm = response.MacAlgorithm; // The HMAC algorithm used in the operation.

            #endregion
        }

        public void KeyManagementServiceGenerateRandom()
        {
            #region to-generate-random-data-1479163645600

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GenerateRandom(new GenerateRandomRequest 
            {
                NumberOfBytes = 32 // The length of the random data, specified in number of bytes.
            });

            MemoryStream plaintext = response.Plaintext; // The random data.

            #endregion
        }

        public void KeyManagementServiceGetKeyPolicy()
        {
            #region to-retrieve-a-key-policy-1479170128325

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GetKeyPolicy(new GetKeyPolicyRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the KMS key whose key policy you want to retrieve. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
                PolicyName = "default" // The name of the key policy to retrieve.
            });

            string policy = response.Policy; // The key policy document.

            #endregion
        }

        public void KeyManagementServiceGetKeyRotationStatus()
        {
            #region to-retrieve-the-rotation-status-for-a-cmk-1479172287408

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GetKeyRotationStatus(new GetKeyRotationStatusRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key whose key material rotation status you want to retrieve. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });

            bool keyRotationEnabled = response.KeyRotationEnabled; // A boolean that indicates the key material rotation status. Returns true when automatic annual rotation of the key material is enabled, or false when it is not.

            #endregion
        }

        public void KeyManagementServiceGetParametersForImport()
        {
            #region to-retrieve-the-public-key-and-import-token-for-a-cmk-1480626483211

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GetParametersForImport(new GetParametersForImportRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the KMS key for which to retrieve the public key and import token. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
                WrappingAlgorithm = "RSAES_OAEP_SHA_1", // The algorithm that you will use to encrypt the key material before importing it.
                WrappingKeySpec = "RSA_2048" // The type of wrapping key (public key) to return in the response.
            });

            MemoryStream importToken = response.ImportToken; // The import token to send with a subsequent ImportKeyMaterial request.
            string keyId = response.KeyId; // The ARN of the KMS key for which you are retrieving the public key and import token. This is the same KMS key specified in the request.
            DateTime parametersValidTo = response.ParametersValidTo; // The time at which the import token and public key are no longer valid.
            MemoryStream publicKey = response.PublicKey; // The public key to use to encrypt the key material before importing it.

            #endregion
        }

        public void KeyManagementServiceGetPublicKey()
        {
            #region to-download-the-public-key-of-an-asymmetric-kms-key-1628621691873

            var client = new AmazonKeyManagementServiceClient();
            var response = client.GetPublicKey(new GetPublicKeyRequest 
            {
                KeyId = "arn:aws:kms:us-west-2:111122223333:key/0987dcba-09fe-87dc-65ba-ab0987654321" // The key ARN of the asymmetric KMS key.
            });

            string customerMasterKeySpec = response.CustomerMasterKeySpec; // The key spec of the asymmetric KMS key from which the public key was downloaded.
            List<string> encryptionAlgorithms = response.EncryptionAlgorithms; // The encryption algorithms supported by the asymmetric KMS key that was downloaded.
            string keyId = response.KeyId; // The key ARN of the asymmetric KMS key from which the public key was downloaded.
            string keyUsage = response.KeyUsage; // The key usage of the asymmetric KMS key from which the public key was downloaded.
            MemoryStream publicKey = response.PublicKey; // The public key (plaintext) of the asymmetric KMS key.

            #endregion
        }

        public void KeyManagementServiceImportKeyMaterial()
        {
            #region to-import-key-material-into-a-cmk-1480630551969

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ImportKeyMaterial(new ImportKeyMaterialRequest 
            {
                EncryptedKeyMaterial = new MemoryStream(<binary data>), // The encrypted key material to import.
                ExpirationModel = "KEY_MATERIAL_DOES_NOT_EXPIRE", // A value that specifies whether the key material expires.
                ImportToken = new MemoryStream(<binary data>), // The import token that you received in the response to a previous GetParametersForImport request.
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key to import the key material into. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });


            #endregion
        }

        public void KeyManagementServiceListAliases()
        {
            #region to-list-aliases-1480729693349

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ListAliases(new ListAliasesRequest 
            {
            });

            List<AliasListEntry> aliases = response.Aliases; // A list of aliases, including the key ID of the KMS key that each alias refers to.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServiceListGrants()
        {
            #region to-list-grants-for-a-cmk-1481067365389

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ListGrants(new ListGrantsRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key whose grants you want to list. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });

            List<GrantListEntry> grants = response.Grants; // A list of grants.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServiceListKeyPolicies()
        {
            #region to-list-key-policies-for-a-cmk-1481069780998

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ListKeyPolicies(new ListKeyPoliciesRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key whose key policies you want to list. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });

            List<string> policyNames = response.PolicyNames; // A list of key policy names.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServiceListKeys()
        {
            #region to-list-cmks-1481071643069

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ListKeys(new ListKeysRequest 
            {
            });

            List<KeyListEntry> keys = response.Keys; // A list of KMS keys, including the key ID and Amazon Resource Name (ARN) of each one.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServiceListResourceTags()
        {
            #region to-list-tags-for-a-cmk-1483996855796

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ListResourceTags(new ListResourceTagsRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key whose tags you are listing. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });

            List<Tag> tags = response.Tags; // A list of tags.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServiceListRetirableGrants()
        {
            #region to-list-grants-that-the-specified-principal-can-retire-1481140499620

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ListRetirableGrants(new ListRetirableGrantsRequest 
            {
                RetiringPrincipal = "arn:aws:iam::111122223333:role/ExampleRole" // The retiring principal whose grants you want to list. Use the Amazon Resource Name (ARN) of a principal such as an AWS account (root), IAM user, federated user, or assumed role user.
            });

            List<GrantListEntry> grants = response.Grants; // A list of grants that the specified principal can retire.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServicePutKeyPolicy()
        {
            #region to-attach-a-key-policy-to-a-cmk-1481147345018

            var client = new AmazonKeyManagementServiceClient();
            var response = client.PutKeyPolicy(new PutKeyPolicyRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the KMS key to attach the key policy to. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
                Policy = "{
    \"Version\": \"2012-10-17\",
    \"Id\": \"custom-policy-2016-12-07\",
    \"Statement\": [
        {
            \"Sid\": \"Enable IAM User Permissions\",
            \"Effect\": \"Allow\",
            \"Principal\": {
                \"AWS\": \"arn:aws:iam::111122223333:root\"
            },
            \"Action\": \"kms:*\",
            \"Resource\": \"*\"
        },
        {
            \"Sid\": \"Allow access for Key Administrators\",
            \"Effect\": \"Allow\",
            \"Principal\": {
                \"AWS\": [
                    \"arn:aws:iam::111122223333:user/ExampleAdminUser\",
                    \"arn:aws:iam::111122223333:role/ExampleAdminRole\"
                ]
            },
            \"Action\": [
                \"kms:Create*\",
                \"kms:Describe*\",
                \"kms:Enable*\",
                \"kms:List*\",
                \"kms:Put*\",
                \"kms:Update*\",
                \"kms:Revoke*\",
                \"kms:Disable*\",
                \"kms:Get*\",
                \"kms:Delete*\",
                \"kms:ScheduleKeyDeletion\",
                \"kms:CancelKeyDeletion\"
            ],
            \"Resource\": \"*\"
        },
        {
            \"Sid\": \"Allow use of the key\",
            \"Effect\": \"Allow\",
            \"Principal\": {
                \"AWS\": \"arn:aws:iam::111122223333:role/ExamplePowerUserRole\"
            },
            \"Action\": [
                \"kms:Encrypt\",
                \"kms:Decrypt\",
                \"kms:ReEncrypt*\",
                \"kms:GenerateDataKey*\",
                \"kms:DescribeKey\"
            ],
            \"Resource\": \"*\"
        },
        {
            \"Sid\": \"Allow attachment of persistent resources\",
            \"Effect\": \"Allow\",
            \"Principal\": {
                \"AWS\": \"arn:aws:iam::111122223333:role/ExamplePowerUserRole\"
            },
            \"Action\": [
                \"kms:CreateGrant\",
                \"kms:ListGrants\",
                \"kms:RevokeGrant\"
            ],
            \"Resource\": \"*\",
            \"Condition\": {
                \"Bool\": {
                    \"kms:GrantIsForAWSResource\": \"true\"
                }
            }
        }
    ]
}
", // The key policy document.
                PolicyName = "default" // The name of the key policy.
            });


            #endregion
        }

        public void KeyManagementServiceReEncrypt()
        {
            #region to-reencrypt-data-1481230358001

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ReEncrypt(new ReEncryptRequest 
            {
                CiphertextBlob = new MemoryStream(<binary data>), // The data to reencrypt.
                DestinationKeyId = "0987dcba-09fe-87dc-65ba-ab0987654321" // The identifier of the KMS key to use to reencrypt the data. You can use any valid key identifier.
            });

            MemoryStream ciphertextBlob = response.CiphertextBlob; // The reencrypted data.
            string keyId = response.KeyId; // The ARN of the KMS key that was used to reencrypt the data.
            string sourceKeyId = response.SourceKeyId; // The ARN of the KMS key that was originally used to encrypt the data.

            #endregion
        }

        public void KeyManagementServiceReplicateKey()
        {
            #region to-replicate-a-multi-region-key-in-a-different-aws-region-1628622402887

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ReplicateKey(new ReplicateKeyRequest 
            {
                KeyId = "arn:aws:kms:us-east-1:111122223333:key/mrk-1234abcd12ab34cd56ef1234567890ab", // The key ID or key ARN of the multi-Region primary key
                ReplicaRegion = "us-west-2" // The Region of the new replica.
            });

            KeyMetadata replicaKeyMetadata = response.ReplicaKeyMetadata; // An object that displays detailed information about the replica key.
            string replicaPolicy = response.ReplicaPolicy; // The key policy of the replica key. If you don't specify a key policy, the replica key gets the default key policy for a KMS key.
            List<Tag> replicaTags = response.ReplicaTags; // The tags on the replica key, if any.

            #endregion
        }

        public void KeyManagementServiceRetireGrant()
        {
            #region to-retire-a-grant-1481327028297

            var client = new AmazonKeyManagementServiceClient();
            var response = client.RetireGrant(new RetireGrantRequest 
            {
                GrantId = "0c237476b39f8bc44e45212e08498fbe3151305030726c0590dd8d3e9f3d6a60", // The identifier of the grant to retire.
                KeyId = "arn:aws:kms:us-east-2:444455556666:key/1234abcd-12ab-34cd-56ef-1234567890ab" // The Amazon Resource Name (ARN) of the KMS key associated with the grant.
            });


            #endregion
        }

        public void KeyManagementServiceRevokeGrant()
        {
            #region to-revoke-a-grant-1481329549302

            var client = new AmazonKeyManagementServiceClient();
            var response = client.RevokeGrant(new RevokeGrantRequest 
            {
                GrantId = "0c237476b39f8bc44e45212e08498fbe3151305030726c0590dd8d3e9f3d6a60", // The identifier of the grant to revoke.
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key associated with the grant. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });


            #endregion
        }

        public void KeyManagementServiceScheduleKeyDeletion()
        {
            #region to-schedule-a-cmk-for-deletion-1481331111094

            var client = new AmazonKeyManagementServiceClient();
            var response = client.ScheduleKeyDeletion(new ScheduleKeyDeletionRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the KMS key to schedule for deletion. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
                PendingWindowInDays = 7 // The waiting period, specified in number of days. After the waiting period ends, KMS deletes the KMS key.
            });

            DateTime deletionDate = response.DeletionDate; // The date and time after which KMS deletes the KMS key.
            string keyId = response.KeyId; // The ARN of the KMS key that is scheduled for deletion.

            #endregion
        }

        public void KeyManagementServiceSign()
        {
            #region to-digitally-sign-a-message-with-an-asymmetric-kms-key-1628631433832

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Sign(new SignRequest 
            {
                KeyId = "alias/ECC_signing_key", // The asymmetric KMS key to be used to generate the digital signature. This example uses an alias of the KMS key.
                Message = new MemoryStream(<message to be signed>), // Message to be signed. Use Base-64 for the CLI.
                MessageType = "RAW", // Indicates whether the message is RAW or a DIGEST.
                SigningAlgorithm = "ECDSA_SHA_384" // The requested signing algorithm. This must be an algorithm that the KMS key supports.
            });

            string keyId = response.KeyId; // The key ARN of the asymmetric KMS key that was used to sign the message.
            MemoryStream signature = response.Signature; // The digital signature of the message.
            string signingAlgorithm = response.SigningAlgorithm; // The actual signing algorithm that was used to generate the signature.

            #endregion
        }

        public void KeyManagementServiceTagResource()
        {
            #region to-tag-a-cmk-1483997246518

            var client = new AmazonKeyManagementServiceClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the KMS key you are tagging. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
                Tags = new List<Tag> {
                    new Tag {
                        TagKey = "Purpose",
                        TagValue = "Test"
                    }
                } // A list of tags.
            });


            #endregion
        }

        public void KeyManagementServiceUntagResource()
        {
            #region to-remove-tags-from-a-cmk-1483997590962

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the KMS key whose tags you are removing.
                TagKeys = new List<string> {
                    "Purpose",
                    "CostCenter"
                } // A list of tag keys. Provide only the tag keys, not the tag values.
            });


            #endregion
        }

        public void KeyManagementServiceUpdateAlias()
        {
            #region to-update-an-alias-1481572726920

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateAlias(new UpdateAliasRequest 
            {
                AliasName = "alias/ExampleAlias", // The alias to update.
                TargetKeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key that the alias will refer to after this operation succeeds. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });


            #endregion
        }

        public void KeyManagementServiceUpdateCustomKeyStore()
        {
            #region to-edit-the-properties-of-a-custom-key-store-1

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateCustomKeyStore(new UpdateCustomKeyStoreRequest 
            {
                CustomKeyStoreId = "cks-1234567890abcdef0", // The ID of the custom key store that you are updating.
                KeyStorePassword = "ExamplePassword" // The password for the kmsuser crypto user in the CloudHSM cluster.
            });


            #endregion
        }

        public void KeyManagementServiceUpdateCustomKeyStore()
        {
            #region to-edit-the-friendly-name-of-a-custom-key-store-2

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateCustomKeyStore(new UpdateCustomKeyStoreRequest 
            {
                CustomKeyStoreId = "cks-1234567890abcdef0", // The ID of the custom key store that you are updating.
                NewCustomKeyStoreName = "DevelopmentKeys" // A new friendly name for the custom key store.
            });


            #endregion
        }

        public void KeyManagementServiceUpdateCustomKeyStore()
        {
            #region to-associate-the-custom-key-store-with-a-different-but-related-aws-cloudhsm-cluster-3

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateCustomKeyStore(new UpdateCustomKeyStoreRequest 
            {
                CloudHsmClusterId = "cluster-1a23b4cdefg", // The ID of the AWS CloudHSM cluster that you want to associate with the custom key store. This cluster must be related to the original CloudHSM cluster for this key store.
                CustomKeyStoreId = "cks-1234567890abcdef0" // The ID of the custom key store that you are updating.
            });


            #endregion
        }

        public void KeyManagementServiceUpdateCustomKeyStore()
        {
            #region to-update-the-xks-proxy-api-path-of-an-external-custom-key-store-4

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateCustomKeyStore(new UpdateCustomKeyStoreRequest 
            {
                CustomKeyStoreId = "cks-1234567890abcdef0", // The ID of the custom key store that you are updating
                XksProxyUriPath = "/new-path/kms/xks/v1" // The URI path to the external key store proxy APIs
            });


            #endregion
        }

        public void KeyManagementServiceUpdateCustomKeyStore()
        {
            #region to-update-the-proxy-connectivity-of-an-external-key-store-to-vpc_endpoint_service-5

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateCustomKeyStore(new UpdateCustomKeyStoreRequest 
            {
                CustomKeyStoreId = "cks-1234567890abcdef0", // Identifies the custom key store
                XksProxyConnectivity = "VPC_ENDPOINT_SERVICE", // Specifies the connectivity option
                XksProxyUriEndpoint = "https://myproxy-private.xks.example.com", // Specifies the URI endpoint that AWS KMS uses when communicating with the external key store proxy
                XksProxyVpcEndpointServiceName = "com.amazonaws.vpce.us-east-1.vpce-svc-example" // Specifies the name of the VPC endpoint service that the proxy uses for communication
            });


            #endregion
        }

        public void KeyManagementServiceUpdateKeyDescription()
        {
            #region to-update-the-description-of-a-cmk-1481574808619

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdateKeyDescription(new UpdateKeyDescriptionRequest 
            {
                Description = "Example description that indicates the intended use of this KMS key.", // The updated description.
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the KMS key whose description you are updating. You can use the key ID or the Amazon Resource Name (ARN) of the KMS key.
            });


            #endregion
        }

        public void KeyManagementServiceUpdatePrimaryRegion()
        {
            #region to-update-the-primary-region-of-a-multi-region-kms-key-1660249555577

            var client = new AmazonKeyManagementServiceClient();
            var response = client.UpdatePrimaryRegion(new UpdatePrimaryRegionRequest 
            {
                KeyId = "arn:aws:kms:us-west-1:111122223333:key/mrk-1234abcd12ab34cd56ef1234567890ab", // The current primary key.
                PrimaryRegion = "eu-central-1" // The Region of the replica key that will become the primary key.
            });


            #endregion
        }

        public void KeyManagementServiceVerify()
        {
            #region to-use-an-asymmetric-kms-key-to-verify-a-digital-signature-1628633365663

            var client = new AmazonKeyManagementServiceClient();
            var response = client.Verify(new VerifyRequest 
            {
                KeyId = "alias/ECC_signing_key", // The asymmetric KMS key to be used to verify the digital signature. This example uses an alias to identify the KMS key.
                Message = new MemoryStream(<message to be verified>), // The message that was signed.
                MessageType = "RAW", // Indicates whether the message is RAW or a DIGEST.
                Signature = new MemoryStream(<binary data>), // The signature to be verified.
                SigningAlgorithm = "ECDSA_SHA_384" // The signing algorithm to be used to verify the signature.
            });

            string keyId = response.KeyId; // The key ARN of the asymmetric KMS key that was used to verify the digital signature.
            bool signatureValid = response.SignatureValid; // A value of 'true' Indicates that the signature was verified. If verification fails, the call to Verify fails.
            string signingAlgorithm = response.SigningAlgorithm; // The signing algorithm that was used to verify the signature.

            #endregion
        }

        public void KeyManagementServiceVerifyMac()
        {
            #region to-verify-an-hmac-1631570863401

            var client = new AmazonKeyManagementServiceClient();
            var response = client.VerifyMac(new VerifyMacRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The HMAC KMS key input to the HMAC algorithm.
                Mac = new MemoryStream(<HMAC_TAG>), // The HMAC to be verified.
                MacAlgorithm = "HMAC_SHA_384", // The HMAC algorithm requested for the operation.
                Message = new MemoryStream(Hello World) // The message input to the HMAC algorithm.
            });

            string keyId = response.KeyId; // The key ARN of the HMAC key used in the operation.
            string macAlgorithm = response.MacAlgorithm; // The HMAC algorithm used in the operation.
            bool macValid = response.MacValid; // A value of 'true' indicates that verification succeeded. If verification fails, the call to VerifyMac fails.

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}