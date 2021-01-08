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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ECR.Model;
using Amazon.ECR.Model.Internal.MarshallTransformations;
using Amazon.ECR.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ECR
{
    /// <summary>
    /// Implementation for accessing ECR
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
    public partial class AmazonECRClient : AmazonServiceClient, IAmazonECR
    {
        private static IServiceMetadata serviceMetadata = new AmazonECRMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonECRClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonECRClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonECRConfig()) { }

        /// <summary>
        /// Constructs AmazonECRClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonECRClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonECRConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonECRClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonECRClient Configuration Object</param>
        public AmazonECRClient(AmazonECRConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
        private IECRPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IECRPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ECRPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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

        internal virtual BatchCheckLayerAvailabilityResponse BatchCheckLayerAvailability(BatchCheckLayerAvailabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCheckLayerAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCheckLayerAvailabilityResponseUnmarshaller.Instance;

            return Invoke<BatchCheckLayerAvailabilityResponse>(request, options);
        }



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
        public virtual Task<BatchCheckLayerAvailabilityResponse> BatchCheckLayerAvailabilityAsync(BatchCheckLayerAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCheckLayerAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCheckLayerAvailabilityResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCheckLayerAvailabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteImage

        internal virtual BatchDeleteImageResponse BatchDeleteImage(BatchDeleteImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteImageResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteImageResponse>(request, options);
        }



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
        public virtual Task<BatchDeleteImageResponse> BatchDeleteImageAsync(BatchDeleteImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteImageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetImage

        internal virtual BatchGetImageResponse BatchGetImage(BatchGetImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetImageResponseUnmarshaller.Instance;

            return Invoke<BatchGetImageResponse>(request, options);
        }



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
        public virtual Task<BatchGetImageResponse> BatchGetImageAsync(BatchGetImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetImageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CompleteLayerUpload

        internal virtual CompleteLayerUploadResponse CompleteLayerUpload(CompleteLayerUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteLayerUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteLayerUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteLayerUploadResponse>(request, options);
        }



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
        public virtual Task<CompleteLayerUploadResponse> CompleteLayerUploadAsync(CompleteLayerUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteLayerUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteLayerUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteLayerUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRepository

        internal virtual CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateRepositoryResponse>(request, options);
        }



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
        public virtual Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLifecyclePolicy

        internal virtual DeleteLifecyclePolicyResponse DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecyclePolicyResponse>(request, options);
        }



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
        public virtual Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRegistryPolicy

        internal virtual DeleteRegistryPolicyResponse DeleteRegistryPolicy(DeleteRegistryPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegistryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistryPolicyResponse>(request, options);
        }



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
        public virtual Task<DeleteRegistryPolicyResponse> DeleteRegistryPolicyAsync(DeleteRegistryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegistryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegistryPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRepository

        internal virtual DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryResponse>(request, options);
        }



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
        public virtual Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRepositoryPolicy

        internal virtual DeleteRepositoryPolicyResponse DeleteRepositoryPolicy(DeleteRepositoryPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryPolicyResponse>(request, options);
        }



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
        public virtual Task<DeleteRepositoryPolicyResponse> DeleteRepositoryPolicyAsync(DeleteRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRepositoryPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImages

        internal virtual DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesResponse>(request, options);
        }



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
        public virtual Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImageScanFindings

        internal virtual DescribeImageScanFindingsResponse DescribeImageScanFindings(DescribeImageScanFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageScanFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageScanFindingsResponseUnmarshaller.Instance;

            return Invoke<DescribeImageScanFindingsResponse>(request, options);
        }



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
        public virtual Task<DescribeImageScanFindingsResponse> DescribeImageScanFindingsAsync(DescribeImageScanFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageScanFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageScanFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImageScanFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRegistry

        internal virtual DescribeRegistryResponse DescribeRegistry(DescribeRegistryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistryResponseUnmarshaller.Instance;

            return Invoke<DescribeRegistryResponse>(request, options);
        }



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
        public virtual Task<DescribeRegistryResponse> DescribeRegistryAsync(DescribeRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegistryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRepositories

        internal virtual DescribeRepositoriesResponse DescribeRepositories(DescribeRepositoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRepositoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeRepositoriesResponse>(request, options);
        }



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
        public virtual Task<DescribeRepositoriesResponse> DescribeRepositoriesAsync(DescribeRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRepositoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAuthorizationToken

        internal virtual GetAuthorizationTokenResponse GetAuthorizationToken(GetAuthorizationTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizationTokenResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizationTokenResponse>(request, options);
        }



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
        public virtual Task<GetAuthorizationTokenResponse> GetAuthorizationTokenAsync(GetAuthorizationTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizationTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetAuthorizationTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDownloadUrlForLayer

        internal virtual GetDownloadUrlForLayerResponse GetDownloadUrlForLayer(GetDownloadUrlForLayerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDownloadUrlForLayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDownloadUrlForLayerResponseUnmarshaller.Instance;

            return Invoke<GetDownloadUrlForLayerResponse>(request, options);
        }



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
        public virtual Task<GetDownloadUrlForLayerResponse> GetDownloadUrlForLayerAsync(GetDownloadUrlForLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDownloadUrlForLayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDownloadUrlForLayerResponseUnmarshaller.Instance;

            return InvokeAsync<GetDownloadUrlForLayerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLifecyclePolicy

        internal virtual GetLifecyclePolicyResponse GetLifecyclePolicy(GetLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<GetLifecyclePolicyResponse>(request, options);
        }



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
        public virtual Task<GetLifecyclePolicyResponse> GetLifecyclePolicyAsync(GetLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLifecyclePolicyPreview

        internal virtual GetLifecyclePolicyPreviewResponse GetLifecyclePolicyPreview(GetLifecyclePolicyPreviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyPreviewResponseUnmarshaller.Instance;

            return Invoke<GetLifecyclePolicyPreviewResponse>(request, options);
        }



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
        public virtual Task<GetLifecyclePolicyPreviewResponse> GetLifecyclePolicyPreviewAsync(GetLifecyclePolicyPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyPreviewResponseUnmarshaller.Instance;

            return InvokeAsync<GetLifecyclePolicyPreviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRegistryPolicy

        internal virtual GetRegistryPolicyResponse GetRegistryPolicy(GetRegistryPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryPolicyResponseUnmarshaller.Instance;

            return Invoke<GetRegistryPolicyResponse>(request, options);
        }



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
        public virtual Task<GetRegistryPolicyResponse> GetRegistryPolicyAsync(GetRegistryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegistryPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRepositoryPolicy

        internal virtual GetRepositoryPolicyResponse GetRepositoryPolicy(GetRepositoryPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryPolicyResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryPolicyResponse>(request, options);
        }



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
        public virtual Task<GetRepositoryPolicyResponse> GetRepositoryPolicyAsync(GetRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetRepositoryPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateLayerUpload

        internal virtual InitiateLayerUploadResponse InitiateLayerUpload(InitiateLayerUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateLayerUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateLayerUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateLayerUploadResponse>(request, options);
        }



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
        public virtual Task<InitiateLayerUploadResponse> InitiateLayerUploadAsync(InitiateLayerUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateLayerUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateLayerUploadResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateLayerUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListImages

        internal virtual ListImagesResponse ListImages(ListImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagesResponseUnmarshaller.Instance;

            return Invoke<ListImagesResponse>(request, options);
        }



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
        public virtual Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutImage

        internal virtual PutImageResponse PutImage(PutImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageResponseUnmarshaller.Instance;

            return Invoke<PutImageResponse>(request, options);
        }



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
        public virtual Task<PutImageResponse> PutImageAsync(PutImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageResponseUnmarshaller.Instance;

            return InvokeAsync<PutImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutImageScanningConfiguration

        internal virtual PutImageScanningConfigurationResponse PutImageScanningConfiguration(PutImageScanningConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImageScanningConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageScanningConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutImageScanningConfigurationResponse>(request, options);
        }



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
        public virtual Task<PutImageScanningConfigurationResponse> PutImageScanningConfigurationAsync(PutImageScanningConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImageScanningConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageScanningConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutImageScanningConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutImageTagMutability

        internal virtual PutImageTagMutabilityResponse PutImageTagMutability(PutImageTagMutabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImageTagMutabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageTagMutabilityResponseUnmarshaller.Instance;

            return Invoke<PutImageTagMutabilityResponse>(request, options);
        }



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
        public virtual Task<PutImageTagMutabilityResponse> PutImageTagMutabilityAsync(PutImageTagMutabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImageTagMutabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageTagMutabilityResponseUnmarshaller.Instance;

            return InvokeAsync<PutImageTagMutabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLifecyclePolicy

        internal virtual PutLifecyclePolicyResponse PutLifecyclePolicy(PutLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<PutLifecyclePolicyResponse>(request, options);
        }



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
        public virtual Task<PutLifecyclePolicyResponse> PutLifecyclePolicyAsync(PutLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRegistryPolicy

        internal virtual PutRegistryPolicyResponse PutRegistryPolicy(PutRegistryPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRegistryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRegistryPolicyResponseUnmarshaller.Instance;

            return Invoke<PutRegistryPolicyResponse>(request, options);
        }



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
        public virtual Task<PutRegistryPolicyResponse> PutRegistryPolicyAsync(PutRegistryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRegistryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRegistryPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutRegistryPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutReplicationConfiguration

        internal virtual PutReplicationConfigurationResponse PutReplicationConfiguration(PutReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutReplicationConfigurationResponse>(request, options);
        }



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
        public virtual Task<PutReplicationConfigurationResponse> PutReplicationConfigurationAsync(PutReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutReplicationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutReplicationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetRepositoryPolicy

        internal virtual SetRepositoryPolicyResponse SetRepositoryPolicy(SetRepositoryPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetRepositoryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetRepositoryPolicyResponseUnmarshaller.Instance;

            return Invoke<SetRepositoryPolicyResponse>(request, options);
        }



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
        public virtual Task<SetRepositoryPolicyResponse> SetRepositoryPolicyAsync(SetRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetRepositoryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetRepositoryPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SetRepositoryPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartImageScan

        internal virtual StartImageScanResponse StartImageScan(StartImageScanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImageScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImageScanResponseUnmarshaller.Instance;

            return Invoke<StartImageScanResponse>(request, options);
        }



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
        public virtual Task<StartImageScanResponse> StartImageScanAsync(StartImageScanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImageScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImageScanResponseUnmarshaller.Instance;

            return InvokeAsync<StartImageScanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartLifecyclePolicyPreview

        internal virtual StartLifecyclePolicyPreviewResponse StartLifecyclePolicyPreview(StartLifecyclePolicyPreviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLifecyclePolicyPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLifecyclePolicyPreviewResponseUnmarshaller.Instance;

            return Invoke<StartLifecyclePolicyPreviewResponse>(request, options);
        }



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
        public virtual Task<StartLifecyclePolicyPreviewResponse> StartLifecyclePolicyPreviewAsync(StartLifecyclePolicyPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLifecyclePolicyPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLifecyclePolicyPreviewResponseUnmarshaller.Instance;

            return InvokeAsync<StartLifecyclePolicyPreviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadLayerPart

        internal virtual UploadLayerPartResponse UploadLayerPart(UploadLayerPartRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadLayerPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadLayerPartResponseUnmarshaller.Instance;

            return Invoke<UploadLayerPartResponse>(request, options);
        }



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
        public virtual Task<UploadLayerPartResponse> UploadLayerPartAsync(UploadLayerPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadLayerPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadLayerPartResponseUnmarshaller.Instance;

            return InvokeAsync<UploadLayerPartResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}