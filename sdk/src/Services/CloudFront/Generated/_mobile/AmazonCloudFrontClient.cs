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
 * Do not modify this file. This file is generated from the cloudfront-2018-11-05.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudFront.Model;
using Amazon.CloudFront.Model.Internal.MarshallTransformations;
using Amazon.CloudFront.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront
{
    /// <summary>
    /// Implementation for accessing CloudFront
    ///
    /// Amazon CloudFront 
    /// <para>
    /// This is the <i>Amazon CloudFront API Reference</i>. This guide is for developers who
    /// need detailed information about CloudFront API actions, data types, and errors. For
    /// detailed information about CloudFront features, see the <i>Amazon CloudFront Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudFrontClient : AmazonServiceClient, IAmazonCloudFront
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudFrontMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
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
        public AmazonCloudFrontClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
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
        public AmazonCloudFrontClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(AmazonCloudFrontConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudFrontClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudFrontConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials and an
        /// AmazonCloudFrontClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(AWSCredentials credentials, AmazonCloudFrontConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFrontConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFrontConfig clientConfig)
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


        #region  CreateCloudFrontOriginAccessIdentity

        internal virtual CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<CreateCloudFrontOriginAccessIdentityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/CreateCloudFrontOriginAccessIdentity">REST API Reference for CreateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCloudFrontOriginAccessIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDistribution

        internal virtual CreateDistributionResponse CreateDistribution(CreateDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        public virtual Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDistributionWithTags

        internal virtual CreateDistributionWithTagsResponse CreateDistributionWithTags(CreateDistributionWithTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDistributionWithTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionWithTagsResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionWithTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionWithTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/CreateDistributionWithTags">REST API Reference for CreateDistributionWithTags Operation</seealso>
        public virtual Task<CreateDistributionWithTagsResponse> CreateDistributionWithTagsAsync(CreateDistributionWithTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDistributionWithTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionWithTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDistributionWithTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFieldLevelEncryptionConfig

        internal virtual CreateFieldLevelEncryptionConfigResponse CreateFieldLevelEncryptionConfig(CreateFieldLevelEncryptionConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<CreateFieldLevelEncryptionConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/CreateFieldLevelEncryptionConfig">REST API Reference for CreateFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<CreateFieldLevelEncryptionConfigResponse> CreateFieldLevelEncryptionConfigAsync(CreateFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFieldLevelEncryptionConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFieldLevelEncryptionProfile

        internal virtual CreateFieldLevelEncryptionProfileResponse CreateFieldLevelEncryptionProfile(CreateFieldLevelEncryptionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<CreateFieldLevelEncryptionProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/CreateFieldLevelEncryptionProfile">REST API Reference for CreateFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<CreateFieldLevelEncryptionProfileResponse> CreateFieldLevelEncryptionProfileAsync(CreateFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFieldLevelEncryptionProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInvalidation

        internal virtual CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInvalidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvalidationResponseUnmarshaller.Instance;

            return Invoke<CreateInvalidationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvalidation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/CreateInvalidation">REST API Reference for CreateInvalidation Operation</seealso>
        public virtual Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInvalidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvalidationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInvalidationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePublicKey

        internal virtual CreatePublicKeyResponse CreatePublicKey(CreatePublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePublicKeyResponseUnmarshaller.Instance;

            return Invoke<CreatePublicKeyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/CreatePublicKey">REST API Reference for CreatePublicKey Operation</seealso>
        public virtual Task<CreatePublicKeyResponse> CreatePublicKeyAsync(CreatePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePublicKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStreamingDistribution

        internal virtual CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingDistributionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/CreateStreamingDistribution">REST API Reference for CreateStreamingDistribution Operation</seealso>
        public virtual Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamingDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStreamingDistributionWithTags

        internal virtual CreateStreamingDistributionWithTagsResponse CreateStreamingDistributionWithTags(CreateStreamingDistributionWithTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamingDistributionWithTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingDistributionWithTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistributionWithTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/CreateStreamingDistributionWithTags">REST API Reference for CreateStreamingDistributionWithTags Operation</seealso>
        public virtual Task<CreateStreamingDistributionWithTagsResponse> CreateStreamingDistributionWithTagsAsync(CreateStreamingDistributionWithTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamingDistributionWithTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamingDistributionWithTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCloudFrontOriginAccessIdentity

        internal virtual DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity()
        {
            return DeleteCloudFrontOriginAccessIdentity(new DeleteCloudFrontOriginAccessIdentityRequest());
        }
        internal virtual DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudFrontOriginAccessIdentityResponse>(request, options);
        }


        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteCloudFrontOriginAccessIdentityAsync(new DeleteCloudFrontOriginAccessIdentityRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCloudFrontOriginAccessIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDistribution

        internal virtual DeleteDistributionResponse DeleteDistribution()
        {
            return DeleteDistribution(new DeleteDistributionRequest());
        }
        internal virtual DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionResponseUnmarshaller.Instance;

            return Invoke<DeleteDistributionResponse>(request, options);
        }


        /// <summary>
        /// Delete a distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionNotDisabledException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        public virtual Task<DeleteDistributionResponse> DeleteDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteDistributionAsync(new DeleteDistributionRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        public virtual Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFieldLevelEncryptionConfig

        internal virtual DeleteFieldLevelEncryptionConfigResponse DeleteFieldLevelEncryptionConfig(DeleteFieldLevelEncryptionConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteFieldLevelEncryptionConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/DeleteFieldLevelEncryptionConfig">REST API Reference for DeleteFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<DeleteFieldLevelEncryptionConfigResponse> DeleteFieldLevelEncryptionConfigAsync(DeleteFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFieldLevelEncryptionConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFieldLevelEncryptionProfile

        internal virtual DeleteFieldLevelEncryptionProfileResponse DeleteFieldLevelEncryptionProfile(DeleteFieldLevelEncryptionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteFieldLevelEncryptionProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/DeleteFieldLevelEncryptionProfile">REST API Reference for DeleteFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<DeleteFieldLevelEncryptionProfileResponse> DeleteFieldLevelEncryptionProfileAsync(DeleteFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFieldLevelEncryptionProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePublicKey

        internal virtual DeletePublicKeyResponse DeletePublicKey(DeletePublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicKeyResponseUnmarshaller.Instance;

            return Invoke<DeletePublicKeyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        public virtual Task<DeletePublicKeyResponse> DeletePublicKeyAsync(DeletePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePublicKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStreamingDistribution

        internal virtual DeleteStreamingDistributionResponse DeleteStreamingDistribution()
        {
            return DeleteStreamingDistribution(new DeleteStreamingDistributionRequest());
        }
        internal virtual DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamingDistributionResponse>(request, options);
        }


        /// <summary>
        /// Delete a streaming distribution. To delete an RTMP distribution using the CloudFront
        /// API, perform the following steps.
        /// 
        ///  
        /// <para>
        ///  <b>To delete an RTMP distribution using the CloudFront API</b>:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Disable the RTMP distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>GET Streaming Distribution Config</code> request to get the current
        /// configuration and the <code>Etag</code> header for the distribution. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the XML document that was returned in the response to your <code>GET Streaming
        /// Distribution Config</code> request to change the value of <code>Enabled</code> to
        /// <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>PUT Streaming Distribution Config</code> request to update the configuration
        /// for your distribution. In the request body, include the XML document that you updated
        /// in Step 3. Then set the value of the HTTP <code>If-Match</code> header to the value
        /// of the <code>ETag</code> header that CloudFront returned when you submitted the <code>GET
        /// Streaming Distribution Config</code> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to the <code>PUT Streaming Distribution Config</code> request
        /// to confirm that the distribution was successfully disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>GET Streaming Distribution Config</code> request to confirm that your
        /// changes have propagated. When propagation is complete, the value of <code>Status</code>
        /// is <code>Deployed</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DELETE Streaming Distribution</code> request. Set the value of the
        /// HTTP <code>If-Match</code> header to the value of the <code>ETag</code> header that
        /// CloudFront returned when you submitted the <code>GET Streaming Distribution Config</code>
        /// request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to your <code>DELETE Streaming Distribution</code> request to
        /// confirm that the distribution was successfully deleted.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For information about deleting a distribution using the CloudFront console, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/HowToDeleteDistribution.html">Deleting
        /// a Distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionNotDisabledException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        public virtual Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteStreamingDistributionAsync(new DeleteStreamingDistributionRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        public virtual Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStreamingDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentity

        internal virtual GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity()
        {
            return GetCloudFrontOriginAccessIdentity(new GetCloudFrontOriginAccessIdentityRequest());
        }
        internal virtual GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<GetCloudFrontOriginAccessIdentityResponse>(request, options);
        }


        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetCloudFrontOriginAccessIdentityAsync(new GetCloudFrontOriginAccessIdentityRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudFrontOriginAccessIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentityConfig

        internal virtual GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig()
        {
            return GetCloudFrontOriginAccessIdentityConfig(new GetCloudFrontOriginAccessIdentityConfigRequest());
        }
        internal virtual GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCloudFrontOriginAccessIdentityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance;

            return Invoke<GetCloudFrontOriginAccessIdentityConfigResponse>(request, options);
        }


        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        public virtual Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetCloudFrontOriginAccessIdentityConfigAsync(new GetCloudFrontOriginAccessIdentityConfigRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentityConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        public virtual Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCloudFrontOriginAccessIdentityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudFrontOriginAccessIdentityConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDistribution

        internal virtual GetDistributionResponse GetDistribution()
        {
            return GetDistribution(new GetDistributionRequest());
        }
        internal virtual GetDistributionResponse GetDistribution(GetDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionResponseUnmarshaller.Instance;

            return Invoke<GetDistributionResponse>(request, options);
        }


        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        public virtual Task<GetDistributionResponse> GetDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetDistributionAsync(new GetDistributionRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        public virtual Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDistributionConfig

        internal virtual GetDistributionConfigResponse GetDistributionConfig()
        {
            return GetDistributionConfig(new GetDistributionConfigRequest());
        }
        internal virtual GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionConfigResponseUnmarshaller.Instance;

            return Invoke<GetDistributionConfigResponse>(request, options);
        }


        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        public virtual Task<GetDistributionConfigResponse> GetDistributionConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetDistributionConfigAsync(new GetDistributionConfigRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        public virtual Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFieldLevelEncryption

        internal virtual GetFieldLevelEncryptionResponse GetFieldLevelEncryption(GetFieldLevelEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetFieldLevelEncryption">REST API Reference for GetFieldLevelEncryption Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionResponse> GetFieldLevelEncryptionAsync(GetFieldLevelEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFieldLevelEncryptionConfig

        internal virtual GetFieldLevelEncryptionConfigResponse GetFieldLevelEncryptionConfig(GetFieldLevelEncryptionConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetFieldLevelEncryptionConfig">REST API Reference for GetFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionConfigResponse> GetFieldLevelEncryptionConfigAsync(GetFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFieldLevelEncryptionProfile

        internal virtual GetFieldLevelEncryptionProfileResponse GetFieldLevelEncryptionProfile(GetFieldLevelEncryptionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetFieldLevelEncryptionProfile">REST API Reference for GetFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionProfileResponse> GetFieldLevelEncryptionProfileAsync(GetFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFieldLevelEncryptionProfileConfig

        internal virtual GetFieldLevelEncryptionProfileConfigResponse GetFieldLevelEncryptionProfileConfig(GetFieldLevelEncryptionProfileConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionProfileConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionProfileConfigResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionProfileConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionProfileConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfileConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetFieldLevelEncryptionProfileConfig">REST API Reference for GetFieldLevelEncryptionProfileConfig Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionProfileConfigResponse> GetFieldLevelEncryptionProfileConfigAsync(GetFieldLevelEncryptionProfileConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionProfileConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionProfileConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionProfileConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInvalidation

        internal virtual GetInvalidationResponse GetInvalidation(GetInvalidationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvalidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvalidationResponseUnmarshaller.Instance;

            return Invoke<GetInvalidationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetInvalidation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetInvalidation">REST API Reference for GetInvalidation Operation</seealso>
        public virtual Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvalidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvalidationResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvalidationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPublicKey

        internal virtual GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPublicKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPublicKeyConfig

        internal virtual GetPublicKeyConfigResponse GetPublicKeyConfig(GetPublicKeyConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyConfigResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicKeyConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKeyConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetPublicKeyConfig">REST API Reference for GetPublicKeyConfig Operation</seealso>
        public virtual Task<GetPublicKeyConfigResponse> GetPublicKeyConfigAsync(GetPublicKeyConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetPublicKeyConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStreamingDistribution

        internal virtual GetStreamingDistributionResponse GetStreamingDistribution()
        {
            return GetStreamingDistribution(new GetStreamingDistributionRequest());
        }
        internal virtual GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<GetStreamingDistributionResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a specified RTMP distribution, including the distribution configuration.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        public virtual Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetStreamingDistributionAsync(new GetStreamingDistributionRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        public virtual Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamingDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStreamingDistributionConfig

        internal virtual GetStreamingDistributionConfigResponse GetStreamingDistributionConfig()
        {
            return GetStreamingDistributionConfig(new GetStreamingDistributionConfigRequest());
        }
        internal virtual GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStreamingDistributionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.Instance;

            return Invoke<GetStreamingDistributionConfigResponse>(request, options);
        }


        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        public virtual Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetStreamingDistributionConfigAsync(new GetStreamingDistributionConfigRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        public virtual Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStreamingDistributionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamingDistributionConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCloudFrontOriginAccessIdentities

        internal virtual ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities()
        {
            return ListCloudFrontOriginAccessIdentities(new ListCloudFrontOriginAccessIdentitiesRequest());
        }
        internal virtual ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCloudFrontOriginAccessIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListCloudFrontOriginAccessIdentitiesResponse>(request, options);
        }


        /// <summary>
        /// Lists origin access identities.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        public virtual Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListCloudFrontOriginAccessIdentitiesAsync(new ListCloudFrontOriginAccessIdentitiesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudFrontOriginAccessIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        public virtual Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCloudFrontOriginAccessIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCloudFrontOriginAccessIdentitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDistributions

        internal virtual ListDistributionsResponse ListDistributions()
        {
            return ListDistributions(new ListDistributionsRequest());
        }
        internal virtual ListDistributionsResponse ListDistributions(ListDistributionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDistributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsResponse>(request, options);
        }


        /// <summary>
        /// List distributions.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        public virtual Task<ListDistributionsResponse> ListDistributionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListDistributionsAsync(new ListDistributionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        public virtual Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDistributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDistributionsByWebACLId

        internal virtual ListDistributionsByWebACLIdResponse ListDistributionsByWebACLId(ListDistributionsByWebACLIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDistributionsByWebACLIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByWebACLIdResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByWebACLIdResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByWebACLId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByWebACLId operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListDistributionsByWebACLId">REST API Reference for ListDistributionsByWebACLId Operation</seealso>
        public virtual Task<ListDistributionsByWebACLIdResponse> ListDistributionsByWebACLIdAsync(ListDistributionsByWebACLIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDistributionsByWebACLIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByWebACLIdResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByWebACLIdResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFieldLevelEncryptionConfigs

        internal virtual ListFieldLevelEncryptionConfigsResponse ListFieldLevelEncryptionConfigs(ListFieldLevelEncryptionConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFieldLevelEncryptionConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldLevelEncryptionConfigsResponseUnmarshaller.Instance;

            return Invoke<ListFieldLevelEncryptionConfigsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFieldLevelEncryptionConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListFieldLevelEncryptionConfigs">REST API Reference for ListFieldLevelEncryptionConfigs Operation</seealso>
        public virtual Task<ListFieldLevelEncryptionConfigsResponse> ListFieldLevelEncryptionConfigsAsync(ListFieldLevelEncryptionConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFieldLevelEncryptionConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldLevelEncryptionConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFieldLevelEncryptionConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFieldLevelEncryptionProfiles

        internal virtual ListFieldLevelEncryptionProfilesResponse ListFieldLevelEncryptionProfiles(ListFieldLevelEncryptionProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFieldLevelEncryptionProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldLevelEncryptionProfilesResponseUnmarshaller.Instance;

            return Invoke<ListFieldLevelEncryptionProfilesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFieldLevelEncryptionProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListFieldLevelEncryptionProfiles">REST API Reference for ListFieldLevelEncryptionProfiles Operation</seealso>
        public virtual Task<ListFieldLevelEncryptionProfilesResponse> ListFieldLevelEncryptionProfilesAsync(ListFieldLevelEncryptionProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFieldLevelEncryptionProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldLevelEncryptionProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFieldLevelEncryptionProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInvalidations

        internal virtual ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvalidationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvalidationsResponseUnmarshaller.Instance;

            return Invoke<ListInvalidationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListInvalidations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListInvalidations">REST API Reference for ListInvalidations Operation</seealso>
        public virtual Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvalidationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvalidationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInvalidationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPublicKeys

        internal virtual ListPublicKeysResponse ListPublicKeys(ListPublicKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListPublicKeysResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual Task<ListPublicKeysResponse> ListPublicKeysAsync(ListPublicKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListPublicKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStreamingDistributions

        internal virtual ListStreamingDistributionsResponse ListStreamingDistributions()
        {
            return ListStreamingDistributions(new ListStreamingDistributionsRequest());
        }
        internal virtual ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamingDistributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamingDistributionsResponseUnmarshaller.Instance;

            return Invoke<ListStreamingDistributionsResponse>(request, options);
        }


        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        public virtual Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListStreamingDistributionsAsync(new ListStreamingDistributionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamingDistributions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        public virtual Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamingDistributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamingDistributionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamingDistributionsResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCloudFrontOriginAccessIdentity

        internal virtual UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<UpdateCloudFrontOriginAccessIdentityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/UpdateCloudFrontOriginAccessIdentity">REST API Reference for UpdateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCloudFrontOriginAccessIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDistribution

        internal virtual UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionResponseUnmarshaller.Instance;

            return Invoke<UpdateDistributionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        public virtual Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFieldLevelEncryptionConfig

        internal virtual UpdateFieldLevelEncryptionConfigResponse UpdateFieldLevelEncryptionConfig(UpdateFieldLevelEncryptionConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateFieldLevelEncryptionConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/UpdateFieldLevelEncryptionConfig">REST API Reference for UpdateFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<UpdateFieldLevelEncryptionConfigResponse> UpdateFieldLevelEncryptionConfigAsync(UpdateFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFieldLevelEncryptionConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFieldLevelEncryptionProfile

        internal virtual UpdateFieldLevelEncryptionProfileResponse UpdateFieldLevelEncryptionProfile(UpdateFieldLevelEncryptionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateFieldLevelEncryptionProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/UpdateFieldLevelEncryptionProfile">REST API Reference for UpdateFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<UpdateFieldLevelEncryptionProfileResponse> UpdateFieldLevelEncryptionProfileAsync(UpdateFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFieldLevelEncryptionProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePublicKey

        internal virtual UpdatePublicKeyResponse UpdatePublicKey(UpdatePublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePublicKeyResponseUnmarshaller.Instance;

            return Invoke<UpdatePublicKeyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/UpdatePublicKey">REST API Reference for UpdatePublicKey Operation</seealso>
        public virtual Task<UpdatePublicKeyResponse> UpdatePublicKeyAsync(UpdatePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePublicKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStreamingDistribution

        internal virtual UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<UpdateStreamingDistributionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2018-11-05/UpdateStreamingDistribution">REST API Reference for UpdateStreamingDistribution Operation</seealso>
        public virtual Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStreamingDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}