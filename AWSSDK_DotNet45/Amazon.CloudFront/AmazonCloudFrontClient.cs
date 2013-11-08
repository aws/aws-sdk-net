/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Implementation for accessing AmazonCloudFront.
    /// 
    /// 
    /// </summary>
	public partial class AmazonCloudFrontClient : AmazonWebServiceClient, Amazon.CloudFront.IAmazonCloudFront
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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCloudFront Configuration Object</param>
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
            : this(credentials, new AmazonCloudFrontConfig(){RegionEndpoint=region})
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
        /// AmazonCloudFrontClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
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

 
        /// <summary>
        /// <para> Create a new origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// CreateCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCloudFrontOriginAccessIdentitiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.MissingBodyException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InconsistentQuantitiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityAlreadyExistsException" />
		public CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request)
        {
            var task = CreateCloudFrontOriginAccessIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.CreateCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateCloudFrontOriginAccessIdentityRequest, CreateCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Create a new distribution. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidDefaultRootObjectException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidResponseCodeException" />
        /// <exception cref="T:Amazon.CloudFront.Model.MissingBodyException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyDistributionCNAMEsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidForwardCookiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyDistributionsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchOriginException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InconsistentQuantitiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.CloudFront.Model.CNAMEAlreadyExistsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TrustedSignerDoesNotExistException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidOriginException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCertificatesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidRelativePathException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCacheBehaviorsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyTrustedSignersException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidErrorCodeException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidViewerCertificateException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyOriginsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.DistributionAlreadyExistsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidRequiredProtocolException" />
		public CreateDistributionResponse CreateDistribution(CreateDistributionRequest request)
        {
            var task = CreateDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.CreateDistribution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDistributionRequestMarshaller();
            var unmarshaller = CreateDistributionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateDistributionRequest, CreateDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Create a new invalidation. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateInvalidation service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyInvalidationsInProgressException" />
        /// <exception cref="T:Amazon.CloudFront.Model.MissingBodyException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.BatchTooLargeException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InconsistentQuantitiesException" />
		public CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request)
        {
            var task = CreateInvalidationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.CreateInvalidation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInvalidationRequestMarshaller();
            var unmarshaller = CreateInvalidationResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateInvalidationRequest, CreateInvalidationResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Create a new streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution service
        /// method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyTrustedSignersException" />
        /// <exception cref="T:Amazon.CloudFront.Model.MissingBodyException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.StreamingDistributionAlreadyExistsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.CNAMEAlreadyExistsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyStreamingDistributionsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InconsistentQuantitiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TrustedSignerDoesNotExistException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidOriginException" />
		public CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request)
        {
            var task = CreateStreamingDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.CreateStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var unmarshaller = CreateStreamingDistributionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateStreamingDistributionRequest, CreateStreamingDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Delete an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DeleteCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityInUseException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request)
        {
            var task = DeleteCloudFrontOriginAccessIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.DeleteCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteCloudFrontOriginAccessIdentityRequest, DeleteCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Delete an origin access identity. </para>
        /// </summary>
        /// 
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityInUseException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity()
        {
            return this.DeleteCloudFrontOriginAccessIdentity(new DeleteCloudFrontOriginAccessIdentityRequest());
        }
 
        /// <summary>
        /// <para> Delete a distribution. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.DistributionNotDisabledException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request)
        {
            var task = DeleteDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.DeleteDistribution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDistributionRequestMarshaller();
            var unmarshaller = DeleteDistributionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteDistributionRequest, DeleteDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Delete a distribution. </para>
        /// </summary>
        /// 
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.DistributionNotDisabledException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public DeleteDistributionResponse DeleteDistribution()
        {
            return this.DeleteDistribution(new DeleteDistributionRequest());
        }
 
        /// <summary>
        /// <para> Delete a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution service
        /// method on AmazonCloudFront.</param>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.StreamingDistributionNotDisabledException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request)
        {
            var task = DeleteStreamingDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.DeleteStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStreamingDistributionRequestMarshaller();
            var unmarshaller = DeleteStreamingDistributionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteStreamingDistributionRequest, DeleteStreamingDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Delete a streaming distribution. </para>
        /// </summary>
        /// 
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.StreamingDistributionNotDisabledException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public DeleteStreamingDistributionResponse DeleteStreamingDistribution()
        {
            return this.DeleteStreamingDistribution(new DeleteStreamingDistributionRequest());
        }
 
        /// <summary>
        /// <para> Get the information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// GetCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request)
        {
            var task = GetCloudFrontOriginAccessIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.GetCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetCloudFrontOriginAccessIdentityRequest, GetCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Get the information about an origin access identity. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity()
        {
            return this.GetCloudFrontOriginAccessIdentity(new GetCloudFrontOriginAccessIdentityRequest());
        }
 
        /// <summary>
        /// <para> Get the configuration information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// GetCloudFrontOriginAccessIdentityConfig service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request)
        {
            var task = GetCloudFrontOriginAccessIdentityConfigAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentityConfig operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.GetCloudFrontOriginAccessIdentityConfig"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCloudFrontOriginAccessIdentityConfigRequestMarshaller();
            var unmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetCloudFrontOriginAccessIdentityConfigRequest, GetCloudFrontOriginAccessIdentityConfigResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Get the configuration information about an origin access identity. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig()
        {
            return this.GetCloudFrontOriginAccessIdentityConfig(new GetCloudFrontOriginAccessIdentityConfigRequest());
        }
 
        /// <summary>
        /// <para> Get the information about a distribution. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetDistributionResponse GetDistribution(GetDistributionRequest request)
        {
            var task = GetDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.GetDistribution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDistributionRequestMarshaller();
            var unmarshaller = GetDistributionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetDistributionRequest, GetDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Get the information about a distribution. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetDistributionResponse GetDistribution()
        {
            return this.GetDistribution(new GetDistributionRequest());
        }
 
        /// <summary>
        /// <para> Get the configuration information about a distribution. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request)
        {
            var task = GetDistributionConfigAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.GetDistributionConfig"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDistributionConfigRequestMarshaller();
            var unmarshaller = GetDistributionConfigResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetDistributionConfigRequest, GetDistributionConfigResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Get the configuration information about a distribution. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetDistributionConfigResponse GetDistributionConfig()
        {
            return this.GetDistributionConfig(new GetDistributionConfigRequest());
        }
 
        /// <summary>
        /// <para> Get the information about an invalidation. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetInvalidation service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchInvalidationException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetInvalidationResponse GetInvalidation(GetInvalidationRequest request)
        {
            var task = GetInvalidationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.GetInvalidation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetInvalidationRequestMarshaller();
            var unmarshaller = GetInvalidationResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetInvalidationRequest, GetInvalidationResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Get the information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution service method
        /// on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request)
        {
            var task = GetStreamingDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.GetStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStreamingDistributionRequestMarshaller();
            var unmarshaller = GetStreamingDistributionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetStreamingDistributionRequest, GetStreamingDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Get the information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetStreamingDistributionResponse GetStreamingDistribution()
        {
            return this.GetStreamingDistribution(new GetStreamingDistributionRequest());
        }
 
        /// <summary>
        /// <para> Get the configuration information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig
        /// service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request)
        {
            var task = GetStreamingDistributionConfigAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.GetStreamingDistributionConfig"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStreamingDistributionConfigRequestMarshaller();
            var unmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetStreamingDistributionConfigRequest, GetStreamingDistributionConfigResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Get the configuration information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public GetStreamingDistributionConfigResponse GetStreamingDistributionConfig()
        {
            return this.GetStreamingDistributionConfig(new GetStreamingDistributionConfigRequest());
        }
 
        /// <summary>
        /// <para> List origin access identities. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// ListCloudFrontOriginAccessIdentities service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
		public ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request)
        {
            var task = ListCloudFrontOriginAccessIdentitiesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudFrontOriginAccessIdentities operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.ListCloudFrontOriginAccessIdentities"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListCloudFrontOriginAccessIdentitiesRequestMarshaller();
            var unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListCloudFrontOriginAccessIdentitiesRequest, ListCloudFrontOriginAccessIdentitiesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> List origin access identities. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
		public ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities()
        {
            return this.ListCloudFrontOriginAccessIdentities(new ListCloudFrontOriginAccessIdentitiesRequest());
        }
 
        /// <summary>
        /// <para> List distributions. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
		public ListDistributionsResponse ListDistributions(ListDistributionsRequest request)
        {
            var task = ListDistributionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributions operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.ListDistributions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDistributionsRequestMarshaller();
            var unmarshaller = ListDistributionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListDistributionsRequest, ListDistributionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> List distributions. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
		public ListDistributionsResponse ListDistributions()
        {
            return this.ListDistributions(new ListDistributionsRequest());
        }
 
        /// <summary>
        /// <para> List invalidation batches. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListInvalidations service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request)
        {
            var task = ListInvalidationsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListInvalidations operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.ListInvalidations"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListInvalidationsRequestMarshaller();
            var unmarshaller = ListInvalidationsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListInvalidationsRequest, ListInvalidationsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> List streaming distributions. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions service
        /// method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
		public ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request)
        {
            var task = ListStreamingDistributionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamingDistributions operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.ListStreamingDistributions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStreamingDistributionsRequestMarshaller();
            var unmarshaller = ListStreamingDistributionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListStreamingDistributionsRequest, ListStreamingDistributionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> List streaming distributions. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
		public ListStreamingDistributionsResponse ListStreamingDistributions()
        {
            return this.ListStreamingDistributions(new ListStreamingDistributionsRequest());
        }
 
        /// <summary>
        /// <para> Update an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// UpdateCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the UpdateCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.IllegalUpdateException" />
        /// <exception cref="T:Amazon.CloudFront.Model.MissingBodyException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InconsistentQuantitiesException" />
		public UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request)
        {
            var task = UpdateCloudFrontOriginAccessIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.UpdateCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateCloudFrontOriginAccessIdentityRequest, UpdateCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Update a distribution. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidResponseCodeException" />
        /// <exception cref="T:Amazon.CloudFront.Model.MissingBodyException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyDistributionCNAMEsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchOriginException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InconsistentQuantitiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.CNAMEAlreadyExistsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCacheBehaviorsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyTrustedSignersException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidViewerCertificateException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyOriginsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidRequiredProtocolException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidDefaultRootObjectException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.IllegalUpdateException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidForwardCookiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TrustedSignerDoesNotExistException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCertificatesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidRelativePathException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidErrorCodeException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request)
        {
            var task = UpdateDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.UpdateDistribution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDistributionRequestMarshaller();
            var unmarshaller = UpdateDistributionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateDistributionRequest, UpdateDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Update a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution service
        /// method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the UpdateStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.IllegalUpdateException" />
        /// <exception cref="T:Amazon.CloudFront.Model.MissingBodyException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.CNAMEAlreadyExistsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InconsistentQuantitiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TrustedSignerDoesNotExistException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyTrustedSignersException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		public UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request)
        {
            var task = UpdateStreamingDistributionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.IAmazonCloudFront.UpdateStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateStreamingDistributionRequest, UpdateStreamingDistributionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
