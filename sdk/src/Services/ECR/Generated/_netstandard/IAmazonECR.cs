/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Amazon Elastic Container Registry 
    /// <para>
    /// Amazon Elastic Container Registry (Amazon ECR) is a managed container image registry
    /// service. Customers can use the familiar Docker CLI, or their preferred client, to
    /// push, pull, and manage images. Amazon ECR provides a secure, scalable, and reliable
    /// registry for your Docker or Open Container Initiative (OCI) images. Amazon ECR supports
    /// private repositories with resource-based permissions using IAM so that specific users
    /// or Amazon EC2 instances can access repositories and images.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonECR : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IECRPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchCheckLayerAvailability



        /// <summary>
        /// Checks the availability of one or more image layers in a repository.
        /// 
        ///  
        /// <para>
        /// When an image is pushed to a repository, each image layer is checked to verify if
        /// it has been uploaded before. If it has been uploaded, then the image layer is skipped.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCheckLayerAvailability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchCheckLayerAvailabilityResponse> BatchCheckLayerAvailabilityAsync(BatchCheckLayerAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteImage



        /// <summary>
        /// Deletes a list of specified images within a repository. Images are specified with
        /// either an <code>imageTag</code> or <code>imageDigest</code>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchDeleteImageResponse> BatchDeleteImageAsync(BatchDeleteImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetImage



        /// <summary>
        /// Gets detailed information for an image. Images are specified with either an <code>imageTag</code>
        /// or <code>imageDigest</code>.
        /// 
        ///  
        /// <para>
        /// When an image is pulled, the BatchGetImage API is called once to retrieve the image
        /// manifest.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchGetImageResponse> BatchGetImageAsync(BatchGetImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CompleteLayerUpload



        /// <summary>
        /// Informs Amazon ECR that the image layer upload has completed for a specified registry,
        /// repository name, and upload ID. You can optionally provide a <code>sha256</code> digest
        /// of the image layer for data validation purposes.
        /// 
        ///  
        /// <para>
        /// When an image is pushed, the CompleteLayerUpload API is called once per each new image
        /// layer to verify that the upload has completed.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLayerUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.ECR.Model.KmsException">
        /// The operation failed due to a KMS exception.
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
        /// The upload could not be found, or the specified upload ID is not valid for this repository.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/CompleteLayerUpload">REST API Reference for CompleteLayerUpload Operation</seealso>
        Task<CompleteLayerUploadResponse> CompleteLayerUploadAsync(CompleteLayerUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRepository



        /// <summary>
        /// Creates a repository. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/Repositories.html">Amazon
        /// ECR Repositories</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.KmsException">
        /// The operation failed due to a KMS exception.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LimitExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryAlreadyExistsException">
        /// The specified repository already exists in the specified registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLifecyclePolicy



        /// <summary>
        /// Deletes the lifecycle policy associated with the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRegistryPolicy



        /// <summary>
        /// Deletes the registry permissions policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistryPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistryPolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RegistryPolicyNotFoundException">
        /// The registry doesn't have an associated registry policy.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DeleteRegistryPolicy">REST API Reference for DeleteRegistryPolicy Operation</seealso>
        Task<DeleteRegistryPolicyResponse> DeleteRegistryPolicyAsync(DeleteRegistryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRepository



        /// <summary>
        /// Deletes a repository. If the repository contains images, you must either delete all
        /// images in the repository or use the <code>force</code> option to delete the repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.KmsException">
        /// The operation failed due to a KMS exception.
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
        Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRepositoryPolicy



        /// <summary>
        /// Deletes the repository policy associated with the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteRepositoryPolicyResponse> DeleteRepositoryPolicyAsync(DeleteRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImages



        /// <summary>
        /// Returns metadata about the images in a repository.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImageScanFindings



        /// <summary>
        /// Returns the scan findings for the specified image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageScanFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImageScanFindings service method, as returned by ECR.</returns>
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
        /// <exception cref="Amazon.ECR.Model.ScanNotFoundException">
        /// The specified image scan could not be found. Ensure that image scanning is enabled
        /// on the repository and try again.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DescribeImageScanFindings">REST API Reference for DescribeImageScanFindings Operation</seealso>
        Task<DescribeImageScanFindingsResponse> DescribeImageScanFindingsAsync(DescribeImageScanFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRegistry



        /// <summary>
        /// Describes the settings for a registry. The replication configuration for a repository
        /// can be created or updated with the <a>PutReplicationConfiguration</a> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistry service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ValidationException">
        /// There was an exception validating this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/DescribeRegistry">REST API Reference for DescribeRegistry Operation</seealso>
        Task<DescribeRegistryResponse> DescribeRegistryAsync(DescribeRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRepositories



        /// <summary>
        /// Describes image repositories in a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeRepositoriesResponse> DescribeRepositoriesAsync(DescribeRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAuthorizationToken



        /// <summary>
        /// Retrieves an authorization token. An authorization token represents your IAM authentication
        /// credentials and can be used to access any Amazon ECR registry that your IAM principal
        /// has access to. The authorization token is valid for 12 hours.
        /// 
        ///  
        /// <para>
        /// The <code>authorizationToken</code> returned is a base64 encoded string that can be
        /// decoded and used in a <code>docker login</code> command to authenticate to a registry.
        /// The AWS CLI offers an <code>get-login-password</code> command that simplifies the
        /// login process. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/Registries.html#registry_auth">Registry
        /// Authentication</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAuthorizationToken service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetAuthorizationToken">REST API Reference for GetAuthorizationToken Operation</seealso>
        Task<GetAuthorizationTokenResponse> GetAuthorizationTokenAsync(GetAuthorizationTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDownloadUrlForLayer



        /// <summary>
        /// Retrieves the pre-signed Amazon S3 download URL corresponding to an image layer. You
        /// can only get URLs for image layers that are referenced in an image.
        /// 
        ///  
        /// <para>
        /// When an image is pulled, the GetDownloadUrlForLayer API is called once per image layer
        /// that is not already cached.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDownloadUrlForLayer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDownloadUrlForLayerResponse> GetDownloadUrlForLayerAsync(GetDownloadUrlForLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLifecyclePolicy



        /// <summary>
        /// Retrieves the lifecycle policy for the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetLifecyclePolicyResponse> GetLifecyclePolicyAsync(GetLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLifecyclePolicyPreview



        /// <summary>
        /// Retrieves the results of the lifecycle policy preview request for the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicyPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetLifecyclePolicyPreviewResponse> GetLifecyclePolicyPreviewAsync(GetLifecyclePolicyPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRegistryPolicy



        /// <summary>
        /// Retrieves the permissions policy for a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistryPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegistryPolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RegistryPolicyNotFoundException">
        /// The registry doesn't have an associated registry policy.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/GetRegistryPolicy">REST API Reference for GetRegistryPolicy Operation</seealso>
        Task<GetRegistryPolicyResponse> GetRegistryPolicyAsync(GetRegistryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRepositoryPolicy



        /// <summary>
        /// Retrieves the repository policy for the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRepositoryPolicyResponse> GetRepositoryPolicyAsync(GetRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InitiateLayerUpload



        /// <summary>
        /// Notifies Amazon ECR that you intend to upload an image layer.
        /// 
        ///  
        /// <para>
        /// When an image is pushed, the InitiateLayerUpload API is called once per image layer
        /// that has not already been uploaded. Whether or not an image layer has been uploaded
        /// is determined by the BatchCheckLayerAvailability API action.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateLayerUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateLayerUpload service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.KmsException">
        /// The operation failed due to a KMS exception.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/InitiateLayerUpload">REST API Reference for InitiateLayerUpload Operation</seealso>
        Task<InitiateLayerUploadResponse> InitiateLayerUploadAsync(InitiateLayerUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListImages



        /// <summary>
        /// Lists all the image IDs for the specified repository.
        /// 
        ///  
        /// <para>
        /// You can filter images based on whether or not they are tagged by using the <code>tagStatus</code>
        /// filter and specifying either <code>TAGGED</code>, <code>UNTAGGED</code> or <code>ANY</code>.
        /// For example, you can filter your results to return only <code>UNTAGGED</code> images
        /// and then pipe that result to a <a>BatchDeleteImage</a> operation to delete them. Or,
        /// you can filter your results to return only <code>TAGGED</code> images to list all
        /// of the tags in your repository.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// List the tags for an Amazon ECR resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ECR.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutImage



        /// <summary>
        /// Creates or updates the image manifest and tags associated with an image.
        /// 
        ///  
        /// <para>
        /// When an image is pushed and all new image layers have been uploaded, the PutImage
        /// API is called once to create or update the image manifest and the tags associated
        /// with the image.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutImage service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.ImageAlreadyExistsException">
        /// The specified image has already been pushed, and there were no changes to the manifest
        /// or image tag after the last push.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ImageDigestDoesNotMatchException">
        /// The specified image digest does not match the digest that Amazon ECR calculated for
        /// the image.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ImageTagAlreadyExistsException">
        /// The specified image is tagged with a tag that already exists. The repository is configured
        /// for tag immutability.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.KmsException">
        /// The operation failed due to a KMS exception.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LayersNotFoundException">
        /// The specified layers could not be found, or the specified layer is not valid for this
        /// repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LimitExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ReferencedImagesNotFoundException">
        /// The manifest list is referencing an image that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/PutImage">REST API Reference for PutImage Operation</seealso>
        Task<PutImageResponse> PutImageAsync(PutImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutImageScanningConfiguration



        /// <summary>
        /// Updates the image scanning configuration for the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImageScanningConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutImageScanningConfiguration service method, as returned by ECR.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/PutImageScanningConfiguration">REST API Reference for PutImageScanningConfiguration Operation</seealso>
        Task<PutImageScanningConfigurationResponse> PutImageScanningConfigurationAsync(PutImageScanningConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutImageTagMutability



        /// <summary>
        /// Updates the image tag mutability settings for the specified repository. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/image-tag-mutability.html">Image
        /// Tag Mutability</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImageTagMutability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutImageTagMutability service method, as returned by ECR.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/PutImageTagMutability">REST API Reference for PutImageTagMutability Operation</seealso>
        Task<PutImageTagMutabilityResponse> PutImageTagMutabilityAsync(PutImageTagMutabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutLifecyclePolicy



        /// <summary>
        /// Creates or updates the lifecycle policy for the specified repository. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/LifecyclePolicies.html">Lifecycle
        /// Policy Template</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutLifecyclePolicyResponse> PutLifecyclePolicyAsync(PutLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRegistryPolicy



        /// <summary>
        /// Creates or updates the permissions policy for your registry.
        /// 
        ///  
        /// <para>
        /// A registry policy is used to specify permissions for another AWS account and is used
        /// when configuring cross-account replication. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/registry-permissions.html">Registry
        /// permissions</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRegistryPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRegistryPolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/PutRegistryPolicy">REST API Reference for PutRegistryPolicy Operation</seealso>
        Task<PutRegistryPolicyResponse> PutRegistryPolicyAsync(PutRegistryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutReplicationConfiguration



        /// <summary>
        /// Creates or updates the replication configuration for a registry. The existing replication
        /// configuration for a repository can be retrieved with the <a>DescribeRegistry</a> API
        /// action. The first time the PutReplicationConfiguration API is called, a service-linked
        /// IAM role is created in your account for the replication process. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/using-service-linked-roles.html">Using
        /// Service-Linked Roles for Amazon ECR</a> in the <i>Amazon Elastic Container Registry
        /// User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// When configuring cross-account replication, the destination account must grant the
        /// source account permission to replicate. This permission is controlled using a registry
        /// permissions policy. For more information, see <a>PutRegistryPolicy</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutReplicationConfiguration service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ValidationException">
        /// There was an exception validating this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/PutReplicationConfiguration">REST API Reference for PutReplicationConfiguration Operation</seealso>
        Task<PutReplicationConfigurationResponse> PutReplicationConfigurationAsync(PutReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetRepositoryPolicy



        /// <summary>
        /// Applies a repository policy to the specified repository to control access permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/repository-policies.html">Amazon
        /// ECR Repository Policies</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetRepositoryPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SetRepositoryPolicyResponse> SetRepositoryPolicyAsync(SetRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartImageScan



        /// <summary>
        /// Starts an image vulnerability scan. An image scan can only be started once per day
        /// on an individual image. This limit includes if an image was scanned on initial push.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/image-scanning.html">Image
        /// Scanning</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImageScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImageScan service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.ImageNotFoundException">
        /// The image requested does not exist in the specified repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LimitExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.UnsupportedImageTypeException">
        /// The image is of a type that cannot be scanned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/StartImageScan">REST API Reference for StartImageScan Operation</seealso>
        Task<StartImageScanResponse> StartImageScanAsync(StartImageScanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartLifecyclePolicyPreview



        /// <summary>
        /// Starts a preview of a lifecycle policy for the specified repository. This allows you
        /// to see the results before associating the lifecycle policy with the repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLifecyclePolicyPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartLifecyclePolicyPreview service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LifecyclePolicyNotFoundException">
        /// The lifecycle policy could not be found, and no policy is set to the repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LifecyclePolicyPreviewInProgressException">
        /// The previous lifecycle policy preview request has not completed. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/StartLifecyclePolicyPreview">REST API Reference for StartLifecyclePolicyPreview Operation</seealso>
        Task<StartLifecyclePolicyPreviewResponse> StartLifecyclePolicyPreviewAsync(StartLifecyclePolicyPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds specified tags to a resource with the specified ARN. Existing tags on a resource
        /// are not changed if they are not specified in the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UploadLayerPart



        /// <summary>
        /// Uploads an image layer part to Amazon ECR.
        /// 
        ///  
        /// <para>
        /// When an image is pushed, each new image layer is uploaded in parts. The maximum size
        /// of each image layer part can be 20971520 bytes (or about 20MB). The UploadLayerPart
        /// API is called once per each new image layer part.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadLayerPart service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadLayerPart service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidLayerPartException">
        /// The layer part size is not valid, or the first byte specified is not consecutive to
        /// the last byte of a previous layer part upload.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.KmsException">
        /// The operation failed due to a KMS exception.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LimitExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.UploadNotFoundException">
        /// The upload could not be found, or the specified upload ID is not valid for this repository.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-2015-09-21/UploadLayerPart">REST API Reference for UploadLayerPart Operation</seealso>
        Task<UploadLayerPartResponse> UploadLayerPartAsync(UploadLayerPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}