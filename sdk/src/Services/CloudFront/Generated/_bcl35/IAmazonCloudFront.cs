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
using System.Collections.Generic;

using Amazon.CloudFront.Model;

namespace Amazon.CloudFront
{
    /// <summary>
    /// Interface for accessing CloudFront
    ///
    /// Amazon CloudFront 
    /// <para>
    /// Amazon CloudFront is a global content delivery network (CDN) service that accelerates
    /// delivery of your websites, APIs, video content or other web assets. It integrates
    /// with other Amazon Web Services products to give developers and businesses an easy
    /// way to accelerate content to end users with no minimum usage commitments.
    /// </para>
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
        /// <exception cref="Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityAlreadyExistsException">
        /// If the CallerReference is a value you already sent in a previous request to create
        /// an identity but the content of the CloudFrontOriginAccessIdentityConfig is different
        /// from the original request, CloudFront returns a CloudFrontOriginAccessIdentityAlreadyExists
        /// error.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCloudFrontOriginAccessIdentitiesException">
        /// Processing your request would cause you to exceed the maximum number of origin access
        /// identities allowed.
        /// </exception>
        CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        IAsyncResult BeginCreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  CreateCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        CreateCloudFrontOriginAccessIdentityResponse EndCreateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDistribution


        /// <summary>
        /// Create a new distribution.
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
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
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
        /// for the whitelisted list of cookie names. Either list of cookie names has been specified
        /// when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// 
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
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that Support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the RequiredProtocols element from your distribution configuration.
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
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified Origin Id.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create anymore cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom ssl certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create anymore origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        CreateDistributionResponse CreateDistribution(CreateDistributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDistribution
        ///         operation.</returns>
        IAsyncResult BeginCreateDistribution(CreateDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistribution.</param>
        /// 
        /// <returns>Returns a  CreateDistributionResult from CloudFront.</returns>
        CreateDistributionResponse EndCreateDistribution(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
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
        /// for the whitelisted list of cookie names. Either list of cookie names has been specified
        /// when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// 
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
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that Support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the RequiredProtocols element from your distribution configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The specified tagging for a CloudFront resource is invalid. For more information,
        /// see the error text.
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
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified Origin Id.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create anymore cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom ssl certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create anymore origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        CreateDistributionWithTagsResponse CreateDistributionWithTags(CreateDistributionWithTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionWithTags operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDistributionWithTags
        ///         operation.</returns>
        IAsyncResult BeginCreateDistributionWithTags(CreateDistributionWithTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistributionWithTags.</param>
        /// 
        /// <returns>Returns a  CreateDistributionWithTagsResult from CloudFront.</returns>
        CreateDistributionWithTagsResponse EndCreateDistributionWithTags(IAsyncResult asyncResult);

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
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyInvalidationsInProgressException">
        /// You have exceeded the maximum number of allowable InProgress invalidation batch requests,
        /// or invalidation objects.
        /// </exception>
        CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvalidation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInvalidation
        ///         operation.</returns>
        IAsyncResult BeginCreateInvalidation(CreateInvalidationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInvalidation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvalidation.</param>
        /// 
        /// <returns>Returns a  CreateInvalidationResult from CloudFront.</returns>
        CreateInvalidationResponse EndCreateInvalidation(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStreamingDistribution


        /// <summary>
        /// Create a new streaming distribution.
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
        /// The value of Quantity and the size of Items do not match.
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
        /// This operation requires a body. Ensure that the body is present and the Content-Type
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
        /// One or more of your trusted signers do not exist.
        /// </exception>
        CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamingDistribution
        ///         operation.</returns>
        IAsyncResult BeginCreateStreamingDistribution(CreateStreamingDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  CreateStreamingDistributionResult from CloudFront.</returns>
        CreateStreamingDistributionResponse EndCreateStreamingDistribution(IAsyncResult asyncResult);

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
        /// The value of Quantity and the size of Items do not match.
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
        /// The specified tagging for a CloudFront resource is invalid. For more information,
        /// see the error text.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
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
        /// One or more of your trusted signers do not exist.
        /// </exception>
        CreateStreamingDistributionWithTagsResponse CreateStreamingDistributionWithTags(CreateStreamingDistributionWithTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistributionWithTags operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamingDistributionWithTags
        ///         operation.</returns>
        IAsyncResult BeginCreateStreamingDistributionWithTags(CreateStreamingDistributionWithTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingDistributionWithTags.</param>
        /// 
        /// <returns>Returns a  CreateStreamingDistributionWithTagsResult from CloudFront.</returns>
        CreateStreamingDistributionWithTagsResponse EndCreateStreamingDistributionWithTags(IAsyncResult asyncResult);

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
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
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
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        IAsyncResult BeginDeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        DeleteCloudFrontOriginAccessIdentityResponse EndDeleteCloudFrontOriginAccessIdentity(IAsyncResult asyncResult);

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
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
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
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDistribution
        ///         operation.</returns>
        IAsyncResult BeginDeleteDistribution(DeleteDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDistribution.</param>
        /// 
        /// <returns>Returns a  DeleteDistributionResult from CloudFront.</returns>
        DeleteDistributionResponse EndDeleteDistribution(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStreamingDistribution


        /// <summary>
        /// Delete a streaming distribution.
        /// </summary>
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
        DeleteStreamingDistributionResponse DeleteStreamingDistribution();

        /// <summary>
        /// Delete a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution service method.</param>
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
        DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStreamingDistribution
        ///         operation.</returns>
        IAsyncResult BeginDeleteStreamingDistribution(DeleteStreamingDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  DeleteStreamingDistributionResult from CloudFront.</returns>
        DeleteStreamingDistributionResponse EndDeleteStreamingDistribution(IAsyncResult asyncResult);

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
        GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        IAsyncResult BeginGetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  GetCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        GetCloudFrontOriginAccessIdentityResponse EndGetCloudFrontOriginAccessIdentity(IAsyncResult asyncResult);

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
        GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentityConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudFrontOriginAccessIdentityConfig
        ///         operation.</returns>
        IAsyncResult BeginGetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudFrontOriginAccessIdentityConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentityConfig.</param>
        /// 
        /// <returns>Returns a  GetCloudFrontOriginAccessIdentityConfigResult from CloudFront.</returns>
        GetCloudFrontOriginAccessIdentityConfigResponse EndGetCloudFrontOriginAccessIdentityConfig(IAsyncResult asyncResult);

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
        GetDistributionResponse GetDistribution(GetDistributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistribution
        ///         operation.</returns>
        IAsyncResult BeginGetDistribution(GetDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistribution.</param>
        /// 
        /// <returns>Returns a  GetDistributionResult from CloudFront.</returns>
        GetDistributionResponse EndGetDistribution(IAsyncResult asyncResult);

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
        GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistributionConfig
        ///         operation.</returns>
        IAsyncResult BeginGetDistributionConfig(GetDistributionConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionConfig.</param>
        /// 
        /// <returns>Returns a  GetDistributionConfigResult from CloudFront.</returns>
        GetDistributionConfigResponse EndGetDistributionConfig(IAsyncResult asyncResult);

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
        GetInvalidationResponse GetInvalidation(GetInvalidationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvalidation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvalidation
        ///         operation.</returns>
        IAsyncResult BeginGetInvalidation(GetInvalidationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvalidation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvalidation.</param>
        /// 
        /// <returns>Returns a  GetInvalidationResult from CloudFront.</returns>
        GetInvalidationResponse EndGetInvalidation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStreamingDistribution


        /// <summary>
        /// Get the information about a streaming distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        GetStreamingDistributionResponse GetStreamingDistribution();

        /// <summary>
        /// Get the information about a streaming distribution.
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
        GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamingDistribution
        ///         operation.</returns>
        IAsyncResult BeginGetStreamingDistribution(GetStreamingDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  GetStreamingDistributionResult from CloudFront.</returns>
        GetStreamingDistributionResponse EndGetStreamingDistribution(IAsyncResult asyncResult);

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
        GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamingDistributionConfig
        ///         operation.</returns>
        IAsyncResult BeginGetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistributionConfig.</param>
        /// 
        /// <returns>Returns a  GetStreamingDistributionConfigResult from CloudFront.</returns>
        GetStreamingDistributionConfigResponse EndGetStreamingDistributionConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCloudFrontOriginAccessIdentities


        /// <summary>
        /// List origin access identities.
        /// </summary>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities();

        /// <summary>
        /// List origin access identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities service method.</param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudFrontOriginAccessIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudFrontOriginAccessIdentities
        ///         operation.</returns>
        IAsyncResult BeginListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudFrontOriginAccessIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudFrontOriginAccessIdentities.</param>
        /// 
        /// <returns>Returns a  ListCloudFrontOriginAccessIdentitiesResult from CloudFront.</returns>
        ListCloudFrontOriginAccessIdentitiesResponse EndListCloudFrontOriginAccessIdentities(IAsyncResult asyncResult);

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
        ListDistributionsResponse ListDistributions(ListDistributionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributions
        ///         operation.</returns>
        IAsyncResult BeginListDistributions(ListDistributionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributions.</param>
        /// 
        /// <returns>Returns a  ListDistributionsResult from CloudFront.</returns>
        ListDistributionsResponse EndListDistributions(IAsyncResult asyncResult);

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
        ListDistributionsByWebACLIdResponse ListDistributionsByWebACLId(ListDistributionsByWebACLIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByWebACLId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByWebACLId operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByWebACLId
        ///         operation.</returns>
        IAsyncResult BeginListDistributionsByWebACLId(ListDistributionsByWebACLIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByWebACLId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByWebACLId.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByWebACLIdResult from CloudFront.</returns>
        ListDistributionsByWebACLIdResponse EndListDistributionsByWebACLId(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInvalidations


        /// <summary>
        /// List invalidation batches.
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
        ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvalidations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvalidations
        ///         operation.</returns>
        IAsyncResult BeginListInvalidations(ListInvalidationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvalidations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvalidations.</param>
        /// 
        /// <returns>Returns a  ListInvalidationsResult from CloudFront.</returns>
        ListInvalidationsResponse EndListInvalidations(IAsyncResult asyncResult);

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
        ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamingDistributions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreamingDistributions
        ///         operation.</returns>
        IAsyncResult BeginListStreamingDistributions(ListStreamingDistributionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamingDistributions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamingDistributions.</param>
        /// 
        /// <returns>Returns a  ListStreamingDistributionsResult from CloudFront.</returns>
        ListStreamingDistributionsResponse EndListStreamingDistributions(IAsyncResult asyncResult);

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
        /// The specified tagging for a CloudFront resource is invalid. For more information,
        /// see the error text.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// The specified CloudFront resource does not exist.
        /// </exception>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CloudFront.</returns>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// The specified tagging for a CloudFront resource is invalid. For more information,
        /// see the error text.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// The specified CloudFront resource does not exist.
        /// </exception>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CloudFront.</returns>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// The specified tagging for a CloudFront resource is invalid. For more information,
        /// see the error text.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// The specified CloudFront resource does not exist.
        /// </exception>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CloudFront.</returns>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Origin and CallerReference cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        IAsyncResult BeginUpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  UpdateCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        UpdateCloudFrontOriginAccessIdentityResponse EndUpdateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDistribution


        /// <summary>
        /// Update a distribution.
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
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and CallerReference cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
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
        /// for the whitelisted list of cookie names. Either list of cookie names has been specified
        /// when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
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
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the RequiredProtocols element from your distribution configuration.
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
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified Origin Id.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create anymore cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom ssl certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create anymore origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDistribution
        ///         operation.</returns>
        IAsyncResult BeginUpdateDistribution(UpdateDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDistribution.</param>
        /// 
        /// <returns>Returns a  UpdateDistributionResult from CloudFront.</returns>
        UpdateDistributionResponse EndUpdateDistribution(IAsyncResult asyncResult);

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
        /// Origin and CallerReference cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStreamingDistribution
        ///         operation.</returns>
        IAsyncResult BeginUpdateStreamingDistribution(UpdateStreamingDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  UpdateStreamingDistributionResult from CloudFront.</returns>
        UpdateStreamingDistributionResponse EndUpdateStreamingDistribution(IAsyncResult asyncResult);

        #endregion
        
    }
}