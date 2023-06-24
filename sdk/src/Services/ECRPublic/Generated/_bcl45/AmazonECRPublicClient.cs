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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ECRPublic.Model;
using Amazon.ECRPublic.Model.Internal.MarshallTransformations;
using Amazon.ECRPublic.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ECRPublic
{
    /// <summary>
    /// Implementation for accessing ECRPublic
    ///
    /// Amazon Elastic Container Registry Public 
    /// <para>
    /// Amazon Elastic Container Registry Public (Amazon ECR Public) is a managed container
    /// image registry service. Amazon ECR provides both public and private registries to
    /// host your container images. You can use the Docker CLI or your preferred client to
    /// push, pull, and manage images. Amazon ECR provides a secure, scalable, and reliable
    /// registry for your Docker or Open Container Initiative (OCI) images. Amazon ECR supports
    /// public repositories with this API. For information about the Amazon ECR API for private
    /// repositories, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/APIReference/Welcome.html">Amazon
    /// Elastic Container Registry API Reference</a>.
    /// </para>
    /// </summary>
    public partial class AmazonECRPublicClient : AmazonServiceClient, IAmazonECRPublic
    {
        private static IServiceMetadata serviceMetadata = new AmazonECRPublicMetadata();
        private IECRPublicPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IECRPublicPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ECRPublicPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonECRPublicClient with the credentials loaded from the application's
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
        public AmazonECRPublicClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonECRPublicConfig()) { }

        /// <summary>
        /// Constructs AmazonECRPublicClient with the credentials loaded from the application's
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
        public AmazonECRPublicClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonECRPublicConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonECRPublicClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonECRPublicClient Configuration Object</param>
        public AmazonECRPublicClient(AmazonECRPublicConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonECRPublicClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonECRPublicClient(AWSCredentials credentials)
            : this(credentials, new AmazonECRPublicConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonECRPublicClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonECRPublicClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonECRPublicConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonECRPublicClient with AWS Credentials and an
        /// AmazonECRPublicClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonECRPublicClient Configuration Object</param>
        public AmazonECRPublicClient(AWSCredentials credentials, AmazonECRPublicConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonECRPublicClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonECRPublicClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonECRPublicConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonECRPublicClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonECRPublicClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonECRPublicConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonECRPublicClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonECRPublicClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonECRPublicClient Configuration Object</param>
        public AmazonECRPublicClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonECRPublicConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonECRPublicClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonECRPublicClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonECRPublicConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonECRPublicClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonECRPublicClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonECRPublicConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonECRPublicClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonECRPublicClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonECRPublicClient Configuration Object</param>
        public AmazonECRPublicClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonECRPublicConfig clientConfig)
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

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonECRPublicEndpointResolver());
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


        /// <summary>
        /// Checks the availability of one or more image layers that are within a repository in
        /// a public registry. When an image is pushed to a repository, each image layer is checked
        /// to verify if it has been uploaded before. If it has been uploaded, then the image
        /// layer is skipped.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCheckLayerAvailability service method.</param>
        /// 
        /// <returns>The response from the BatchCheckLayerAvailability service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/BatchCheckLayerAvailability">REST API Reference for BatchCheckLayerAvailability Operation</seealso>
        public virtual BatchCheckLayerAvailabilityResponse BatchCheckLayerAvailability(BatchCheckLayerAvailabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCheckLayerAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCheckLayerAvailabilityResponseUnmarshaller.Instance;

            return Invoke<BatchCheckLayerAvailabilityResponse>(request, options);
        }


        /// <summary>
        /// Checks the availability of one or more image layers that are within a repository in
        /// a public registry. When an image is pushed to a repository, each image layer is checked
        /// to verify if it has been uploaded before. If it has been uploaded, then the image
        /// layer is skipped.
        /// 
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
        /// <returns>The response from the BatchCheckLayerAvailability service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/BatchCheckLayerAvailability">REST API Reference for BatchCheckLayerAvailability Operation</seealso>
        public virtual Task<BatchCheckLayerAvailabilityResponse> BatchCheckLayerAvailabilityAsync(BatchCheckLayerAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCheckLayerAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCheckLayerAvailabilityResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchCheckLayerAvailabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteImage


        /// <summary>
        /// Deletes a list of specified images that are within a repository in a public registry.
        /// Images are specified with either an <code>imageTag</code> or <code>imageDigest</code>.
        /// 
        ///  
        /// <para>
        /// You can remove a tag from an image by specifying the image's tag in your request.
        /// When you remove the last tag from an image, the image is deleted from your repository.
        /// </para>
        ///  
        /// <para>
        /// You can completely delete an image (and all of its tags) by specifying the digest
        /// of the image in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteImage service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteImage service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/BatchDeleteImage">REST API Reference for BatchDeleteImage Operation</seealso>
        public virtual BatchDeleteImageResponse BatchDeleteImage(BatchDeleteImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteImageResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteImageResponse>(request, options);
        }


        /// <summary>
        /// Deletes a list of specified images that are within a repository in a public registry.
        /// Images are specified with either an <code>imageTag</code> or <code>imageDigest</code>.
        /// 
        ///  
        /// <para>
        /// You can remove a tag from an image by specifying the image's tag in your request.
        /// When you remove the last tag from an image, the image is deleted from your repository.
        /// </para>
        ///  
        /// <para>
        /// You can completely delete an image (and all of its tags) by specifying the digest
        /// of the image in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteImage service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/BatchDeleteImage">REST API Reference for BatchDeleteImage Operation</seealso>
        public virtual Task<BatchDeleteImageResponse> BatchDeleteImageAsync(BatchDeleteImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteImageResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDeleteImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CompleteLayerUpload


        /// <summary>
        /// Informs Amazon ECR that the image layer upload is complete for a specified public
        /// registry, repository name, and upload ID. You can optionally provide a <code>sha256</code>
        /// digest of the image layer for data validation purposes.
        /// 
        ///  
        /// <para>
        /// When an image is pushed, the CompleteLayerUpload API is called once for each new image
        /// layer to verify that the upload is complete.
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
        /// 
        /// <returns>The response from the CompleteLayerUpload service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.EmptyUploadException">
        /// The specified layer upload doesn't contain any layer parts.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidLayerException">
        /// The layer digest calculation performed by Amazon ECR when the image layer doesn't
        /// match the digest specified.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LayerAlreadyExistsException">
        /// The image layer already exists in the associated repository.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LayerPartTooSmallException">
        /// Layer parts must be at least 5 MiB in size.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UploadNotFoundException">
        /// The upload can't be found, or the specified upload ID isn't valid for this repository.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/CompleteLayerUpload">REST API Reference for CompleteLayerUpload Operation</seealso>
        public virtual CompleteLayerUploadResponse CompleteLayerUpload(CompleteLayerUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteLayerUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteLayerUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteLayerUploadResponse>(request, options);
        }


        /// <summary>
        /// Informs Amazon ECR that the image layer upload is complete for a specified public
        /// registry, repository name, and upload ID. You can optionally provide a <code>sha256</code>
        /// digest of the image layer for data validation purposes.
        /// 
        ///  
        /// <para>
        /// When an image is pushed, the CompleteLayerUpload API is called once for each new image
        /// layer to verify that the upload is complete.
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
        /// <returns>The response from the CompleteLayerUpload service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.EmptyUploadException">
        /// The specified layer upload doesn't contain any layer parts.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidLayerException">
        /// The layer digest calculation performed by Amazon ECR when the image layer doesn't
        /// match the digest specified.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LayerAlreadyExistsException">
        /// The image layer already exists in the associated repository.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LayerPartTooSmallException">
        /// Layer parts must be at least 5 MiB in size.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UploadNotFoundException">
        /// The upload can't be found, or the specified upload ID isn't valid for this repository.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/CompleteLayerUpload">REST API Reference for CompleteLayerUpload Operation</seealso>
        public virtual Task<CompleteLayerUploadResponse> CompleteLayerUploadAsync(CompleteLayerUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteLayerUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteLayerUploadResponseUnmarshaller.Instance;
            
            return InvokeAsync<CompleteLayerUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRepository


        /// <summary>
        /// Creates a repository in a public registry. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/Repositories.html">Amazon
        /// ECR repositories</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LimitExceededException">
        /// The operation didn't succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryAlreadyExistsException">
        /// The specified repository already exists in the specified registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        public virtual CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Creates a repository in a public registry. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/Repositories.html">Amazon
        /// ECR repositories</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LimitExceededException">
        /// The operation didn't succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryAlreadyExistsException">
        /// The specified repository already exists in the specified registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        public virtual Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRepository


        /// <summary>
        /// Deletes a repository in a public registry. If the repository contains images, you
        /// must either manually delete all images in the repository or use the <code>force</code>
        /// option. This option deletes all images on your behalf before deleting the repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotEmptyException">
        /// The specified repository contains images. To delete a repository that contains images,
        /// you must force the deletion with the <code>force</code> parameter.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        public virtual DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Deletes a repository in a public registry. If the repository contains images, you
        /// must either manually delete all images in the repository or use the <code>force</code>
        /// option. This option deletes all images on your behalf before deleting the repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotEmptyException">
        /// The specified repository contains images. To delete a repository that contains images,
        /// you must force the deletion with the <code>force</code> parameter.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        public virtual Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRepositoryPolicy


        /// <summary>
        /// Deletes the repository policy that's associated with the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRepositoryPolicy service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryPolicyNotFoundException">
        /// The specified repository and registry combination doesn't have an associated repository
        /// policy.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DeleteRepositoryPolicy">REST API Reference for DeleteRepositoryPolicy Operation</seealso>
        public virtual DeleteRepositoryPolicyResponse DeleteRepositoryPolicy(DeleteRepositoryPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the repository policy that's associated with the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRepositoryPolicy service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryPolicyNotFoundException">
        /// The specified repository and registry combination doesn't have an associated repository
        /// policy.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DeleteRepositoryPolicy">REST API Reference for DeleteRepositoryPolicy Operation</seealso>
        public virtual Task<DeleteRepositoryPolicyResponse> DeleteRepositoryPolicyAsync(DeleteRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRepositoryPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImages


        /// <summary>
        /// Returns metadata that's related to the images in a repository in a public registry.
        /// 
        ///  <note> 
        /// <para>
        /// Beginning with Docker version 1.9, the Docker client compresses image layers before
        /// pushing them to a V2 Docker registry. The output of the <code>docker images</code>
        /// command shows the uncompressed image size. Therefore, it might return a larger image
        /// size than the image sizes that are returned by <a>DescribeImages</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.ImageNotFoundException">
        /// The image requested doesn't exist in the specified repository.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesResponse>(request, options);
        }


        /// <summary>
        /// Returns metadata that's related to the images in a repository in a public registry.
        /// 
        ///  <note> 
        /// <para>
        /// Beginning with Docker version 1.9, the Docker client compresses image layers before
        /// pushing them to a V2 Docker registry. The output of the <code>docker images</code>
        /// command shows the uncompressed image size. Therefore, it might return a larger image
        /// size than the image sizes that are returned by <a>DescribeImages</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.ImageNotFoundException">
        /// The image requested doesn't exist in the specified repository.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImageTags


        /// <summary>
        /// Returns the image tag details for a repository in a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageTags service method.</param>
        /// 
        /// <returns>The response from the DescribeImageTags service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeImageTags">REST API Reference for DescribeImageTags Operation</seealso>
        public virtual DescribeImageTagsResponse DescribeImageTags(DescribeImageTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeImageTagsResponse>(request, options);
        }


        /// <summary>
        /// Returns the image tag details for a repository in a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImageTags service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeImageTags">REST API Reference for DescribeImageTags Operation</seealso>
        public virtual Task<DescribeImageTagsResponse> DescribeImageTagsAsync(DescribeImageTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeImageTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRegistries


        /// <summary>
        /// Returns details for a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistries service method.</param>
        /// 
        /// <returns>The response from the DescribeRegistries service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeRegistries">REST API Reference for DescribeRegistries Operation</seealso>
        public virtual DescribeRegistriesResponse DescribeRegistries(DescribeRegistriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistriesResponseUnmarshaller.Instance;

            return Invoke<DescribeRegistriesResponse>(request, options);
        }


        /// <summary>
        /// Returns details for a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistries service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeRegistries">REST API Reference for DescribeRegistries Operation</seealso>
        public virtual Task<DescribeRegistriesResponse> DescribeRegistriesAsync(DescribeRegistriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRegistriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRepositories


        /// <summary>
        /// Describes repositories that are in a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositories service method.</param>
        /// 
        /// <returns>The response from the DescribeRepositories service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeRepositories">REST API Reference for DescribeRepositories Operation</seealso>
        public virtual DescribeRepositoriesResponse DescribeRepositories(DescribeRepositoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRepositoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeRepositoriesResponse>(request, options);
        }


        /// <summary>
        /// Describes repositories that are in a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRepositories service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeRepositories">REST API Reference for DescribeRepositories Operation</seealso>
        public virtual Task<DescribeRepositoriesResponse> DescribeRepositoriesAsync(DescribeRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRepositoriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAuthorizationToken


        /// <summary>
        /// Retrieves an authorization token. An authorization token represents your IAM authentication
        /// credentials. You can use it to access any Amazon ECR registry that your IAM principal
        /// has access to. The authorization token is valid for 12 hours. This API requires the
        /// <code>ecr-public:GetAuthorizationToken</code> and <code>sts:GetServiceBearerToken</code>
        /// permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizationToken service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetAuthorizationToken">REST API Reference for GetAuthorizationToken Operation</seealso>
        public virtual GetAuthorizationTokenResponse GetAuthorizationToken(GetAuthorizationTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizationTokenResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizationTokenResponse>(request, options);
        }


        /// <summary>
        /// Retrieves an authorization token. An authorization token represents your IAM authentication
        /// credentials. You can use it to access any Amazon ECR registry that your IAM principal
        /// has access to. The authorization token is valid for 12 hours. This API requires the
        /// <code>ecr-public:GetAuthorizationToken</code> and <code>sts:GetServiceBearerToken</code>
        /// permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAuthorizationToken service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetAuthorizationToken">REST API Reference for GetAuthorizationToken Operation</seealso>
        public virtual Task<GetAuthorizationTokenResponse> GetAuthorizationTokenAsync(GetAuthorizationTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizationTokenResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAuthorizationTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRegistryCatalogData


        /// <summary>
        /// Retrieves catalog metadata for a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistryCatalogData service method.</param>
        /// 
        /// <returns>The response from the GetRegistryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRegistryCatalogData">REST API Reference for GetRegistryCatalogData Operation</seealso>
        public virtual GetRegistryCatalogDataResponse GetRegistryCatalogData(GetRegistryCatalogDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistryCatalogDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryCatalogDataResponseUnmarshaller.Instance;

            return Invoke<GetRegistryCatalogDataResponse>(request, options);
        }


        /// <summary>
        /// Retrieves catalog metadata for a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistryCatalogData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegistryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRegistryCatalogData">REST API Reference for GetRegistryCatalogData Operation</seealso>
        public virtual Task<GetRegistryCatalogDataResponse> GetRegistryCatalogDataAsync(GetRegistryCatalogDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistryCatalogDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryCatalogDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRegistryCatalogDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRepositoryCatalogData


        /// <summary>
        /// Retrieve catalog metadata for a repository in a public registry. This metadata is
        /// displayed publicly in the Amazon ECR Public Gallery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryCatalogData service method.</param>
        /// 
        /// <returns>The response from the GetRepositoryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryCatalogDataNotFoundException">
        /// The repository catalog data doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRepositoryCatalogData">REST API Reference for GetRepositoryCatalogData Operation</seealso>
        public virtual GetRepositoryCatalogDataResponse GetRepositoryCatalogData(GetRepositoryCatalogDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryCatalogDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryCatalogDataResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryCatalogDataResponse>(request, options);
        }


        /// <summary>
        /// Retrieve catalog metadata for a repository in a public registry. This metadata is
        /// displayed publicly in the Amazon ECR Public Gallery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryCatalogData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRepositoryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryCatalogDataNotFoundException">
        /// The repository catalog data doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRepositoryCatalogData">REST API Reference for GetRepositoryCatalogData Operation</seealso>
        public virtual Task<GetRepositoryCatalogDataResponse> GetRepositoryCatalogDataAsync(GetRepositoryCatalogDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryCatalogDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryCatalogDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRepositoryCatalogDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRepositoryPolicy


        /// <summary>
        /// Retrieves the repository policy for the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the GetRepositoryPolicy service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryPolicyNotFoundException">
        /// The specified repository and registry combination doesn't have an associated repository
        /// policy.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRepositoryPolicy">REST API Reference for GetRepositoryPolicy Operation</seealso>
        public virtual GetRepositoryPolicyResponse GetRepositoryPolicy(GetRepositoryPolicyRequest request)
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
        /// <returns>The response from the GetRepositoryPolicy service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryPolicyNotFoundException">
        /// The specified repository and registry combination doesn't have an associated repository
        /// policy.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRepositoryPolicy">REST API Reference for GetRepositoryPolicy Operation</seealso>
        public virtual Task<GetRepositoryPolicyResponse> GetRepositoryPolicyAsync(GetRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRepositoryPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateLayerUpload


        /// <summary>
        /// Notifies Amazon ECR that you intend to upload an image layer.
        /// 
        ///  
        /// <para>
        /// When an image is pushed, the InitiateLayerUpload API is called once for each image
        /// layer that hasn't already been uploaded. Whether an image layer uploads is determined
        /// by the BatchCheckLayerAvailability API action.
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
        /// 
        /// <returns>The response from the InitiateLayerUpload service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/InitiateLayerUpload">REST API Reference for InitiateLayerUpload Operation</seealso>
        public virtual InitiateLayerUploadResponse InitiateLayerUpload(InitiateLayerUploadRequest request)
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
        /// When an image is pushed, the InitiateLayerUpload API is called once for each image
        /// layer that hasn't already been uploaded. Whether an image layer uploads is determined
        /// by the BatchCheckLayerAvailability API action.
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
        /// <returns>The response from the InitiateLayerUpload service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/InitiateLayerUpload">REST API Reference for InitiateLayerUpload Operation</seealso>
        public virtual Task<InitiateLayerUploadResponse> InitiateLayerUploadAsync(InitiateLayerUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateLayerUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateLayerUploadResponseUnmarshaller.Instance;
            
            return InvokeAsync<InitiateLayerUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the tags for an Amazon ECR Public resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List the tags for an Amazon ECR Public resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutImage


        /// <summary>
        /// Creates or updates the image manifest and tags that are associated with an image.
        /// 
        ///  
        /// <para>
        /// When an image is pushed and all new image layers have been uploaded, the PutImage
        /// API is called once to create or update the image manifest and the tags that are associated
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
        /// 
        /// <returns>The response from the PutImage service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.ImageAlreadyExistsException">
        /// The specified image has already been pushed, and there were no changes to the manifest
        /// or image tag after the last push.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ImageDigestDoesNotMatchException">
        /// The specified image digest doesn't match the digest that Amazon ECR calculated for
        /// the image.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ImageTagAlreadyExistsException">
        /// The specified image is tagged with a tag that already exists. The repository is configured
        /// for tag immutability.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LayersNotFoundException">
        /// The specified layers can't be found, or the specified layer isn't valid for this repository.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LimitExceededException">
        /// The operation didn't succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ReferencedImagesNotFoundException">
        /// The manifest list is referencing an image that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutImage">REST API Reference for PutImage Operation</seealso>
        public virtual PutImageResponse PutImage(PutImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageResponseUnmarshaller.Instance;

            return Invoke<PutImageResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates the image manifest and tags that are associated with an image.
        /// 
        ///  
        /// <para>
        /// When an image is pushed and all new image layers have been uploaded, the PutImage
        /// API is called once to create or update the image manifest and the tags that are associated
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
        /// <returns>The response from the PutImage service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.ImageAlreadyExistsException">
        /// The specified image has already been pushed, and there were no changes to the manifest
        /// or image tag after the last push.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ImageDigestDoesNotMatchException">
        /// The specified image digest doesn't match the digest that Amazon ECR calculated for
        /// the image.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ImageTagAlreadyExistsException">
        /// The specified image is tagged with a tag that already exists. The repository is configured
        /// for tag immutability.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LayersNotFoundException">
        /// The specified layers can't be found, or the specified layer isn't valid for this repository.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LimitExceededException">
        /// The operation didn't succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ReferencedImagesNotFoundException">
        /// The manifest list is referencing an image that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutImage">REST API Reference for PutImage Operation</seealso>
        public virtual Task<PutImageResponse> PutImageAsync(PutImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRegistryCatalogData


        /// <summary>
        /// Create or update the catalog data for a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRegistryCatalogData service method.</param>
        /// 
        /// <returns>The response from the PutRegistryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutRegistryCatalogData">REST API Reference for PutRegistryCatalogData Operation</seealso>
        public virtual PutRegistryCatalogDataResponse PutRegistryCatalogData(PutRegistryCatalogDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRegistryCatalogDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRegistryCatalogDataResponseUnmarshaller.Instance;

            return Invoke<PutRegistryCatalogDataResponse>(request, options);
        }


        /// <summary>
        /// Create or update the catalog data for a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRegistryCatalogData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRegistryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutRegistryCatalogData">REST API Reference for PutRegistryCatalogData Operation</seealso>
        public virtual Task<PutRegistryCatalogDataResponse> PutRegistryCatalogDataAsync(PutRegistryCatalogDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRegistryCatalogDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRegistryCatalogDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutRegistryCatalogDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRepositoryCatalogData


        /// <summary>
        /// Creates or updates the catalog data for a repository in a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryCatalogData service method.</param>
        /// 
        /// <returns>The response from the PutRepositoryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutRepositoryCatalogData">REST API Reference for PutRepositoryCatalogData Operation</seealso>
        public virtual PutRepositoryCatalogDataResponse PutRepositoryCatalogData(PutRepositoryCatalogDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRepositoryCatalogDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRepositoryCatalogDataResponseUnmarshaller.Instance;

            return Invoke<PutRepositoryCatalogDataResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates the catalog data for a repository in a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryCatalogData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRepositoryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutRepositoryCatalogData">REST API Reference for PutRepositoryCatalogData Operation</seealso>
        public virtual Task<PutRepositoryCatalogDataResponse> PutRepositoryCatalogDataAsync(PutRepositoryCatalogDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRepositoryCatalogDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRepositoryCatalogDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutRepositoryCatalogDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetRepositoryPolicy


        /// <summary>
        /// Applies a repository policy to the specified public repository to control access permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/repository-policies.html">Amazon
        /// ECR Repository Policies</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the SetRepositoryPolicy service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/SetRepositoryPolicy">REST API Reference for SetRepositoryPolicy Operation</seealso>
        public virtual SetRepositoryPolicyResponse SetRepositoryPolicy(SetRepositoryPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetRepositoryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetRepositoryPolicyResponseUnmarshaller.Instance;

            return Invoke<SetRepositoryPolicyResponse>(request, options);
        }


        /// <summary>
        /// Applies a repository policy to the specified public repository to control access permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/repository-policies.html">Amazon
        /// ECR Repository Policies</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetRepositoryPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetRepositoryPolicy service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/SetRepositoryPolicy">REST API Reference for SetRepositoryPolicy Operation</seealso>
        public virtual Task<SetRepositoryPolicyResponse> SetRepositoryPolicyAsync(SetRepositoryPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetRepositoryPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetRepositoryPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetRepositoryPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource aren't specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags associated with that resource are also
        /// deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource aren't specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags associated with that resource are also
        /// deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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
        /// <returns>The response from the UntagResource service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadLayerPart


        /// <summary>
        /// Uploads an image layer part to Amazon ECR.
        /// 
        ///  
        /// <para>
        /// When an image is pushed, each new image layer is uploaded in parts. The maximum size
        /// of each image layer part can be 20971520 bytes (about 20MB). The UploadLayerPart API
        /// is called once for each new image layer part.
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
        /// 
        /// <returns>The response from the UploadLayerPart service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidLayerPartException">
        /// The layer part size isn't valid, or the first byte specified isn't consecutive to
        /// the last byte of a previous layer part upload.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LimitExceededException">
        /// The operation didn't succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UploadNotFoundException">
        /// The upload can't be found, or the specified upload ID isn't valid for this repository.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/UploadLayerPart">REST API Reference for UploadLayerPart Operation</seealso>
        public virtual UploadLayerPartResponse UploadLayerPart(UploadLayerPartRequest request)
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
        /// of each image layer part can be 20971520 bytes (about 20MB). The UploadLayerPart API
        /// is called once for each new image layer part.
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
        /// <returns>The response from the UploadLayerPart service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidLayerPartException">
        /// The layer part size isn't valid, or the first byte specified isn't consecutive to
        /// the last byte of a previous layer part upload.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LimitExceededException">
        /// The operation didn't succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UploadNotFoundException">
        /// The upload can't be found, or the specified upload ID isn't valid for this repository.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/UploadLayerPart">REST API Reference for UploadLayerPart Operation</seealso>
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