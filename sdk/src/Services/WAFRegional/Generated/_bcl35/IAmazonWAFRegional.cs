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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WAFRegional.Model;

namespace Amazon.WAFRegional
{
    /// <summary>
    /// Interface for accessing WAFRegional
    ///
    /// This is the <i>AWS WAF Regional API Reference</i> for using AWS WAF with Elastic Load
    /// Balancing (ELB) Application Load Balancers. The AWS WAF actions and data types listed
    /// in the reference are available for protecting Application Load Balancers. You can
    /// use these actions and data types by means of the endpoints listed in <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#waf_region">AWS
    /// Regions and Endpoints</a>. This guide is for developers who need detailed information
    /// about the AWS WAF API actions, data types, and errors. For detailed information about
    /// AWS WAF features and an overview of how to use the AWS WAF API, see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS
    /// WAF Developer Guide</a>.
    /// </summary>
    public partial interface IAmazonWAFRegional : IAmazonService, IDisposable
    {

        
        #region  AssociateWebACL


        /// <summary>
        /// Associates a web ACL with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL service method.</param>
        /// 
        /// <returns>The response from the AssociateWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFUnavailableEntityException">
        /// The operation failed because the entity referenced is temporarily unavailable. Retry
        /// your request.
        /// </exception>
        AssociateWebACLResponse AssociateWebACL(AssociateWebACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWebACL
        ///         operation.</returns>
        IAsyncResult BeginAssociateWebACL(AssociateWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWebACL.</param>
        /// 
        /// <returns>Returns a  AssociateWebACLResult from WAFRegional.</returns>
        AssociateWebACLResponse EndAssociateWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateByteMatchSet


        /// <summary>
        /// Creates a <code>ByteMatchSet</code>. You then use <a>UpdateByteMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <code>User-Agent</code> header or the query string. For example, you can create
        /// a <code>ByteMatchSet</code> that matches any requests with <code>User-Agent</code>
        /// headers that contain the string <code>BadBot</code>. You can then configure AWS WAF
        /// to reject those requests.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateByteMatchSet</a> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
        /// you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>ByteMatchSet</a>. You can't change <code>Name</code> after you create a <code>ByteMatchSet</code>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the CreateByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        CreateByteMatchSetResponse CreateByteMatchSet(string name, string changeToken);

        /// <summary>
        /// Creates a <code>ByteMatchSet</code>. You then use <a>UpdateByteMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <code>User-Agent</code> header or the query string. For example, you can create
        /// a <code>ByteMatchSet</code> that matches any requests with <code>User-Agent</code>
        /// headers that contain the string <code>BadBot</code>. You can then configure AWS WAF
        /// to reject those requests.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateByteMatchSet</a> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
        /// you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateByteMatchSet service method.</param>
        /// 
        /// <returns>The response from the CreateByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        CreateByteMatchSetResponse CreateByteMatchSet(CreateByteMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateByteMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateByteMatchSet
        ///         operation.</returns>
        IAsyncResult BeginCreateByteMatchSet(CreateByteMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateByteMatchSet.</param>
        /// 
        /// <returns>Returns a  CreateByteMatchSetResult from WAFRegional.</returns>
        CreateByteMatchSetResponse EndCreateByteMatchSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIPSet


        /// <summary>
        /// Creates an <a>IPSet</a>, which you use to specify which web requests you want to allow
        /// or block based on the IP addresses that the requests originate from. For example,
        /// if you're receiving a lot of requests from one or more individual IP addresses or
        /// one or more ranges of IP addresses and you want to block the requests, you can create
        /// an <code>IPSet</code> that contains those IP addresses and then configure AWS WAF
        /// to block the requests. 
        /// 
        ///  
        /// <para>
        /// To create and configure an <code>IPSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateIPSet</code> request to specify the IP addresses that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>IPSet</a>. You can't change <code>Name</code> after you create the <code>IPSet</code>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        CreateIPSetResponse CreateIPSet(string name, string changeToken);

        /// <summary>
        /// Creates an <a>IPSet</a>, which you use to specify which web requests you want to allow
        /// or block based on the IP addresses that the requests originate from. For example,
        /// if you're receiving a lot of requests from one or more individual IP addresses or
        /// one or more ranges of IP addresses and you want to block the requests, you can create
        /// an <code>IPSet</code> that contains those IP addresses and then configure AWS WAF
        /// to block the requests. 
        /// 
        ///  
        /// <para>
        /// To create and configure an <code>IPSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateIPSet</code> request to specify the IP addresses that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        CreateIPSetResponse CreateIPSet(CreateIPSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIPSet
        ///         operation.</returns>
        IAsyncResult BeginCreateIPSet(CreateIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIPSet.</param>
        /// 
        /// <returns>Returns a  CreateIPSetResult from WAFRegional.</returns>
        CreateIPSetResponse EndCreateIPSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRule


        /// <summary>
        /// Creates a <code>Rule</code>, which contains the <code>IPSet</code> objects, <code>ByteMatchSet</code>
        /// objects, and other predicates that identify the requests that you want to block. If
        /// you add more than one predicate to a <code>Rule</code>, a request must match all of
        /// the specifications to be allowed or blocked. For example, suppose you add the following
        /// to a <code>Rule</code>:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44/32</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
        /// to blocks requests that satisfy the <code>Rule</code>. For a request to be blocked,
        /// it must come from the IP address 192.0.2.44 <i>and</i> the <code>User-Agent</code>
        /// header in the request must contain the value <code>BadBot</code>.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>Rule</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <code>Rule</code>.
        /// For more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRule</code> request to specify the predicates that you want
        /// to include in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>Rule</code>. For more
        /// information, see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>Rule</a>. You can't change the name of a <code>Rule</code> after you create it.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="metricName">A friendly name or description for the metrics for this <code>Rule</code>. The name can contain only alphanumeric characters (A-Z, a-z, 0-9); the name can't contain whitespace. You can't change the name of the metric after you create the <code>Rule</code>.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        CreateRuleResponse CreateRule(string name, string changeToken, string metricName);

        /// <summary>
        /// Creates a <code>Rule</code>, which contains the <code>IPSet</code> objects, <code>ByteMatchSet</code>
        /// objects, and other predicates that identify the requests that you want to block. If
        /// you add more than one predicate to a <code>Rule</code>, a request must match all of
        /// the specifications to be allowed or blocked. For example, suppose you add the following
        /// to a <code>Rule</code>:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44/32</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
        /// to blocks requests that satisfy the <code>Rule</code>. For a request to be blocked,
        /// it must come from the IP address 192.0.2.44 <i>and</i> the <code>User-Agent</code>
        /// header in the request must contain the value <code>BadBot</code>.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>Rule</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <code>Rule</code>.
        /// For more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRule</code> request to specify the predicates that you want
        /// to include in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>Rule</code>. For more
        /// information, see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        CreateRuleResponse CreateRule(CreateRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRule
        ///         operation.</returns>
        IAsyncResult BeginCreateRule(CreateRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRule.</param>
        /// 
        /// <returns>Returns a  CreateRuleResult from WAFRegional.</returns>
        CreateRuleResponse EndCreateRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSizeConstraintSet


        /// <summary>
        /// Creates a <code>SizeConstraintSet</code>. You then use <a>UpdateSizeConstraintSet</a>
        /// to identify the part of a web request that you want AWS WAF to check for length, such
        /// as the length of the <code>User-Agent</code> header or the length of the query string.
        /// For example, you can create a <code>SizeConstraintSet</code> that matches any requests
        /// that have a query string that is longer than 100 bytes. You can then configure AWS
        /// WAF to reject those requests.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>SizeConstraintSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateSizeConstraintSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateSizeConstraintSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateSizeConstraintSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateSizeConstraintSet</a> request to specify the part of the request
        /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSizeConstraintSet service method.</param>
        /// 
        /// <returns>The response from the CreateSizeConstraintSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        CreateSizeConstraintSetResponse CreateSizeConstraintSet(CreateSizeConstraintSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSizeConstraintSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSizeConstraintSet
        ///         operation.</returns>
        IAsyncResult BeginCreateSizeConstraintSet(CreateSizeConstraintSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSizeConstraintSet.</param>
        /// 
        /// <returns>Returns a  CreateSizeConstraintSetResult from WAFRegional.</returns>
        CreateSizeConstraintSetResponse EndCreateSizeConstraintSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSqlInjectionMatchSet


        /// <summary>
        /// Creates a <a>SqlInjectionMatchSet</a>, which you use to allow, block, or count requests
        /// that contain snippets of SQL code in a specified part of web requests. AWS WAF searches
        /// for character sequences that are likely to be malicious strings.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>SqlInjectionMatchSet</code>, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateSqlInjectionMatchSet</a> request to specify the parts of web requests
        /// in which you want to allow, block, or count malicious SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description for the <a>SqlInjectionMatchSet</a> that you're creating. You can't change <code>Name</code> after you create the <code>SqlInjectionMatchSet</code>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the CreateSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        CreateSqlInjectionMatchSetResponse CreateSqlInjectionMatchSet(string name, string changeToken);

        /// <summary>
        /// Creates a <a>SqlInjectionMatchSet</a>, which you use to allow, block, or count requests
        /// that contain snippets of SQL code in a specified part of web requests. AWS WAF searches
        /// for character sequences that are likely to be malicious strings.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>SqlInjectionMatchSet</code>, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateSqlInjectionMatchSet</a> request to specify the parts of web requests
        /// in which you want to allow, block, or count malicious SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSqlInjectionMatchSet service method.</param>
        /// 
        /// <returns>The response from the CreateSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        CreateSqlInjectionMatchSetResponse CreateSqlInjectionMatchSet(CreateSqlInjectionMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSqlInjectionMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSqlInjectionMatchSet
        ///         operation.</returns>
        IAsyncResult BeginCreateSqlInjectionMatchSet(CreateSqlInjectionMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSqlInjectionMatchSet.</param>
        /// 
        /// <returns>Returns a  CreateSqlInjectionMatchSetResult from WAFRegional.</returns>
        CreateSqlInjectionMatchSetResponse EndCreateSqlInjectionMatchSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWebACL


        /// <summary>
        /// Creates a <code>WebACL</code>, which contains the <code>Rules</code> that identify
        /// the CloudFront web requests that you want to allow, block, or count. AWS WAF evaluates
        /// <code>Rules</code> in order based on the value of <code>Priority</code> for each <code>Rule</code>.
        /// 
        ///  
        /// <para>
        /// You also specify a default action, either <code>ALLOW</code> or <code>BLOCK</code>.
        /// If a web request doesn't match any of the <code>Rules</code> in a <code>WebACL</code>,
        /// AWS WAF responds to the request with the default action. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>WebACL</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the <code>ByteMatchSet</code> objects and other predicates that
        /// you want to include in <code>Rules</code>. For more information, see <a>CreateByteMatchSet</a>,
        /// <a>UpdateByteMatchSet</a>, <a>CreateIPSet</a>, <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>,
        /// and <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update the <code>Rules</code> that you want to include in the <code>WebACL</code>.
        /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateWebACL</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateWebACL</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateWebACL</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateWebACL</a> request to specify the <code>Rules</code> that you want
        /// to include in the <code>WebACL</code>, to specify the default action, and to associate
        /// the <code>WebACL</code> with a CloudFront distribution.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API, see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS
        /// WAF Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        CreateWebACLResponse CreateWebACL(CreateWebACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWebACL
        ///         operation.</returns>
        IAsyncResult BeginCreateWebACL(CreateWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWebACL.</param>
        /// 
        /// <returns>Returns a  CreateWebACLResult from WAFRegional.</returns>
        CreateWebACLResponse EndCreateWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateXssMatchSet


        /// <summary>
        /// Creates an <a>XssMatchSet</a>, which you use to allow, block, or count requests that
        /// contain cross-site scripting attacks in the specified part of web requests. AWS WAF
        /// searches for character sequences that are likely to be malicious strings.
        /// 
        ///  
        /// <para>
        /// To create and configure an <code>XssMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateXssMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateXssMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateXssMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateXssMatchSet</a> request to specify the parts of web requests in
        /// which you want to allow, block, or count cross-site scripting attacks.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateXssMatchSet service method.</param>
        /// 
        /// <returns>The response from the CreateXssMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        CreateXssMatchSetResponse CreateXssMatchSet(CreateXssMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateXssMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateXssMatchSet
        ///         operation.</returns>
        IAsyncResult BeginCreateXssMatchSet(CreateXssMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateXssMatchSet.</param>
        /// 
        /// <returns>Returns a  CreateXssMatchSetResult from WAFRegional.</returns>
        CreateXssMatchSetResponse EndCreateXssMatchSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteByteMatchSet


        /// <summary>
        /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <code>ByteMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still includes any <a>ByteMatchTuple</a>
        /// objects (any filters).
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>ByteMatchSet</code> from a <code>Rule</code>, use
        /// <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>ByteMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteByteMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="byteMatchSetId">The <code>ByteMatchSetId</code> of the <a>ByteMatchSet</a> that you want to delete. <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the DeleteByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteByteMatchSetResponse DeleteByteMatchSet(string byteMatchSetId, string changeToken);

        /// <summary>
        /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <code>ByteMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still includes any <a>ByteMatchTuple</a>
        /// objects (any filters).
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>ByteMatchSet</code> from a <code>Rule</code>, use
        /// <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>ByteMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteByteMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteByteMatchSet service method.</param>
        /// 
        /// <returns>The response from the DeleteByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteByteMatchSetResponse DeleteByteMatchSet(DeleteByteMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteByteMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteByteMatchSet
        ///         operation.</returns>
        IAsyncResult BeginDeleteByteMatchSet(DeleteByteMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteByteMatchSet.</param>
        /// 
        /// <returns>Returns a  DeleteByteMatchSetResult from WAFRegional.</returns>
        DeleteByteMatchSetResponse EndDeleteByteMatchSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIPSet


        /// <summary>
        /// Permanently deletes an <a>IPSet</a>. You can't delete an <code>IPSet</code> if it's
        /// still used in any <code>Rules</code> or if it still includes any IP addresses.
        /// 
        ///  
        /// <para>
        /// If you just want to remove an <code>IPSet</code> from a <code>Rule</code>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <code>IPSet</code> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>IPSet</code> to remove IP address ranges, if any. For more information,
        /// see <a>UpdateIPSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteIPSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ipSetId">The <code>IPSetId</code> of the <a>IPSet</a> that you want to delete. <code>IPSetId</code> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteIPSetResponse DeleteIPSet(string ipSetId, string changeToken);

        /// <summary>
        /// Permanently deletes an <a>IPSet</a>. You can't delete an <code>IPSet</code> if it's
        /// still used in any <code>Rules</code> or if it still includes any IP addresses.
        /// 
        ///  
        /// <para>
        /// If you just want to remove an <code>IPSet</code> from a <code>Rule</code>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <code>IPSet</code> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>IPSet</code> to remove IP address ranges, if any. For more information,
        /// see <a>UpdateIPSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteIPSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIPSet
        ///         operation.</returns>
        IAsyncResult BeginDeleteIPSet(DeleteIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIPSet.</param>
        /// 
        /// <returns>Returns a  DeleteIPSetResult from WAFRegional.</returns>
        DeleteIPSetResponse EndDeleteIPSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Permanently deletes a <a>Rule</a>. You can't delete a <code>Rule</code> if it's still
        /// used in any <code>WebACL</code> objects or if it still includes any predicates, such
        /// as <code>ByteMatchSet</code> objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>Rule</code> from a <code>WebACL</code>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>Rule</code> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>Rule</code> to remove predicates, if any. For more information, see
        /// <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteRule</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ruleId">The <code>RuleId</code> of the <a>Rule</a> that you want to delete. <code>RuleId</code> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteRuleResponse DeleteRule(string ruleId, string changeToken);

        /// <summary>
        /// Permanently deletes a <a>Rule</a>. You can't delete a <code>Rule</code> if it's still
        /// used in any <code>WebACL</code> objects or if it still includes any predicates, such
        /// as <code>ByteMatchSet</code> objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>Rule</code> from a <code>WebACL</code>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>Rule</code> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>Rule</code> to remove predicates, if any. For more information, see
        /// <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteRule</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRule
        ///         operation.</returns>
        IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from WAFRegional.</returns>
        DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSizeConstraintSet


        /// <summary>
        /// Permanently deletes a <a>SizeConstraintSet</a>. You can't delete a <code>SizeConstraintSet</code>
        /// if it's still used in any <code>Rules</code> or if it still includes any <a>SizeConstraint</a>
        /// objects (any filters).
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>SizeConstraintSet</code> from a <code>Rule</code>,
        /// use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>SizeConstraintSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>SizeConstraintSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateSizeConstraintSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteSizeConstraintSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteSizeConstraintSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSizeConstraintSet service method.</param>
        /// 
        /// <returns>The response from the DeleteSizeConstraintSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteSizeConstraintSetResponse DeleteSizeConstraintSet(DeleteSizeConstraintSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSizeConstraintSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSizeConstraintSet
        ///         operation.</returns>
        IAsyncResult BeginDeleteSizeConstraintSet(DeleteSizeConstraintSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSizeConstraintSet.</param>
        /// 
        /// <returns>Returns a  DeleteSizeConstraintSetResult from WAFRegional.</returns>
        DeleteSizeConstraintSetResponse EndDeleteSizeConstraintSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSqlInjectionMatchSet


        /// <summary>
        /// Permanently deletes a <a>SqlInjectionMatchSet</a>. You can't delete a <code>SqlInjectionMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still contains any <a>SqlInjectionMatchTuple</a>
        /// objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>SqlInjectionMatchSet</code> from a <code>Rule</code>,
        /// use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>SqlInjectionMatchSet</code> from AWS WAF, perform the
        /// following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>SqlInjectionMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <code>SqlInjectionMatchSetId</code> of the <a>SqlInjectionMatchSet</a> that you want to delete. <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the DeleteSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteSqlInjectionMatchSetResponse DeleteSqlInjectionMatchSet(string sqlInjectionMatchSetId, string changeToken);

        /// <summary>
        /// Permanently deletes a <a>SqlInjectionMatchSet</a>. You can't delete a <code>SqlInjectionMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still contains any <a>SqlInjectionMatchTuple</a>
        /// objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>SqlInjectionMatchSet</code> from a <code>Rule</code>,
        /// use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>SqlInjectionMatchSet</code> from AWS WAF, perform the
        /// following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>SqlInjectionMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSqlInjectionMatchSet service method.</param>
        /// 
        /// <returns>The response from the DeleteSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteSqlInjectionMatchSetResponse DeleteSqlInjectionMatchSet(DeleteSqlInjectionMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSqlInjectionMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSqlInjectionMatchSet
        ///         operation.</returns>
        IAsyncResult BeginDeleteSqlInjectionMatchSet(DeleteSqlInjectionMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSqlInjectionMatchSet.</param>
        /// 
        /// <returns>Returns a  DeleteSqlInjectionMatchSetResult from WAFRegional.</returns>
        DeleteSqlInjectionMatchSetResponse EndDeleteSqlInjectionMatchSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWebACL


        /// <summary>
        /// Permanently deletes a <a>WebACL</a>. You can't delete a <code>WebACL</code> if it
        /// still contains any <code>Rules</code>.
        /// 
        ///  
        /// <para>
        /// To delete a <code>WebACL</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>WebACL</code> to remove <code>Rules</code>, if any. For more information,
        /// see <a>UpdateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteWebACL</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteWebACL</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="webACLId">The <code>WebACLId</code> of the <a>WebACL</a> that you want to delete. <code>WebACLId</code> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteWebACLResponse DeleteWebACL(string webACLId, string changeToken);

        /// <summary>
        /// Permanently deletes a <a>WebACL</a>. You can't delete a <code>WebACL</code> if it
        /// still contains any <code>Rules</code>.
        /// 
        ///  
        /// <para>
        /// To delete a <code>WebACL</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>WebACL</code> to remove <code>Rules</code>, if any. For more information,
        /// see <a>UpdateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteWebACL</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteWebACL</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteWebACLResponse DeleteWebACL(DeleteWebACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWebACL
        ///         operation.</returns>
        IAsyncResult BeginDeleteWebACL(DeleteWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWebACL.</param>
        /// 
        /// <returns>Returns a  DeleteWebACLResult from WAFRegional.</returns>
        DeleteWebACLResponse EndDeleteWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteXssMatchSet


        /// <summary>
        /// Permanently deletes an <a>XssMatchSet</a>. You can't delete an <code>XssMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still contains any <a>XssMatchTuple</a>
        /// objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove an <code>XssMatchSet</code> from a <code>Rule</code>, use
        /// <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <code>XssMatchSet</code> from AWS WAF, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>XssMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateXssMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteXssMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteXssMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteXssMatchSet service method.</param>
        /// 
        /// <returns>The response from the DeleteXssMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        DeleteXssMatchSetResponse DeleteXssMatchSet(DeleteXssMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteXssMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteXssMatchSet
        ///         operation.</returns>
        IAsyncResult BeginDeleteXssMatchSet(DeleteXssMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteXssMatchSet.</param>
        /// 
        /// <returns>Returns a  DeleteXssMatchSetResult from WAFRegional.</returns>
        DeleteXssMatchSetResponse EndDeleteXssMatchSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateWebACL


        /// <summary>
        /// Removes a web ACL from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL service method.</param>
        /// 
        /// <returns>The response from the DisassociateWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        DisassociateWebACLResponse DisassociateWebACL(DisassociateWebACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWebACL
        ///         operation.</returns>
        IAsyncResult BeginDisassociateWebACL(DisassociateWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWebACL.</param>
        /// 
        /// <returns>Returns a  DisassociateWebACLResult from WAFRegional.</returns>
        DisassociateWebACLResponse EndDisassociateWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  GetByteMatchSet


        /// <summary>
        /// Returns the <a>ByteMatchSet</a> specified by <code>ByteMatchSetId</code>.
        /// </summary>
        /// <param name="byteMatchSetId">The <code>ByteMatchSetId</code> of the <a>ByteMatchSet</a> that you want to get. <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// 
        /// <returns>The response from the GetByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetByteMatchSetResponse GetByteMatchSet(string byteMatchSetId);

        /// <summary>
        /// Returns the <a>ByteMatchSet</a> specified by <code>ByteMatchSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetByteMatchSet service method.</param>
        /// 
        /// <returns>The response from the GetByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetByteMatchSetResponse GetByteMatchSet(GetByteMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetByteMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetByteMatchSet
        ///         operation.</returns>
        IAsyncResult BeginGetByteMatchSet(GetByteMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetByteMatchSet.</param>
        /// 
        /// <returns>Returns a  GetByteMatchSetResult from WAFRegional.</returns>
        GetByteMatchSetResponse EndGetByteMatchSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChangeToken


        /// <summary>
        /// When you want to create, update, or delete AWS WAF objects, get a change token and
        /// include the change token in the create, update, or delete request. Change tokens ensure
        /// that your application doesn't submit conflicting requests to AWS WAF.
        /// 
        ///  
        /// <para>
        /// Each create, update, or delete request must use a unique change token. If your application
        /// submits a <code>GetChangeToken</code> request and then submits a second <code>GetChangeToken</code>
        /// request before submitting a create, update, or delete request, the second <code>GetChangeToken</code>
        /// request returns the same value as the first <code>GetChangeToken</code> request.
        /// </para>
        ///  
        /// <para>
        /// When you use a change token in a create, update, or delete request, the status of
        /// the change token changes to <code>PENDING</code>, which indicates that AWS WAF is
        /// propagating the change to all AWS WAF servers. Use <code>GetChangeTokenStatus</code>
        /// to determine the status of your change token.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetChangeToken service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        GetChangeTokenResponse GetChangeToken();

        /// <summary>
        /// When you want to create, update, or delete AWS WAF objects, get a change token and
        /// include the change token in the create, update, or delete request. Change tokens ensure
        /// that your application doesn't submit conflicting requests to AWS WAF.
        /// 
        ///  
        /// <para>
        /// Each create, update, or delete request must use a unique change token. If your application
        /// submits a <code>GetChangeToken</code> request and then submits a second <code>GetChangeToken</code>
        /// request before submitting a create, update, or delete request, the second <code>GetChangeToken</code>
        /// request returns the same value as the first <code>GetChangeToken</code> request.
        /// </para>
        ///  
        /// <para>
        /// When you use a change token in a create, update, or delete request, the status of
        /// the change token changes to <code>PENDING</code>, which indicates that AWS WAF is
        /// propagating the change to all AWS WAF servers. Use <code>GetChangeTokenStatus</code>
        /// to determine the status of your change token.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeToken service method.</param>
        /// 
        /// <returns>The response from the GetChangeToken service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        GetChangeTokenResponse GetChangeToken(GetChangeTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChangeToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChangeToken operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChangeToken
        ///         operation.</returns>
        IAsyncResult BeginGetChangeToken(GetChangeTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChangeToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChangeToken.</param>
        /// 
        /// <returns>Returns a  GetChangeTokenResult from WAFRegional.</returns>
        GetChangeTokenResponse EndGetChangeToken(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChangeTokenStatus


        /// <summary>
        /// Returns the status of a <code>ChangeToken</code> that you got by calling <a>GetChangeToken</a>.
        /// <code>ChangeTokenStatus</code> is one of the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>PROVISIONED</code>: You requested the change token by calling <code>GetChangeToken</code>,
        /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING</code>: AWS WAF is propagating the create, update, or delete request
        /// to all AWS WAF servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: Propagation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="changeToken">The change token for which you want to get the status. This change token was previously returned in the <code>GetChangeToken</code> response.</param>
        /// 
        /// <returns>The response from the GetChangeTokenStatus service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetChangeTokenStatusResponse GetChangeTokenStatus(string changeToken);

        /// <summary>
        /// Returns the status of a <code>ChangeToken</code> that you got by calling <a>GetChangeToken</a>.
        /// <code>ChangeTokenStatus</code> is one of the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>PROVISIONED</code>: You requested the change token by calling <code>GetChangeToken</code>,
        /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING</code>: AWS WAF is propagating the create, update, or delete request
        /// to all AWS WAF servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: Propagation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeTokenStatus service method.</param>
        /// 
        /// <returns>The response from the GetChangeTokenStatus service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetChangeTokenStatusResponse GetChangeTokenStatus(GetChangeTokenStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChangeTokenStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChangeTokenStatus operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChangeTokenStatus
        ///         operation.</returns>
        IAsyncResult BeginGetChangeTokenStatus(GetChangeTokenStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChangeTokenStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChangeTokenStatus.</param>
        /// 
        /// <returns>Returns a  GetChangeTokenStatusResult from WAFRegional.</returns>
        GetChangeTokenStatusResponse EndGetChangeTokenStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIPSet


        /// <summary>
        /// Returns the <a>IPSet</a> that is specified by <code>IPSetId</code>.
        /// </summary>
        /// <param name="ipSetId">The <code>IPSetId</code> of the <a>IPSet</a> that you want to get. <code>IPSetId</code> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetIPSetResponse GetIPSet(string ipSetId);

        /// <summary>
        /// Returns the <a>IPSet</a> that is specified by <code>IPSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetIPSetResponse GetIPSet(GetIPSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIPSet
        ///         operation.</returns>
        IAsyncResult BeginGetIPSet(GetIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIPSet.</param>
        /// 
        /// <returns>Returns a  GetIPSetResult from WAFRegional.</returns>
        GetIPSetResponse EndGetIPSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRule


        /// <summary>
        /// Returns the <a>Rule</a> that is specified by the <code>RuleId</code> that you included
        /// in the <code>GetRule</code> request.
        /// </summary>
        /// <param name="ruleId">The <code>RuleId</code> of the <a>Rule</a> that you want to get. <code>RuleId</code> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetRuleResponse GetRule(string ruleId);

        /// <summary>
        /// Returns the <a>Rule</a> that is specified by the <code>RuleId</code> that you included
        /// in the <code>GetRule</code> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetRuleResponse GetRule(GetRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRule operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRule
        ///         operation.</returns>
        IAsyncResult BeginGetRule(GetRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRule.</param>
        /// 
        /// <returns>Returns a  GetRuleResult from WAFRegional.</returns>
        GetRuleResponse EndGetRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSampledRequests


        /// <summary>
        /// Gets detailed information about a specified number of requests--a sample--that AWS
        /// WAF randomly selects from among the first 5,000 requests that your AWS resource received
        /// during a time range that you choose. You can specify a sample size of up to 100 requests,
        /// and you can specify any time range in the previous three hours.
        /// 
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
        /// <returns>The response from the GetSampledRequests service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetSampledRequestsResponse GetSampledRequests(GetSampledRequestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSampledRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSampledRequests
        ///         operation.</returns>
        IAsyncResult BeginGetSampledRequests(GetSampledRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSampledRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSampledRequests.</param>
        /// 
        /// <returns>Returns a  GetSampledRequestsResult from WAFRegional.</returns>
        GetSampledRequestsResponse EndGetSampledRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSizeConstraintSet


        /// <summary>
        /// Returns the <a>SizeConstraintSet</a> specified by <code>SizeConstraintSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSizeConstraintSet service method.</param>
        /// 
        /// <returns>The response from the GetSizeConstraintSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetSizeConstraintSetResponse GetSizeConstraintSet(GetSizeConstraintSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSizeConstraintSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSizeConstraintSet
        ///         operation.</returns>
        IAsyncResult BeginGetSizeConstraintSet(GetSizeConstraintSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSizeConstraintSet.</param>
        /// 
        /// <returns>Returns a  GetSizeConstraintSetResult from WAFRegional.</returns>
        GetSizeConstraintSetResponse EndGetSizeConstraintSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSqlInjectionMatchSet


        /// <summary>
        /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <code>SqlInjectionMatchSetId</code>.
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <code>SqlInjectionMatchSetId</code> of the <a>SqlInjectionMatchSet</a> that you want to get. <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// 
        /// <returns>The response from the GetSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetSqlInjectionMatchSetResponse GetSqlInjectionMatchSet(string sqlInjectionMatchSetId);

        /// <summary>
        /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <code>SqlInjectionMatchSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSqlInjectionMatchSet service method.</param>
        /// 
        /// <returns>The response from the GetSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetSqlInjectionMatchSetResponse GetSqlInjectionMatchSet(GetSqlInjectionMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSqlInjectionMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSqlInjectionMatchSet
        ///         operation.</returns>
        IAsyncResult BeginGetSqlInjectionMatchSet(GetSqlInjectionMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSqlInjectionMatchSet.</param>
        /// 
        /// <returns>Returns a  GetSqlInjectionMatchSetResult from WAFRegional.</returns>
        GetSqlInjectionMatchSetResponse EndGetSqlInjectionMatchSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWebACL


        /// <summary>
        /// Returns the <a>WebACL</a> that is specified by <code>WebACLId</code>.
        /// </summary>
        /// <param name="webACLId">The <code>WebACLId</code> of the <a>WebACL</a> that you want to get. <code>WebACLId</code> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetWebACLResponse GetWebACL(string webACLId);

        /// <summary>
        /// Returns the <a>WebACL</a> that is specified by <code>WebACLId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetWebACLResponse GetWebACL(GetWebACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWebACL
        ///         operation.</returns>
        IAsyncResult BeginGetWebACL(GetWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWebACL.</param>
        /// 
        /// <returns>Returns a  GetWebACLResult from WAFRegional.</returns>
        GetWebACLResponse EndGetWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWebACLForResource


        /// <summary>
        /// Returns the web ACL for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource service method.</param>
        /// 
        /// <returns>The response from the GetWebACLForResource service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFUnavailableEntityException">
        /// The operation failed because the entity referenced is temporarily unavailable. Retry
        /// your request.
        /// </exception>
        GetWebACLForResourceResponse GetWebACLForResource(GetWebACLForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWebACLForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWebACLForResource
        ///         operation.</returns>
        IAsyncResult BeginGetWebACLForResource(GetWebACLForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWebACLForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWebACLForResource.</param>
        /// 
        /// <returns>Returns a  GetWebACLForResourceResult from WAFRegional.</returns>
        GetWebACLForResourceResponse EndGetWebACLForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetXssMatchSet


        /// <summary>
        /// Returns the <a>XssMatchSet</a> that is specified by <code>XssMatchSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetXssMatchSet service method.</param>
        /// 
        /// <returns>The response from the GetXssMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        GetXssMatchSetResponse GetXssMatchSet(GetXssMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetXssMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetXssMatchSet
        ///         operation.</returns>
        IAsyncResult BeginGetXssMatchSet(GetXssMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetXssMatchSet.</param>
        /// 
        /// <returns>Returns a  GetXssMatchSetResult from WAFRegional.</returns>
        GetXssMatchSetResponse EndGetXssMatchSet(IAsyncResult asyncResult);

        #endregion
        
        #region  ListByteMatchSets


        /// <summary>
        /// Returns an array of <a>ByteMatchSetSummary</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListByteMatchSets service method.</param>
        /// 
        /// <returns>The response from the ListByteMatchSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        ListByteMatchSetsResponse ListByteMatchSets(ListByteMatchSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListByteMatchSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListByteMatchSets operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListByteMatchSets
        ///         operation.</returns>
        IAsyncResult BeginListByteMatchSets(ListByteMatchSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListByteMatchSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListByteMatchSets.</param>
        /// 
        /// <returns>Returns a  ListByteMatchSetsResult from WAFRegional.</returns>
        ListByteMatchSetsResponse EndListByteMatchSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIPSets


        /// <summary>
        /// Returns an array of <a>IPSetSummary</a> objects in the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        ListIPSetsResponse ListIPSets(ListIPSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIPSets
        ///         operation.</returns>
        IAsyncResult BeginListIPSets(ListIPSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIPSets.</param>
        /// 
        /// <returns>Returns a  ListIPSetsResult from WAFRegional.</returns>
        ListIPSetsResponse EndListIPSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourcesForWebACL


        /// <summary>
        /// Returns an array of resources associated with the specified web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL service method.</param>
        /// 
        /// <returns>The response from the ListResourcesForWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        ListResourcesForWebACLResponse ListResourcesForWebACL(ListResourcesForWebACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourcesForWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourcesForWebACL
        ///         operation.</returns>
        IAsyncResult BeginListResourcesForWebACL(ListResourcesForWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourcesForWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourcesForWebACL.</param>
        /// 
        /// <returns>Returns a  ListResourcesForWebACLResult from WAFRegional.</returns>
        ListResourcesForWebACLResponse EndListResourcesForWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Returns an array of <a>RuleSummary</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        ListRulesResponse ListRules(ListRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRules operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRules
        ///         operation.</returns>
        IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRules.</param>
        /// 
        /// <returns>Returns a  ListRulesResult from WAFRegional.</returns>
        ListRulesResponse EndListRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSizeConstraintSets


        /// <summary>
        /// Returns an array of <a>SizeConstraintSetSummary</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSizeConstraintSets service method.</param>
        /// 
        /// <returns>The response from the ListSizeConstraintSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        ListSizeConstraintSetsResponse ListSizeConstraintSets(ListSizeConstraintSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSizeConstraintSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSizeConstraintSets operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSizeConstraintSets
        ///         operation.</returns>
        IAsyncResult BeginListSizeConstraintSets(ListSizeConstraintSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSizeConstraintSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSizeConstraintSets.</param>
        /// 
        /// <returns>Returns a  ListSizeConstraintSetsResult from WAFRegional.</returns>
        ListSizeConstraintSetsResponse EndListSizeConstraintSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSqlInjectionMatchSets


        /// <summary>
        /// Returns an array of <a>SqlInjectionMatchSet</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSqlInjectionMatchSets service method.</param>
        /// 
        /// <returns>The response from the ListSqlInjectionMatchSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        ListSqlInjectionMatchSetsResponse ListSqlInjectionMatchSets(ListSqlInjectionMatchSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSqlInjectionMatchSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSqlInjectionMatchSets operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSqlInjectionMatchSets
        ///         operation.</returns>
        IAsyncResult BeginListSqlInjectionMatchSets(ListSqlInjectionMatchSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSqlInjectionMatchSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSqlInjectionMatchSets.</param>
        /// 
        /// <returns>Returns a  ListSqlInjectionMatchSetsResult from WAFRegional.</returns>
        ListSqlInjectionMatchSetsResponse EndListSqlInjectionMatchSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWebACLs


        /// <summary>
        /// Returns an array of <a>WebACLSummary</a> objects in the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
        /// 
        /// <returns>The response from the ListWebACLs service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        ListWebACLsResponse ListWebACLs(ListWebACLsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWebACLs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWebACLs
        ///         operation.</returns>
        IAsyncResult BeginListWebACLs(ListWebACLsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWebACLs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWebACLs.</param>
        /// 
        /// <returns>Returns a  ListWebACLsResult from WAFRegional.</returns>
        ListWebACLsResponse EndListWebACLs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListXssMatchSets


        /// <summary>
        /// Returns an array of <a>XssMatchSet</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListXssMatchSets service method.</param>
        /// 
        /// <returns>The response from the ListXssMatchSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        ListXssMatchSetsResponse ListXssMatchSets(ListXssMatchSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListXssMatchSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListXssMatchSets operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListXssMatchSets
        ///         operation.</returns>
        IAsyncResult BeginListXssMatchSets(ListXssMatchSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListXssMatchSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListXssMatchSets.</param>
        /// 
        /// <returns>Returns a  ListXssMatchSetsResult from WAFRegional.</returns>
        ListXssMatchSetsResponse EndListXssMatchSets(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateByteMatchSet


        /// <summary>
        /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
        /// For each <code>ByteMatchTuple</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <code>ByteMatchSetUpdate</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <code>User-Agent</code> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bytes (typically a string that corresponds with ASCII characters) that you want
        /// AWS WAF to look for. For more information, including how you specify the values for
        /// the AWS WAF API and the AWS CLI or SDKs, see <code>TargetString</code> in the <a>ByteMatchTuple</a>
        /// data type. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Where to look, such as at the beginning or the end of a query string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any conversions on the request, such as converting it to lowercase,
        /// before inspecting it for the specified string.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, you can add a <code>ByteMatchSetUpdate</code> object that matches web
        /// requests in which <code>User-Agent</code> headers contain the string <code>BadBot</code>.
        /// You can then configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <code>ByteMatchSet.</code> For more information, see <a>CreateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateByteMatchSet</code> request to specify the part of the request
        /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="byteMatchSetId">The <code>ByteMatchSetId</code> of the <a>ByteMatchSet</a> that you want to update. <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="updates">An array of <code>ByteMatchSetUpdate</code> objects that you want to insert into or delete from a <a>ByteMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>ByteMatchSetUpdate</a>: Contains <code>Action</code> and <code>ByteMatchTuple</code>  </li> <li>  <a>ByteMatchTuple</a>: Contains <code>FieldToMatch</code>, <code>PositionalConstraint</code>, <code>TargetString</code>, and <code>TextTransformation</code>  </li> <li>  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the UpdateByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        UpdateByteMatchSetResponse UpdateByteMatchSet(string byteMatchSetId, List<ByteMatchSetUpdate> updates, string changeToken);

        /// <summary>
        /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
        /// For each <code>ByteMatchTuple</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <code>ByteMatchSetUpdate</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <code>User-Agent</code> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bytes (typically a string that corresponds with ASCII characters) that you want
        /// AWS WAF to look for. For more information, including how you specify the values for
        /// the AWS WAF API and the AWS CLI or SDKs, see <code>TargetString</code> in the <a>ByteMatchTuple</a>
        /// data type. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Where to look, such as at the beginning or the end of a query string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any conversions on the request, such as converting it to lowercase,
        /// before inspecting it for the specified string.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, you can add a <code>ByteMatchSetUpdate</code> object that matches web
        /// requests in which <code>User-Agent</code> headers contain the string <code>BadBot</code>.
        /// You can then configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <code>ByteMatchSet.</code> For more information, see <a>CreateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateByteMatchSet</code> request to specify the part of the request
        /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateByteMatchSet service method.</param>
        /// 
        /// <returns>The response from the UpdateByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        UpdateByteMatchSetResponse UpdateByteMatchSet(UpdateByteMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateByteMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateByteMatchSet
        ///         operation.</returns>
        IAsyncResult BeginUpdateByteMatchSet(UpdateByteMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateByteMatchSet.</param>
        /// 
        /// <returns>Returns a  UpdateByteMatchSetResult from WAFRegional.</returns>
        UpdateByteMatchSetResponse EndUpdateByteMatchSet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIPSet


        /// <summary>
        /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <code>IPSet</code>. For each
        /// <code>IPSetDescriptor</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <code>IPSetDescriptor</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address version, <code>IPv4</code> or <code>IPv6</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address in CIDR notation, for example, <code>192.0.2.0/24</code> (for the range
        /// of IP addresses from <code>192.0.2.0</code> to <code>192.0.2.255</code>) or <code>192.0.2.44/32</code>
        /// (for the individual IP address <code>192.0.2.44</code>). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS WAF supports /8, /16, /24, and /32 IP address ranges for IPv4, and /24, /32, /48,
        /// /56, /64 and /128 for IPv6. For more information about CIDR notation, see the Wikipedia
        /// entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.
        /// </para>
        ///  
        /// <para>
        /// IPv6 addresses can be represented using any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 1111:0000:0000:0000:0000:0000:0000:0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111:0:0:0:0:0:0:0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111::0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111::111/128
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use an <code>IPSet</code> to specify which web requests you want to allow or block
        /// based on the IP addresses that the requests originated from. For example, if you're
        /// receiving a lot of requests from one or a small number of IP addresses and you want
        /// to block the requests, you can create an <code>IPSet</code> that specifies those IP
        /// addresses, and then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <code>IPSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateIPSet</code> request to specify the IP addresses that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <code>IPSet</code>, you specify the IP addresses that you want
        /// to add and/or the IP addresses that you want to delete. If you want to change an IP
        /// address, you delete the existing IP address and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ipSetId">The <code>IPSetId</code> of the <a>IPSet</a> that you want to update. <code>IPSetId</code> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="updates">An array of <code>IPSetUpdate</code> objects that you want to insert into or delete from an <a>IPSet</a>. For more information, see the applicable data types: <ul> <li>  <a>IPSetUpdate</a>: Contains <code>Action</code> and <code>IPSetDescriptor</code>  </li> <li>  <a>IPSetDescriptor</a>: Contains <code>Type</code> and <code>Value</code>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        UpdateIPSetResponse UpdateIPSet(string ipSetId, List<IPSetUpdate> updates, string changeToken);

        /// <summary>
        /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <code>IPSet</code>. For each
        /// <code>IPSetDescriptor</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <code>IPSetDescriptor</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address version, <code>IPv4</code> or <code>IPv6</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address in CIDR notation, for example, <code>192.0.2.0/24</code> (for the range
        /// of IP addresses from <code>192.0.2.0</code> to <code>192.0.2.255</code>) or <code>192.0.2.44/32</code>
        /// (for the individual IP address <code>192.0.2.44</code>). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS WAF supports /8, /16, /24, and /32 IP address ranges for IPv4, and /24, /32, /48,
        /// /56, /64 and /128 for IPv6. For more information about CIDR notation, see the Wikipedia
        /// entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.
        /// </para>
        ///  
        /// <para>
        /// IPv6 addresses can be represented using any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 1111:0000:0000:0000:0000:0000:0000:0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111:0:0:0:0:0:0:0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111::0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111::111/128
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use an <code>IPSet</code> to specify which web requests you want to allow or block
        /// based on the IP addresses that the requests originated from. For example, if you're
        /// receiving a lot of requests from one or a small number of IP addresses and you want
        /// to block the requests, you can create an <code>IPSet</code> that specifies those IP
        /// addresses, and then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <code>IPSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateIPSet</code> request to specify the IP addresses that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <code>IPSet</code>, you specify the IP addresses that you want
        /// to add and/or the IP addresses that you want to delete. If you want to change an IP
        /// address, you delete the existing IP address and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIPSet
        ///         operation.</returns>
        IAsyncResult BeginUpdateIPSet(UpdateIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIPSet.</param>
        /// 
        /// <returns>Returns a  UpdateIPSetResult from WAFRegional.</returns>
        UpdateIPSetResponse EndUpdateIPSet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRule


        /// <summary>
        /// Inserts or deletes <a>Predicate</a> objects in a <code>Rule</code>. Each <code>Predicate</code>
        /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
        /// specifies the web requests that you want to allow, block, or count. If you add more
        /// than one predicate to a <code>Rule</code>, a request must match all of the specifications
        /// to be allowed, blocked, or counted. For example, suppose you add the following to
        /// a <code>Rule</code>: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches the value <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
        /// to block requests that satisfy the <code>Rule</code>. For a request to be blocked,
        /// the <code>User-Agent</code> header in the request must contain the value <code>BadBot</code>
        /// <i>and</i> the request must originate from the IP address 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>Rule</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the <code>Rule</code>. See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRule</code> request to add predicates to the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>Rule</code>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <code>ByteMatchSet</code> or <code>IPSet</code> with another,
        /// you delete the existing one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ruleId">The <code>RuleId</code> of the <code>Rule</code> that you want to update. <code>RuleId</code> is returned by <code>CreateRule</code> and by <a>ListRules</a>.</param>
        /// <param name="updates">An array of <code>RuleUpdate</code> objects that you want to insert into or delete from a <a>Rule</a>. For more information, see the applicable data types: <ul> <li>  <a>RuleUpdate</a>: Contains <code>Action</code> and <code>Predicate</code>  </li> <li>  <a>Predicate</a>: Contains <code>DataId</code>, <code>Negated</code>, and <code>Type</code>  </li> <li>  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        UpdateRuleResponse UpdateRule(string ruleId, List<RuleUpdate> updates, string changeToken);

        /// <summary>
        /// Inserts or deletes <a>Predicate</a> objects in a <code>Rule</code>. Each <code>Predicate</code>
        /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
        /// specifies the web requests that you want to allow, block, or count. If you add more
        /// than one predicate to a <code>Rule</code>, a request must match all of the specifications
        /// to be allowed, blocked, or counted. For example, suppose you add the following to
        /// a <code>Rule</code>: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches the value <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
        /// to block requests that satisfy the <code>Rule</code>. For a request to be blocked,
        /// the <code>User-Agent</code> header in the request must contain the value <code>BadBot</code>
        /// <i>and</i> the request must originate from the IP address 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>Rule</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the <code>Rule</code>. See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRule</code> request to add predicates to the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>Rule</code>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <code>ByteMatchSet</code> or <code>IPSet</code> with another,
        /// you delete the existing one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        UpdateRuleResponse UpdateRule(UpdateRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRule
        ///         operation.</returns>
        IAsyncResult BeginUpdateRule(UpdateRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRule.</param>
        /// 
        /// <returns>Returns a  UpdateRuleResult from WAFRegional.</returns>
        UpdateRuleResponse EndUpdateRule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSizeConstraintSet


        /// <summary>
        /// Inserts or deletes <a>SizeConstraint</a> objects (filters) in a <a>SizeConstraintSet</a>.
        /// For each <code>SizeConstraint</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <code>SizeConstraintSetUpdate</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to evaluate, such as the length of
        /// a query string or the length of the <code>User-Agent</code> header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any transformations on the request, such as converting it to lowercase,
        /// before checking its length. Note that transformations of the request body are not
        /// supported because the AWS resource forwards only the first <code>8192</code> bytes
        /// of your request to AWS WAF.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>ComparisonOperator</code> used for evaluating the selected part of the request
        /// against the specified <code>Size</code>, such as equals, greater than, less than,
        /// and so on.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The length, in bytes, that you want AWS WAF to watch for in selected part of the request.
        /// The length is computed after applying the transformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, you can add a <code>SizeConstraintSetUpdate</code> object that matches
        /// web requests in which the length of the <code>User-Agent</code> header is greater
        /// than 100 bytes. You can then configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>SizeConstraintSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <code>SizeConstraintSet.</code> For more information, see <a>CreateSizeConstraintSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateSizeConstraintSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateSizeConstraintSet</code> request to specify the part of the
        /// request that you want AWS WAF to inspect (for example, the header or the URI) and
        /// the value that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSizeConstraintSet service method.</param>
        /// 
        /// <returns>The response from the UpdateSizeConstraintSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        UpdateSizeConstraintSetResponse UpdateSizeConstraintSet(UpdateSizeConstraintSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSizeConstraintSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSizeConstraintSet
        ///         operation.</returns>
        IAsyncResult BeginUpdateSizeConstraintSet(UpdateSizeConstraintSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSizeConstraintSet.</param>
        /// 
        /// <returns>Returns a  UpdateSizeConstraintSetResult from WAFRegional.</returns>
        UpdateSizeConstraintSetResponse EndUpdateSizeConstraintSet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSqlInjectionMatchSet


        /// <summary>
        /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
        /// For each <code>SqlInjectionMatchTuple</code> object, you specify the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>Action</code>: Whether to insert the object into or delete the object from
        /// the array. To change a <code>SqlInjectionMatchTuple</code>, you delete the existing
        /// object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FieldToMatch</code>: The part of web requests that you want AWS WAF to inspect
        /// and, if you want AWS WAF to inspect a header, the name of the header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TextTransformation</code>: Which text transformation, if any, to perform on
        /// the web request before inspecting the request for snippets of malicious SQL code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <code>SqlInjectionMatchSet</code> objects to specify which CloudFront requests
        /// you want to allow, block, or count. For example, if you're receiving requests that
        /// contain snippets of SQL code in the query string and you want to block the requests,
        /// you can create a <code>SqlInjectionMatchSet</code> with the applicable settings, and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>SqlInjectionMatchSet</code>, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateSqlInjectionMatchSet</code> request to specify the parts of
        /// web requests that you want AWS WAF to inspect for snippets of SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <code>SqlInjectionMatchSetId</code> of the <code>SqlInjectionMatchSet</code> that you want to update. <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="updates">An array of <code>SqlInjectionMatchSetUpdate</code> objects that you want to insert into or delete from a <a>SqlInjectionMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>SqlInjectionMatchSetUpdate</a>: Contains <code>Action</code> and <code>SqlInjectionMatchTuple</code>  </li> <li>  <a>SqlInjectionMatchTuple</a>: Contains <code>FieldToMatch</code> and <code>TextTransformation</code>  </li> <li>  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the UpdateSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        UpdateSqlInjectionMatchSetResponse UpdateSqlInjectionMatchSet(string sqlInjectionMatchSetId, List<SqlInjectionMatchSetUpdate> updates, string changeToken);

        /// <summary>
        /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
        /// For each <code>SqlInjectionMatchTuple</code> object, you specify the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>Action</code>: Whether to insert the object into or delete the object from
        /// the array. To change a <code>SqlInjectionMatchTuple</code>, you delete the existing
        /// object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FieldToMatch</code>: The part of web requests that you want AWS WAF to inspect
        /// and, if you want AWS WAF to inspect a header, the name of the header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TextTransformation</code>: Which text transformation, if any, to perform on
        /// the web request before inspecting the request for snippets of malicious SQL code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <code>SqlInjectionMatchSet</code> objects to specify which CloudFront requests
        /// you want to allow, block, or count. For example, if you're receiving requests that
        /// contain snippets of SQL code in the query string and you want to block the requests,
        /// you can create a <code>SqlInjectionMatchSet</code> with the applicable settings, and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>SqlInjectionMatchSet</code>, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateSqlInjectionMatchSet</code> request to specify the parts of
        /// web requests that you want AWS WAF to inspect for snippets of SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSqlInjectionMatchSet service method.</param>
        /// 
        /// <returns>The response from the UpdateSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        UpdateSqlInjectionMatchSetResponse UpdateSqlInjectionMatchSet(UpdateSqlInjectionMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSqlInjectionMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSqlInjectionMatchSet
        ///         operation.</returns>
        IAsyncResult BeginUpdateSqlInjectionMatchSet(UpdateSqlInjectionMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSqlInjectionMatchSet.</param>
        /// 
        /// <returns>Returns a  UpdateSqlInjectionMatchSetResult from WAFRegional.</returns>
        UpdateSqlInjectionMatchSetResponse EndUpdateSqlInjectionMatchSet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWebACL


        /// <summary>
        /// Inserts or deletes <a>ActivatedRule</a> objects in a <code>WebACL</code>. Each <code>Rule</code>
        /// identifies web requests that you want to allow, block, or count. When you update a
        /// <code>WebACL</code>, you specify the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A default action for the <code>WebACL</code>, either <code>ALLOW</code> or <code>BLOCK</code>.
        /// AWS WAF performs the default action if a request doesn't match the criteria in any
        /// of the <code>Rules</code> in a <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Rules</code> that you want to add and/or delete. If you want to replace
        /// one <code>Rule</code> with another, you delete the existing <code>Rule</code> and
        /// add the new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each <code>Rule</code>, whether you want AWS WAF to allow requests, block requests,
        /// or count requests that match the conditions in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order in which you want AWS WAF to evaluate the <code>Rules</code> in a <code>WebACL</code>.
        /// If you add more than one <code>Rule</code> to a <code>WebACL</code>, AWS WAF evaluates
        /// each request against the <code>Rules</code> in order based on the value of <code>Priority</code>.
        /// (The <code>Rule</code> that has the lowest value for <code>Priority</code> is evaluated
        /// first.) When a web request matches all of the predicates (such as <code>ByteMatchSets</code>
        /// and <code>IPSets</code>) in a <code>Rule</code>, AWS WAF immediately takes the corresponding
        /// action, allow or block, and doesn't evaluate the request against the remaining <code>Rules</code>
        /// in the <code>WebACL</code>, if any. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The CloudFront distribution that you want to associate with the <code>WebACL</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure a <code>WebACL</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in <code>Rules</code>. For
        /// more information, see <a>CreateByteMatchSet</a>, <a>UpdateByteMatchSet</a>, <a>CreateIPSet</a>,
        /// <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>, and <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update the <code>Rules</code> that you want to include in the <code>WebACL</code>.
        /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a <code>WebACL</code>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateWebACL</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateWebACL</code> request to specify the <code>Rules</code> that
        /// you want to include in the <code>WebACL</code>, to specify the default action, and
        /// to associate the <code>WebACL</code> with a CloudFront distribution. 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        UpdateWebACLResponse UpdateWebACL(UpdateWebACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWebACL
        ///         operation.</returns>
        IAsyncResult BeginUpdateWebACL(UpdateWebACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWebACL.</param>
        /// 
        /// <returns>Returns a  UpdateWebACLResult from WAFRegional.</returns>
        UpdateWebACLResponse EndUpdateWebACL(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateXssMatchSet


        /// <summary>
        /// Inserts or deletes <a>XssMatchTuple</a> objects (filters) in an <a>XssMatchSet</a>.
        /// For each <code>XssMatchTuple</code> object, you specify the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>Action</code>: Whether to insert the object into or delete the object from
        /// the array. To change a <code>XssMatchTuple</code>, you delete the existing object
        /// and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FieldToMatch</code>: The part of web requests that you want AWS WAF to inspect
        /// and, if you want AWS WAF to inspect a header, the name of the header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TextTransformation</code>: Which text transformation, if any, to perform on
        /// the web request before inspecting the request for cross-site scripting attacks.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <code>XssMatchSet</code> objects to specify which CloudFront requests you
        /// want to allow, block, or count. For example, if you're receiving requests that contain
        /// cross-site scripting attacks in the request body and you want to block the requests,
        /// you can create an <code>XssMatchSet</code> with the applicable settings, and then
        /// configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <code>XssMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateXssMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateXssMatchSet</code> request to specify the parts of web requests
        /// that you want AWS WAF to inspect for cross-site scripting attacks.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateXssMatchSet service method.</param>
        /// 
        /// <returns>The response from the UpdateXssMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, QUERY_STRING, or URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        UpdateXssMatchSetResponse UpdateXssMatchSet(UpdateXssMatchSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateXssMatchSet operation on AmazonWAFRegionalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateXssMatchSet
        ///         operation.</returns>
        IAsyncResult BeginUpdateXssMatchSet(UpdateXssMatchSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateXssMatchSet.</param>
        /// 
        /// <returns>Returns a  UpdateXssMatchSetResult from WAFRegional.</returns>
        UpdateXssMatchSetResponse EndUpdateXssMatchSet(IAsyncResult asyncResult);

        #endregion
        
    }
}