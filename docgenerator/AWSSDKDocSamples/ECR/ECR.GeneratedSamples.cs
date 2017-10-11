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
        static IAmazonECR client = new AmazonECRClient();
        public void ECRBatchDeleteImage()
        {
            #region batchdeleteimages-example-1470860541707

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

            var response = client.CreateRepository(new CreateRepositoryRequest 
            {
                RepositoryName = "project-a/nginx-web-app"
            });

            Repository repository = response.Repository;

            #endregion
        }

        public void ECRDeleteRepository()
        {
            #region deleterepository-example-1470863805703

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
            #region deleterepositorypolicy-example-1470866943748

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

            var response = client.DescribeRepositories(new DescribeRepositoriesRequest 
            {
            });

            List<Repository> repositories = response.Repositories;

            #endregion
        }

        public void ECRGetAuthorizationToken()
        {
            #region getauthorizationtoken-example-1470867047084

            var response = client.GetAuthorizationToken(new GetAuthorizationTokenRequest 
            {
            });

            List<AuthorizationData> authorizationData = response.AuthorizationData;

            #endregion
        }

        public void ECRGetRepositoryPolicy()
        {
            #region getrepositorypolicy-example-1470867669211

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

            var response = client.ListImages(new ListImagesRequest 
            {
                RepositoryName = "ubuntu"
            });

            List<ImageIdentifier> imageIds = response.ImageIds;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}