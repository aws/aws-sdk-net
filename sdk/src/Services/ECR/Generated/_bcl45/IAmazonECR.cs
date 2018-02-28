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
        /// Check the availability of multiple image layers in a specified registry and repository.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers for pulling and pushing images. In most cases, you should use the
        /// <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCheckLayerAvailability service method.</param>
        /// 
        /// <returns>The response from the BatchCheckLayerAvailability service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/BatchCheckLayerAvailability">REST API Reference for BatchCheckLayerAvailability Operation</seealso>
        BatchCheckLayerAvailabilityResponse BatchCheckLayerAvailability(BatchCheckLayerAvailabilityRequest request);


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
        Task<BatchCheckLayerAvailabilityResponse> BatchCheckLayerAvailabilityAsync(BatchCheckLayerAvailabilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteImage


        /// <summary>
        /// Deletes a list of specified images within a specified repository. Images are specified
        /// with either <code>imageTag</code> or <code>imageDigest</code>.
        /// 
        ///  
        /// <para>
        /// You can remove a tag from an image by specifying the image's tag in your request.
        /// When you remove the last tag from an image, the image is deleted from your repository.
        /// </para>
        ///  
        /// <para>
        /// You can completely delete an image (and all of its tags) by specifying the image's
        /// digest in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteImage service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteImage service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/BatchDeleteImage">REST API Reference for BatchDeleteImage Operation</seealso>
        BatchDeleteImageResponse BatchDeleteImage(BatchDeleteImageRequest request);


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
        Task<BatchDeleteImageResponse> BatchDeleteImageAsync(BatchDeleteImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetImage


        /// <summary>
        /// Gets detailed information for specified images within a specified repository. Images
        /// are specified with either <code>imageTag</code> or <code>imageDigest</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetImage service method.</param>
        /// 
        /// <returns>The response from the BatchGetImage service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/BatchGetImage">REST API Reference for BatchGetImage Operation</seealso>
        BatchGetImageResponse BatchGetImage(BatchGetImageRequest request);


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
        Task<BatchGetImageResponse> BatchGetImageAsync(BatchGetImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CompleteLayerUpload


        /// <summary>
        /// Informs Amazon ECR that the image layer upload has completed for a specified registry,
        /// repository name, and upload ID. You can optionally provide a <code>sha256</code> digest
        /// of the image layer for data validation purposes.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers for pulling and pushing images. In most cases, you should use the
        /// <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLayerUpload service method.</param>
        /// 
        /// <returns>The response from the CompleteLayerUpload service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.EmptyUploadException">
        /// The specified layer upload does not contain any layer parts.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidLayerException">
        /// The layer digest calculation performed by Amazon ECR upon receipt of the image layer
        /// does not match the digest specified.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LayerAlreadyExistsException">
        /// The image layer already exists in the associated repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LayerPartTooSmallException">
        /// Layer parts must be at least 5 MiB in size.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.UploadNotFoundException">
        /// The upload could not be found, or the specified upload id is not valid for this repository.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/CompleteLayerUpload">REST API Reference for CompleteLayerUpload Operation</seealso>
        CompleteLayerUploadResponse CompleteLayerUpload(CompleteLayerUploadRequest request);


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
        Task<CompleteLayerUploadResponse> CompleteLayerUploadAsync(CompleteLayerUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRepository


        /// <summary>
        /// Creates an image repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LimitExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="http://docs.aws.amazon.com/AmazonECR/latest/userguide/service_limits.html">Amazon
        /// ECR Default Service Limits</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryAlreadyExistsException">
        /// The specified repository already exists in the specified registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request);


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
        Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLifecyclePolicy


        /// <summary>
        /// Deletes the specified lifecycle policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecyclePolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LifecyclePolicyNotFoundException">
        /// The lifecycle policy could not be found, and no policy is set to the repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        DeleteLifecyclePolicyResponse DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request);


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
        Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRepository


        /// <summary>
        /// Deletes an existing image repository. If a repository contains images, you must use
        /// the <code>force</code> option to delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotEmptyException">
        /// The specified repository contains images. To delete a repository that contains images,
        /// you must force the deletion with the <code>force</code> parameter.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request);


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
        Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRepositoryPolicy


        /// <summary>
        /// Deletes the repository policy from a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRepositoryPolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryPolicyNotFoundException">
        /// The specified repository and registry combination does not have an associated repository
        /// policy.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DeleteRepositoryPolicy">REST API Reference for DeleteRepositoryPolicy Operation</seealso>
        DeleteRepositoryPolicyResponse DeleteRepositoryPolicy(DeleteRepositoryPolicyRequest request);


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
        Task<DeleteRepositoryPolicyResponse> DeleteRepositoryPolicyAsync(DeleteRepositoryPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeImages


        /// <summary>
        /// Returns metadata about the images in a repository, including image size, image tags,
        /// and creation date.
        /// 
        ///  <note> 
        /// <para>
        /// Beginning with Docker version 1.9, the Docker client compresses image layers before
        /// pushing them to a V2 Docker registry. The output of the <code>docker images</code>
        /// command shows the uncompressed image size, so it may return a larger image size than
        /// the image sizes returned by <a>DescribeImages</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.ImageNotFoundException">
        /// The image requested does not exist in the specified repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        DescribeImagesResponse DescribeImages(DescribeImagesRequest request);


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
        Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRepositories


        /// <summary>
        /// Describes image repositories in a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositories service method.</param>
        /// 
        /// <returns>The response from the DescribeRepositories service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DescribeRepositories">REST API Reference for DescribeRepositories Operation</seealso>
        DescribeRepositoriesResponse DescribeRepositories(DescribeRepositoriesRequest request);


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
        Task<DescribeRepositoriesResponse> DescribeRepositoriesAsync(DescribeRepositoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAuthorizationToken


        /// <summary>
        /// Retrieves a token that is valid for a specified registry for 12 hours. This command
        /// allows you to use the <code>docker</code> CLI to push and pull images with Amazon
        /// ECR. If you do not specify a registry, the default registry is assumed.
        /// 
        ///  
        /// <para>
        /// The <code>authorizationToken</code> returned for each registry specified is a base64
        /// encoded string that can be decoded and used in a <code>docker login</code> command
        /// to authenticate to a registry. The AWS CLI offers an <code>aws ecr get-login</code>
        /// command that simplifies the login process.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizationToken service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetAuthorizationToken">REST API Reference for GetAuthorizationToken Operation</seealso>
        GetAuthorizationTokenResponse GetAuthorizationToken(GetAuthorizationTokenRequest request);


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
        Task<GetAuthorizationTokenResponse> GetAuthorizationTokenAsync(GetAuthorizationTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDownloadUrlForLayer


        /// <summary>
        /// Retrieves the pre-signed Amazon S3 download URL corresponding to an image layer. You
        /// can only get URLs for image layers that are referenced in an image.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers for pulling and pushing images. In most cases, you should use the
        /// <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDownloadUrlForLayer service method.</param>
        /// 
        /// <returns>The response from the GetDownloadUrlForLayer service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LayerInaccessibleException">
        /// The specified layer is not available because it is not associated with an image. Unassociated
        /// image layers may be cleaned up at any time.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LayersNotFoundException">
        /// The specified layers could not be found, or the specified layer is not valid for this
        /// repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetDownloadUrlForLayer">REST API Reference for GetDownloadUrlForLayer Operation</seealso>
        GetDownloadUrlForLayerResponse GetDownloadUrlForLayer(GetDownloadUrlForLayerRequest request);


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
        Task<GetDownloadUrlForLayerResponse> GetDownloadUrlForLayerAsync(GetDownloadUrlForLayerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLifecyclePolicy


        /// <summary>
        /// Retrieves the specified lifecycle policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy service method.</param>
        /// 
        /// <returns>The response from the GetLifecyclePolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LifecyclePolicyNotFoundException">
        /// The lifecycle policy could not be found, and no policy is set to the repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        GetLifecyclePolicyResponse GetLifecyclePolicy(GetLifecyclePolicyRequest request);


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
        Task<GetLifecyclePolicyResponse> GetLifecyclePolicyAsync(GetLifecyclePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLifecyclePolicyPreview


        /// <summary>
        /// Retrieves the results of the specified lifecycle policy preview request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicyPreview service method.</param>
        /// 
        /// <returns>The response from the GetLifecyclePolicyPreview service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LifecyclePolicyPreviewNotFoundException">
        /// There is no dry run for this repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetLifecyclePolicyPreview">REST API Reference for GetLifecyclePolicyPreview Operation</seealso>
        GetLifecyclePolicyPreviewResponse GetLifecyclePolicyPreview(GetLifecyclePolicyPreviewRequest request);


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
        Task<GetLifecyclePolicyPreviewResponse> GetLifecyclePolicyPreviewAsync(GetLifecyclePolicyPreviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRepositoryPolicy


        /// <summary>
        /// Retrieves the repository policy for a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the GetRepositoryPolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryPolicyNotFoundException">
        /// The specified repository and registry combination does not have an associated repository
        /// policy.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetRepositoryPolicy">REST API Reference for GetRepositoryPolicy Operation</seealso>
        GetRepositoryPolicyResponse GetRepositoryPolicy(GetRepositoryPolicyRequest request);


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
        Task<GetRepositoryPolicyResponse> GetRepositoryPolicyAsync(GetRepositoryPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InitiateLayerUpload


        /// <summary>
        /// Notify Amazon ECR that you intend to upload an image layer.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers for pulling and pushing images. In most cases, you should use the
        /// <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateLayerUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateLayerUpload service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/InitiateLayerUpload">REST API Reference for InitiateLayerUpload Operation</seealso>
        InitiateLayerUploadResponse InitiateLayerUpload(InitiateLayerUploadRequest request);


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
        Task<InitiateLayerUploadResponse> InitiateLayerUploadAsync(InitiateLayerUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListImages


        /// <summary>
        /// Lists all the image IDs for a given repository.
        /// 
        ///  
        /// <para>
        /// You can filter images based on whether or not they are tagged by setting the <code>tagStatus</code>
        /// parameter to <code>TAGGED</code> or <code>UNTAGGED</code>. For example, you can filter
        /// your results to return only <code>UNTAGGED</code> images and then pipe that result
        /// to a <a>BatchDeleteImage</a> operation to delete them. Or, you can filter your results
        /// to return only <code>TAGGED</code> images to list all of the tags in your repository.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImages service method.</param>
        /// 
        /// <returns>The response from the ListImages service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/ListImages">REST API Reference for ListImages Operation</seealso>
        ListImagesResponse ListImages(ListImagesRequest request);


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
        Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutImage


        /// <summary>
        /// Creates or updates the image manifest and tags associated with an image.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers for pulling and pushing images. In most cases, you should use the
        /// <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImage service method.</param>
        /// 
        /// <returns>The response from the PutImage service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.ImageAlreadyExistsException">
        /// The specified image has already been pushed, and there were no changes to the manifest
        /// or image tag after the last push.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LayersNotFoundException">
        /// The specified layers could not be found, or the specified layer is not valid for this
        /// repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LimitExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="http://docs.aws.amazon.com/AmazonECR/latest/userguide/service_limits.html">Amazon
        /// ECR Default Service Limits</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/PutImage">REST API Reference for PutImage Operation</seealso>
        PutImageResponse PutImage(PutImageRequest request);


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
        Task<PutImageResponse> PutImageAsync(PutImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLifecyclePolicy


        /// <summary>
        /// Creates or updates a lifecycle policy. For information about lifecycle policy syntax,
        /// see <a href="http://docs.aws.amazon.com/AmazonECR/latest/userguide/LifecyclePolicies.html">Lifecycle
        /// Policy Template</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecyclePolicy service method.</param>
        /// 
        /// <returns>The response from the PutLifecyclePolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/PutLifecyclePolicy">REST API Reference for PutLifecyclePolicy Operation</seealso>
        PutLifecyclePolicyResponse PutLifecyclePolicy(PutLifecyclePolicyRequest request);


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
        Task<PutLifecyclePolicyResponse> PutLifecyclePolicyAsync(PutLifecyclePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetRepositoryPolicy


        /// <summary>
        /// Applies a repository policy on a specified repository to control access permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the SetRepositoryPolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/SetRepositoryPolicy">REST API Reference for SetRepositoryPolicy Operation</seealso>
        SetRepositoryPolicyResponse SetRepositoryPolicy(SetRepositoryPolicyRequest request);


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
        Task<SetRepositoryPolicyResponse> SetRepositoryPolicyAsync(SetRepositoryPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartLifecyclePolicyPreview


        /// <summary>
        /// Starts a preview of the specified lifecycle policy. This allows you to see the results
        /// before creating the lifecycle policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLifecyclePolicyPreview service method.</param>
        /// 
        /// <returns>The response from the StartLifecyclePolicyPreview service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LifecyclePolicyNotFoundException">
        /// The lifecycle policy could not be found, and no policy is set to the repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LifecyclePolicyPreviewInProgressException">
        /// The previous lifecycle policy preview request has not completed. Please try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/StartLifecyclePolicyPreview">REST API Reference for StartLifecyclePolicyPreview Operation</seealso>
        StartLifecyclePolicyPreviewResponse StartLifecyclePolicyPreview(StartLifecyclePolicyPreviewRequest request);


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
        Task<StartLifecyclePolicyPreviewResponse> StartLifecyclePolicyPreviewAsync(StartLifecyclePolicyPreviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UploadLayerPart


        /// <summary>
        /// Uploads an image layer part to Amazon ECR.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers for pulling and pushing images. In most cases, you should use the
        /// <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadLayerPart service method.</param>
        /// 
        /// <returns>The response from the UploadLayerPart service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidLayerPartException">
        /// The layer part size is not valid, or the first byte specified is not consecutive to
        /// the last byte of a previous layer part upload.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LimitExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="http://docs.aws.amazon.com/AmazonECR/latest/userguide/service_limits.html">Amazon
        /// ECR Default Service Limits</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.UploadNotFoundException">
        /// The upload could not be found, or the specified upload id is not valid for this repository.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/UploadLayerPart">REST API Reference for UploadLayerPart Operation</seealso>
        UploadLayerPartResponse UploadLayerPart(UploadLayerPartRequest request);


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
        Task<UploadLayerPartResponse> UploadLayerPartAsync(UploadLayerPartRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}