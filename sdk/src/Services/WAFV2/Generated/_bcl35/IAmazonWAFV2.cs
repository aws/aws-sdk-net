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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WAFV2.Model;

namespace Amazon.WAFV2
{
    /// <summary>
    /// Interface for accessing WAFV2
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
    /// that are forwarded to Amazon CloudFront, an Amazon API Gateway REST API, an Application
    /// Load Balancer, an AppSync GraphQL API, or an Amazon Cognito user pool. WAF also lets
    /// you control access to your content. Based on conditions that you specify, such as
    /// the IP addresses that requests originate from or the values of query strings, the
    /// Amazon API Gateway REST API, CloudFront distribution, the Application Load Balancer,
    /// the AppSync GraphQL API, or the Amazon Cognito user pool responds to requests either
    /// with the requested content or with an HTTP 403 status code (Forbidden). You also can
    /// configure CloudFront to return a custom error page when a request is blocked.
    /// </para>
    ///  
    /// <para>
    /// This API guide is for developers who need detailed information about WAF API actions,
    /// data types, and errors. For detailed information about WAF features and an overview
    /// of how to use WAF, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/what-is-aws-waf.html">WAF
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
    /// API, an AppSync GraphQL API, or an Amazon Cognito user pool. 
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
    /// the scope, you specify a <code>Scope</code> parameter and set it to <code>CLOUDFRONT</code>
    /// or <code>REGIONAL</code>. 
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
        /// REST API, an AppSync GraphQL API, or an Amazon Cognito user pool. 
        /// 
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To associate a web ACL, in the CloudFront call <code>UpdateDistribution</code>,
        /// set the web ACL ID to the Amazon Resource Name (ARN) of the web ACL. For information,
        /// see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
        /// </para>
        ///  
        /// <para>
        /// When you make changes to web ACLs or web ACL components, like rules and rule groups,
        /// WAF propagates the changes everywhere that the web ACL and its components are stored
        /// and used. Your changes are applied within seconds, but there might be a brief period
        /// of inconsistency when the changes have arrived in some places and not in others. So,
        /// for example, if you change a rule action setting, the action might be the old action
        /// in one area and the new action in another area. Or if you add an IP address to an
        /// IP set used in a blocking rule, the new address might briefly be blocked in one area
        /// while still allowed in another. This temporary inconsistency can occur when you first
        /// associate a web ACL with an Amazon Web Services resource and when you change a web
        /// ACL that is already associated with a resource. Generally, any inconsistencies of
        /// this type last only a few seconds.
        /// </para>
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the AssociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        IAsyncResult BeginAssociateWebACL(AssociateWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWebACL.</param>
        /// 
        /// <returns>Returns a  AssociateWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        AssociateWebACLResponse EndAssociateWebACL(IAsyncResult asyncResult);

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
        /// when they use a rule group. The WCU limit for web ACLs is 1,500. 
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// the maximum number of <code>WebACL</code> objects that you can create for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
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
        /// Initiates the asynchronous execution of the CheckCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckCapacity operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckCapacity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CheckCapacity">REST API Reference for CheckCapacity Operation</seealso>
        IAsyncResult BeginCheckCapacity(CheckCapacityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckCapacity.</param>
        /// 
        /// <returns>Returns a  CheckCapacityResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CheckCapacity">REST API Reference for CheckCapacity Operation</seealso>
        CheckCapacityResponse EndCheckCapacity(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// the maximum number of <code>WebACL</code> objects that you can create for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
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
        /// Initiates the asynchronous execution of the CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        IAsyncResult BeginCreateIPSet(CreateIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIPSet.</param>
        /// 
        /// <returns>Returns a  CreateIPSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        CreateIPSetResponse EndCreateIPSet(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// the maximum number of <code>WebACL</code> objects that you can create for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
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
        /// Initiates the asynchronous execution of the CreateRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRegexPatternSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        IAsyncResult BeginCreateRegexPatternSet(CreateRegexPatternSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRegexPatternSet.</param>
        /// 
        /// <returns>Returns a  CreateRegexPatternSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        CreateRegexPatternSetResponse EndCreateRegexPatternSet(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// the maximum number of <code>WebACL</code> objects that you can create for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
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
        /// Initiates the asynchronous execution of the CreateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        IAsyncResult BeginCreateRuleGroup(CreateRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRuleGroup.</param>
        /// 
        /// <returns>Returns a  CreateRuleGroupResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        CreateRuleGroupResponse EndCreateRuleGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWebACL


        /// <summary>
        /// Creates a <a>WebACL</a> per the specifications provided.
        /// 
        ///  
        /// <para>
        ///  A web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has an action defined (allow, block, or count) for requests that match the
        /// statement of the rule. In the web ACL, you assign a default action to take (allow,
        /// block) for any request that does not match any of the rules. The rules in a web ACL
        /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
        /// group. You can associate a web ACL with one or more Amazon Web Services resources
        /// to protect. The resources can be an Amazon CloudFront distribution, an Amazon API
        /// Gateway REST API, an Application Load Balancer, an AppSync GraphQL API, or an Amazon
        /// Cognito user pool. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <code>OversizeHandling</code> configuration or they must
        /// be preceded by a <code>SizeConstraintStatement</code> that blocks the body content
        /// from being too large. Rules that inspect the headers or cookies must provide an <code>OversizeHandling</code>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <code>Tag</code> (key:<code>WAF:OversizeFieldsHandlingConstraintOptOut</code>,
        /// value:<code>true</code>).
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// the maximum number of <code>WebACL</code> objects that you can create for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
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
        /// Initiates the asynchronous execution of the CreateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        IAsyncResult BeginCreateWebACL(CreateWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWebACL.</param>
        /// 
        /// <returns>Returns a  CreateWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        CreateWebACLResponse EndCreateWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFirewallManagerRuleGroups


        /// <summary>
        /// Deletes all rule groups that are managed by Firewall Manager for the specified web
        /// ACL. 
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the DeleteFirewallManagerRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallManagerRuleGroups operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFirewallManagerRuleGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteFirewallManagerRuleGroups">REST API Reference for DeleteFirewallManagerRuleGroups Operation</seealso>
        IAsyncResult BeginDeleteFirewallManagerRuleGroups(DeleteFirewallManagerRuleGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFirewallManagerRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFirewallManagerRuleGroups.</param>
        /// 
        /// <returns>Returns a  DeleteFirewallManagerRuleGroupsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteFirewallManagerRuleGroups">REST API Reference for DeleteFirewallManagerRuleGroups Operation</seealso>
        DeleteFirewallManagerRuleGroupsResponse EndDeleteFirewallManagerRuleGroups(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        IAsyncResult BeginDeleteIPSet(DeleteIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIPSet.</param>
        /// 
        /// <returns>Returns a  DeleteIPSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        DeleteIPSetResponse EndDeleteIPSet(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the DeleteLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        IAsyncResult BeginDeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteLoggingConfigurationResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        DeleteLoggingConfigurationResponse EndDeleteLoggingConfiguration(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the DeletePermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionPolicy operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePermissionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        IAsyncResult BeginDeletePermissionPolicy(DeletePermissionPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePermissionPolicy.</param>
        /// 
        /// <returns>Returns a  DeletePermissionPolicyResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        DeletePermissionPolicyResponse EndDeletePermissionPolicy(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the DeleteRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRegexPatternSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        IAsyncResult BeginDeleteRegexPatternSet(DeleteRegexPatternSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRegexPatternSet.</param>
        /// 
        /// <returns>Returns a  DeleteRegexPatternSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        DeleteRegexPatternSetResponse EndDeleteRegexPatternSet(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the DeleteRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        IAsyncResult BeginDeleteRuleGroup(DeleteRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRuleGroup.</param>
        /// 
        /// <returns>Returns a  DeleteRuleGroupResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        DeleteRuleGroupResponse EndDeleteRuleGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWebACL


        /// <summary>
        /// Deletes the specified <a>WebACL</a>. 
        /// 
        ///  
        /// <para>
        /// You can only use this if <code>ManagedByFirewallManager</code> is false in the specified
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
        /// For Amazon CloudFront distributions, use the CloudFront call <code>ListDistributionsByWebACLId</code>.
        /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDistributionsByWebACLId.html">ListDistributionsByWebACLId</a>.
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
        /// call <code>UpdateDistribution</code>. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the DeleteWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        IAsyncResult BeginDeleteWebACL(DeleteWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWebACL.</param>
        /// 
        /// <returns>Returns a  DeleteWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        DeleteWebACLResponse EndDeleteWebACL(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the DescribeManagedRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedRuleGroup operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeManagedRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedRuleGroup">REST API Reference for DescribeManagedRuleGroup Operation</seealso>
        IAsyncResult BeginDescribeManagedRuleGroup(DescribeManagedRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeManagedRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeManagedRuleGroup.</param>
        /// 
        /// <returns>Returns a  DescribeManagedRuleGroupResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedRuleGroup">REST API Reference for DescribeManagedRuleGroup Operation</seealso>
        DescribeManagedRuleGroupResponse EndDescribeManagedRuleGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateWebACL


        /// <summary>
        /// Disassociates the specified regional application resource from any existing web ACL
        /// association. A resource can have at most one web ACL association. A regional application
        /// can be an Application Load Balancer (ALB), an Amazon API Gateway REST API, an AppSync
        /// GraphQL API, or an Amazon Cognito user pool. 
        /// 
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To disassociate a web ACL, provide an empty web ACL ID in the CloudFront
        /// call <code>UpdateDistribution</code>. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the DisassociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        IAsyncResult BeginDisassociateWebACL(DisassociateWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWebACL.</param>
        /// 
        /// <returns>Returns a  DisassociateWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        DisassociateWebACLResponse EndDisassociateWebACL(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the GenerateMobileSdkReleaseUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateMobileSdkReleaseUrl operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateMobileSdkReleaseUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GenerateMobileSdkReleaseUrl">REST API Reference for GenerateMobileSdkReleaseUrl Operation</seealso>
        IAsyncResult BeginGenerateMobileSdkReleaseUrl(GenerateMobileSdkReleaseUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateMobileSdkReleaseUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateMobileSdkReleaseUrl.</param>
        /// 
        /// <returns>Returns a  GenerateMobileSdkReleaseUrlResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GenerateMobileSdkReleaseUrl">REST API Reference for GenerateMobileSdkReleaseUrl Operation</seealso>
        GenerateMobileSdkReleaseUrlResponse EndGenerateMobileSdkReleaseUrl(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        IAsyncResult BeginGetIPSet(GetIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIPSet.</param>
        /// 
        /// <returns>Returns a  GetIPSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        GetIPSetResponse EndGetIPSet(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the GetLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        IAsyncResult BeginGetLoggingConfiguration(GetLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetLoggingConfigurationResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        GetLoggingConfigurationResponse EndGetLoggingConfiguration(IAsyncResult asyncResult);

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
        /// versioned managed rule group offerings for your customers. The APIs are <code>ListManagedRuleSets</code>,
        /// <code>GetManagedRuleSet</code>, <code>PutManagedRuleSetVersions</code>, and <code>UpdateManagedRuleSetVersionExpiryDate</code>.
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the GetManagedRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedRuleSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetManagedRuleSet">REST API Reference for GetManagedRuleSet Operation</seealso>
        IAsyncResult BeginGetManagedRuleSet(GetManagedRuleSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedRuleSet.</param>
        /// 
        /// <returns>Returns a  GetManagedRuleSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetManagedRuleSet">REST API Reference for GetManagedRuleSet Operation</seealso>
        GetManagedRuleSetResponse EndGetManagedRuleSet(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the GetMobileSdkRelease operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMobileSdkRelease operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMobileSdkRelease
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetMobileSdkRelease">REST API Reference for GetMobileSdkRelease Operation</seealso>
        IAsyncResult BeginGetMobileSdkRelease(GetMobileSdkReleaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMobileSdkRelease operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMobileSdkRelease.</param>
        /// 
        /// <returns>Returns a  GetMobileSdkReleaseResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetMobileSdkRelease">REST API Reference for GetMobileSdkRelease Operation</seealso>
        GetMobileSdkReleaseResponse EndGetMobileSdkRelease(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the GetPermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionPolicy operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPermissionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        IAsyncResult BeginGetPermissionPolicy(GetPermissionPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPermissionPolicy.</param>
        /// 
        /// <returns>Returns a  GetPermissionPolicyResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        GetPermissionPolicyResponse EndGetPermissionPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRateBasedStatementManagedKeys


        /// <summary>
        /// Retrieves the keys that are currently blocked by a rate-based rule instance. The maximum
        /// number of managed keys that can be blocked for a single rate-based rule instance is
        /// 10,000. If more than 10,000 addresses exceed the rate limit, those with the highest
        /// rates are blocked.
        /// 
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        GetRateBasedStatementManagedKeysResponse GetRateBasedStatementManagedKeys(GetRateBasedStatementManagedKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRateBasedStatementManagedKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedStatementManagedKeys operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRateBasedStatementManagedKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        IAsyncResult BeginGetRateBasedStatementManagedKeys(GetRateBasedStatementManagedKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRateBasedStatementManagedKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRateBasedStatementManagedKeys.</param>
        /// 
        /// <returns>Returns a  GetRateBasedStatementManagedKeysResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        GetRateBasedStatementManagedKeysResponse EndGetRateBasedStatementManagedKeys(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the GetRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRegexPatternSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        IAsyncResult BeginGetRegexPatternSet(GetRegexPatternSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRegexPatternSet.</param>
        /// 
        /// <returns>Returns a  GetRegexPatternSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        GetRegexPatternSetResponse EndGetRegexPatternSet(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the GetRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        IAsyncResult BeginGetRuleGroup(GetRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRuleGroup.</param>
        /// 
        /// <returns>Returns a  GetRuleGroupResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        GetRuleGroupResponse EndGetRuleGroup(IAsyncResult asyncResult);

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
        ///  <code>GetSampledRequests</code> returns a time range, which is usually the time range
        /// that you specified. However, if your resource (such as a CloudFront distribution)
        /// received 5,000 requests before the specified time range elapsed, <code>GetSampledRequests</code>
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the GetSampledRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSampledRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        IAsyncResult BeginGetSampledRequests(GetSampledRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSampledRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSampledRequests.</param>
        /// 
        /// <returns>Returns a  GetSampledRequestsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        GetSampledRequestsResponse EndGetSampledRequests(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the GetWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        IAsyncResult BeginGetWebACL(GetWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWebACL.</param>
        /// 
        /// <returns>Returns a  GetWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        GetWebACLResponse EndGetWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWebACLForResource


        /// <summary>
        /// Retrieves the <a>WebACL</a> for the specified resource.
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the GetWebACLForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWebACLForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        IAsyncResult BeginGetWebACLForResource(GetWebACLForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWebACLForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWebACLForResource.</param>
        /// 
        /// <returns>Returns a  GetWebACLForResourceResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        GetWebACLForResourceResponse EndGetWebACLForResource(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the ListAvailableManagedRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroups operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableManagedRuleGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroups">REST API Reference for ListAvailableManagedRuleGroups Operation</seealso>
        IAsyncResult BeginListAvailableManagedRuleGroups(ListAvailableManagedRuleGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableManagedRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableManagedRuleGroups.</param>
        /// 
        /// <returns>Returns a  ListAvailableManagedRuleGroupsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroups">REST API Reference for ListAvailableManagedRuleGroups Operation</seealso>
        ListAvailableManagedRuleGroupsResponse EndListAvailableManagedRuleGroups(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the ListAvailableManagedRuleGroupVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroupVersions operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableManagedRuleGroupVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroupVersions">REST API Reference for ListAvailableManagedRuleGroupVersions Operation</seealso>
        IAsyncResult BeginListAvailableManagedRuleGroupVersions(ListAvailableManagedRuleGroupVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableManagedRuleGroupVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableManagedRuleGroupVersions.</param>
        /// 
        /// <returns>Returns a  ListAvailableManagedRuleGroupVersionsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroupVersions">REST API Reference for ListAvailableManagedRuleGroupVersions Operation</seealso>
        ListAvailableManagedRuleGroupVersionsResponse EndListAvailableManagedRuleGroupVersions(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIPSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        IAsyncResult BeginListIPSets(ListIPSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIPSets.</param>
        /// 
        /// <returns>Returns a  ListIPSetsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        ListIPSetsResponse EndListIPSets(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the ListLoggingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLoggingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        IAsyncResult BeginListLoggingConfigurations(ListLoggingConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLoggingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLoggingConfigurations.</param>
        /// 
        /// <returns>Returns a  ListLoggingConfigurationsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        ListLoggingConfigurationsResponse EndListLoggingConfigurations(IAsyncResult asyncResult);

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
        /// versioned managed rule group offerings for your customers. The APIs are <code>ListManagedRuleSets</code>,
        /// <code>GetManagedRuleSet</code>, <code>PutManagedRuleSetVersions</code>, and <code>UpdateManagedRuleSetVersionExpiryDate</code>.
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the ListManagedRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedRuleSets operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedRuleSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListManagedRuleSets">REST API Reference for ListManagedRuleSets Operation</seealso>
        IAsyncResult BeginListManagedRuleSets(ListManagedRuleSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedRuleSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedRuleSets.</param>
        /// 
        /// <returns>Returns a  ListManagedRuleSetsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListManagedRuleSets">REST API Reference for ListManagedRuleSets Operation</seealso>
        ListManagedRuleSetsResponse EndListManagedRuleSets(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the ListMobileSdkReleases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMobileSdkReleases operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMobileSdkReleases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListMobileSdkReleases">REST API Reference for ListMobileSdkReleases Operation</seealso>
        IAsyncResult BeginListMobileSdkReleases(ListMobileSdkReleasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMobileSdkReleases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMobileSdkReleases.</param>
        /// 
        /// <returns>Returns a  ListMobileSdkReleasesResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListMobileSdkReleases">REST API Reference for ListMobileSdkReleases Operation</seealso>
        ListMobileSdkReleasesResponse EndListMobileSdkReleases(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the ListRegexPatternSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRegexPatternSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        IAsyncResult BeginListRegexPatternSets(ListRegexPatternSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRegexPatternSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRegexPatternSets.</param>
        /// 
        /// <returns>Returns a  ListRegexPatternSetsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        ListRegexPatternSetsResponse EndListRegexPatternSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourcesForWebACL


        /// <summary>
        /// Retrieves an array of the Amazon Resource Names (ARNs) for the regional resources
        /// that are associated with the specified web ACL. If you want the list of Amazon CloudFront
        /// resources, use the CloudFront call <code>ListDistributionsByWebACLId</code>.
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the ListResourcesForWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourcesForWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        IAsyncResult BeginListResourcesForWebACL(ListResourcesForWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourcesForWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourcesForWebACL.</param>
        /// 
        /// <returns>Returns a  ListResourcesForWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        ListResourcesForWebACLResponse EndListResourcesForWebACL(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the ListRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuleGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        IAsyncResult BeginListRuleGroups(ListRuleGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleGroups.</param>
        /// 
        /// <returns>Returns a  ListRuleGroupsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        ListRuleGroupsResponse EndListRuleGroups(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the ListWebACLs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWebACLs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        IAsyncResult BeginListWebACLs(ListWebACLsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWebACLs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWebACLs.</param>
        /// 
        /// <returns>Returns a  ListWebACLsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        ListWebACLsResponse EndListWebACLs(IAsyncResult asyncResult);

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
        /// The name that you give the destination must start with <code>aws-waf-logs-</code>.
        /// Depending on the type of destination, you might need to configure additional settings
        /// or permissions. 
        /// </para>
        ///  
        /// <para>
        /// For configuration requirements and pricing information for each destination type,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// web ACL traffic</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Associate your logging destination to your web ACL using a <code>PutLoggingConfiguration</code>
        /// request.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you successfully enable logging using a <code>PutLoggingConfiguration</code>
        /// request, WAF creates an additional role or policy that is required to write logs to
        /// the logging destination. For an Amazon CloudWatch Logs log group, WAF creates a resource
        /// policy on the log group. For an Amazon S3 bucket, WAF creates a bucket policy. For
        /// an Amazon Kinesis Data Firehose, WAF creates a service-linked role.
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// the maximum number of <code>WebACL</code> objects that you can create for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
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
        /// Initiates the asynchronous execution of the PutLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        IAsyncResult BeginPutLoggingConfiguration(PutLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutLoggingConfigurationResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        PutLoggingConfigurationResponse EndPutLoggingConfiguration(IAsyncResult asyncResult);

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
        /// versioned managed rule group offerings for your customers. The APIs are <code>ListManagedRuleSets</code>,
        /// <code>GetManagedRuleSet</code>, <code>PutManagedRuleSetVersions</code>, and <code>UpdateManagedRuleSetVersionExpiryDate</code>.
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the PutManagedRuleSetVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutManagedRuleSetVersions operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutManagedRuleSetVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutManagedRuleSetVersions">REST API Reference for PutManagedRuleSetVersions Operation</seealso>
        IAsyncResult BeginPutManagedRuleSetVersions(PutManagedRuleSetVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutManagedRuleSetVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutManagedRuleSetVersions.</param>
        /// 
        /// <returns>Returns a  PutManagedRuleSetVersionsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutManagedRuleSetVersions">REST API Reference for PutManagedRuleSetVersions Operation</seealso>
        PutManagedRuleSetVersionsResponse EndPutManagedRuleSetVersions(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// and <code>wafv2:PutFirewallManagerRuleGroups</code> and may optionally specify <code>wafv2:GetRuleGroup</code>.
        /// WAF rejects any extra actions or wildcard actions in the policy.
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
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        PutPermissionPolicyResponse PutPermissionPolicy(PutPermissionPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionPolicy operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPermissionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        IAsyncResult BeginPutPermissionPolicy(PutPermissionPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPermissionPolicy.</param>
        /// 
        /// <returns>Returns a  PutPermissionPolicyResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        PutPermissionPolicyResponse EndPutPermissionPolicy(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// the maximum number of <code>WebACL</code> objects that you can create for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// When you make changes to web ACLs or web ACL components, like rules and rule groups,
        /// WAF propagates the changes everywhere that the web ACL and its components are stored
        /// and used. Your changes are applied within seconds, but there might be a brief period
        /// of inconsistency when the changes have arrived in some places and not in others. So,
        /// for example, if you change a rule action setting, the action might be the old action
        /// in one area and the new action in another area. Or if you add an IP address to an
        /// IP set used in a blocking rule, the new address might briefly be blocked in one area
        /// while still allowed in another. This temporary inconsistency can occur when you first
        /// associate a web ACL with an Amazon Web Services resource and when you change a web
        /// ACL that is already associated with a resource. Generally, any inconsistencies of
        /// this type last only a few seconds.
        /// </para>
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// the maximum number of <code>WebACL</code> objects that you can create for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
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
        /// Initiates the asynchronous execution of the UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        IAsyncResult BeginUpdateIPSet(UpdateIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIPSet.</param>
        /// 
        /// <returns>Returns a  UpdateIPSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        UpdateIPSetResponse EndUpdateIPSet(IAsyncResult asyncResult);

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
        /// versioned managed rule group offerings for your customers. The APIs are <code>ListManagedRuleSets</code>,
        /// <code>GetManagedRuleSet</code>, <code>PutManagedRuleSetVersions</code>, and <code>UpdateManagedRuleSetVersionExpiryDate</code>.
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// Initiates the asynchronous execution of the UpdateManagedRuleSetVersionExpiryDate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedRuleSetVersionExpiryDate operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateManagedRuleSetVersionExpiryDate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateManagedRuleSetVersionExpiryDate">REST API Reference for UpdateManagedRuleSetVersionExpiryDate Operation</seealso>
        IAsyncResult BeginUpdateManagedRuleSetVersionExpiryDate(UpdateManagedRuleSetVersionExpiryDateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateManagedRuleSetVersionExpiryDate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateManagedRuleSetVersionExpiryDate.</param>
        /// 
        /// <returns>Returns a  UpdateManagedRuleSetVersionExpiryDateResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateManagedRuleSetVersionExpiryDate">REST API Reference for UpdateManagedRuleSetVersionExpiryDate Operation</seealso>
        UpdateManagedRuleSetVersionExpiryDateResponse EndUpdateManagedRuleSetVersionExpiryDate(IAsyncResult asyncResult);

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
        /// When you make changes to web ACLs or web ACL components, like rules and rule groups,
        /// WAF propagates the changes everywhere that the web ACL and its components are stored
        /// and used. Your changes are applied within seconds, but there might be a brief period
        /// of inconsistency when the changes have arrived in some places and not in others. So,
        /// for example, if you change a rule action setting, the action might be the old action
        /// in one area and the new action in another area. Or if you add an IP address to an
        /// IP set used in a blocking rule, the new address might briefly be blocked in one area
        /// while still allowed in another. This temporary inconsistency can occur when you first
        /// associate a web ACL with an Amazon Web Services resource and when you change a web
        /// ACL that is already associated with a resource. Generally, any inconsistencies of
        /// this type last only a few seconds.
        /// </para>
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// the maximum number of <code>WebACL</code> objects that you can create for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
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
        /// Initiates the asynchronous execution of the UpdateRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRegexPatternSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        IAsyncResult BeginUpdateRegexPatternSet(UpdateRegexPatternSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRegexPatternSet.</param>
        /// 
        /// <returns>Returns a  UpdateRegexPatternSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        UpdateRegexPatternSetResponse EndUpdateRegexPatternSet(IAsyncResult asyncResult);

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
        /// When you make changes to web ACLs or web ACL components, like rules and rule groups,
        /// WAF propagates the changes everywhere that the web ACL and its components are stored
        /// and used. Your changes are applied within seconds, but there might be a brief period
        /// of inconsistency when the changes have arrived in some places and not in others. So,
        /// for example, if you change a rule action setting, the action might be the old action
        /// in one area and the new action in another area. Or if you add an IP address to an
        /// IP set used in a blocking rule, the new address might briefly be blocked in one area
        /// while still allowed in another. This temporary inconsistency can occur when you first
        /// associate a web ACL with an Amazon Web Services resource and when you change a web
        /// ACL that is already associated with a resource. Generally, any inconsistencies of
        /// this type last only a few seconds.
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
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <code>OversizeHandling</code> configuration or they must
        /// be preceded by a <code>SizeConstraintStatement</code> that blocks the body content
        /// from being too large. Rules that inspect the headers or cookies must provide an <code>OversizeHandling</code>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <code>Tag</code> (key:<code>WAF:OversizeFieldsHandlingConstraintOptOut</code>,
        /// value:<code>true</code>).
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// the maximum number of <code>WebACL</code> objects that you can create for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
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
        /// Initiates the asynchronous execution of the UpdateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        IAsyncResult BeginUpdateRuleGroup(UpdateRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleGroup.</param>
        /// 
        /// <returns>Returns a  UpdateRuleGroupResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        UpdateRuleGroupResponse EndUpdateRuleGroup(IAsyncResult asyncResult);

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
        /// When you make changes to web ACLs or web ACL components, like rules and rule groups,
        /// WAF propagates the changes everywhere that the web ACL and its components are stored
        /// and used. Your changes are applied within seconds, but there might be a brief period
        /// of inconsistency when the changes have arrived in some places and not in others. So,
        /// for example, if you change a rule action setting, the action might be the old action
        /// in one area and the new action in another area. Or if you add an IP address to an
        /// IP set used in a blocking rule, the new address might briefly be blocked in one area
        /// while still allowed in another. This temporary inconsistency can occur when you first
        /// associate a web ACL with an Amazon Web Services resource and when you change a web
        /// ACL that is already associated with a resource. Generally, any inconsistencies of
        /// this type last only a few seconds.
        /// </para>
        ///  
        /// <para>
        ///  A web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has an action defined (allow, block, or count) for requests that match the
        /// statement of the rule. In the web ACL, you assign a default action to take (allow,
        /// block) for any request that does not match any of the rules. The rules in a web ACL
        /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
        /// group. You can associate a web ACL with one or more Amazon Web Services resources
        /// to protect. The resources can be an Amazon CloudFront distribution, an Amazon API
        /// Gateway REST API, an Application Load Balancer, an AppSync GraphQL API, or an Amazon
        /// Cognito user pool. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <code>OversizeHandling</code> configuration or they must
        /// be preceded by a <code>SizeConstraintStatement</code> that blocks the body content
        /// from being too large. Rules that inspect the headers or cookies must provide an <code>OversizeHandling</code>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <code>Tag</code> (key:<code>WAF:OversizeFieldsHandlingConstraintOptOut</code>,
        /// value:<code>true</code>).
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
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
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
        /// the maximum number of <code>WebACL</code> objects that you can create for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
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
        /// Initiates the asynchronous execution of the UpdateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        IAsyncResult BeginUpdateWebACL(UpdateWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWebACL.</param>
        /// 
        /// <returns>Returns a  UpdateWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        UpdateWebACLResponse EndUpdateWebACL(IAsyncResult asyncResult);

        #endregion
        
    }
}