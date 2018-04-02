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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudFront.Model;

namespace Amazon.CloudFront
{
    /// <summary>
    /// Interface for accessing CloudFront
    ///
    /// Amazon CloudFront 
    /// <para>
    /// This is the <i>Amazon CloudFront API Reference</i>. This guide is for developers who
    /// need detailed information about CloudFront API actions, data types, and errors. For
    /// detailed information about CloudFront features, see the <i>Amazon CloudFront Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudFront : IAmazonService, IDisposable
    {

        
        #region  CreateCloudFrontOriginAccessIdentity


        /// <summary>
        /// Creates a new origin access identity. If you're using Amazon S3 for your origin, you
        /// can use an origin access identity to require users to access your content using a
        /// CloudFront URL instead of the Amazon S3 URL. For more information about how to use
        /// origin access identities, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the CreateCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityAlreadyExistsException">
        /// If the <code>CallerReference</code> is a value you already sent in a previous request
        /// to create an identity but the content of the <code>CloudFrontOriginAccessIdentityConfig</code>
        /// is different from the original request, CloudFront returns a <code>CloudFrontOriginAccessIdentityAlreadyExists</code>
        /// error.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCloudFrontOriginAccessIdentitiesException">
        /// Processing your request would cause you to exceed the maximum number of origin access
        /// identities allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateCloudFrontOriginAccessIdentity">REST API Reference for CreateCloudFrontOriginAccessIdentity Operation</seealso>
        CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request);


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
        Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDistribution


        /// <summary>
        /// Creates a new web distribution. Send a <code>POST</code> request to the <code>/<i>CloudFront
        /// API version</i>/distribution</code>/<code>distribution ID</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution service method.</param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionAlreadyExistsException">
        /// The caller reference you attempted to create the distribution with is associated with
        /// another distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <code>whitelisted</code> list of cookie names. Either list of cookie names
        /// has been specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <code>RequiredProtocols</code> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <code>Origin Id</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create more cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom SSL/TLS certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda function associations than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        CreateDistributionResponse CreateDistribution(CreateDistributionRequest request);


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
        Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDistributionWithTags


        /// <summary>
        /// Create a new distribution with tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionWithTags service method.</param>
        /// 
        /// <returns>The response from the CreateDistributionWithTags service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionAlreadyExistsException">
        /// The caller reference you attempted to create the distribution with is associated with
        /// another distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <code>whitelisted</code> list of cookie names. Either list of cookie names
        /// has been specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <code>RequiredProtocols</code> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <code>Origin Id</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create more cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom SSL/TLS certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda function associations than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistributionWithTags">REST API Reference for CreateDistributionWithTags Operation</seealso>
        CreateDistributionWithTagsResponse CreateDistributionWithTags(CreateDistributionWithTagsRequest request);


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
        Task<CreateDistributionWithTagsResponse> CreateDistributionWithTagsAsync(CreateDistributionWithTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFieldLevelEncryptionConfig


        /// <summary>
        /// Create a new field-level encryption configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the CreateFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionConfigAlreadyExistsException">
        /// The specified configuration for field-level encryption already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.QueryArgProfileEmptyException">
        /// No profile specified for the field-level encryption query argument.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionConfigsException">
        /// The maximum number of configurations for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionContentTypeProfilesException">
        /// The maximum number of content type profiles for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionQueryArgProfilesException">
        /// The maximum number of query arg profiles for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionConfig">REST API Reference for CreateFieldLevelEncryptionConfig Operation</seealso>
        CreateFieldLevelEncryptionConfigResponse CreateFieldLevelEncryptionConfig(CreateFieldLevelEncryptionConfigRequest request);


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
        Task<CreateFieldLevelEncryptionConfigResponse> CreateFieldLevelEncryptionConfigAsync(CreateFieldLevelEncryptionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFieldLevelEncryptionProfile


        /// <summary>
        /// Create a field-level encryption profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionProfile service method.</param>
        /// 
        /// <returns>The response from the CreateFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileAlreadyExistsException">
        /// The specified profile for field-level encryption already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileSizeExceededException">
        /// The maximum size of a profile for field-level encryption was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionEncryptionEntitiesException">
        /// The maximum number of encryption entities for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionFieldPatternsException">
        /// The maximum number of field patterns for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionProfilesException">
        /// The maximum number of profiles for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionProfile">REST API Reference for CreateFieldLevelEncryptionProfile Operation</seealso>
        CreateFieldLevelEncryptionProfileResponse CreateFieldLevelEncryptionProfile(CreateFieldLevelEncryptionProfileRequest request);


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
        Task<CreateFieldLevelEncryptionProfileResponse> CreateFieldLevelEncryptionProfileAsync(CreateFieldLevelEncryptionProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInvalidation


        /// <summary>
        /// Create a new invalidation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation service method.</param>
        /// 
        /// <returns>The response from the CreateInvalidation service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.BatchTooLargeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyInvalidationsInProgressException">
        /// You have exceeded the maximum number of allowable InProgress invalidation batch requests,
        /// or invalidation objects.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateInvalidation">REST API Reference for CreateInvalidation Operation</seealso>
        CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request);


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
        Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePublicKey


        /// <summary>
        /// Add a new public key to CloudFront to use, for example, for field-level encryption.
        /// You can add a maximum of 10 public keys with one AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicKey service method.</param>
        /// 
        /// <returns>The response from the CreatePublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PublicKeyAlreadyExistsException">
        /// The specified public key already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyPublicKeysException">
        /// The maximum number of public keys for field-level encryption have been created. To
        /// create a new public key, delete one of the existing keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreatePublicKey">REST API Reference for CreatePublicKey Operation</seealso>
        CreatePublicKeyResponse CreatePublicKey(CreatePublicKeyRequest request);


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
        Task<CreatePublicKeyResponse> CreatePublicKeyAsync(CreatePublicKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStreamingDistribution


        /// <summary>
        /// Creates a new RMTP distribution. An RTMP distribution is similar to a web distribution,
        /// but an RTMP distribution streams media files using the Adobe Real-Time Messaging Protocol
        /// (RTMP) instead of serving files using HTTP. 
        /// 
        ///  
        /// <para>
        /// To create a new web distribution, submit a <code>POST</code> request to the <i>CloudFront
        /// API version</i>/distribution resource. The request body must include a document with
        /// a <i>StreamingDistributionConfig</i> element. The response echoes the <code>StreamingDistributionConfig</code>
        /// element and returns other information about the RTMP distribution.
        /// </para>
        ///  
        /// <para>
        /// To get the status of your request, use the <i>GET StreamingDistribution</i> API action.
        /// When the value of <code>Enabled</code> is <code>true</code> and the value of <code>Status</code>
        /// is <code>Deployed</code>, your distribution is ready. A distribution usually deploys
        /// in less than 15 minutes.
        /// </para>
        ///  
        /// <para>
        /// For more information about web distributions, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-rtmp.html">Working
        /// with RTMP Distributions</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Beginning with the 2012-05-05 version of the CloudFront API, we made substantial changes
        /// to the format of the XML document that you include in the request body when you create
        /// or update a web distribution or an RTMP distribution, and when you invalidate objects.
        /// With previous versions of the API, we discovered that it was too easy to accidentally
        /// delete one or more values for an element that accepts multiple values, for example,
        /// CNAMEs and trusted signers. Our changes for the 2012-05-05 release are intended to
        /// prevent these accidental deletions and to notify you when there's a mismatch between
        /// the number of values you say you're specifying in the <code>Quantity</code> element
        /// and the number of values specified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of streaming
        /// distributions allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistribution">REST API Reference for CreateStreamingDistribution Operation</seealso>
        CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request);


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
        Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStreamingDistributionWithTags


        /// <summary>
        /// Create a new streaming distribution with tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistributionWithTags service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingDistributionWithTags service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of streaming
        /// distributions allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistributionWithTags">REST API Reference for CreateStreamingDistributionWithTags Operation</seealso>
        CreateStreamingDistributionWithTagsResponse CreateStreamingDistributionWithTags(CreateStreamingDistributionWithTagsRequest request);


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
        Task<CreateStreamingDistributionWithTagsResponse> CreateStreamingDistributionWithTagsAsync(CreateStreamingDistributionWithTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCloudFrontOriginAccessIdentity


        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
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
        DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity();


        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity service method.</param>
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
        DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request);


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
        Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDistribution


        /// <summary>
        /// Delete a distribution.
        /// </summary>
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
        DeleteDistributionResponse DeleteDistribution();


        /// <summary>
        /// Delete a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution service method.</param>
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
        DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request);


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
        Task<DeleteDistributionResponse> DeleteDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFieldLevelEncryptionConfig


        /// <summary>
        /// Remove a field-level encryption configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionConfigInUseException">
        /// The specified configuration for field-level encryption is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionConfig">REST API Reference for DeleteFieldLevelEncryptionConfig Operation</seealso>
        DeleteFieldLevelEncryptionConfigResponse DeleteFieldLevelEncryptionConfig(DeleteFieldLevelEncryptionConfigRequest request);


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
        Task<DeleteFieldLevelEncryptionConfigResponse> DeleteFieldLevelEncryptionConfigAsync(DeleteFieldLevelEncryptionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFieldLevelEncryptionProfile


        /// <summary>
        /// Remove a field-level encryption profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileInUseException">
        /// The specified profile for field-level encryption is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionProfile">REST API Reference for DeleteFieldLevelEncryptionProfile Operation</seealso>
        DeleteFieldLevelEncryptionProfileResponse DeleteFieldLevelEncryptionProfile(DeleteFieldLevelEncryptionProfileRequest request);


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
        Task<DeleteFieldLevelEncryptionProfileResponse> DeleteFieldLevelEncryptionProfileAsync(DeleteFieldLevelEncryptionProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePublicKey


        /// <summary>
        /// Remove a public key you previously added to CloudFront.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicKey service method.</param>
        /// 
        /// <returns>The response from the DeletePublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PublicKeyInUseException">
        /// The specified public key is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        DeletePublicKeyResponse DeletePublicKey(DeletePublicKeyRequest request);


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
        Task<DeletePublicKeyResponse> DeletePublicKeyAsync(DeletePublicKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteServiceLinkedRole


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceLinkedRole service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        DeleteServiceLinkedRoleResponse DeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest request);


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
        Task<DeleteServiceLinkedRoleResponse> DeleteServiceLinkedRoleAsync(DeleteServiceLinkedRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStreamingDistribution


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
        DeleteStreamingDistributionResponse DeleteStreamingDistribution();


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
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution service method.</param>
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
        DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request);


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
        Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentity


        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity();


        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request);


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
        Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentityConfig


        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig();


        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig service method.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request);


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
        Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDistribution


        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        GetDistributionResponse GetDistribution();


        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution service method.</param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        GetDistributionResponse GetDistribution(GetDistributionRequest request);


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
        Task<GetDistributionResponse> GetDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDistributionConfig


        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        GetDistributionConfigResponse GetDistributionConfig();


        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig service method.</param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request);


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
        Task<GetDistributionConfigResponse> GetDistributionConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFieldLevelEncryption


        /// <summary>
        /// Get the field-level encryption configuration information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryption service method.</param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryption service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryption">REST API Reference for GetFieldLevelEncryption Operation</seealso>
        GetFieldLevelEncryptionResponse GetFieldLevelEncryption(GetFieldLevelEncryptionRequest request);


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
        Task<GetFieldLevelEncryptionResponse> GetFieldLevelEncryptionAsync(GetFieldLevelEncryptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFieldLevelEncryptionConfig


        /// <summary>
        /// Get the field-level encryption configuration information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionConfig">REST API Reference for GetFieldLevelEncryptionConfig Operation</seealso>
        GetFieldLevelEncryptionConfigResponse GetFieldLevelEncryptionConfig(GetFieldLevelEncryptionConfigRequest request);


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
        Task<GetFieldLevelEncryptionConfigResponse> GetFieldLevelEncryptionConfigAsync(GetFieldLevelEncryptionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFieldLevelEncryptionProfile


        /// <summary>
        /// Get the field-level encryption profile information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfile service method.</param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfile">REST API Reference for GetFieldLevelEncryptionProfile Operation</seealso>
        GetFieldLevelEncryptionProfileResponse GetFieldLevelEncryptionProfile(GetFieldLevelEncryptionProfileRequest request);


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
        Task<GetFieldLevelEncryptionProfileResponse> GetFieldLevelEncryptionProfileAsync(GetFieldLevelEncryptionProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFieldLevelEncryptionProfileConfig


        /// <summary>
        /// Get the field-level encryption profile configuration information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfileConfig service method.</param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryptionProfileConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfileConfig">REST API Reference for GetFieldLevelEncryptionProfileConfig Operation</seealso>
        GetFieldLevelEncryptionProfileConfigResponse GetFieldLevelEncryptionProfileConfig(GetFieldLevelEncryptionProfileConfigRequest request);


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
        Task<GetFieldLevelEncryptionProfileConfigResponse> GetFieldLevelEncryptionProfileConfigAsync(GetFieldLevelEncryptionProfileConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInvalidation


        /// <summary>
        /// Get the information about an invalidation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation service method.</param>
        /// 
        /// <returns>The response from the GetInvalidation service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchInvalidationException">
        /// The specified invalidation does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetInvalidation">REST API Reference for GetInvalidation Operation</seealso>
        GetInvalidationResponse GetInvalidation(GetInvalidationRequest request);


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
        Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPublicKey


        /// <summary>
        /// Get the public key information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey service method.</param>
        /// 
        /// <returns>The response from the GetPublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request);


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
        Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPublicKeyConfig


        /// <summary>
        /// Return public key configuration informaation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKeyConfig service method.</param>
        /// 
        /// <returns>The response from the GetPublicKeyConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKeyConfig">REST API Reference for GetPublicKeyConfig Operation</seealso>
        GetPublicKeyConfigResponse GetPublicKeyConfig(GetPublicKeyConfigRequest request);


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
        Task<GetPublicKeyConfigResponse> GetPublicKeyConfigAsync(GetPublicKeyConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStreamingDistribution


        /// <summary>
        /// Gets information about a specified RTMP distribution, including the distribution configuration.
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        GetStreamingDistributionResponse GetStreamingDistribution();


        /// <summary>
        /// Gets information about a specified RTMP distribution, including the distribution configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request);


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
        Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStreamingDistributionConfig


        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        GetStreamingDistributionConfigResponse GetStreamingDistributionConfig();


        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig service method.</param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request);


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
        Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCloudFrontOriginAccessIdentities


        /// <summary>
        /// Lists origin access identities.
        /// </summary>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities();


        /// <summary>
        /// Lists origin access identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities service method.</param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request);


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
        Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDistributions


        /// <summary>
        /// List distributions.
        /// </summary>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        ListDistributionsResponse ListDistributions();


        /// <summary>
        /// List distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions service method.</param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        ListDistributionsResponse ListDistributions(ListDistributionsRequest request);


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
        Task<ListDistributionsResponse> ListDistributionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDistributionsByWebACLId


        /// <summary>
        /// List the distributions that are associated with a specified AWS WAF web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByWebACLId service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByWebACLId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributionsByWebACLId">REST API Reference for ListDistributionsByWebACLId Operation</seealso>
        ListDistributionsByWebACLIdResponse ListDistributionsByWebACLId(ListDistributionsByWebACLIdRequest request);


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
        Task<ListDistributionsByWebACLIdResponse> ListDistributionsByWebACLIdAsync(ListDistributionsByWebACLIdRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFieldLevelEncryptionConfigs


        /// <summary>
        /// List all field-level encryption configurations that have been created in CloudFront
        /// for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionConfigs service method.</param>
        /// 
        /// <returns>The response from the ListFieldLevelEncryptionConfigs service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionConfigs">REST API Reference for ListFieldLevelEncryptionConfigs Operation</seealso>
        ListFieldLevelEncryptionConfigsResponse ListFieldLevelEncryptionConfigs(ListFieldLevelEncryptionConfigsRequest request);


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
        Task<ListFieldLevelEncryptionConfigsResponse> ListFieldLevelEncryptionConfigsAsync(ListFieldLevelEncryptionConfigsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFieldLevelEncryptionProfiles


        /// <summary>
        /// Request a list of field-level encryption profiles that have been created in CloudFront
        /// for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionProfiles service method.</param>
        /// 
        /// <returns>The response from the ListFieldLevelEncryptionProfiles service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionProfiles">REST API Reference for ListFieldLevelEncryptionProfiles Operation</seealso>
        ListFieldLevelEncryptionProfilesResponse ListFieldLevelEncryptionProfiles(ListFieldLevelEncryptionProfilesRequest request);


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
        Task<ListFieldLevelEncryptionProfilesResponse> ListFieldLevelEncryptionProfilesAsync(ListFieldLevelEncryptionProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInvalidations


        /// <summary>
        /// Lists invalidation batches.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations service method.</param>
        /// 
        /// <returns>The response from the ListInvalidations service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListInvalidations">REST API Reference for ListInvalidations Operation</seealso>
        ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request);


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
        Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPublicKeys


        /// <summary>
        /// List all public keys that have been added to CloudFront for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys service method.</param>
        /// 
        /// <returns>The response from the ListPublicKeys service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        ListPublicKeysResponse ListPublicKeys(ListPublicKeysRequest request);


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
        Task<ListPublicKeysResponse> ListPublicKeysAsync(ListPublicKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStreamingDistributions


        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        ListStreamingDistributionsResponse ListStreamingDistributions();


        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions service method.</param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request);


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
        Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for a CloudFront resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);


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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add tags to a CloudFront resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);


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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove tags from a CloudFront resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);


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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCloudFrontOriginAccessIdentity


        /// <summary>
        /// Update an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the UpdateCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateCloudFrontOriginAccessIdentity">REST API Reference for UpdateCloudFrontOriginAccessIdentity Operation</seealso>
        UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request);


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
        Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDistribution


        /// <summary>
        /// Updates the configuration for a web distribution. Perform the following steps.
        /// 
        ///  
        /// <para>
        /// For information about updating a distribution using the CloudFront console, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-creating-console.html">Creating
        /// or Updating a Web Distribution Using the CloudFront Console </a> in the <i>Amazon
        /// CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>To update a web distribution using the CloudFront API</b> 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>GetDistributionConfig</a> request to get the current configuration and
        /// an <code>Etag</code> header for the distribution.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you update the distribution again, you need to get a new <code>Etag</code> header.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Update the XML document that was returned in the response to your <code>GetDistributionConfig</code>
        /// request to include the desired changes. You can't change the value of <code>CallerReference</code>.
        /// If you try to change this value, CloudFront returns an <code>IllegalUpdate</code>
        /// error.
        /// </para>
        ///  <important> 
        /// <para>
        /// The new configuration replaces the existing configuration; the values that you specify
        /// in an <code>UpdateDistribution</code> request are not merged into the existing configuration.
        /// When you add, delete, or replace values in an element that allows multiple values
        /// (for example, <code>CNAME</code>), you must specify all of the values that you want
        /// to appear in the updated distribution. In addition, you must update the corresponding
        /// <code>Quantity</code> element.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// Submit an <code>UpdateDistribution</code> request to update the configuration for
        /// your distribution:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In the request body, include the XML document that you updated in Step 2. The request
        /// body must include an XML document with a <code>DistributionConfig</code> element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set the value of the HTTP <code>If-Match</code> header to the value of the <code>ETag</code>
        /// header that CloudFront returned when you submitted the <code>GetDistributionConfig</code>
        /// request in Step 1.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Review the response to the <code>UpdateDistribution</code> request to confirm that
        /// the configuration was successfully updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: Submit a <a>GetDistribution</a> request to confirm that your changes have
        /// propagated. When propagation is complete, the value of <code>Status</code> is <code>Deployed</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Beginning with the 2012-05-05 version of the CloudFront API, we made substantial changes
        /// to the format of the XML document that you include in the request body when you create
        /// or update a distribution. With previous versions of the API, we discovered that it
        /// was too easy to accidentally delete one or more values for an element that accepts
        /// multiple values, for example, CNAMEs and trusted signers. Our changes for the 2012-05-05
        /// release are intended to prevent these accidental deletions and to notify you when
        /// there's a mismatch between the number of values you say you're specifying in the <code>Quantity</code>
        /// element and the number of values you're actually specifying.
        /// </para>
        ///  </important> </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution service method.</param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <code>whitelisted</code> list of cookie names. Either list of cookie names
        /// has been specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <code>RequiredProtocols</code> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <code>Origin Id</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create more cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom SSL/TLS certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda function associations than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request);


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
        Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFieldLevelEncryptionConfig


        /// <summary>
        /// Update a field-level encryption configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.QueryArgProfileEmptyException">
        /// No profile specified for the field-level encryption query argument.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionContentTypeProfilesException">
        /// The maximum number of content type profiles for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionQueryArgProfilesException">
        /// The maximum number of query arg profiles for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionConfig">REST API Reference for UpdateFieldLevelEncryptionConfig Operation</seealso>
        UpdateFieldLevelEncryptionConfigResponse UpdateFieldLevelEncryptionConfig(UpdateFieldLevelEncryptionConfigRequest request);


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
        Task<UpdateFieldLevelEncryptionConfigResponse> UpdateFieldLevelEncryptionConfigAsync(UpdateFieldLevelEncryptionConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFieldLevelEncryptionProfile


        /// <summary>
        /// Update a field-level encryption profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileAlreadyExistsException">
        /// The specified profile for field-level encryption already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileSizeExceededException">
        /// The maximum size of a profile for field-level encryption was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionEncryptionEntitiesException">
        /// The maximum number of encryption entities for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionFieldPatternsException">
        /// The maximum number of field patterns for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionProfile">REST API Reference for UpdateFieldLevelEncryptionProfile Operation</seealso>
        UpdateFieldLevelEncryptionProfileResponse UpdateFieldLevelEncryptionProfile(UpdateFieldLevelEncryptionProfileRequest request);


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
        Task<UpdateFieldLevelEncryptionProfileResponse> UpdateFieldLevelEncryptionProfileAsync(UpdateFieldLevelEncryptionProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePublicKey


        /// <summary>
        /// Update public key information. Note that the only value you can change is the comment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicKey service method.</param>
        /// 
        /// <returns>The response from the UpdatePublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotChangeImmutablePublicKeyFieldsException">
        /// You can't change the value of a public key.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdatePublicKey">REST API Reference for UpdatePublicKey Operation</seealso>
        UpdatePublicKeyResponse UpdatePublicKey(UpdatePublicKeyRequest request);


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
        Task<UpdatePublicKeyResponse> UpdatePublicKeyAsync(UpdatePublicKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStreamingDistribution


        /// <summary>
        /// Update a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the UpdateStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateStreamingDistribution">REST API Reference for UpdateStreamingDistribution Operation</seealso>
        UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request);


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
        Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}