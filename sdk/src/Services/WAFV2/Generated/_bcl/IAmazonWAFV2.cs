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

#pragma warning disable CS1570
namespace Amazon.WAFV2
{
    /// <summary>
    /// <para>Interface for accessing WAFV2</para>
    ///
    /// WAF <note> 
    /// <para>
    /// This is the latest version of the <b>WAF</b> API, released in November, 2019. The
    /// names of the entities that you use to access this API, like endpoints and namespaces,
    /// all have the versioning information added, like "V2" or "v2", to distinguish from
    /// the prior version. We recommend migrating your resources to this version, because
    /// it has a number of significant improvements.
    /// </para>
    ///  
    /// <para>
    /// If you used WAF prior to this release, you can't use this WAFV2 API to access any
    /// WAF resources that you created before. You can access your old rules, web ACLs, and
    /// other WAF resources only through the WAF Classic APIs. The WAF Classic APIs have retained
    /// the prior names, endpoints, and namespaces. 
    /// </para>
    ///  
    /// <para>
    /// For information, including how to migrate your WAF resources to this version, see
    /// the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
    /// Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// WAF is a web application firewall that lets you monitor the HTTP and HTTPS requests
    /// that are forwarded to an Amazon CloudFront distribution, Amazon API Gateway REST API,
    /// Application Load Balancer, AppSync GraphQL API, Amazon Cognito user pool, App Runner
    /// service, or Amazon Web Services Verified Access instance. WAF also lets you control
    /// access to your content, to protect the Amazon Web Services resource that WAF is monitoring.
    /// Based on conditions that you specify, such as the IP addresses that requests originate
    /// from or the values of query strings, the protected resource responds to requests with
    /// either the requested content, an HTTP 403 status code (Forbidden), or with a custom
    /// response. 
    /// </para>
    ///  
    /// <para>
    /// This API guide is for developers who need detailed information about WAF API actions,
    /// data types, and errors. For detailed information about WAF features and guidance for
    /// configuring and using WAF, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/what-is-aws-waf.html">WAF
    /// Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can make calls using the endpoints listed in <a href="https://docs.aws.amazon.com/general/latest/gr/waf.html">WAF
    /// endpoints and quotas</a>. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For regional applications, you can use any of the endpoints in the list. A regional
    /// application can be an Application Load Balancer (ALB), an Amazon API Gateway REST
    /// API, an AppSync GraphQL API, an Amazon Cognito user pool, an App Runner service, or
    /// an Amazon Web Services Verified Access instance. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For Amazon CloudFront applications, you must use the API endpoint listed for US East
    /// (N. Virginia): us-east-1.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Alternatively, you can use one of the Amazon Web Services SDKs to access an API that's
    /// tailored to the programming language or platform that you're using. For more information,
    /// see <a href="http://aws.amazon.com/tools/#SDKs">Amazon Web Services SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// We currently provide two versions of the WAF API: this API and the prior versions,
    /// the classic WAF APIs. This new API provides the same functionality as the older versions,
    /// with the following major improvements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You use one API for both global and regional applications. Where you need to distinguish
    /// the scope, you specify a <c>Scope</c> parameter and set it to <c>CLOUDFRONT</c> or
    /// <c>REGIONAL</c>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can define a web ACL or rule group with a single call, and update it with a single
    /// call. You define all rule specifications in JSON format, and pass them to your rule
    /// group or web ACL calls.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The limits WAF places on the use of rules more closely reflects the cost of running
    /// each type of rule. Rule groups include capacity settings, so you know the maximum
    /// cost of a rule group when you use it.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonWAFV2 : IAmazonService, IDisposable
    {


        
        #region  AssociateWebACL


        /// <summary>
        /// Associates a web ACL with a regional application resource, to protect the resource.
        /// A regional application can be an Application Load Balancer (ALB), an Amazon API Gateway
        /// REST API, an AppSync GraphQL API, an Amazon Cognito user pool, an App Runner service,
        /// or an Amazon Web Services Verified Access instance. 
        /// 
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To associate a web ACL, in the CloudFront call <c>UpdateDistribution</c>,
        /// set the web ACL ID to the Amazon Resource Name (ARN) of the web ACL. For information,
        /// see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-AssociateWebACL">Permissions
        /// for AssociateWebACL</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL service method.</param>
        /// 
        /// <returns>The response from the AssociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        AssociateWebACLResponse AssociateWebACL(AssociateWebACLRequest request);



        /// <summary>
        /// Associates a web ACL with a regional application resource, to protect the resource.
        /// A regional application can be an Application Load Balancer (ALB), an Amazon API Gateway
        /// REST API, an AppSync GraphQL API, an Amazon Cognito user pool, an App Runner service,
        /// or an Amazon Web Services Verified Access instance. 
        /// 
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To associate a web ACL, in the CloudFront call <c>UpdateDistribution</c>,
        /// set the web ACL ID to the Amazon Resource Name (ARN) of the web ACL. For information,
        /// see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-AssociateWebACL">Permissions
        /// for AssociateWebACL</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        Task<AssociateWebACLResponse> AssociateWebACLAsync(AssociateWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CheckCapacity


        /// <summary>
        /// Returns the web ACL capacity unit (WCU) requirements for a specified scope and set
        /// of rules. You can use this to check the capacity requirements for the rules you want
        /// to use in a <a>RuleGroup</a> or <a>WebACL</a>. 
        /// 
        ///  
        /// <para>
        /// WAF uses WCUs to calculate and control the operating resources that are used to run
        /// your rules, rule groups, and web ACLs. WAF calculates capacity differently for each
        /// rule type, to reflect the relative cost of each rule. Simple rules that cost little
        /// to run use fewer WCUs than more complex rules that use more processing power. Rule
        /// group capacity is fixed at creation, which helps users plan their web ACL WCU usage
        /// when they use a rule group. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-waf-capacity-units.html">WAF
        /// web ACL capacity units (WCU)</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckCapacity service method.</param>
        /// 
        /// <returns>The response from the CheckCapacity service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CheckCapacity">REST API Reference for CheckCapacity Operation</seealso>
        CheckCapacityResponse CheckCapacity(CheckCapacityRequest request);



        /// <summary>
        /// Returns the web ACL capacity unit (WCU) requirements for a specified scope and set
        /// of rules. You can use this to check the capacity requirements for the rules you want
        /// to use in a <a>RuleGroup</a> or <a>WebACL</a>. 
        /// 
        ///  
        /// <para>
        /// WAF uses WCUs to calculate and control the operating resources that are used to run
        /// your rules, rule groups, and web ACLs. WAF calculates capacity differently for each
        /// rule type, to reflect the relative cost of each rule. Simple rules that cost little
        /// to run use fewer WCUs than more complex rules that use more processing power. Rule
        /// group capacity is fixed at creation, which helps users plan their web ACL WCU usage
        /// when they use a rule group. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-waf-capacity-units.html">WAF
        /// web ACL capacity units (WCU)</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckCapacity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckCapacity service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CheckCapacity">REST API Reference for CheckCapacity Operation</seealso>
        Task<CheckCapacityResponse> CheckCapacityAsync(CheckCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAPIKey


        /// <summary>
        /// Creates an API key that contains a set of token domains.
        /// 
        ///  
        /// <para>
        /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
        /// applications. The API lets you customize the placement and characteristics of the
        /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
        /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use a single key for up to 5 domains. After you generate a key, you can copy
        /// it for use in your JavaScript integration. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAPIKey service method.</param>
        /// 
        /// <returns>The response from the CreateAPIKey service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateAPIKey">REST API Reference for CreateAPIKey Operation</seealso>
        CreateAPIKeyResponse CreateAPIKey(CreateAPIKeyRequest request);



        /// <summary>
        /// Creates an API key that contains a set of token domains.
        /// 
        ///  
        /// <para>
        /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
        /// applications. The API lets you customize the placement and characteristics of the
        /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
        /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use a single key for up to 5 domains. After you generate a key, you can copy
        /// it for use in your JavaScript integration. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAPIKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAPIKey service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateAPIKey">REST API Reference for CreateAPIKey Operation</seealso>
        Task<CreateAPIKeyResponse> CreateAPIKeyAsync(CreateAPIKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateIPSet


        /// <summary>
        /// Creates an <a>IPSet</a>, which you use to identify web requests that originate from
        /// specific IP addresses or ranges of IP addresses. For example, if you're receiving
        /// a lot of requests from a ranges of IP addresses, you can configure WAF to block them
        /// using an IPSet that lists those IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        CreateIPSetResponse CreateIPSet(CreateIPSetRequest request);



        /// <summary>
        /// Creates an <a>IPSet</a>, which you use to identify web requests that originate from
        /// specific IP addresses or ranges of IP addresses. For example, if you're receiving
        /// a lot of requests from a ranges of IP addresses, you can configure WAF to block them
        /// using an IPSet that lists those IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        Task<CreateIPSetResponse> CreateIPSetAsync(CreateIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRegexPatternSet


        /// <summary>
        /// Creates a <a>RegexPatternSet</a>, which you reference in a <a>RegexPatternSetReferenceStatement</a>,
        /// to have WAF inspect a web request component for the specified patterns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the CreateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        CreateRegexPatternSetResponse CreateRegexPatternSet(CreateRegexPatternSetRequest request);



        /// <summary>
        /// Creates a <a>RegexPatternSet</a>, which you reference in a <a>RegexPatternSetReferenceStatement</a>,
        /// to have WAF inspect a web request component for the specified patterns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        Task<CreateRegexPatternSetResponse> CreateRegexPatternSetAsync(CreateRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRuleGroup


        /// <summary>
        /// Creates a <a>RuleGroup</a> per the specifications provided. 
        /// 
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
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request);



        /// <summary>
        /// Creates a <a>RuleGroup</a> per the specifications provided. 
        /// 
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
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        Task<CreateRuleGroupResponse> CreateRuleGroupAsync(CreateRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWebACL


        /// <summary>
        /// Creates a <a>WebACL</a> per the specifications provided.
        /// 
        ///  
        /// <para>
        ///  A web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has a statement that defines what to look for in web requests and an action
        /// that WAF applies to requests that match the statement. In the web ACL, you assign
        /// a default action to take (allow, block) for any request that does not match any of
        /// the rules. The rules in a web ACL can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>,
        /// and managed rule group. You can associate a web ACL with one or more Amazon Web Services
        /// resources to protect. The resources can be an Amazon CloudFront distribution, an Amazon
        /// API Gateway REST API, an Application Load Balancer, an AppSync GraphQL API, an Amazon
        /// Cognito user pool, an App Runner service, or an Amazon Web Services Verified Access
        /// instance. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <c>OversizeHandling</c> configuration or they must be
        /// preceded by a <c>SizeConstraintStatement</c> that blocks the body content from being
        /// too large. Rules that inspect the headers or cookies must provide an <c>OversizeHandling</c>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <c>Tag</c> (key:<c>WAF:OversizeFieldsHandlingConstraintOptOut</c>,
        /// value:<c>true</c>).
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        CreateWebACLResponse CreateWebACL(CreateWebACLRequest request);



        /// <summary>
        /// Creates a <a>WebACL</a> per the specifications provided.
        /// 
        ///  
        /// <para>
        ///  A web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has a statement that defines what to look for in web requests and an action
        /// that WAF applies to requests that match the statement. In the web ACL, you assign
        /// a default action to take (allow, block) for any request that does not match any of
        /// the rules. The rules in a web ACL can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>,
        /// and managed rule group. You can associate a web ACL with one or more Amazon Web Services
        /// resources to protect. The resources can be an Amazon CloudFront distribution, an Amazon
        /// API Gateway REST API, an Application Load Balancer, an AppSync GraphQL API, an Amazon
        /// Cognito user pool, an App Runner service, or an Amazon Web Services Verified Access
        /// instance. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <c>OversizeHandling</c> configuration or they must be
        /// preceded by a <c>SizeConstraintStatement</c> that blocks the body content from being
        /// too large. Rules that inspect the headers or cookies must provide an <c>OversizeHandling</c>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <c>Tag</c> (key:<c>WAF:OversizeFieldsHandlingConstraintOptOut</c>,
        /// value:<c>true</c>).
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        Task<CreateWebACLResponse> CreateWebACLAsync(CreateWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAPIKey


        /// <summary>
        /// Deletes the specified API key. 
        /// 
        ///  
        /// <para>
        /// After you delete a key, it can take up to 24 hours for WAF to disallow use of the
        /// key in all regions. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAPIKey service method.</param>
        /// 
        /// <returns>The response from the DeleteAPIKey service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteAPIKey">REST API Reference for DeleteAPIKey Operation</seealso>
        DeleteAPIKeyResponse DeleteAPIKey(DeleteAPIKeyRequest request);



        /// <summary>
        /// Deletes the specified API key. 
        /// 
        ///  
        /// <para>
        /// After you delete a key, it can take up to 24 hours for WAF to disallow use of the
        /// key in all regions. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAPIKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAPIKey service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteAPIKey">REST API Reference for DeleteAPIKey Operation</seealso>
        Task<DeleteAPIKeyResponse> DeleteAPIKeyAsync(DeleteAPIKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFirewallManagerRuleGroups


        /// <summary>
        /// Deletes all rule groups that are managed by Firewall Manager for the specified web
        /// ACL. 
        /// 
        ///  
        /// <para>
        /// You can only use this if <c>ManagedByFirewallManager</c> is false in the specified
        /// <a>WebACL</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallManagerRuleGroups service method.</param>
        /// 
        /// <returns>The response from the DeleteFirewallManagerRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteFirewallManagerRuleGroups">REST API Reference for DeleteFirewallManagerRuleGroups Operation</seealso>
        DeleteFirewallManagerRuleGroupsResponse DeleteFirewallManagerRuleGroups(DeleteFirewallManagerRuleGroupsRequest request);



        /// <summary>
        /// Deletes all rule groups that are managed by Firewall Manager for the specified web
        /// ACL. 
        /// 
        ///  
        /// <para>
        /// You can only use this if <c>ManagedByFirewallManager</c> is false in the specified
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
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteFirewallManagerRuleGroups">REST API Reference for DeleteFirewallManagerRuleGroups Operation</seealso>
        Task<DeleteFirewallManagerRuleGroupsResponse> DeleteFirewallManagerRuleGroupsAsync(DeleteFirewallManagerRuleGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIPSet


        /// <summary>
        /// Deletes the specified <a>IPSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request);



        /// <summary>
        /// Deletes the specified <a>IPSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        Task<DeleteIPSetResponse> DeleteIPSetAsync(DeleteIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLoggingConfiguration


        /// <summary>
        /// Deletes the <a>LoggingConfiguration</a> from the specified web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        DeleteLoggingConfigurationResponse DeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request);



        /// <summary>
        /// Deletes the <a>LoggingConfiguration</a> from the specified web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
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
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
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
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        Task<DeletePermissionPolicyResponse> DeletePermissionPolicyAsync(DeletePermissionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRegexPatternSet


        /// <summary>
        /// Deletes the specified <a>RegexPatternSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the DeleteRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        DeleteRegexPatternSetResponse DeleteRegexPatternSet(DeleteRegexPatternSetRequest request);



        /// <summary>
        /// Deletes the specified <a>RegexPatternSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        Task<DeleteRegexPatternSetResponse> DeleteRegexPatternSetAsync(DeleteRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRuleGroup


        /// <summary>
        /// Deletes the specified <a>RuleGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request);



        /// <summary>
        /// Deletes the specified <a>RuleGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        Task<DeleteRuleGroupResponse> DeleteRuleGroupAsync(DeleteRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWebACL


        /// <summary>
        /// Deletes the specified <a>WebACL</a>. 
        /// 
        ///  
        /// <para>
        /// You can only use this if <c>ManagedByFirewallManager</c> is false in the specified
        /// <a>WebACL</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Before deleting any web ACL, first disassociate it from all resources.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve a list of the resources that are associated with a web ACL, use the following
        /// calls:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For regional resources, call <a>ListResourcesForWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon CloudFront distributions, use the CloudFront call <c>ListDistributionsByWebACLId</c>.
        /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDistributionsByWebACLId.html">ListDistributionsByWebACLId</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// To disassociate a resource from a web ACL, use the following calls:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For regional resources, call <a>DisassociateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon CloudFront distributions, provide an empty web ACL ID in the CloudFront
        /// call <c>UpdateDistribution</c>. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  </li> </ul> </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        DeleteWebACLResponse DeleteWebACL(DeleteWebACLRequest request);



        /// <summary>
        /// Deletes the specified <a>WebACL</a>. 
        /// 
        ///  
        /// <para>
        /// You can only use this if <c>ManagedByFirewallManager</c> is false in the specified
        /// <a>WebACL</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Before deleting any web ACL, first disassociate it from all resources.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve a list of the resources that are associated with a web ACL, use the following
        /// calls:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For regional resources, call <a>ListResourcesForWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon CloudFront distributions, use the CloudFront call <c>ListDistributionsByWebACLId</c>.
        /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDistributionsByWebACLId.html">ListDistributionsByWebACLId</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// To disassociate a resource from a web ACL, use the following calls:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For regional resources, call <a>DisassociateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon CloudFront distributions, provide an empty web ACL ID in the CloudFront
        /// call <c>UpdateDistribution</c>. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  </li> </ul> </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        Task<DeleteWebACLResponse> DeleteWebACLAsync(DeleteWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAllManagedProducts


        /// <summary>
        /// Provides high-level information for the Amazon Web Services Managed Rules rule groups
        /// and Amazon Web Services Marketplace managed rule groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAllManagedProducts service method.</param>
        /// 
        /// <returns>The response from the DescribeAllManagedProducts service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeAllManagedProducts">REST API Reference for DescribeAllManagedProducts Operation</seealso>
        DescribeAllManagedProductsResponse DescribeAllManagedProducts(DescribeAllManagedProductsRequest request);



        /// <summary>
        /// Provides high-level information for the Amazon Web Services Managed Rules rule groups
        /// and Amazon Web Services Marketplace managed rule groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAllManagedProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAllManagedProducts service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeAllManagedProducts">REST API Reference for DescribeAllManagedProducts Operation</seealso>
        Task<DescribeAllManagedProductsResponse> DescribeAllManagedProductsAsync(DescribeAllManagedProductsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeManagedProductsByVendor


        /// <summary>
        /// Provides high-level information for the managed rule groups owned by a specific vendor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedProductsByVendor service method.</param>
        /// 
        /// <returns>The response from the DescribeManagedProductsByVendor service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedProductsByVendor">REST API Reference for DescribeManagedProductsByVendor Operation</seealso>
        DescribeManagedProductsByVendorResponse DescribeManagedProductsByVendor(DescribeManagedProductsByVendorRequest request);



        /// <summary>
        /// Provides high-level information for the managed rule groups owned by a specific vendor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedProductsByVendor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeManagedProductsByVendor service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedProductsByVendor">REST API Reference for DescribeManagedProductsByVendor Operation</seealso>
        Task<DescribeManagedProductsByVendorResponse> DescribeManagedProductsByVendorAsync(DescribeManagedProductsByVendorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeManagedRuleGroup


        /// <summary>
        /// Provides high-level information for a managed rule group, including descriptions of
        /// the rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeManagedRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedRuleGroup">REST API Reference for DescribeManagedRuleGroup Operation</seealso>
        DescribeManagedRuleGroupResponse DescribeManagedRuleGroup(DescribeManagedRuleGroupRequest request);



        /// <summary>
        /// Provides high-level information for a managed rule group, including descriptions of
        /// the rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeManagedRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedRuleGroup">REST API Reference for DescribeManagedRuleGroup Operation</seealso>
        Task<DescribeManagedRuleGroupResponse> DescribeManagedRuleGroupAsync(DescribeManagedRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateWebACL


        /// <summary>
        /// Disassociates the specified regional application resource from any existing web ACL
        /// association. A resource can have at most one web ACL association. A regional application
        /// can be an Application Load Balancer (ALB), an Amazon API Gateway REST API, an AppSync
        /// GraphQL API, an Amazon Cognito user pool, an App Runner service, or an Amazon Web
        /// Services Verified Access instance. 
        /// 
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To disassociate a web ACL, provide an empty web ACL ID in the CloudFront
        /// call <c>UpdateDistribution</c>. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-DisassociateWebACL">Permissions
        /// for DisassociateWebACL</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL service method.</param>
        /// 
        /// <returns>The response from the DisassociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        DisassociateWebACLResponse DisassociateWebACL(DisassociateWebACLRequest request);



        /// <summary>
        /// Disassociates the specified regional application resource from any existing web ACL
        /// association. A resource can have at most one web ACL association. A regional application
        /// can be an Application Load Balancer (ALB), an Amazon API Gateway REST API, an AppSync
        /// GraphQL API, an Amazon Cognito user pool, an App Runner service, or an Amazon Web
        /// Services Verified Access instance. 
        /// 
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To disassociate a web ACL, provide an empty web ACL ID in the CloudFront
        /// call <c>UpdateDistribution</c>. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-DisassociateWebACL">Permissions
        /// for DisassociateWebACL</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        Task<DisassociateWebACLResponse> DisassociateWebACLAsync(DisassociateWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateMobileSdkReleaseUrl


        /// <summary>
        /// Generates a presigned download URL for the specified release of the mobile SDK.
        /// 
        ///  
        /// <para>
        /// The mobile SDK is not generally available. Customers who have access to the mobile
        /// SDK can use it to establish and manage WAF tokens for use in HTTP(S) requests from
        /// a mobile device to WAF. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMobileSdkReleaseUrl service method.</param>
        /// 
        /// <returns>The response from the GenerateMobileSdkReleaseUrl service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GenerateMobileSdkReleaseUrl">REST API Reference for GenerateMobileSdkReleaseUrl Operation</seealso>
        GenerateMobileSdkReleaseUrlResponse GenerateMobileSdkReleaseUrl(GenerateMobileSdkReleaseUrlRequest request);



        /// <summary>
        /// Generates a presigned download URL for the specified release of the mobile SDK.
        /// 
        ///  
        /// <para>
        /// The mobile SDK is not generally available. Customers who have access to the mobile
        /// SDK can use it to establish and manage WAF tokens for use in HTTP(S) requests from
        /// a mobile device to WAF. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMobileSdkReleaseUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateMobileSdkReleaseUrl service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GenerateMobileSdkReleaseUrl">REST API Reference for GenerateMobileSdkReleaseUrl Operation</seealso>
        Task<GenerateMobileSdkReleaseUrlResponse> GenerateMobileSdkReleaseUrlAsync(GenerateMobileSdkReleaseUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDecryptedAPIKey


        /// <summary>
        /// Returns your API key in decrypted form. Use this to check the token domains that you
        /// have defined for the key. 
        /// 
        ///  
        /// <para>
        /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
        /// applications. The API lets you customize the placement and characteristics of the
        /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
        /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDecryptedAPIKey service method.</param>
        /// 
        /// <returns>The response from the GetDecryptedAPIKey service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetDecryptedAPIKey">REST API Reference for GetDecryptedAPIKey Operation</seealso>
        GetDecryptedAPIKeyResponse GetDecryptedAPIKey(GetDecryptedAPIKeyRequest request);



        /// <summary>
        /// Returns your API key in decrypted form. Use this to check the token domains that you
        /// have defined for the key. 
        /// 
        ///  
        /// <para>
        /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
        /// applications. The API lets you customize the placement and characteristics of the
        /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
        /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDecryptedAPIKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDecryptedAPIKey service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetDecryptedAPIKey">REST API Reference for GetDecryptedAPIKey Operation</seealso>
        Task<GetDecryptedAPIKeyResponse> GetDecryptedAPIKeyAsync(GetDecryptedAPIKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIPSet


        /// <summary>
        /// Retrieves the specified <a>IPSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        GetIPSetResponse GetIPSet(GetIPSetRequest request);



        /// <summary>
        /// Retrieves the specified <a>IPSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        Task<GetIPSetResponse> GetIPSetAsync(GetIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLoggingConfiguration


        /// <summary>
        /// Returns the <a>LoggingConfiguration</a> for the specified web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        GetLoggingConfigurationResponse GetLoggingConfiguration(GetLoggingConfigurationRequest request);



        /// <summary>
        /// Returns the <a>LoggingConfiguration</a> for the specified web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        Task<GetLoggingConfigurationResponse> GetLoggingConfigurationAsync(GetLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetManagedRuleSet


        /// <summary>
        /// Retrieves the specified managed rule set. 
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedRuleSet service method.</param>
        /// 
        /// <returns>The response from the GetManagedRuleSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetManagedRuleSet">REST API Reference for GetManagedRuleSet Operation</seealso>
        GetManagedRuleSetResponse GetManagedRuleSet(GetManagedRuleSetRequest request);



        /// <summary>
        /// Retrieves the specified managed rule set. 
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedRuleSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetManagedRuleSet">REST API Reference for GetManagedRuleSet Operation</seealso>
        Task<GetManagedRuleSetResponse> GetManagedRuleSetAsync(GetManagedRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMobileSdkRelease


        /// <summary>
        /// Retrieves information for the specified mobile SDK release, including release notes
        /// and tags.
        /// 
        ///  
        /// <para>
        /// The mobile SDK is not generally available. Customers who have access to the mobile
        /// SDK can use it to establish and manage WAF tokens for use in HTTP(S) requests from
        /// a mobile device to WAF. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMobileSdkRelease service method.</param>
        /// 
        /// <returns>The response from the GetMobileSdkRelease service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetMobileSdkRelease">REST API Reference for GetMobileSdkRelease Operation</seealso>
        GetMobileSdkReleaseResponse GetMobileSdkRelease(GetMobileSdkReleaseRequest request);



        /// <summary>
        /// Retrieves information for the specified mobile SDK release, including release notes
        /// and tags.
        /// 
        ///  
        /// <para>
        /// The mobile SDK is not generally available. Customers who have access to the mobile
        /// SDK can use it to establish and manage WAF tokens for use in HTTP(S) requests from
        /// a mobile device to WAF. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMobileSdkRelease service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMobileSdkRelease service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetMobileSdkRelease">REST API Reference for GetMobileSdkRelease Operation</seealso>
        Task<GetMobileSdkReleaseResponse> GetMobileSdkReleaseAsync(GetMobileSdkReleaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
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
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        Task<GetPermissionPolicyResponse> GetPermissionPolicyAsync(GetPermissionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRateBasedStatementManagedKeys


        /// <summary>
        /// Retrieves the IP addresses that are currently blocked by a rate-based rule instance.
        /// This is only available for rate-based rules that aggregate solely on the IP address
        /// or on the forwarded IP address. 
        /// 
        ///  
        /// <para>
        /// The maximum number of addresses that can be blocked for a single rate-based rule instance
        /// is 10,000. If more than 10,000 addresses exceed the rate limit, those with the highest
        /// rates are blocked.
        /// </para>
        ///  
        /// <para>
        /// For a rate-based rule that you've defined inside a rule group, provide the name of
        /// the rule group reference statement in your request, in addition to the rate-based
        /// rule name and the web ACL name. 
        /// </para>
        ///  
        /// <para>
        /// WAF monitors web requests and manages keys independently for each unique combination
        /// of web ACL, optional rule group, and rate-based rule. For example, if you define a
        /// rate-based rule inside a rule group, and then use the rule group in a web ACL, WAF
        /// monitors web requests and manages keys for that web ACL, rule group reference statement,
        /// and rate-based rule instance. If you use the same rule group in a second web ACL,
        /// WAF monitors web requests and manages keys for this second usage completely independent
        /// of your first. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedStatementManagedKeys service method.</param>
        /// 
        /// <returns>The response from the GetRateBasedStatementManagedKeys service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnsupportedAggregateKeyTypeException">
        /// The rule that you've named doesn't aggregate solely on the IP address or solely on
        /// the forwarded IP address. This call is only available for rate-based rules with an
        /// <c>AggregateKeyType</c> setting of <c>IP</c> or <c>FORWARDED_IP</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        GetRateBasedStatementManagedKeysResponse GetRateBasedStatementManagedKeys(GetRateBasedStatementManagedKeysRequest request);



        /// <summary>
        /// Retrieves the IP addresses that are currently blocked by a rate-based rule instance.
        /// This is only available for rate-based rules that aggregate solely on the IP address
        /// or on the forwarded IP address. 
        /// 
        ///  
        /// <para>
        /// The maximum number of addresses that can be blocked for a single rate-based rule instance
        /// is 10,000. If more than 10,000 addresses exceed the rate limit, those with the highest
        /// rates are blocked.
        /// </para>
        ///  
        /// <para>
        /// For a rate-based rule that you've defined inside a rule group, provide the name of
        /// the rule group reference statement in your request, in addition to the rate-based
        /// rule name and the web ACL name. 
        /// </para>
        ///  
        /// <para>
        /// WAF monitors web requests and manages keys independently for each unique combination
        /// of web ACL, optional rule group, and rate-based rule. For example, if you define a
        /// rate-based rule inside a rule group, and then use the rule group in a web ACL, WAF
        /// monitors web requests and manages keys for that web ACL, rule group reference statement,
        /// and rate-based rule instance. If you use the same rule group in a second web ACL,
        /// WAF monitors web requests and manages keys for this second usage completely independent
        /// of your first. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedStatementManagedKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRateBasedStatementManagedKeys service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnsupportedAggregateKeyTypeException">
        /// The rule that you've named doesn't aggregate solely on the IP address or solely on
        /// the forwarded IP address. This call is only available for rate-based rules with an
        /// <c>AggregateKeyType</c> setting of <c>IP</c> or <c>FORWARDED_IP</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        Task<GetRateBasedStatementManagedKeysResponse> GetRateBasedStatementManagedKeysAsync(GetRateBasedStatementManagedKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRegexPatternSet


        /// <summary>
        /// Retrieves the specified <a>RegexPatternSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the GetRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        GetRegexPatternSetResponse GetRegexPatternSet(GetRegexPatternSetRequest request);



        /// <summary>
        /// Retrieves the specified <a>RegexPatternSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        Task<GetRegexPatternSetResponse> GetRegexPatternSetAsync(GetRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRuleGroup


        /// <summary>
        /// Retrieves the specified <a>RuleGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup service method.</param>
        /// 
        /// <returns>The response from the GetRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        GetRuleGroupResponse GetRuleGroup(GetRuleGroupRequest request);



        /// <summary>
        /// Retrieves the specified <a>RuleGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        Task<GetRuleGroupResponse> GetRuleGroupAsync(GetRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSampledRequests


        /// <summary>
        /// Gets detailed information about a specified number of requests--a sample--that WAF
        /// randomly selects from among the first 5,000 requests that your Amazon Web Services
        /// resource received during a time range that you choose. You can specify a sample size
        /// of up to 500 requests, and you can specify any time range in the previous three hours.
        /// 
        ///  
        /// <para>
        ///  <c>GetSampledRequests</c> returns a time range, which is usually the time range that
        /// you specified. However, if your resource (such as a CloudFront distribution) received
        /// 5,000 requests before the specified time range elapsed, <c>GetSampledRequests</c>
        /// returns an updated time range. This new time range indicates the actual period during
        /// which WAF selected the requests in the sample.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests service method.</param>
        /// 
        /// <returns>The response from the GetSampledRequests service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        GetSampledRequestsResponse GetSampledRequests(GetSampledRequestsRequest request);



        /// <summary>
        /// Gets detailed information about a specified number of requests--a sample--that WAF
        /// randomly selects from among the first 5,000 requests that your Amazon Web Services
        /// resource received during a time range that you choose. You can specify a sample size
        /// of up to 500 requests, and you can specify any time range in the previous three hours.
        /// 
        ///  
        /// <para>
        ///  <c>GetSampledRequests</c> returns a time range, which is usually the time range that
        /// you specified. However, if your resource (such as a CloudFront distribution) received
        /// 5,000 requests before the specified time range elapsed, <c>GetSampledRequests</c>
        /// returns an updated time range. This new time range indicates the actual period during
        /// which WAF selected the requests in the sample.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSampledRequests service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        Task<GetSampledRequestsResponse> GetSampledRequestsAsync(GetSampledRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWebACL


        /// <summary>
        /// Retrieves the specified <a>WebACL</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        GetWebACLResponse GetWebACL(GetWebACLRequest request);



        /// <summary>
        /// Retrieves the specified <a>WebACL</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        Task<GetWebACLResponse> GetWebACLAsync(GetWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWebACLForResource


        /// <summary>
        /// Retrieves the <a>WebACL</a> for the specified resource. 
        /// 
        ///  
        /// <para>
        /// This call uses <c>GetWebACL</c>, to verify that your account has permission to access
        /// the retrieved web ACL. If you get an error that indicates that your account isn't
        /// authorized to perform <c>wafv2:GetWebACL</c> on the resource, that error won't be
        /// included in your CloudTrail event history. 
        /// </para>
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, call the CloudFront action <c>GetDistributionConfig</c>.
        /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_GetDistributionConfig.html">GetDistributionConfig</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-GetWebACLForResource">Permissions
        /// for GetWebACLForResource</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource service method.</param>
        /// 
        /// <returns>The response from the GetWebACLForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        GetWebACLForResourceResponse GetWebACLForResource(GetWebACLForResourceRequest request);



        /// <summary>
        /// Retrieves the <a>WebACL</a> for the specified resource. 
        /// 
        ///  
        /// <para>
        /// This call uses <c>GetWebACL</c>, to verify that your account has permission to access
        /// the retrieved web ACL. If you get an error that indicates that your account isn't
        /// authorized to perform <c>wafv2:GetWebACL</c> on the resource, that error won't be
        /// included in your CloudTrail event history. 
        /// </para>
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, call the CloudFront action <c>GetDistributionConfig</c>.
        /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_GetDistributionConfig.html">GetDistributionConfig</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-GetWebACLForResource">Permissions
        /// for GetWebACLForResource</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebACLForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        Task<GetWebACLForResourceResponse> GetWebACLForResourceAsync(GetWebACLForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAPIKeys


        /// <summary>
        /// Retrieves a list of the API keys that you've defined for the specified scope. 
        /// 
        ///  
        /// <para>
        /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
        /// applications. The API lets you customize the placement and characteristics of the
        /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
        /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAPIKeys service method.</param>
        /// 
        /// <returns>The response from the ListAPIKeys service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAPIKeys">REST API Reference for ListAPIKeys Operation</seealso>
        ListAPIKeysResponse ListAPIKeys(ListAPIKeysRequest request);



        /// <summary>
        /// Retrieves a list of the API keys that you've defined for the specified scope. 
        /// 
        ///  
        /// <para>
        /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
        /// applications. The API lets you customize the placement and characteristics of the
        /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
        /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAPIKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAPIKeys service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAPIKeys">REST API Reference for ListAPIKeys Operation</seealso>
        Task<ListAPIKeysResponse> ListAPIKeysAsync(ListAPIKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAvailableManagedRuleGroups


        /// <summary>
        /// Retrieves an array of managed rule groups that are available for you to use. This
        /// list includes all Amazon Web Services Managed Rules rule groups and all of the Amazon
        /// Web Services Marketplace managed rule groups that you're subscribed to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListAvailableManagedRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroups">REST API Reference for ListAvailableManagedRuleGroups Operation</seealso>
        ListAvailableManagedRuleGroupsResponse ListAvailableManagedRuleGroups(ListAvailableManagedRuleGroupsRequest request);



        /// <summary>
        /// Retrieves an array of managed rule groups that are available for you to use. This
        /// list includes all Amazon Web Services Managed Rules rule groups and all of the Amazon
        /// Web Services Marketplace managed rule groups that you're subscribed to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableManagedRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroups">REST API Reference for ListAvailableManagedRuleGroups Operation</seealso>
        Task<ListAvailableManagedRuleGroupsResponse> ListAvailableManagedRuleGroupsAsync(ListAvailableManagedRuleGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAvailableManagedRuleGroupVersions


        /// <summary>
        /// Returns a list of the available versions for the specified managed rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroupVersions service method.</param>
        /// 
        /// <returns>The response from the ListAvailableManagedRuleGroupVersions service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroupVersions">REST API Reference for ListAvailableManagedRuleGroupVersions Operation</seealso>
        ListAvailableManagedRuleGroupVersionsResponse ListAvailableManagedRuleGroupVersions(ListAvailableManagedRuleGroupVersionsRequest request);



        /// <summary>
        /// Returns a list of the available versions for the specified managed rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroupVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableManagedRuleGroupVersions service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroupVersions">REST API Reference for ListAvailableManagedRuleGroupVersions Operation</seealso>
        Task<ListAvailableManagedRuleGroupVersionsResponse> ListAvailableManagedRuleGroupVersionsAsync(ListAvailableManagedRuleGroupVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIPSets


        /// <summary>
        /// Retrieves an array of <a>IPSetSummary</a> objects for the IP sets that you manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        ListIPSetsResponse ListIPSets(ListIPSetsRequest request);



        /// <summary>
        /// Retrieves an array of <a>IPSetSummary</a> objects for the IP sets that you manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        Task<ListIPSetsResponse> ListIPSetsAsync(ListIPSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLoggingConfigurations


        /// <summary>
        /// Retrieves an array of your <a>LoggingConfiguration</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListLoggingConfigurations service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        ListLoggingConfigurationsResponse ListLoggingConfigurations(ListLoggingConfigurationsRequest request);



        /// <summary>
        /// Retrieves an array of your <a>LoggingConfiguration</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLoggingConfigurations service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        Task<ListLoggingConfigurationsResponse> ListLoggingConfigurationsAsync(ListLoggingConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListManagedRuleSets


        /// <summary>
        /// Retrieves the managed rule sets that you own. 
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedRuleSets service method.</param>
        /// 
        /// <returns>The response from the ListManagedRuleSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListManagedRuleSets">REST API Reference for ListManagedRuleSets Operation</seealso>
        ListManagedRuleSetsResponse ListManagedRuleSets(ListManagedRuleSetsRequest request);



        /// <summary>
        /// Retrieves the managed rule sets that you own. 
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedRuleSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedRuleSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListManagedRuleSets">REST API Reference for ListManagedRuleSets Operation</seealso>
        Task<ListManagedRuleSetsResponse> ListManagedRuleSetsAsync(ListManagedRuleSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMobileSdkReleases


        /// <summary>
        /// Retrieves a list of the available releases for the mobile SDK and the specified device
        /// platform. 
        /// 
        ///  
        /// <para>
        /// The mobile SDK is not generally available. Customers who have access to the mobile
        /// SDK can use it to establish and manage WAF tokens for use in HTTP(S) requests from
        /// a mobile device to WAF. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMobileSdkReleases service method.</param>
        /// 
        /// <returns>The response from the ListMobileSdkReleases service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListMobileSdkReleases">REST API Reference for ListMobileSdkReleases Operation</seealso>
        ListMobileSdkReleasesResponse ListMobileSdkReleases(ListMobileSdkReleasesRequest request);



        /// <summary>
        /// Retrieves a list of the available releases for the mobile SDK and the specified device
        /// platform. 
        /// 
        ///  
        /// <para>
        /// The mobile SDK is not generally available. Customers who have access to the mobile
        /// SDK can use it to establish and manage WAF tokens for use in HTTP(S) requests from
        /// a mobile device to WAF. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMobileSdkReleases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMobileSdkReleases service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListMobileSdkReleases">REST API Reference for ListMobileSdkReleases Operation</seealso>
        Task<ListMobileSdkReleasesResponse> ListMobileSdkReleasesAsync(ListMobileSdkReleasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRegexPatternSets


        /// <summary>
        /// Retrieves an array of <a>RegexPatternSetSummary</a> objects for the regex pattern
        /// sets that you manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets service method.</param>
        /// 
        /// <returns>The response from the ListRegexPatternSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        ListRegexPatternSetsResponse ListRegexPatternSets(ListRegexPatternSetsRequest request);



        /// <summary>
        /// Retrieves an array of <a>RegexPatternSetSummary</a> objects for the regex pattern
        /// sets that you manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegexPatternSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        Task<ListRegexPatternSetsResponse> ListRegexPatternSetsAsync(ListRegexPatternSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourcesForWebACL


        /// <summary>
        /// Retrieves an array of the Amazon Resource Names (ARNs) for the regional resources
        /// that are associated with the specified web ACL. 
        /// 
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, use the CloudFront call <c>ListDistributionsByWebACLId</c>.
        /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDistributionsByWebACLId.html">ListDistributionsByWebACLId</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-ListResourcesForWebACL">Permissions
        /// for ListResourcesForWebACL</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL service method.</param>
        /// 
        /// <returns>The response from the ListResourcesForWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        ListResourcesForWebACLResponse ListResourcesForWebACL(ListResourcesForWebACLRequest request);



        /// <summary>
        /// Retrieves an array of the Amazon Resource Names (ARNs) for the regional resources
        /// that are associated with the specified web ACL. 
        /// 
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, use the CloudFront call <c>ListDistributionsByWebACLId</c>.
        /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDistributionsByWebACLId.html">ListDistributionsByWebACLId</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-ListResourcesForWebACL">Permissions
        /// for ListResourcesForWebACL</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcesForWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        Task<ListResourcesForWebACLResponse> ListResourcesForWebACLAsync(ListResourcesForWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRuleGroups


        /// <summary>
        /// Retrieves an array of <a>RuleGroupSummary</a> objects for the rule groups that you
        /// manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request);



        /// <summary>
        /// Retrieves an array of <a>RuleGroupSummary</a> objects for the rule groups that you
        /// manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        Task<ListRuleGroupsResponse> ListRuleGroupsAsync(ListRuleGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves the <a>TagInfoForResource</a> for the specified resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each Amazon Web Services
        /// resource, up to 50 tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can tag the Amazon Web Services resources that you manage through WAF: web ACLs,
        /// rule groups, IP sets, and regex pattern sets. You can't manage or view tags through
        /// the WAF console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Retrieves the <a>TagInfoForResource</a> for the specified resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each Amazon Web Services
        /// resource, up to 50 tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can tag the Amazon Web Services resources that you manage through WAF: web ACLs,
        /// rule groups, IP sets, and regex pattern sets. You can't manage or view tags through
        /// the WAF console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWebACLs


        /// <summary>
        /// Retrieves an array of <a>WebACLSummary</a> objects for the web ACLs that you manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
        /// 
        /// <returns>The response from the ListWebACLs service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        ListWebACLsResponse ListWebACLs(ListWebACLsRequest request);



        /// <summary>
        /// Retrieves an array of <a>WebACLSummary</a> objects for the web ACLs that you manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebACLs service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        Task<ListWebACLsResponse> ListWebACLsAsync(ListWebACLsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLoggingConfiguration


        /// <summary>
        /// Enables the specified <a>LoggingConfiguration</a>, to start logging from a web ACL,
        /// according to the configuration provided. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces any mutable specifications that you already have
        /// for a logging configuration with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify an existing logging configuration, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetLoggingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete logging configuration specification to this call
        /// </para>
        ///  </li> </ol> </note> <note> 
        /// <para>
        /// You can define one logging destination per web ACL.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can access information about the traffic that WAF inspects using the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create your logging destination. You can use an Amazon CloudWatch Logs log group,
        /// an Amazon Simple Storage Service (Amazon S3) bucket, or an Amazon Kinesis Data Firehose.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The name that you give the destination must start with <c>aws-waf-logs-</c>. Depending
        /// on the type of destination, you might need to configure additional settings or permissions.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For configuration requirements and pricing information for each destination type,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// web ACL traffic</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Associate your logging destination to your web ACL using a <c>PutLoggingConfiguration</c>
        /// request.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you successfully enable logging using a <c>PutLoggingConfiguration</c> request,
        /// WAF creates an additional role or policy that is required to write logs to the logging
        /// destination. For an Amazon CloudWatch Logs log group, WAF creates a resource policy
        /// on the log group. For an Amazon S3 bucket, WAF creates a bucket policy. For an Amazon
        /// Kinesis Data Firehose, WAF creates a service-linked role.
        /// </para>
        ///  
        /// <para>
        /// For additional information about web ACL logging, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// web ACL traffic information</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLogDestinationPermissionIssueException">
        /// The operation failed because you don't have the permissions that your logging configuration
        /// requires. For information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// web ACL traffic information</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFServiceLinkedRoleErrorException">
        /// WAF is not able to access the service linked role. This can be caused by a previous
        /// <c>PutLoggingConfiguration</c> request, which can lock the service linked role for
        /// about 20 seconds. Please try your request again. The service linked role can also
        /// be locked by a previous <c>DeleteServiceLinkedRole</c> request, which can lock the
        /// role for 15 minutes or more. If you recently made a call to <c>DeleteServiceLinkedRole</c>,
        /// wait at least 15 minutes and try the request again. If you receive this same exception
        /// again, you will have to wait additional time until the role is unlocked.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        PutLoggingConfigurationResponse PutLoggingConfiguration(PutLoggingConfigurationRequest request);



        /// <summary>
        /// Enables the specified <a>LoggingConfiguration</a>, to start logging from a web ACL,
        /// according to the configuration provided. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces any mutable specifications that you already have
        /// for a logging configuration with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify an existing logging configuration, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetLoggingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete logging configuration specification to this call
        /// </para>
        ///  </li> </ol> </note> <note> 
        /// <para>
        /// You can define one logging destination per web ACL.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can access information about the traffic that WAF inspects using the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create your logging destination. You can use an Amazon CloudWatch Logs log group,
        /// an Amazon Simple Storage Service (Amazon S3) bucket, or an Amazon Kinesis Data Firehose.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The name that you give the destination must start with <c>aws-waf-logs-</c>. Depending
        /// on the type of destination, you might need to configure additional settings or permissions.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For configuration requirements and pricing information for each destination type,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// web ACL traffic</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Associate your logging destination to your web ACL using a <c>PutLoggingConfiguration</c>
        /// request.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you successfully enable logging using a <c>PutLoggingConfiguration</c> request,
        /// WAF creates an additional role or policy that is required to write logs to the logging
        /// destination. For an Amazon CloudWatch Logs log group, WAF creates a resource policy
        /// on the log group. For an Amazon S3 bucket, WAF creates a bucket policy. For an Amazon
        /// Kinesis Data Firehose, WAF creates a service-linked role.
        /// </para>
        ///  
        /// <para>
        /// For additional information about web ACL logging, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// web ACL traffic information</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLogDestinationPermissionIssueException">
        /// The operation failed because you don't have the permissions that your logging configuration
        /// requires. For information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// web ACL traffic information</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFServiceLinkedRoleErrorException">
        /// WAF is not able to access the service linked role. This can be caused by a previous
        /// <c>PutLoggingConfiguration</c> request, which can lock the service linked role for
        /// about 20 seconds. Please try your request again. The service linked role can also
        /// be locked by a previous <c>DeleteServiceLinkedRole</c> request, which can lock the
        /// role for 15 minutes or more. If you recently made a call to <c>DeleteServiceLinkedRole</c>,
        /// wait at least 15 minutes and try the request again. If you receive this same exception
        /// again, you will have to wait additional time until the role is unlocked.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        Task<PutLoggingConfigurationResponse> PutLoggingConfigurationAsync(PutLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutManagedRuleSetVersions


        /// <summary>
        /// Defines the versions of your managed rule set that you are offering to the customers.
        /// Customers see your offerings as managed rule groups with versioning.
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Customers retrieve their managed rule group list by calling <a>ListAvailableManagedRuleGroups</a>.
        /// The name that you provide here for your managed rule set is the name the customer
        /// sees for the corresponding managed rule group. Customers can retrieve the available
        /// versions for a managed rule group by calling <a>ListAvailableManagedRuleGroupVersions</a>.
        /// You provide a rule group specification for each version. For each managed rule set,
        /// you must specify a version that you recommend using. 
        /// </para>
        ///  
        /// <para>
        /// To initiate the expiration of a managed rule group version, use <a>UpdateManagedRuleSetVersionExpiryDate</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutManagedRuleSetVersions service method.</param>
        /// 
        /// <returns>The response from the PutManagedRuleSetVersions service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutManagedRuleSetVersions">REST API Reference for PutManagedRuleSetVersions Operation</seealso>
        PutManagedRuleSetVersionsResponse PutManagedRuleSetVersions(PutManagedRuleSetVersionsRequest request);



        /// <summary>
        /// Defines the versions of your managed rule set that you are offering to the customers.
        /// Customers see your offerings as managed rule groups with versioning.
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Customers retrieve their managed rule group list by calling <a>ListAvailableManagedRuleGroups</a>.
        /// The name that you provide here for your managed rule set is the name the customer
        /// sees for the corresponding managed rule group. Customers can retrieve the available
        /// versions for a managed rule group by calling <a>ListAvailableManagedRuleGroupVersions</a>.
        /// You provide a rule group specification for each version. For each managed rule set,
        /// you must specify a version that you recommend using. 
        /// </para>
        ///  
        /// <para>
        /// To initiate the expiration of a managed rule group version, use <a>UpdateManagedRuleSetVersionExpiryDate</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutManagedRuleSetVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutManagedRuleSetVersions service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutManagedRuleSetVersions">REST API Reference for PutManagedRuleSetVersions Operation</seealso>
        Task<PutManagedRuleSetVersionsResponse> PutManagedRuleSetVersionsAsync(PutManagedRuleSetVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You can attach only one policy with each <c>PutPermissionPolicy</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF <a>RuleGroup</a> ARN and the rule group
        /// must exist in the same Region.
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
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
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
        /// The policy must be composed using IAM Policy version 2012-10-17.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include specifications for <c>Effect</c>, <c>Action</c>, and <c>Principal</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Effect</c> must specify <c>Allow</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Action</c> must specify <c>wafv2:CreateWebACL</c>, <c>wafv2:UpdateWebACL</c>,
        /// and <c>wafv2:PutFirewallManagerRuleGroups</c> and may optionally specify <c>wafv2:GetRuleGroup</c>.
        /// WAF rejects any extra actions or wildcard actions in the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must not include a <c>Resource</c> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
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
        /// You can attach only one policy with each <c>PutPermissionPolicy</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF <a>RuleGroup</a> ARN and the rule group
        /// must exist in the same Region.
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
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
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
        /// The policy must be composed using IAM Policy version 2012-10-17.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include specifications for <c>Effect</c>, <c>Action</c>, and <c>Principal</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Effect</c> must specify <c>Allow</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Action</c> must specify <c>wafv2:CreateWebACL</c>, <c>wafv2:UpdateWebACL</c>,
        /// and <c>wafv2:PutFirewallManagerRuleGroups</c> and may optionally specify <c>wafv2:GetRuleGroup</c>.
        /// WAF rejects any extra actions or wildcard actions in the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must not include a <c>Resource</c> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        Task<PutPermissionPolicyResponse> PutPermissionPolicyAsync(PutPermissionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates tags with the specified Amazon Web Services resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each Amazon Web Services
        /// resource, up to 50 tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can tag the Amazon Web Services resources that you manage through WAF: web ACLs,
        /// rule groups, IP sets, and regex pattern sets. You can't manage or view tags through
        /// the WAF console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Associates tags with the specified Amazon Web Services resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each Amazon Web Services
        /// resource, up to 50 tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can tag the Amazon Web Services resources that you manage through WAF: web ACLs,
        /// rule groups, IP sets, and regex pattern sets. You can't manage or view tags through
        /// the WAF console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Disassociates tags from an Amazon Web Services resource. Tags are key:value pairs
        /// that you can associate with Amazon Web Services resources. For example, the tag key
        /// might be "customer" and the tag value might be "companyA." You can specify one or
        /// more tags to add to each container. You can add up to 50 tags to each Amazon Web Services
        /// resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Disassociates tags from an Amazon Web Services resource. Tags are key:value pairs
        /// that you can associate with Amazon Web Services resources. For example, the tag key
        /// might be "customer" and the tag value might be "companyA." You can specify one or
        /// more tags to add to each container. You can add up to 50 tags to each Amazon Web Services
        /// resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIPSet


        /// <summary>
        /// Updates the specified <a>IPSet</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the IP set with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify an IP set, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetIPSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete IP set specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request);



        /// <summary>
        /// Updates the specified <a>IPSet</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the IP set with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify an IP set, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetIPSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete IP set specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        Task<UpdateIPSetResponse> UpdateIPSetAsync(UpdateIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateManagedRuleSetVersionExpiryDate


        /// <summary>
        /// Updates the expiration information for your managed rule set. Use this to initiate
        /// the expiration of a managed rule group version. After you initiate expiration for
        /// a version, WAF excludes it from the response to <a>ListAvailableManagedRuleGroupVersions</a>
        /// for the managed rule group. 
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedRuleSetVersionExpiryDate service method.</param>
        /// 
        /// <returns>The response from the UpdateManagedRuleSetVersionExpiryDate service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateManagedRuleSetVersionExpiryDate">REST API Reference for UpdateManagedRuleSetVersionExpiryDate Operation</seealso>
        UpdateManagedRuleSetVersionExpiryDateResponse UpdateManagedRuleSetVersionExpiryDate(UpdateManagedRuleSetVersionExpiryDateRequest request);



        /// <summary>
        /// Updates the expiration information for your managed rule set. Use this to initiate
        /// the expiration of a managed rule group version. After you initiate expiration for
        /// a version, WAF excludes it from the response to <a>ListAvailableManagedRuleGroupVersions</a>
        /// for the managed rule group. 
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedRuleSetVersionExpiryDate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateManagedRuleSetVersionExpiryDate service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateManagedRuleSetVersionExpiryDate">REST API Reference for UpdateManagedRuleSetVersionExpiryDate Operation</seealso>
        Task<UpdateManagedRuleSetVersionExpiryDateResponse> UpdateManagedRuleSetVersionExpiryDateAsync(UpdateManagedRuleSetVersionExpiryDateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRegexPatternSet


        /// <summary>
        /// Updates the specified <a>RegexPatternSet</a>.
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the regex pattern set with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify a regex pattern set, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetRegexPatternSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete regex pattern set specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the UpdateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        UpdateRegexPatternSetResponse UpdateRegexPatternSet(UpdateRegexPatternSetRequest request);



        /// <summary>
        /// Updates the specified <a>RegexPatternSet</a>.
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the regex pattern set with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify a regex pattern set, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetRegexPatternSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete regex pattern set specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        Task<UpdateRegexPatternSetResponse> UpdateRegexPatternSetAsync(UpdateRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRuleGroup


        /// <summary>
        /// Updates the specified <a>RuleGroup</a>.
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the rule group with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify a rule group, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetRuleGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete rule group specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  A rule group defines a collection of rules to inspect and control web requests that
        /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
        /// capacity limit. If you update a rule group, you must stay within the capacity. This
        /// allows others to reuse the rule group with confidence in its capacity requirements.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <c>OversizeHandling</c> configuration or they must be
        /// preceded by a <c>SizeConstraintStatement</c> that blocks the body content from being
        /// too large. Rules that inspect the headers or cookies must provide an <c>OversizeHandling</c>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <c>Tag</c> (key:<c>WAF:OversizeFieldsHandlingConstraintOptOut</c>,
        /// value:<c>true</c>).
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        UpdateRuleGroupResponse UpdateRuleGroup(UpdateRuleGroupRequest request);



        /// <summary>
        /// Updates the specified <a>RuleGroup</a>.
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the rule group with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify a rule group, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetRuleGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete rule group specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  A rule group defines a collection of rules to inspect and control web requests that
        /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
        /// capacity limit. If you update a rule group, you must stay within the capacity. This
        /// allows others to reuse the rule group with confidence in its capacity requirements.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <c>OversizeHandling</c> configuration or they must be
        /// preceded by a <c>SizeConstraintStatement</c> that blocks the body content from being
        /// too large. Rules that inspect the headers or cookies must provide an <c>OversizeHandling</c>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <c>Tag</c> (key:<c>WAF:OversizeFieldsHandlingConstraintOptOut</c>,
        /// value:<c>true</c>).
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        Task<UpdateRuleGroupResponse> UpdateRuleGroupAsync(UpdateRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWebACL


        /// <summary>
        /// Updates the specified <a>WebACL</a>. While updating a web ACL, WAF provides continuous
        /// coverage to the resources that you have associated with the web ACL. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the web ACL with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify a web ACL, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetWebACL</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete web ACL specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  A web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has a statement that defines what to look for in web requests and an action
        /// that WAF applies to requests that match the statement. In the web ACL, you assign
        /// a default action to take (allow, block) for any request that does not match any of
        /// the rules. The rules in a web ACL can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>,
        /// and managed rule group. You can associate a web ACL with one or more Amazon Web Services
        /// resources to protect. The resources can be an Amazon CloudFront distribution, an Amazon
        /// API Gateway REST API, an Application Load Balancer, an AppSync GraphQL API, an Amazon
        /// Cognito user pool, an App Runner service, or an Amazon Web Services Verified Access
        /// instance. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <c>OversizeHandling</c> configuration or they must be
        /// preceded by a <c>SizeConstraintStatement</c> that blocks the body content from being
        /// too large. Rules that inspect the headers or cookies must provide an <c>OversizeHandling</c>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <c>Tag</c> (key:<c>WAF:OversizeFieldsHandlingConstraintOptOut</c>,
        /// value:<c>true</c>).
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        UpdateWebACLResponse UpdateWebACL(UpdateWebACLRequest request);



        /// <summary>
        /// Updates the specified <a>WebACL</a>. While updating a web ACL, WAF provides continuous
        /// coverage to the resources that you have associated with the web ACL. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the web ACL with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify a web ACL, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetWebACL</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete web ACL specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  A web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has a statement that defines what to look for in web requests and an action
        /// that WAF applies to requests that match the statement. In the web ACL, you assign
        /// a default action to take (allow, block) for any request that does not match any of
        /// the rules. The rules in a web ACL can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>,
        /// and managed rule group. You can associate a web ACL with one or more Amazon Web Services
        /// resources to protect. The resources can be an Amazon CloudFront distribution, an Amazon
        /// API Gateway REST API, an Application Load Balancer, an AppSync GraphQL API, an Amazon
        /// Cognito user pool, an App Runner service, or an Amazon Web Services Verified Access
        /// instance. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <c>OversizeHandling</c> configuration or they must be
        /// preceded by a <c>SizeConstraintStatement</c> that blocks the body content from being
        /// too large. Rules that inspect the headers or cookies must provide an <c>OversizeHandling</c>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <c>Tag</c> (key:<c>WAF:OversizeFieldsHandlingConstraintOptOut</c>,
        /// value:<c>true</c>).
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resources that you are specifying in your request parameters
        /// and then retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        Task<UpdateWebACLResponse> UpdateWebACLAsync(UpdateWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

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