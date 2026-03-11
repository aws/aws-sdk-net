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
                    "PULL_THROUGH_CACHE",
                    "CREATE_ON_PUSH"
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

        public void ECRDeregisterPullTimeUpdateExclusion()
        {
            #region deregisterpulltimeupdateexclusion-example

            var client = new AmazonECRClient();
            var response = client.DeregisterPullTimeUpdateExclusion(new DeregisterPullTimeUpdateExclusionRequest 
            {
                PrincipalArn = "arn:aws:iam::012345678910:role/ECRAccess"
            });

            string principalArn = response.PrincipalArn;

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

        public void ECRListImageReferrers()
        {
            #region listimagereferrers-basic-example

            var client = new AmazonECRClient();
            var response = client.ListImageReferrers(new ListImageReferrersRequest 
            {
                RepositoryName = "sample-repo",
                SubjectId = new SubjectIdentifier { ImageDigest = "sha256:943e640159415616581703a53fa4ed87e96740655fd67daf2d2146a35337bce5" }
            });

            List<ImageReferrer> referrers = response.Referrers;

            #endregion
        }

        public void ECRListImageReferrers()
        {
            #region listimagereferrers-filtered-example

            var client = new AmazonECRClient();
            var response = client.ListImageReferrers(new ListImageReferrersRequest 
            {
                Filter = new ListImageReferrersFilter { ArtifactTypes = new List<string> {
                    "application/vnd.dev.sigstore.bundle.v0.3+json"
                } },
                RepositoryName = "sample-repo",
                SubjectId = new SubjectIdentifier { ImageDigest = "sha256:943e640159415616581703a53fa4ed87e96740655fd67daf2d2146a35337bce5" }
            });

            List<ImageReferrer> referrers = response.Referrers;

            #endregion
        }

        public void ECRListImageReferrers()
        {
            #region listimagereferrers-archived-example

            var client = new AmazonECRClient();
            var response = client.ListImageReferrers(new ListImageReferrersRequest 
            {
                Filter = new ListImageReferrersFilter { ArtifactStatus = "ANY" },
                RepositoryName = "sample-repo",
                SubjectId = new SubjectIdentifier { ImageDigest = "sha256:943e640159415616581703a53fa4ed87e96740655fd67daf2d2146a35337bce5" }
            });

            List<ImageReferrer> referrers = response.Referrers;

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

        public void ECRListPullTimeUpdateExclusions()
        {
            #region listpulltimeupdateexclusions-basic-example

            var client = new AmazonECRClient();
            var response = client.ListPullTimeUpdateExclusions(new ListPullTimeUpdateExclusionsRequest 
            {
            });

            List<string> pullTimeUpdateExclusions = response.PullTimeUpdateExclusions;

            #endregion
        }

        public void ECRListPullTimeUpdateExclusions()
        {
            #region listpulltimeupdateexclusions-paginated-example

            var client = new AmazonECRClient();
            var response = client.ListPullTimeUpdateExclusions(new ListPullTimeUpdateExclusionsRequest 
            {
                MaxResults = 2
            });

            string nextToken = response.NextToken;
            List<string> pullTimeUpdateExclusions = response.PullTimeUpdateExclusions;

            #endregion
        }

        public void ECRRegisterPullTimeUpdateExclusion()
        {
            #region registerpulltimeupdateexclusion-role-example

            var client = new AmazonECRClient();
            var response = client.RegisterPullTimeUpdateExclusion(new RegisterPullTimeUpdateExclusionRequest 
            {
                PrincipalArn = "arn:aws:iam::012345678910:role/ECRAccess"
            });

            DateTime createdAt = response.CreatedAt;
            string principalArn = response.PrincipalArn;

            #endregion
        }

        public void ECRUpdateImageStorageClass()
        {
            #region updateimagestorageclass-archive-example

            var client = new AmazonECRClient();
            var response = client.UpdateImageStorageClass(new UpdateImageStorageClassRequest 
            {
                ImageId = new ImageIdentifier { ImageDigest = "sha256:0b1a4e0c81c434fa7928e5c4a2651a521ebabc4ff200c65f7e25b99373efca3b" },
                RegistryId = "724772093679",
                RepositoryName = "hello-repository",
                TargetStorageClass = "ARCHIVE"
            });

            ImageIdentifier imageId = response.ImageId;
            string imageStatus = response.ImageStatus;
            string registryId = response.RegistryId;
            string repositoryName = response.RepositoryName;

            #endregion
        }

        public void ECRUpdateImageStorageClass()
        {
            #region updateimagestorageclass-restore-example

            var client = new AmazonECRClient();
            var response = client.UpdateImageStorageClass(new UpdateImageStorageClassRequest 
            {
                ImageId = new ImageIdentifier { ImageDigest = "sha256:0b1a4e0c81c434fa7928e5c4a2651a521ebabc4ff200c65f7e25b99373efca3b" },
                RegistryId = "724772093679",
                RepositoryName = "hello-repository",
                TargetStorageClass = "STANDARD"
            });

            ImageIdentifier imageId = response.ImageId;
            string imageStatus = response.ImageStatus;
            string registryId = response.RegistryId;
            string repositoryName = response.RepositoryName;

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