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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ECR.Model;

namespace Amazon.ECR
{
    /// <summary>
    /// Interface for accessing ECR
    ///
    /// Amazon Elastic Container Registry (Amazon ECR) is a managed Docker registry service.
    /// Customers can use the familiar Docker CLI to push, pull, and manage images. Amazon
    /// ECR provides a secure, scalable, and reliable registry. Amazon ECR supports private
    /// Docker repositories with resource-based permissions using IAM so that specific users
    /// or Amazon EC2 instances can access repositories and images. Developers can use the
    /// Docker CLI to author and manage images.
    /// </summary>
    public partial interface IAmazonECR : IAmazonService, IDisposable
    {
                
        #region  BatchCheckLayerAvailability


        /// <summary>
        /// Initiates the asynchronous execution of the BatchCheckLayerAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCheckLayerAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/BatchCheckLayerAvailability">REST API Reference for BatchCheckLayerAvailability Operation</seealso>
        Task<BatchCheckLayerAvailabilityResponse> BatchCheckLayerAvailabilityAsync(BatchCheckLayerAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteImage


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/BatchDeleteImage">REST API Reference for BatchDeleteImage Operation</seealso>
        Task<BatchDeleteImageResponse> BatchDeleteImageAsync(BatchDeleteImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetImage


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/BatchGetImage">REST API Reference for BatchGetImage Operation</seealso>
        Task<BatchGetImageResponse> BatchGetImageAsync(BatchGetImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CompleteLayerUpload


        /// <summary>
        /// Initiates the asynchronous execution of the CompleteLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteLayerUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/CompleteLayerUpload">REST API Reference for CompleteLayerUpload Operation</seealso>
        Task<CompleteLayerUploadResponse> CompleteLayerUploadAsync(CompleteLayerUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRepository


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLifecyclePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRepository


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRepositoryPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DeleteRepositoryPolicy">REST API Reference for DeleteRepositoryPolicy Operation</seealso>
        Task<DeleteRepositoryPolicyResponse> DeleteRepositoryPolicyAsync(DeleteRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImages


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRepositories


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DescribeRepositories">REST API Reference for DescribeRepositories Operation</seealso>
        Task<DescribeRepositoriesResponse> DescribeRepositoriesAsync(DescribeRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAuthorizationToken


        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizationToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetAuthorizationToken">REST API Reference for GetAuthorizationToken Operation</seealso>
        Task<GetAuthorizationTokenResponse> GetAuthorizationTokenAsync(GetAuthorizationTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDownloadUrlForLayer


        /// <summary>
        /// Initiates the asynchronous execution of the GetDownloadUrlForLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDownloadUrlForLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetDownloadUrlForLayer">REST API Reference for GetDownloadUrlForLayer Operation</seealso>
        Task<GetDownloadUrlForLayerResponse> GetDownloadUrlForLayerAsync(GetDownloadUrlForLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLifecyclePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        Task<GetLifecyclePolicyResponse> GetLifecyclePolicyAsync(GetLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLifecyclePolicyPreview


        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecyclePolicyPreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicyPreview operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetLifecyclePolicyPreview">REST API Reference for GetLifecyclePolicyPreview Operation</seealso>
        Task<GetLifecyclePolicyPreviewResponse> GetLifecyclePolicyPreviewAsync(GetLifecyclePolicyPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRepositoryPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetRepositoryPolicy">REST API Reference for GetRepositoryPolicy Operation</seealso>
        Task<GetRepositoryPolicyResponse> GetRepositoryPolicyAsync(GetRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InitiateLayerUpload


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateLayerUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/InitiateLayerUpload">REST API Reference for InitiateLayerUpload Operation</seealso>
        Task<InitiateLayerUploadResponse> InitiateLayerUploadAsync(InitiateLayerUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListImages


        /// <summary>
        /// Initiates the asynchronous execution of the ListImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/ListImages">REST API Reference for ListImages Operation</seealso>
        Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutImage


        /// <summary>
        /// Initiates the asynchronous execution of the PutImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/PutImage">REST API Reference for PutImage Operation</seealso>
        Task<PutImageResponse> PutImageAsync(PutImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutLifecyclePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecyclePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/PutLifecyclePolicy">REST API Reference for PutLifecyclePolicy Operation</seealso>
        Task<PutLifecyclePolicyResponse> PutLifecyclePolicyAsync(PutLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetRepositoryPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the SetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRepositoryPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/SetRepositoryPolicy">REST API Reference for SetRepositoryPolicy Operation</seealso>
        Task<SetRepositoryPolicyResponse> SetRepositoryPolicyAsync(SetRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartLifecyclePolicyPreview


        /// <summary>
        /// Initiates the asynchronous execution of the StartLifecyclePolicyPreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLifecyclePolicyPreview operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/StartLifecyclePolicyPreview">REST API Reference for StartLifecyclePolicyPreview Operation</seealso>
        Task<StartLifecyclePolicyPreviewResponse> StartLifecyclePolicyPreviewAsync(StartLifecyclePolicyPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UploadLayerPart


        /// <summary>
        /// Initiates the asynchronous execution of the UploadLayerPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadLayerPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/UploadLayerPart">REST API Reference for UploadLayerPart Operation</seealso>
        Task<UploadLayerPartResponse> UploadLayerPartAsync(UploadLayerPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}