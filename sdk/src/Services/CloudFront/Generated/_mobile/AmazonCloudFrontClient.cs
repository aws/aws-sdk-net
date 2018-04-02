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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudFront.Model;
using Amazon.CloudFront.Model.Internal.MarshallTransformations;
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
            var marshaller = CreateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<CreateCloudFrontOriginAccessIdentityRequest,CreateCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateCloudFrontOriginAccessIdentity">REST API Reference for CreateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCloudFrontOriginAccessIdentityRequest,CreateCloudFrontOriginAccessIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDistribution

        internal virtual CreateDistributionResponse CreateDistribution(CreateDistributionRequest request)
        {
            var marshaller = CreateDistributionRequestMarshaller.Instance;
            var unmarshaller = CreateDistributionResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionRequest,CreateDistributionResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        public virtual Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDistributionRequestMarshaller.Instance;
            var unmarshaller = CreateDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDistributionRequest,CreateDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDistributionWithTags

        internal virtual CreateDistributionWithTagsResponse CreateDistributionWithTags(CreateDistributionWithTagsRequest request)
        {
            var marshaller = CreateDistributionWithTagsRequestMarshaller.Instance;
            var unmarshaller = CreateDistributionWithTagsResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionWithTagsRequest,CreateDistributionWithTagsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistributionWithTags">REST API Reference for CreateDistributionWithTags Operation</seealso>
        public virtual Task<CreateDistributionWithTagsResponse> CreateDistributionWithTagsAsync(CreateDistributionWithTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDistributionWithTagsRequestMarshaller.Instance;
            var unmarshaller = CreateDistributionWithTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDistributionWithTagsRequest,CreateDistributionWithTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFieldLevelEncryptionConfig

        internal virtual CreateFieldLevelEncryptionConfigResponse CreateFieldLevelEncryptionConfig(CreateFieldLevelEncryptionConfigRequest request)
        {
            var marshaller = CreateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<CreateFieldLevelEncryptionConfigRequest,CreateFieldLevelEncryptionConfigResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionConfig">REST API Reference for CreateFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<CreateFieldLevelEncryptionConfigResponse> CreateFieldLevelEncryptionConfigAsync(CreateFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFieldLevelEncryptionConfigRequest,CreateFieldLevelEncryptionConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFieldLevelEncryptionProfile

        internal virtual CreateFieldLevelEncryptionProfileResponse CreateFieldLevelEncryptionProfile(CreateFieldLevelEncryptionProfileRequest request)
        {
            var marshaller = CreateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<CreateFieldLevelEncryptionProfileRequest,CreateFieldLevelEncryptionProfileResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionProfile">REST API Reference for CreateFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<CreateFieldLevelEncryptionProfileResponse> CreateFieldLevelEncryptionProfileAsync(CreateFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFieldLevelEncryptionProfileRequest,CreateFieldLevelEncryptionProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInvalidation

        internal virtual CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request)
        {
            var marshaller = CreateInvalidationRequestMarshaller.Instance;
            var unmarshaller = CreateInvalidationResponseUnmarshaller.Instance;

            return Invoke<CreateInvalidationRequest,CreateInvalidationResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateInvalidation">REST API Reference for CreateInvalidation Operation</seealso>
        public virtual Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateInvalidationRequestMarshaller.Instance;
            var unmarshaller = CreateInvalidationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInvalidationRequest,CreateInvalidationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePublicKey

        internal virtual CreatePublicKeyResponse CreatePublicKey(CreatePublicKeyRequest request)
        {
            var marshaller = CreatePublicKeyRequestMarshaller.Instance;
            var unmarshaller = CreatePublicKeyResponseUnmarshaller.Instance;

            return Invoke<CreatePublicKeyRequest,CreatePublicKeyResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreatePublicKey">REST API Reference for CreatePublicKey Operation</seealso>
        public virtual Task<CreatePublicKeyResponse> CreatePublicKeyAsync(CreatePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreatePublicKeyRequestMarshaller.Instance;
            var unmarshaller = CreatePublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePublicKeyRequest,CreatePublicKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStreamingDistribution

        internal virtual CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request)
        {
            var marshaller = CreateStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = CreateStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingDistributionRequest,CreateStreamingDistributionResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistribution">REST API Reference for CreateStreamingDistribution Operation</seealso>
        public virtual Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = CreateStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamingDistributionRequest,CreateStreamingDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStreamingDistributionWithTags

        internal virtual CreateStreamingDistributionWithTagsResponse CreateStreamingDistributionWithTags(CreateStreamingDistributionWithTagsRequest request)
        {
            var marshaller = CreateStreamingDistributionWithTagsRequestMarshaller.Instance;
            var unmarshaller = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingDistributionWithTagsRequest,CreateStreamingDistributionWithTagsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistributionWithTags">REST API Reference for CreateStreamingDistributionWithTags Operation</seealso>
        public virtual Task<CreateStreamingDistributionWithTagsResponse> CreateStreamingDistributionWithTagsAsync(CreateStreamingDistributionWithTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateStreamingDistributionWithTagsRequestMarshaller.Instance;
            var unmarshaller = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamingDistributionWithTagsRequest,CreateStreamingDistributionWithTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCloudFrontOriginAccessIdentity

        internal virtual DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity()
        {
            return DeleteCloudFrontOriginAccessIdentity(new DeleteCloudFrontOriginAccessIdentityRequest());
        }
        internal virtual DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request)
        {
            var marshaller = DeleteCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudFrontOriginAccessIdentityRequest,DeleteCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCloudFrontOriginAccessIdentityRequest,DeleteCloudFrontOriginAccessIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDistribution

        internal virtual DeleteDistributionResponse DeleteDistribution()
        {
            return DeleteDistribution(new DeleteDistributionRequest());
        }
        internal virtual DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request)
        {
            var marshaller = DeleteDistributionRequestMarshaller.Instance;
            var unmarshaller = DeleteDistributionResponseUnmarshaller.Instance;

            return Invoke<DeleteDistributionRequest,DeleteDistributionResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        public virtual Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDistributionRequestMarshaller.Instance;
            var unmarshaller = DeleteDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDistributionRequest,DeleteDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFieldLevelEncryptionConfig

        internal virtual DeleteFieldLevelEncryptionConfigResponse DeleteFieldLevelEncryptionConfig(DeleteFieldLevelEncryptionConfigRequest request)
        {
            var marshaller = DeleteFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteFieldLevelEncryptionConfigRequest,DeleteFieldLevelEncryptionConfigResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionConfig">REST API Reference for DeleteFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<DeleteFieldLevelEncryptionConfigResponse> DeleteFieldLevelEncryptionConfigAsync(DeleteFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFieldLevelEncryptionConfigRequest,DeleteFieldLevelEncryptionConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFieldLevelEncryptionProfile

        internal virtual DeleteFieldLevelEncryptionProfileResponse DeleteFieldLevelEncryptionProfile(DeleteFieldLevelEncryptionProfileRequest request)
        {
            var marshaller = DeleteFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteFieldLevelEncryptionProfileRequest,DeleteFieldLevelEncryptionProfileResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionProfile">REST API Reference for DeleteFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<DeleteFieldLevelEncryptionProfileResponse> DeleteFieldLevelEncryptionProfileAsync(DeleteFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFieldLevelEncryptionProfileRequest,DeleteFieldLevelEncryptionProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePublicKey

        internal virtual DeletePublicKeyResponse DeletePublicKey(DeletePublicKeyRequest request)
        {
            var marshaller = DeletePublicKeyRequestMarshaller.Instance;
            var unmarshaller = DeletePublicKeyResponseUnmarshaller.Instance;

            return Invoke<DeletePublicKeyRequest,DeletePublicKeyResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        public virtual Task<DeletePublicKeyResponse> DeletePublicKeyAsync(DeletePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeletePublicKeyRequestMarshaller.Instance;
            var unmarshaller = DeletePublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePublicKeyRequest,DeletePublicKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceLinkedRole

        internal virtual DeleteServiceLinkedRoleResponse DeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest request)
        {
            var marshaller = DeleteServiceLinkedRoleRequestMarshaller.Instance;
            var unmarshaller = DeleteServiceLinkedRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceLinkedRoleRequest,DeleteServiceLinkedRoleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        public virtual Task<DeleteServiceLinkedRoleResponse> DeleteServiceLinkedRoleAsync(DeleteServiceLinkedRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteServiceLinkedRoleRequestMarshaller.Instance;
            var unmarshaller = DeleteServiceLinkedRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServiceLinkedRoleRequest,DeleteServiceLinkedRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStreamingDistribution

        internal virtual DeleteStreamingDistributionResponse DeleteStreamingDistribution()
        {
            return DeleteStreamingDistribution(new DeleteStreamingDistributionRequest());
        }
        internal virtual DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request)
        {
            var marshaller = DeleteStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = DeleteStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamingDistributionRequest,DeleteStreamingDistributionResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        public virtual Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = DeleteStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStreamingDistributionRequest,DeleteStreamingDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentity

        internal virtual GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity()
        {
            return GetCloudFrontOriginAccessIdentity(new GetCloudFrontOriginAccessIdentityRequest());
        }
        internal virtual GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request)
        {
            var marshaller = GetCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<GetCloudFrontOriginAccessIdentityRequest,GetCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudFrontOriginAccessIdentityRequest,GetCloudFrontOriginAccessIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentityConfig

        internal virtual GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig()
        {
            return GetCloudFrontOriginAccessIdentityConfig(new GetCloudFrontOriginAccessIdentityConfigRequest());
        }
        internal virtual GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request)
        {
            var marshaller = GetCloudFrontOriginAccessIdentityConfigRequestMarshaller.Instance;
            var unmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance;

            return Invoke<GetCloudFrontOriginAccessIdentityConfigRequest,GetCloudFrontOriginAccessIdentityConfigResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        public virtual Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCloudFrontOriginAccessIdentityConfigRequestMarshaller.Instance;
            var unmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudFrontOriginAccessIdentityConfigRequest,GetCloudFrontOriginAccessIdentityConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDistribution

        internal virtual GetDistributionResponse GetDistribution()
        {
            return GetDistribution(new GetDistributionRequest());
        }
        internal virtual GetDistributionResponse GetDistribution(GetDistributionRequest request)
        {
            var marshaller = GetDistributionRequestMarshaller.Instance;
            var unmarshaller = GetDistributionResponseUnmarshaller.Instance;

            return Invoke<GetDistributionRequest,GetDistributionResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        public virtual Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDistributionRequestMarshaller.Instance;
            var unmarshaller = GetDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionRequest,GetDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDistributionConfig

        internal virtual GetDistributionConfigResponse GetDistributionConfig()
        {
            return GetDistributionConfig(new GetDistributionConfigRequest());
        }
        internal virtual GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request)
        {
            var marshaller = GetDistributionConfigRequestMarshaller.Instance;
            var unmarshaller = GetDistributionConfigResponseUnmarshaller.Instance;

            return Invoke<GetDistributionConfigRequest,GetDistributionConfigResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        public virtual Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDistributionConfigRequestMarshaller.Instance;
            var unmarshaller = GetDistributionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionConfigRequest,GetDistributionConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFieldLevelEncryption

        internal virtual GetFieldLevelEncryptionResponse GetFieldLevelEncryption(GetFieldLevelEncryptionRequest request)
        {
            var marshaller = GetFieldLevelEncryptionRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionRequest,GetFieldLevelEncryptionResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryption">REST API Reference for GetFieldLevelEncryption Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionResponse> GetFieldLevelEncryptionAsync(GetFieldLevelEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFieldLevelEncryptionRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionRequest,GetFieldLevelEncryptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFieldLevelEncryptionConfig

        internal virtual GetFieldLevelEncryptionConfigResponse GetFieldLevelEncryptionConfig(GetFieldLevelEncryptionConfigRequest request)
        {
            var marshaller = GetFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionConfigRequest,GetFieldLevelEncryptionConfigResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionConfig">REST API Reference for GetFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionConfigResponse> GetFieldLevelEncryptionConfigAsync(GetFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionConfigRequest,GetFieldLevelEncryptionConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFieldLevelEncryptionProfile

        internal virtual GetFieldLevelEncryptionProfileResponse GetFieldLevelEncryptionProfile(GetFieldLevelEncryptionProfileRequest request)
        {
            var marshaller = GetFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionProfileRequest,GetFieldLevelEncryptionProfileResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfile">REST API Reference for GetFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionProfileResponse> GetFieldLevelEncryptionProfileAsync(GetFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionProfileRequest,GetFieldLevelEncryptionProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFieldLevelEncryptionProfileConfig

        internal virtual GetFieldLevelEncryptionProfileConfigResponse GetFieldLevelEncryptionProfileConfig(GetFieldLevelEncryptionProfileConfigRequest request)
        {
            var marshaller = GetFieldLevelEncryptionProfileConfigRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionProfileConfigResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionProfileConfigRequest,GetFieldLevelEncryptionProfileConfigResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfileConfig">REST API Reference for GetFieldLevelEncryptionProfileConfig Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionProfileConfigResponse> GetFieldLevelEncryptionProfileConfigAsync(GetFieldLevelEncryptionProfileConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFieldLevelEncryptionProfileConfigRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionProfileConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionProfileConfigRequest,GetFieldLevelEncryptionProfileConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetInvalidation

        internal virtual GetInvalidationResponse GetInvalidation(GetInvalidationRequest request)
        {
            var marshaller = GetInvalidationRequestMarshaller.Instance;
            var unmarshaller = GetInvalidationResponseUnmarshaller.Instance;

            return Invoke<GetInvalidationRequest,GetInvalidationResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetInvalidation">REST API Reference for GetInvalidation Operation</seealso>
        public virtual Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetInvalidationRequestMarshaller.Instance;
            var unmarshaller = GetInvalidationResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvalidationRequest,GetInvalidationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPublicKey

        internal virtual GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request)
        {
            var marshaller = GetPublicKeyRequestMarshaller.Instance;
            var unmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyRequest,GetPublicKeyResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetPublicKeyRequestMarshaller.Instance;
            var unmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPublicKeyRequest,GetPublicKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPublicKeyConfig

        internal virtual GetPublicKeyConfigResponse GetPublicKeyConfig(GetPublicKeyConfigRequest request)
        {
            var marshaller = GetPublicKeyConfigRequestMarshaller.Instance;
            var unmarshaller = GetPublicKeyConfigResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyConfigRequest,GetPublicKeyConfigResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKeyConfig">REST API Reference for GetPublicKeyConfig Operation</seealso>
        public virtual Task<GetPublicKeyConfigResponse> GetPublicKeyConfigAsync(GetPublicKeyConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetPublicKeyConfigRequestMarshaller.Instance;
            var unmarshaller = GetPublicKeyConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetPublicKeyConfigRequest,GetPublicKeyConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetStreamingDistribution

        internal virtual GetStreamingDistributionResponse GetStreamingDistribution()
        {
            return GetStreamingDistribution(new GetStreamingDistributionRequest());
        }
        internal virtual GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request)
        {
            var marshaller = GetStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<GetStreamingDistributionRequest,GetStreamingDistributionResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        public virtual Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamingDistributionRequest,GetStreamingDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetStreamingDistributionConfig

        internal virtual GetStreamingDistributionConfigResponse GetStreamingDistributionConfig()
        {
            return GetStreamingDistributionConfig(new GetStreamingDistributionConfigRequest());
        }
        internal virtual GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request)
        {
            var marshaller = GetStreamingDistributionConfigRequestMarshaller.Instance;
            var unmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.Instance;

            return Invoke<GetStreamingDistributionConfigRequest,GetStreamingDistributionConfigResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        public virtual Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetStreamingDistributionConfigRequestMarshaller.Instance;
            var unmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamingDistributionConfigRequest,GetStreamingDistributionConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCloudFrontOriginAccessIdentities

        internal virtual ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities()
        {
            return ListCloudFrontOriginAccessIdentities(new ListCloudFrontOriginAccessIdentitiesRequest());
        }
        internal virtual ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request)
        {
            var marshaller = ListCloudFrontOriginAccessIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListCloudFrontOriginAccessIdentitiesRequest,ListCloudFrontOriginAccessIdentitiesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        public virtual Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListCloudFrontOriginAccessIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCloudFrontOriginAccessIdentitiesRequest,ListCloudFrontOriginAccessIdentitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDistributions

        internal virtual ListDistributionsResponse ListDistributions()
        {
            return ListDistributions(new ListDistributionsRequest());
        }
        internal virtual ListDistributionsResponse ListDistributions(ListDistributionsRequest request)
        {
            var marshaller = ListDistributionsRequestMarshaller.Instance;
            var unmarshaller = ListDistributionsResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsRequest,ListDistributionsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        public virtual Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDistributionsRequestMarshaller.Instance;
            var unmarshaller = ListDistributionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsRequest,ListDistributionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDistributionsByWebACLId

        internal virtual ListDistributionsByWebACLIdResponse ListDistributionsByWebACLId(ListDistributionsByWebACLIdRequest request)
        {
            var marshaller = ListDistributionsByWebACLIdRequestMarshaller.Instance;
            var unmarshaller = ListDistributionsByWebACLIdResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByWebACLIdRequest,ListDistributionsByWebACLIdResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributionsByWebACLId">REST API Reference for ListDistributionsByWebACLId Operation</seealso>
        public virtual Task<ListDistributionsByWebACLIdResponse> ListDistributionsByWebACLIdAsync(ListDistributionsByWebACLIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDistributionsByWebACLIdRequestMarshaller.Instance;
            var unmarshaller = ListDistributionsByWebACLIdResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByWebACLIdRequest,ListDistributionsByWebACLIdResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFieldLevelEncryptionConfigs

        internal virtual ListFieldLevelEncryptionConfigsResponse ListFieldLevelEncryptionConfigs(ListFieldLevelEncryptionConfigsRequest request)
        {
            var marshaller = ListFieldLevelEncryptionConfigsRequestMarshaller.Instance;
            var unmarshaller = ListFieldLevelEncryptionConfigsResponseUnmarshaller.Instance;

            return Invoke<ListFieldLevelEncryptionConfigsRequest,ListFieldLevelEncryptionConfigsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionConfigs">REST API Reference for ListFieldLevelEncryptionConfigs Operation</seealso>
        public virtual Task<ListFieldLevelEncryptionConfigsResponse> ListFieldLevelEncryptionConfigsAsync(ListFieldLevelEncryptionConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListFieldLevelEncryptionConfigsRequestMarshaller.Instance;
            var unmarshaller = ListFieldLevelEncryptionConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFieldLevelEncryptionConfigsRequest,ListFieldLevelEncryptionConfigsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFieldLevelEncryptionProfiles

        internal virtual ListFieldLevelEncryptionProfilesResponse ListFieldLevelEncryptionProfiles(ListFieldLevelEncryptionProfilesRequest request)
        {
            var marshaller = ListFieldLevelEncryptionProfilesRequestMarshaller.Instance;
            var unmarshaller = ListFieldLevelEncryptionProfilesResponseUnmarshaller.Instance;

            return Invoke<ListFieldLevelEncryptionProfilesRequest,ListFieldLevelEncryptionProfilesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionProfiles">REST API Reference for ListFieldLevelEncryptionProfiles Operation</seealso>
        public virtual Task<ListFieldLevelEncryptionProfilesResponse> ListFieldLevelEncryptionProfilesAsync(ListFieldLevelEncryptionProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListFieldLevelEncryptionProfilesRequestMarshaller.Instance;
            var unmarshaller = ListFieldLevelEncryptionProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFieldLevelEncryptionProfilesRequest,ListFieldLevelEncryptionProfilesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInvalidations

        internal virtual ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request)
        {
            var marshaller = ListInvalidationsRequestMarshaller.Instance;
            var unmarshaller = ListInvalidationsResponseUnmarshaller.Instance;

            return Invoke<ListInvalidationsRequest,ListInvalidationsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListInvalidations">REST API Reference for ListInvalidations Operation</seealso>
        public virtual Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListInvalidationsRequestMarshaller.Instance;
            var unmarshaller = ListInvalidationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInvalidationsRequest,ListInvalidationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPublicKeys

        internal virtual ListPublicKeysResponse ListPublicKeys(ListPublicKeysRequest request)
        {
            var marshaller = ListPublicKeysRequestMarshaller.Instance;
            var unmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListPublicKeysRequest,ListPublicKeysResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual Task<ListPublicKeysResponse> ListPublicKeysAsync(ListPublicKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPublicKeysRequestMarshaller.Instance;
            var unmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListPublicKeysRequest,ListPublicKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStreamingDistributions

        internal virtual ListStreamingDistributionsResponse ListStreamingDistributions()
        {
            return ListStreamingDistributions(new ListStreamingDistributionsRequest());
        }
        internal virtual ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request)
        {
            var marshaller = ListStreamingDistributionsRequestMarshaller.Instance;
            var unmarshaller = ListStreamingDistributionsResponseUnmarshaller.Instance;

            return Invoke<ListStreamingDistributionsRequest,ListStreamingDistributionsResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        public virtual Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListStreamingDistributionsRequestMarshaller.Instance;
            var unmarshaller = ListStreamingDistributionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamingDistributionsRequest,ListStreamingDistributionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCloudFrontOriginAccessIdentity

        internal virtual UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request)
        {
            var marshaller = UpdateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<UpdateCloudFrontOriginAccessIdentityRequest,UpdateCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateCloudFrontOriginAccessIdentity">REST API Reference for UpdateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCloudFrontOriginAccessIdentityRequest,UpdateCloudFrontOriginAccessIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDistribution

        internal virtual UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request)
        {
            var marshaller = UpdateDistributionRequestMarshaller.Instance;
            var unmarshaller = UpdateDistributionResponseUnmarshaller.Instance;

            return Invoke<UpdateDistributionRequest,UpdateDistributionResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        public virtual Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDistributionRequestMarshaller.Instance;
            var unmarshaller = UpdateDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDistributionRequest,UpdateDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFieldLevelEncryptionConfig

        internal virtual UpdateFieldLevelEncryptionConfigResponse UpdateFieldLevelEncryptionConfig(UpdateFieldLevelEncryptionConfigRequest request)
        {
            var marshaller = UpdateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateFieldLevelEncryptionConfigRequest,UpdateFieldLevelEncryptionConfigResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionConfig">REST API Reference for UpdateFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<UpdateFieldLevelEncryptionConfigResponse> UpdateFieldLevelEncryptionConfigAsync(UpdateFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFieldLevelEncryptionConfigRequest,UpdateFieldLevelEncryptionConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFieldLevelEncryptionProfile

        internal virtual UpdateFieldLevelEncryptionProfileResponse UpdateFieldLevelEncryptionProfile(UpdateFieldLevelEncryptionProfileRequest request)
        {
            var marshaller = UpdateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateFieldLevelEncryptionProfileRequest,UpdateFieldLevelEncryptionProfileResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionProfile">REST API Reference for UpdateFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<UpdateFieldLevelEncryptionProfileResponse> UpdateFieldLevelEncryptionProfileAsync(UpdateFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFieldLevelEncryptionProfileRequest,UpdateFieldLevelEncryptionProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdatePublicKey

        internal virtual UpdatePublicKeyResponse UpdatePublicKey(UpdatePublicKeyRequest request)
        {
            var marshaller = UpdatePublicKeyRequestMarshaller.Instance;
            var unmarshaller = UpdatePublicKeyResponseUnmarshaller.Instance;

            return Invoke<UpdatePublicKeyRequest,UpdatePublicKeyResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdatePublicKey">REST API Reference for UpdatePublicKey Operation</seealso>
        public virtual Task<UpdatePublicKeyResponse> UpdatePublicKeyAsync(UpdatePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdatePublicKeyRequestMarshaller.Instance;
            var unmarshaller = UpdatePublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePublicKeyRequest,UpdatePublicKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateStreamingDistribution

        internal virtual UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request)
        {
            var marshaller = UpdateStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<UpdateStreamingDistributionRequest,UpdateStreamingDistributionResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateStreamingDistribution">REST API Reference for UpdateStreamingDistribution Operation</seealso>
        public virtual Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStreamingDistributionRequest,UpdateStreamingDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}