using System;
using System.Collections.Generic;
using System.IO;
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
            #region BatchDeleteImage-1

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
            #region BatchGetImage-1

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
            #region CreateRepository-1

            var client = new AmazonECRClient();
            var response = client.CreateRepository(new CreateRepositoryRequest
            {
                RepositoryName = "project-a/nginx-web-app"
            });

            Repository repository = response.Repository;

            #endregion
        }

        public void ECRDeleteRepository()
        {
            #region DeleteRepository-1

            var client = new AmazonECRClient();
            var response = client.DeleteRepository(new DeleteRepositoryRequest
            {
                Force = true,
                RepositoryName = "ubuntu"
            });

            Repository repository = response.Repository;

            #endregion
        }

        public void ECRDeleteRepositoryPolicy()
        {
            #region DeleteRepositoryPolicy-1

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
            #region DeregisterPullTimeUpdateExclusion-1

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
            #region DescribeRepositories-1

            var client = new AmazonECRClient();
            var response = client.DescribeRepositories(new DescribeRepositoriesRequest
            {
            });

            List<Repository> repositories = response.Repositories;

            #endregion
        }

        public void ECRGetRepositoryPolicy()
        {
            #region GetRepositoryPolicy-1

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
            #region ListImageReferrers-1

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

        public void ECRListImageReferrers()
        {
            #region ListImageReferrers-2

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
            #region ListImageReferrers-3

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

        public void ECRListImages()
        {
            #region ListImages-1

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
            #region ListPullTimeUpdateExclusions-1

            var client = new AmazonECRClient();
            var response = client.ListPullTimeUpdateExclusions(new ListPullTimeUpdateExclusionsRequest
            {
            });

            List<string> pullTimeUpdateExclusions = response.PullTimeUpdateExclusions;

            #endregion
        }

        public void ECRListPullTimeUpdateExclusions()
        {
            #region ListPullTimeUpdateExclusions-2

            var client = new AmazonECRClient();
            var response = client.ListPullTimeUpdateExclusions(new ListPullTimeUpdateExclusionsRequest
            {
                MaxResults = 2
            });

            string nextToken = response.NextToken;
            List<string> pullTimeUpdateExclusions = response.PullTimeUpdateExclusions;

            #endregion
        }

        public void ECRUpdateImageStorageClass()
        {
            #region UpdateImageStorageClass-1

            var client = new AmazonECRClient();
            var response = client.UpdateImageStorageClass(new UpdateImageStorageClassRequest
            {
                ImageId = new ImageIdentifier { ImageDigest = "sha256:0b1a4e0c81c434fa7928e5c4a2651a521ebabc4ff200c65f7e25b99373efca3b" },
                RegistryId = "724772093679",
                RepositoryName = "hello-repository",
                TargetStorageClass = "ARCHIVE"
            });

            ImageIdentifier imageId = response.ImageId;
            ImageStatus imageStatus = response.ImageStatus;
            string registryId = response.RegistryId;
            string repositoryName = response.RepositoryName;

            #endregion
        }

        public void ECRUpdateImageStorageClass()
        {
            #region UpdateImageStorageClass-2

            var client = new AmazonECRClient();
            var response = client.UpdateImageStorageClass(new UpdateImageStorageClassRequest
            {
                ImageId = new ImageIdentifier { ImageDigest = "sha256:0b1a4e0c81c434fa7928e5c4a2651a521ebabc4ff200c65f7e25b99373efca3b" },
                RegistryId = "724772093679",
                RepositoryName = "hello-repository",
                TargetStorageClass = "STANDARD"
            });

            ImageIdentifier imageId = response.ImageId;
            ImageStatus imageStatus = response.ImageStatus;
            string registryId = response.RegistryId;
            string repositoryName = response.RepositoryName;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
