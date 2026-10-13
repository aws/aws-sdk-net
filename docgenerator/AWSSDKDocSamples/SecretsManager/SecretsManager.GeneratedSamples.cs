using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;

namespace AWSSDKDocSamples.Amazon.SecretsManager.Generated
{
    class SecretsManagerSamples : ISample
    {
        public void SecretsManagerBatchGetSecretValue()
        {
            #region BatchGetSecretValue-1

            var client = new AmazonSecretsManagerClient();
            var response = client.BatchGetSecretValue(new BatchGetSecretValueRequest
            {
                SecretIdList = new List<string> {
                    "MySecret1",
                    "MySecret2",
                    "MySecret3"
                }
            });

            List<APIErrorType> errors = response.Errors;
            List<SecretValueEntry> secretValues = response.SecretValues;

            #endregion
        }

        public void SecretsManagerCancelRotateSecret()
        {
            #region CancelRotateSecret-1

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
            #region CreateSecret-1

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
            #region DeleteResourcePolicy-1

            var client = new AmazonSecretsManagerClient();
            var response = client.DeleteResourcePolicy(new DeleteResourcePolicyRequest
            {
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerGetRandomPassword()
        {
            #region GetRandomPassword-1

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
            #region GetResourcePolicy-1

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
            #region GetSecretValue-1

            var client = new AmazonSecretsManagerClient();
            var response = client.GetSecretValue(new GetSecretValueRequest
            {
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            DateTime? createdDate = response.CreatedDate;
            string name = response.Name;
            string secretString = response.SecretString;
            string versionId = response.VersionId;
            List<string> versionStages = response.VersionStages;

            #endregion
        }

        public void SecretsManagerListSecrets()
        {
            #region ListSecrets-1

            var client = new AmazonSecretsManagerClient();
            var response = client.ListSecrets(new ListSecretsRequest
            {
            });

            List<SecretListEntry> secretList = response.SecretList;

            #endregion
        }

        public void SecretsManagerListSecretVersionIds()
        {
            #region ListSecretVersionIds-1

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
            #region PutResourcePolicy-1

            var client = new AmazonSecretsManagerClient();
            var response = client.PutResourcePolicy(new PutResourcePolicyRequest
            {
                ResourcePolicy = "{\n\"Version\":\"2012-10-17\",\n\"Statement\":[{\n\"Effect\":\"Allow\",\n\"Principal\":{\n\"AWS\":\"arn:aws:iam::123456789012:root\"\n},\n\"Action\":\"secretsmanager:GetSecretValue\",\n\"Resource\":\"*\"\n}]\n}",
                SecretId = "MyTestDatabaseSecret"
            });

            string arn = response.ARN;
            string name = response.Name;

            #endregion
        }

        public void SecretsManagerPutSecretValue()
        {
            #region PutSecretValue-1

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

        public void SecretsManagerReplicateSecretToRegions()
        {
            #region ReplicateSecretToRegions-1

            var client = new AmazonSecretsManagerClient();
            var response = client.ReplicateSecretToRegions(new ReplicateSecretToRegionsRequest
            {
                AddReplicaRegions = new List<ReplicaRegionType> {
                    new ReplicaRegionType { Region = "eu-west-3" }
                },
                ForceOverwriteReplicaSecret = true,
                SecretId = "MyTestSecret"
            });

            string arn = response.ARN;
            List<ReplicationStatusType> replicationStatus = response.ReplicationStatus;

            #endregion
        }

        public void SecretsManagerRestoreSecret()
        {
            #region RestoreSecret-1

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
            #region RotateSecret-1

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
            #region RotateSecret-2

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
            #region TagResource-1

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
            #region UntagResource-1

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
            #region UpdateSecret-1

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

        public void SecretsManagerUpdateSecret()
        {
            #region UpdateSecret-2

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
            #region UpdateSecret-3

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

        public void SecretsManagerUpdateSecretVersionStage()
        {
            #region UpdateSecretVersionStage-1

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
            #region UpdateSecretVersionStage-2

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
            #region UpdateSecretVersionStage-3

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
            #region ValidateResourcePolicy-1

            var client = new AmazonSecretsManagerClient();
            var response = client.ValidateResourcePolicy(new ValidateResourcePolicyRequest
            {
                ResourcePolicy = "{\n\"Version\":\"2012-10-17\",\n\"Statement\":[{\n\"Effect\":\"Allow\",\n\"Principal\":{\n\"AWS\":\"arn:aws:iam::123456789012:root\"\n},\n\"Action\":\"secretsmanager:GetSecretValue\",\n\"Resource\":\"*\"\n}]\n}",
                SecretId = "MyTestDatabaseSecret"
            });

            bool? policyValidationPassed = response.PolicyValidationPassed;
            List<ValidationErrorsEntry> validationErrors = response.ValidationErrors;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
