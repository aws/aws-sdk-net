using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ECR;
using Amazon.ECR.Model;

namespace AWSSDKDocSamples.Amazon.ECR.Generated
{
    class ECRSamples : ISample
    {
        public void ECRBatchDeleteImage()
        {
            #region batchdeleteimages-example-1470860541707

            var client = new AmazonECRClient();
            var response = client.BatchDeleteImage(new BatchDeleteImageRequest 
            {
                ImageIds = new List<ImageIdentifier> {
                    new ImageIdentifier { ImageTag = "precise" }
                },
                RepositoryName = "ubuntu"
            });

            List<ImageFailure> failures = response.Failures;
            List<ImageIdentifier> imageIds = response.ImageIds;

            #endregion
        }

        public void ECRBatchGetImage()
        {
            #region batchgetimage-example-1470862771437

            var client = new AmazonECRClient();
            var response = client.BatchGetImage(new BatchGetImageRequest 
            {
                ImageIds = new List<ImageIdentifier> {
                    new ImageIdentifier { ImageTag = "precise" }
                },
                RepositoryName = "ubuntu"
            });

            List<ImageFailure> failures = response.Failures;
            List<Image> images = response.Images;

            #endregion
        }

        public void ECRCreateRepository()
        {
            #region createrepository-example-1470863688724

            var client = new AmazonECRClient();
            var response = client.CreateRepository(new CreateRepositoryRequest 
            {
                RepositoryName = "project-a/nginx-web-app"
            });

            Repository repository = response.Repository;

            #endregion
        }

        public void ECRCreateRepositoryCreationTemplate()
        {
            #region create-a-new-repository-creation-template-1713296923053

            var client = new AmazonECRClient();
            var response = client.CreateRepositoryCreationTemplate(new CreateRepositoryCreationTemplateRequest 
            {
                AppliedFor = new List<string> {
                    "REPLICATION",
                    "PULL_THROUGH_CACHE"
                },
                Description = "Repos for testing images",
                EncryptionConfiguration = new EncryptionConfigurationForRepositoryCreationTemplate { EncryptionType = "AES256" },
                ImageTagMutability = "MUTABLE",
                LifecyclePolicy = "{
    \"rules\": [
        {
            \"rulePriority\": 1,
            \"description\": \"Expire images older than 14 days\",
            \"selection\": {
                \"tagStatus\": \"untagged\",
                \"countType\": \"sinceImagePushed\",
                \"countUnit\": \"days\",
                \"countNumber\": 14
            },
            \"action\": {
                \"type\": \"expire\"
            }
        }
    ]
}",
                Prefix = "eng/test",
                RepositoryPolicy = "{
  \"Version\": \"2012-10-17\",
  \"Statement\": [
    {
      \"Sid\": \"LambdaECRPullPolicy\",
      \"Effect\": \"Allow\",
      \"Principal\": {
        \"Service\": \"lambda.amazonaws.com\"
      },
      \"Action\": \"ecr:BatchGetImage\"
    }
  ]
}",
                ResourceTags = new List<Tag> {
                    new Tag {
                        Key = "environment",
                        Value = "test"
                    }
                }
            });

            string registryId = response.RegistryId;
            RepositoryCreationTemplate repositoryCreationTemplate = response.RepositoryCreationTemplate;

            #endregion
        }

        public void ECRDeleteRepository()
        {
            #region deleterepository-example-1470863805703

            var client = new AmazonECRClient();
            var response = client.DeleteRepository(new DeleteRepositoryRequest 
            {
                Force = true,
                RepositoryName = "ubuntu"
            });

            Repository repository = response.Repository;

            #endregion
        }

        public void ECRDeleteRepositoryCreationTemplate()
        {
            #region delete-a-repository-creation-template-1713298142230

            var client = new AmazonECRClient();
            var response = client.DeleteRepositoryCreationTemplate(new DeleteRepositoryCreationTemplateRequest 
            {
                Prefix = "eng"
            });

            string registryId = response.RegistryId;
            RepositoryCreationTemplate repositoryCreationTemplate = response.RepositoryCreationTemplate;

            #endregion
        }

        public void ECRDeleteRepositoryPolicy()
        {
            #region deleterepositorypolicy-example-1470866943748

            var client = new AmazonECRClient();
            var response = client.DeleteRepositoryPolicy(new DeleteRepositoryPolicyRequest 
            {
                RepositoryName = "ubuntu"
            });

            string policyText = response.PolicyText;
            string registryId = response.RegistryId;
            string repositoryName = response.RepositoryName;

            #endregion
        }

        public void ECRDescribeRepositories()
        {
            #region describe-repositories-1470856017467

            var client = new AmazonECRClient();
            var response = client.DescribeRepositories(new DescribeRepositoriesRequest 
            {
            });

            List<Repository> repositories = response.Repositories;

            #endregion
        }

        public void ECRDescribeRepositoryCreationTemplates()
        {
            #region describe-a-repository-creation-template-1713298784302

            var client = new AmazonECRClient();
            var response = client.DescribeRepositoryCreationTemplates(new DescribeRepositoryCreationTemplatesRequest 
            {
                MaxResults = 123,
                NextToken = "",
                Prefixes = new List<string> {
                    "eng"
                }
            });

            string nextToken = response.NextToken;
            string registryId = response.RegistryId;
            List<RepositoryCreationTemplate> repositoryCreationTemplates = response.RepositoryCreationTemplates;

            #endregion
        }

        public void ECRGetAuthorizationToken()
        {
            #region getauthorizationtoken-example-1470867047084

            var client = new AmazonECRClient();
            var response = client.GetAuthorizationToken(new GetAuthorizationTokenRequest 
            {
            });

            List<AuthorizationData> authorizationData = response.AuthorizationData;

            #endregion
        }

        public void ECRGetRepositoryPolicy()
        {
            #region getrepositorypolicy-example-1470867669211

            var client = new AmazonECRClient();
            var response = client.GetRepositoryPolicy(new GetRepositoryPolicyRequest 
            {
                RepositoryName = "ubuntu"
            });

            string policyText = response.PolicyText;
            string registryId = response.RegistryId;
            string repositoryName = response.RepositoryName;

            #endregion
        }

        public void ECRListImages()
        {
            #region listimages-example-1470868161594

            var client = new AmazonECRClient();
            var response = client.ListImages(new ListImagesRequest 
            {
                RepositoryName = "ubuntu"
            });

            List<ImageIdentifier> imageIds = response.ImageIds;

            #endregion
        }

        public void ECRUpdateRepositoryCreationTemplate()
        {
            #region update-a-repository-creation-template-1713299261276

            var client = new AmazonECRClient();
            var response = client.UpdateRepositoryCreationTemplate(new UpdateRepositoryCreationTemplateRequest 
            {
                AppliedFor = new List<string> {
                    "REPLICATION"
                },
                Prefix = "eng/test",
                ResourceTags = new List<Tag> {
                    new Tag {
                        Key = "environment",
                        Value = "test"
                    }
                }
            });

            string registryId = response.RegistryId;
            RepositoryCreationTemplate repositoryCreationTemplate = response.RepositoryCreationTemplate;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}