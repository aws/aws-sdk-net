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
		Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest createCloudFrontOriginAccessIdentityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest createDistributionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest createInvalidationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest createStreamingDistributionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest deleteCloudFrontOriginAccessIdentityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest deleteDistributionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest deleteStreamingDistributionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest getCloudFrontOriginAccessIdentityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest getCloudFrontOriginAccessIdentityConfigRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest getDistributionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest getDistributionConfigRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest getInvalidationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest getStreamingDistributionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest getStreamingDistributionConfigRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest listCloudFrontOriginAccessIdentitiesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest listDistributionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest listInvalidationsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest listStreamingDistributionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest updateCloudFrontOriginAccessIdentityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest updateDistributionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest updateStreamingDistributionRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
