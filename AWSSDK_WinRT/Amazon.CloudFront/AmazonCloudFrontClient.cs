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
        #region Constructors

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

 
		internal CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request)
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
        /// <para> Create a new origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="createCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        /// CreateCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCloudFrontOriginAccessIdentitiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.MissingBodyException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InconsistentQuantitiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest createCloudFrontOriginAccessIdentityRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateCloudFrontOriginAccessIdentityRequest, CreateCloudFrontOriginAccessIdentityResponse>(createCloudFrontOriginAccessIdentityRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateDistributionResponse CreateDistribution(CreateDistributionRequest request)
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
        /// <para> Create a new distribution. </para>
        /// </summary>
        /// 
        /// <param name="createDistributionRequest">Container for the necessary parameters to execute the CreateDistribution service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidResponseCodeException" />
        /// <exception cref="T:Amazon.CloudFront.Model.MissingBodyException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidLocationCodeException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyDistributionCNAMEsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyDistributionsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchOriginException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InconsistentQuantitiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.CloudFront.Model.CNAMEAlreadyExistsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCacheBehaviorsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyTrustedSignersException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidViewerCertificateException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyOriginsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.DistributionAlreadyExistsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidRequiredProtocolException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidDefaultRootObjectException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidForwardCookiesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TrustedSignerDoesNotExistException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidOriginException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCertificatesException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidRelativePathException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidErrorCodeException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest createDistributionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDistributionRequestMarshaller();
            var unmarshaller = CreateDistributionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateDistributionRequest, CreateDistributionResponse>(createDistributionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request)
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
        /// <para> Create a new invalidation. </para>
        /// </summary>
        /// 
        /// <param name="createInvalidationRequest">Container for the necessary parameters to execute the CreateInvalidation service method on
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest createInvalidationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInvalidationRequestMarshaller();
            var unmarshaller = CreateInvalidationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateInvalidationRequest, CreateInvalidationResponse>(createInvalidationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request)
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
        /// <para> Create a new streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="createStreamingDistributionRequest">Container for the necessary parameters to execute the CreateStreamingDistribution service
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest createStreamingDistributionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var unmarshaller = CreateStreamingDistributionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateStreamingDistributionRequest, CreateStreamingDistributionResponse>(createStreamingDistributionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request)
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
        /// <para> Delete an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="deleteCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        /// DeleteCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityInUseException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest deleteCloudFrontOriginAccessIdentityRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteCloudFrontOriginAccessIdentityRequest, DeleteCloudFrontOriginAccessIdentityResponse>(deleteCloudFrontOriginAccessIdentityRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request)
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
        /// <para> Delete a distribution. </para>
        /// </summary>
        /// 
        /// <param name="deleteDistributionRequest">Container for the necessary parameters to execute the DeleteDistribution service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.DistributionNotDisabledException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest deleteDistributionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDistributionRequestMarshaller();
            var unmarshaller = DeleteDistributionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteDistributionRequest, DeleteDistributionResponse>(deleteDistributionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request)
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
        /// <para> Delete a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="deleteStreamingDistributionRequest">Container for the necessary parameters to execute the DeleteStreamingDistribution service
        /// method on AmazonCloudFront.</param>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidIfMatchVersionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.StreamingDistributionNotDisabledException" />
        /// <exception cref="T:Amazon.CloudFront.Model.PreconditionFailedException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest deleteStreamingDistributionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStreamingDistributionRequestMarshaller();
            var unmarshaller = DeleteStreamingDistributionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteStreamingDistributionRequest, DeleteStreamingDistributionResponse>(deleteStreamingDistributionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request)
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
        /// <para> Get the information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="getCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        /// GetCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest getCloudFrontOriginAccessIdentityRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetCloudFrontOriginAccessIdentityRequest, GetCloudFrontOriginAccessIdentityResponse>(getCloudFrontOriginAccessIdentityRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request)
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
        /// <para> Get the configuration information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="getCloudFrontOriginAccessIdentityConfigRequest">Container for the necessary parameters to execute the
        /// GetCloudFrontOriginAccessIdentityConfig service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest getCloudFrontOriginAccessIdentityConfigRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCloudFrontOriginAccessIdentityConfigRequestMarshaller();
            var unmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetCloudFrontOriginAccessIdentityConfigRequest, GetCloudFrontOriginAccessIdentityConfigResponse>(getCloudFrontOriginAccessIdentityConfigRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetDistributionResponse GetDistribution(GetDistributionRequest request)
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
        /// <para> Get the information about a distribution. </para>
        /// </summary>
        /// 
        /// <param name="getDistributionRequest">Container for the necessary parameters to execute the GetDistribution service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest getDistributionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDistributionRequestMarshaller();
            var unmarshaller = GetDistributionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetDistributionRequest, GetDistributionResponse>(getDistributionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request)
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
        /// <para> Get the configuration information about a distribution. </para>
        /// </summary>
        /// 
        /// <param name="getDistributionConfigRequest">Container for the necessary parameters to execute the GetDistributionConfig service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest getDistributionConfigRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDistributionConfigRequestMarshaller();
            var unmarshaller = GetDistributionConfigResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetDistributionConfigRequest, GetDistributionConfigResponse>(getDistributionConfigRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetInvalidationResponse GetInvalidation(GetInvalidationRequest request)
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
        /// <para> Get the information about an invalidation. </para>
        /// </summary>
        /// 
        /// <param name="getInvalidationRequest">Container for the necessary parameters to execute the GetInvalidation service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetInvalidation service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchInvalidationException" />
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest getInvalidationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetInvalidationRequestMarshaller();
            var unmarshaller = GetInvalidationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetInvalidationRequest, GetInvalidationResponse>(getInvalidationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request)
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
        /// <para> Get the information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="getStreamingDistributionRequest">Container for the necessary parameters to execute the GetStreamingDistribution service method
        /// on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest getStreamingDistributionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStreamingDistributionRequestMarshaller();
            var unmarshaller = GetStreamingDistributionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetStreamingDistributionRequest, GetStreamingDistributionResponse>(getStreamingDistributionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request)
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
        /// <para> Get the configuration information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="getStreamingDistributionConfigRequest">Container for the necessary parameters to execute the GetStreamingDistributionConfig
        /// service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest getStreamingDistributionConfigRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStreamingDistributionConfigRequestMarshaller();
            var unmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetStreamingDistributionConfigRequest, GetStreamingDistributionConfigResponse>(getStreamingDistributionConfigRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request)
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
        /// <para> List origin access identities. </para>
        /// </summary>
        /// 
        /// <param name="listCloudFrontOriginAccessIdentitiesRequest">Container for the necessary parameters to execute the
        /// ListCloudFrontOriginAccessIdentities service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest listCloudFrontOriginAccessIdentitiesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListCloudFrontOriginAccessIdentitiesRequestMarshaller();
            var unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListCloudFrontOriginAccessIdentitiesRequest, ListCloudFrontOriginAccessIdentitiesResponse>(listCloudFrontOriginAccessIdentitiesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListDistributionsResponse ListDistributions(ListDistributionsRequest request)
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
        /// <para> List distributions. </para>
        /// </summary>
        /// 
        /// <param name="listDistributionsRequest">Container for the necessary parameters to execute the ListDistributions service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest listDistributionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDistributionsRequestMarshaller();
            var unmarshaller = ListDistributionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListDistributionsRequest, ListDistributionsResponse>(listDistributionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request)
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
        /// <para> List invalidation batches. </para>
        /// </summary>
        /// 
        /// <param name="listInvalidationsRequest">Container for the necessary parameters to execute the ListInvalidations service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListInvalidations service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest listInvalidationsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListInvalidationsRequestMarshaller();
            var unmarshaller = ListInvalidationsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListInvalidationsRequest, ListInvalidationsResponse>(listInvalidationsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request)
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
        /// <para> List streaming distributions. </para>
        /// </summary>
        /// 
        /// <param name="listStreamingDistributionsRequest">Container for the necessary parameters to execute the ListStreamingDistributions service
        /// method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest listStreamingDistributionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStreamingDistributionsRequestMarshaller();
            var unmarshaller = ListStreamingDistributionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListStreamingDistributionsRequest, ListStreamingDistributionsResponse>(listStreamingDistributionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request)
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
        /// <para> Update an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="updateCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest updateCloudFrontOriginAccessIdentityRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var unmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateCloudFrontOriginAccessIdentityRequest, UpdateCloudFrontOriginAccessIdentityResponse>(updateCloudFrontOriginAccessIdentityRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request)
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
        /// <para> Update a distribution. </para>
        /// </summary>
        /// 
        /// <param name="updateDistributionRequest">Container for the necessary parameters to execute the UpdateDistribution service method on
        /// AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidResponseCodeException" />
        /// <exception cref="T:Amazon.CloudFront.Model.MissingBodyException" />
        /// <exception cref="T:Amazon.CloudFront.Model.TooManyDistributionCNAMEsException" />
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidLocationCodeException" />
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest updateDistributionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDistributionRequestMarshaller();
            var unmarshaller = UpdateDistributionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateDistributionRequest, UpdateDistributionResponse>(updateDistributionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request)
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
        /// <para> Update a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="updateStreamingDistributionRequest">Container for the necessary parameters to execute the UpdateStreamingDistribution service
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest updateStreamingDistributionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateStreamingDistributionRequest, UpdateStreamingDistributionResponse>(updateStreamingDistributionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
