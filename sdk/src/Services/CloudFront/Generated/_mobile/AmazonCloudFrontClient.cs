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
 * Do not modify this file. This file is generated from the cloudfront-2016-09-07.normal.json service model.
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
    /// Amazon CloudFront is a global content delivery network (CDN) service that accelerates
    /// delivery of your websites, APIs, video content or other web assets. It integrates
    /// with other Amazon Web Services products to give developers and businesses an easy
    /// way to accelerate content to end users with no minimum usage commitments.
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

        internal CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request)
        {
            var marshaller = new CreateCloudFrontOriginAccessIdentityRequestMarshaller();
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
        public Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCloudFrontOriginAccessIdentityRequest,CreateCloudFrontOriginAccessIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDistribution

        internal CreateDistributionResponse CreateDistribution(CreateDistributionRequest request)
        {
            var marshaller = new CreateDistributionRequestMarshaller();
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
        public Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDistributionRequestMarshaller();
            var unmarshaller = CreateDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDistributionRequest,CreateDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDistributionWithTags

        internal CreateDistributionWithTagsResponse CreateDistributionWithTags(CreateDistributionWithTagsRequest request)
        {
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
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
        public Task<CreateDistributionWithTagsResponse> CreateDistributionWithTagsAsync(CreateDistributionWithTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var unmarshaller = CreateDistributionWithTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDistributionWithTagsRequest,CreateDistributionWithTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInvalidation

        internal CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request)
        {
            var marshaller = new CreateInvalidationRequestMarshaller();
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
        public Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInvalidationRequestMarshaller();
            var unmarshaller = CreateInvalidationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInvalidationRequest,CreateInvalidationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStreamingDistribution

        internal CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request)
        {
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
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
        public Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var unmarshaller = CreateStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamingDistributionRequest,CreateStreamingDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStreamingDistributionWithTags

        internal CreateStreamingDistributionWithTagsResponse CreateStreamingDistributionWithTags(CreateStreamingDistributionWithTagsRequest request)
        {
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
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
        public Task<CreateStreamingDistributionWithTagsResponse> CreateStreamingDistributionWithTagsAsync(CreateStreamingDistributionWithTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var unmarshaller = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamingDistributionWithTagsRequest,CreateStreamingDistributionWithTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCloudFrontOriginAccessIdentity

        internal DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity()
        {
            return DeleteCloudFrontOriginAccessIdentity(new DeleteCloudFrontOriginAccessIdentityRequest());
        }
        internal DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request)
        {
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();
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
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCloudFrontOriginAccessIdentityRequest,DeleteCloudFrontOriginAccessIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDistribution

        internal DeleteDistributionResponse DeleteDistribution()
        {
            return DeleteDistribution(new DeleteDistributionRequest());
        }
        internal DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request)
        {
            var marshaller = new DeleteDistributionRequestMarshaller();
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
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public Task<DeleteDistributionResponse> DeleteDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDistributionRequestMarshaller();
            var unmarshaller = DeleteDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDistributionRequest,DeleteDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStreamingDistribution

        internal DeleteStreamingDistributionResponse DeleteStreamingDistribution()
        {
            return DeleteStreamingDistribution(new DeleteStreamingDistributionRequest());
        }
        internal DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request)
        {
            var marshaller = new DeleteStreamingDistributionRequestMarshaller();
            var unmarshaller = DeleteStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamingDistributionRequest,DeleteStreamingDistributionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Delete a streaming distribution.
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
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionNotDisabledException">
        /// 
        /// </exception>
        public Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStreamingDistributionRequestMarshaller();
            var unmarshaller = DeleteStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStreamingDistributionRequest,DeleteStreamingDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentity

        internal GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity()
        {
            return GetCloudFrontOriginAccessIdentity(new GetCloudFrontOriginAccessIdentityRequest());
        }
        internal GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request)
        {
            var marshaller = new GetCloudFrontOriginAccessIdentityRequestMarshaller();
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
        public Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudFrontOriginAccessIdentityRequest,GetCloudFrontOriginAccessIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentityConfig

        internal GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig()
        {
            return GetCloudFrontOriginAccessIdentityConfig(new GetCloudFrontOriginAccessIdentityConfigRequest());
        }
        internal GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request)
        {
            var marshaller = new GetCloudFrontOriginAccessIdentityConfigRequestMarshaller();
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
        public Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCloudFrontOriginAccessIdentityConfigRequestMarshaller();
            var unmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudFrontOriginAccessIdentityConfigRequest,GetCloudFrontOriginAccessIdentityConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDistribution

        internal GetDistributionResponse GetDistribution()
        {
            return GetDistribution(new GetDistributionRequest());
        }
        internal GetDistributionResponse GetDistribution(GetDistributionRequest request)
        {
            var marshaller = new GetDistributionRequestMarshaller();
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
        public Task<GetDistributionResponse> GetDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDistributionRequestMarshaller();
            var unmarshaller = GetDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionRequest,GetDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDistributionConfig

        internal GetDistributionConfigResponse GetDistributionConfig()
        {
            return GetDistributionConfig(new GetDistributionConfigRequest());
        }
        internal GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request)
        {
            var marshaller = new GetDistributionConfigRequestMarshaller();
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
        public Task<GetDistributionConfigResponse> GetDistributionConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDistributionConfigRequestMarshaller();
            var unmarshaller = GetDistributionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionConfigRequest,GetDistributionConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetInvalidation

        internal GetInvalidationResponse GetInvalidation(GetInvalidationRequest request)
        {
            var marshaller = new GetInvalidationRequestMarshaller();
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
        public Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetInvalidationRequestMarshaller();
            var unmarshaller = GetInvalidationResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvalidationRequest,GetInvalidationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetStreamingDistribution

        internal GetStreamingDistributionResponse GetStreamingDistribution()
        {
            return GetStreamingDistribution(new GetStreamingDistributionRequest());
        }
        internal GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request)
        {
            var marshaller = new GetStreamingDistributionRequestMarshaller();
            var unmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<GetStreamingDistributionRequest,GetStreamingDistributionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Get the information about a streaming distribution.
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
        public Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStreamingDistributionRequestMarshaller();
            var unmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamingDistributionRequest,GetStreamingDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetStreamingDistributionConfig

        internal GetStreamingDistributionConfigResponse GetStreamingDistributionConfig()
        {
            return GetStreamingDistributionConfig(new GetStreamingDistributionConfigRequest());
        }
        internal GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request)
        {
            var marshaller = new GetStreamingDistributionConfigRequestMarshaller();
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
        public Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStreamingDistributionConfigRequestMarshaller();
            var unmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamingDistributionConfigRequest,GetStreamingDistributionConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCloudFrontOriginAccessIdentities

        internal ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities()
        {
            return ListCloudFrontOriginAccessIdentities(new ListCloudFrontOriginAccessIdentitiesRequest());
        }
        internal ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request)
        {
            var marshaller = new ListCloudFrontOriginAccessIdentitiesRequestMarshaller();
            var unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListCloudFrontOriginAccessIdentitiesRequest,ListCloudFrontOriginAccessIdentitiesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// List origin access identities.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListCloudFrontOriginAccessIdentitiesRequestMarshaller();
            var unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCloudFrontOriginAccessIdentitiesRequest,ListCloudFrontOriginAccessIdentitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDistributions

        internal ListDistributionsResponse ListDistributions()
        {
            return ListDistributions(new ListDistributionsRequest());
        }
        internal ListDistributionsResponse ListDistributions(ListDistributionsRequest request)
        {
            var marshaller = new ListDistributionsRequestMarshaller();
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
        public Task<ListDistributionsResponse> ListDistributionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDistributionsRequestMarshaller();
            var unmarshaller = ListDistributionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsRequest,ListDistributionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDistributionsByWebACLId

        internal ListDistributionsByWebACLIdResponse ListDistributionsByWebACLId(ListDistributionsByWebACLIdRequest request)
        {
            var marshaller = new ListDistributionsByWebACLIdRequestMarshaller();
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
        public Task<ListDistributionsByWebACLIdResponse> ListDistributionsByWebACLIdAsync(ListDistributionsByWebACLIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDistributionsByWebACLIdRequestMarshaller();
            var unmarshaller = ListDistributionsByWebACLIdResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByWebACLIdRequest,ListDistributionsByWebACLIdResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInvalidations

        internal ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request)
        {
            var marshaller = new ListInvalidationsRequestMarshaller();
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
        public Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListInvalidationsRequestMarshaller();
            var unmarshaller = ListInvalidationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInvalidationsRequest,ListInvalidationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStreamingDistributions

        internal ListStreamingDistributionsResponse ListStreamingDistributions()
        {
            return ListStreamingDistributions(new ListStreamingDistributionsRequest());
        }
        internal ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request)
        {
            var marshaller = new ListStreamingDistributionsRequestMarshaller();
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
        public Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStreamingDistributionsRequestMarshaller();
            var unmarshaller = ListStreamingDistributionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamingDistributionsRequest,ListStreamingDistributionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
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
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = new TagResourceRequestMarshaller();
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
        public Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TagResourceRequestMarshaller();
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = new UntagResourceRequestMarshaller();
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
        public Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UntagResourceRequestMarshaller();
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCloudFrontOriginAccessIdentity

        internal UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request)
        {
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
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
        public Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCloudFrontOriginAccessIdentityRequest,UpdateCloudFrontOriginAccessIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDistribution

        internal UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request)
        {
            var marshaller = new UpdateDistributionRequestMarshaller();
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
        public Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDistributionRequestMarshaller();
            var unmarshaller = UpdateDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDistributionRequest,UpdateDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateStreamingDistribution

        internal UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request)
        {
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
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
        public Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStreamingDistributionRequest,UpdateStreamingDistributionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}