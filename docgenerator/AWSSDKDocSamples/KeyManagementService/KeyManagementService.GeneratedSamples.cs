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
        static IAmazonKeyManagementService client = new AmazonKeyManagementServiceClient();
        public void KeyManagementServiceCancelKeyDeletion()
        {
            #region to-cancel-deletion-of-a-cmk-1477428535102

            var response = client.CancelKeyDeletion(new CancelKeyDeletionRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK whose deletion you are canceling. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });

            string keyId = response.KeyId; // The ARN of the CMK whose deletion you canceled.

            #endregion
        }

        public void KeyManagementServiceCreateAlias()
        {
            #region to-create-an-alias-1477505685119

            var response = client.CreateAlias(new CreateAliasRequest 
            {
                AliasName = "alias/ExampleAlias", // The alias to create. Aliases must begin with 'alias/'. Do not use aliases that begin with 'alias/aws' because they are reserved for use by AWS.
                TargetKeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK whose alias you are creating. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });


            #endregion
        }

        public void KeyManagementServiceCreateGrant()
        {
            #region to-create-a-grant-1477972226782

            var response = client.CreateGrant(new CreateGrantRequest 
            {
                GranteePrincipal = "arn:aws:iam::111122223333:role/ExampleRole", // The identity that is given permission to perform the operations specified in the grant.
                KeyId = "arn:aws:kms:us-east-2:444455556666:key/1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the CMK to which the grant applies. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
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
            #region to-create-a-cmk-1478028992966

            var response = client.CreateKey(new CreateKeyRequest 
            {
                Tags = new List<Tag> {
                    new Tag {
                        TagKey = "CreatedBy",
                        TagValue = "ExampleUser"
                    }
                } // One or more tags. Each tag consists of a tag key and a tag value.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // An object that contains information about the CMK created by this operation.

            #endregion
        }

        public void KeyManagementServiceDecrypt()
        {
            #region to-decrypt-data-1478281622886

            var response = client.Decrypt(new DecryptRequest 
            {
                CiphertextBlob =  // The encrypted data (ciphertext).
            });

            string keyId = response.KeyId; // The Amazon Resource Name (ARN) of the CMK that was used to decrypt the data.
            blob plaintext = response.Plaintext; // The decrypted (plaintext) data.

            #endregion
        }

        public void KeyManagementServiceDeleteAlias()
        {
            #region to-delete-an-alias-1478285209338

            var response = client.DeleteAlias(new DeleteAliasRequest 
            {
                AliasName = "alias/ExampleAlias" // The alias to delete.
            });


            #endregion
        }

        public void KeyManagementServiceDeleteImportedKeyMaterial()
        {
            #region to-delete-imported-key-material-1478561674507

            var response = client.DeleteImportedKeyMaterial(new DeleteImportedKeyMaterialRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK whose imported key material you are deleting. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });


            #endregion
        }

        public void KeyManagementServiceDescribeKey()
        {
            #region to-obtain-information-about-a-cmk-1478565820907

            var response = client.DescribeKey(new DescribeKeyRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK that you want information about. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });

            KeyMetadata keyMetadata = response.KeyMetadata; // An object that contains information about the specified CMK.

            #endregion
        }

        public void KeyManagementServiceDisableKey()
        {
            #region to-disable-a-cmk-1478566583659

            var response = client.DisableKey(new DisableKeyRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK to disable. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });


            #endregion
        }

        public void KeyManagementServiceDisableKeyRotation()
        {
            #region to-disable-automatic-rotation-of-key-material-1478624396092

            var response = client.DisableKeyRotation(new DisableKeyRotationRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK whose key material will no longer be rotated. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });


            #endregion
        }

        public void KeyManagementServiceEnableKey()
        {
            #region to-enable-a-cmk-1478627501129

            var response = client.EnableKey(new EnableKeyRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK to enable. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });


            #endregion
        }

        public void KeyManagementServiceEnableKeyRotation()
        {
            #region to-enable-automatic-rotation-of-key-material-1478629109677

            var response = client.EnableKeyRotation(new EnableKeyRotationRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK whose key material will be rotated annually. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });


            #endregion
        }

        public void KeyManagementServiceEncrypt()
        {
            #region to-encrypt-data-1478906026012

            var response = client.Encrypt(new EncryptRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the CMK to use for encryption. You can use the key ID or Amazon Resource Name (ARN) of the CMK, or the name or ARN of an alias that refers to the CMK.
                Plaintext =  // The data to encrypt.
            });

            blob ciphertextBlob = response.CiphertextBlob; // The encrypted data (ciphertext).
            string keyId = response.KeyId; // The ARN of the CMK that was used to encrypt the data.

            #endregion
        }

        public void KeyManagementServiceGenerateDataKey()
        {
            #region to-generate-a-data-key-1478912956062

            var response = client.GenerateDataKey(new GenerateDataKeyRequest 
            {
                KeyId = "alias/ExampleAlias", // The identifier of the CMK to use to encrypt the data key. You can use the key ID or Amazon Resource Name (ARN) of the CMK, or the name or ARN of an alias that refers to the CMK.
                KeySpec = "AES_256" // Specifies the type of data key to return.
            });

            blob ciphertextBlob = response.CiphertextBlob; // The encrypted data key.
            string keyId = response.KeyId; // The ARN of the CMK that was used to encrypt the data key.
            blob plaintext = response.Plaintext; // The unencrypted (plaintext) data key.

            #endregion
        }

        public void KeyManagementServiceGenerateDataKeyWithoutPlaintext()
        {
            #region to-generate-an-encrypted-data-key-1478914121134

            var response = client.GenerateDataKeyWithoutPlaintext(new GenerateDataKeyWithoutPlaintextRequest 
            {
                KeyId = "alias/ExampleAlias", // The identifier of the CMK to use to encrypt the data key. You can use the key ID or Amazon Resource Name (ARN) of the CMK, or the name or ARN of an alias that refers to the CMK.
                KeySpec = "AES_256" // Specifies the type of data key to return.
            });

            blob ciphertextBlob = response.CiphertextBlob; // The encrypted data key.
            string keyId = response.KeyId; // The ARN of the CMK that was used to encrypt the data key.

            #endregion
        }

        public void KeyManagementServiceGenerateRandom()
        {
            #region to-generate-random-data-1479163645600

            var response = client.GenerateRandom(new GenerateRandomRequest 
            {
                NumberOfBytes = 32 // The length of the random data, specified in number of bytes.
            });

            blob plaintext = response.Plaintext; // The random data.

            #endregion
        }

        public void KeyManagementServiceGetKeyPolicy()
        {
            #region to-retrieve-a-key-policy-1479170128325

            var response = client.GetKeyPolicy(new GetKeyPolicyRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the CMK whose key policy you want to retrieve. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
                PolicyName = "default" // The name of the key policy to retrieve.
            });

            string policy = response.Policy; // The key policy document.

            #endregion
        }

        public void KeyManagementServiceGetKeyRotationStatus()
        {
            #region to-retrieve-the-rotation-status-for-a-cmk-1479172287408

            var response = client.GetKeyRotationStatus(new GetKeyRotationStatusRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK whose key material rotation status you want to retrieve. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });

            bool keyRotationEnabled = response.KeyRotationEnabled; // A boolean that indicates the key material rotation status. Returns true when automatic annual rotation of the key material is enabled, or false when it is not.

            #endregion
        }

        public void KeyManagementServiceGetParametersForImport()
        {
            #region to-retrieve-the-public-key-and-import-token-for-a-cmk-1480626483211

            var response = client.GetParametersForImport(new GetParametersForImportRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the CMK for which to retrieve the public key and import token. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
                WrappingAlgorithm = "RSAES_OAEP_SHA_1", // The algorithm that you will use to encrypt the key material before importing it.
                WrappingKeySpec = "RSA_2048" // The type of wrapping key (public key) to return in the response.
            });

            blob importToken = response.ImportToken; // The import token to send with a subsequent ImportKeyMaterial request.
            string keyId = response.KeyId; // The ARN of the CMK for which you are retrieving the public key and import token. This is the same CMK specified in the request.
            DateTime parametersValidTo = response.ParametersValidTo; // The time at which the import token and public key are no longer valid.
            blob publicKey = response.PublicKey; // The public key to use to encrypt the key material before importing it.

            #endregion
        }

        public void KeyManagementServiceImportKeyMaterial()
        {
            #region to-import-key-material-into-a-cmk-1480630551969

            var response = client.ImportKeyMaterial(new ImportKeyMaterialRequest 
            {
                EncryptedKeyMaterial = , // The encrypted key material to import.
                ExpirationModel = "KEY_MATERIAL_DOES_NOT_EXPIRE", // A value that specifies whether the key material expires.
                ImportToken = , // The import token that you received in the response to a previous GetParametersForImport request.
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK to import the key material into. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });


            #endregion
        }

        public void KeyManagementServiceListAliases()
        {
            #region to-list-aliases-1480729693349

            var response = client.ListAliases(new ListAliasesRequest 
            {
            });

            List<AliasListEntry> aliases = response.Aliases; // A list of aliases, including the key ID of the customer master key (CMK) that each alias refers to.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServiceListGrants()
        {
            #region to-list-grants-for-a-cmk-1481067365389

            var response = client.ListGrants(new ListGrantsRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK whose grants you want to list. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });

            List<GrantListEntry> grants = response.Grants; // A list of grants.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServiceListKeyPolicies()
        {
            #region to-list-key-policies-for-a-cmk-1481069780998

            var response = client.ListKeyPolicies(new ListKeyPoliciesRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK whose key policies you want to list. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });

            List<string> policyNames = response.PolicyNames; // A list of key policy names.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServiceListKeys()
        {
            #region to-list-cmks-1481071643069

            var response = client.ListKeys(new ListKeysRequest 
            {
            });

            List<KeyListEntry> keys = response.Keys; // A list of CMKs, including the key ID and Amazon Resource Name (ARN) of each one.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServiceListResourceTags()
        {
            #region to-list-tags-for-a-cmk-1483996855796

            var response = client.ListResourceTags(new ListResourceTagsRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK whose tags you are listing. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });

            List<Tag> tags = response.Tags; // A list of tags.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServiceListRetirableGrants()
        {
            #region to-list-grants-that-the-specified-principal-can-retire-1481140499620

            var response = client.ListRetirableGrants(new ListRetirableGrantsRequest 
            {
                RetiringPrincipal = "arn:aws:iam::111122223333:role/ExampleRole" // The retiring principal whose grants you want to list. Use the Amazon Resource Name (ARN) of an AWS principal such as an AWS account (root), IAM user, federated user, or assumed role user.
            });

            List<GrantListEntry> grants = response.Grants; // A list of grants that the specified principal can retire.
            bool truncated = response.Truncated; // A boolean that indicates whether there are more items in the list. Returns true when there are more items, or false when there are not.

            #endregion
        }

        public void KeyManagementServicePutKeyPolicy()
        {
            #region to-attach-a-key-policy-to-a-cmk-1481147345018

            var response = client.PutKeyPolicy(new PutKeyPolicyRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the CMK to attach the key policy to. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
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

            var response = client.ReEncrypt(new ReEncryptRequest 
            {
                CiphertextBlob = , // The data to reencrypt.
                DestinationKeyId = "0987dcba-09fe-87dc-65ba-ab0987654321" // The identifier of the CMK to use to reencrypt the data. You can use the key ID or Amazon Resource Name (ARN) of the CMK, or the name or ARN of an alias that refers to the CMK.
            });

            blob ciphertextBlob = response.CiphertextBlob; // The reencrypted data.
            string keyId = response.KeyId; // The ARN of the CMK that was used to reencrypt the data.
            string sourceKeyId = response.SourceKeyId; // The ARN of the CMK that was used to originally encrypt the data.

            #endregion
        }

        public void KeyManagementServiceRetireGrant()
        {
            #region to-retire-a-grant-1481327028297

            var response = client.RetireGrant(new RetireGrantRequest 
            {
                GrantId = "0c237476b39f8bc44e45212e08498fbe3151305030726c0590dd8d3e9f3d6a60", // The identifier of the grant to retire.
                KeyId = "arn:aws:kms:us-east-2:444455556666:key/1234abcd-12ab-34cd-56ef-1234567890ab" // The Amazon Resource Name (ARN) of the customer master key (CMK) associated with the grant.
            });


            #endregion
        }

        public void KeyManagementServiceRevokeGrant()
        {
            #region to-revoke-a-grant-1481329549302

            var response = client.RevokeGrant(new RevokeGrantRequest 
            {
                GrantId = "0c237476b39f8bc44e45212e08498fbe3151305030726c0590dd8d3e9f3d6a60", // The identifier of the grant to revoke.
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the customer master key (CMK) associated with the grant. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });


            #endregion
        }

        public void KeyManagementServiceScheduleKeyDeletion()
        {
            #region to-schedule-a-cmk-for-deletion-1481331111094

            var response = client.ScheduleKeyDeletion(new ScheduleKeyDeletionRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the CMK to schedule for deletion. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
                PendingWindowInDays = 7 // The waiting period, specified in number of days. After the waiting period ends, AWS KMS deletes the CMK.
            });

            DateTime deletionDate = response.DeletionDate; // The date and time after which AWS KMS deletes the CMK.
            string keyId = response.KeyId; // The ARN of the CMK that is scheduled for deletion.

            #endregion
        }

        public void KeyManagementServiceTagResource()
        {
            #region to-tag-a-cmk-1483997246518

            var response = client.TagResource(new TagResourceRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the CMK you are tagging. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
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

            var response = client.UntagResource(new UntagResourceRequest 
            {
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab", // The identifier of the CMK whose tags you are removing.
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

            var response = client.UpdateAlias(new UpdateAliasRequest 
            {
                AliasName = "alias/ExampleAlias", // The alias to update.
                TargetKeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK that the alias will refer to after this operation succeeds. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });


            #endregion
        }

        public void KeyManagementServiceUpdateKeyDescription()
        {
            #region to-update-the-description-of-a-cmk-1481574808619

            var response = client.UpdateKeyDescription(new UpdateKeyDescriptionRequest 
            {
                Description = "Example description that indicates the intended use of this CMK.", // The updated description.
                KeyId = "1234abcd-12ab-34cd-56ef-1234567890ab" // The identifier of the CMK whose description you are updating. You can use the key ID or the Amazon Resource Name (ARN) of the CMK.
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}