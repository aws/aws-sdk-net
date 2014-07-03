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

namespace Amazon.CloudFront
{
    /// <summary>
    /// Implementation for accessing CloudFront
    ///
    /// 
    /// </summary>
    public partial interface IAmazonCloudFront : IDisposable
    {

        
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
        CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request);

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
        Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateDistributionResponse CreateDistribution(CreateDistributionRequest request);

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
        Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request);

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
        Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request);

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
        Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity();

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
        DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request);

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
        Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteDistributionResponse DeleteDistribution();

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
        DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request);

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
        Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteStreamingDistributionResponse DeleteStreamingDistribution();

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
        DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request);

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
        Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity();

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
        GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request);

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
        Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig();

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
        GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request);

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
        Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDistributionResponse GetDistribution();

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
        GetDistributionResponse GetDistribution(GetDistributionRequest request);

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
        Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDistributionConfigResponse GetDistributionConfig();

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
        GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request);

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
        Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetInvalidationResponse GetInvalidation(GetInvalidationRequest request);

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
        Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetStreamingDistributionResponse GetStreamingDistribution();

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
        GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request);

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
        Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetStreamingDistributionConfigResponse GetStreamingDistributionConfig();

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
        GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request);

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
        Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities();

        /// <summary>
        /// List origin access identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities service method.</param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request);

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
        Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListDistributionsResponse ListDistributions();

        /// <summary>
        /// List distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions service method.</param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        ListDistributionsResponse ListDistributions(ListDistributionsRequest request);

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
        Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request);

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
        Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListStreamingDistributionsResponse ListStreamingDistributions();

        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions service method.</param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request);

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
        Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request);

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
        Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request);

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
        Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request);

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
        Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}