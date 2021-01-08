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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WAFV2.Model;

namespace Amazon.WAFV2
{
    /// <summary>
    /// Interface for accessing WAFV2
    ///
    /// <note> 
    /// <para>
    /// This is the latest version of the <b>AWS WAF</b> API, released in November, 2019.
    /// The names of the entities that you use to access this API, like endpoints and namespaces,
    /// all have the versioning information added, like "V2" or "v2", to distinguish from
    /// the prior version. We recommend migrating your resources to this version, because
    /// it has a number of significant improvements.
    /// </para>
    ///  
    /// <para>
    /// If you used AWS WAF prior to this release, you can't use this AWS WAFV2 API to access
    /// any AWS WAF resources that you created before. You can access your old rules, web
    /// ACLs, and other AWS WAF resources only through the AWS WAF Classic APIs. The AWS WAF
    /// Classic APIs have retained the prior names, endpoints, and namespaces. 
    /// </para>
    ///  
    /// <para>
    /// For information, including how to migrate your AWS WAF resources to this version,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// AWS WAF is a web application firewall that lets you monitor the HTTP and HTTPS requests
    /// that are forwarded to Amazon CloudFront, an Amazon API Gateway REST API, an Application
    /// Load Balancer, or an AWS AppSync GraphQL API. AWS WAF also lets you control access
    /// to your content. Based on conditions that you specify, such as the IP addresses that
    /// requests originate from or the values of query strings, the API Gateway REST API,
    /// CloudFront distribution, the Application Load Balancer, or the AWS AppSync GraphQL
    /// API responds to requests either with the requested content or with an HTTP 403 status
    /// code (Forbidden). You also can configure CloudFront to return a custom error page
    /// when a request is blocked.
    /// </para>
    ///  
    /// <para>
    /// This API guide is for developers who need detailed information about AWS WAF API actions,
    /// data types, and errors. For detailed information about AWS WAF features and an overview
    /// of how to use AWS WAF, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS
    /// WAF Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can make calls using the endpoints listed in <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#waf_region">AWS
    /// Service Endpoints for AWS WAF</a>. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For regional applications, you can use any of the endpoints in the list. A regional
    /// application can be an Application Load Balancer (ALB), an API Gateway REST API, or
    /// an AppSync GraphQL API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For AWS CloudFront applications, you must use the API endpoint listed for US East
    /// (N. Virginia): us-east-1.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Alternatively, you can use one of the AWS SDKs to access an API that's tailored to
    /// the programming language or platform that you're using. For more information, see
    /// <a href="http://aws.amazon.com/tools/#SDKs">AWS SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// We currently provide two versions of the AWS WAF API: this API and the prior versions,
    /// the classic AWS WAF APIs. This new API provides the same functionality as the older
    /// versions, with the following major improvements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You use one API for both global and regional applications. Where you need to distinguish
    /// the scope, you specify a <code>Scope</code> parameter and set it to <code>CLOUDFRONT</code>
    /// or <code>REGIONAL</code>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can define a Web ACL or rule group with a single call, and update it with a single
    /// call. You define all rule specifications in JSON format, and pass them to your rule
    /// group or Web ACL calls.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The limits AWS WAF places on the use of rules more closely reflects the cost of running
    /// each type of rule. Rule groups include capacity settings, so you know the maximum
    /// cost of a rule group when you use it.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonWAFV2 : IAmazonService, IDisposable
    {


        
        #region  AssociateWebACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates a Web ACL with a regional application resource, to protect the resource.
        /// A regional application can be an Application Load Balancer (ALB), an API Gateway REST
        /// API, or an AppSync GraphQL API. 
        /// </para>
        ///  
        /// <para>
        /// For AWS CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To associate a Web ACL, in the CloudFront call <code>UpdateDistribution</code>,
        /// set the web ACL ID to the Amazon Resource Name (ARN) of the Web ACL. For information,
        /// see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL service method.</param>
        /// 
        /// <returns>The response from the AssociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        AssociateWebACLResponse AssociateWebACL(AssociateWebACLRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates a Web ACL with a regional application resource, to protect the resource.
        /// A regional application can be an Application Load Balancer (ALB), an API Gateway REST
        /// API, or an AppSync GraphQL API. 
        /// </para>
        ///  
        /// <para>
        /// For AWS CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To associate a Web ACL, in the CloudFront call <code>UpdateDistribution</code>,
        /// set the web ACL ID to the Amazon Resource Name (ARN) of the Web ACL. For information,
        /// see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        Task<AssociateWebACLResponse> AssociateWebACLAsync(AssociateWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CheckCapacity


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the web ACL capacity unit (WCU) requirements for a specified scope and set
        /// of rules. You can use this to check the capacity requirements for the rules you want
        /// to use in a <a>RuleGroup</a> or <a>WebACL</a>. 
        /// </para>
        ///  
        /// <para>
        /// AWS WAF uses WCUs to calculate and control the operating resources that are used to
        /// run your rules, rule groups, and web ACLs. AWS WAF calculates capacity differently
        /// for each rule type, to reflect the relative cost of each rule. Simple rules that cost
        /// little to run use fewer WCUs than more complex rules that use more processing power.
        /// Rule group capacity is fixed at creation, which helps users plan their web ACL WCU
        /// usage when they use a rule group. The WCU limit for web ACLs is 1,500. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckCapacity service method.</param>
        /// 
        /// <returns>The response from the CheckCapacity service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CheckCapacity">REST API Reference for CheckCapacity Operation</seealso>
        CheckCapacityResponse CheckCapacity(CheckCapacityRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the web ACL capacity unit (WCU) requirements for a specified scope and set
        /// of rules. You can use this to check the capacity requirements for the rules you want
        /// to use in a <a>RuleGroup</a> or <a>WebACL</a>. 
        /// </para>
        ///  
        /// <para>
        /// AWS WAF uses WCUs to calculate and control the operating resources that are used to
        /// run your rules, rule groups, and web ACLs. AWS WAF calculates capacity differently
        /// for each rule type, to reflect the relative cost of each rule. Simple rules that cost
        /// little to run use fewer WCUs than more complex rules that use more processing power.
        /// Rule group capacity is fixed at creation, which helps users plan their web ACL WCU
        /// usage when they use a rule group. The WCU limit for web ACLs is 1,500. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckCapacity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckCapacity service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CheckCapacity">REST API Reference for CheckCapacity Operation</seealso>
        Task<CheckCapacityResponse> CheckCapacityAsync(CheckCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateIPSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>IPSet</a>, which you use to identify web requests that originate from
        /// specific IP addresses or ranges of IP addresses. For example, if you're receiving
        /// a lot of requests from a ranges of IP addresses, you can configure AWS WAF to block
        /// them using an IPSet that lists those IP addresses. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        CreateIPSetResponse CreateIPSet(CreateIPSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>IPSet</a>, which you use to identify web requests that originate from
        /// specific IP addresses or ranges of IP addresses. For example, if you're receiving
        /// a lot of requests from a ranges of IP addresses, you can configure AWS WAF to block
        /// them using an IPSet that lists those IP addresses. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        Task<CreateIPSetResponse> CreateIPSetAsync(CreateIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRegexPatternSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RegexPatternSet</a>, which you reference in a <a>RegexPatternSetReferenceStatement</a>,
        /// to have AWS WAF inspect a web request component for the specified patterns.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the CreateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        CreateRegexPatternSetResponse CreateRegexPatternSet(CreateRegexPatternSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RegexPatternSet</a>, which you reference in a <a>RegexPatternSetReferenceStatement</a>,
        /// to have AWS WAF inspect a web request component for the specified patterns.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        Task<CreateRegexPatternSetResponse> CreateRegexPatternSetAsync(CreateRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRuleGroup


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RuleGroup</a> per the specifications provided. 
        /// </para>
        ///  
        /// <para>
        ///  A rule group defines a collection of rules to inspect and control web requests that
        /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
        /// capacity limit. If you update a rule group, you must stay within the capacity. This
        /// allows others to reuse the rule group with confidence in its capacity requirements.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the CreateRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RuleGroup</a> per the specifications provided. 
        /// </para>
        ///  
        /// <para>
        ///  A rule group defines a collection of rules to inspect and control web requests that
        /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
        /// capacity limit. If you update a rule group, you must stay within the capacity. This
        /// allows others to reuse the rule group with confidence in its capacity requirements.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        Task<CreateRuleGroupResponse> CreateRuleGroupAsync(CreateRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWebACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>WebACL</a> per the specifications provided.
        /// </para>
        ///  
        /// <para>
        ///  A Web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has an action defined (allow, block, or count) for requests that match the
        /// statement of the rule. In the Web ACL, you assign a default action to take (allow,
        /// block) for any request that does not match any of the rules. The rules in a Web ACL
        /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
        /// group. You can associate a Web ACL with one or more AWS resources to protect. The
        /// resources can be Amazon CloudFront, an Amazon API Gateway REST API, an Application
        /// Load Balancer, or an AWS AppSync GraphQL API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        CreateWebACLResponse CreateWebACL(CreateWebACLRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>WebACL</a> per the specifications provided.
        /// </para>
        ///  
        /// <para>
        ///  A Web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has an action defined (allow, block, or count) for requests that match the
        /// statement of the rule. In the Web ACL, you assign a default action to take (allow,
        /// block) for any request that does not match any of the rules. The rules in a Web ACL
        /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
        /// group. You can associate a Web ACL with one or more AWS resources to protect. The
        /// resources can be Amazon CloudFront, an Amazon API Gateway REST API, an Application
        /// Load Balancer, or an AWS AppSync GraphQL API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        Task<CreateWebACLResponse> CreateWebACLAsync(CreateWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFirewallManagerRuleGroups


        /// <summary>
        /// Deletes all rule groups that are managed by AWS Firewall Manager for the specified
        /// web ACL. 
        /// 
        ///  
        /// <para>
        /// You can only use this if <code>ManagedByFirewallManager</code> is false in the specified
        /// <a>WebACL</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallManagerRuleGroups service method.</param>
        /// 
        /// <returns>The response from the DeleteFirewallManagerRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteFirewallManagerRuleGroups">REST API Reference for DeleteFirewallManagerRuleGroups Operation</seealso>
        DeleteFirewallManagerRuleGroupsResponse DeleteFirewallManagerRuleGroups(DeleteFirewallManagerRuleGroupsRequest request);



        /// <summary>
        /// Deletes all rule groups that are managed by AWS Firewall Manager for the specified
        /// web ACL. 
        /// 
        ///  
        /// <para>
        /// You can only use this if <code>ManagedByFirewallManager</code> is false in the specified
        /// <a>WebACL</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallManagerRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFirewallManagerRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteFirewallManagerRuleGroups">REST API Reference for DeleteFirewallManagerRuleGroups Operation</seealso>
        Task<DeleteFirewallManagerRuleGroupsResponse> DeleteFirewallManagerRuleGroupsAsync(DeleteFirewallManagerRuleGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIPSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>IPSet</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>IPSet</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        Task<DeleteIPSetResponse> DeleteIPSetAsync(DeleteIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLoggingConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the <a>LoggingConfiguration</a> from the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        DeleteLoggingConfigurationResponse DeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the <a>LoggingConfiguration</a> from the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        Task<DeleteLoggingConfigurationResponse> DeleteLoggingConfigurationAsync(DeleteLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePermissionPolicy


        /// <summary>
        /// Permanently deletes an IAM policy from the specified rule group.
        /// 
        ///  
        /// <para>
        /// You must be the owner of the rule group to perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionPolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePermissionPolicy service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        DeletePermissionPolicyResponse DeletePermissionPolicy(DeletePermissionPolicyRequest request);



        /// <summary>
        /// Permanently deletes an IAM policy from the specified rule group.
        /// 
        ///  
        /// <para>
        /// You must be the owner of the rule group to perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePermissionPolicy service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        Task<DeletePermissionPolicyResponse> DeletePermissionPolicyAsync(DeletePermissionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRegexPatternSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the DeleteRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        DeleteRegexPatternSetResponse DeleteRegexPatternSet(DeleteRegexPatternSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        Task<DeleteRegexPatternSetResponse> DeleteRegexPatternSetAsync(DeleteRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRuleGroup


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>RuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>RuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        Task<DeleteRuleGroupResponse> DeleteRuleGroupAsync(DeleteRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWebACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>WebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// You can only use this if <code>ManagedByFirewallManager</code> is false in the specified
        /// <a>WebACL</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        DeleteWebACLResponse DeleteWebACL(DeleteWebACLRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>WebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// You can only use this if <code>ManagedByFirewallManager</code> is false in the specified
        /// <a>WebACL</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        Task<DeleteWebACLResponse> DeleteWebACLAsync(DeleteWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeManagedRuleGroup


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Provides high-level information for a managed rule group, including descriptions of
        /// the rules. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeManagedRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedRuleGroup">REST API Reference for DescribeManagedRuleGroup Operation</seealso>
        DescribeManagedRuleGroupResponse DescribeManagedRuleGroup(DescribeManagedRuleGroupRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Provides high-level information for a managed rule group, including descriptions of
        /// the rules. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeManagedRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedRuleGroup">REST API Reference for DescribeManagedRuleGroup Operation</seealso>
        Task<DescribeManagedRuleGroupResponse> DescribeManagedRuleGroupAsync(DescribeManagedRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateWebACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Disassociates a Web ACL from a regional application resource. A regional application
        /// can be an Application Load Balancer (ALB), an API Gateway REST API, or an AppSync
        /// GraphQL API. 
        /// </para>
        ///  
        /// <para>
        /// For AWS CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To disassociate a Web ACL, provide an empty web ACL ID in the CloudFront
        /// call <code>UpdateDistribution</code>. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL service method.</param>
        /// 
        /// <returns>The response from the DisassociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        DisassociateWebACLResponse DisassociateWebACL(DisassociateWebACLRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Disassociates a Web ACL from a regional application resource. A regional application
        /// can be an Application Load Balancer (ALB), an API Gateway REST API, or an AppSync
        /// GraphQL API. 
        /// </para>
        ///  
        /// <para>
        /// For AWS CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To disassociate a Web ACL, provide an empty web ACL ID in the CloudFront
        /// call <code>UpdateDistribution</code>. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        Task<DisassociateWebACLResponse> DisassociateWebACLAsync(DisassociateWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIPSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>IPSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        GetIPSetResponse GetIPSet(GetIPSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>IPSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        Task<GetIPSetResponse> GetIPSetAsync(GetIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLoggingConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>LoggingConfiguration</a> for the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        GetLoggingConfigurationResponse GetLoggingConfiguration(GetLoggingConfigurationRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>LoggingConfiguration</a> for the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        Task<GetLoggingConfigurationResponse> GetLoggingConfigurationAsync(GetLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPermissionPolicy


        /// <summary>
        /// Returns the IAM policy that is attached to the specified rule group.
        /// 
        ///  
        /// <para>
        /// You must be the owner of the rule group to perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPermissionPolicy service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        GetPermissionPolicyResponse GetPermissionPolicy(GetPermissionPolicyRequest request);



        /// <summary>
        /// Returns the IAM policy that is attached to the specified rule group.
        /// 
        ///  
        /// <para>
        /// You must be the owner of the rule group to perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPermissionPolicy service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        Task<GetPermissionPolicyResponse> GetPermissionPolicyAsync(GetPermissionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRateBasedStatementManagedKeys


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the keys that are currently blocked by a rate-based rule. The maximum number
        /// of managed keys that can be blocked for a single rate-based rule is 10,000. If more
        /// than 10,000 addresses exceed the rate limit, those with the highest rates are blocked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedStatementManagedKeys service method.</param>
        /// 
        /// <returns>The response from the GetRateBasedStatementManagedKeys service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        GetRateBasedStatementManagedKeysResponse GetRateBasedStatementManagedKeys(GetRateBasedStatementManagedKeysRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the keys that are currently blocked by a rate-based rule. The maximum number
        /// of managed keys that can be blocked for a single rate-based rule is 10,000. If more
        /// than 10,000 addresses exceed the rate limit, those with the highest rates are blocked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedStatementManagedKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRateBasedStatementManagedKeys service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        Task<GetRateBasedStatementManagedKeysResponse> GetRateBasedStatementManagedKeysAsync(GetRateBasedStatementManagedKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRegexPatternSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the GetRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        GetRegexPatternSetResponse GetRegexPatternSet(GetRegexPatternSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        Task<GetRegexPatternSetResponse> GetRegexPatternSetAsync(GetRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRuleGroup


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>RuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup service method.</param>
        /// 
        /// <returns>The response from the GetRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        GetRuleGroupResponse GetRuleGroup(GetRuleGroupRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>RuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        Task<GetRuleGroupResponse> GetRuleGroupAsync(GetRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSampledRequests


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets detailed information about a specified number of requests--a sample--that AWS
        /// WAF randomly selects from among the first 5,000 requests that your AWS resource received
        /// during a time range that you choose. You can specify a sample size of up to 500 requests,
        /// and you can specify any time range in the previous three hours.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetSampledRequests</code> returns a time range, which is usually the time range
        /// that you specified. However, if your resource (such as a CloudFront distribution)
        /// received 5,000 requests before the specified time range elapsed, <code>GetSampledRequests</code>
        /// returns an updated time range. This new time range indicates the actual period during
        /// which AWS WAF selected the requests in the sample.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests service method.</param>
        /// 
        /// <returns>The response from the GetSampledRequests service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        GetSampledRequestsResponse GetSampledRequests(GetSampledRequestsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets detailed information about a specified number of requests--a sample--that AWS
        /// WAF randomly selects from among the first 5,000 requests that your AWS resource received
        /// during a time range that you choose. You can specify a sample size of up to 500 requests,
        /// and you can specify any time range in the previous three hours.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetSampledRequests</code> returns a time range, which is usually the time range
        /// that you specified. However, if your resource (such as a CloudFront distribution)
        /// received 5,000 requests before the specified time range elapsed, <code>GetSampledRequests</code>
        /// returns an updated time range. This new time range indicates the actual period during
        /// which AWS WAF selected the requests in the sample.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSampledRequests service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        Task<GetSampledRequestsResponse> GetSampledRequestsAsync(GetSampledRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWebACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>WebACL</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        GetWebACLResponse GetWebACL(GetWebACLRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>WebACL</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        Task<GetWebACLResponse> GetWebACLAsync(GetWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWebACLForResource


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the <a>WebACL</a> for the specified resource. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource service method.</param>
        /// 
        /// <returns>The response from the GetWebACLForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        GetWebACLForResourceResponse GetWebACLForResource(GetWebACLForResourceRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the <a>WebACL</a> for the specified resource. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebACLForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        Task<GetWebACLForResourceResponse> GetWebACLForResourceAsync(GetWebACLForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAvailableManagedRuleGroups


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of managed rule groups that are available for you to use. This
        /// list includes all AWS Managed Rules rule groups and the AWS Marketplace managed rule
        /// groups that you're subscribed to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListAvailableManagedRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroups">REST API Reference for ListAvailableManagedRuleGroups Operation</seealso>
        ListAvailableManagedRuleGroupsResponse ListAvailableManagedRuleGroups(ListAvailableManagedRuleGroupsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of managed rule groups that are available for you to use. This
        /// list includes all AWS Managed Rules rule groups and the AWS Marketplace managed rule
        /// groups that you're subscribed to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableManagedRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroups">REST API Reference for ListAvailableManagedRuleGroups Operation</seealso>
        Task<ListAvailableManagedRuleGroupsResponse> ListAvailableManagedRuleGroupsAsync(ListAvailableManagedRuleGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIPSets


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>IPSetSummary</a> objects for the IP sets that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        ListIPSetsResponse ListIPSets(ListIPSetsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>IPSetSummary</a> objects for the IP sets that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        Task<ListIPSetsResponse> ListIPSetsAsync(ListIPSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLoggingConfigurations


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of your <a>LoggingConfiguration</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListLoggingConfigurations service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        ListLoggingConfigurationsResponse ListLoggingConfigurations(ListLoggingConfigurationsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of your <a>LoggingConfiguration</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLoggingConfigurations service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        Task<ListLoggingConfigurationsResponse> ListLoggingConfigurationsAsync(ListLoggingConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRegexPatternSets


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>RegexPatternSetSummary</a> objects for the regex pattern
        /// sets that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets service method.</param>
        /// 
        /// <returns>The response from the ListRegexPatternSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        ListRegexPatternSetsResponse ListRegexPatternSets(ListRegexPatternSetsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>RegexPatternSetSummary</a> objects for the regex pattern
        /// sets that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegexPatternSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        Task<ListRegexPatternSetsResponse> ListRegexPatternSetsAsync(ListRegexPatternSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourcesForWebACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of the Amazon Resource Names (ARNs) for the regional resources
        /// that are associated with the specified web ACL. If you want the list of AWS CloudFront
        /// resources, use the AWS CloudFront call <code>ListDistributionsByWebACLId</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL service method.</param>
        /// 
        /// <returns>The response from the ListResourcesForWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        ListResourcesForWebACLResponse ListResourcesForWebACL(ListResourcesForWebACLRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of the Amazon Resource Names (ARNs) for the regional resources
        /// that are associated with the specified web ACL. If you want the list of AWS CloudFront
        /// resources, use the AWS CloudFront call <code>ListDistributionsByWebACLId</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcesForWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        Task<ListResourcesForWebACLResponse> ListResourcesForWebACLAsync(ListResourcesForWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRuleGroups


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>RuleGroupSummary</a> objects for the rule groups that you
        /// manage. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>RuleGroupSummary</a> objects for the rule groups that you
        /// manage. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        Task<ListRuleGroupsResponse> ListRuleGroupsAsync(ListRuleGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the <a>TagInfoForResource</a> for the specified resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each AWS resource,
        /// up to 50 tags for a resource.
        /// </para>
        ///  
        /// <para>
        /// You can tag the AWS resources that you manage through AWS WAF: web ACLs, rule groups,
        /// IP sets, and regex pattern sets. You can't manage or view tags through the AWS WAF
        /// console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the <a>TagInfoForResource</a> for the specified resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each AWS resource,
        /// up to 50 tags for a resource.
        /// </para>
        ///  
        /// <para>
        /// You can tag the AWS resources that you manage through AWS WAF: web ACLs, rule groups,
        /// IP sets, and regex pattern sets. You can't manage or view tags through the AWS WAF
        /// console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWebACLs


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>WebACLSummary</a> objects for the web ACLs that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
        /// 
        /// <returns>The response from the ListWebACLs service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        ListWebACLsResponse ListWebACLs(ListWebACLsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>WebACLSummary</a> objects for the web ACLs that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebACLs service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        Task<ListWebACLsResponse> ListWebACLsAsync(ListWebACLsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLoggingConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Enables the specified <a>LoggingConfiguration</a>, to start logging from a web ACL,
        /// according to the configuration provided.
        /// </para>
        ///  
        /// <para>
        /// You can access information about all traffic that AWS WAF inspects using the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create an Amazon Kinesis Data Firehose. 
        /// </para>
        ///  
        /// <para>
        /// Create the data firehose with a PUT source and in the Region that you are operating.
        /// If you are capturing logs for Amazon CloudFront, always create the firehose in US
        /// East (N. Virginia). 
        /// </para>
        ///  
        /// <para>
        /// Give the data firehose a name that starts with the prefix <code>aws-waf-logs-</code>.
        /// For example, <code>aws-waf-logs-us-east-2-analytics</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not create the data firehose using a <code>Kinesis stream</code> as your source.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Associate that firehose to your web ACL using a <code>PutLoggingConfiguration</code>
        /// request.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you successfully enable logging using a <code>PutLoggingConfiguration</code>
        /// request, AWS WAF will create a service linked role with the necessary permissions
        /// to write logs to the Amazon Kinesis Data Firehose. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// Web ACL Traffic Information</a> in the <i>AWS WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFServiceLinkedRoleErrorException">
        /// AWS WAF is not able to access the service linked role. This can be caused by a previous
        /// <code>PutLoggingConfiguration</code> request, which can lock the service linked role
        /// for about 20 seconds. Please try your request again. The service linked role can also
        /// be locked by a previous <code>DeleteServiceLinkedRole</code> request, which can lock
        /// the role for 15 minutes or more. If you recently made a call to <code>DeleteServiceLinkedRole</code>,
        /// wait at least 15 minutes and try the request again. If you receive this same exception
        /// again, you will have to wait additional time until the role is unlocked.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        PutLoggingConfigurationResponse PutLoggingConfiguration(PutLoggingConfigurationRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Enables the specified <a>LoggingConfiguration</a>, to start logging from a web ACL,
        /// according to the configuration provided.
        /// </para>
        ///  
        /// <para>
        /// You can access information about all traffic that AWS WAF inspects using the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create an Amazon Kinesis Data Firehose. 
        /// </para>
        ///  
        /// <para>
        /// Create the data firehose with a PUT source and in the Region that you are operating.
        /// If you are capturing logs for Amazon CloudFront, always create the firehose in US
        /// East (N. Virginia). 
        /// </para>
        ///  
        /// <para>
        /// Give the data firehose a name that starts with the prefix <code>aws-waf-logs-</code>.
        /// For example, <code>aws-waf-logs-us-east-2-analytics</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not create the data firehose using a <code>Kinesis stream</code> as your source.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Associate that firehose to your web ACL using a <code>PutLoggingConfiguration</code>
        /// request.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you successfully enable logging using a <code>PutLoggingConfiguration</code>
        /// request, AWS WAF will create a service linked role with the necessary permissions
        /// to write logs to the Amazon Kinesis Data Firehose. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// Web ACL Traffic Information</a> in the <i>AWS WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFServiceLinkedRoleErrorException">
        /// AWS WAF is not able to access the service linked role. This can be caused by a previous
        /// <code>PutLoggingConfiguration</code> request, which can lock the service linked role
        /// for about 20 seconds. Please try your request again. The service linked role can also
        /// be locked by a previous <code>DeleteServiceLinkedRole</code> request, which can lock
        /// the role for 15 minutes or more. If you recently made a call to <code>DeleteServiceLinkedRole</code>,
        /// wait at least 15 minutes and try the request again. If you receive this same exception
        /// again, you will have to wait additional time until the role is unlocked.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        Task<PutLoggingConfigurationResponse> PutLoggingConfigurationAsync(PutLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutPermissionPolicy


        /// <summary>
        /// Attaches an IAM policy to the specified resource. Use this to share a rule group across
        /// accounts.
        /// 
        ///  
        /// <para>
        /// You must be the owner of the rule group to perform this operation.
        /// </para>
        ///  
        /// <para>
        /// This action is subject to the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can attach only one policy with each <code>PutPermissionPolicy</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF <a>RuleGroup</a> ARN and the rule group
        /// must exist in the same region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user making the request must be the owner of the rule group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionPolicy service method.</param>
        /// 
        /// <returns>The response from the PutPermissionPolicy service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidPermissionPolicyException">
        /// The operation failed because the specified policy isn't in the proper format. 
        /// 
        ///  
        /// <para>
        /// The policy specifications must conform to the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The policy must be composed using IAM Policy version 2012-10-17 or version 2015-01-01.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include specifications for <code>Effect</code>, <code>Action</code>,
        /// and <code>Principal</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Effect</code> must specify <code>Allow</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Action</code> must specify <code>wafv2:CreateWebACL</code>, <code>wafv2:UpdateWebACL</code>,
        /// and <code>wafv2:PutFirewallManagerRuleGroups</code>. AWS WAF rejects any extra actions
        /// or wildcard actions in the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must not include a <code>Resource</code> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        PutPermissionPolicyResponse PutPermissionPolicy(PutPermissionPolicyRequest request);



        /// <summary>
        /// Attaches an IAM policy to the specified resource. Use this to share a rule group across
        /// accounts.
        /// 
        ///  
        /// <para>
        /// You must be the owner of the rule group to perform this operation.
        /// </para>
        ///  
        /// <para>
        /// This action is subject to the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can attach only one policy with each <code>PutPermissionPolicy</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF <a>RuleGroup</a> ARN and the rule group
        /// must exist in the same region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user making the request must be the owner of the rule group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPermissionPolicy service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidPermissionPolicyException">
        /// The operation failed because the specified policy isn't in the proper format. 
        /// 
        ///  
        /// <para>
        /// The policy specifications must conform to the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The policy must be composed using IAM Policy version 2012-10-17 or version 2015-01-01.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include specifications for <code>Effect</code>, <code>Action</code>,
        /// and <code>Principal</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Effect</code> must specify <code>Allow</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Action</code> must specify <code>wafv2:CreateWebACL</code>, <code>wafv2:UpdateWebACL</code>,
        /// and <code>wafv2:PutFirewallManagerRuleGroups</code>. AWS WAF rejects any extra actions
        /// or wildcard actions in the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must not include a <code>Resource</code> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        Task<PutPermissionPolicyResponse> PutPermissionPolicyAsync(PutPermissionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates tags with the specified AWS resource. Tags are key:value pairs that you
        /// can use to categorize and manage your resources, for purposes like billing. For example,
        /// you might set the tag key to "customer" and the value to the customer name or ID.
        /// You can specify one or more tags to add to each AWS resource, up to 50 tags for a
        /// resource.
        /// </para>
        ///  
        /// <para>
        /// You can tag the AWS resources that you manage through AWS WAF: web ACLs, rule groups,
        /// IP sets, and regex pattern sets. You can't manage or view tags through the AWS WAF
        /// console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates tags with the specified AWS resource. Tags are key:value pairs that you
        /// can use to categorize and manage your resources, for purposes like billing. For example,
        /// you might set the tag key to "customer" and the value to the customer name or ID.
        /// You can specify one or more tags to add to each AWS resource, up to 50 tags for a
        /// resource.
        /// </para>
        ///  
        /// <para>
        /// You can tag the AWS resources that you manage through AWS WAF: web ACLs, rule groups,
        /// IP sets, and regex pattern sets. You can't manage or view tags through the AWS WAF
        /// console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Disassociates tags from an AWS resource. Tags are key:value pairs that you can associate
        /// with AWS resources. For example, the tag key might be "customer" and the tag value
        /// might be "companyA." You can specify one or more tags to add to each container. You
        /// can add up to 50 tags to each AWS resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Disassociates tags from an AWS resource. Tags are key:value pairs that you can associate
        /// with AWS resources. For example, the tag key might be "customer" and the tag value
        /// might be "companyA." You can specify one or more tags to add to each container. You
        /// can add up to 50 tags to each AWS resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIPSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>IPSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>IPSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        Task<UpdateIPSetResponse> UpdateIPSetAsync(UpdateIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRegexPatternSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the UpdateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        UpdateRegexPatternSetResponse UpdateRegexPatternSet(UpdateRegexPatternSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        Task<UpdateRegexPatternSetResponse> UpdateRegexPatternSetAsync(UpdateRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRuleGroup


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>RuleGroup</a>.
        /// </para>
        ///  
        /// <para>
        ///  A rule group defines a collection of rules to inspect and control web requests that
        /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
        /// capacity limit. If you update a rule group, you must stay within the capacity. This
        /// allows others to reuse the rule group with confidence in its capacity requirements.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        UpdateRuleGroupResponse UpdateRuleGroup(UpdateRuleGroupRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>RuleGroup</a>.
        /// </para>
        ///  
        /// <para>
        ///  A rule group defines a collection of rules to inspect and control web requests that
        /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
        /// capacity limit. If you update a rule group, you must stay within the capacity. This
        /// allows others to reuse the rule group with confidence in its capacity requirements.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        Task<UpdateRuleGroupResponse> UpdateRuleGroupAsync(UpdateRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWebACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>WebACL</a>.
        /// </para>
        ///  
        /// <para>
        ///  A Web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has an action defined (allow, block, or count) for requests that match the
        /// statement of the rule. In the Web ACL, you assign a default action to take (allow,
        /// block) for any request that does not match any of the rules. The rules in a Web ACL
        /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
        /// group. You can associate a Web ACL with one or more AWS resources to protect. The
        /// resources can be Amazon CloudFront, an Amazon API Gateway REST API, an Application
        /// Load Balancer, or an AWS AppSync GraphQL API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        UpdateWebACLResponse UpdateWebACL(UpdateWebACLRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>WebACL</a>.
        /// </para>
        ///  
        /// <para>
        ///  A Web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has an action defined (allow, block, or count) for requests that match the
        /// statement of the rule. In the Web ACL, you assign a default action to take (allow,
        /// block) for any request that does not match any of the rules. The rules in a Web ACL
        /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
        /// group. You can associate a Web ACL with one or more AWS resources to protect. The
        /// resources can be Amazon CloudFront, an Amazon API Gateway REST API, an Application
        /// Load Balancer, or an AWS AppSync GraphQL API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        Task<UpdateWebACLResponse> UpdateWebACLAsync(UpdateWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}