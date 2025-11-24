/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudFront.Model;

#pragma warning disable CS1570
namespace Amazon.CloudFront
{
    /// <summary>
    /// <para>Interface for accessing CloudFront</para>
    ///
    /// Amazon CloudFront 
    /// <para>
    /// This is the <i>Amazon CloudFront API Reference</i>. This guide is for developers who
    /// need detailed information about CloudFront API actions, data types, and errors. For
    /// detailed information about CloudFront features, see the <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Introduction.html">Amazon
    /// CloudFront Developer Guide</a>.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudFront : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudFrontPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateAlias


        /// <summary>
        /// <note> 
        /// <para>
        /// The <c>AssociateAlias</c> API operation only supports standard distributions. To move
        /// domains between distribution tenants and/or standard distributions, we recommend that
        /// you use the <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDomainAssociation.html">UpdateDomainAssociation</a>
        /// API operation instead.
        /// 
        ///  </note> 
        /// <para>
        /// Associates an alias with a CloudFront standard distribution. An alias is commonly
        /// known as a custom domain or vanity domain. It can also be called a CNAME or alternate
        /// domain name.
        /// </para>
        ///  
        /// <para>
        /// With this operation, you can move an alias that's already used for a standard distribution
        /// to a different standard distribution. This prevents the downtime that could occur
        /// if you first remove the alias from one standard distribution and then separately add
        /// the alias to another standard distribution.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, specify the alias and the ID of the target standard distribution.
        /// </para>
        ///  
        /// <para>
        /// For more information, including how to set up the target standard distribution, prerequisites
        /// that you must complete, and other restrictions, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
        /// an alternate domain name to a different standard distribution or distribution tenant</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAlias service method.</param>
        /// 
        /// <returns>The response from the AssociateAlias service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateAlias">REST API Reference for AssociateAlias Operation</seealso>
        AssociateAliasResponse AssociateAlias(AssociateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAlias operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateAlias">REST API Reference for AssociateAlias Operation</seealso>
        IAsyncResult BeginAssociateAlias(AssociateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAlias.</param>
        /// 
        /// <returns>Returns a  AssociateAliasResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateAlias">REST API Reference for AssociateAlias Operation</seealso>
        AssociateAliasResponse EndAssociateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateDistributionTenantWebACL


        /// <summary>
        /// Associates the WAF web ACL with a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDistributionTenantWebACL service method.</param>
        /// 
        /// <returns>The response from the AssociateDistributionTenantWebACL service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateDistributionTenantWebACL">REST API Reference for AssociateDistributionTenantWebACL Operation</seealso>
        AssociateDistributionTenantWebACLResponse AssociateDistributionTenantWebACL(AssociateDistributionTenantWebACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDistributionTenantWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDistributionTenantWebACL operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDistributionTenantWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateDistributionTenantWebACL">REST API Reference for AssociateDistributionTenantWebACL Operation</seealso>
        IAsyncResult BeginAssociateDistributionTenantWebACL(AssociateDistributionTenantWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDistributionTenantWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDistributionTenantWebACL.</param>
        /// 
        /// <returns>Returns a  AssociateDistributionTenantWebACLResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateDistributionTenantWebACL">REST API Reference for AssociateDistributionTenantWebACL Operation</seealso>
        AssociateDistributionTenantWebACLResponse EndAssociateDistributionTenantWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateDistributionWebACL


        /// <summary>
        /// Associates the WAF web ACL with a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDistributionWebACL service method.</param>
        /// 
        /// <returns>The response from the AssociateDistributionWebACL service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateDistributionWebACL">REST API Reference for AssociateDistributionWebACL Operation</seealso>
        AssociateDistributionWebACLResponse AssociateDistributionWebACL(AssociateDistributionWebACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDistributionWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDistributionWebACL operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDistributionWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateDistributionWebACL">REST API Reference for AssociateDistributionWebACL Operation</seealso>
        IAsyncResult BeginAssociateDistributionWebACL(AssociateDistributionWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDistributionWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDistributionWebACL.</param>
        /// 
        /// <returns>Returns a  AssociateDistributionWebACLResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateDistributionWebACL">REST API Reference for AssociateDistributionWebACL Operation</seealso>
        AssociateDistributionWebACLResponse EndAssociateDistributionWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  CopyDistribution


        /// <summary>
        /// Creates a staging distribution using the configuration of the provided primary distribution.
        /// A staging distribution is a copy of an existing distribution (called the primary distribution)
        /// that you can use in a continuous deployment workflow.
        /// 
        ///  
        /// <para>
        /// After you create a staging distribution, you can use <c>UpdateDistribution</c> to
        /// modify the staging distribution's configuration. Then you can use <c>CreateContinuousDeploymentPolicy</c>
        /// to incrementally move traffic to the staging distribution.
        /// </para>
        ///  
        /// <para>
        /// This API operation requires the following IAM permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_GetDistribution.html">GetDistribution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_CreateDistribution.html">CreateDistribution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_CopyDistribution.html">CopyDistribution</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDistribution service method.</param>
        /// 
        /// <returns>The response from the CopyDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
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
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// An invalid error code was specified.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <c>whitelisted</c> list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidFunctionAssociationException">
        /// A CloudFront function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// The specified geo restriction parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// The headers specified are not valid for an Amazon S3 origin.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda@Edge function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// The location code specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// The minimum protocol version specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// The keep alive timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// The read timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// The query string parameters specified are not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <c>RequiredProtocols</c> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// A response code is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// The TTL order specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// A viewer certificate specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <c>Origin Id</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigOwnerMismatchException">
        /// The specified real-time log configuration belongs to a different Amazon Web Services
        /// account.
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
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToCachePolicyException">
        /// The maximum number of distributions have been associated with the specified cache
        /// policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToKeyGroupException">
        /// The number of distributions that reference this key group is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginAccessControlException">
        /// The maximum number of distributions have been associated with the specified origin
        /// access control.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginRequestPolicyException">
        /// The maximum number of distributions have been associated with the specified origin
        /// request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToResponseHeadersPolicyException">
        /// The maximum number of distributions have been associated with the specified response
        /// headers policy.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithFunctionAssociationsException">
        /// You have reached the maximum number of distributions that are associated with a CloudFront
        /// function. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda@Edge
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithSingleFunctionARNException">
        /// The maximum number of distributions have been associated with the specified Lambda@Edge
        /// function.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionAssociationsException">
        /// You have reached the maximum number of CloudFront function associations for this distribution.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// Your request contains too many headers in forwarded values.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsAssociatedToDistributionException">
        /// The number of key groups referenced by this distribution is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda@Edge function associations than are allowed per
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// Your request contains too many origin custom headers.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginGroupsPerDistributionException">
        /// Processing your request would cause you to exceed the maximum number of origin groups
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// Your request contains too many query string parameters.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedKeyGroupDoesNotExistException">
        /// The specified key group does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CopyDistribution">REST API Reference for CopyDistribution Operation</seealso>
        CopyDistributionResponse CopyDistribution(CopyDistributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CopyDistribution">REST API Reference for CopyDistribution Operation</seealso>
        IAsyncResult BeginCopyDistribution(CopyDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyDistribution.</param>
        /// 
        /// <returns>Returns a  CopyDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CopyDistribution">REST API Reference for CopyDistribution Operation</seealso>
        CopyDistributionResponse EndCopyDistribution(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAnycastIpList


        /// <summary>
        /// Creates an Anycast static IP list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnycastIpList service method.</param>
        /// 
        /// <returns>The response from the CreateAnycastIpList service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateAnycastIpList">REST API Reference for CreateAnycastIpList Operation</seealso>
        CreateAnycastIpListResponse CreateAnycastIpList(CreateAnycastIpListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAnycastIpList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnycastIpList operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnycastIpList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateAnycastIpList">REST API Reference for CreateAnycastIpList Operation</seealso>
        IAsyncResult BeginCreateAnycastIpList(CreateAnycastIpListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnycastIpList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnycastIpList.</param>
        /// 
        /// <returns>Returns a  CreateAnycastIpListResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateAnycastIpList">REST API Reference for CreateAnycastIpList Operation</seealso>
        CreateAnycastIpListResponse EndCreateAnycastIpList(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCachePolicy


        /// <summary>
        /// Creates a cache policy.
        /// 
        ///  
        /// <para>
        /// After you create a cache policy, you can attach it to one or more cache behaviors.
        /// When it's attached to a cache behavior, the cache policy determines the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The values that CloudFront includes in the <i>cache key</i>. These values can include
        /// HTTP headers, cookies, and URL query strings. CloudFront uses the cache key to find
        /// an object in its cache that it can return to the viewer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The default, minimum, and maximum time to live (TTL) values that you want objects
        /// to stay in the CloudFront cache.
        /// </para>
        ///  <important> 
        /// <para>
        /// If your minimum TTL is greater than 0, CloudFront will cache content for at least
        /// the duration specified in the cache policy's minimum TTL, even if the <c>Cache-Control:
        /// no-cache</c>, <c>no-store</c>, or <c>private</c> directives are present in the origin
        /// headers.
        /// </para>
        ///  </important> </li> </ul> 
        /// <para>
        /// The headers, cookies, and query strings that are included in the cache key are also
        /// included in requests that CloudFront sends to the origin. CloudFront sends a request
        /// when it can't find an object in its cache that matches the request's cache key. If
        /// you want to send values to the origin but <i>not</i> include them in the cache key,
        /// use <c>OriginRequestPolicy</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about cache policies, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html">Controlling
        /// the cache key</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCachePolicy service method.</param>
        /// 
        /// <returns>The response from the CreateCachePolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CachePolicyAlreadyExistsException">
        /// A cache policy with this name already exists. You must provide a unique name. To modify
        /// an existing cache policy, use <c>UpdateCachePolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCachePoliciesException">
        /// You have reached the maximum number of cache policies for this Amazon Web Services
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookiesInCachePolicyException">
        /// The number of cookies in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInCachePolicyException">
        /// The number of headers in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringsInCachePolicyException">
        /// The number of query strings in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateCachePolicy">REST API Reference for CreateCachePolicy Operation</seealso>
        CreateCachePolicyResponse CreateCachePolicy(CreateCachePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCachePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCachePolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCachePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateCachePolicy">REST API Reference for CreateCachePolicy Operation</seealso>
        IAsyncResult BeginCreateCachePolicy(CreateCachePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCachePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCachePolicy.</param>
        /// 
        /// <returns>Returns a  CreateCachePolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateCachePolicy">REST API Reference for CreateCachePolicy Operation</seealso>
        CreateCachePolicyResponse EndCreateCachePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCloudFrontOriginAccessIdentity


        /// <summary>
        /// Creates a new origin access identity. If you're using Amazon S3 for your origin, you
        /// can use an origin access identity to require users to access your content using a
        /// CloudFront URL instead of the Amazon S3 URL. For more information about how to use
        /// origin access identities, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the CreateCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityAlreadyExistsException">
        /// If the <c>CallerReference</c> is a value you already sent in a previous request to
        /// create an identity but the content of the <c>CloudFrontOriginAccessIdentityConfig</c>
        /// is different from the original request, CloudFront returns a <c>CloudFrontOriginAccessIdentityAlreadyExists</c>
        /// error.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCloudFrontOriginAccessIdentitiesException">
        /// Processing your request would cause you to exceed the maximum number of origin access
        /// identities allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateCloudFrontOriginAccessIdentity">REST API Reference for CreateCloudFrontOriginAccessIdentity Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateCloudFrontOriginAccessIdentity">REST API Reference for CreateCloudFrontOriginAccessIdentity Operation</seealso>
        IAsyncResult BeginCreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  CreateCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateCloudFrontOriginAccessIdentity">REST API Reference for CreateCloudFrontOriginAccessIdentity Operation</seealso>
        CreateCloudFrontOriginAccessIdentityResponse EndCreateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConnectionFunction


        /// <summary>
        /// Creates a connection function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionFunction service method.</param>
        /// 
        /// <returns>The response from the CreateConnectionFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntitySizeLimitExceededException">
        /// The entity size limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateConnectionFunction">REST API Reference for CreateConnectionFunction Operation</seealso>
        CreateConnectionFunctionResponse CreateConnectionFunction(CreateConnectionFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnectionFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateConnectionFunction">REST API Reference for CreateConnectionFunction Operation</seealso>
        IAsyncResult BeginCreateConnectionFunction(CreateConnectionFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectionFunction.</param>
        /// 
        /// <returns>Returns a  CreateConnectionFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateConnectionFunction">REST API Reference for CreateConnectionFunction Operation</seealso>
        CreateConnectionFunctionResponse EndCreateConnectionFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConnectionGroup


        /// <summary>
        /// Creates a connection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionGroup service method.</param>
        /// 
        /// <returns>The response from the CreateConnectionGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateConnectionGroup">REST API Reference for CreateConnectionGroup Operation</seealso>
        CreateConnectionGroupResponse CreateConnectionGroup(CreateConnectionGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnectionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionGroup operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnectionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateConnectionGroup">REST API Reference for CreateConnectionGroup Operation</seealso>
        IAsyncResult BeginCreateConnectionGroup(CreateConnectionGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectionGroup.</param>
        /// 
        /// <returns>Returns a  CreateConnectionGroupResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateConnectionGroup">REST API Reference for CreateConnectionGroup Operation</seealso>
        CreateConnectionGroupResponse EndCreateConnectionGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateContinuousDeploymentPolicy


        /// <summary>
        /// Creates a continuous deployment policy that distributes traffic for a custom domain
        /// name to two different CloudFront distributions.
        /// 
        ///  
        /// <para>
        /// To use a continuous deployment policy, first use <c>CopyDistribution</c> to create
        /// a staging distribution, then use <c>UpdateDistribution</c> to modify the staging distribution's
        /// configuration.
        /// </para>
        ///  
        /// <para>
        /// After you create and update a staging distribution, you can use a continuous deployment
        /// policy to incrementally move traffic to the staging distribution. This workflow enables
        /// you to test changes to a distribution's configuration before moving all of your domain's
        /// production traffic to the new configuration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContinuousDeploymentPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateContinuousDeploymentPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ContinuousDeploymentPolicyAlreadyExistsException">
        /// A continuous deployment policy with this configuration already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StagingDistributionInUseException">
        /// A continuous deployment policy for this staging distribution already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyContinuousDeploymentPoliciesException">
        /// You have reached the maximum number of continuous deployment policies for this Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateContinuousDeploymentPolicy">REST API Reference for CreateContinuousDeploymentPolicy Operation</seealso>
        CreateContinuousDeploymentPolicyResponse CreateContinuousDeploymentPolicy(CreateContinuousDeploymentPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContinuousDeploymentPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContinuousDeploymentPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContinuousDeploymentPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateContinuousDeploymentPolicy">REST API Reference for CreateContinuousDeploymentPolicy Operation</seealso>
        IAsyncResult BeginCreateContinuousDeploymentPolicy(CreateContinuousDeploymentPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContinuousDeploymentPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContinuousDeploymentPolicy.</param>
        /// 
        /// <returns>Returns a  CreateContinuousDeploymentPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateContinuousDeploymentPolicy">REST API Reference for CreateContinuousDeploymentPolicy Operation</seealso>
        CreateContinuousDeploymentPolicyResponse EndCreateContinuousDeploymentPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDistribution


        /// <summary>
        /// Creates a CloudFront distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution service method.</param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ContinuousDeploymentPolicyInUseException">
        /// You cannot delete a continuous deployment policy that is associated with a primary
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionAlreadyExistsException">
        /// The caller reference you attempted to create the distribution with is associated with
        /// another distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalOriginAccessConfigurationException">
        /// An origin cannot contain both an origin access control (OAC) and an origin access
        /// identity (OAI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDomainNameForOriginAccessControlException">
        /// An origin access control is associated with an origin whose domain name is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// An invalid error code was specified.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <c>whitelisted</c> list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidFunctionAssociationException">
        /// A CloudFront function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// The specified geo restriction parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// The headers specified are not valid for an Amazon S3 origin.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda@Edge function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// The location code specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// The minimum protocol version specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// The keep alive timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// The read timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// The query string parameters specified are not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <c>RequiredProtocols</c> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// A response code is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// The TTL order specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// A viewer certificate specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <c>Origin Id</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigOwnerMismatchException">
        /// The specified real-time log configuration belongs to a different Amazon Web Services
        /// account.
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
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToCachePolicyException">
        /// The maximum number of distributions have been associated with the specified cache
        /// policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToKeyGroupException">
        /// The number of distributions that reference this key group is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginAccessControlException">
        /// The maximum number of distributions have been associated with the specified origin
        /// access control.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginRequestPolicyException">
        /// The maximum number of distributions have been associated with the specified origin
        /// request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToResponseHeadersPolicyException">
        /// The maximum number of distributions have been associated with the specified response
        /// headers policy.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithFunctionAssociationsException">
        /// You have reached the maximum number of distributions that are associated with a CloudFront
        /// function. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda@Edge
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithSingleFunctionARNException">
        /// The maximum number of distributions have been associated with the specified Lambda@Edge
        /// function.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionAssociationsException">
        /// You have reached the maximum number of CloudFront function associations for this distribution.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// Your request contains too many headers in forwarded values.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsAssociatedToDistributionException">
        /// The number of key groups referenced by this distribution is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda@Edge function associations than are allowed per
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// Your request contains too many origin custom headers.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginGroupsPerDistributionException">
        /// Processing your request would cause you to exceed the maximum number of origin groups
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// Your request contains too many query string parameters.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedKeyGroupDoesNotExistException">
        /// The specified key group does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        IAsyncResult BeginCreateDistribution(CreateDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistribution.</param>
        /// 
        /// <returns>Returns a  CreateDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        CreateDistributionResponse EndCreateDistribution(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDistributionTenant


        /// <summary>
        /// Creates a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionTenant service method.</param>
        /// 
        /// <returns>The response from the CreateDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidAssociationException">
        /// The specified CloudFront resource can't be associated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistributionTenant">REST API Reference for CreateDistributionTenant Operation</seealso>
        CreateDistributionTenantResponse CreateDistributionTenant(CreateDistributionTenantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionTenant operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDistributionTenant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistributionTenant">REST API Reference for CreateDistributionTenant Operation</seealso>
        IAsyncResult BeginCreateDistributionTenant(CreateDistributionTenantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistributionTenant.</param>
        /// 
        /// <returns>Returns a  CreateDistributionTenantResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistributionTenant">REST API Reference for CreateDistributionTenant Operation</seealso>
        CreateDistributionTenantResponse EndCreateDistributionTenant(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDistributionWithTags


        /// <summary>
        /// Create a new distribution with tags. This API operation requires the following IAM
        /// permissions:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_CreateDistribution.html">CreateDistribution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_TagResource.html">TagResource</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionWithTags service method.</param>
        /// 
        /// <returns>The response from the CreateDistributionWithTags service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ContinuousDeploymentPolicyInUseException">
        /// You cannot delete a continuous deployment policy that is associated with a primary
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionAlreadyExistsException">
        /// The caller reference you attempted to create the distribution with is associated with
        /// another distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalOriginAccessConfigurationException">
        /// An origin cannot contain both an origin access control (OAC) and an origin access
        /// identity (OAI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDomainNameForOriginAccessControlException">
        /// An origin access control is associated with an origin whose domain name is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// An invalid error code was specified.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <c>whitelisted</c> list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidFunctionAssociationException">
        /// A CloudFront function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// The specified geo restriction parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// The headers specified are not valid for an Amazon S3 origin.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda@Edge function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// The location code specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// The minimum protocol version specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// The keep alive timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// The read timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// The query string parameters specified are not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <c>RequiredProtocols</c> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// A response code is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// The TTL order specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// A viewer certificate specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <c>Origin Id</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigOwnerMismatchException">
        /// The specified real-time log configuration belongs to a different Amazon Web Services
        /// account.
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
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToCachePolicyException">
        /// The maximum number of distributions have been associated with the specified cache
        /// policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToKeyGroupException">
        /// The number of distributions that reference this key group is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginAccessControlException">
        /// The maximum number of distributions have been associated with the specified origin
        /// access control.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginRequestPolicyException">
        /// The maximum number of distributions have been associated with the specified origin
        /// request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToResponseHeadersPolicyException">
        /// The maximum number of distributions have been associated with the specified response
        /// headers policy.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithFunctionAssociationsException">
        /// You have reached the maximum number of distributions that are associated with a CloudFront
        /// function. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda@Edge
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithSingleFunctionARNException">
        /// The maximum number of distributions have been associated with the specified Lambda@Edge
        /// function.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionAssociationsException">
        /// You have reached the maximum number of CloudFront function associations for this distribution.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// Your request contains too many headers in forwarded values.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsAssociatedToDistributionException">
        /// The number of key groups referenced by this distribution is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda@Edge function associations than are allowed per
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// Your request contains too many origin custom headers.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginGroupsPerDistributionException">
        /// Processing your request would cause you to exceed the maximum number of origin groups
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// Your request contains too many query string parameters.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedKeyGroupDoesNotExistException">
        /// The specified key group does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistributionWithTags">REST API Reference for CreateDistributionWithTags Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistributionWithTags">REST API Reference for CreateDistributionWithTags Operation</seealso>
        IAsyncResult BeginCreateDistributionWithTags(CreateDistributionWithTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistributionWithTags.</param>
        /// 
        /// <returns>Returns a  CreateDistributionWithTagsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistributionWithTags">REST API Reference for CreateDistributionWithTags Operation</seealso>
        CreateDistributionWithTagsResponse EndCreateDistributionWithTags(IAsyncResult asyncResult);

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
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFieldLevelEncryptionConfig">REST API Reference for CreateFieldLevelEncryptionConfig Operation</seealso>
        CreateFieldLevelEncryptionConfigResponse CreateFieldLevelEncryptionConfig(CreateFieldLevelEncryptionConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFieldLevelEncryptionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFieldLevelEncryptionConfig">REST API Reference for CreateFieldLevelEncryptionConfig Operation</seealso>
        IAsyncResult BeginCreateFieldLevelEncryptionConfig(CreateFieldLevelEncryptionConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFieldLevelEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  CreateFieldLevelEncryptionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFieldLevelEncryptionConfig">REST API Reference for CreateFieldLevelEncryptionConfig Operation</seealso>
        CreateFieldLevelEncryptionConfigResponse EndCreateFieldLevelEncryptionConfig(IAsyncResult asyncResult);

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
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFieldLevelEncryptionProfile">REST API Reference for CreateFieldLevelEncryptionProfile Operation</seealso>
        CreateFieldLevelEncryptionProfileResponse CreateFieldLevelEncryptionProfile(CreateFieldLevelEncryptionProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionProfile operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFieldLevelEncryptionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFieldLevelEncryptionProfile">REST API Reference for CreateFieldLevelEncryptionProfile Operation</seealso>
        IAsyncResult BeginCreateFieldLevelEncryptionProfile(CreateFieldLevelEncryptionProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFieldLevelEncryptionProfile.</param>
        /// 
        /// <returns>Returns a  CreateFieldLevelEncryptionProfileResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFieldLevelEncryptionProfile">REST API Reference for CreateFieldLevelEncryptionProfile Operation</seealso>
        CreateFieldLevelEncryptionProfileResponse EndCreateFieldLevelEncryptionProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFunction


        /// <summary>
        /// Creates a CloudFront function.
        /// 
        ///  
        /// <para>
        /// To create a function, you provide the function code and some configuration information
        /// about the function. The response contains an Amazon Resource Name (ARN) that uniquely
        /// identifies the function.
        /// </para>
        ///  
        /// <para>
        /// When you create a function, it's in the <c>DEVELOPMENT</c> stage. In this stage, you
        /// can test the function with <c>TestFunction</c>, and update it with <c>UpdateFunction</c>.
        /// </para>
        ///  
        /// <para>
        /// When you're ready to use your function with a CloudFront distribution, use <c>PublishFunction</c>
        /// to copy the function from the <c>DEVELOPMENT</c> stage to <c>LIVE</c>. When it's live,
        /// you can attach the function to a distribution's cache behavior, using the function's
        /// ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction service method.</param>
        /// 
        /// <returns>The response from the CreateFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FunctionAlreadyExistsException">
        /// A function with the same name already exists in this Amazon Web Services account.
        /// To create a function, you must provide a unique name. To update an existing function,
        /// use <c>UpdateFunction</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FunctionSizeLimitExceededException">
        /// The function is too large. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionsException">
        /// You have reached the maximum number of CloudFront functions for this Amazon Web Services
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        CreateFunctionResponse CreateFunction(CreateFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        IAsyncResult BeginCreateFunction(CreateFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFunction.</param>
        /// 
        /// <returns>Returns a  CreateFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        CreateFunctionResponse EndCreateFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInvalidation


        /// <summary>
        /// Create a new invalidation. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Invalidation.html">Invalidating
        /// files</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation service method.</param>
        /// 
        /// <returns>The response from the CreateInvalidation service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.BatchTooLargeException">
        /// Invalidation batch specified is too large.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyInvalidationsInProgressException">
        /// You have exceeded the maximum number of allowable InProgress invalidation batch requests,
        /// or invalidation objects.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateInvalidation">REST API Reference for CreateInvalidation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateInvalidation">REST API Reference for CreateInvalidation Operation</seealso>
        IAsyncResult BeginCreateInvalidation(CreateInvalidationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInvalidation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvalidation.</param>
        /// 
        /// <returns>Returns a  CreateInvalidationResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateInvalidation">REST API Reference for CreateInvalidation Operation</seealso>
        CreateInvalidationResponse EndCreateInvalidation(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInvalidationForDistributionTenant


        /// <summary>
        /// Creates an invalidation for a distribution tenant. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Invalidation.html">Invalidating
        /// files</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidationForDistributionTenant service method.</param>
        /// 
        /// <returns>The response from the CreateInvalidationForDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.BatchTooLargeException">
        /// Invalidation batch specified is too large.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyInvalidationsInProgressException">
        /// You have exceeded the maximum number of allowable InProgress invalidation batch requests,
        /// or invalidation objects.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateInvalidationForDistributionTenant">REST API Reference for CreateInvalidationForDistributionTenant Operation</seealso>
        CreateInvalidationForDistributionTenantResponse CreateInvalidationForDistributionTenant(CreateInvalidationForDistributionTenantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvalidationForDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidationForDistributionTenant operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInvalidationForDistributionTenant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateInvalidationForDistributionTenant">REST API Reference for CreateInvalidationForDistributionTenant Operation</seealso>
        IAsyncResult BeginCreateInvalidationForDistributionTenant(CreateInvalidationForDistributionTenantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInvalidationForDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvalidationForDistributionTenant.</param>
        /// 
        /// <returns>Returns a  CreateInvalidationForDistributionTenantResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateInvalidationForDistributionTenant">REST API Reference for CreateInvalidationForDistributionTenant Operation</seealso>
        CreateInvalidationForDistributionTenantResponse EndCreateInvalidationForDistributionTenant(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKeyGroup


        /// <summary>
        /// Creates a key group that you can use with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">CloudFront
        /// signed URLs and signed cookies</a>.
        /// 
        ///  
        /// <para>
        /// To create a key group, you must specify at least one public key for the key group.
        /// After you create a key group, you can reference it from one or more cache behaviors.
        /// When you reference a key group in a cache behavior, CloudFront requires signed URLs
        /// or signed cookies for all requests that match the cache behavior. The URLs or cookies
        /// must be signed with a private key whose corresponding public key is in the key group.
        /// The signed URL or cookie contains information about which public key CloudFront should
        /// use to verify the signature. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// private content</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyGroup service method.</param>
        /// 
        /// <returns>The response from the CreateKeyGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.KeyGroupAlreadyExistsException">
        /// A key group with this name already exists. You must provide a unique name. To modify
        /// an existing key group, use <c>UpdateKeyGroup</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsException">
        /// You have reached the maximum number of key groups for this Amazon Web Services account.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyPublicKeysInKeyGroupException">
        /// The number of public keys in this key group is more than the maximum allowed. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateKeyGroup">REST API Reference for CreateKeyGroup Operation</seealso>
        CreateKeyGroupResponse CreateKeyGroup(CreateKeyGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyGroup operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKeyGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateKeyGroup">REST API Reference for CreateKeyGroup Operation</seealso>
        IAsyncResult BeginCreateKeyGroup(CreateKeyGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKeyGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKeyGroup.</param>
        /// 
        /// <returns>Returns a  CreateKeyGroupResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateKeyGroup">REST API Reference for CreateKeyGroup Operation</seealso>
        CreateKeyGroupResponse EndCreateKeyGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKeyValueStore


        /// <summary>
        /// Specifies the key value store resource to add to your account. In your account, the
        /// key value store names must be unique. You can also import key value store data in
        /// JSON format from an S3 bucket by providing a valid <c>ImportSource</c> that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyValueStore service method.</param>
        /// 
        /// <returns>The response from the CreateKeyValueStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntitySizeLimitExceededException">
        /// The entity size limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateKeyValueStore">REST API Reference for CreateKeyValueStore Operation</seealso>
        CreateKeyValueStoreResponse CreateKeyValueStore(CreateKeyValueStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyValueStore operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKeyValueStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateKeyValueStore">REST API Reference for CreateKeyValueStore Operation</seealso>
        IAsyncResult BeginCreateKeyValueStore(CreateKeyValueStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKeyValueStore.</param>
        /// 
        /// <returns>Returns a  CreateKeyValueStoreResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateKeyValueStore">REST API Reference for CreateKeyValueStore Operation</seealso>
        CreateKeyValueStoreResponse EndCreateKeyValueStore(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMonitoringSubscription


        /// <summary>
        /// Enables or disables additional Amazon CloudWatch metrics for the specified CloudFront
        /// distribution. The additional metrics incur an additional cost.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/viewing-cloudfront-metrics.html#monitoring-console.distributions-additional">Viewing
        /// additional CloudFront distribution metrics</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitoringSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateMonitoringSubscription service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MonitoringSubscriptionAlreadyExistsException">
        /// A monitoring subscription already exists for the specified distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateMonitoringSubscription">REST API Reference for CreateMonitoringSubscription Operation</seealso>
        CreateMonitoringSubscriptionResponse CreateMonitoringSubscription(CreateMonitoringSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMonitoringSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitoringSubscription operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMonitoringSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateMonitoringSubscription">REST API Reference for CreateMonitoringSubscription Operation</seealso>
        IAsyncResult BeginCreateMonitoringSubscription(CreateMonitoringSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMonitoringSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMonitoringSubscription.</param>
        /// 
        /// <returns>Returns a  CreateMonitoringSubscriptionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateMonitoringSubscription">REST API Reference for CreateMonitoringSubscription Operation</seealso>
        CreateMonitoringSubscriptionResponse EndCreateMonitoringSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOriginAccessControl


        /// <summary>
        /// Creates a new origin access control in CloudFront. After you create an origin access
        /// control, you can add it to an origin in a CloudFront distribution so that CloudFront
        /// sends authenticated (signed) requests to the origin.
        /// 
        ///  
        /// <para>
        /// This makes it possible to block public access to the origin, allowing viewers (users)
        /// to access the origin's content only through CloudFront.
        /// </para>
        ///  
        /// <para>
        /// For more information about using a CloudFront origin access control, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-restricting-access-to-origin.html">Restricting
        /// access to an Amazon Web Services origin</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginAccessControl service method.</param>
        /// 
        /// <returns>The response from the CreateOriginAccessControl service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginAccessControlAlreadyExistsException">
        /// An origin access control with the specified parameters already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginAccessControlsException">
        /// The number of origin access controls in your Amazon Web Services account exceeds the
        /// maximum allowed.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateOriginAccessControl">REST API Reference for CreateOriginAccessControl Operation</seealso>
        CreateOriginAccessControlResponse CreateOriginAccessControl(CreateOriginAccessControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOriginAccessControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginAccessControl operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOriginAccessControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateOriginAccessControl">REST API Reference for CreateOriginAccessControl Operation</seealso>
        IAsyncResult BeginCreateOriginAccessControl(CreateOriginAccessControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOriginAccessControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOriginAccessControl.</param>
        /// 
        /// <returns>Returns a  CreateOriginAccessControlResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateOriginAccessControl">REST API Reference for CreateOriginAccessControl Operation</seealso>
        CreateOriginAccessControlResponse EndCreateOriginAccessControl(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOriginRequestPolicy


        /// <summary>
        /// Creates an origin request policy.
        /// 
        ///  
        /// <para>
        /// After you create an origin request policy, you can attach it to one or more cache
        /// behaviors. When it's attached to a cache behavior, the origin request policy determines
        /// the values that CloudFront includes in requests that it sends to the origin. Each
        /// request that CloudFront sends to the origin includes the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The request body and the URL path (without the domain name) from the viewer request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The headers that CloudFront automatically includes in every origin request, including
        /// <c>Host</c>, <c>User-Agent</c>, and <c>X-Amz-Cf-Id</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All HTTP headers, cookies, and URL query strings that are specified in the cache policy
        /// or the origin request policy. These can include items from the viewer request and,
        /// in the case of headers, additional ones that are added by CloudFront.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// CloudFront sends a request when it can't find a valid object in its cache that matches
        /// the request. If you want to send values to the origin and also include them in the
        /// cache key, use <c>CachePolicy</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about origin request policies, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-origin-requests.html">Controlling
        /// origin requests</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginRequestPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateOriginRequestPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginRequestPolicyAlreadyExistsException">
        /// An origin request policy with this name already exists. You must provide a unique
        /// name. To modify an existing origin request policy, use <c>UpdateOriginRequestPolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookiesInOriginRequestPolicyException">
        /// The number of cookies in the origin request policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInOriginRequestPolicyException">
        /// The number of headers in the origin request policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginRequestPoliciesException">
        /// You have reached the maximum number of origin request policies for this Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringsInOriginRequestPolicyException">
        /// The number of query strings in the origin request policy exceeds the maximum. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateOriginRequestPolicy">REST API Reference for CreateOriginRequestPolicy Operation</seealso>
        CreateOriginRequestPolicyResponse CreateOriginRequestPolicy(CreateOriginRequestPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOriginRequestPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginRequestPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOriginRequestPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateOriginRequestPolicy">REST API Reference for CreateOriginRequestPolicy Operation</seealso>
        IAsyncResult BeginCreateOriginRequestPolicy(CreateOriginRequestPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOriginRequestPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOriginRequestPolicy.</param>
        /// 
        /// <returns>Returns a  CreateOriginRequestPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateOriginRequestPolicy">REST API Reference for CreateOriginRequestPolicy Operation</seealso>
        CreateOriginRequestPolicyResponse EndCreateOriginRequestPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePublicKey


        /// <summary>
        /// Uploads a public key to CloudFront that you can use with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">signed
        /// URLs and signed cookies</a>, or with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/field-level-encryption.html">field-level
        /// encryption</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicKey service method.</param>
        /// 
        /// <returns>The response from the CreatePublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PublicKeyAlreadyExistsException">
        /// The specified public key already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyPublicKeysException">
        /// The maximum number of public keys for field-level encryption have been created. To
        /// create a new public key, delete one of the existing keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreatePublicKey">REST API Reference for CreatePublicKey Operation</seealso>
        CreatePublicKeyResponse CreatePublicKey(CreatePublicKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicKey operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreatePublicKey">REST API Reference for CreatePublicKey Operation</seealso>
        IAsyncResult BeginCreatePublicKey(CreatePublicKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePublicKey.</param>
        /// 
        /// <returns>Returns a  CreatePublicKeyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreatePublicKey">REST API Reference for CreatePublicKey Operation</seealso>
        CreatePublicKeyResponse EndCreatePublicKey(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRealtimeLogConfig


        /// <summary>
        /// Creates a real-time log configuration.
        /// 
        ///  
        /// <para>
        /// After you create a real-time log configuration, you can attach it to one or more cache
        /// behaviors to send real-time log data to the specified Amazon Kinesis data stream.
        /// </para>
        ///  
        /// <para>
        /// For more information about real-time log configurations, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/real-time-logs.html">Real-time
        /// logs</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRealtimeLogConfig service method.</param>
        /// 
        /// <returns>The response from the CreateRealtimeLogConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigAlreadyExistsException">
        /// A real-time log configuration with this name already exists. You must provide a unique
        /// name. To modify an existing real-time log configuration, use <c>UpdateRealtimeLogConfig</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyRealtimeLogConfigsException">
        /// You have reached the maximum number of real-time log configurations for this Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateRealtimeLogConfig">REST API Reference for CreateRealtimeLogConfig Operation</seealso>
        CreateRealtimeLogConfigResponse CreateRealtimeLogConfig(CreateRealtimeLogConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRealtimeLogConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRealtimeLogConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRealtimeLogConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateRealtimeLogConfig">REST API Reference for CreateRealtimeLogConfig Operation</seealso>
        IAsyncResult BeginCreateRealtimeLogConfig(CreateRealtimeLogConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRealtimeLogConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRealtimeLogConfig.</param>
        /// 
        /// <returns>Returns a  CreateRealtimeLogConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateRealtimeLogConfig">REST API Reference for CreateRealtimeLogConfig Operation</seealso>
        CreateRealtimeLogConfigResponse EndCreateRealtimeLogConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResponseHeadersPolicy


        /// <summary>
        /// Creates a response headers policy.
        /// 
        ///  
        /// <para>
        /// A response headers policy contains information about a set of HTTP headers. To create
        /// a response headers policy, you provide some metadata about the policy and a set of
        /// configurations that specify the headers.
        /// </para>
        ///  
        /// <para>
        /// After you create a response headers policy, you can use its ID to attach it to one
        /// or more cache behaviors in a CloudFront distribution. When it's attached to a cache
        /// behavior, the response headers policy affects the HTTP headers that CloudFront includes
        /// in HTTP responses to requests that match the cache behavior. CloudFront adds or removes
        /// response headers according to the configuration of the response headers policy.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/modifying-response-headers.html">Adding
        /// or removing HTTP headers in CloudFront responses</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponseHeadersPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateResponseHeadersPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResponseHeadersPolicyAlreadyExistsException">
        /// A response headers policy with this name already exists. You must provide a unique
        /// name. To modify an existing response headers policy, use <c>UpdateResponseHeadersPolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooLongCSPInResponseHeadersPolicyException">
        /// The length of the <c>Content-Security-Policy</c> header value in the response headers
        /// policy exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCustomHeadersInResponseHeadersPolicyException">
        /// The number of custom headers in the response headers policy exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyRemoveHeadersInResponseHeadersPolicyException">
        /// The number of headers in <c>RemoveHeadersConfig</c> in the response headers policy
        /// exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyResponseHeadersPoliciesException">
        /// You have reached the maximum number of response headers policies for this Amazon Web
        /// Services account.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateResponseHeadersPolicy">REST API Reference for CreateResponseHeadersPolicy Operation</seealso>
        CreateResponseHeadersPolicyResponse CreateResponseHeadersPolicy(CreateResponseHeadersPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResponseHeadersPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResponseHeadersPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResponseHeadersPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateResponseHeadersPolicy">REST API Reference for CreateResponseHeadersPolicy Operation</seealso>
        IAsyncResult BeginCreateResponseHeadersPolicy(CreateResponseHeadersPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResponseHeadersPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResponseHeadersPolicy.</param>
        /// 
        /// <returns>Returns a  CreateResponseHeadersPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateResponseHeadersPolicy">REST API Reference for CreateResponseHeadersPolicy Operation</seealso>
        CreateResponseHeadersPolicyResponse EndCreateResponseHeadersPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStreamingDistribution


        /// <summary>
        /// This API is deprecated. Amazon CloudFront is deprecating real-time messaging protocol
        /// (RTMP) distributions on December 31, 2020. For more information, <a href="http://forums.aws.amazon.com/ann.jspa?annID=7356">read
        /// the announcement</a> on the Amazon CloudFront discussion forum.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionAlreadyExistsException">
        /// The caller reference you attempted to create the streaming distribution with is associated
        /// with another distribution
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateStreamingDistribution">REST API Reference for CreateStreamingDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateStreamingDistribution">REST API Reference for CreateStreamingDistribution Operation</seealso>
        IAsyncResult BeginCreateStreamingDistribution(CreateStreamingDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  CreateStreamingDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateStreamingDistribution">REST API Reference for CreateStreamingDistribution Operation</seealso>
        CreateStreamingDistributionResponse EndCreateStreamingDistribution(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStreamingDistributionWithTags


        /// <summary>
        /// This API is deprecated. Amazon CloudFront is deprecating real-time messaging protocol
        /// (RTMP) distributions on December 31, 2020. For more information, <a href="http://forums.aws.amazon.com/ann.jspa?annID=7356">read
        /// the announcement</a> on the Amazon CloudFront discussion forum.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistributionWithTags service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingDistributionWithTags service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionAlreadyExistsException">
        /// The caller reference you attempted to create the streaming distribution with is associated
        /// with another distribution
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateStreamingDistributionWithTags">REST API Reference for CreateStreamingDistributionWithTags Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateStreamingDistributionWithTags">REST API Reference for CreateStreamingDistributionWithTags Operation</seealso>
        IAsyncResult BeginCreateStreamingDistributionWithTags(CreateStreamingDistributionWithTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingDistributionWithTags.</param>
        /// 
        /// <returns>Returns a  CreateStreamingDistributionWithTagsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateStreamingDistributionWithTags">REST API Reference for CreateStreamingDistributionWithTags Operation</seealso>
        CreateStreamingDistributionWithTagsResponse EndCreateStreamingDistributionWithTags(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrustStore


        /// <summary>
        /// Creates a trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustStore service method.</param>
        /// 
        /// <returns>The response from the CreateTrustStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        CreateTrustStoreResponse CreateTrustStore(CreateTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustStore operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        IAsyncResult BeginCreateTrustStore(CreateTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrustStore.</param>
        /// 
        /// <returns>Returns a  CreateTrustStoreResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        CreateTrustStoreResponse EndCreateTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcOrigin


        /// <summary>
        /// Create an Amazon CloudFront VPC origin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcOrigin service method.</param>
        /// 
        /// <returns>The response from the CreateVpcOrigin service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateVpcOrigin">REST API Reference for CreateVpcOrigin Operation</seealso>
        CreateVpcOriginResponse CreateVpcOrigin(CreateVpcOriginRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcOrigin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcOrigin operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcOrigin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateVpcOrigin">REST API Reference for CreateVpcOrigin Operation</seealso>
        IAsyncResult BeginCreateVpcOrigin(CreateVpcOriginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcOrigin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcOrigin.</param>
        /// 
        /// <returns>Returns a  CreateVpcOriginResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateVpcOrigin">REST API Reference for CreateVpcOrigin Operation</seealso>
        CreateVpcOriginResponse EndCreateVpcOrigin(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAnycastIpList


        /// <summary>
        /// Deletes an Anycast static IP list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnycastIpList service method.</param>
        /// 
        /// <returns>The response from the DeleteAnycastIpList service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotDeleteEntityWhileInUseException">
        /// The entity cannot be deleted while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalDeleteException">
        /// Deletion is not allowed for this entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteAnycastIpList">REST API Reference for DeleteAnycastIpList Operation</seealso>
        DeleteAnycastIpListResponse DeleteAnycastIpList(DeleteAnycastIpListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnycastIpList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnycastIpList operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnycastIpList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteAnycastIpList">REST API Reference for DeleteAnycastIpList Operation</seealso>
        IAsyncResult BeginDeleteAnycastIpList(DeleteAnycastIpListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnycastIpList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnycastIpList.</param>
        /// 
        /// <returns>Returns a  DeleteAnycastIpListResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteAnycastIpList">REST API Reference for DeleteAnycastIpList Operation</seealso>
        DeleteAnycastIpListResponse EndDeleteAnycastIpList(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCachePolicy


        /// <summary>
        /// Deletes a cache policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete a cache policy if it's attached to a cache behavior. First update
        /// your distributions to remove the cache policy from all cache behaviors, then delete
        /// the cache policy.
        /// </para>
        ///  
        /// <para>
        /// To delete a cache policy, you must provide the policy's identifier and version. To
        /// get these values, you can use <c>ListCachePolicies</c> or <c>GetCachePolicy</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCachePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteCachePolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CachePolicyInUseException">
        /// Cannot delete the cache policy because it is attached to one or more cache behaviors.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalDeleteException">
        /// Deletion is not allowed for this entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteCachePolicy">REST API Reference for DeleteCachePolicy Operation</seealso>
        DeleteCachePolicyResponse DeleteCachePolicy(DeleteCachePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCachePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCachePolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCachePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteCachePolicy">REST API Reference for DeleteCachePolicy Operation</seealso>
        IAsyncResult BeginDeleteCachePolicy(DeleteCachePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCachePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCachePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteCachePolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteCachePolicy">REST API Reference for DeleteCachePolicy Operation</seealso>
        DeleteCachePolicyResponse EndDeleteCachePolicy(IAsyncResult asyncResult);

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
        /// The Origin Access Identity specified is already in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
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
        /// The Origin Access Identity specified is already in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        IAsyncResult BeginDeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        DeleteCloudFrontOriginAccessIdentityResponse EndDeleteCloudFrontOriginAccessIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnectionFunction


        /// <summary>
        /// Deletes a connection function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectionFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectionFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotDeleteEntityWhileInUseException">
        /// The entity cannot be deleted while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteConnectionFunction">REST API Reference for DeleteConnectionFunction Operation</seealso>
        DeleteConnectionFunctionResponse DeleteConnectionFunction(DeleteConnectionFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectionFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectionFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteConnectionFunction">REST API Reference for DeleteConnectionFunction Operation</seealso>
        IAsyncResult BeginDeleteConnectionFunction(DeleteConnectionFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectionFunction.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteConnectionFunction">REST API Reference for DeleteConnectionFunction Operation</seealso>
        DeleteConnectionFunctionResponse EndDeleteConnectionFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnectionGroup


        /// <summary>
        /// Deletes a connection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectionGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectionGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotDeleteEntityWhileInUseException">
        /// The entity cannot be deleted while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceNotDisabledException">
        /// The specified CloudFront resource hasn't been disabled yet.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteConnectionGroup">REST API Reference for DeleteConnectionGroup Operation</seealso>
        DeleteConnectionGroupResponse DeleteConnectionGroup(DeleteConnectionGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectionGroup operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteConnectionGroup">REST API Reference for DeleteConnectionGroup Operation</seealso>
        IAsyncResult BeginDeleteConnectionGroup(DeleteConnectionGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectionGroup.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionGroupResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteConnectionGroup">REST API Reference for DeleteConnectionGroup Operation</seealso>
        DeleteConnectionGroupResponse EndDeleteConnectionGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteContinuousDeploymentPolicy


        /// <summary>
        /// Deletes a continuous deployment policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete a continuous deployment policy that's attached to a primary distribution.
        /// First update your distribution to remove the continuous deployment policy, then you
        /// can delete the policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContinuousDeploymentPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteContinuousDeploymentPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ContinuousDeploymentPolicyInUseException">
        /// You cannot delete a continuous deployment policy that is associated with a primary
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteContinuousDeploymentPolicy">REST API Reference for DeleteContinuousDeploymentPolicy Operation</seealso>
        DeleteContinuousDeploymentPolicyResponse DeleteContinuousDeploymentPolicy(DeleteContinuousDeploymentPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContinuousDeploymentPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContinuousDeploymentPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContinuousDeploymentPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteContinuousDeploymentPolicy">REST API Reference for DeleteContinuousDeploymentPolicy Operation</seealso>
        IAsyncResult BeginDeleteContinuousDeploymentPolicy(DeleteContinuousDeploymentPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContinuousDeploymentPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContinuousDeploymentPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteContinuousDeploymentPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteContinuousDeploymentPolicy">REST API Reference for DeleteContinuousDeploymentPolicy Operation</seealso>
        DeleteContinuousDeploymentPolicyResponse EndDeleteContinuousDeploymentPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDistribution


        /// <summary>
        /// Delete a distribution.
        /// 
        ///  <important> 
        /// <para>
        /// Before you can delete a distribution, you must disable it, which requires permission
        /// to update the distribution. Once deleted, a distribution cannot be recovered.
        /// </para>
        ///  </important>
        /// </summary>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionNotDisabledException">
        /// The specified CloudFront distribution is not disabled. You must disable the distribution
        /// before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceInUseException">
        /// Cannot delete this resource because it is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        DeleteDistributionResponse DeleteDistribution();

        /// <summary>
        /// Delete a distribution.
        /// 
        ///  <important> 
        /// <para>
        /// Before you can delete a distribution, you must disable it, which requires permission
        /// to update the distribution. Once deleted, a distribution cannot be recovered.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution service method.</param>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionNotDisabledException">
        /// The specified CloudFront distribution is not disabled. You must disable the distribution
        /// before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceInUseException">
        /// Cannot delete this resource because it is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        IAsyncResult BeginDeleteDistribution(DeleteDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDistribution.</param>
        /// 
        /// <returns>Returns a  DeleteDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        DeleteDistributionResponse EndDeleteDistribution(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDistributionTenant


        /// <summary>
        /// Deletes a distribution tenant. If you use this API operation to delete a distribution
        /// tenant that is currently enabled, the request will fail.
        /// 
        ///  
        /// <para>
        /// To delete a distribution tenant, you must first disable the distribution tenant by
        /// using the <c>UpdateDistributionTenant</c> API operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistributionTenant service method.</param>
        /// 
        /// <returns>The response from the DeleteDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceNotDisabledException">
        /// The specified CloudFront resource hasn't been disabled yet.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteDistributionTenant">REST API Reference for DeleteDistributionTenant Operation</seealso>
        DeleteDistributionTenantResponse DeleteDistributionTenant(DeleteDistributionTenantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistributionTenant operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDistributionTenant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteDistributionTenant">REST API Reference for DeleteDistributionTenant Operation</seealso>
        IAsyncResult BeginDeleteDistributionTenant(DeleteDistributionTenantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDistributionTenant.</param>
        /// 
        /// <returns>Returns a  DeleteDistributionTenantResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteDistributionTenant">REST API Reference for DeleteDistributionTenant Operation</seealso>
        DeleteDistributionTenantResponse EndDeleteDistributionTenant(IAsyncResult asyncResult);

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
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFieldLevelEncryptionConfig">REST API Reference for DeleteFieldLevelEncryptionConfig Operation</seealso>
        DeleteFieldLevelEncryptionConfigResponse DeleteFieldLevelEncryptionConfig(DeleteFieldLevelEncryptionConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFieldLevelEncryptionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFieldLevelEncryptionConfig">REST API Reference for DeleteFieldLevelEncryptionConfig Operation</seealso>
        IAsyncResult BeginDeleteFieldLevelEncryptionConfig(DeleteFieldLevelEncryptionConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFieldLevelEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  DeleteFieldLevelEncryptionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFieldLevelEncryptionConfig">REST API Reference for DeleteFieldLevelEncryptionConfig Operation</seealso>
        DeleteFieldLevelEncryptionConfigResponse EndDeleteFieldLevelEncryptionConfig(IAsyncResult asyncResult);

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
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFieldLevelEncryptionProfile">REST API Reference for DeleteFieldLevelEncryptionProfile Operation</seealso>
        DeleteFieldLevelEncryptionProfileResponse DeleteFieldLevelEncryptionProfile(DeleteFieldLevelEncryptionProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionProfile operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFieldLevelEncryptionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFieldLevelEncryptionProfile">REST API Reference for DeleteFieldLevelEncryptionProfile Operation</seealso>
        IAsyncResult BeginDeleteFieldLevelEncryptionProfile(DeleteFieldLevelEncryptionProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFieldLevelEncryptionProfile.</param>
        /// 
        /// <returns>Returns a  DeleteFieldLevelEncryptionProfileResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFieldLevelEncryptionProfile">REST API Reference for DeleteFieldLevelEncryptionProfile Operation</seealso>
        DeleteFieldLevelEncryptionProfileResponse EndDeleteFieldLevelEncryptionProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFunction


        /// <summary>
        /// Deletes a CloudFront function.
        /// 
        ///  
        /// <para>
        /// You cannot delete a function if it's associated with a cache behavior. First, update
        /// your distributions to remove the function association from all cache behaviors, then
        /// delete the function.
        /// </para>
        ///  
        /// <para>
        /// To delete a function, you must provide the function's name and version (<c>ETag</c>
        /// value). To get these values, you can use <c>ListFunctions</c> and <c>DescribeFunction</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FunctionInUseException">
        /// Cannot delete the function because it's attached to one or more cache behaviors.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        IAsyncResult BeginDeleteFunction(DeleteFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunction.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        DeleteFunctionResponse EndDeleteFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKeyGroup


        /// <summary>
        /// Deletes a key group.
        /// 
        ///  
        /// <para>
        /// You cannot delete a key group that is referenced in a cache behavior. First update
        /// your distributions to remove the key group from all cache behaviors, then delete the
        /// key group.
        /// </para>
        ///  
        /// <para>
        /// To delete a key group, you must provide the key group's identifier and version. To
        /// get these values, use <c>ListKeyGroups</c> followed by <c>GetKeyGroup</c> or <c>GetKeyGroupConfig</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceInUseException">
        /// Cannot delete this resource because it is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteKeyGroup">REST API Reference for DeleteKeyGroup Operation</seealso>
        DeleteKeyGroupResponse DeleteKeyGroup(DeleteKeyGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyGroup operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKeyGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteKeyGroup">REST API Reference for DeleteKeyGroup Operation</seealso>
        IAsyncResult BeginDeleteKeyGroup(DeleteKeyGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKeyGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKeyGroup.</param>
        /// 
        /// <returns>Returns a  DeleteKeyGroupResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteKeyGroup">REST API Reference for DeleteKeyGroup Operation</seealso>
        DeleteKeyGroupResponse EndDeleteKeyGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKeyValueStore


        /// <summary>
        /// Specifies the key value store to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyValueStore service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyValueStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotDeleteEntityWhileInUseException">
        /// The entity cannot be deleted while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteKeyValueStore">REST API Reference for DeleteKeyValueStore Operation</seealso>
        DeleteKeyValueStoreResponse DeleteKeyValueStore(DeleteKeyValueStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyValueStore operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKeyValueStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteKeyValueStore">REST API Reference for DeleteKeyValueStore Operation</seealso>
        IAsyncResult BeginDeleteKeyValueStore(DeleteKeyValueStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKeyValueStore.</param>
        /// 
        /// <returns>Returns a  DeleteKeyValueStoreResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteKeyValueStore">REST API Reference for DeleteKeyValueStore Operation</seealso>
        DeleteKeyValueStoreResponse EndDeleteKeyValueStore(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMonitoringSubscription


        /// <summary>
        /// Disables additional CloudWatch metrics for the specified CloudFront distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitoringSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteMonitoringSubscription service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchMonitoringSubscriptionException">
        /// A monitoring subscription does not exist for the specified distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteMonitoringSubscription">REST API Reference for DeleteMonitoringSubscription Operation</seealso>
        DeleteMonitoringSubscriptionResponse DeleteMonitoringSubscription(DeleteMonitoringSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMonitoringSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitoringSubscription operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMonitoringSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteMonitoringSubscription">REST API Reference for DeleteMonitoringSubscription Operation</seealso>
        IAsyncResult BeginDeleteMonitoringSubscription(DeleteMonitoringSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMonitoringSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMonitoringSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteMonitoringSubscriptionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteMonitoringSubscription">REST API Reference for DeleteMonitoringSubscription Operation</seealso>
        DeleteMonitoringSubscriptionResponse EndDeleteMonitoringSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOriginAccessControl


        /// <summary>
        /// Deletes a CloudFront origin access control.
        /// 
        ///  
        /// <para>
        /// You cannot delete an origin access control if it's in use. First, update all distributions
        /// to remove the origin access control from all origins, then delete the origin access
        /// control.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginAccessControl service method.</param>
        /// 
        /// <returns>The response from the DeleteOriginAccessControl service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginAccessControlException">
        /// The origin access control does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginAccessControlInUseException">
        /// Cannot delete the origin access control because it's in use by one or more distributions.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteOriginAccessControl">REST API Reference for DeleteOriginAccessControl Operation</seealso>
        DeleteOriginAccessControlResponse DeleteOriginAccessControl(DeleteOriginAccessControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOriginAccessControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginAccessControl operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOriginAccessControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteOriginAccessControl">REST API Reference for DeleteOriginAccessControl Operation</seealso>
        IAsyncResult BeginDeleteOriginAccessControl(DeleteOriginAccessControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOriginAccessControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOriginAccessControl.</param>
        /// 
        /// <returns>Returns a  DeleteOriginAccessControlResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteOriginAccessControl">REST API Reference for DeleteOriginAccessControl Operation</seealso>
        DeleteOriginAccessControlResponse EndDeleteOriginAccessControl(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOriginRequestPolicy


        /// <summary>
        /// Deletes an origin request policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete an origin request policy if it's attached to any cache behaviors.
        /// First update your distributions to remove the origin request policy from all cache
        /// behaviors, then delete the origin request policy.
        /// </para>
        ///  
        /// <para>
        /// To delete an origin request policy, you must provide the policy's identifier and version.
        /// To get the identifier, you can use <c>ListOriginRequestPolicies</c> or <c>GetOriginRequestPolicy</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginRequestPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteOriginRequestPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalDeleteException">
        /// Deletion is not allowed for this entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginRequestPolicyInUseException">
        /// Cannot delete the origin request policy because it is attached to one or more cache
        /// behaviors.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteOriginRequestPolicy">REST API Reference for DeleteOriginRequestPolicy Operation</seealso>
        DeleteOriginRequestPolicyResponse DeleteOriginRequestPolicy(DeleteOriginRequestPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOriginRequestPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginRequestPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOriginRequestPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteOriginRequestPolicy">REST API Reference for DeleteOriginRequestPolicy Operation</seealso>
        IAsyncResult BeginDeleteOriginRequestPolicy(DeleteOriginRequestPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOriginRequestPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOriginRequestPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteOriginRequestPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteOriginRequestPolicy">REST API Reference for DeleteOriginRequestPolicy Operation</seealso>
        DeleteOriginRequestPolicyResponse EndDeleteOriginRequestPolicy(IAsyncResult asyncResult);

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
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PublicKeyInUseException">
        /// The specified public key is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        DeletePublicKeyResponse DeletePublicKey(DeletePublicKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicKey operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        IAsyncResult BeginDeletePublicKey(DeletePublicKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePublicKey.</param>
        /// 
        /// <returns>Returns a  DeletePublicKeyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        DeletePublicKeyResponse EndDeletePublicKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRealtimeLogConfig


        /// <summary>
        /// Deletes a real-time log configuration.
        /// 
        ///  
        /// <para>
        /// You cannot delete a real-time log configuration if it's attached to a cache behavior.
        /// First update your distributions to remove the real-time log configuration from all
        /// cache behaviors, then delete the real-time log configuration.
        /// </para>
        ///  
        /// <para>
        /// To delete a real-time log configuration, you can provide the configuration's name
        /// or its Amazon Resource Name (ARN). You must provide at least one. If you provide both,
        /// CloudFront uses the name to identify the real-time log configuration to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRealtimeLogConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteRealtimeLogConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigInUseException">
        /// Cannot delete the real-time log configuration because it is attached to one or more
        /// cache behaviors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteRealtimeLogConfig">REST API Reference for DeleteRealtimeLogConfig Operation</seealso>
        DeleteRealtimeLogConfigResponse DeleteRealtimeLogConfig(DeleteRealtimeLogConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRealtimeLogConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRealtimeLogConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRealtimeLogConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteRealtimeLogConfig">REST API Reference for DeleteRealtimeLogConfig Operation</seealso>
        IAsyncResult BeginDeleteRealtimeLogConfig(DeleteRealtimeLogConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRealtimeLogConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRealtimeLogConfig.</param>
        /// 
        /// <returns>Returns a  DeleteRealtimeLogConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteRealtimeLogConfig">REST API Reference for DeleteRealtimeLogConfig Operation</seealso>
        DeleteRealtimeLogConfigResponse EndDeleteRealtimeLogConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the resource policy attached to the CloudFront resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalDeleteException">
        /// Deletion is not allowed for this entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResponseHeadersPolicy


        /// <summary>
        /// Deletes a response headers policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete a response headers policy if it's attached to a cache behavior.
        /// First update your distributions to remove the response headers policy from all cache
        /// behaviors, then delete the response headers policy.
        /// </para>
        ///  
        /// <para>
        /// To delete a response headers policy, you must provide the policy's identifier and
        /// version. To get these values, you can use <c>ListResponseHeadersPolicies</c> or <c>GetResponseHeadersPolicy</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponseHeadersPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResponseHeadersPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalDeleteException">
        /// Deletion is not allowed for this entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResponseHeadersPolicyInUseException">
        /// Cannot delete the response headers policy because it is attached to one or more cache
        /// behaviors in a CloudFront distribution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteResponseHeadersPolicy">REST API Reference for DeleteResponseHeadersPolicy Operation</seealso>
        DeleteResponseHeadersPolicyResponse DeleteResponseHeadersPolicy(DeleteResponseHeadersPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResponseHeadersPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponseHeadersPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResponseHeadersPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteResponseHeadersPolicy">REST API Reference for DeleteResponseHeadersPolicy Operation</seealso>
        IAsyncResult BeginDeleteResponseHeadersPolicy(DeleteResponseHeadersPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResponseHeadersPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResponseHeadersPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResponseHeadersPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteResponseHeadersPolicy">REST API Reference for DeleteResponseHeadersPolicy Operation</seealso>
        DeleteResponseHeadersPolicyResponse EndDeleteResponseHeadersPolicy(IAsyncResult asyncResult);

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
        /// Submit a <c>GET Streaming Distribution Config</c> request to get the current configuration
        /// and the <c>Etag</c> header for the distribution. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the XML document that was returned in the response to your <c>GET Streaming
        /// Distribution Config</c> request to change the value of <c>Enabled</c> to <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>PUT Streaming Distribution Config</c> request to update the configuration
        /// for your distribution. In the request body, include the XML document that you updated
        /// in Step 3. Then set the value of the HTTP <c>If-Match</c> header to the value of the
        /// <c>ETag</c> header that CloudFront returned when you submitted the <c>GET Streaming
        /// Distribution Config</c> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to the <c>PUT Streaming Distribution Config</c> request to confirm
        /// that the distribution was successfully disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>GET Streaming Distribution Config</c> request to confirm that your changes
        /// have propagated. When propagation is complete, the value of <c>Status</c> is <c>Deployed</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DELETE Streaming Distribution</c> request. Set the value of the HTTP <c>If-Match</c>
        /// header to the value of the <c>ETag</c> header that CloudFront returned when you submitted
        /// the <c>GET Streaming Distribution Config</c> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to your <c>DELETE Streaming Distribution</c> request to confirm
        /// that the distribution was successfully deleted.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For information about deleting a distribution using the CloudFront console, see <a
        /// href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/HowToDeleteDistribution.html">Deleting
        /// a Distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DeleteStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionNotDisabledException">
        /// The specified CloudFront distribution is not disabled. You must disable the distribution
        /// before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
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
        /// Submit a <c>GET Streaming Distribution Config</c> request to get the current configuration
        /// and the <c>Etag</c> header for the distribution. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the XML document that was returned in the response to your <c>GET Streaming
        /// Distribution Config</c> request to change the value of <c>Enabled</c> to <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>PUT Streaming Distribution Config</c> request to update the configuration
        /// for your distribution. In the request body, include the XML document that you updated
        /// in Step 3. Then set the value of the HTTP <c>If-Match</c> header to the value of the
        /// <c>ETag</c> header that CloudFront returned when you submitted the <c>GET Streaming
        /// Distribution Config</c> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to the <c>PUT Streaming Distribution Config</c> request to confirm
        /// that the distribution was successfully disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>GET Streaming Distribution Config</c> request to confirm that your changes
        /// have propagated. When propagation is complete, the value of <c>Status</c> is <c>Deployed</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DELETE Streaming Distribution</c> request. Set the value of the HTTP <c>If-Match</c>
        /// header to the value of the <c>ETag</c> header that CloudFront returned when you submitted
        /// the <c>GET Streaming Distribution Config</c> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to your <c>DELETE Streaming Distribution</c> request to confirm
        /// that the distribution was successfully deleted.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For information about deleting a distribution using the CloudFront console, see <a
        /// href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/HowToDeleteDistribution.html">Deleting
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
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionNotDisabledException">
        /// The specified CloudFront distribution is not disabled. You must disable the distribution
        /// before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        IAsyncResult BeginDeleteStreamingDistribution(DeleteStreamingDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  DeleteStreamingDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        DeleteStreamingDistributionResponse EndDeleteStreamingDistribution(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrustStore


        /// <summary>
        /// Deletes a trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustStore service method.</param>
        /// 
        /// <returns>The response from the DeleteTrustStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotDeleteEntityWhileInUseException">
        /// The entity cannot be deleted while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        DeleteTrustStoreResponse DeleteTrustStore(DeleteTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustStore operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        IAsyncResult BeginDeleteTrustStore(DeleteTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrustStore.</param>
        /// 
        /// <returns>Returns a  DeleteTrustStoreResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        DeleteTrustStoreResponse EndDeleteTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcOrigin


        /// <summary>
        /// Delete an Amazon CloudFront VPC origin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcOrigin service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcOrigin service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotDeleteEntityWhileInUseException">
        /// The entity cannot be deleted while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalDeleteException">
        /// Deletion is not allowed for this entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteVpcOrigin">REST API Reference for DeleteVpcOrigin Operation</seealso>
        DeleteVpcOriginResponse DeleteVpcOrigin(DeleteVpcOriginRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcOrigin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcOrigin operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcOrigin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteVpcOrigin">REST API Reference for DeleteVpcOrigin Operation</seealso>
        IAsyncResult BeginDeleteVpcOrigin(DeleteVpcOriginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcOrigin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcOrigin.</param>
        /// 
        /// <returns>Returns a  DeleteVpcOriginResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteVpcOrigin">REST API Reference for DeleteVpcOrigin Operation</seealso>
        DeleteVpcOriginResponse EndDeleteVpcOrigin(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConnectionFunction


        /// <summary>
        /// Describes a connection function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionFunction service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectionFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DescribeConnectionFunction">REST API Reference for DescribeConnectionFunction Operation</seealso>
        DescribeConnectionFunctionResponse DescribeConnectionFunction(DescribeConnectionFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnectionFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DescribeConnectionFunction">REST API Reference for DescribeConnectionFunction Operation</seealso>
        IAsyncResult BeginDescribeConnectionFunction(DescribeConnectionFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectionFunction.</param>
        /// 
        /// <returns>Returns a  DescribeConnectionFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DescribeConnectionFunction">REST API Reference for DescribeConnectionFunction Operation</seealso>
        DescribeConnectionFunctionResponse EndDescribeConnectionFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFunction


        /// <summary>
        /// Gets configuration information and metadata about a CloudFront function, but not the
        /// function's code. To get a function's code, use <c>GetFunction</c>.
        /// 
        ///  
        /// <para>
        /// To get configuration information and metadata about a function, you must provide the
        /// function's name and stage. To get these values, you can use <c>ListFunctions</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFunction service method.</param>
        /// 
        /// <returns>The response from the DescribeFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DescribeFunction">REST API Reference for DescribeFunction Operation</seealso>
        DescribeFunctionResponse DescribeFunction(DescribeFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DescribeFunction">REST API Reference for DescribeFunction Operation</seealso>
        IAsyncResult BeginDescribeFunction(DescribeFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFunction.</param>
        /// 
        /// <returns>Returns a  DescribeFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DescribeFunction">REST API Reference for DescribeFunction Operation</seealso>
        DescribeFunctionResponse EndDescribeFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeKeyValueStore


        /// <summary>
        /// Specifies the key value store and its configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyValueStore service method.</param>
        /// 
        /// <returns>The response from the DescribeKeyValueStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DescribeKeyValueStore">REST API Reference for DescribeKeyValueStore Operation</seealso>
        DescribeKeyValueStoreResponse DescribeKeyValueStore(DescribeKeyValueStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyValueStore operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeKeyValueStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DescribeKeyValueStore">REST API Reference for DescribeKeyValueStore Operation</seealso>
        IAsyncResult BeginDescribeKeyValueStore(DescribeKeyValueStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeyValueStore.</param>
        /// 
        /// <returns>Returns a  DescribeKeyValueStoreResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DescribeKeyValueStore">REST API Reference for DescribeKeyValueStore Operation</seealso>
        DescribeKeyValueStoreResponse EndDescribeKeyValueStore(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateDistributionTenantWebACL


        /// <summary>
        /// Disassociates a distribution tenant from the WAF web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDistributionTenantWebACL service method.</param>
        /// 
        /// <returns>The response from the DisassociateDistributionTenantWebACL service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DisassociateDistributionTenantWebACL">REST API Reference for DisassociateDistributionTenantWebACL Operation</seealso>
        DisassociateDistributionTenantWebACLResponse DisassociateDistributionTenantWebACL(DisassociateDistributionTenantWebACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDistributionTenantWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDistributionTenantWebACL operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDistributionTenantWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DisassociateDistributionTenantWebACL">REST API Reference for DisassociateDistributionTenantWebACL Operation</seealso>
        IAsyncResult BeginDisassociateDistributionTenantWebACL(DisassociateDistributionTenantWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDistributionTenantWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDistributionTenantWebACL.</param>
        /// 
        /// <returns>Returns a  DisassociateDistributionTenantWebACLResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DisassociateDistributionTenantWebACL">REST API Reference for DisassociateDistributionTenantWebACL Operation</seealso>
        DisassociateDistributionTenantWebACLResponse EndDisassociateDistributionTenantWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateDistributionWebACL


        /// <summary>
        /// Disassociates a distribution from the WAF web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDistributionWebACL service method.</param>
        /// 
        /// <returns>The response from the DisassociateDistributionWebACL service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DisassociateDistributionWebACL">REST API Reference for DisassociateDistributionWebACL Operation</seealso>
        DisassociateDistributionWebACLResponse DisassociateDistributionWebACL(DisassociateDistributionWebACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDistributionWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDistributionWebACL operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDistributionWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DisassociateDistributionWebACL">REST API Reference for DisassociateDistributionWebACL Operation</seealso>
        IAsyncResult BeginDisassociateDistributionWebACL(DisassociateDistributionWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDistributionWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDistributionWebACL.</param>
        /// 
        /// <returns>Returns a  DisassociateDistributionWebACLResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DisassociateDistributionWebACL">REST API Reference for DisassociateDistributionWebACL Operation</seealso>
        DisassociateDistributionWebACLResponse EndDisassociateDistributionWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAnycastIpList


        /// <summary>
        /// Gets an Anycast static IP list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnycastIpList service method.</param>
        /// 
        /// <returns>The response from the GetAnycastIpList service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetAnycastIpList">REST API Reference for GetAnycastIpList Operation</seealso>
        GetAnycastIpListResponse GetAnycastIpList(GetAnycastIpListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnycastIpList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnycastIpList operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnycastIpList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetAnycastIpList">REST API Reference for GetAnycastIpList Operation</seealso>
        IAsyncResult BeginGetAnycastIpList(GetAnycastIpListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnycastIpList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnycastIpList.</param>
        /// 
        /// <returns>Returns a  GetAnycastIpListResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetAnycastIpList">REST API Reference for GetAnycastIpList Operation</seealso>
        GetAnycastIpListResponse EndGetAnycastIpList(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCachePolicy


        /// <summary>
        /// Gets a cache policy, including the following metadata:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The policy's identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The date and time when the policy was last modified.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get a cache policy, you must provide the policy's identifier. If the cache policy
        /// is attached to a distribution's cache behavior, you can get the policy's identifier
        /// using <c>ListDistributions</c> or <c>GetDistribution</c>. If the cache policy is not
        /// attached to a cache behavior, you can get the identifier using <c>ListCachePolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCachePolicy service method.</param>
        /// 
        /// <returns>The response from the GetCachePolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCachePolicy">REST API Reference for GetCachePolicy Operation</seealso>
        GetCachePolicyResponse GetCachePolicy(GetCachePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCachePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCachePolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCachePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCachePolicy">REST API Reference for GetCachePolicy Operation</seealso>
        IAsyncResult BeginGetCachePolicy(GetCachePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCachePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCachePolicy.</param>
        /// 
        /// <returns>Returns a  GetCachePolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCachePolicy">REST API Reference for GetCachePolicy Operation</seealso>
        GetCachePolicyResponse EndGetCachePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCachePolicyConfig


        /// <summary>
        /// Gets a cache policy configuration.
        /// 
        ///  
        /// <para>
        /// To get a cache policy configuration, you must provide the policy's identifier. If
        /// the cache policy is attached to a distribution's cache behavior, you can get the policy's
        /// identifier using <c>ListDistributions</c> or <c>GetDistribution</c>. If the cache
        /// policy is not attached to a cache behavior, you can get the identifier using <c>ListCachePolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCachePolicyConfig service method.</param>
        /// 
        /// <returns>The response from the GetCachePolicyConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCachePolicyConfig">REST API Reference for GetCachePolicyConfig Operation</seealso>
        GetCachePolicyConfigResponse GetCachePolicyConfig(GetCachePolicyConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCachePolicyConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCachePolicyConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCachePolicyConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCachePolicyConfig">REST API Reference for GetCachePolicyConfig Operation</seealso>
        IAsyncResult BeginGetCachePolicyConfig(GetCachePolicyConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCachePolicyConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCachePolicyConfig.</param>
        /// 
        /// <returns>Returns a  GetCachePolicyConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCachePolicyConfig">REST API Reference for GetCachePolicyConfig Operation</seealso>
        GetCachePolicyConfigResponse EndGetCachePolicyConfig(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        IAsyncResult BeginGetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  GetCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        IAsyncResult BeginGetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudFrontOriginAccessIdentityConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentityConfig.</param>
        /// 
        /// <returns>Returns a  GetCloudFrontOriginAccessIdentityConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        GetCloudFrontOriginAccessIdentityConfigResponse EndGetCloudFrontOriginAccessIdentityConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnectionFunction


        /// <summary>
        /// Gets a connection function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionFunction service method.</param>
        /// 
        /// <returns>The response from the GetConnectionFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetConnectionFunction">REST API Reference for GetConnectionFunction Operation</seealso>
        GetConnectionFunctionResponse GetConnectionFunction(GetConnectionFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectionFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetConnectionFunction">REST API Reference for GetConnectionFunction Operation</seealso>
        IAsyncResult BeginGetConnectionFunction(GetConnectionFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectionFunction.</param>
        /// 
        /// <returns>Returns a  GetConnectionFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetConnectionFunction">REST API Reference for GetConnectionFunction Operation</seealso>
        GetConnectionFunctionResponse EndGetConnectionFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnectionGroup


        /// <summary>
        /// Gets information about a connection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionGroup service method.</param>
        /// 
        /// <returns>The response from the GetConnectionGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetConnectionGroup">REST API Reference for GetConnectionGroup Operation</seealso>
        GetConnectionGroupResponse GetConnectionGroup(GetConnectionGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionGroup operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetConnectionGroup">REST API Reference for GetConnectionGroup Operation</seealso>
        IAsyncResult BeginGetConnectionGroup(GetConnectionGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectionGroup.</param>
        /// 
        /// <returns>Returns a  GetConnectionGroupResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetConnectionGroup">REST API Reference for GetConnectionGroup Operation</seealso>
        GetConnectionGroupResponse EndGetConnectionGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnectionGroupByRoutingEndpoint


        /// <summary>
        /// Gets information about a connection group by using the endpoint that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionGroupByRoutingEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetConnectionGroupByRoutingEndpoint service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetConnectionGroupByRoutingEndpoint">REST API Reference for GetConnectionGroupByRoutingEndpoint Operation</seealso>
        GetConnectionGroupByRoutingEndpointResponse GetConnectionGroupByRoutingEndpoint(GetConnectionGroupByRoutingEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectionGroupByRoutingEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionGroupByRoutingEndpoint operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectionGroupByRoutingEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetConnectionGroupByRoutingEndpoint">REST API Reference for GetConnectionGroupByRoutingEndpoint Operation</seealso>
        IAsyncResult BeginGetConnectionGroupByRoutingEndpoint(GetConnectionGroupByRoutingEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectionGroupByRoutingEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectionGroupByRoutingEndpoint.</param>
        /// 
        /// <returns>Returns a  GetConnectionGroupByRoutingEndpointResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetConnectionGroupByRoutingEndpoint">REST API Reference for GetConnectionGroupByRoutingEndpoint Operation</seealso>
        GetConnectionGroupByRoutingEndpointResponse EndGetConnectionGroupByRoutingEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContinuousDeploymentPolicy


        /// <summary>
        /// Gets a continuous deployment policy, including metadata (the policy's identifier and
        /// the date and time when the policy was last modified).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContinuousDeploymentPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContinuousDeploymentPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetContinuousDeploymentPolicy">REST API Reference for GetContinuousDeploymentPolicy Operation</seealso>
        GetContinuousDeploymentPolicyResponse GetContinuousDeploymentPolicy(GetContinuousDeploymentPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContinuousDeploymentPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContinuousDeploymentPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContinuousDeploymentPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetContinuousDeploymentPolicy">REST API Reference for GetContinuousDeploymentPolicy Operation</seealso>
        IAsyncResult BeginGetContinuousDeploymentPolicy(GetContinuousDeploymentPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContinuousDeploymentPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContinuousDeploymentPolicy.</param>
        /// 
        /// <returns>Returns a  GetContinuousDeploymentPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetContinuousDeploymentPolicy">REST API Reference for GetContinuousDeploymentPolicy Operation</seealso>
        GetContinuousDeploymentPolicyResponse EndGetContinuousDeploymentPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContinuousDeploymentPolicyConfig


        /// <summary>
        /// Gets configuration information about a continuous deployment policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContinuousDeploymentPolicyConfig service method.</param>
        /// 
        /// <returns>The response from the GetContinuousDeploymentPolicyConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetContinuousDeploymentPolicyConfig">REST API Reference for GetContinuousDeploymentPolicyConfig Operation</seealso>
        GetContinuousDeploymentPolicyConfigResponse GetContinuousDeploymentPolicyConfig(GetContinuousDeploymentPolicyConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContinuousDeploymentPolicyConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContinuousDeploymentPolicyConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContinuousDeploymentPolicyConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetContinuousDeploymentPolicyConfig">REST API Reference for GetContinuousDeploymentPolicyConfig Operation</seealso>
        IAsyncResult BeginGetContinuousDeploymentPolicyConfig(GetContinuousDeploymentPolicyConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContinuousDeploymentPolicyConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContinuousDeploymentPolicyConfig.</param>
        /// 
        /// <returns>Returns a  GetContinuousDeploymentPolicyConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetContinuousDeploymentPolicyConfig">REST API Reference for GetContinuousDeploymentPolicyConfig Operation</seealso>
        GetContinuousDeploymentPolicyConfigResponse EndGetContinuousDeploymentPolicyConfig(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        IAsyncResult BeginGetDistribution(GetDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistribution.</param>
        /// 
        /// <returns>Returns a  GetDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        IAsyncResult BeginGetDistributionConfig(GetDistributionConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionConfig.</param>
        /// 
        /// <returns>Returns a  GetDistributionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        GetDistributionConfigResponse EndGetDistributionConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDistributionTenant


        /// <summary>
        /// Gets information about a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionTenant service method.</param>
        /// 
        /// <returns>The response from the GetDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionTenant">REST API Reference for GetDistributionTenant Operation</seealso>
        GetDistributionTenantResponse GetDistributionTenant(GetDistributionTenantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionTenant operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistributionTenant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionTenant">REST API Reference for GetDistributionTenant Operation</seealso>
        IAsyncResult BeginGetDistributionTenant(GetDistributionTenantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionTenant.</param>
        /// 
        /// <returns>Returns a  GetDistributionTenantResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionTenant">REST API Reference for GetDistributionTenant Operation</seealso>
        GetDistributionTenantResponse EndGetDistributionTenant(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDistributionTenantByDomain


        /// <summary>
        /// Gets information about a distribution tenant by the associated domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionTenantByDomain service method.</param>
        /// 
        /// <returns>The response from the GetDistributionTenantByDomain service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionTenantByDomain">REST API Reference for GetDistributionTenantByDomain Operation</seealso>
        GetDistributionTenantByDomainResponse GetDistributionTenantByDomain(GetDistributionTenantByDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionTenantByDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionTenantByDomain operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistributionTenantByDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionTenantByDomain">REST API Reference for GetDistributionTenantByDomain Operation</seealso>
        IAsyncResult BeginGetDistributionTenantByDomain(GetDistributionTenantByDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistributionTenantByDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionTenantByDomain.</param>
        /// 
        /// <returns>Returns a  GetDistributionTenantByDomainResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionTenantByDomain">REST API Reference for GetDistributionTenantByDomain Operation</seealso>
        GetDistributionTenantByDomainResponse EndGetDistributionTenantByDomain(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryption">REST API Reference for GetFieldLevelEncryption Operation</seealso>
        GetFieldLevelEncryptionResponse GetFieldLevelEncryption(GetFieldLevelEncryptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryption operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFieldLevelEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryption">REST API Reference for GetFieldLevelEncryption Operation</seealso>
        IAsyncResult BeginGetFieldLevelEncryption(GetFieldLevelEncryptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFieldLevelEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFieldLevelEncryption.</param>
        /// 
        /// <returns>Returns a  GetFieldLevelEncryptionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryption">REST API Reference for GetFieldLevelEncryption Operation</seealso>
        GetFieldLevelEncryptionResponse EndGetFieldLevelEncryption(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionConfig">REST API Reference for GetFieldLevelEncryptionConfig Operation</seealso>
        GetFieldLevelEncryptionConfigResponse GetFieldLevelEncryptionConfig(GetFieldLevelEncryptionConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFieldLevelEncryptionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionConfig">REST API Reference for GetFieldLevelEncryptionConfig Operation</seealso>
        IAsyncResult BeginGetFieldLevelEncryptionConfig(GetFieldLevelEncryptionConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFieldLevelEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  GetFieldLevelEncryptionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionConfig">REST API Reference for GetFieldLevelEncryptionConfig Operation</seealso>
        GetFieldLevelEncryptionConfigResponse EndGetFieldLevelEncryptionConfig(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionProfile">REST API Reference for GetFieldLevelEncryptionProfile Operation</seealso>
        GetFieldLevelEncryptionProfileResponse GetFieldLevelEncryptionProfile(GetFieldLevelEncryptionProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfile operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFieldLevelEncryptionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionProfile">REST API Reference for GetFieldLevelEncryptionProfile Operation</seealso>
        IAsyncResult BeginGetFieldLevelEncryptionProfile(GetFieldLevelEncryptionProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFieldLevelEncryptionProfile.</param>
        /// 
        /// <returns>Returns a  GetFieldLevelEncryptionProfileResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionProfile">REST API Reference for GetFieldLevelEncryptionProfile Operation</seealso>
        GetFieldLevelEncryptionProfileResponse EndGetFieldLevelEncryptionProfile(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionProfileConfig">REST API Reference for GetFieldLevelEncryptionProfileConfig Operation</seealso>
        GetFieldLevelEncryptionProfileConfigResponse GetFieldLevelEncryptionProfileConfig(GetFieldLevelEncryptionProfileConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionProfileConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfileConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFieldLevelEncryptionProfileConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionProfileConfig">REST API Reference for GetFieldLevelEncryptionProfileConfig Operation</seealso>
        IAsyncResult BeginGetFieldLevelEncryptionProfileConfig(GetFieldLevelEncryptionProfileConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFieldLevelEncryptionProfileConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFieldLevelEncryptionProfileConfig.</param>
        /// 
        /// <returns>Returns a  GetFieldLevelEncryptionProfileConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionProfileConfig">REST API Reference for GetFieldLevelEncryptionProfileConfig Operation</seealso>
        GetFieldLevelEncryptionProfileConfigResponse EndGetFieldLevelEncryptionProfileConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFunction


        /// <summary>
        /// Gets the code of a CloudFront function. To get configuration information and metadata
        /// about a function, use <c>DescribeFunction</c>.
        /// 
        ///  
        /// <para>
        /// To get a function's code, you must provide the function's name and stage. To get these
        /// values, you can use <c>ListFunctions</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        GetFunctionResponse GetFunction(GetFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        IAsyncResult BeginGetFunction(GetFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunction.</param>
        /// 
        /// <returns>Returns a  GetFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        GetFunctionResponse EndGetFunction(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetInvalidation">REST API Reference for GetInvalidation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetInvalidation">REST API Reference for GetInvalidation Operation</seealso>
        IAsyncResult BeginGetInvalidation(GetInvalidationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvalidation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvalidation.</param>
        /// 
        /// <returns>Returns a  GetInvalidationResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetInvalidation">REST API Reference for GetInvalidation Operation</seealso>
        GetInvalidationResponse EndGetInvalidation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInvalidationForDistributionTenant


        /// <summary>
        /// Gets information about a specific invalidation for a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidationForDistributionTenant service method.</param>
        /// 
        /// <returns>The response from the GetInvalidationForDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchInvalidationException">
        /// The specified invalidation does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetInvalidationForDistributionTenant">REST API Reference for GetInvalidationForDistributionTenant Operation</seealso>
        GetInvalidationForDistributionTenantResponse GetInvalidationForDistributionTenant(GetInvalidationForDistributionTenantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvalidationForDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidationForDistributionTenant operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvalidationForDistributionTenant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetInvalidationForDistributionTenant">REST API Reference for GetInvalidationForDistributionTenant Operation</seealso>
        IAsyncResult BeginGetInvalidationForDistributionTenant(GetInvalidationForDistributionTenantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvalidationForDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvalidationForDistributionTenant.</param>
        /// 
        /// <returns>Returns a  GetInvalidationForDistributionTenantResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetInvalidationForDistributionTenant">REST API Reference for GetInvalidationForDistributionTenant Operation</seealso>
        GetInvalidationForDistributionTenantResponse EndGetInvalidationForDistributionTenant(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKeyGroup


        /// <summary>
        /// Gets a key group, including the date and time when the key group was last modified.
        /// 
        ///  
        /// <para>
        /// To get a key group, you must provide the key group's identifier. If the key group
        /// is referenced in a distribution's cache behavior, you can get the key group's identifier
        /// using <c>ListDistributions</c> or <c>GetDistribution</c>. If the key group is not
        /// referenced in a cache behavior, you can get the identifier using <c>ListKeyGroups</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyGroup service method.</param>
        /// 
        /// <returns>The response from the GetKeyGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetKeyGroup">REST API Reference for GetKeyGroup Operation</seealso>
        GetKeyGroupResponse GetKeyGroup(GetKeyGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyGroup operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKeyGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetKeyGroup">REST API Reference for GetKeyGroup Operation</seealso>
        IAsyncResult BeginGetKeyGroup(GetKeyGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKeyGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKeyGroup.</param>
        /// 
        /// <returns>Returns a  GetKeyGroupResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetKeyGroup">REST API Reference for GetKeyGroup Operation</seealso>
        GetKeyGroupResponse EndGetKeyGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKeyGroupConfig


        /// <summary>
        /// Gets a key group configuration.
        /// 
        ///  
        /// <para>
        /// To get a key group configuration, you must provide the key group's identifier. If
        /// the key group is referenced in a distribution's cache behavior, you can get the key
        /// group's identifier using <c>ListDistributions</c> or <c>GetDistribution</c>. If the
        /// key group is not referenced in a cache behavior, you can get the identifier using
        /// <c>ListKeyGroups</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyGroupConfig service method.</param>
        /// 
        /// <returns>The response from the GetKeyGroupConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetKeyGroupConfig">REST API Reference for GetKeyGroupConfig Operation</seealso>
        GetKeyGroupConfigResponse GetKeyGroupConfig(GetKeyGroupConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyGroupConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyGroupConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKeyGroupConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetKeyGroupConfig">REST API Reference for GetKeyGroupConfig Operation</seealso>
        IAsyncResult BeginGetKeyGroupConfig(GetKeyGroupConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKeyGroupConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKeyGroupConfig.</param>
        /// 
        /// <returns>Returns a  GetKeyGroupConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetKeyGroupConfig">REST API Reference for GetKeyGroupConfig Operation</seealso>
        GetKeyGroupConfigResponse EndGetKeyGroupConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetManagedCertificateDetails


        /// <summary>
        /// Gets details about the CloudFront managed ACM certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedCertificateDetails service method.</param>
        /// 
        /// <returns>The response from the GetManagedCertificateDetails service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetManagedCertificateDetails">REST API Reference for GetManagedCertificateDetails Operation</seealso>
        GetManagedCertificateDetailsResponse GetManagedCertificateDetails(GetManagedCertificateDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedCertificateDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedCertificateDetails operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedCertificateDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetManagedCertificateDetails">REST API Reference for GetManagedCertificateDetails Operation</seealso>
        IAsyncResult BeginGetManagedCertificateDetails(GetManagedCertificateDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedCertificateDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedCertificateDetails.</param>
        /// 
        /// <returns>Returns a  GetManagedCertificateDetailsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetManagedCertificateDetails">REST API Reference for GetManagedCertificateDetails Operation</seealso>
        GetManagedCertificateDetailsResponse EndGetManagedCertificateDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMonitoringSubscription


        /// <summary>
        /// Gets information about whether additional CloudWatch metrics are enabled for the specified
        /// CloudFront distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitoringSubscription service method.</param>
        /// 
        /// <returns>The response from the GetMonitoringSubscription service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchMonitoringSubscriptionException">
        /// A monitoring subscription does not exist for the specified distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetMonitoringSubscription">REST API Reference for GetMonitoringSubscription Operation</seealso>
        GetMonitoringSubscriptionResponse GetMonitoringSubscription(GetMonitoringSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMonitoringSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMonitoringSubscription operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMonitoringSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetMonitoringSubscription">REST API Reference for GetMonitoringSubscription Operation</seealso>
        IAsyncResult BeginGetMonitoringSubscription(GetMonitoringSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMonitoringSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMonitoringSubscription.</param>
        /// 
        /// <returns>Returns a  GetMonitoringSubscriptionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetMonitoringSubscription">REST API Reference for GetMonitoringSubscription Operation</seealso>
        GetMonitoringSubscriptionResponse EndGetMonitoringSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOriginAccessControl


        /// <summary>
        /// Gets a CloudFront origin access control, including its unique identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginAccessControl service method.</param>
        /// 
        /// <returns>The response from the GetOriginAccessControl service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginAccessControlException">
        /// The origin access control does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginAccessControl">REST API Reference for GetOriginAccessControl Operation</seealso>
        GetOriginAccessControlResponse GetOriginAccessControl(GetOriginAccessControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOriginAccessControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOriginAccessControl operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOriginAccessControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginAccessControl">REST API Reference for GetOriginAccessControl Operation</seealso>
        IAsyncResult BeginGetOriginAccessControl(GetOriginAccessControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOriginAccessControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOriginAccessControl.</param>
        /// 
        /// <returns>Returns a  GetOriginAccessControlResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginAccessControl">REST API Reference for GetOriginAccessControl Operation</seealso>
        GetOriginAccessControlResponse EndGetOriginAccessControl(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOriginAccessControlConfig


        /// <summary>
        /// Gets a CloudFront origin access control configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginAccessControlConfig service method.</param>
        /// 
        /// <returns>The response from the GetOriginAccessControlConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginAccessControlException">
        /// The origin access control does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginAccessControlConfig">REST API Reference for GetOriginAccessControlConfig Operation</seealso>
        GetOriginAccessControlConfigResponse GetOriginAccessControlConfig(GetOriginAccessControlConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOriginAccessControlConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOriginAccessControlConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOriginAccessControlConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginAccessControlConfig">REST API Reference for GetOriginAccessControlConfig Operation</seealso>
        IAsyncResult BeginGetOriginAccessControlConfig(GetOriginAccessControlConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOriginAccessControlConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOriginAccessControlConfig.</param>
        /// 
        /// <returns>Returns a  GetOriginAccessControlConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginAccessControlConfig">REST API Reference for GetOriginAccessControlConfig Operation</seealso>
        GetOriginAccessControlConfigResponse EndGetOriginAccessControlConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOriginRequestPolicy


        /// <summary>
        /// Gets an origin request policy, including the following metadata:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The policy's identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The date and time when the policy was last modified.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get an origin request policy, you must provide the policy's identifier. If the
        /// origin request policy is attached to a distribution's cache behavior, you can get
        /// the policy's identifier using <c>ListDistributions</c> or <c>GetDistribution</c>.
        /// If the origin request policy is not attached to a cache behavior, you can get the
        /// identifier using <c>ListOriginRequestPolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginRequestPolicy service method.</param>
        /// 
        /// <returns>The response from the GetOriginRequestPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginRequestPolicy">REST API Reference for GetOriginRequestPolicy Operation</seealso>
        GetOriginRequestPolicyResponse GetOriginRequestPolicy(GetOriginRequestPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOriginRequestPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOriginRequestPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOriginRequestPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginRequestPolicy">REST API Reference for GetOriginRequestPolicy Operation</seealso>
        IAsyncResult BeginGetOriginRequestPolicy(GetOriginRequestPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOriginRequestPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOriginRequestPolicy.</param>
        /// 
        /// <returns>Returns a  GetOriginRequestPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginRequestPolicy">REST API Reference for GetOriginRequestPolicy Operation</seealso>
        GetOriginRequestPolicyResponse EndGetOriginRequestPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOriginRequestPolicyConfig


        /// <summary>
        /// Gets an origin request policy configuration.
        /// 
        ///  
        /// <para>
        /// To get an origin request policy configuration, you must provide the policy's identifier.
        /// If the origin request policy is attached to a distribution's cache behavior, you can
        /// get the policy's identifier using <c>ListDistributions</c> or <c>GetDistribution</c>.
        /// If the origin request policy is not attached to a cache behavior, you can get the
        /// identifier using <c>ListOriginRequestPolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginRequestPolicyConfig service method.</param>
        /// 
        /// <returns>The response from the GetOriginRequestPolicyConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginRequestPolicyConfig">REST API Reference for GetOriginRequestPolicyConfig Operation</seealso>
        GetOriginRequestPolicyConfigResponse GetOriginRequestPolicyConfig(GetOriginRequestPolicyConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOriginRequestPolicyConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOriginRequestPolicyConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOriginRequestPolicyConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginRequestPolicyConfig">REST API Reference for GetOriginRequestPolicyConfig Operation</seealso>
        IAsyncResult BeginGetOriginRequestPolicyConfig(GetOriginRequestPolicyConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOriginRequestPolicyConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOriginRequestPolicyConfig.</param>
        /// 
        /// <returns>Returns a  GetOriginRequestPolicyConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginRequestPolicyConfig">REST API Reference for GetOriginRequestPolicyConfig Operation</seealso>
        GetOriginRequestPolicyConfigResponse EndGetOriginRequestPolicyConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPublicKey


        /// <summary>
        /// Gets a public key.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        IAsyncResult BeginGetPublicKey(GetPublicKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPublicKey.</param>
        /// 
        /// <returns>Returns a  GetPublicKeyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        GetPublicKeyResponse EndGetPublicKey(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPublicKeyConfig


        /// <summary>
        /// Gets a public key configuration.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetPublicKeyConfig">REST API Reference for GetPublicKeyConfig Operation</seealso>
        GetPublicKeyConfigResponse GetPublicKeyConfig(GetPublicKeyConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicKeyConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKeyConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPublicKeyConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetPublicKeyConfig">REST API Reference for GetPublicKeyConfig Operation</seealso>
        IAsyncResult BeginGetPublicKeyConfig(GetPublicKeyConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPublicKeyConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPublicKeyConfig.</param>
        /// 
        /// <returns>Returns a  GetPublicKeyConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetPublicKeyConfig">REST API Reference for GetPublicKeyConfig Operation</seealso>
        GetPublicKeyConfigResponse EndGetPublicKeyConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRealtimeLogConfig


        /// <summary>
        /// Gets a real-time log configuration.
        /// 
        ///  
        /// <para>
        /// To get a real-time log configuration, you can provide the configuration's name or
        /// its Amazon Resource Name (ARN). You must provide at least one. If you provide both,
        /// CloudFront uses the name to identify the real-time log configuration to get.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRealtimeLogConfig service method.</param>
        /// 
        /// <returns>The response from the GetRealtimeLogConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetRealtimeLogConfig">REST API Reference for GetRealtimeLogConfig Operation</seealso>
        GetRealtimeLogConfigResponse GetRealtimeLogConfig(GetRealtimeLogConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRealtimeLogConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRealtimeLogConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRealtimeLogConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetRealtimeLogConfig">REST API Reference for GetRealtimeLogConfig Operation</seealso>
        IAsyncResult BeginGetRealtimeLogConfig(GetRealtimeLogConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRealtimeLogConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRealtimeLogConfig.</param>
        /// 
        /// <returns>Returns a  GetRealtimeLogConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetRealtimeLogConfig">REST API Reference for GetRealtimeLogConfig Operation</seealso>
        GetRealtimeLogConfigResponse EndGetRealtimeLogConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves the resource policy for the specified CloudFront resource that you own and
        /// have shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResponseHeadersPolicy


        /// <summary>
        /// Gets a response headers policy, including metadata (the policy's identifier and the
        /// date and time when the policy was last modified).
        /// 
        ///  
        /// <para>
        /// To get a response headers policy, you must provide the policy's identifier. If the
        /// response headers policy is attached to a distribution's cache behavior, you can get
        /// the policy's identifier using <c>ListDistributions</c> or <c>GetDistribution</c>.
        /// If the response headers policy is not attached to a cache behavior, you can get the
        /// identifier using <c>ListResponseHeadersPolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponseHeadersPolicy service method.</param>
        /// 
        /// <returns>The response from the GetResponseHeadersPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetResponseHeadersPolicy">REST API Reference for GetResponseHeadersPolicy Operation</seealso>
        GetResponseHeadersPolicyResponse GetResponseHeadersPolicy(GetResponseHeadersPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResponseHeadersPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResponseHeadersPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResponseHeadersPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetResponseHeadersPolicy">REST API Reference for GetResponseHeadersPolicy Operation</seealso>
        IAsyncResult BeginGetResponseHeadersPolicy(GetResponseHeadersPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResponseHeadersPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResponseHeadersPolicy.</param>
        /// 
        /// <returns>Returns a  GetResponseHeadersPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetResponseHeadersPolicy">REST API Reference for GetResponseHeadersPolicy Operation</seealso>
        GetResponseHeadersPolicyResponse EndGetResponseHeadersPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResponseHeadersPolicyConfig


        /// <summary>
        /// Gets a response headers policy configuration.
        /// 
        ///  
        /// <para>
        /// To get a response headers policy configuration, you must provide the policy's identifier.
        /// If the response headers policy is attached to a distribution's cache behavior, you
        /// can get the policy's identifier using <c>ListDistributions</c> or <c>GetDistribution</c>.
        /// If the response headers policy is not attached to a cache behavior, you can get the
        /// identifier using <c>ListResponseHeadersPolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponseHeadersPolicyConfig service method.</param>
        /// 
        /// <returns>The response from the GetResponseHeadersPolicyConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetResponseHeadersPolicyConfig">REST API Reference for GetResponseHeadersPolicyConfig Operation</seealso>
        GetResponseHeadersPolicyConfigResponse GetResponseHeadersPolicyConfig(GetResponseHeadersPolicyConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResponseHeadersPolicyConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResponseHeadersPolicyConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResponseHeadersPolicyConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetResponseHeadersPolicyConfig">REST API Reference for GetResponseHeadersPolicyConfig Operation</seealso>
        IAsyncResult BeginGetResponseHeadersPolicyConfig(GetResponseHeadersPolicyConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResponseHeadersPolicyConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResponseHeadersPolicyConfig.</param>
        /// 
        /// <returns>Returns a  GetResponseHeadersPolicyConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetResponseHeadersPolicyConfig">REST API Reference for GetResponseHeadersPolicyConfig Operation</seealso>
        GetResponseHeadersPolicyConfigResponse EndGetResponseHeadersPolicyConfig(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        IAsyncResult BeginGetStreamingDistribution(GetStreamingDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  GetStreamingDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        IAsyncResult BeginGetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistributionConfig.</param>
        /// 
        /// <returns>Returns a  GetStreamingDistributionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        GetStreamingDistributionConfigResponse EndGetStreamingDistributionConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrustStore


        /// <summary>
        /// Gets a trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStore service method.</param>
        /// 
        /// <returns>The response from the GetTrustStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        GetTrustStoreResponse GetTrustStore(GetTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStore operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        IAsyncResult BeginGetTrustStore(GetTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrustStore.</param>
        /// 
        /// <returns>Returns a  GetTrustStoreResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        GetTrustStoreResponse EndGetTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVpcOrigin


        /// <summary>
        /// Get the details of an Amazon CloudFront VPC origin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcOrigin service method.</param>
        /// 
        /// <returns>The response from the GetVpcOrigin service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetVpcOrigin">REST API Reference for GetVpcOrigin Operation</seealso>
        GetVpcOriginResponse GetVpcOrigin(GetVpcOriginRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcOrigin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcOrigin operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcOrigin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetVpcOrigin">REST API Reference for GetVpcOrigin Operation</seealso>
        IAsyncResult BeginGetVpcOrigin(GetVpcOriginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcOrigin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcOrigin.</param>
        /// 
        /// <returns>Returns a  GetVpcOriginResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetVpcOrigin">REST API Reference for GetVpcOrigin Operation</seealso>
        GetVpcOriginResponse EndGetVpcOrigin(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAnycastIpLists


        /// <summary>
        /// Lists your Anycast static IP lists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnycastIpLists service method.</param>
        /// 
        /// <returns>The response from the ListAnycastIpLists service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListAnycastIpLists">REST API Reference for ListAnycastIpLists Operation</seealso>
        ListAnycastIpListsResponse ListAnycastIpLists(ListAnycastIpListsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnycastIpLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnycastIpLists operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnycastIpLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListAnycastIpLists">REST API Reference for ListAnycastIpLists Operation</seealso>
        IAsyncResult BeginListAnycastIpLists(ListAnycastIpListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnycastIpLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnycastIpLists.</param>
        /// 
        /// <returns>Returns a  ListAnycastIpListsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListAnycastIpLists">REST API Reference for ListAnycastIpLists Operation</seealso>
        ListAnycastIpListsResponse EndListAnycastIpLists(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCachePolicies


        /// <summary>
        /// Gets a list of cache policies.
        /// 
        ///  
        /// <para>
        /// You can optionally apply a filter to return only the managed policies created by Amazon
        /// Web Services, or only the custom policies created in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCachePolicies service method.</param>
        /// 
        /// <returns>The response from the ListCachePolicies service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListCachePolicies">REST API Reference for ListCachePolicies Operation</seealso>
        ListCachePoliciesResponse ListCachePolicies(ListCachePoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCachePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCachePolicies operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCachePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListCachePolicies">REST API Reference for ListCachePolicies Operation</seealso>
        IAsyncResult BeginListCachePolicies(ListCachePoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCachePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCachePolicies.</param>
        /// 
        /// <returns>Returns a  ListCachePoliciesResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListCachePolicies">REST API Reference for ListCachePolicies Operation</seealso>
        ListCachePoliciesResponse EndListCachePolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCloudFrontOriginAccessIdentities


        /// <summary>
        /// Lists origin access identities.
        /// </summary>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities();

        /// <summary>
        /// Lists origin access identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities service method.</param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        IAsyncResult BeginListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudFrontOriginAccessIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudFrontOriginAccessIdentities.</param>
        /// 
        /// <returns>Returns a  ListCloudFrontOriginAccessIdentitiesResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        ListCloudFrontOriginAccessIdentitiesResponse EndListCloudFrontOriginAccessIdentities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConflictingAliases


        /// <summary>
        /// <note> 
        /// <para>
        /// The <c>ListConflictingAliases</c> API operation only supports standard distributions.
        /// To list domain conflicts for both standard distributions and distribution tenants,
        /// we recommend that you use the <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDomainConflicts.html">ListDomainConflicts</a>
        /// API operation instead.
        /// 
        ///  </note> 
        /// <para>
        /// Gets a list of aliases that conflict or overlap with the provided alias, and the associated
        /// CloudFront standard distribution and Amazon Web Services accounts for each conflicting
        /// alias. An alias is commonly known as a custom domain or vanity domain. It can also
        /// be called a CNAME or alternate domain name.
        /// </para>
        ///  
        /// <para>
        /// In the returned list, the standard distribution and account IDs are partially hidden,
        /// which allows you to identify the standard distribution and accounts that you own,
        /// and helps to protect the information of ones that you don't own.
        /// </para>
        ///  
        /// <para>
        /// Use this operation to find aliases that are in use in CloudFront that conflict or
        /// overlap with the provided alias. For example, if you provide <c>www.example.com</c>
        /// as input, the returned list can include <c>www.example.com</c> and the overlapping
        /// wildcard alternate domain name (<c><em>.example.com</c>), if they exist. If you provide
        /// <c></em>.example.com</c> as input, the returned list can include <c>*.example.com</c>
        /// and any alternate domain names covered by that wildcard (for example, <c>www.example.com</c>,
        /// <c>test.example.com</c>, <c>dev.example.com</c>, and so on), if they exist.
        /// </para>
        ///  
        /// <para>
        /// To list conflicting aliases, specify the alias to search and the ID of a standard
        /// distribution in your account that has an attached TLS certificate that includes the
        /// provided alias. For more information, including how to set up the standard distribution
        /// and certificate, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
        /// an alternate domain name to a different standard distribution or distribution tenant</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConflictingAliases service method.</param>
        /// 
        /// <returns>The response from the ListConflictingAliases service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListConflictingAliases">REST API Reference for ListConflictingAliases Operation</seealso>
        ListConflictingAliasesResponse ListConflictingAliases(ListConflictingAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConflictingAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConflictingAliases operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConflictingAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListConflictingAliases">REST API Reference for ListConflictingAliases Operation</seealso>
        IAsyncResult BeginListConflictingAliases(ListConflictingAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConflictingAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConflictingAliases.</param>
        /// 
        /// <returns>Returns a  ListConflictingAliasesResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListConflictingAliases">REST API Reference for ListConflictingAliases Operation</seealso>
        ListConflictingAliasesResponse EndListConflictingAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConnectionFunctions


        /// <summary>
        /// Lists connection functions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectionFunctions service method.</param>
        /// 
        /// <returns>The response from the ListConnectionFunctions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListConnectionFunctions">REST API Reference for ListConnectionFunctions Operation</seealso>
        ListConnectionFunctionsResponse ListConnectionFunctions(ListConnectionFunctionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectionFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectionFunctions operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectionFunctions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListConnectionFunctions">REST API Reference for ListConnectionFunctions Operation</seealso>
        IAsyncResult BeginListConnectionFunctions(ListConnectionFunctionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectionFunctions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectionFunctions.</param>
        /// 
        /// <returns>Returns a  ListConnectionFunctionsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListConnectionFunctions">REST API Reference for ListConnectionFunctions Operation</seealso>
        ListConnectionFunctionsResponse EndListConnectionFunctions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConnectionGroups


        /// <summary>
        /// Lists the connection groups in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectionGroups service method.</param>
        /// 
        /// <returns>The response from the ListConnectionGroups service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListConnectionGroups">REST API Reference for ListConnectionGroups Operation</seealso>
        ListConnectionGroupsResponse ListConnectionGroups(ListConnectionGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectionGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectionGroups operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectionGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListConnectionGroups">REST API Reference for ListConnectionGroups Operation</seealso>
        IAsyncResult BeginListConnectionGroups(ListConnectionGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectionGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectionGroups.</param>
        /// 
        /// <returns>Returns a  ListConnectionGroupsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListConnectionGroups">REST API Reference for ListConnectionGroups Operation</seealso>
        ListConnectionGroupsResponse EndListConnectionGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListContinuousDeploymentPolicies


        /// <summary>
        /// Gets a list of the continuous deployment policies in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContinuousDeploymentPolicies service method.</param>
        /// 
        /// <returns>The response from the ListContinuousDeploymentPolicies service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListContinuousDeploymentPolicies">REST API Reference for ListContinuousDeploymentPolicies Operation</seealso>
        ListContinuousDeploymentPoliciesResponse ListContinuousDeploymentPolicies(ListContinuousDeploymentPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListContinuousDeploymentPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContinuousDeploymentPolicies operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContinuousDeploymentPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListContinuousDeploymentPolicies">REST API Reference for ListContinuousDeploymentPolicies Operation</seealso>
        IAsyncResult BeginListContinuousDeploymentPolicies(ListContinuousDeploymentPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListContinuousDeploymentPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContinuousDeploymentPolicies.</param>
        /// 
        /// <returns>Returns a  ListContinuousDeploymentPoliciesResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListContinuousDeploymentPolicies">REST API Reference for ListContinuousDeploymentPolicies Operation</seealso>
        ListContinuousDeploymentPoliciesResponse EndListContinuousDeploymentPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributions


        /// <summary>
        /// List CloudFront distributions.
        /// </summary>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        ListDistributionsResponse ListDistributions();

        /// <summary>
        /// List CloudFront distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions service method.</param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        IAsyncResult BeginListDistributions(ListDistributionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributions.</param>
        /// 
        /// <returns>Returns a  ListDistributionsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        ListDistributionsResponse EndListDistributions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByAnycastIpListId


        /// <summary>
        /// Lists the distributions in your account that are associated with the specified <c>AnycastIpListId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByAnycastIpListId service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByAnycastIpListId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByAnycastIpListId">REST API Reference for ListDistributionsByAnycastIpListId Operation</seealso>
        ListDistributionsByAnycastIpListIdResponse ListDistributionsByAnycastIpListId(ListDistributionsByAnycastIpListIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByAnycastIpListId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByAnycastIpListId operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByAnycastIpListId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByAnycastIpListId">REST API Reference for ListDistributionsByAnycastIpListId Operation</seealso>
        IAsyncResult BeginListDistributionsByAnycastIpListId(ListDistributionsByAnycastIpListIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByAnycastIpListId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByAnycastIpListId.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByAnycastIpListIdResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByAnycastIpListId">REST API Reference for ListDistributionsByAnycastIpListId Operation</seealso>
        ListDistributionsByAnycastIpListIdResponse EndListDistributionsByAnycastIpListId(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByCachePolicyId


        /// <summary>
        /// Gets a list of distribution IDs for distributions that have a cache behavior that's
        /// associated with the specified cache policy.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByCachePolicyId service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByCachePolicyId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByCachePolicyId">REST API Reference for ListDistributionsByCachePolicyId Operation</seealso>
        ListDistributionsByCachePolicyIdResponse ListDistributionsByCachePolicyId(ListDistributionsByCachePolicyIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByCachePolicyId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByCachePolicyId operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByCachePolicyId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByCachePolicyId">REST API Reference for ListDistributionsByCachePolicyId Operation</seealso>
        IAsyncResult BeginListDistributionsByCachePolicyId(ListDistributionsByCachePolicyIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByCachePolicyId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByCachePolicyId.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByCachePolicyIdResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByCachePolicyId">REST API Reference for ListDistributionsByCachePolicyId Operation</seealso>
        ListDistributionsByCachePolicyIdResponse EndListDistributionsByCachePolicyId(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByConnectionFunction


        /// <summary>
        /// Lists distributions by connection function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByConnectionFunction service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByConnectionFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByConnectionFunction">REST API Reference for ListDistributionsByConnectionFunction Operation</seealso>
        ListDistributionsByConnectionFunctionResponse ListDistributionsByConnectionFunction(ListDistributionsByConnectionFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByConnectionFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByConnectionFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByConnectionFunction">REST API Reference for ListDistributionsByConnectionFunction Operation</seealso>
        IAsyncResult BeginListDistributionsByConnectionFunction(ListDistributionsByConnectionFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByConnectionFunction.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByConnectionFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByConnectionFunction">REST API Reference for ListDistributionsByConnectionFunction Operation</seealso>
        ListDistributionsByConnectionFunctionResponse EndListDistributionsByConnectionFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByConnectionMode


        /// <summary>
        /// Lists the distributions by the connection mode that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByConnectionMode service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByConnectionMode service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByConnectionMode">REST API Reference for ListDistributionsByConnectionMode Operation</seealso>
        ListDistributionsByConnectionModeResponse ListDistributionsByConnectionMode(ListDistributionsByConnectionModeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByConnectionMode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByConnectionMode operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByConnectionMode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByConnectionMode">REST API Reference for ListDistributionsByConnectionMode Operation</seealso>
        IAsyncResult BeginListDistributionsByConnectionMode(ListDistributionsByConnectionModeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByConnectionMode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByConnectionMode.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByConnectionModeResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByConnectionMode">REST API Reference for ListDistributionsByConnectionMode Operation</seealso>
        ListDistributionsByConnectionModeResponse EndListDistributionsByConnectionMode(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByKeyGroup


        /// <summary>
        /// Gets a list of distribution IDs for distributions that have a cache behavior that
        /// references the specified key group.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByKeyGroup service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByKeyGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByKeyGroup">REST API Reference for ListDistributionsByKeyGroup Operation</seealso>
        ListDistributionsByKeyGroupResponse ListDistributionsByKeyGroup(ListDistributionsByKeyGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByKeyGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByKeyGroup operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByKeyGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByKeyGroup">REST API Reference for ListDistributionsByKeyGroup Operation</seealso>
        IAsyncResult BeginListDistributionsByKeyGroup(ListDistributionsByKeyGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByKeyGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByKeyGroup.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByKeyGroupResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByKeyGroup">REST API Reference for ListDistributionsByKeyGroup Operation</seealso>
        ListDistributionsByKeyGroupResponse EndListDistributionsByKeyGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByOriginRequestPolicyId


        /// <summary>
        /// Gets a list of distribution IDs for distributions that have a cache behavior that's
        /// associated with the specified origin request policy.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByOriginRequestPolicyId service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByOriginRequestPolicyId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByOriginRequestPolicyId">REST API Reference for ListDistributionsByOriginRequestPolicyId Operation</seealso>
        ListDistributionsByOriginRequestPolicyIdResponse ListDistributionsByOriginRequestPolicyId(ListDistributionsByOriginRequestPolicyIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByOriginRequestPolicyId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByOriginRequestPolicyId operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByOriginRequestPolicyId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByOriginRequestPolicyId">REST API Reference for ListDistributionsByOriginRequestPolicyId Operation</seealso>
        IAsyncResult BeginListDistributionsByOriginRequestPolicyId(ListDistributionsByOriginRequestPolicyIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByOriginRequestPolicyId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByOriginRequestPolicyId.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByOriginRequestPolicyIdResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByOriginRequestPolicyId">REST API Reference for ListDistributionsByOriginRequestPolicyId Operation</seealso>
        ListDistributionsByOriginRequestPolicyIdResponse EndListDistributionsByOriginRequestPolicyId(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByOwnedResource


        /// <summary>
        /// Lists the CloudFront distributions that are associated with the specified resource
        /// that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByOwnedResource service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByOwnedResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByOwnedResource">REST API Reference for ListDistributionsByOwnedResource Operation</seealso>
        ListDistributionsByOwnedResourceResponse ListDistributionsByOwnedResource(ListDistributionsByOwnedResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByOwnedResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByOwnedResource operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByOwnedResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByOwnedResource">REST API Reference for ListDistributionsByOwnedResource Operation</seealso>
        IAsyncResult BeginListDistributionsByOwnedResource(ListDistributionsByOwnedResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByOwnedResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByOwnedResource.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByOwnedResourceResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByOwnedResource">REST API Reference for ListDistributionsByOwnedResource Operation</seealso>
        ListDistributionsByOwnedResourceResponse EndListDistributionsByOwnedResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByRealtimeLogConfig


        /// <summary>
        /// Gets a list of distributions that have a cache behavior that's associated with the
        /// specified real-time log configuration.
        /// 
        ///  
        /// <para>
        /// You can specify the real-time log configuration by its name or its Amazon Resource
        /// Name (ARN). You must provide at least one. If you provide both, CloudFront uses the
        /// name to identify the real-time log configuration to list distributions for.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByRealtimeLogConfig service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByRealtimeLogConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByRealtimeLogConfig">REST API Reference for ListDistributionsByRealtimeLogConfig Operation</seealso>
        ListDistributionsByRealtimeLogConfigResponse ListDistributionsByRealtimeLogConfig(ListDistributionsByRealtimeLogConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByRealtimeLogConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByRealtimeLogConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByRealtimeLogConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByRealtimeLogConfig">REST API Reference for ListDistributionsByRealtimeLogConfig Operation</seealso>
        IAsyncResult BeginListDistributionsByRealtimeLogConfig(ListDistributionsByRealtimeLogConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByRealtimeLogConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByRealtimeLogConfig.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByRealtimeLogConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByRealtimeLogConfig">REST API Reference for ListDistributionsByRealtimeLogConfig Operation</seealso>
        ListDistributionsByRealtimeLogConfigResponse EndListDistributionsByRealtimeLogConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByResponseHeadersPolicyId


        /// <summary>
        /// Gets a list of distribution IDs for distributions that have a cache behavior that's
        /// associated with the specified response headers policy.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByResponseHeadersPolicyId service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByResponseHeadersPolicyId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByResponseHeadersPolicyId">REST API Reference for ListDistributionsByResponseHeadersPolicyId Operation</seealso>
        ListDistributionsByResponseHeadersPolicyIdResponse ListDistributionsByResponseHeadersPolicyId(ListDistributionsByResponseHeadersPolicyIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByResponseHeadersPolicyId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByResponseHeadersPolicyId operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByResponseHeadersPolicyId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByResponseHeadersPolicyId">REST API Reference for ListDistributionsByResponseHeadersPolicyId Operation</seealso>
        IAsyncResult BeginListDistributionsByResponseHeadersPolicyId(ListDistributionsByResponseHeadersPolicyIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByResponseHeadersPolicyId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByResponseHeadersPolicyId.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByResponseHeadersPolicyIdResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByResponseHeadersPolicyId">REST API Reference for ListDistributionsByResponseHeadersPolicyId Operation</seealso>
        ListDistributionsByResponseHeadersPolicyIdResponse EndListDistributionsByResponseHeadersPolicyId(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByTrustStore


        /// <summary>
        /// Lists distributions by trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByTrustStore service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByTrustStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByTrustStore">REST API Reference for ListDistributionsByTrustStore Operation</seealso>
        ListDistributionsByTrustStoreResponse ListDistributionsByTrustStore(ListDistributionsByTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByTrustStore operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByTrustStore">REST API Reference for ListDistributionsByTrustStore Operation</seealso>
        IAsyncResult BeginListDistributionsByTrustStore(ListDistributionsByTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByTrustStore.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByTrustStoreResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByTrustStore">REST API Reference for ListDistributionsByTrustStore Operation</seealso>
        ListDistributionsByTrustStoreResponse EndListDistributionsByTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByVpcOriginId


        /// <summary>
        /// List CloudFront distributions by their VPC origin ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByVpcOriginId service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByVpcOriginId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByVpcOriginId">REST API Reference for ListDistributionsByVpcOriginId Operation</seealso>
        ListDistributionsByVpcOriginIdResponse ListDistributionsByVpcOriginId(ListDistributionsByVpcOriginIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByVpcOriginId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByVpcOriginId operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByVpcOriginId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByVpcOriginId">REST API Reference for ListDistributionsByVpcOriginId Operation</seealso>
        IAsyncResult BeginListDistributionsByVpcOriginId(ListDistributionsByVpcOriginIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByVpcOriginId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByVpcOriginId.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByVpcOriginIdResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByVpcOriginId">REST API Reference for ListDistributionsByVpcOriginId Operation</seealso>
        ListDistributionsByVpcOriginIdResponse EndListDistributionsByVpcOriginId(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionsByWebACLId


        /// <summary>
        /// List the distributions that are associated with a specified WAF web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByWebACLId service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByWebACLId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByWebACLId">REST API Reference for ListDistributionsByWebACLId Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByWebACLId">REST API Reference for ListDistributionsByWebACLId Operation</seealso>
        IAsyncResult BeginListDistributionsByWebACLId(ListDistributionsByWebACLIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByWebACLId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByWebACLId.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByWebACLIdResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByWebACLId">REST API Reference for ListDistributionsByWebACLId Operation</seealso>
        ListDistributionsByWebACLIdResponse EndListDistributionsByWebACLId(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionTenants


        /// <summary>
        /// Lists the distribution tenants in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionTenants service method.</param>
        /// 
        /// <returns>The response from the ListDistributionTenants service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionTenants">REST API Reference for ListDistributionTenants Operation</seealso>
        ListDistributionTenantsResponse ListDistributionTenants(ListDistributionTenantsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionTenants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionTenants operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionTenants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionTenants">REST API Reference for ListDistributionTenants Operation</seealso>
        IAsyncResult BeginListDistributionTenants(ListDistributionTenantsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionTenants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionTenants.</param>
        /// 
        /// <returns>Returns a  ListDistributionTenantsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionTenants">REST API Reference for ListDistributionTenants Operation</seealso>
        ListDistributionTenantsResponse EndListDistributionTenants(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributionTenantsByCustomization


        /// <summary>
        /// Lists distribution tenants by the customization that you specify.
        /// 
        ///  
        /// <para>
        /// You must specify either the <c>CertificateArn</c> parameter or <c>WebACLArn</c> parameter,
        /// but not both in the same request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionTenantsByCustomization service method.</param>
        /// 
        /// <returns>The response from the ListDistributionTenantsByCustomization service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionTenantsByCustomization">REST API Reference for ListDistributionTenantsByCustomization Operation</seealso>
        ListDistributionTenantsByCustomizationResponse ListDistributionTenantsByCustomization(ListDistributionTenantsByCustomizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionTenantsByCustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionTenantsByCustomization operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionTenantsByCustomization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionTenantsByCustomization">REST API Reference for ListDistributionTenantsByCustomization Operation</seealso>
        IAsyncResult BeginListDistributionTenantsByCustomization(ListDistributionTenantsByCustomizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionTenantsByCustomization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionTenantsByCustomization.</param>
        /// 
        /// <returns>Returns a  ListDistributionTenantsByCustomizationResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionTenantsByCustomization">REST API Reference for ListDistributionTenantsByCustomization Operation</seealso>
        ListDistributionTenantsByCustomizationResponse EndListDistributionTenantsByCustomization(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomainConflicts


        /// <summary>
        /// <note> 
        /// <para>
        /// We recommend that you use the <c>ListDomainConflicts</c> API operation to check for
        /// domain conflicts, as it supports both standard distributions and distribution tenants.
        /// <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListConflictingAliases.html">ListConflictingAliases</a>
        /// performs similar checks but only supports standard distributions.
        /// 
        ///  </note> 
        /// <para>
        /// Lists existing domain associations that conflict with the domain that you specify.
        /// </para>
        ///  
        /// <para>
        /// You can use this API operation to identify potential domain conflicts when moving
        /// domains between standard distributions and/or distribution tenants. Domain conflicts
        /// must be resolved first before they can be moved. 
        /// </para>
        ///  
        /// <para>
        /// For example, if you provide <c>www.example.com</c> as input, the returned list can
        /// include <c>www.example.com</c> and the overlapping wildcard alternate domain name
        /// (<c><em>.example.com</c>), if they exist. If you provide <c></em>.example.com</c>
        /// as input, the returned list can include <c>*.example.com</c> and any alternate domain
        /// names covered by that wildcard (for example, <c>www.example.com</c>, <c>test.example.com</c>,
        /// <c>dev.example.com</c>, and so on), if they exist.
        /// </para>
        ///  
        /// <para>
        /// To list conflicting domains, specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The domain to search for
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ID of a standard distribution or distribution tenant in your account that has
        /// an attached TLS certificate, which covers the specified domain
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, including how to set up the standard distribution or distribution
        /// tenant, and the certificate, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
        /// an alternate domain name to a different standard distribution or distribution tenant</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainConflicts service method.</param>
        /// 
        /// <returns>The response from the ListDomainConflicts service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDomainConflicts">REST API Reference for ListDomainConflicts Operation</seealso>
        ListDomainConflictsResponse ListDomainConflicts(ListDomainConflictsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainConflicts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainConflicts operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainConflicts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDomainConflicts">REST API Reference for ListDomainConflicts Operation</seealso>
        IAsyncResult BeginListDomainConflicts(ListDomainConflictsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainConflicts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainConflicts.</param>
        /// 
        /// <returns>Returns a  ListDomainConflictsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDomainConflicts">REST API Reference for ListDomainConflicts Operation</seealso>
        ListDomainConflictsResponse EndListDomainConflicts(IAsyncResult asyncResult);

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
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFieldLevelEncryptionConfigs">REST API Reference for ListFieldLevelEncryptionConfigs Operation</seealso>
        ListFieldLevelEncryptionConfigsResponse ListFieldLevelEncryptionConfigs(ListFieldLevelEncryptionConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFieldLevelEncryptionConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionConfigs operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFieldLevelEncryptionConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFieldLevelEncryptionConfigs">REST API Reference for ListFieldLevelEncryptionConfigs Operation</seealso>
        IAsyncResult BeginListFieldLevelEncryptionConfigs(ListFieldLevelEncryptionConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFieldLevelEncryptionConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFieldLevelEncryptionConfigs.</param>
        /// 
        /// <returns>Returns a  ListFieldLevelEncryptionConfigsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFieldLevelEncryptionConfigs">REST API Reference for ListFieldLevelEncryptionConfigs Operation</seealso>
        ListFieldLevelEncryptionConfigsResponse EndListFieldLevelEncryptionConfigs(IAsyncResult asyncResult);

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
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFieldLevelEncryptionProfiles">REST API Reference for ListFieldLevelEncryptionProfiles Operation</seealso>
        ListFieldLevelEncryptionProfilesResponse ListFieldLevelEncryptionProfiles(ListFieldLevelEncryptionProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFieldLevelEncryptionProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionProfiles operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFieldLevelEncryptionProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFieldLevelEncryptionProfiles">REST API Reference for ListFieldLevelEncryptionProfiles Operation</seealso>
        IAsyncResult BeginListFieldLevelEncryptionProfiles(ListFieldLevelEncryptionProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFieldLevelEncryptionProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFieldLevelEncryptionProfiles.</param>
        /// 
        /// <returns>Returns a  ListFieldLevelEncryptionProfilesResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFieldLevelEncryptionProfiles">REST API Reference for ListFieldLevelEncryptionProfiles Operation</seealso>
        ListFieldLevelEncryptionProfilesResponse EndListFieldLevelEncryptionProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFunctions


        /// <summary>
        /// Gets a list of all CloudFront functions in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can optionally apply a filter to return only the functions that are in the specified
        /// stage, either <c>DEVELOPMENT</c> or <c>LIVE</c>.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        ListFunctionsResponse ListFunctions(ListFunctionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFunctions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        IAsyncResult BeginListFunctions(ListFunctionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctions.</param>
        /// 
        /// <returns>Returns a  ListFunctionsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        ListFunctionsResponse EndListFunctions(IAsyncResult asyncResult);

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
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListInvalidations">REST API Reference for ListInvalidations Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListInvalidations">REST API Reference for ListInvalidations Operation</seealso>
        IAsyncResult BeginListInvalidations(ListInvalidationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvalidations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvalidations.</param>
        /// 
        /// <returns>Returns a  ListInvalidationsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListInvalidations">REST API Reference for ListInvalidations Operation</seealso>
        ListInvalidationsResponse EndListInvalidations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInvalidationsForDistributionTenant


        /// <summary>
        /// Lists the invalidations for a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidationsForDistributionTenant service method.</param>
        /// 
        /// <returns>The response from the ListInvalidationsForDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListInvalidationsForDistributionTenant">REST API Reference for ListInvalidationsForDistributionTenant Operation</seealso>
        ListInvalidationsForDistributionTenantResponse ListInvalidationsForDistributionTenant(ListInvalidationsForDistributionTenantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvalidationsForDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidationsForDistributionTenant operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvalidationsForDistributionTenant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListInvalidationsForDistributionTenant">REST API Reference for ListInvalidationsForDistributionTenant Operation</seealso>
        IAsyncResult BeginListInvalidationsForDistributionTenant(ListInvalidationsForDistributionTenantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvalidationsForDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvalidationsForDistributionTenant.</param>
        /// 
        /// <returns>Returns a  ListInvalidationsForDistributionTenantResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListInvalidationsForDistributionTenant">REST API Reference for ListInvalidationsForDistributionTenant Operation</seealso>
        ListInvalidationsForDistributionTenantResponse EndListInvalidationsForDistributionTenant(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKeyGroups


        /// <summary>
        /// Gets a list of key groups.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyGroups service method.</param>
        /// 
        /// <returns>The response from the ListKeyGroups service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListKeyGroups">REST API Reference for ListKeyGroups Operation</seealso>
        ListKeyGroupsResponse ListKeyGroups(ListKeyGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyGroups operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKeyGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListKeyGroups">REST API Reference for ListKeyGroups Operation</seealso>
        IAsyncResult BeginListKeyGroups(ListKeyGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKeyGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKeyGroups.</param>
        /// 
        /// <returns>Returns a  ListKeyGroupsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListKeyGroups">REST API Reference for ListKeyGroups Operation</seealso>
        ListKeyGroupsResponse EndListKeyGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKeyValueStores


        /// <summary>
        /// Specifies the key value stores to list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyValueStores service method.</param>
        /// 
        /// <returns>The response from the ListKeyValueStores service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListKeyValueStores">REST API Reference for ListKeyValueStores Operation</seealso>
        ListKeyValueStoresResponse ListKeyValueStores(ListKeyValueStoresRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyValueStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyValueStores operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKeyValueStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListKeyValueStores">REST API Reference for ListKeyValueStores Operation</seealso>
        IAsyncResult BeginListKeyValueStores(ListKeyValueStoresRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKeyValueStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKeyValueStores.</param>
        /// 
        /// <returns>Returns a  ListKeyValueStoresResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListKeyValueStores">REST API Reference for ListKeyValueStores Operation</seealso>
        ListKeyValueStoresResponse EndListKeyValueStores(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOriginAccessControls


        /// <summary>
        /// Gets the list of CloudFront origin access controls (OACs) in this Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// another request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the next request.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're not using origin access controls for your Amazon Web Services account, the
        /// <c>ListOriginAccessControls</c> operation doesn't return the <c>Items</c> element
        /// in the response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginAccessControls service method.</param>
        /// 
        /// <returns>The response from the ListOriginAccessControls service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListOriginAccessControls">REST API Reference for ListOriginAccessControls Operation</seealso>
        ListOriginAccessControlsResponse ListOriginAccessControls(ListOriginAccessControlsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOriginAccessControls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOriginAccessControls operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOriginAccessControls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListOriginAccessControls">REST API Reference for ListOriginAccessControls Operation</seealso>
        IAsyncResult BeginListOriginAccessControls(ListOriginAccessControlsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOriginAccessControls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOriginAccessControls.</param>
        /// 
        /// <returns>Returns a  ListOriginAccessControlsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListOriginAccessControls">REST API Reference for ListOriginAccessControls Operation</seealso>
        ListOriginAccessControlsResponse EndListOriginAccessControls(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOriginRequestPolicies


        /// <summary>
        /// Gets a list of origin request policies.
        /// 
        ///  
        /// <para>
        /// You can optionally apply a filter to return only the managed policies created by Amazon
        /// Web Services, or only the custom policies created in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginRequestPolicies service method.</param>
        /// 
        /// <returns>The response from the ListOriginRequestPolicies service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListOriginRequestPolicies">REST API Reference for ListOriginRequestPolicies Operation</seealso>
        ListOriginRequestPoliciesResponse ListOriginRequestPolicies(ListOriginRequestPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOriginRequestPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOriginRequestPolicies operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOriginRequestPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListOriginRequestPolicies">REST API Reference for ListOriginRequestPolicies Operation</seealso>
        IAsyncResult BeginListOriginRequestPolicies(ListOriginRequestPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOriginRequestPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOriginRequestPolicies.</param>
        /// 
        /// <returns>Returns a  ListOriginRequestPoliciesResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListOriginRequestPolicies">REST API Reference for ListOriginRequestPolicies Operation</seealso>
        ListOriginRequestPoliciesResponse EndListOriginRequestPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPublicKeys


        /// <summary>
        /// List all public keys that have been added to CloudFront for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys service method.</param>
        /// 
        /// <returns>The response from the ListPublicKeys service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        ListPublicKeysResponse ListPublicKeys(ListPublicKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPublicKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        IAsyncResult BeginListPublicKeys(ListPublicKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPublicKeys.</param>
        /// 
        /// <returns>Returns a  ListPublicKeysResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        ListPublicKeysResponse EndListPublicKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRealtimeLogConfigs


        /// <summary>
        /// Gets a list of real-time log configurations.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRealtimeLogConfigs service method.</param>
        /// 
        /// <returns>The response from the ListRealtimeLogConfigs service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListRealtimeLogConfigs">REST API Reference for ListRealtimeLogConfigs Operation</seealso>
        ListRealtimeLogConfigsResponse ListRealtimeLogConfigs(ListRealtimeLogConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRealtimeLogConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRealtimeLogConfigs operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRealtimeLogConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListRealtimeLogConfigs">REST API Reference for ListRealtimeLogConfigs Operation</seealso>
        IAsyncResult BeginListRealtimeLogConfigs(ListRealtimeLogConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRealtimeLogConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRealtimeLogConfigs.</param>
        /// 
        /// <returns>Returns a  ListRealtimeLogConfigsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListRealtimeLogConfigs">REST API Reference for ListRealtimeLogConfigs Operation</seealso>
        ListRealtimeLogConfigsResponse EndListRealtimeLogConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResponseHeadersPolicies


        /// <summary>
        /// Gets a list of response headers policies.
        /// 
        ///  
        /// <para>
        /// You can optionally apply a filter to get only the managed policies created by Amazon
        /// Web Services, or only the custom policies created in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponseHeadersPolicies service method.</param>
        /// 
        /// <returns>The response from the ListResponseHeadersPolicies service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListResponseHeadersPolicies">REST API Reference for ListResponseHeadersPolicies Operation</seealso>
        ListResponseHeadersPoliciesResponse ListResponseHeadersPolicies(ListResponseHeadersPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResponseHeadersPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResponseHeadersPolicies operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResponseHeadersPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListResponseHeadersPolicies">REST API Reference for ListResponseHeadersPolicies Operation</seealso>
        IAsyncResult BeginListResponseHeadersPolicies(ListResponseHeadersPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResponseHeadersPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResponseHeadersPolicies.</param>
        /// 
        /// <returns>Returns a  ListResponseHeadersPoliciesResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListResponseHeadersPolicies">REST API Reference for ListResponseHeadersPolicies Operation</seealso>
        ListResponseHeadersPoliciesResponse EndListResponseHeadersPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStreamingDistributions


        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        ListStreamingDistributionsResponse ListStreamingDistributions();

        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions service method.</param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        IAsyncResult BeginListStreamingDistributions(ListStreamingDistributionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamingDistributions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamingDistributions.</param>
        /// 
        /// <returns>Returns a  ListStreamingDistributionsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        ListStreamingDistributionsResponse EndListStreamingDistributions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for a CloudFront resource. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/tagging.html">Tagging
        /// a distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrustStores


        /// <summary>
        /// Lists trust stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStores service method.</param>
        /// 
        /// <returns>The response from the ListTrustStores service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        ListTrustStoresResponse ListTrustStores(ListTrustStoresRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrustStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStores operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrustStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        IAsyncResult BeginListTrustStores(ListTrustStoresRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrustStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrustStores.</param>
        /// 
        /// <returns>Returns a  ListTrustStoresResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        ListTrustStoresResponse EndListTrustStores(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVpcOrigins


        /// <summary>
        /// List the CloudFront VPC origins in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcOrigins service method.</param>
        /// 
        /// <returns>The response from the ListVpcOrigins service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListVpcOrigins">REST API Reference for ListVpcOrigins Operation</seealso>
        ListVpcOriginsResponse ListVpcOrigins(ListVpcOriginsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcOrigins operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcOrigins operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcOrigins
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListVpcOrigins">REST API Reference for ListVpcOrigins Operation</seealso>
        IAsyncResult BeginListVpcOrigins(ListVpcOriginsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcOrigins operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcOrigins.</param>
        /// 
        /// <returns>Returns a  ListVpcOriginsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListVpcOrigins">REST API Reference for ListVpcOrigins Operation</seealso>
        ListVpcOriginsResponse EndListVpcOrigins(IAsyncResult asyncResult);

        #endregion
        
        #region  PublishConnectionFunction


        /// <summary>
        /// Publishes a connection function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishConnectionFunction service method.</param>
        /// 
        /// <returns>The response from the PublishConnectionFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/PublishConnectionFunction">REST API Reference for PublishConnectionFunction Operation</seealso>
        PublishConnectionFunctionResponse PublishConnectionFunction(PublishConnectionFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PublishConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishConnectionFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishConnectionFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/PublishConnectionFunction">REST API Reference for PublishConnectionFunction Operation</seealso>
        IAsyncResult BeginPublishConnectionFunction(PublishConnectionFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PublishConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishConnectionFunction.</param>
        /// 
        /// <returns>Returns a  PublishConnectionFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/PublishConnectionFunction">REST API Reference for PublishConnectionFunction Operation</seealso>
        PublishConnectionFunctionResponse EndPublishConnectionFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  PublishFunction


        /// <summary>
        /// Publishes a CloudFront function by copying the function code from the <c>DEVELOPMENT</c>
        /// stage to <c>LIVE</c>. This automatically updates all cache behaviors that are using
        /// this function to use the newly published copy in the <c>LIVE</c> stage.
        /// 
        ///  
        /// <para>
        /// When a function is published to the <c>LIVE</c> stage, you can attach the function
        /// to a distribution's cache behavior, using the function's Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// To publish a function, you must provide the function's name and version (<c>ETag</c>
        /// value). To get these values, you can use <c>ListFunctions</c> and <c>DescribeFunction</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishFunction service method.</param>
        /// 
        /// <returns>The response from the PublishFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/PublishFunction">REST API Reference for PublishFunction Operation</seealso>
        PublishFunctionResponse PublishFunction(PublishFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PublishFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/PublishFunction">REST API Reference for PublishFunction Operation</seealso>
        IAsyncResult BeginPublishFunction(PublishFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PublishFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishFunction.</param>
        /// 
        /// <returns>Returns a  PublishFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/PublishFunction">REST API Reference for PublishFunction Operation</seealso>
        PublishFunctionResponse EndPublishFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Creates a resource control policy for a given CloudFront resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add tags to a CloudFront resource. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/tagging.html">Tagging
        /// a distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestConnectionFunction


        /// <summary>
        /// Tests a connection function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestConnectionFunction service method.</param>
        /// 
        /// <returns>The response from the TestConnectionFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TestFunctionFailedException">
        /// The CloudFront function failed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/TestConnectionFunction">REST API Reference for TestConnectionFunction Operation</seealso>
        TestConnectionFunctionResponse TestConnectionFunction(TestConnectionFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestConnectionFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestConnectionFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/TestConnectionFunction">REST API Reference for TestConnectionFunction Operation</seealso>
        IAsyncResult BeginTestConnectionFunction(TestConnectionFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestConnectionFunction.</param>
        /// 
        /// <returns>Returns a  TestConnectionFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/TestConnectionFunction">REST API Reference for TestConnectionFunction Operation</seealso>
        TestConnectionFunctionResponse EndTestConnectionFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  TestFunction


        /// <summary>
        /// Tests a CloudFront function.
        /// 
        ///  
        /// <para>
        /// To test a function, you provide an <i>event object</i> that represents an HTTP request
        /// or response that your CloudFront distribution could receive in production. CloudFront
        /// runs the function, passing it the event object that you provided, and returns the
        /// function's result (the modified event object) in the response. The response also contains
        /// function logs and error messages, if any exist. For more information about testing
        /// functions, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/managing-functions.html#test-function">Testing
        /// functions</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To test a function, you provide the function's name and version (<c>ETag</c> value)
        /// along with the event object. To get the function's name and version, you can use <c>ListFunctions</c>
        /// and <c>DescribeFunction</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestFunction service method.</param>
        /// 
        /// <returns>The response from the TestFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TestFunctionFailedException">
        /// The CloudFront function failed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/TestFunction">REST API Reference for TestFunction Operation</seealso>
        TestFunctionResponse TestFunction(TestFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/TestFunction">REST API Reference for TestFunction Operation</seealso>
        IAsyncResult BeginTestFunction(TestFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestFunction.</param>
        /// 
        /// <returns>Returns a  TestFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/TestFunction">REST API Reference for TestFunction Operation</seealso>
        TestFunctionResponse EndTestFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove tags from a CloudFront resource. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/tagging.html">Tagging
        /// a distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAnycastIpList


        /// <summary>
        /// Updates an Anycast static IP list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnycastIpList service method.</param>
        /// 
        /// <returns>The response from the UpdateAnycastIpList service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateAnycastIpList">REST API Reference for UpdateAnycastIpList Operation</seealso>
        UpdateAnycastIpListResponse UpdateAnycastIpList(UpdateAnycastIpListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAnycastIpList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnycastIpList operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnycastIpList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateAnycastIpList">REST API Reference for UpdateAnycastIpList Operation</seealso>
        IAsyncResult BeginUpdateAnycastIpList(UpdateAnycastIpListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnycastIpList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnycastIpList.</param>
        /// 
        /// <returns>Returns a  UpdateAnycastIpListResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateAnycastIpList">REST API Reference for UpdateAnycastIpList Operation</seealso>
        UpdateAnycastIpListResponse EndUpdateAnycastIpList(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCachePolicy


        /// <summary>
        /// Updates a cache policy configuration.
        /// 
        ///  
        /// <para>
        /// When you update a cache policy configuration, all the fields are updated with the
        /// values provided in the request. You cannot update some fields independent of others.
        /// To update a cache policy configuration:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <c>GetCachePolicyConfig</c> to get the current configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Locally modify the fields in the cache policy configuration that you want to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <c>UpdateCachePolicy</c> by providing the entire cache policy configuration,
        /// including the fields that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol> <important> 
        /// <para>
        /// If your minimum TTL is greater than 0, CloudFront will cache content for at least
        /// the duration specified in the cache policy's minimum TTL, even if the <c>Cache-Control:
        /// no-cache</c>, <c>no-store</c>, or <c>private</c> directives are present in the origin
        /// headers.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCachePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateCachePolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CachePolicyAlreadyExistsException">
        /// A cache policy with this name already exists. You must provide a unique name. To modify
        /// an existing cache policy, use <c>UpdateCachePolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookiesInCachePolicyException">
        /// The number of cookies in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInCachePolicyException">
        /// The number of headers in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringsInCachePolicyException">
        /// The number of query strings in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateCachePolicy">REST API Reference for UpdateCachePolicy Operation</seealso>
        UpdateCachePolicyResponse UpdateCachePolicy(UpdateCachePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCachePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCachePolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCachePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateCachePolicy">REST API Reference for UpdateCachePolicy Operation</seealso>
        IAsyncResult BeginUpdateCachePolicy(UpdateCachePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCachePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCachePolicy.</param>
        /// 
        /// <returns>Returns a  UpdateCachePolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateCachePolicy">REST API Reference for UpdateCachePolicy Operation</seealso>
        UpdateCachePolicyResponse EndUpdateCachePolicy(IAsyncResult asyncResult);

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
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateCloudFrontOriginAccessIdentity">REST API Reference for UpdateCloudFrontOriginAccessIdentity Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateCloudFrontOriginAccessIdentity">REST API Reference for UpdateCloudFrontOriginAccessIdentity Operation</seealso>
        IAsyncResult BeginUpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  UpdateCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateCloudFrontOriginAccessIdentity">REST API Reference for UpdateCloudFrontOriginAccessIdentity Operation</seealso>
        UpdateCloudFrontOriginAccessIdentityResponse EndUpdateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConnectionFunction


        /// <summary>
        /// Updates a connection function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionFunction service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectionFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntitySizeLimitExceededException">
        /// The entity size limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateConnectionFunction">REST API Reference for UpdateConnectionFunction Operation</seealso>
        UpdateConnectionFunctionResponse UpdateConnectionFunction(UpdateConnectionFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectionFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateConnectionFunction">REST API Reference for UpdateConnectionFunction Operation</seealso>
        IAsyncResult BeginUpdateConnectionFunction(UpdateConnectionFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectionFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectionFunction.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateConnectionFunction">REST API Reference for UpdateConnectionFunction Operation</seealso>
        UpdateConnectionFunctionResponse EndUpdateConnectionFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConnectionGroup


        /// <summary>
        /// Updates a connection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectionGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceInUseException">
        /// Cannot delete this resource because it is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateConnectionGroup">REST API Reference for UpdateConnectionGroup Operation</seealso>
        UpdateConnectionGroupResponse UpdateConnectionGroup(UpdateConnectionGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionGroup operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateConnectionGroup">REST API Reference for UpdateConnectionGroup Operation</seealso>
        IAsyncResult BeginUpdateConnectionGroup(UpdateConnectionGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectionGroup.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionGroupResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateConnectionGroup">REST API Reference for UpdateConnectionGroup Operation</seealso>
        UpdateConnectionGroupResponse EndUpdateConnectionGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateContinuousDeploymentPolicy


        /// <summary>
        /// Updates a continuous deployment policy. You can update a continuous deployment policy
        /// to enable or disable it, to change the percentage of traffic that it sends to the
        /// staging distribution, or to change the staging distribution that it sends traffic
        /// to.
        /// 
        ///  
        /// <para>
        /// When you update a continuous deployment policy configuration, all the fields are updated
        /// with the values that are provided in the request. You cannot update some fields independent
        /// of others. To update a continuous deployment policy configuration:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <c>GetContinuousDeploymentPolicyConfig</c> to get the current configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Locally modify the fields in the continuous deployment policy configuration that you
        /// want to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>UpdateContinuousDeploymentPolicy</c>, providing the entire continuous deployment
        /// policy configuration, including the fields that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContinuousDeploymentPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateContinuousDeploymentPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StagingDistributionInUseException">
        /// A continuous deployment policy for this staging distribution already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateContinuousDeploymentPolicy">REST API Reference for UpdateContinuousDeploymentPolicy Operation</seealso>
        UpdateContinuousDeploymentPolicyResponse UpdateContinuousDeploymentPolicy(UpdateContinuousDeploymentPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContinuousDeploymentPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContinuousDeploymentPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContinuousDeploymentPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateContinuousDeploymentPolicy">REST API Reference for UpdateContinuousDeploymentPolicy Operation</seealso>
        IAsyncResult BeginUpdateContinuousDeploymentPolicy(UpdateContinuousDeploymentPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContinuousDeploymentPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContinuousDeploymentPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateContinuousDeploymentPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateContinuousDeploymentPolicy">REST API Reference for UpdateContinuousDeploymentPolicy Operation</seealso>
        UpdateContinuousDeploymentPolicyResponse EndUpdateContinuousDeploymentPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDistribution


        /// <summary>
        /// Updates the configuration for a CloudFront distribution.
        /// 
        ///  
        /// <para>
        /// The update process includes getting the current distribution configuration, updating
        /// it to make your changes, and then submitting an <c>UpdateDistribution</c> request
        /// to make the updates.
        /// </para>
        ///  
        /// <para>
        ///  <b>To update a web distribution using the CloudFront API</b> 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <c>GetDistributionConfig</c> to get the current configuration, including the version
        /// identifier (<c>ETag</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the distribution configuration that was returned in the response. Note the
        /// following important requirements and restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must copy the <c>ETag</c> field value from the response. (You'll use it for the
        /// <c>IfMatch</c> parameter in your request.) Then, remove the <c>ETag</c> field from
        /// the distribution configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't change the value of <c>CallerReference</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Submit an <c>UpdateDistribution</c> request, providing the updated distribution configuration.
        /// The new configuration replaces the existing configuration. The values that you specify
        /// in an <c>UpdateDistribution</c> request are not merged into your existing configuration.
        /// Make sure to include all fields: the ones that you modified and also the ones that
        /// you didn't.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution service method.</param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ContinuousDeploymentPolicyInUseException">
        /// You cannot delete a continuous deployment policy that is associated with a primary
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalOriginAccessConfigurationException">
        /// An origin cannot contain both an origin access control (OAC) and an origin access
        /// identity (OAI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDomainNameForOriginAccessControlException">
        /// An origin access control is associated with an origin whose domain name is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// An invalid error code was specified.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <c>whitelisted</c> list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidFunctionAssociationException">
        /// A CloudFront function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// The specified geo restriction parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// The headers specified are not valid for an Amazon S3 origin.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda@Edge function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// The location code specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// The minimum protocol version specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// The keep alive timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// The read timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// The query string parameters specified are not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <c>RequiredProtocols</c> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// A response code is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// The TTL order specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// A viewer certificate specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <c>Origin Id</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigOwnerMismatchException">
        /// The specified real-time log configuration belongs to a different Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StagingDistributionInUseException">
        /// A continuous deployment policy for this staging distribution already exists.
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
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToCachePolicyException">
        /// The maximum number of distributions have been associated with the specified cache
        /// policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToKeyGroupException">
        /// The number of distributions that reference this key group is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginAccessControlException">
        /// The maximum number of distributions have been associated with the specified origin
        /// access control.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginRequestPolicyException">
        /// The maximum number of distributions have been associated with the specified origin
        /// request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToResponseHeadersPolicyException">
        /// The maximum number of distributions have been associated with the specified response
        /// headers policy.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithFunctionAssociationsException">
        /// You have reached the maximum number of distributions that are associated with a CloudFront
        /// function. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda@Edge
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithSingleFunctionARNException">
        /// The maximum number of distributions have been associated with the specified Lambda@Edge
        /// function.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionAssociationsException">
        /// You have reached the maximum number of CloudFront function associations for this distribution.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// Your request contains too many headers in forwarded values.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsAssociatedToDistributionException">
        /// The number of key groups referenced by this distribution is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda@Edge function associations than are allowed per
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// Your request contains too many origin custom headers.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginGroupsPerDistributionException">
        /// Processing your request would cause you to exceed the maximum number of origin groups
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// Your request contains too many query string parameters.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedKeyGroupDoesNotExistException">
        /// The specified key group does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        IAsyncResult BeginUpdateDistribution(UpdateDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDistribution.</param>
        /// 
        /// <returns>Returns a  UpdateDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        UpdateDistributionResponse EndUpdateDistribution(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDistributionTenant


        /// <summary>
        /// Updates a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionTenant service method.</param>
        /// 
        /// <returns>The response from the UpdateDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidAssociationException">
        /// The specified CloudFront resource can't be associated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistributionTenant">REST API Reference for UpdateDistributionTenant Operation</seealso>
        UpdateDistributionTenantResponse UpdateDistributionTenant(UpdateDistributionTenantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionTenant operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDistributionTenant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistributionTenant">REST API Reference for UpdateDistributionTenant Operation</seealso>
        IAsyncResult BeginUpdateDistributionTenant(UpdateDistributionTenantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDistributionTenant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDistributionTenant.</param>
        /// 
        /// <returns>Returns a  UpdateDistributionTenantResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistributionTenant">REST API Reference for UpdateDistributionTenant Operation</seealso>
        UpdateDistributionTenantResponse EndUpdateDistributionTenant(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDistributionWithStagingConfig


        /// <summary>
        /// Copies the staging distribution's configuration to its corresponding primary distribution.
        /// The primary distribution retains its <c>Aliases</c> (also known as alternate domain
        /// names or CNAMEs) and <c>ContinuousDeploymentPolicyId</c> value, but otherwise its
        /// configuration is overwritten to match the staging distribution.
        /// 
        ///  
        /// <para>
        /// You can use this operation in a continuous deployment workflow after you have tested
        /// configuration changes on the staging distribution. After using a continuous deployment
        /// policy to move a portion of your domain name's traffic to the staging distribution
        /// and verifying that it works as intended, you can use this operation to copy the staging
        /// distribution's configuration to the primary distribution. This action will disable
        /// the continuous deployment policy and move your domain's traffic back to the primary
        /// distribution.
        /// </para>
        ///  
        /// <para>
        /// This API operation requires the following IAM permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_GetDistribution.html">GetDistribution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionWithStagingConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateDistributionWithStagingConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// An invalid error code was specified.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <c>whitelisted</c> list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidFunctionAssociationException">
        /// A CloudFront function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// The specified geo restriction parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// The headers specified are not valid for an Amazon S3 origin.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda@Edge function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// The location code specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// The minimum protocol version specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// The keep alive timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// The read timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// The query string parameters specified are not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <c>RequiredProtocols</c> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// A response code is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// The TTL order specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// A viewer certificate specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <c>Origin Id</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigOwnerMismatchException">
        /// The specified real-time log configuration belongs to a different Amazon Web Services
        /// account.
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
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToCachePolicyException">
        /// The maximum number of distributions have been associated with the specified cache
        /// policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToKeyGroupException">
        /// The number of distributions that reference this key group is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginAccessControlException">
        /// The maximum number of distributions have been associated with the specified origin
        /// access control.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginRequestPolicyException">
        /// The maximum number of distributions have been associated with the specified origin
        /// request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToResponseHeadersPolicyException">
        /// The maximum number of distributions have been associated with the specified response
        /// headers policy.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithFunctionAssociationsException">
        /// You have reached the maximum number of distributions that are associated with a CloudFront
        /// function. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda@Edge
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithSingleFunctionARNException">
        /// The maximum number of distributions have been associated with the specified Lambda@Edge
        /// function.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionAssociationsException">
        /// You have reached the maximum number of CloudFront function associations for this distribution.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// Your request contains too many headers in forwarded values.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsAssociatedToDistributionException">
        /// The number of key groups referenced by this distribution is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda@Edge function associations than are allowed per
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// Your request contains too many origin custom headers.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginGroupsPerDistributionException">
        /// Processing your request would cause you to exceed the maximum number of origin groups
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// Your request contains too many query string parameters.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedKeyGroupDoesNotExistException">
        /// The specified key group does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistributionWithStagingConfig">REST API Reference for UpdateDistributionWithStagingConfig Operation</seealso>
        UpdateDistributionWithStagingConfigResponse UpdateDistributionWithStagingConfig(UpdateDistributionWithStagingConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistributionWithStagingConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionWithStagingConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDistributionWithStagingConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistributionWithStagingConfig">REST API Reference for UpdateDistributionWithStagingConfig Operation</seealso>
        IAsyncResult BeginUpdateDistributionWithStagingConfig(UpdateDistributionWithStagingConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDistributionWithStagingConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDistributionWithStagingConfig.</param>
        /// 
        /// <returns>Returns a  UpdateDistributionWithStagingConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistributionWithStagingConfig">REST API Reference for UpdateDistributionWithStagingConfig Operation</seealso>
        UpdateDistributionWithStagingConfigResponse EndUpdateDistributionWithStagingConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomainAssociation


        /// <summary>
        /// <note> 
        /// <para>
        /// We recommend that you use the <c>UpdateDomainAssociation</c> API operation to move
        /// a domain association, as it supports both standard distributions and distribution
        /// tenants. <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_AssociateAlias.html">AssociateAlias</a>
        /// performs similar checks but only supports standard distributions.
        /// 
        ///  </note> 
        /// <para>
        /// Moves a domain from its current standard distribution or distribution tenant to another
        /// one.
        /// </para>
        ///  
        /// <para>
        /// You must first disable the source distribution (standard distribution or distribution
        /// tenant) and then separately call this operation to move the domain to another target
        /// distribution (standard distribution or distribution tenant).
        /// </para>
        ///  
        /// <para>
        /// To use this operation, specify the domain and the ID of the target resource (standard
        /// distribution or distribution tenant). For more information, including how to set up
        /// the target resource, prerequisites that you must complete, and other restrictions,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
        /// an alternate domain name to a different standard distribution or distribution tenant</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainAssociation service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        UpdateDomainAssociationResponse UpdateDomainAssociation(UpdateDomainAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainAssociation operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        IAsyncResult BeginUpdateDomainAssociation(UpdateDomainAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateDomainAssociationResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        UpdateDomainAssociationResponse EndUpdateDomainAssociation(IAsyncResult asyncResult);

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
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFieldLevelEncryptionConfig">REST API Reference for UpdateFieldLevelEncryptionConfig Operation</seealso>
        UpdateFieldLevelEncryptionConfigResponse UpdateFieldLevelEncryptionConfig(UpdateFieldLevelEncryptionConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFieldLevelEncryptionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFieldLevelEncryptionConfig">REST API Reference for UpdateFieldLevelEncryptionConfig Operation</seealso>
        IAsyncResult BeginUpdateFieldLevelEncryptionConfig(UpdateFieldLevelEncryptionConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFieldLevelEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  UpdateFieldLevelEncryptionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFieldLevelEncryptionConfig">REST API Reference for UpdateFieldLevelEncryptionConfig Operation</seealso>
        UpdateFieldLevelEncryptionConfigResponse EndUpdateFieldLevelEncryptionConfig(IAsyncResult asyncResult);

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
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionEncryptionEntitiesException">
        /// The maximum number of encryption entities for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionFieldPatternsException">
        /// The maximum number of field patterns for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFieldLevelEncryptionProfile">REST API Reference for UpdateFieldLevelEncryptionProfile Operation</seealso>
        UpdateFieldLevelEncryptionProfileResponse UpdateFieldLevelEncryptionProfile(UpdateFieldLevelEncryptionProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionProfile operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFieldLevelEncryptionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFieldLevelEncryptionProfile">REST API Reference for UpdateFieldLevelEncryptionProfile Operation</seealso>
        IAsyncResult BeginUpdateFieldLevelEncryptionProfile(UpdateFieldLevelEncryptionProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFieldLevelEncryptionProfile.</param>
        /// 
        /// <returns>Returns a  UpdateFieldLevelEncryptionProfileResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFieldLevelEncryptionProfile">REST API Reference for UpdateFieldLevelEncryptionProfile Operation</seealso>
        UpdateFieldLevelEncryptionProfileResponse EndUpdateFieldLevelEncryptionProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFunction


        /// <summary>
        /// Updates a CloudFront function.
        /// 
        ///  
        /// <para>
        /// You can update a function's code or the comment that describes the function. You cannot
        /// update a function's name.
        /// </para>
        ///  
        /// <para>
        /// To update a function, you provide the function's name and version (<c>ETag</c> value)
        /// along with the updated function code. To get the name and version, you can use <c>ListFunctions</c>
        /// and <c>DescribeFunction</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunction service method.</param>
        /// 
        /// <returns>The response from the UpdateFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FunctionSizeLimitExceededException">
        /// The function is too large. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFunction">REST API Reference for UpdateFunction Operation</seealso>
        UpdateFunctionResponse UpdateFunction(UpdateFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunction operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFunction">REST API Reference for UpdateFunction Operation</seealso>
        IAsyncResult BeginUpdateFunction(UpdateFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunction.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFunction">REST API Reference for UpdateFunction Operation</seealso>
        UpdateFunctionResponse EndUpdateFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKeyGroup


        /// <summary>
        /// Updates a key group.
        /// 
        ///  
        /// <para>
        /// When you update a key group, all the fields are updated with the values provided in
        /// the request. You cannot update some fields independent of others. To update a key
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Get the current key group with <c>GetKeyGroup</c> or <c>GetKeyGroupConfig</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Locally modify the fields in the key group that you want to update. For example, add
        /// or remove public key IDs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <c>UpdateKeyGroup</c> with the entire key group object, including the fields
        /// that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateKeyGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.KeyGroupAlreadyExistsException">
        /// A key group with this name already exists. You must provide a unique name. To modify
        /// an existing key group, use <c>UpdateKeyGroup</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyPublicKeysInKeyGroupException">
        /// The number of public keys in this key group is more than the maximum allowed. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateKeyGroup">REST API Reference for UpdateKeyGroup Operation</seealso>
        UpdateKeyGroupResponse UpdateKeyGroup(UpdateKeyGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeyGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyGroup operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKeyGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateKeyGroup">REST API Reference for UpdateKeyGroup Operation</seealso>
        IAsyncResult BeginUpdateKeyGroup(UpdateKeyGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKeyGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKeyGroup.</param>
        /// 
        /// <returns>Returns a  UpdateKeyGroupResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateKeyGroup">REST API Reference for UpdateKeyGroup Operation</seealso>
        UpdateKeyGroupResponse EndUpdateKeyGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKeyValueStore


        /// <summary>
        /// Specifies the key value store to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyValueStore service method.</param>
        /// 
        /// <returns>The response from the UpdateKeyValueStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateKeyValueStore">REST API Reference for UpdateKeyValueStore Operation</seealso>
        UpdateKeyValueStoreResponse UpdateKeyValueStore(UpdateKeyValueStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyValueStore operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKeyValueStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateKeyValueStore">REST API Reference for UpdateKeyValueStore Operation</seealso>
        IAsyncResult BeginUpdateKeyValueStore(UpdateKeyValueStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKeyValueStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKeyValueStore.</param>
        /// 
        /// <returns>Returns a  UpdateKeyValueStoreResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateKeyValueStore">REST API Reference for UpdateKeyValueStore Operation</seealso>
        UpdateKeyValueStoreResponse EndUpdateKeyValueStore(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOriginAccessControl


        /// <summary>
        /// Updates a CloudFront origin access control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginAccessControl service method.</param>
        /// 
        /// <returns>The response from the UpdateOriginAccessControl service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginAccessControlException">
        /// The origin access control does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginAccessControlAlreadyExistsException">
        /// An origin access control with the specified parameters already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateOriginAccessControl">REST API Reference for UpdateOriginAccessControl Operation</seealso>
        UpdateOriginAccessControlResponse UpdateOriginAccessControl(UpdateOriginAccessControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOriginAccessControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginAccessControl operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOriginAccessControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateOriginAccessControl">REST API Reference for UpdateOriginAccessControl Operation</seealso>
        IAsyncResult BeginUpdateOriginAccessControl(UpdateOriginAccessControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOriginAccessControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOriginAccessControl.</param>
        /// 
        /// <returns>Returns a  UpdateOriginAccessControlResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateOriginAccessControl">REST API Reference for UpdateOriginAccessControl Operation</seealso>
        UpdateOriginAccessControlResponse EndUpdateOriginAccessControl(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOriginRequestPolicy


        /// <summary>
        /// Updates an origin request policy configuration.
        /// 
        ///  
        /// <para>
        /// When you update an origin request policy configuration, all the fields are updated
        /// with the values provided in the request. You cannot update some fields independent
        /// of others. To update an origin request policy configuration:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <c>GetOriginRequestPolicyConfig</c> to get the current configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Locally modify the fields in the origin request policy configuration that you want
        /// to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <c>UpdateOriginRequestPolicy</c> by providing the entire origin request policy
        /// configuration, including the fields that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginRequestPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateOriginRequestPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginRequestPolicyAlreadyExistsException">
        /// An origin request policy with this name already exists. You must provide a unique
        /// name. To modify an existing origin request policy, use <c>UpdateOriginRequestPolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookiesInOriginRequestPolicyException">
        /// The number of cookies in the origin request policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInOriginRequestPolicyException">
        /// The number of headers in the origin request policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringsInOriginRequestPolicyException">
        /// The number of query strings in the origin request policy exceeds the maximum. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateOriginRequestPolicy">REST API Reference for UpdateOriginRequestPolicy Operation</seealso>
        UpdateOriginRequestPolicyResponse UpdateOriginRequestPolicy(UpdateOriginRequestPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOriginRequestPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginRequestPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOriginRequestPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateOriginRequestPolicy">REST API Reference for UpdateOriginRequestPolicy Operation</seealso>
        IAsyncResult BeginUpdateOriginRequestPolicy(UpdateOriginRequestPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOriginRequestPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOriginRequestPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateOriginRequestPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateOriginRequestPolicy">REST API Reference for UpdateOriginRequestPolicy Operation</seealso>
        UpdateOriginRequestPolicyResponse EndUpdateOriginRequestPolicy(IAsyncResult asyncResult);

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
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdatePublicKey">REST API Reference for UpdatePublicKey Operation</seealso>
        UpdatePublicKeyResponse UpdatePublicKey(UpdatePublicKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicKey operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdatePublicKey">REST API Reference for UpdatePublicKey Operation</seealso>
        IAsyncResult BeginUpdatePublicKey(UpdatePublicKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePublicKey.</param>
        /// 
        /// <returns>Returns a  UpdatePublicKeyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdatePublicKey">REST API Reference for UpdatePublicKey Operation</seealso>
        UpdatePublicKeyResponse EndUpdatePublicKey(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRealtimeLogConfig


        /// <summary>
        /// Updates a real-time log configuration.
        /// 
        ///  
        /// <para>
        /// When you update a real-time log configuration, all the parameters are updated with
        /// the values provided in the request. You cannot update some parameters independent
        /// of others. To update a real-time log configuration:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Call <c>GetRealtimeLogConfig</c> to get the current real-time log configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Locally modify the parameters in the real-time log configuration that you want to
        /// update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call this API (<c>UpdateRealtimeLogConfig</c>) by providing the entire real-time log
        /// configuration, including the parameters that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// You cannot update a real-time log configuration's <c>Name</c> or <c>ARN</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRealtimeLogConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateRealtimeLogConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateRealtimeLogConfig">REST API Reference for UpdateRealtimeLogConfig Operation</seealso>
        UpdateRealtimeLogConfigResponse UpdateRealtimeLogConfig(UpdateRealtimeLogConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRealtimeLogConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRealtimeLogConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRealtimeLogConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateRealtimeLogConfig">REST API Reference for UpdateRealtimeLogConfig Operation</seealso>
        IAsyncResult BeginUpdateRealtimeLogConfig(UpdateRealtimeLogConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRealtimeLogConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRealtimeLogConfig.</param>
        /// 
        /// <returns>Returns a  UpdateRealtimeLogConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateRealtimeLogConfig">REST API Reference for UpdateRealtimeLogConfig Operation</seealso>
        UpdateRealtimeLogConfigResponse EndUpdateRealtimeLogConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResponseHeadersPolicy


        /// <summary>
        /// Updates a response headers policy.
        /// 
        ///  
        /// <para>
        /// When you update a response headers policy, the entire policy is replaced. You cannot
        /// update some policy fields independent of others. To update a response headers policy
        /// configuration:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <c>GetResponseHeadersPolicyConfig</c> to get the current policy's configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modify the fields in the response headers policy configuration that you want to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <c>UpdateResponseHeadersPolicy</c>, providing the entire response headers policy
        /// configuration, including the fields that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponseHeadersPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateResponseHeadersPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResponseHeadersPolicyAlreadyExistsException">
        /// A response headers policy with this name already exists. You must provide a unique
        /// name. To modify an existing response headers policy, use <c>UpdateResponseHeadersPolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooLongCSPInResponseHeadersPolicyException">
        /// The length of the <c>Content-Security-Policy</c> header value in the response headers
        /// policy exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCustomHeadersInResponseHeadersPolicyException">
        /// The number of custom headers in the response headers policy exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyRemoveHeadersInResponseHeadersPolicyException">
        /// The number of headers in <c>RemoveHeadersConfig</c> in the response headers policy
        /// exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateResponseHeadersPolicy">REST API Reference for UpdateResponseHeadersPolicy Operation</seealso>
        UpdateResponseHeadersPolicyResponse UpdateResponseHeadersPolicy(UpdateResponseHeadersPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResponseHeadersPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponseHeadersPolicy operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResponseHeadersPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateResponseHeadersPolicy">REST API Reference for UpdateResponseHeadersPolicy Operation</seealso>
        IAsyncResult BeginUpdateResponseHeadersPolicy(UpdateResponseHeadersPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResponseHeadersPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResponseHeadersPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateResponseHeadersPolicyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateResponseHeadersPolicy">REST API Reference for UpdateResponseHeadersPolicy Operation</seealso>
        UpdateResponseHeadersPolicyResponse EndUpdateResponseHeadersPolicy(IAsyncResult asyncResult);

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
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateStreamingDistribution">REST API Reference for UpdateStreamingDistribution Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateStreamingDistribution">REST API Reference for UpdateStreamingDistribution Operation</seealso>
        IAsyncResult BeginUpdateStreamingDistribution(UpdateStreamingDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  UpdateStreamingDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateStreamingDistribution">REST API Reference for UpdateStreamingDistribution Operation</seealso>
        UpdateStreamingDistributionResponse EndUpdateStreamingDistribution(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTrustStore


        /// <summary>
        /// Updates a trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustStore service method.</param>
        /// 
        /// <returns>The response from the UpdateTrustStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        UpdateTrustStoreResponse UpdateTrustStore(UpdateTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustStore operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        IAsyncResult BeginUpdateTrustStore(UpdateTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrustStore.</param>
        /// 
        /// <returns>Returns a  UpdateTrustStoreResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        UpdateTrustStoreResponse EndUpdateTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVpcOrigin


        /// <summary>
        /// Update an Amazon CloudFront VPC origin in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcOrigin service method.</param>
        /// 
        /// <returns>The response from the UpdateVpcOrigin service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotUpdateEntityWhileInUseException">
        /// The entity cannot be updated while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateVpcOrigin">REST API Reference for UpdateVpcOrigin Operation</seealso>
        UpdateVpcOriginResponse UpdateVpcOrigin(UpdateVpcOriginRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcOrigin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcOrigin operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVpcOrigin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateVpcOrigin">REST API Reference for UpdateVpcOrigin Operation</seealso>
        IAsyncResult BeginUpdateVpcOrigin(UpdateVpcOriginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVpcOrigin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVpcOrigin.</param>
        /// 
        /// <returns>Returns a  UpdateVpcOriginResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateVpcOrigin">REST API Reference for UpdateVpcOrigin Operation</seealso>
        UpdateVpcOriginResponse EndUpdateVpcOrigin(IAsyncResult asyncResult);

        #endregion
        
        #region  VerifyDnsConfiguration


        /// <summary>
        /// Verify the DNS configuration for your domain names. This API operation checks whether
        /// your domain name points to the correct routing endpoint of the connection group, such
        /// as d111111abcdef8.cloudfront.net. You can use this API operation to troubleshoot and
        /// resolve DNS configuration issues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDnsConfiguration service method.</param>
        /// 
        /// <returns>The response from the VerifyDnsConfiguration service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/VerifyDnsConfiguration">REST API Reference for VerifyDnsConfiguration Operation</seealso>
        VerifyDnsConfigurationResponse VerifyDnsConfiguration(VerifyDnsConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDnsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyDnsConfiguration operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyDnsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/VerifyDnsConfiguration">REST API Reference for VerifyDnsConfiguration Operation</seealso>
        IAsyncResult BeginVerifyDnsConfiguration(VerifyDnsConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyDnsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyDnsConfiguration.</param>
        /// 
        /// <returns>Returns a  VerifyDnsConfigurationResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/VerifyDnsConfiguration">REST API Reference for VerifyDnsConfiguration Operation</seealso>
        VerifyDnsConfigurationResponse EndVerifyDnsConfiguration(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}