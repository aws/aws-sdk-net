/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ECR.Model;
using Amazon.ECR.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ECR
{
    /// <summary>
    /// Implementation for accessing ECR
    ///
    /// Amazon EC2 Container Registry (Amazon ECR) is a managed AWS Docker registry service.
    /// Customers can use the familiar Docker CLI to push, pull, and manage images. Amazon
    /// ECR provides a secure, scalable, and reliable registry. Amazon ECR supports private
    /// Docker repositories with resource-based permissions using AWS IAM so that specific
    /// users or Amazon EC2 instances can access repositories and images. Developers can use
    /// the Docker CLI to author and manage images.
    /// </summary>
    public partial class AmazonECRClient : AmazonServiceClient, IAmazonECR
    {
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonECRClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonECRClient(AWSCredentials credentials)
            : this(credentials, new AmazonECRConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonECRClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonECRClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonECRConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonECRClient with AWS Credentials and an
        /// AmazonECRClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonECRClient Configuration Object</param>
        public AmazonECRClient(AWSCredentials credentials, AmazonECRConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonECRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonECRClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonECRConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonECRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonECRClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonECRConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonECRClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonECRClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonECRClient Configuration Object</param>
        public AmazonECRClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonECRConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonECRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonECRClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonECRConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonECRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonECRClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonECRConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonECRClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonECRClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonECRClient Configuration Object</param>
        public AmazonECRClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonECRConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  BatchCheckLayerAvailability

        internal BatchCheckLayerAvailabilityResponse BatchCheckLayerAvailability(BatchCheckLayerAvailabilityRequest request)
        {
            var marshaller = new BatchCheckLayerAvailabilityRequestMarshaller();
            var unmarshaller = BatchCheckLayerAvailabilityResponseUnmarshaller.Instance;

            return Invoke<BatchCheckLayerAvailabilityRequest,BatchCheckLayerAvailabilityResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchCheckLayerAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCheckLayerAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<BatchCheckLayerAvailabilityResponse> BatchCheckLayerAvailabilityAsync(BatchCheckLayerAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchCheckLayerAvailabilityRequestMarshaller();
            var unmarshaller = BatchCheckLayerAvailabilityResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCheckLayerAvailabilityRequest,BatchCheckLayerAvailabilityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteImage

        internal BatchDeleteImageResponse BatchDeleteImage(BatchDeleteImageRequest request)
        {
            var marshaller = new BatchDeleteImageRequestMarshaller();
            var unmarshaller = BatchDeleteImageResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteImageRequest,BatchDeleteImageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<BatchDeleteImageResponse> BatchDeleteImageAsync(BatchDeleteImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchDeleteImageRequestMarshaller();
            var unmarshaller = BatchDeleteImageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteImageRequest,BatchDeleteImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetImage

        internal BatchGetImageResponse BatchGetImage(BatchGetImageRequest request)
        {
            var marshaller = new BatchGetImageRequestMarshaller();
            var unmarshaller = BatchGetImageResponseUnmarshaller.Instance;

            return Invoke<BatchGetImageRequest,BatchGetImageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<BatchGetImageResponse> BatchGetImageAsync(BatchGetImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchGetImageRequestMarshaller();
            var unmarshaller = BatchGetImageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetImageRequest,BatchGetImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CompleteLayerUpload

        internal CompleteLayerUploadResponse CompleteLayerUpload(CompleteLayerUploadRequest request)
        {
            var marshaller = new CompleteLayerUploadRequestMarshaller();
            var unmarshaller = CompleteLayerUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteLayerUploadRequest,CompleteLayerUploadResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CompleteLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteLayerUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CompleteLayerUploadResponse> CompleteLayerUploadAsync(CompleteLayerUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CompleteLayerUploadRequestMarshaller();
            var unmarshaller = CompleteLayerUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteLayerUploadRequest,CompleteLayerUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRepository

        internal CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            var marshaller = new CreateRepositoryRequestMarshaller();
            var unmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateRepositoryRequest,CreateRepositoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRepositoryRequestMarshaller();
            var unmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRepositoryRequest,CreateRepositoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRepository

        internal DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request)
        {
            var marshaller = new DeleteRepositoryRequestMarshaller();
            var unmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryRequest,DeleteRepositoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRepositoryRequestMarshaller();
            var unmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRepositoryRequest,DeleteRepositoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRepositoryPolicy

        internal DeleteRepositoryPolicyResponse DeleteRepositoryPolicy(DeleteRepositoryPolicyRequest request)
        {
            var marshaller = new DeleteRepositoryPolicyRequestMarshaller();
            var unmarshaller = DeleteRepositoryPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryPolicyRequest,DeleteRepositoryPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteRepositoryPolicyResponse> DeleteRepositoryPolicyAsync(DeleteRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRepositoryPolicyRequestMarshaller();
            var unmarshaller = DeleteRepositoryPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRepositoryPolicyRequest,DeleteRepositoryPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRepositories

        internal DescribeRepositoriesResponse DescribeRepositories(DescribeRepositoriesRequest request)
        {
            var marshaller = new DescribeRepositoriesRequestMarshaller();
            var unmarshaller = DescribeRepositoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeRepositoriesRequest,DescribeRepositoriesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeRepositoriesResponse> DescribeRepositoriesAsync(DescribeRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRepositoriesRequestMarshaller();
            var unmarshaller = DescribeRepositoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRepositoriesRequest,DescribeRepositoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAuthorizationToken

        internal GetAuthorizationTokenResponse GetAuthorizationToken(GetAuthorizationTokenRequest request)
        {
            var marshaller = new GetAuthorizationTokenRequestMarshaller();
            var unmarshaller = GetAuthorizationTokenResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizationTokenRequest,GetAuthorizationTokenResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizationToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetAuthorizationTokenResponse> GetAuthorizationTokenAsync(GetAuthorizationTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAuthorizationTokenRequestMarshaller();
            var unmarshaller = GetAuthorizationTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetAuthorizationTokenRequest,GetAuthorizationTokenResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDownloadUrlForLayer

        internal GetDownloadUrlForLayerResponse GetDownloadUrlForLayer(GetDownloadUrlForLayerRequest request)
        {
            var marshaller = new GetDownloadUrlForLayerRequestMarshaller();
            var unmarshaller = GetDownloadUrlForLayerResponseUnmarshaller.Instance;

            return Invoke<GetDownloadUrlForLayerRequest,GetDownloadUrlForLayerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDownloadUrlForLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDownloadUrlForLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDownloadUrlForLayerResponse> GetDownloadUrlForLayerAsync(GetDownloadUrlForLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDownloadUrlForLayerRequestMarshaller();
            var unmarshaller = GetDownloadUrlForLayerResponseUnmarshaller.Instance;

            return InvokeAsync<GetDownloadUrlForLayerRequest,GetDownloadUrlForLayerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRepositoryPolicy

        internal GetRepositoryPolicyResponse GetRepositoryPolicy(GetRepositoryPolicyRequest request)
        {
            var marshaller = new GetRepositoryPolicyRequestMarshaller();
            var unmarshaller = GetRepositoryPolicyResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryPolicyRequest,GetRepositoryPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetRepositoryPolicyResponse> GetRepositoryPolicyAsync(GetRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetRepositoryPolicyRequestMarshaller();
            var unmarshaller = GetRepositoryPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetRepositoryPolicyRequest,GetRepositoryPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InitiateLayerUpload

        internal InitiateLayerUploadResponse InitiateLayerUpload(InitiateLayerUploadRequest request)
        {
            var marshaller = new InitiateLayerUploadRequestMarshaller();
            var unmarshaller = InitiateLayerUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateLayerUploadRequest,InitiateLayerUploadResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateLayerUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<InitiateLayerUploadResponse> InitiateLayerUploadAsync(InitiateLayerUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new InitiateLayerUploadRequestMarshaller();
            var unmarshaller = InitiateLayerUploadResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateLayerUploadRequest,InitiateLayerUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListImages

        internal ListImagesResponse ListImages(ListImagesRequest request)
        {
            var marshaller = new ListImagesRequestMarshaller();
            var unmarshaller = ListImagesResponseUnmarshaller.Instance;

            return Invoke<ListImagesRequest,ListImagesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListImagesRequestMarshaller();
            var unmarshaller = ListImagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListImagesRequest,ListImagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutImage

        internal PutImageResponse PutImage(PutImageRequest request)
        {
            var marshaller = new PutImageRequestMarshaller();
            var unmarshaller = PutImageResponseUnmarshaller.Instance;

            return Invoke<PutImageRequest,PutImageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutImageResponse> PutImageAsync(PutImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutImageRequestMarshaller();
            var unmarshaller = PutImageResponseUnmarshaller.Instance;

            return InvokeAsync<PutImageRequest,PutImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetRepositoryPolicy

        internal SetRepositoryPolicyResponse SetRepositoryPolicy(SetRepositoryPolicyRequest request)
        {
            var marshaller = new SetRepositoryPolicyRequestMarshaller();
            var unmarshaller = SetRepositoryPolicyResponseUnmarshaller.Instance;

            return Invoke<SetRepositoryPolicyRequest,SetRepositoryPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRepositoryPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetRepositoryPolicyResponse> SetRepositoryPolicyAsync(SetRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetRepositoryPolicyRequestMarshaller();
            var unmarshaller = SetRepositoryPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SetRepositoryPolicyRequest,SetRepositoryPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadLayerPart

        internal UploadLayerPartResponse UploadLayerPart(UploadLayerPartRequest request)
        {
            var marshaller = new UploadLayerPartRequestMarshaller();
            var unmarshaller = UploadLayerPartResponseUnmarshaller.Instance;

            return Invoke<UploadLayerPartRequest,UploadLayerPartResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UploadLayerPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadLayerPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UploadLayerPartResponse> UploadLayerPartAsync(UploadLayerPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadLayerPartRequestMarshaller();
            var unmarshaller = UploadLayerPartResponseUnmarshaller.Instance;

            return InvokeAsync<UploadLayerPartRequest,UploadLayerPartResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}