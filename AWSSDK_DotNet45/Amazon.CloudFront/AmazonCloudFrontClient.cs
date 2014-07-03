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


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

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
    /// 
    /// </summary>
    public partial class AmazonCloudFrontClient : AmazonWebServiceClient, IAmazonCloudFront
    {
        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  CreateCloudFrontOriginAccessIdentity


        /// <summary>
        /// Create a new origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the CreateCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="CloudFrontOriginAccessIdentityAlreadyExistsException">
        /// If the CallerReference is a value you already sent in a previous request to create
        /// an identity but the content of the CloudFrontOriginAccessIdentityConfig is different
        /// from the original request,    CloudFront returns a CloudFrontOriginAccessIdentityAlreadyExists
        /// error.
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="TooManyCloudFrontOriginAccessIdentitiesException">
        /// Processing your request would cause you to exceed the maximum number of origin access
        /// identities allowed.
        /// </exception>
        public CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request)
        {
            var task = CreateCloudFrontOriginAccessIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateCloudFrontOriginAccessIdentityRequest, CreateCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateDistribution


        /// <summary>
        /// Create a new distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution service method.</param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="DistributionAlreadyExistsException">
        /// The caller reference you attempted to create the distribution with is associated with
        /// another distribution.
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="InvalidErrorCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the whitelisted    list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names    is missing when expected.
        /// </exception>
        /// <exception cref="InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="InvalidHeadersForS3OriginException">
        /// 
        /// </exception>
        /// <exception cref="InvalidLocationCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or    does not begin with a slash
        /// (/).
        /// </exception>
        /// <exception cref="InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the RequiredProtocols element from your distribution configuration.
        /// </exception>
        /// <exception cref="InvalidResponseCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidViewerCertificateException">
        /// 
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="NoSuchOriginException">
        /// No origin exists with the specified Origin Id.
        /// </exception>
        /// <exception cref="TooManyCacheBehaviorsException">
        /// You cannot create anymore cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="TooManyCertificatesException">
        /// You cannot create anymore custom ssl certificates.
        /// </exception>
        /// <exception cref="TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="TooManyOriginsException">
        /// You cannot create anymore origins for the distribution.
        /// </exception>
        /// <exception cref="TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        public CreateDistributionResponse CreateDistribution(CreateDistributionRequest request)
        {
            var task = CreateDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDistributionRequestMarshaller();
            var unmarshaller = CreateDistributionResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateDistributionRequest, CreateDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateInvalidation


        /// <summary>
        /// Create a new invalidation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation service method.</param>
        /// 
        /// <returns>The response from the CreateInvalidation service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="BatchTooLargeException">
        /// 
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="TooManyInvalidationsInProgressException">
        /// You have exceeded the maximum number of allowable InProgress invalidation batch requests,
        /// or invalidation objects.
        /// </exception>
        public CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request)
        {
            var task = CreateInvalidationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInvalidationRequestMarshaller();
            var unmarshaller = CreateInvalidationResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateInvalidationRequest, CreateInvalidationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateStreamingDistribution


        /// <summary>
        /// Create a new streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="StreamingDistributionAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="TooManyStreamingDistributionCNAMEsException">
        /// 
        /// </exception>
        /// <exception cref="TooManyStreamingDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of streaming
        /// distributions allowed.
        /// </exception>
        /// <exception cref="TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        public CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request)
        {
            var task = CreateStreamingDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var unmarshaller = CreateStreamingDistributionResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateStreamingDistributionRequest, CreateStreamingDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteCloudFrontOriginAccessIdentity

        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CloudFrontOriginAccessIdentityInUseException">
        /// 
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity()
        {
            return DeleteCloudFrontOriginAccessIdentity(new DeleteCloudFrontOriginAccessIdentityRequest());
        }

        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CloudFrontOriginAccessIdentityInUseException">
        /// 
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request)
        {
            var task = DeleteCloudFrontOriginAccessIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteCloudFrontOriginAccessIdentityRequest, DeleteCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteDistribution

        /// <summary>
        /// Delete a distribution.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="DistributionNotDisabledException">
        /// 
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public DeleteDistributionResponse DeleteDistribution()
        {
            return DeleteDistribution(new DeleteDistributionRequest());
        }

        /// <summary>
        /// Delete a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution service method.</param>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="DistributionNotDisabledException">
        /// 
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request)
        {
            var task = DeleteDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDistributionRequestMarshaller();
            var unmarshaller = DeleteDistributionResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteDistributionRequest, DeleteDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteStreamingDistribution

        /// <summary>
        /// Delete a streaming distribution.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        /// <exception cref="StreamingDistributionNotDisabledException">
        /// 
        /// </exception>
        public DeleteStreamingDistributionResponse DeleteStreamingDistribution()
        {
            return DeleteStreamingDistribution(new DeleteStreamingDistributionRequest());
        }

        /// <summary>
        /// Delete a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the DeleteStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        /// <exception cref="StreamingDistributionNotDisabledException">
        /// 
        /// </exception>
        public DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request)
        {
            var task = DeleteStreamingDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStreamingDistributionRequestMarshaller();
            var unmarshaller = DeleteStreamingDistributionResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteStreamingDistributionRequest, DeleteStreamingDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentity

        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        public GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity()
        {
            return GetCloudFrontOriginAccessIdentity(new GetCloudFrontOriginAccessIdentityRequest());
        }

        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        public GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request)
        {
            var task = GetCloudFrontOriginAccessIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;
            return Invoke<IRequest, GetCloudFrontOriginAccessIdentityRequest, GetCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentityConfig

        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        public GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig()
        {
            return GetCloudFrontOriginAccessIdentityConfig(new GetCloudFrontOriginAccessIdentityConfigRequest());
        }

        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig service method.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        public GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request)
        {
            var task = GetCloudFrontOriginAccessIdentityConfigAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentityConfig operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCloudFrontOriginAccessIdentityConfigRequestMarshaller();
            var unmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance;
            return Invoke<IRequest, GetCloudFrontOriginAccessIdentityConfigRequest, GetCloudFrontOriginAccessIdentityConfigResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  GetDistribution

        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        public GetDistributionResponse GetDistribution()
        {
            return GetDistribution(new GetDistributionRequest());
        }

        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution service method.</param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        public GetDistributionResponse GetDistribution(GetDistributionRequest request)
        {
            var task = GetDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDistributionRequestMarshaller();
            var unmarshaller = GetDistributionResponseUnmarshaller.Instance;
            return Invoke<IRequest, GetDistributionRequest, GetDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  GetDistributionConfig

        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        public GetDistributionConfigResponse GetDistributionConfig()
        {
            return GetDistributionConfig(new GetDistributionConfigRequest());
        }

        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig service method.</param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        public GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request)
        {
            var task = GetDistributionConfigAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDistributionConfigRequestMarshaller();
            var unmarshaller = GetDistributionConfigResponseUnmarshaller.Instance;
            return Invoke<IRequest, GetDistributionConfigRequest, GetDistributionConfigResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  GetInvalidation


        /// <summary>
        /// Get the information about an invalidation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation service method.</param>
        /// 
        /// <returns>The response from the GetInvalidation service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="NoSuchInvalidationException">
        /// The specified invalidation does not exist.
        /// </exception>
        public GetInvalidationResponse GetInvalidation(GetInvalidationRequest request)
        {
            var task = GetInvalidationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetInvalidationRequestMarshaller();
            var unmarshaller = GetInvalidationResponseUnmarshaller.Instance;
            return Invoke<IRequest, GetInvalidationRequest, GetInvalidationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  GetStreamingDistribution

        /// <summary>
        /// Get the information about a streaming distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        public GetStreamingDistributionResponse GetStreamingDistribution()
        {
            return GetStreamingDistribution(new GetStreamingDistributionRequest());
        }

        /// <summary>
        /// Get the information about a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        public GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request)
        {
            var task = GetStreamingDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStreamingDistributionRequestMarshaller();
            var unmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;
            return Invoke<IRequest, GetStreamingDistributionRequest, GetStreamingDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  GetStreamingDistributionConfig

        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        public GetStreamingDistributionConfigResponse GetStreamingDistributionConfig()
        {
            return GetStreamingDistributionConfig(new GetStreamingDistributionConfigRequest());
        }

        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig service method.</param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        public GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request)
        {
            var task = GetStreamingDistributionConfigAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStreamingDistributionConfigRequestMarshaller();
            var unmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.Instance;
            return Invoke<IRequest, GetStreamingDistributionConfigRequest, GetStreamingDistributionConfigResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ListCloudFrontOriginAccessIdentities

        /// <summary>
        /// List origin access identities.
        /// </summary>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities()
        {
            return ListCloudFrontOriginAccessIdentities(new ListCloudFrontOriginAccessIdentitiesRequest());
        }

        /// <summary>
        /// List origin access identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities service method.</param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request)
        {
            var task = ListCloudFrontOriginAccessIdentitiesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudFrontOriginAccessIdentities operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListCloudFrontOriginAccessIdentitiesRequestMarshaller();
            var unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;
            return Invoke<IRequest, ListCloudFrontOriginAccessIdentitiesRequest, ListCloudFrontOriginAccessIdentitiesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ListDistributions

        /// <summary>
        /// List distributions.
        /// </summary>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListDistributionsResponse ListDistributions()
        {
            return ListDistributions(new ListDistributionsRequest());
        }

        /// <summary>
        /// List distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions service method.</param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListDistributionsResponse ListDistributions(ListDistributionsRequest request)
        {
            var task = ListDistributionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributions operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDistributionsRequestMarshaller();
            var unmarshaller = ListDistributionsResponseUnmarshaller.Instance;
            return Invoke<IRequest, ListDistributionsRequest, ListDistributionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ListInvalidations


        /// <summary>
        /// List invalidation batches.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations service method.</param>
        /// 
        /// <returns>The response from the ListInvalidations service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        public ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request)
        {
            var task = ListInvalidationsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvalidations operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListInvalidationsRequestMarshaller();
            var unmarshaller = ListInvalidationsResponseUnmarshaller.Instance;
            return Invoke<IRequest, ListInvalidationsRequest, ListInvalidationsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ListStreamingDistributions

        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListStreamingDistributionsResponse ListStreamingDistributions()
        {
            return ListStreamingDistributions(new ListStreamingDistributionsRequest());
        }

        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions service method.</param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request)
        {
            var task = ListStreamingDistributionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamingDistributions operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStreamingDistributionsRequestMarshaller();
            var unmarshaller = ListStreamingDistributionsResponseUnmarshaller.Instance;
            return Invoke<IRequest, ListStreamingDistributionsRequest, ListStreamingDistributionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateCloudFrontOriginAccessIdentity


        /// <summary>
        /// Update an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the UpdateCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="IllegalUpdateException">
        /// Origin and CallerReference cannot be updated.
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request)
        {
            var task = UpdateCloudFrontOriginAccessIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateCloudFrontOriginAccessIdentityRequest, UpdateCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateDistribution


        /// <summary>
        /// Update a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution service method.</param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="IllegalUpdateException">
        /// Origin and CallerReference cannot be updated.
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="InvalidErrorCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the whitelisted    list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names    is missing when expected.
        /// </exception>
        /// <exception cref="InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="InvalidHeadersForS3OriginException">
        /// 
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="InvalidLocationCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or    does not begin with a slash
        /// (/).
        /// </exception>
        /// <exception cref="InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the RequiredProtocols element from your distribution configuration.
        /// </exception>
        /// <exception cref="InvalidResponseCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidViewerCertificateException">
        /// 
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="NoSuchOriginException">
        /// No origin exists with the specified Origin Id.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        /// <exception cref="TooManyCacheBehaviorsException">
        /// You cannot create anymore cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="TooManyCertificatesException">
        /// You cannot create anymore custom ssl certificates.
        /// </exception>
        /// <exception cref="TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="TooManyOriginsException">
        /// You cannot create anymore origins for the distribution.
        /// </exception>
        /// <exception cref="TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        public UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request)
        {
            var task = UpdateDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDistributionRequestMarshaller();
            var unmarshaller = UpdateDistributionResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateDistributionRequest, UpdateDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateStreamingDistribution


        /// <summary>
        /// Update a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the UpdateStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="IllegalUpdateException">
        /// Origin and CallerReference cannot be updated.
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        /// <exception cref="TooManyStreamingDistributionCNAMEsException">
        /// 
        /// </exception>
        /// <exception cref="TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        public UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request)
        {
            var task = UpdateStreamingDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateStreamingDistributionRequest, UpdateStreamingDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
    }
}