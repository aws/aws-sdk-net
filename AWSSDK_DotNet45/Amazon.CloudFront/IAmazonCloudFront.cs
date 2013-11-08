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

namespace Amazon.CloudFront
{
    /// <summary>
    /// Interface for accessing AmazonCloudFront.
    /// 
    /// 
    /// </summary>
	public partial interface IAmazonCloudFront : IDisposable
    {
 

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
		CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request);

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
		Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
		CreateDistributionResponse CreateDistribution(CreateDistributionRequest request);

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
		Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
		CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request);

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
		Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
		CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request);

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
		Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
		DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request);

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
		Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
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
		DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity();
 

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
		DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request);

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
		Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
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
		DeleteDistributionResponse DeleteDistribution();
 

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
		DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request);

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
		Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
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
		DeleteStreamingDistributionResponse DeleteStreamingDistribution();
 

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
		GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request);

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
		Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Get the information about an origin access identity. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity();
 

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
		GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request);

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
		Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Get the configuration information about an origin access identity. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig();
 

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
		GetDistributionResponse GetDistribution(GetDistributionRequest request);

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
		Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Get the information about a distribution. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		GetDistributionResponse GetDistribution();
 

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
		GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request);

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
		Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Get the configuration information about a distribution. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		GetDistributionConfigResponse GetDistributionConfig();
 

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
		GetInvalidationResponse GetInvalidation(GetInvalidationRequest request);

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
		Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
		GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request);

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
		Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Get the information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		GetStreamingDistributionResponse GetStreamingDistribution();
 

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
		GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request);

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
		Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Get the configuration information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.NoSuchStreamingDistributionException" />
        /// <exception cref="T:Amazon.CloudFront.Model.AccessDeniedException" />
		GetStreamingDistributionConfigResponse GetStreamingDistributionConfig();
 

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
		ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request);

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
		Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> List origin access identities. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
		ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities();
 

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
		ListDistributionsResponse ListDistributions(ListDistributionsRequest request);

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
		Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> List distributions. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
		ListDistributionsResponse ListDistributions();
 

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
		ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request);

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
		Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
		ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request);

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
		Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> List streaming distributions. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFront.Model.InvalidArgumentException" />
		ListStreamingDistributionsResponse ListStreamingDistributions();
 

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
		UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request);

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
		Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
		UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request);

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
		Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
		UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request);

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
		Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
