using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;

namespace AWSSDKDocSamples.Amazon.SecretsManager.Generated
{
    class SecretsManagerSamples : ISample
    {
        public void SecretsManagerCancelRotateSecret()
        {
            #region to-cancel-scheduled-rotation-for-a-secret-1523996016032

            var client = new AmazonSecretsManagerClient();
            var response = client.CancelRotateSecret(new CancelRotateSecretRequest 
            {
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerCreateSecret()
        {
            #region to-create-a-basic-secret-1523996473658

            var client = new AmazonSecretsManagerClient();
            var response = client.CreateSecret(new CreateSecretRequest 
            {
                ClientRequestToken = "EXAMPLE1-90ab-cdef-fedc-ba987SECRET1",
                Description = "My test database secret created with the CLI",
                Name = "MyTestDatabaseSecret",
                SecretString = "{\"username\":\"david\",\"password\":\"EXAMPLE-PASSWORD\"}"
            });

            string arn = response.ARN;
            string name = response.Name;
            string versionId = response.VersionId;

            #endregion
        }

        public void SecretsManagerDeleteResourcePolicy()
        {
            #region to-delete-the-resource-based-policy-attached-to-a-secret-1530209419204

            var client = new AmazonSecretsManagerClient();
            var response = client.DeleteResourcePolicy(new DeleteResourcePolicyRequest 
            {
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerDeleteSecret()
        {
            #region to-delete-a-secret-1523996905092

            var client = new AmazonSecretsManagerClient();
            var response = client.DeleteSecret(new DeleteSecretRequest 
            {
                RecoveryWindowInDays = 7,
                SecretId = "MyTestDatabaseSecret1"
            });

            string arn = response.ARN;
            DateTime deletionDate = response.DeletionDate;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerDescribeSecret()
        {
            #region to-retrieve-the-details-of-a-secret-1524000138629

            var client = new AmazonSecretsManagerClient();
            var response = client.DescribeSecret(new DescribeSecretRequest 
            {
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string description = response.Description;
            string kmsKeyId = response.KmsKeyId;
            DateTime lastAccessedDate = response.LastAccessedDate;
            DateTime lastChangedDate = response.LastChangedDate;
            DateTime lastRotatedDate = response.LastRotatedDate;
            string name = response.Name;
            DateTime nextRotationDate = response.NextRotationDate;
            bool rotationEnabled = response.RotationEnabled;
            string rotationLambdaARN = response.RotationLambdaARN;
            RotationRulesType rotationRules = response.RotationRules;
            List<Tag> tags = response.Tags;
            Dictionary<string, List<string>> versionIdsToStages = response.VersionIdsToStages;

            #endregion
        }

        public void SecretsManagerGetRandomPassword()
        {
            #region to-generate-a-random-password-1524000546092

            var client = new AmazonSecretsManagerClient();
            var response = client.GetRandomPassword(new GetRandomPasswordRequest 
            {
                IncludeSpace = true,
                PasswordLength = 20,
                RequireEachIncludedType = true
            });

            string randomPassword = response.RandomPassword;

            #endregion
        }

        public void SecretsManagerGetResourcePolicy()
        {
            #region to-retrieve-the-resource-based-policy-attached-to-a-secret-1530209677536

            var client = new AmazonSecretsManagerClient();
            var response = client.GetResourcePolicy(new GetResourcePolicyRequest 
            {
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;
            string resourcePolicy = response.ResourcePolicy;

            #endregion
        }

        public void SecretsManagerGetSecretValue()
        {
            #region to-retrieve-the-encrypted-secret-value-of-a-secret-1524000702484

            var client = new AmazonSecretsManagerClient();
            var response = client.GetSecretValue(new GetSecretValueRequest 
            {
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            DateTime createdDate = response.CreatedDate;
            string name = response.Name;
            string secretString = response.SecretString;
            string versionId = response.VersionId;
            List<string> versionStages = response.VersionStages;

            #endregion
        }

        public void SecretsManagerListSecrets()
        {
            #region to-list-the-secrets-in-your-account-1524001246087

            var client = new AmazonSecretsManagerClient();
            var response = client.ListSecrets(new ListSecretsRequest 
            {
            });

            List<SecretListEntry> secretList = response.SecretList;

            #endregion
        }

        public void SecretsManagerListSecretVersionIds()
        {
            #region to-list-all-of-the-secret-versions-associated-with-a-secret-1524000999164

            var client = new AmazonSecretsManagerClient();
            var response = client.ListSecretVersionIds(new ListSecretVersionIdsRequest 
            {
                IncludeDeprecated = true,
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;
            List<SecretVersionsListEntry> versions = response.Versions;

            #endregion
        }

        public void SecretsManagerPutResourcePolicy()
        {
            #region to-add-a-resource-based-policy-to-a-secret-1530209881839

            var client = new AmazonSecretsManagerClient();
            var response = client.PutResourcePolicy(new PutResourcePolicyRequest 
            {
                ResourcePolicy = "{
\"Version\":\"2012-10-17\",
\"Statement\":[{
\"Effect\":\"Allow\",
\"Principal\":{
\"AWS\":\"arn:aws:iam::123456789012:root\"
},
\"Action\":\"secretsmanager:GetSecretValue\",
\"Resource\":\"*\"
}]
}",
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerPutSecretValue()
        {
            #region to-store-a-secret-value-in-a-new-version-of-a-secret-1524001393971

            var client = new AmazonSecretsManagerClient();
            var response = client.PutSecretValue(new PutSecretValueRequest 
            {
                ClientRequestToken = "EXAMPLE2-90ab-cdef-fedc-ba987EXAMPLE",
                SecretId = "MyTestDatabaseSecret",
                SecretString = "{\"username\":\"david\",\"password\":\"EXAMPLE-PASSWORD\"}"
            });

            string arn = response.ARN;
            string name = response.Name;
            string versionId = response.VersionId;
            List<string> versionStages = response.VersionStages;

            #endregion
        }

        public void SecretsManagerRestoreSecret()
        {
            #region to-restore-a-previously-deleted-secret-1524001513930

            var client = new AmazonSecretsManagerClient();
            var response = client.RestoreSecret(new RestoreSecretRequest 
            {
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerRotateSecret()
        {
            #region to-configure-rotation-for-a-secret-1524001629475

            var client = new AmazonSecretsManagerClient();
            var response = client.RotateSecret(new RotateSecretRequest 
            {
                RotationLambdaARN = "arn:aws:lambda:us-west-2:123456789012:function:MyTestDatabaseRotationLambda",
                RotationRules = new RotationRulesType {
                    Duration = "2h",
                    ScheduleExpression = "cron(0 16 1,15 * ? *)"
                },
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;
            string versionId = response.VersionId;

            #endregion
        }

        public void SecretsManagerRotateSecret()
        {
            #region to-request-an-immediate-rotation-for-a-secret-1524001949004

            var client = new AmazonSecretsManagerClient();
            var response = client.RotateSecret(new RotateSecretRequest 
            {
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;
            string versionId = response.VersionId;

            #endregion
        }

        public void SecretsManagerTagResource()
        {
            #region to-add-tags-to-a-secret-1524002106718

            var client = new AmazonSecretsManagerClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                SecretId = "MyExampleSecret",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "FirstTag",
                        Value = "SomeValue"
                    },
                    new Tag {
                        Key = "SecondTag",
                        Value = "AnotherValue"
                    }
                }
            });


            #endregion
        }

        public void SecretsManagerUntagResource()
        {
            #region to-remove-tags-from-a-secret-1524002239065

            var client = new AmazonSecretsManagerClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                SecretId = "MyTestDatabaseSecret",
                TagKeys = new List<string> {
                    "FirstTag",
                    "SecondTag"
                }
            });


            #endregion
        }

        public void SecretsManagerUpdateSecret()
        {
            #region to-update-the-description-of-a-secret-1524002349094

            var client = new AmazonSecretsManagerClient();
            var response = client.UpdateSecret(new UpdateSecretRequest 
            {
                ClientRequestToken = "EXAMPLE1-90ab-cdef-fedc-ba987EXAMPLE",
                Description = "This is a new description for the secret.",
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerUpdateSecret()
        {
            #region to-update-the-kms-key-associated-with-a-secret-1524002421563

            var client = new AmazonSecretsManagerClient();
            var response = client.UpdateSecret(new UpdateSecretRequest 
            {
                KmsKeyId = "arn:aws:kms:us-west-2:123456789012:key/EXAMPLE2-90ab-cdef-fedc-ba987EXAMPLE",
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerUpdateSecret()
        {
            #region to-create-a-new-version-of-the-encrypted-secret-value-1524004651836

            var client = new AmazonSecretsManagerClient();
            var response = client.UpdateSecret(new UpdateSecretRequest 
            {
                SecretId = "MyTestDatabaseSecret",
                SecretString = "{JSON STRING WITH CREDENTIALS}"
            });

            string arn = response.ARN;
            string name = response.Name;
            string versionId = response.VersionId;

            #endregion
        }

        public void SecretsManagerUpdateSecretVersionStage()
        {
            #region to-add-a-staging-label-attached-to-a-version-of-a-secret-1524004783841

            var client = new AmazonSecretsManagerClient();
            var response = client.UpdateSecretVersionStage(new UpdateSecretVersionStageRequest 
            {
                MoveToVersionId = "EXAMPLE1-90ab-cdef-fedc-ba987SECRET1",
                SecretId = "MyTestDatabaseSecret",
                VersionStage = "STAGINGLABEL1"
            });

            string arn = response.ARN;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerUpdateSecretVersionStage()
        {
            #region to-delete-a-staging-label-attached-to-a-version-of-a-secret-1524004862181

            var client = new AmazonSecretsManagerClient();
            var response = client.UpdateSecretVersionStage(new UpdateSecretVersionStageRequest 
            {
                RemoveFromVersionId = "EXAMPLE1-90ab-cdef-fedc-ba987SECRET1",
                SecretId = "MyTestDatabaseSecret",
                VersionStage = "STAGINGLABEL1"
            });

            string arn = response.ARN;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerUpdateSecretVersionStage()
        {
            #region to-move-a-staging-label-from-one-version-of-a-secret-to-another-1524004963841

            var client = new AmazonSecretsManagerClient();
            var response = client.UpdateSecretVersionStage(new UpdateSecretVersionStageRequest 
            {
                MoveToVersionId = "EXAMPLE2-90ab-cdef-fedc-ba987SECRET2",
                RemoveFromVersionId = "EXAMPLE1-90ab-cdef-fedc-ba987SECRET1",
                SecretId = "MyTestDatabaseSecret",
                VersionStage = "AWSCURRENT"
            });

            string arn = response.ARN;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerValidateResourcePolicy()
        {
            #region to-validate-the-resource-policy-of-a-secret-1524000138629

            var client = new AmazonSecretsManagerClient();
            var response = client.ValidateResourcePolicy(new ValidateResourcePolicyRequest 
            {
                ResourcePolicy = "{
\"Version\":\"2012-10-17\",
\"Statement\":[{
\"Effect\":\"Allow\",
\"Principal\":{
\"AWS\":\"arn:aws:iam::123456789012:root\"
},
\"Action\":\"secretsmanager:GetSecretValue\",
\"Resource\":\"*\"
}]
}",
                SecretId = "MyTestDatabaseSecret"
            });

            bool policyValidationPassed = response.PolicyValidationPassed;
            List<ValidationErrorsEntry> validationErrors = response.ValidationErrors;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}