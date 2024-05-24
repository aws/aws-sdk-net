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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WAF.Model;

#pragma warning disable CS1570
namespace Amazon.WAF
{
    /// <summary>
    /// <para>Interface for accessing WAF</para>
    ///
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// This is the <i>AWS WAF Classic API Reference</i> for using AWS WAF Classic with Amazon
    /// CloudFront. The AWS WAF Classic actions and data types listed in the reference are
    /// available for protecting Amazon CloudFront distributions. You can use these actions
    /// and data types via the endpoint <i>waf.amazonaws.com</i>. This guide is for developers
    /// who need detailed information about the AWS WAF Classic API actions, data types, and
    /// errors. For detailed information about AWS WAF Classic features and an overview of
    /// how to use the AWS WAF Classic API, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    /// </summary>
    public partial interface IAmazonWAF : IAmazonService, IDisposable
    {


        
        #region  CreateByteMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>ByteMatchSet</c>. You then use <a>UpdateByteMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <c>User-Agent</c> header or the query string. For example, you can create a <c>ByteMatchSet</c>
        /// that matches any requests with <c>User-Agent</c> headers that contain the string <c>BadBot</c>.
        /// You can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>ByteMatchSet</a>. You can't change <c>Name</c> after you create a <c>ByteMatchSet</c>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the CreateByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateByteMatchSet">REST API Reference for CreateByteMatchSet Operation</seealso>
        CreateByteMatchSetResponse CreateByteMatchSet(string name, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>ByteMatchSet</c>. You then use <a>UpdateByteMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <c>User-Agent</c> header or the query string. For example, you can create a <c>ByteMatchSet</c>
        /// that matches any requests with <c>User-Agent</c> headers that contain the string <c>BadBot</c>.
        /// You can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateByteMatchSet service method.</param>
        /// 
        /// <returns>The response from the CreateByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateByteMatchSet">REST API Reference for CreateByteMatchSet Operation</seealso>
        CreateByteMatchSetResponse CreateByteMatchSet(CreateByteMatchSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>ByteMatchSet</c>. You then use <a>UpdateByteMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <c>User-Agent</c> header or the query string. For example, you can create a <c>ByteMatchSet</c>
        /// that matches any requests with <c>User-Agent</c> headers that contain the string <c>BadBot</c>.
        /// You can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>ByteMatchSet</a>. You can't change <c>Name</c> after you create a <c>ByteMatchSet</c>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateByteMatchSet">REST API Reference for CreateByteMatchSet Operation</seealso>
        Task<CreateByteMatchSetResponse> CreateByteMatchSetAsync(string name, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>ByteMatchSet</c>. You then use <a>UpdateByteMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <c>User-Agent</c> header or the query string. For example, you can create a <c>ByteMatchSet</c>
        /// that matches any requests with <c>User-Agent</c> headers that contain the string <c>BadBot</c>.
        /// You can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateByteMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateByteMatchSet">REST API Reference for CreateByteMatchSet Operation</seealso>
        Task<CreateByteMatchSetResponse> CreateByteMatchSetAsync(CreateByteMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGeoMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>GeoMatchSet</a>, which you use to specify which web requests you want
        /// to allow or block based on the country that the requests originate from. For example,
        /// if you're receiving a lot of requests from one or more countries and you want to block
        /// the requests, you can create an <c>GeoMatchSet</c> that contains those countries and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>GeoMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateGeoMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateGeoMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateGeoMatchSetSet</c> request to specify the countries that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeoMatchSet service method.</param>
        /// 
        /// <returns>The response from the CreateGeoMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateGeoMatchSet">REST API Reference for CreateGeoMatchSet Operation</seealso>
        CreateGeoMatchSetResponse CreateGeoMatchSet(CreateGeoMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>GeoMatchSet</a>, which you use to specify which web requests you want
        /// to allow or block based on the country that the requests originate from. For example,
        /// if you're receiving a lot of requests from one or more countries and you want to block
        /// the requests, you can create an <c>GeoMatchSet</c> that contains those countries and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>GeoMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateGeoMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateGeoMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateGeoMatchSetSet</c> request to specify the countries that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeoMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGeoMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateGeoMatchSet">REST API Reference for CreateGeoMatchSet Operation</seealso>
        Task<CreateGeoMatchSetResponse> CreateGeoMatchSetAsync(CreateGeoMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateIPSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>IPSet</a>, which you use to specify which web requests that you want
        /// to allow or block based on the IP addresses that the requests originate from. For
        /// example, if you're receiving a lot of requests from one or more individual IP addresses
        /// or one or more ranges of IP addresses and you want to block the requests, you can
        /// create an <c>IPSet</c> that contains those IP addresses and then configure AWS WAF
        /// to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>IPSet</a>. You can't change <c>Name</c> after you create the <c>IPSet</c>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        CreateIPSetResponse CreateIPSet(string name, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>IPSet</a>, which you use to specify which web requests that you want
        /// to allow or block based on the IP addresses that the requests originate from. For
        /// example, if you're receiving a lot of requests from one or more individual IP addresses
        /// or one or more ranges of IP addresses and you want to block the requests, you can
        /// create an <c>IPSet</c> that contains those IP addresses and then configure AWS WAF
        /// to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        CreateIPSetResponse CreateIPSet(CreateIPSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>IPSet</a>, which you use to specify which web requests that you want
        /// to allow or block based on the IP addresses that the requests originate from. For
        /// example, if you're receiving a lot of requests from one or more individual IP addresses
        /// or one or more ranges of IP addresses and you want to block the requests, you can
        /// create an <c>IPSet</c> that contains those IP addresses and then configure AWS WAF
        /// to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>IPSet</a>. You can't change <c>Name</c> after you create the <c>IPSet</c>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        Task<CreateIPSetResponse> CreateIPSetAsync(string name, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>IPSet</a>, which you use to specify which web requests that you want
        /// to allow or block based on the IP addresses that the requests originate from. For
        /// example, if you're receiving a lot of requests from one or more individual IP addresses
        /// or one or more ranges of IP addresses and you want to block the requests, you can
        /// create an <c>IPSet</c> that contains those IP addresses and then configure AWS WAF
        /// to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        Task<CreateIPSetResponse> CreateIPSetAsync(CreateIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRateBasedRule


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RateBasedRule</a>. The <c>RateBasedRule</c> contains a <c>RateLimit</c>,
        /// which specifies the maximum number of requests that AWS WAF allows from a specified
        /// IP address in a five-minute period. The <c>RateBasedRule</c> also contains the <c>IPSet</c>
        /// objects, <c>ByteMatchSet</c> objects, and other predicates that identify the requests
        /// that you want to count or block if these requests exceed the <c>RateLimit</c>.
        /// </para>
        ///  
        /// <para>
        /// If you add more than one predicate to a <c>RateBasedRule</c>, a request not only must
        /// exceed the <c>RateLimit</c>, but it also must match all the conditions to be counted
        /// or blocked. For example, suppose you add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// You then add the <c>RateBasedRule</c> to a <c>WebACL</c> and specify that you want
        /// to block requests that meet the conditions in the rule. For a request to be blocked,
        /// it must come from the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header
        /// in the request must contain the value <c>BadBot</c>. Further, requests that match
        /// these two conditions must be received at a rate of more than 1,000 requests every
        /// five minutes. If both conditions are met and the rate is exceeded, AWS WAF blocks
        /// the requests. If the rate drops below 1,000 for a five-minute period, AWS WAF no longer
        /// blocks the requests.
        /// </para>
        ///  
        /// <para>
        /// As a second example, suppose you want to limit requests to a particular page on your
        /// site. To do this, you could add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> with <c>FieldToMatch</c> of <c>URI</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>PositionalConstraint</c> of <c>STARTS_WITH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>TargetString</c> of <c>login</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// By adding this <c>RateBasedRule</c> to a <c>WebACL</c>, you could limit requests to
        /// your login page without affecting the rest of your site.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RateBasedRule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the rule. For more information,
        /// see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRateBasedRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRateBasedRule</c> request to specify the predicates that you want
        /// to include in the rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>RateBasedRule</c>. For more
        /// information, see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRateBasedRule service method.</param>
        /// 
        /// <returns>The response from the CreateRateBasedRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRateBasedRule">REST API Reference for CreateRateBasedRule Operation</seealso>
        CreateRateBasedRuleResponse CreateRateBasedRule(CreateRateBasedRuleRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RateBasedRule</a>. The <c>RateBasedRule</c> contains a <c>RateLimit</c>,
        /// which specifies the maximum number of requests that AWS WAF allows from a specified
        /// IP address in a five-minute period. The <c>RateBasedRule</c> also contains the <c>IPSet</c>
        /// objects, <c>ByteMatchSet</c> objects, and other predicates that identify the requests
        /// that you want to count or block if these requests exceed the <c>RateLimit</c>.
        /// </para>
        ///  
        /// <para>
        /// If you add more than one predicate to a <c>RateBasedRule</c>, a request not only must
        /// exceed the <c>RateLimit</c>, but it also must match all the conditions to be counted
        /// or blocked. For example, suppose you add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// You then add the <c>RateBasedRule</c> to a <c>WebACL</c> and specify that you want
        /// to block requests that meet the conditions in the rule. For a request to be blocked,
        /// it must come from the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header
        /// in the request must contain the value <c>BadBot</c>. Further, requests that match
        /// these two conditions must be received at a rate of more than 1,000 requests every
        /// five minutes. If both conditions are met and the rate is exceeded, AWS WAF blocks
        /// the requests. If the rate drops below 1,000 for a five-minute period, AWS WAF no longer
        /// blocks the requests.
        /// </para>
        ///  
        /// <para>
        /// As a second example, suppose you want to limit requests to a particular page on your
        /// site. To do this, you could add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> with <c>FieldToMatch</c> of <c>URI</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>PositionalConstraint</c> of <c>STARTS_WITH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>TargetString</c> of <c>login</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// By adding this <c>RateBasedRule</c> to a <c>WebACL</c>, you could limit requests to
        /// your login page without affecting the rest of your site.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RateBasedRule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the rule. For more information,
        /// see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRateBasedRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRateBasedRule</c> request to specify the predicates that you want
        /// to include in the rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>RateBasedRule</c>. For more
        /// information, see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRateBasedRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRateBasedRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRateBasedRule">REST API Reference for CreateRateBasedRule Operation</seealso>
        Task<CreateRateBasedRuleResponse> CreateRateBasedRuleAsync(CreateRateBasedRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRegexMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RegexMatchSet</a>. You then use <a>UpdateRegexMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <c>User-Agent</c> header or the query string. For example, you can create a <c>RegexMatchSet</c>
        /// that contains a <c>RegexMatchTuple</c> that looks for any requests with <c>User-Agent</c>
        /// headers that match a <c>RegexPatternSet</c> with pattern <c>B[a@]dB[o0]t</c>. You
        /// can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RegexMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateRegexMatchSet</a> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value, using
        /// a <c>RegexPatternSet</c>, that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexMatchSet service method.</param>
        /// 
        /// <returns>The response from the CreateRegexMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRegexMatchSet">REST API Reference for CreateRegexMatchSet Operation</seealso>
        CreateRegexMatchSetResponse CreateRegexMatchSet(CreateRegexMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RegexMatchSet</a>. You then use <a>UpdateRegexMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <c>User-Agent</c> header or the query string. For example, you can create a <c>RegexMatchSet</c>
        /// that contains a <c>RegexMatchTuple</c> that looks for any requests with <c>User-Agent</c>
        /// headers that match a <c>RegexPatternSet</c> with pattern <c>B[a@]dB[o0]t</c>. You
        /// can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RegexMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateRegexMatchSet</a> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value, using
        /// a <c>RegexPatternSet</c>, that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegexMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRegexMatchSet">REST API Reference for CreateRegexMatchSet Operation</seealso>
        Task<CreateRegexMatchSetResponse> CreateRegexMatchSetAsync(CreateRegexMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRegexPatternSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>RegexPatternSet</c>. You then use <a>UpdateRegexPatternSet</a> to specify
        /// the regular expression (regex) pattern that you want AWS WAF to search for, such as
        /// <c>B[a@]dB[o0]t</c>. You can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RegexPatternSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateRegexPatternSet</a> request to specify the string that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the CreateRegexPatternSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        CreateRegexPatternSetResponse CreateRegexPatternSet(CreateRegexPatternSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>RegexPatternSet</c>. You then use <a>UpdateRegexPatternSet</a> to specify
        /// the regular expression (regex) pattern that you want AWS WAF to search for, such as
        /// <c>B[a@]dB[o0]t</c>. You can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RegexPatternSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateRegexPatternSet</a> request to specify the string that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegexPatternSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        Task<CreateRegexPatternSetResponse> CreateRegexPatternSetAsync(CreateRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRule


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>Rule</c>, which contains the <c>IPSet</c> objects, <c>ByteMatchSet</c>
        /// objects, and other predicates that identify the requests that you want to block. If
        /// you add more than one predicate to a <c>Rule</c>, a request must match all of the
        /// specifications to be allowed or blocked. For example, suppose that you add the following
        /// to a <c>Rule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to blocks
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, it must come from
        /// the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header in the request must
        /// contain the value <c>BadBot</c>.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>. For
        /// more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to specify the predicates that you want to include
        /// in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. For more information,
        /// see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>Rule</a>. You can't change the name of a <c>Rule</c> after you create it.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="metricName">A friendly name or description for the metrics for this <c>Rule</c>. The name can contain only alphanumeric characters (A-Z, a-z, 0-9), with maximum length 128 and minimum length one. It can't contain whitespace or metric names reserved for AWS WAF, including "All" and "Default_Action." You can't change the name of the metric after you create the <c>Rule</c>.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRule">REST API Reference for CreateRule Operation</seealso>
        CreateRuleResponse CreateRule(string name, string changeToken, string metricName);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>Rule</c>, which contains the <c>IPSet</c> objects, <c>ByteMatchSet</c>
        /// objects, and other predicates that identify the requests that you want to block. If
        /// you add more than one predicate to a <c>Rule</c>, a request must match all of the
        /// specifications to be allowed or blocked. For example, suppose that you add the following
        /// to a <c>Rule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to blocks
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, it must come from
        /// the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header in the request must
        /// contain the value <c>BadBot</c>.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>. For
        /// more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to specify the predicates that you want to include
        /// in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. For more information,
        /// see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRule">REST API Reference for CreateRule Operation</seealso>
        CreateRuleResponse CreateRule(CreateRuleRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>Rule</c>, which contains the <c>IPSet</c> objects, <c>ByteMatchSet</c>
        /// objects, and other predicates that identify the requests that you want to block. If
        /// you add more than one predicate to a <c>Rule</c>, a request must match all of the
        /// specifications to be allowed or blocked. For example, suppose that you add the following
        /// to a <c>Rule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to blocks
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, it must come from
        /// the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header in the request must
        /// contain the value <c>BadBot</c>.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>. For
        /// more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to specify the predicates that you want to include
        /// in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. For more information,
        /// see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>Rule</a>. You can't change the name of a <c>Rule</c> after you create it.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="metricName">A friendly name or description for the metrics for this <c>Rule</c>. The name can contain only alphanumeric characters (A-Z, a-z, 0-9), with maximum length 128 and minimum length one. It can't contain whitespace or metric names reserved for AWS WAF, including "All" and "Default_Action." You can't change the name of the metric after you create the <c>Rule</c>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRule">REST API Reference for CreateRule Operation</seealso>
        Task<CreateRuleResponse> CreateRuleAsync(string name, string changeToken, string metricName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>Rule</c>, which contains the <c>IPSet</c> objects, <c>ByteMatchSet</c>
        /// objects, and other predicates that identify the requests that you want to block. If
        /// you add more than one predicate to a <c>Rule</c>, a request must match all of the
        /// specifications to be allowed or blocked. For example, suppose that you add the following
        /// to a <c>Rule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to blocks
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, it must come from
        /// the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header in the request must
        /// contain the value <c>BadBot</c>.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>. For
        /// more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to specify the predicates that you want to include
        /// in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. For more information,
        /// see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRule">REST API Reference for CreateRule Operation</seealso>
        Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRuleGroup


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>RuleGroup</c>. A rule group is a collection of predefined rules that
        /// you add to a web ACL. You use <a>UpdateRuleGroup</a> to add rules to the rule group.
        /// </para>
        ///  
        /// <para>
        /// Rule groups are subject to the following limits:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Three rule groups per account. You can request an increase to this limit by contacting
        /// customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One rule group per web ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ten rules per rule group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the CreateRuleGroup service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>RuleGroup</c>. A rule group is a collection of predefined rules that
        /// you add to a web ACL. You use <a>UpdateRuleGroup</a> to add rules to the rule group.
        /// </para>
        ///  
        /// <para>
        /// Rule groups are subject to the following limits:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Three rule groups per account. You can request an increase to this limit by contacting
        /// customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One rule group per web ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ten rules per rule group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleGroup service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        Task<CreateRuleGroupResponse> CreateRuleGroupAsync(CreateRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSizeConstraintSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>SizeConstraintSet</c>. You then use <a>UpdateSizeConstraintSet</a> to
        /// identify the part of a web request that you want AWS WAF to check for length, such
        /// as the length of the <c>User-Agent</c> header or the length of the query string. For
        /// example, you can create a <c>SizeConstraintSet</c> that matches any requests that
        /// have a query string that is longer than 100 bytes. You can then configure AWS WAF
        /// to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SizeConstraintSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateSizeConstraintSet</c> request.
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSizeConstraintSet service method.</param>
        /// 
        /// <returns>The response from the CreateSizeConstraintSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateSizeConstraintSet">REST API Reference for CreateSizeConstraintSet Operation</seealso>
        CreateSizeConstraintSetResponse CreateSizeConstraintSet(CreateSizeConstraintSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>SizeConstraintSet</c>. You then use <a>UpdateSizeConstraintSet</a> to
        /// identify the part of a web request that you want AWS WAF to check for length, such
        /// as the length of the <c>User-Agent</c> header or the length of the query string. For
        /// example, you can create a <c>SizeConstraintSet</c> that matches any requests that
        /// have a query string that is longer than 100 bytes. You can then configure AWS WAF
        /// to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SizeConstraintSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateSizeConstraintSet</c> request.
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSizeConstraintSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSizeConstraintSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateSizeConstraintSet">REST API Reference for CreateSizeConstraintSet Operation</seealso>
        Task<CreateSizeConstraintSetResponse> CreateSizeConstraintSetAsync(CreateSizeConstraintSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSqlInjectionMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>SqlInjectionMatchSet</a>, which you use to allow, block, or count requests
        /// that contain snippets of SQL code in a specified part of web requests. AWS WAF searches
        /// for character sequences that are likely to be malicious strings.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description for the <a>SqlInjectionMatchSet</a> that you're creating. You can't change <c>Name</c> after you create the <c>SqlInjectionMatchSet</c>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the CreateSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateSqlInjectionMatchSet">REST API Reference for CreateSqlInjectionMatchSet Operation</seealso>
        CreateSqlInjectionMatchSetResponse CreateSqlInjectionMatchSet(string name, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>SqlInjectionMatchSet</a>, which you use to allow, block, or count requests
        /// that contain snippets of SQL code in a specified part of web requests. AWS WAF searches
        /// for character sequences that are likely to be malicious strings.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSqlInjectionMatchSet service method.</param>
        /// 
        /// <returns>The response from the CreateSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateSqlInjectionMatchSet">REST API Reference for CreateSqlInjectionMatchSet Operation</seealso>
        CreateSqlInjectionMatchSetResponse CreateSqlInjectionMatchSet(CreateSqlInjectionMatchSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>SqlInjectionMatchSet</a>, which you use to allow, block, or count requests
        /// that contain snippets of SQL code in a specified part of web requests. AWS WAF searches
        /// for character sequences that are likely to be malicious strings.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description for the <a>SqlInjectionMatchSet</a> that you're creating. You can't change <c>Name</c> after you create the <c>SqlInjectionMatchSet</c>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateSqlInjectionMatchSet">REST API Reference for CreateSqlInjectionMatchSet Operation</seealso>
        Task<CreateSqlInjectionMatchSetResponse> CreateSqlInjectionMatchSetAsync(string name, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>SqlInjectionMatchSet</a>, which you use to allow, block, or count requests
        /// that contain snippets of SQL code in a specified part of web requests. AWS WAF searches
        /// for character sequences that are likely to be malicious strings.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSqlInjectionMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateSqlInjectionMatchSet">REST API Reference for CreateSqlInjectionMatchSet Operation</seealso>
        Task<CreateSqlInjectionMatchSetResponse> CreateSqlInjectionMatchSetAsync(CreateSqlInjectionMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWebACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>WebACL</c>, which contains the <c>Rules</c> that identify the CloudFront
        /// web requests that you want to allow, block, or count. AWS WAF evaluates <c>Rules</c>
        /// in order based on the value of <c>Priority</c> for each <c>Rule</c>.
        /// </para>
        ///  
        /// <para>
        /// You also specify a default action, either <c>ALLOW</c> or <c>BLOCK</c>. If a web request
        /// doesn't match any of the <c>Rules</c> in a <c>WebACL</c>, AWS WAF responds to the
        /// request with the default action. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the <c>ByteMatchSet</c> objects and other predicates that you want
        /// to include in <c>Rules</c>. For more information, see <a>CreateByteMatchSet</a>, <a>UpdateByteMatchSet</a>,
        /// <a>CreateIPSet</a>, <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>, and <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update the <c>Rules</c> that you want to include in the <c>WebACL</c>.
        /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateWebACL</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateWebACL</a> request to specify the <c>Rules</c> that you want to
        /// include in the <c>WebACL</c>, to specify the default action, and to associate the
        /// <c>WebACL</c> with a CloudFront distribution.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS
        /// WAF Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        CreateWebACLResponse CreateWebACL(CreateWebACLRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>WebACL</c>, which contains the <c>Rules</c> that identify the CloudFront
        /// web requests that you want to allow, block, or count. AWS WAF evaluates <c>Rules</c>
        /// in order based on the value of <c>Priority</c> for each <c>Rule</c>.
        /// </para>
        ///  
        /// <para>
        /// You also specify a default action, either <c>ALLOW</c> or <c>BLOCK</c>. If a web request
        /// doesn't match any of the <c>Rules</c> in a <c>WebACL</c>, AWS WAF responds to the
        /// request with the default action. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the <c>ByteMatchSet</c> objects and other predicates that you want
        /// to include in <c>Rules</c>. For more information, see <a>CreateByteMatchSet</a>, <a>UpdateByteMatchSet</a>,
        /// <a>CreateIPSet</a>, <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>, and <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update the <c>Rules</c> that you want to include in the <c>WebACL</c>.
        /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateWebACL</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateWebACL</a> request to specify the <c>Rules</c> that you want to
        /// include in the <c>WebACL</c>, to specify the default action, and to associate the
        /// <c>WebACL</c> with a CloudFront distribution.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS
        /// WAF Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        Task<CreateWebACLResponse> CreateWebACLAsync(CreateWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWebACLMigrationStack


        /// <summary>
        /// Creates an AWS CloudFormation WAFV2 template for the specified web ACL in the specified
        /// Amazon S3 bucket. Then, in CloudFormation, you create a stack from the template, to
        /// create the web ACL and its resources in AWS WAFV2. Use this to migrate your AWS WAF
        /// Classic web ACL to the latest version of AWS WAF.
        /// 
        ///  
        /// <para>
        /// This is part of a larger migration procedure for web ACLs from AWS WAF Classic to
        /// the latest version of AWS WAF. For the full procedure, including caveats and manual
        /// steps to complete the migration and switch over to the new web ACL, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-migrating-from-classic.html">Migrating
        /// your AWS WAF Classic resources to AWS WAF</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACLMigrationStack service method.</param>
        /// 
        /// <returns>The response from the CreateWebACLMigrationStack service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFEntityMigrationException">
        /// The operation failed due to a problem with the migration. The failure cause is provided
        /// in the exception, in the <c>MigrationErrorType</c>: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENTITY_NOT_SUPPORTED</c> - The web ACL has an unsupported entity but the <c>IgnoreUnsupportedType</c>
        /// is not set to true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENTITY_NOT_FOUND</c> - The web ACL doesn't exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_NO_PERMISSION</c> - You don't have permission to perform the <c>PutObject</c>
        /// action to the specified Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_NOT_ACCESSIBLE</c> - The bucket policy doesn't allow AWS WAF to perform
        /// the <c>PutObject</c> action in the bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_NOT_FOUND</c> - The S3 bucket doesn't exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_INVALID_REGION</c> - The S3 bucket is not in the same Region as the
        /// web ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_INTERNAL_ERROR</c> - AWS WAF failed to create the template in the S3 bucket
        /// for another reason.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateWebACLMigrationStack">REST API Reference for CreateWebACLMigrationStack Operation</seealso>
        CreateWebACLMigrationStackResponse CreateWebACLMigrationStack(CreateWebACLMigrationStackRequest request);



        /// <summary>
        /// Creates an AWS CloudFormation WAFV2 template for the specified web ACL in the specified
        /// Amazon S3 bucket. Then, in CloudFormation, you create a stack from the template, to
        /// create the web ACL and its resources in AWS WAFV2. Use this to migrate your AWS WAF
        /// Classic web ACL to the latest version of AWS WAF.
        /// 
        ///  
        /// <para>
        /// This is part of a larger migration procedure for web ACLs from AWS WAF Classic to
        /// the latest version of AWS WAF. For the full procedure, including caveats and manual
        /// steps to complete the migration and switch over to the new web ACL, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-migrating-from-classic.html">Migrating
        /// your AWS WAF Classic resources to AWS WAF</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACLMigrationStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebACLMigrationStack service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFEntityMigrationException">
        /// The operation failed due to a problem with the migration. The failure cause is provided
        /// in the exception, in the <c>MigrationErrorType</c>: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENTITY_NOT_SUPPORTED</c> - The web ACL has an unsupported entity but the <c>IgnoreUnsupportedType</c>
        /// is not set to true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENTITY_NOT_FOUND</c> - The web ACL doesn't exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_NO_PERMISSION</c> - You don't have permission to perform the <c>PutObject</c>
        /// action to the specified Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_NOT_ACCESSIBLE</c> - The bucket policy doesn't allow AWS WAF to perform
        /// the <c>PutObject</c> action in the bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_NOT_FOUND</c> - The S3 bucket doesn't exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_INVALID_REGION</c> - The S3 bucket is not in the same Region as the
        /// web ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_INTERNAL_ERROR</c> - AWS WAF failed to create the template in the S3 bucket
        /// for another reason.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateWebACLMigrationStack">REST API Reference for CreateWebACLMigrationStack Operation</seealso>
        Task<CreateWebACLMigrationStackResponse> CreateWebACLMigrationStackAsync(CreateWebACLMigrationStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateXssMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>XssMatchSet</a>, which you use to allow, block, or count requests that
        /// contain cross-site scripting attacks in the specified part of web requests. AWS WAF
        /// searches for character sequences that are likely to be malicious strings.
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>XssMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateXssMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateXssMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateXssMatchSet service method.</param>
        /// 
        /// <returns>The response from the CreateXssMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateXssMatchSet">REST API Reference for CreateXssMatchSet Operation</seealso>
        CreateXssMatchSetResponse CreateXssMatchSet(CreateXssMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>XssMatchSet</a>, which you use to allow, block, or count requests that
        /// contain cross-site scripting attacks in the specified part of web requests. AWS WAF
        /// searches for character sequences that are likely to be malicious strings.
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>XssMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateXssMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateXssMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
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
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateXssMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateXssMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/CreateXssMatchSet">REST API Reference for CreateXssMatchSet Operation</seealso>
        Task<CreateXssMatchSetResponse> CreateXssMatchSetAsync(CreateXssMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteByteMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <c>ByteMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <a>ByteMatchTuple</a>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>ByteMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>ByteMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="byteMatchSetId">The <c>ByteMatchSetId</c> of the <a>ByteMatchSet</a> that you want to delete. <c>ByteMatchSetId</c> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the DeleteByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteByteMatchSet">REST API Reference for DeleteByteMatchSet Operation</seealso>
        DeleteByteMatchSetResponse DeleteByteMatchSet(string byteMatchSetId, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <c>ByteMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <a>ByteMatchTuple</a>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>ByteMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>ByteMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteByteMatchSet service method.</param>
        /// 
        /// <returns>The response from the DeleteByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteByteMatchSet">REST API Reference for DeleteByteMatchSet Operation</seealso>
        DeleteByteMatchSetResponse DeleteByteMatchSet(DeleteByteMatchSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <c>ByteMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <a>ByteMatchTuple</a>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>ByteMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>ByteMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="byteMatchSetId">The <c>ByteMatchSetId</c> of the <a>ByteMatchSet</a> that you want to delete. <c>ByteMatchSetId</c> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteByteMatchSet">REST API Reference for DeleteByteMatchSet Operation</seealso>
        Task<DeleteByteMatchSetResponse> DeleteByteMatchSetAsync(string byteMatchSetId, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <c>ByteMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <a>ByteMatchTuple</a>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>ByteMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>ByteMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteByteMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteByteMatchSet">REST API Reference for DeleteByteMatchSet Operation</seealso>
        Task<DeleteByteMatchSetResponse> DeleteByteMatchSetAsync(DeleteByteMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGeoMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>GeoMatchSet</a>. You can't delete a <c>GeoMatchSet</c> if
        /// it's still used in any <c>Rules</c> or if it still includes any countries.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>GeoMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>GeoMatchSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>GeoMatchSet</c> to remove any countries. For more information, see <a>UpdateGeoMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteGeoMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteGeoMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeoMatchSet service method.</param>
        /// 
        /// <returns>The response from the DeleteGeoMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteGeoMatchSet">REST API Reference for DeleteGeoMatchSet Operation</seealso>
        DeleteGeoMatchSetResponse DeleteGeoMatchSet(DeleteGeoMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>GeoMatchSet</a>. You can't delete a <c>GeoMatchSet</c> if
        /// it's still used in any <c>Rules</c> or if it still includes any countries.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>GeoMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>GeoMatchSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>GeoMatchSet</c> to remove any countries. For more information, see <a>UpdateGeoMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteGeoMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteGeoMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeoMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGeoMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteGeoMatchSet">REST API Reference for DeleteGeoMatchSet Operation</seealso>
        Task<DeleteGeoMatchSetResponse> DeleteGeoMatchSetAsync(DeleteGeoMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIPSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an <a>IPSet</a>. You can't delete an <c>IPSet</c> if it's still
        /// used in any <c>Rules</c> or if it still includes any IP addresses.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove an <c>IPSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <c>IPSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>IPSet</c> to remove IP address ranges, if any. For more information,
        /// see <a>UpdateIPSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ipSetId">The <c>IPSetId</c> of the <a>IPSet</a> that you want to delete. <c>IPSetId</c> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        DeleteIPSetResponse DeleteIPSet(string ipSetId, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an <a>IPSet</a>. You can't delete an <c>IPSet</c> if it's still
        /// used in any <c>Rules</c> or if it still includes any IP addresses.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove an <c>IPSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <c>IPSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>IPSet</c> to remove IP address ranges, if any. For more information,
        /// see <a>UpdateIPSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an <a>IPSet</a>. You can't delete an <c>IPSet</c> if it's still
        /// used in any <c>Rules</c> or if it still includes any IP addresses.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove an <c>IPSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <c>IPSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>IPSet</c> to remove IP address ranges, if any. For more information,
        /// see <a>UpdateIPSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ipSetId">The <c>IPSetId</c> of the <a>IPSet</a> that you want to delete. <c>IPSetId</c> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        Task<DeleteIPSetResponse> DeleteIPSetAsync(string ipSetId, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an <a>IPSet</a>. You can't delete an <c>IPSet</c> if it's still
        /// used in any <c>Rules</c> or if it still includes any IP addresses.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove an <c>IPSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <c>IPSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>IPSet</c> to remove IP address ranges, if any. For more information,
        /// see <a>UpdateIPSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        Task<DeleteIPSetResponse> DeleteIPSetAsync(DeleteIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLoggingConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes the <a>LoggingConfiguration</a> from the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        DeleteLoggingConfigurationResponse DeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes the <a>LoggingConfiguration</a> from the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        Task<DeleteLoggingConfigurationResponse> DeleteLoggingConfigurationAsync(DeleteLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePermissionPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an IAM policy from the specified RuleGroup.
        /// </para>
        ///  
        /// <para>
        /// The user making the request must be the owner of the RuleGroup.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionPolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePermissionPolicy service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        DeletePermissionPolicyResponse DeletePermissionPolicy(DeletePermissionPolicyRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an IAM policy from the specified RuleGroup.
        /// </para>
        ///  
        /// <para>
        /// The user making the request must be the owner of the RuleGroup.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePermissionPolicy service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        Task<DeletePermissionPolicyResponse> DeletePermissionPolicyAsync(DeletePermissionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRateBasedRule


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RateBasedRule</a>. You can't delete a rule if it's still
        /// used in any <c>WebACL</c> objects or if it still includes any predicates, such as
        /// <c>ByteMatchSet</c> objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a rule from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>RateBasedRule</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>RateBasedRule</c> to remove predicates, if any. For more information,
        /// see <a>UpdateRateBasedRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRateBasedRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRateBasedRule</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRateBasedRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRateBasedRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRateBasedRule">REST API Reference for DeleteRateBasedRule Operation</seealso>
        DeleteRateBasedRuleResponse DeleteRateBasedRule(DeleteRateBasedRuleRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RateBasedRule</a>. You can't delete a rule if it's still
        /// used in any <c>WebACL</c> objects or if it still includes any predicates, such as
        /// <c>ByteMatchSet</c> objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a rule from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>RateBasedRule</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>RateBasedRule</c> to remove predicates, if any. For more information,
        /// see <a>UpdateRateBasedRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRateBasedRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRateBasedRule</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRateBasedRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRateBasedRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRateBasedRule">REST API Reference for DeleteRateBasedRule Operation</seealso>
        Task<DeleteRateBasedRuleResponse> DeleteRateBasedRuleAsync(DeleteRateBasedRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRegexMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RegexMatchSet</a>. You can't delete a <c>RegexMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <c>RegexMatchTuples</c>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>RegexMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>RegexMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>RegexMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateRegexMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRegexMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexMatchSet service method.</param>
        /// 
        /// <returns>The response from the DeleteRegexMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRegexMatchSet">REST API Reference for DeleteRegexMatchSet Operation</seealso>
        DeleteRegexMatchSetResponse DeleteRegexMatchSet(DeleteRegexMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RegexMatchSet</a>. You can't delete a <c>RegexMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <c>RegexMatchTuples</c>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>RegexMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>RegexMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>RegexMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateRegexMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRegexMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegexMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRegexMatchSet">REST API Reference for DeleteRegexMatchSet Operation</seealso>
        Task<DeleteRegexMatchSetResponse> DeleteRegexMatchSetAsync(DeleteRegexMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRegexPatternSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RegexPatternSet</a>. You can't delete a <c>RegexPatternSet</c>
        /// if it's still used in any <c>RegexMatchSet</c> or if the <c>RegexPatternSet</c> is
        /// not empty. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the DeleteRegexPatternSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        DeleteRegexPatternSetResponse DeleteRegexPatternSet(DeleteRegexPatternSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RegexPatternSet</a>. You can't delete a <c>RegexPatternSet</c>
        /// if it's still used in any <c>RegexMatchSet</c> or if the <c>RegexPatternSet</c> is
        /// not empty. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegexPatternSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        Task<DeleteRegexPatternSetResponse> DeleteRegexPatternSetAsync(DeleteRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>Rule</a>. You can't delete a <c>Rule</c> if it's still used
        /// in any <c>WebACL</c> objects or if it still includes any predicates, such as <c>ByteMatchSet</c>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>Rule</c> from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>Rule</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>Rule</c> to remove predicates, if any. For more information, see <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ruleId">The <c>RuleId</c> of the <a>Rule</a> that you want to delete. <c>RuleId</c> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse DeleteRule(string ruleId, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>Rule</a>. You can't delete a <c>Rule</c> if it's still used
        /// in any <c>WebACL</c> objects or if it still includes any predicates, such as <c>ByteMatchSet</c>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>Rule</c> from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>Rule</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>Rule</c> to remove predicates, if any. For more information, see <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>Rule</a>. You can't delete a <c>Rule</c> if it's still used
        /// in any <c>WebACL</c> objects or if it still includes any predicates, such as <c>ByteMatchSet</c>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>Rule</c> from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>Rule</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>Rule</c> to remove predicates, if any. For more information, see <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ruleId">The <c>RuleId</c> of the <a>Rule</a> that you want to delete. <c>RuleId</c> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        Task<DeleteRuleResponse> DeleteRuleAsync(string ruleId, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>Rule</a>. You can't delete a <c>Rule</c> if it's still used
        /// in any <c>WebACL</c> objects or if it still includes any predicates, such as <c>ByteMatchSet</c>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>Rule</c> from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>Rule</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>Rule</c> to remove predicates, if any. For more information, see <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRuleGroup


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RuleGroup</a>. You can't delete a <c>RuleGroup</c> if it's
        /// still used in any <c>WebACL</c> objects or if it still includes any rules.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>RuleGroup</c> from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>RuleGroup</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>RuleGroup</c> to remove rules, if any. For more information, see <a>UpdateRuleGroup</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRuleGroup</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRuleGroup</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RuleGroup</a>. You can't delete a <c>RuleGroup</c> if it's
        /// still used in any <c>WebACL</c> objects or if it still includes any rules.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>RuleGroup</c> from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>RuleGroup</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>RuleGroup</c> to remove rules, if any. For more information, see <a>UpdateRuleGroup</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRuleGroup</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRuleGroup</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        Task<DeleteRuleGroupResponse> DeleteRuleGroupAsync(DeleteRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSizeConstraintSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>SizeConstraintSet</a>. You can't delete a <c>SizeConstraintSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <a>SizeConstraint</a>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>SizeConstraintSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>SizeConstraintSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>SizeConstraintSet</c> to remove filters, if any. For more information,
        /// see <a>UpdateSizeConstraintSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteSizeConstraintSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSizeConstraintSet service method.</param>
        /// 
        /// <returns>The response from the DeleteSizeConstraintSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteSizeConstraintSet">REST API Reference for DeleteSizeConstraintSet Operation</seealso>
        DeleteSizeConstraintSetResponse DeleteSizeConstraintSet(DeleteSizeConstraintSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>SizeConstraintSet</a>. You can't delete a <c>SizeConstraintSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <a>SizeConstraint</a>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>SizeConstraintSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>SizeConstraintSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>SizeConstraintSet</c> to remove filters, if any. For more information,
        /// see <a>UpdateSizeConstraintSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteSizeConstraintSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSizeConstraintSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSizeConstraintSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteSizeConstraintSet">REST API Reference for DeleteSizeConstraintSet Operation</seealso>
        Task<DeleteSizeConstraintSetResponse> DeleteSizeConstraintSetAsync(DeleteSizeConstraintSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSqlInjectionMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>SqlInjectionMatchSet</a>. You can't delete a <c>SqlInjectionMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still contains any <a>SqlInjectionMatchTuple</a>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>SqlInjectionMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>SqlInjectionMatchSet</c> from AWS WAF, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>SqlInjectionMatchSet</c> to remove filters, if any. For more information,
        /// see <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <c>SqlInjectionMatchSetId</c> of the <a>SqlInjectionMatchSet</a> that you want to delete. <c>SqlInjectionMatchSetId</c> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the DeleteSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteSqlInjectionMatchSet">REST API Reference for DeleteSqlInjectionMatchSet Operation</seealso>
        DeleteSqlInjectionMatchSetResponse DeleteSqlInjectionMatchSet(string sqlInjectionMatchSetId, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>SqlInjectionMatchSet</a>. You can't delete a <c>SqlInjectionMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still contains any <a>SqlInjectionMatchTuple</a>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>SqlInjectionMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>SqlInjectionMatchSet</c> from AWS WAF, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>SqlInjectionMatchSet</c> to remove filters, if any. For more information,
        /// see <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSqlInjectionMatchSet service method.</param>
        /// 
        /// <returns>The response from the DeleteSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteSqlInjectionMatchSet">REST API Reference for DeleteSqlInjectionMatchSet Operation</seealso>
        DeleteSqlInjectionMatchSetResponse DeleteSqlInjectionMatchSet(DeleteSqlInjectionMatchSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>SqlInjectionMatchSet</a>. You can't delete a <c>SqlInjectionMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still contains any <a>SqlInjectionMatchTuple</a>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>SqlInjectionMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>SqlInjectionMatchSet</c> from AWS WAF, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>SqlInjectionMatchSet</c> to remove filters, if any. For more information,
        /// see <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <c>SqlInjectionMatchSetId</c> of the <a>SqlInjectionMatchSet</a> that you want to delete. <c>SqlInjectionMatchSetId</c> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteSqlInjectionMatchSet">REST API Reference for DeleteSqlInjectionMatchSet Operation</seealso>
        Task<DeleteSqlInjectionMatchSetResponse> DeleteSqlInjectionMatchSetAsync(string sqlInjectionMatchSetId, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>SqlInjectionMatchSet</a>. You can't delete a <c>SqlInjectionMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still contains any <a>SqlInjectionMatchTuple</a>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>SqlInjectionMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>SqlInjectionMatchSet</c> from AWS WAF, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>SqlInjectionMatchSet</c> to remove filters, if any. For more information,
        /// see <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSqlInjectionMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteSqlInjectionMatchSet">REST API Reference for DeleteSqlInjectionMatchSet Operation</seealso>
        Task<DeleteSqlInjectionMatchSetResponse> DeleteSqlInjectionMatchSetAsync(DeleteSqlInjectionMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWebACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>WebACL</a>. You can't delete a <c>WebACL</c> if it still
        /// contains any <c>Rules</c>.
        /// </para>
        ///  
        /// <para>
        /// To delete a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>WebACL</c> to remove <c>Rules</c>, if any. For more information, see
        /// <a>UpdateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="webACLId">The <c>WebACLId</c> of the <a>WebACL</a> that you want to delete. <c>WebACLId</c> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        DeleteWebACLResponse DeleteWebACL(string webACLId, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>WebACL</a>. You can't delete a <c>WebACL</c> if it still
        /// contains any <c>Rules</c>.
        /// </para>
        ///  
        /// <para>
        /// To delete a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>WebACL</c> to remove <c>Rules</c>, if any. For more information, see
        /// <a>UpdateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        DeleteWebACLResponse DeleteWebACL(DeleteWebACLRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>WebACL</a>. You can't delete a <c>WebACL</c> if it still
        /// contains any <c>Rules</c>.
        /// </para>
        ///  
        /// <para>
        /// To delete a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>WebACL</c> to remove <c>Rules</c>, if any. For more information, see
        /// <a>UpdateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="webACLId">The <c>WebACLId</c> of the <a>WebACL</a> that you want to delete. <c>WebACLId</c> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        Task<DeleteWebACLResponse> DeleteWebACLAsync(string webACLId, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>WebACL</a>. You can't delete a <c>WebACL</c> if it still
        /// contains any <c>Rules</c>.
        /// </para>
        ///  
        /// <para>
        /// To delete a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>WebACL</c> to remove <c>Rules</c>, if any. For more information, see
        /// <a>UpdateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        Task<DeleteWebACLResponse> DeleteWebACLAsync(DeleteWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteXssMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an <a>XssMatchSet</a>. You can't delete an <c>XssMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still contains any <a>XssMatchTuple</a>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove an <c>XssMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <c>XssMatchSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>XssMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateXssMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteXssMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteXssMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteXssMatchSet service method.</param>
        /// 
        /// <returns>The response from the DeleteXssMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteXssMatchSet">REST API Reference for DeleteXssMatchSet Operation</seealso>
        DeleteXssMatchSetResponse DeleteXssMatchSet(DeleteXssMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an <a>XssMatchSet</a>. You can't delete an <c>XssMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still contains any <a>XssMatchTuple</a>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove an <c>XssMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <c>XssMatchSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>XssMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateXssMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteXssMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteXssMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteXssMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteXssMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/DeleteXssMatchSet">REST API Reference for DeleteXssMatchSet Operation</seealso>
        Task<DeleteXssMatchSetResponse> DeleteXssMatchSetAsync(DeleteXssMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetByteMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>ByteMatchSet</a> specified by <c>ByteMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="byteMatchSetId">The <c>ByteMatchSetId</c> of the <a>ByteMatchSet</a> that you want to get. <c>ByteMatchSetId</c> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// 
        /// <returns>The response from the GetByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetByteMatchSet">REST API Reference for GetByteMatchSet Operation</seealso>
        GetByteMatchSetResponse GetByteMatchSet(string byteMatchSetId);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>ByteMatchSet</a> specified by <c>ByteMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetByteMatchSet service method.</param>
        /// 
        /// <returns>The response from the GetByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetByteMatchSet">REST API Reference for GetByteMatchSet Operation</seealso>
        GetByteMatchSetResponse GetByteMatchSet(GetByteMatchSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>ByteMatchSet</a> specified by <c>ByteMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="byteMatchSetId">The <c>ByteMatchSetId</c> of the <a>ByteMatchSet</a> that you want to get. <c>ByteMatchSetId</c> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetByteMatchSet">REST API Reference for GetByteMatchSet Operation</seealso>
        Task<GetByteMatchSetResponse> GetByteMatchSetAsync(string byteMatchSetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>ByteMatchSet</a> specified by <c>ByteMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetByteMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetByteMatchSet">REST API Reference for GetByteMatchSet Operation</seealso>
        Task<GetByteMatchSetResponse> GetByteMatchSetAsync(GetByteMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetChangeToken


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// When you want to create, update, or delete AWS WAF objects, get a change token and
        /// include the change token in the create, update, or delete request. Change tokens ensure
        /// that your application doesn't submit conflicting requests to AWS WAF.
        /// </para>
        ///  
        /// <para>
        /// Each create, update, or delete request must use a unique change token. If your application
        /// submits a <c>GetChangeToken</c> request and then submits a second <c>GetChangeToken</c>
        /// request before submitting a create, update, or delete request, the second <c>GetChangeToken</c>
        /// request returns the same value as the first <c>GetChangeToken</c> request.
        /// </para>
        ///  
        /// <para>
        /// When you use a change token in a create, update, or delete request, the status of
        /// the change token changes to <c>PENDING</c>, which indicates that AWS WAF is propagating
        /// the change to all AWS WAF servers. Use <c>GetChangeTokenStatus</c> to determine the
        /// status of your change token.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetChangeToken service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetChangeToken">REST API Reference for GetChangeToken Operation</seealso>
        GetChangeTokenResponse GetChangeToken();


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// When you want to create, update, or delete AWS WAF objects, get a change token and
        /// include the change token in the create, update, or delete request. Change tokens ensure
        /// that your application doesn't submit conflicting requests to AWS WAF.
        /// </para>
        ///  
        /// <para>
        /// Each create, update, or delete request must use a unique change token. If your application
        /// submits a <c>GetChangeToken</c> request and then submits a second <c>GetChangeToken</c>
        /// request before submitting a create, update, or delete request, the second <c>GetChangeToken</c>
        /// request returns the same value as the first <c>GetChangeToken</c> request.
        /// </para>
        ///  
        /// <para>
        /// When you use a change token in a create, update, or delete request, the status of
        /// the change token changes to <c>PENDING</c>, which indicates that AWS WAF is propagating
        /// the change to all AWS WAF servers. Use <c>GetChangeTokenStatus</c> to determine the
        /// status of your change token.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeToken service method.</param>
        /// 
        /// <returns>The response from the GetChangeToken service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetChangeToken">REST API Reference for GetChangeToken Operation</seealso>
        GetChangeTokenResponse GetChangeToken(GetChangeTokenRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// When you want to create, update, or delete AWS WAF objects, get a change token and
        /// include the change token in the create, update, or delete request. Change tokens ensure
        /// that your application doesn't submit conflicting requests to AWS WAF.
        /// </para>
        ///  
        /// <para>
        /// Each create, update, or delete request must use a unique change token. If your application
        /// submits a <c>GetChangeToken</c> request and then submits a second <c>GetChangeToken</c>
        /// request before submitting a create, update, or delete request, the second <c>GetChangeToken</c>
        /// request returns the same value as the first <c>GetChangeToken</c> request.
        /// </para>
        ///  
        /// <para>
        /// When you use a change token in a create, update, or delete request, the status of
        /// the change token changes to <c>PENDING</c>, which indicates that AWS WAF is propagating
        /// the change to all AWS WAF servers. Use <c>GetChangeTokenStatus</c> to determine the
        /// status of your change token.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChangeToken service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetChangeToken">REST API Reference for GetChangeToken Operation</seealso>
        Task<GetChangeTokenResponse> GetChangeTokenAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// When you want to create, update, or delete AWS WAF objects, get a change token and
        /// include the change token in the create, update, or delete request. Change tokens ensure
        /// that your application doesn't submit conflicting requests to AWS WAF.
        /// </para>
        ///  
        /// <para>
        /// Each create, update, or delete request must use a unique change token. If your application
        /// submits a <c>GetChangeToken</c> request and then submits a second <c>GetChangeToken</c>
        /// request before submitting a create, update, or delete request, the second <c>GetChangeToken</c>
        /// request returns the same value as the first <c>GetChangeToken</c> request.
        /// </para>
        ///  
        /// <para>
        /// When you use a change token in a create, update, or delete request, the status of
        /// the change token changes to <c>PENDING</c>, which indicates that AWS WAF is propagating
        /// the change to all AWS WAF servers. Use <c>GetChangeTokenStatus</c> to determine the
        /// status of your change token.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChangeToken service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetChangeToken">REST API Reference for GetChangeToken Operation</seealso>
        Task<GetChangeTokenResponse> GetChangeTokenAsync(GetChangeTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetChangeTokenStatus


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the status of a <c>ChangeToken</c> that you got by calling <a>GetChangeToken</a>.
        /// <c>ChangeTokenStatus</c> is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONED</c>: You requested the change token by calling <c>GetChangeToken</c>,
        /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c>: AWS WAF is propagating the create, update, or delete request to all
        /// AWS WAF servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSYNC</c>: Propagation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="changeToken">The change token for which you want to get the status. This change token was previously returned in the <c>GetChangeToken</c> response.</param>
        /// 
        /// <returns>The response from the GetChangeTokenStatus service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetChangeTokenStatus">REST API Reference for GetChangeTokenStatus Operation</seealso>
        GetChangeTokenStatusResponse GetChangeTokenStatus(string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the status of a <c>ChangeToken</c> that you got by calling <a>GetChangeToken</a>.
        /// <c>ChangeTokenStatus</c> is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONED</c>: You requested the change token by calling <c>GetChangeToken</c>,
        /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c>: AWS WAF is propagating the create, update, or delete request to all
        /// AWS WAF servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSYNC</c>: Propagation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeTokenStatus service method.</param>
        /// 
        /// <returns>The response from the GetChangeTokenStatus service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetChangeTokenStatus">REST API Reference for GetChangeTokenStatus Operation</seealso>
        GetChangeTokenStatusResponse GetChangeTokenStatus(GetChangeTokenStatusRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the status of a <c>ChangeToken</c> that you got by calling <a>GetChangeToken</a>.
        /// <c>ChangeTokenStatus</c> is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONED</c>: You requested the change token by calling <c>GetChangeToken</c>,
        /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c>: AWS WAF is propagating the create, update, or delete request to all
        /// AWS WAF servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSYNC</c>: Propagation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="changeToken">The change token for which you want to get the status. This change token was previously returned in the <c>GetChangeToken</c> response.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChangeTokenStatus service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetChangeTokenStatus">REST API Reference for GetChangeTokenStatus Operation</seealso>
        Task<GetChangeTokenStatusResponse> GetChangeTokenStatusAsync(string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the status of a <c>ChangeToken</c> that you got by calling <a>GetChangeToken</a>.
        /// <c>ChangeTokenStatus</c> is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONED</c>: You requested the change token by calling <c>GetChangeToken</c>,
        /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c>: AWS WAF is propagating the create, update, or delete request to all
        /// AWS WAF servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSYNC</c>: Propagation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeTokenStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChangeTokenStatus service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetChangeTokenStatus">REST API Reference for GetChangeTokenStatus Operation</seealso>
        Task<GetChangeTokenStatusResponse> GetChangeTokenStatusAsync(GetChangeTokenStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGeoMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>GeoMatchSet</a> that is specified by <c>GeoMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeoMatchSet service method.</param>
        /// 
        /// <returns>The response from the GetGeoMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetGeoMatchSet">REST API Reference for GetGeoMatchSet Operation</seealso>
        GetGeoMatchSetResponse GetGeoMatchSet(GetGeoMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>GeoMatchSet</a> that is specified by <c>GeoMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeoMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGeoMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetGeoMatchSet">REST API Reference for GetGeoMatchSet Operation</seealso>
        Task<GetGeoMatchSetResponse> GetGeoMatchSetAsync(GetGeoMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIPSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>IPSet</a> that is specified by <c>IPSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="ipSetId">The <c>IPSetId</c> of the <a>IPSet</a> that you want to get. <c>IPSetId</c> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        GetIPSetResponse GetIPSet(string ipSetId);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>IPSet</a> that is specified by <c>IPSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        GetIPSetResponse GetIPSet(GetIPSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>IPSet</a> that is specified by <c>IPSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="ipSetId">The <c>IPSetId</c> of the <a>IPSet</a> that you want to get. <c>IPSetId</c> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        Task<GetIPSetResponse> GetIPSetAsync(string ipSetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>IPSet</a> that is specified by <c>IPSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        Task<GetIPSetResponse> GetIPSetAsync(GetIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLoggingConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>LoggingConfiguration</a> for the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLoggingConfiguration service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        GetLoggingConfigurationResponse GetLoggingConfiguration(GetLoggingConfigurationRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
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
        /// <returns>The response from the GetLoggingConfiguration service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        Task<GetLoggingConfigurationResponse> GetLoggingConfigurationAsync(GetLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPermissionPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the IAM policy attached to the RuleGroup.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPermissionPolicy service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        GetPermissionPolicyResponse GetPermissionPolicy(GetPermissionPolicyRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the IAM policy attached to the RuleGroup.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPermissionPolicy service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        Task<GetPermissionPolicyResponse> GetPermissionPolicyAsync(GetPermissionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRateBasedRule


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RateBasedRule</a> that is specified by the <c>RuleId</c> that you included
        /// in the <c>GetRateBasedRule</c> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedRule service method.</param>
        /// 
        /// <returns>The response from the GetRateBasedRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRateBasedRule">REST API Reference for GetRateBasedRule Operation</seealso>
        GetRateBasedRuleResponse GetRateBasedRule(GetRateBasedRuleRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RateBasedRule</a> that is specified by the <c>RuleId</c> that you included
        /// in the <c>GetRateBasedRule</c> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRateBasedRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRateBasedRule">REST API Reference for GetRateBasedRule Operation</seealso>
        Task<GetRateBasedRuleResponse> GetRateBasedRuleAsync(GetRateBasedRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRateBasedRuleManagedKeys


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of IP addresses currently being blocked by the <a>RateBasedRule</a>
        /// that is specified by the <c>RuleId</c>. The maximum number of managed keys that will
        /// be blocked is 10,000. If more than 10,000 addresses exceed the rate limit, the 10,000
        /// addresses with the highest rates will be blocked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedRuleManagedKeys service method.</param>
        /// 
        /// <returns>The response from the GetRateBasedRuleManagedKeys service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRateBasedRuleManagedKeys">REST API Reference for GetRateBasedRuleManagedKeys Operation</seealso>
        GetRateBasedRuleManagedKeysResponse GetRateBasedRuleManagedKeys(GetRateBasedRuleManagedKeysRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of IP addresses currently being blocked by the <a>RateBasedRule</a>
        /// that is specified by the <c>RuleId</c>. The maximum number of managed keys that will
        /// be blocked is 10,000. If more than 10,000 addresses exceed the rate limit, the 10,000
        /// addresses with the highest rates will be blocked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedRuleManagedKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRateBasedRuleManagedKeys service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRateBasedRuleManagedKeys">REST API Reference for GetRateBasedRuleManagedKeys Operation</seealso>
        Task<GetRateBasedRuleManagedKeysResponse> GetRateBasedRuleManagedKeysAsync(GetRateBasedRuleManagedKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRegexMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RegexMatchSet</a> specified by <c>RegexMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexMatchSet service method.</param>
        /// 
        /// <returns>The response from the GetRegexMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRegexMatchSet">REST API Reference for GetRegexMatchSet Operation</seealso>
        GetRegexMatchSetResponse GetRegexMatchSet(GetRegexMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RegexMatchSet</a> specified by <c>RegexMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegexMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRegexMatchSet">REST API Reference for GetRegexMatchSet Operation</seealso>
        Task<GetRegexMatchSetResponse> GetRegexMatchSetAsync(GetRegexMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRegexPatternSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RegexPatternSet</a> specified by <c>RegexPatternSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the GetRegexPatternSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        GetRegexPatternSetResponse GetRegexPatternSet(GetRegexPatternSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RegexPatternSet</a> specified by <c>RegexPatternSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegexPatternSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        Task<GetRegexPatternSetResponse> GetRegexPatternSetAsync(GetRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRule


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>Rule</a> that is specified by the <c>RuleId</c> that you included in
        /// the <c>GetRule</c> request.
        /// </para>
        /// </summary>
        /// <param name="ruleId">The <c>RuleId</c> of the <a>Rule</a> that you want to get. <c>RuleId</c> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRule">REST API Reference for GetRule Operation</seealso>
        GetRuleResponse GetRule(string ruleId);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>Rule</a> that is specified by the <c>RuleId</c> that you included in
        /// the <c>GetRule</c> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRule">REST API Reference for GetRule Operation</seealso>
        GetRuleResponse GetRule(GetRuleRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>Rule</a> that is specified by the <c>RuleId</c> that you included in
        /// the <c>GetRule</c> request.
        /// </para>
        /// </summary>
        /// <param name="ruleId">The <c>RuleId</c> of the <a>Rule</a> that you want to get. <c>RuleId</c> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRule">REST API Reference for GetRule Operation</seealso>
        Task<GetRuleResponse> GetRuleAsync(string ruleId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>Rule</a> that is specified by the <c>RuleId</c> that you included in
        /// the <c>GetRule</c> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRule">REST API Reference for GetRule Operation</seealso>
        Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRuleGroup


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RuleGroup</a> that is specified by the <c>RuleGroupId</c> that you
        /// included in the <c>GetRuleGroup</c> request.
        /// </para>
        ///  
        /// <para>
        /// To view the rules in a rule group, use <a>ListActivatedRulesInRuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup service method.</param>
        /// 
        /// <returns>The response from the GetRuleGroup service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        GetRuleGroupResponse GetRuleGroup(GetRuleGroupRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RuleGroup</a> that is specified by the <c>RuleGroupId</c> that you
        /// included in the <c>GetRuleGroup</c> request.
        /// </para>
        ///  
        /// <para>
        /// To view the rules in a rule group, use <a>ListActivatedRulesInRuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRuleGroup service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        Task<GetRuleGroupResponse> GetRuleGroupAsync(GetRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSampledRequests


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
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
        ///  <c>GetSampledRequests</c> returns a time range, which is usually the time range that
        /// you specified. However, if your resource (such as a CloudFront distribution) received
        /// 5,000 requests before the specified time range elapsed, <c>GetSampledRequests</c>
        /// returns an updated time range. This new time range indicates the actual period during
        /// which AWS WAF selected the requests in the sample.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests service method.</param>
        /// 
        /// <returns>The response from the GetSampledRequests service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        GetSampledRequestsResponse GetSampledRequests(GetSampledRequestsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
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
        ///  <c>GetSampledRequests</c> returns a time range, which is usually the time range that
        /// you specified. However, if your resource (such as a CloudFront distribution) received
        /// 5,000 requests before the specified time range elapsed, <c>GetSampledRequests</c>
        /// returns an updated time range. This new time range indicates the actual period during
        /// which AWS WAF selected the requests in the sample.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSampledRequests service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        Task<GetSampledRequestsResponse> GetSampledRequestsAsync(GetSampledRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSizeConstraintSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>SizeConstraintSet</a> specified by <c>SizeConstraintSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSizeConstraintSet service method.</param>
        /// 
        /// <returns>The response from the GetSizeConstraintSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetSizeConstraintSet">REST API Reference for GetSizeConstraintSet Operation</seealso>
        GetSizeConstraintSetResponse GetSizeConstraintSet(GetSizeConstraintSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>SizeConstraintSet</a> specified by <c>SizeConstraintSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSizeConstraintSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSizeConstraintSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetSizeConstraintSet">REST API Reference for GetSizeConstraintSet Operation</seealso>
        Task<GetSizeConstraintSetResponse> GetSizeConstraintSetAsync(GetSizeConstraintSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSqlInjectionMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <c>SqlInjectionMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <c>SqlInjectionMatchSetId</c> of the <a>SqlInjectionMatchSet</a> that you want to get. <c>SqlInjectionMatchSetId</c> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// 
        /// <returns>The response from the GetSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetSqlInjectionMatchSet">REST API Reference for GetSqlInjectionMatchSet Operation</seealso>
        GetSqlInjectionMatchSetResponse GetSqlInjectionMatchSet(string sqlInjectionMatchSetId);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <c>SqlInjectionMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSqlInjectionMatchSet service method.</param>
        /// 
        /// <returns>The response from the GetSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetSqlInjectionMatchSet">REST API Reference for GetSqlInjectionMatchSet Operation</seealso>
        GetSqlInjectionMatchSetResponse GetSqlInjectionMatchSet(GetSqlInjectionMatchSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <c>SqlInjectionMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <c>SqlInjectionMatchSetId</c> of the <a>SqlInjectionMatchSet</a> that you want to get. <c>SqlInjectionMatchSetId</c> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetSqlInjectionMatchSet">REST API Reference for GetSqlInjectionMatchSet Operation</seealso>
        Task<GetSqlInjectionMatchSetResponse> GetSqlInjectionMatchSetAsync(string sqlInjectionMatchSetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <c>SqlInjectionMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSqlInjectionMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetSqlInjectionMatchSet">REST API Reference for GetSqlInjectionMatchSet Operation</seealso>
        Task<GetSqlInjectionMatchSetResponse> GetSqlInjectionMatchSetAsync(GetSqlInjectionMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWebACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>WebACL</a> that is specified by <c>WebACLId</c>.
        /// </para>
        /// </summary>
        /// <param name="webACLId">The <c>WebACLId</c> of the <a>WebACL</a> that you want to get. <c>WebACLId</c> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        GetWebACLResponse GetWebACL(string webACLId);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>WebACL</a> that is specified by <c>WebACLId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        GetWebACLResponse GetWebACL(GetWebACLRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>WebACL</a> that is specified by <c>WebACLId</c>.
        /// </para>
        /// </summary>
        /// <param name="webACLId">The <c>WebACLId</c> of the <a>WebACL</a> that you want to get. <c>WebACLId</c> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        Task<GetWebACLResponse> GetWebACLAsync(string webACLId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>WebACL</a> that is specified by <c>WebACLId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        Task<GetWebACLResponse> GetWebACLAsync(GetWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetXssMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>XssMatchSet</a> that is specified by <c>XssMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetXssMatchSet service method.</param>
        /// 
        /// <returns>The response from the GetXssMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetXssMatchSet">REST API Reference for GetXssMatchSet Operation</seealso>
        GetXssMatchSetResponse GetXssMatchSet(GetXssMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>XssMatchSet</a> that is specified by <c>XssMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetXssMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetXssMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/GetXssMatchSet">REST API Reference for GetXssMatchSet Operation</seealso>
        Task<GetXssMatchSetResponse> GetXssMatchSetAsync(GetXssMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListActivatedRulesInRuleGroup


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>ActivatedRule</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActivatedRulesInRuleGroup service method.</param>
        /// 
        /// <returns>The response from the ListActivatedRulesInRuleGroup service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListActivatedRulesInRuleGroup">REST API Reference for ListActivatedRulesInRuleGroup Operation</seealso>
        ListActivatedRulesInRuleGroupResponse ListActivatedRulesInRuleGroup(ListActivatedRulesInRuleGroupRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>ActivatedRule</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActivatedRulesInRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActivatedRulesInRuleGroup service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListActivatedRulesInRuleGroup">REST API Reference for ListActivatedRulesInRuleGroup Operation</seealso>
        Task<ListActivatedRulesInRuleGroupResponse> ListActivatedRulesInRuleGroupAsync(ListActivatedRulesInRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListByteMatchSets


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>ByteMatchSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListByteMatchSets service method.</param>
        /// 
        /// <returns>The response from the ListByteMatchSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListByteMatchSets">REST API Reference for ListByteMatchSets Operation</seealso>
        ListByteMatchSetsResponse ListByteMatchSets(ListByteMatchSetsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>ByteMatchSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListByteMatchSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListByteMatchSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListByteMatchSets">REST API Reference for ListByteMatchSets Operation</seealso>
        Task<ListByteMatchSetsResponse> ListByteMatchSetsAsync(ListByteMatchSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGeoMatchSets


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>GeoMatchSetSummary</a> objects in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeoMatchSets service method.</param>
        /// 
        /// <returns>The response from the ListGeoMatchSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListGeoMatchSets">REST API Reference for ListGeoMatchSets Operation</seealso>
        ListGeoMatchSetsResponse ListGeoMatchSets(ListGeoMatchSetsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>GeoMatchSetSummary</a> objects in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeoMatchSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeoMatchSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListGeoMatchSets">REST API Reference for ListGeoMatchSets Operation</seealso>
        Task<ListGeoMatchSetsResponse> ListGeoMatchSetsAsync(ListGeoMatchSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIPSets


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>IPSetSummary</a> objects in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        ListIPSetsResponse ListIPSets(ListIPSetsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>IPSetSummary</a> objects in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        Task<ListIPSetsResponse> ListIPSetsAsync(ListIPSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLoggingConfigurations


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>LoggingConfiguration</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListLoggingConfigurations service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        ListLoggingConfigurationsResponse ListLoggingConfigurations(ListLoggingConfigurationsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>LoggingConfiguration</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLoggingConfigurations service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        Task<ListLoggingConfigurationsResponse> ListLoggingConfigurationsAsync(ListLoggingConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRateBasedRules


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRateBasedRules service method.</param>
        /// 
        /// <returns>The response from the ListRateBasedRules service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListRateBasedRules">REST API Reference for ListRateBasedRules Operation</seealso>
        ListRateBasedRulesResponse ListRateBasedRules(ListRateBasedRulesRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRateBasedRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRateBasedRules service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListRateBasedRules">REST API Reference for ListRateBasedRules Operation</seealso>
        Task<ListRateBasedRulesResponse> ListRateBasedRulesAsync(ListRateBasedRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRegexMatchSets


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RegexMatchSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexMatchSets service method.</param>
        /// 
        /// <returns>The response from the ListRegexMatchSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListRegexMatchSets">REST API Reference for ListRegexMatchSets Operation</seealso>
        ListRegexMatchSetsResponse ListRegexMatchSets(ListRegexMatchSetsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RegexMatchSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexMatchSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegexMatchSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListRegexMatchSets">REST API Reference for ListRegexMatchSets Operation</seealso>
        Task<ListRegexMatchSetsResponse> ListRegexMatchSetsAsync(ListRegexMatchSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRegexPatternSets


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RegexPatternSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets service method.</param>
        /// 
        /// <returns>The response from the ListRegexPatternSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        ListRegexPatternSetsResponse ListRegexPatternSets(ListRegexPatternSetsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RegexPatternSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegexPatternSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        Task<ListRegexPatternSetsResponse> ListRegexPatternSetsAsync(ListRegexPatternSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRuleGroups


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleGroup</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleGroup</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        Task<ListRuleGroupsResponse> ListRuleGroupsAsync(ListRuleGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRules


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse ListRules(ListRulesRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListRules">REST API Reference for ListRules Operation</seealso>
        Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSizeConstraintSets


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>SizeConstraintSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSizeConstraintSets service method.</param>
        /// 
        /// <returns>The response from the ListSizeConstraintSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListSizeConstraintSets">REST API Reference for ListSizeConstraintSets Operation</seealso>
        ListSizeConstraintSetsResponse ListSizeConstraintSets(ListSizeConstraintSetsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>SizeConstraintSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSizeConstraintSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSizeConstraintSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListSizeConstraintSets">REST API Reference for ListSizeConstraintSets Operation</seealso>
        Task<ListSizeConstraintSetsResponse> ListSizeConstraintSetsAsync(ListSizeConstraintSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSqlInjectionMatchSets


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>SqlInjectionMatchSet</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSqlInjectionMatchSets service method.</param>
        /// 
        /// <returns>The response from the ListSqlInjectionMatchSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListSqlInjectionMatchSets">REST API Reference for ListSqlInjectionMatchSets Operation</seealso>
        ListSqlInjectionMatchSetsResponse ListSqlInjectionMatchSets(ListSqlInjectionMatchSetsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>SqlInjectionMatchSet</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSqlInjectionMatchSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSqlInjectionMatchSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListSqlInjectionMatchSets">REST API Reference for ListSqlInjectionMatchSets Operation</seealso>
        Task<ListSqlInjectionMatchSetsResponse> ListSqlInjectionMatchSetsAsync(ListSqlInjectionMatchSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSubscribedRuleGroups


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleGroup</a> objects that you are subscribed to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListSubscribedRuleGroups service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListSubscribedRuleGroups">REST API Reference for ListSubscribedRuleGroups Operation</seealso>
        ListSubscribedRuleGroupsResponse ListSubscribedRuleGroups(ListSubscribedRuleGroupsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleGroup</a> objects that you are subscribed to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscribedRuleGroups service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListSubscribedRuleGroups">REST API Reference for ListSubscribedRuleGroups Operation</seealso>
        Task<ListSubscribedRuleGroupsResponse> ListSubscribedRuleGroupsAsync(ListSubscribedRuleGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the tags associated with the specified AWS resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each AWS resource,
        /// up to 50 tags for a resource.
        /// </para>
        ///  
        /// <para>
        /// Tagging is only available through the API, SDKs, and CLI. You can't manage or view
        /// tags through the AWS WAF Classic console. You can tag the AWS resources that you manage
        /// through AWS WAF Classic: web ACLs, rule groups, and rules. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the tags associated with the specified AWS resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each AWS resource,
        /// up to 50 tags for a resource.
        /// </para>
        ///  
        /// <para>
        /// Tagging is only available through the API, SDKs, and CLI. You can't manage or view
        /// tags through the AWS WAF Classic console. You can tag the AWS resources that you manage
        /// through AWS WAF Classic: web ACLs, rule groups, and rules. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWebACLs


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>WebACLSummary</a> objects in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
        /// 
        /// <returns>The response from the ListWebACLs service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        ListWebACLsResponse ListWebACLs(ListWebACLsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>WebACLSummary</a> objects in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebACLs service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        Task<ListWebACLsResponse> ListWebACLsAsync(ListWebACLsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListXssMatchSets


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>XssMatchSet</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListXssMatchSets service method.</param>
        /// 
        /// <returns>The response from the ListXssMatchSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListXssMatchSets">REST API Reference for ListXssMatchSets Operation</seealso>
        ListXssMatchSetsResponse ListXssMatchSets(ListXssMatchSetsRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>XssMatchSet</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListXssMatchSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListXssMatchSets service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/ListXssMatchSets">REST API Reference for ListXssMatchSets Operation</seealso>
        Task<ListXssMatchSetsResponse> ListXssMatchSetsAsync(ListXssMatchSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLoggingConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates a <a>LoggingConfiguration</a> with a specified web ACL.
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
        /// Create the data firehose with a PUT source and in the region that you are operating.
        /// However, if you are capturing logs for Amazon CloudFront, always create the firehose
        /// in US East (N. Virginia). 
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not create the data firehose using a <c>Kinesis stream</c> as your source.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Associate that firehose to your web ACL using a <c>PutLoggingConfiguration</c> request.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you successfully enable logging using a <c>PutLoggingConfiguration</c> request,
        /// AWS WAF will create a service linked role with the necessary permissions to write
        /// logs to the Amazon Kinesis Data Firehose. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// Web ACL Traffic Information</a> in the <i>AWS WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutLoggingConfiguration service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFServiceLinkedRoleErrorException">
        /// AWS WAF is not able to access the service linked role. This can be caused by a previous
        /// <c>PutLoggingConfiguration</c> request, which can lock the service linked role for
        /// about 20 seconds. Please try your request again. The service linked role can also
        /// be locked by a previous <c>DeleteServiceLinkedRole</c> request, which can lock the
        /// role for 15 minutes or more. If you recently made a <c>DeleteServiceLinkedRole</c>,
        /// wait at least 15 minutes and try the request again. If you receive this same exception
        /// again, you will have to wait additional time until the role is unlocked.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        PutLoggingConfigurationResponse PutLoggingConfiguration(PutLoggingConfigurationRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates a <a>LoggingConfiguration</a> with a specified web ACL.
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
        /// Create the data firehose with a PUT source and in the region that you are operating.
        /// However, if you are capturing logs for Amazon CloudFront, always create the firehose
        /// in US East (N. Virginia). 
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not create the data firehose using a <c>Kinesis stream</c> as your source.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Associate that firehose to your web ACL using a <c>PutLoggingConfiguration</c> request.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you successfully enable logging using a <c>PutLoggingConfiguration</c> request,
        /// AWS WAF will create a service linked role with the necessary permissions to write
        /// logs to the Amazon Kinesis Data Firehose. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// Web ACL Traffic Information</a> in the <i>AWS WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLoggingConfiguration service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFServiceLinkedRoleErrorException">
        /// AWS WAF is not able to access the service linked role. This can be caused by a previous
        /// <c>PutLoggingConfiguration</c> request, which can lock the service linked role for
        /// about 20 seconds. Please try your request again. The service linked role can also
        /// be locked by a previous <c>DeleteServiceLinkedRole</c> request, which can lock the
        /// role for 15 minutes or more. If you recently made a <c>DeleteServiceLinkedRole</c>,
        /// wait at least 15 minutes and try the request again. If you receive this same exception
        /// again, you will have to wait additional time until the role is unlocked.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        Task<PutLoggingConfigurationResponse> PutLoggingConfigurationAsync(PutLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutPermissionPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Attaches an IAM policy to the specified resource. The only supported use for this
        /// action is to share a RuleGroup across accounts.
        /// </para>
        ///  
        /// <para>
        /// The <c>PutPermissionPolicy</c> is subject to the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can attach only one policy with each <c>PutPermissionPolicy</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include an <c>Effect</c>, <c>Action</c> and <c>Principal</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Effect</c> must specify <c>Allow</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Action</c> in the policy must be <c>waf:UpdateWebACL</c>, <c>waf-regional:UpdateWebACL</c>,
        /// <c>waf:GetRuleGroup</c> and <c>waf-regional:GetRuleGroup</c> . Any extra or wildcard
        /// actions in the policy will be rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy cannot include a <c>Resource</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF RuleGroup ARN and the RuleGroup must exist
        /// in the same region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user making the request must be the owner of the RuleGroup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your policy must be composed using IAM Policy version 2012-10-17.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// An example of a valid policy parameter is shown in the Examples section below.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionPolicy service method.</param>
        /// 
        /// <returns>The response from the PutPermissionPolicy service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidPermissionPolicyException">
        /// The operation failed because the specified policy is not in the proper format. 
        /// 
        ///  
        /// <para>
        /// The policy is subject to the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can attach only one policy with each <c>PutPermissionPolicy</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include an <c>Effect</c>, <c>Action</c> and <c>Principal</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Effect</c> must specify <c>Allow</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Action</c> in the policy must be <c>waf:UpdateWebACL</c>, <c>waf-regional:UpdateWebACL</c>,
        /// <c>waf:GetRuleGroup</c> and <c>waf-regional:GetRuleGroup</c> . Any extra or wildcard
        /// actions in the policy will be rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy cannot include a <c>Resource</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF RuleGroup ARN and the RuleGroup must exist
        /// in the same region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user making the request must be the owner of the RuleGroup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your policy must be composed using IAM Policy version 2012-10-17.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        PutPermissionPolicyResponse PutPermissionPolicy(PutPermissionPolicyRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Attaches an IAM policy to the specified resource. The only supported use for this
        /// action is to share a RuleGroup across accounts.
        /// </para>
        ///  
        /// <para>
        /// The <c>PutPermissionPolicy</c> is subject to the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can attach only one policy with each <c>PutPermissionPolicy</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include an <c>Effect</c>, <c>Action</c> and <c>Principal</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Effect</c> must specify <c>Allow</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Action</c> in the policy must be <c>waf:UpdateWebACL</c>, <c>waf-regional:UpdateWebACL</c>,
        /// <c>waf:GetRuleGroup</c> and <c>waf-regional:GetRuleGroup</c> . Any extra or wildcard
        /// actions in the policy will be rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy cannot include a <c>Resource</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF RuleGroup ARN and the RuleGroup must exist
        /// in the same region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user making the request must be the owner of the RuleGroup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your policy must be composed using IAM Policy version 2012-10-17.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// An example of a valid policy parameter is shown in the Examples section below.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPermissionPolicy service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidPermissionPolicyException">
        /// The operation failed because the specified policy is not in the proper format. 
        /// 
        ///  
        /// <para>
        /// The policy is subject to the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can attach only one policy with each <c>PutPermissionPolicy</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include an <c>Effect</c>, <c>Action</c> and <c>Principal</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Effect</c> must specify <c>Allow</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Action</c> in the policy must be <c>waf:UpdateWebACL</c>, <c>waf-regional:UpdateWebACL</c>,
        /// <c>waf:GetRuleGroup</c> and <c>waf-regional:GetRuleGroup</c> . Any extra or wildcard
        /// actions in the policy will be rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy cannot include a <c>Resource</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF RuleGroup ARN and the RuleGroup must exist
        /// in the same region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user making the request must be the owner of the RuleGroup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your policy must be composed using IAM Policy version 2012-10-17.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        Task<PutPermissionPolicyResponse> PutPermissionPolicyAsync(PutPermissionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
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
        /// Tagging is only available through the API, SDKs, and CLI. You can't manage or view
        /// tags through the AWS WAF Classic console. You can use this action to tag the AWS resources
        /// that you manage through AWS WAF Classic: web ACLs, rule groups, and rules. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
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
        /// Tagging is only available through the API, SDKs, and CLI. You can't manage or view
        /// tags through the AWS WAF Classic console. You can use this action to tag the AWS resources
        /// that you manage through AWS WAF Classic: web ACLs, rule groups, and rules. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateByteMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
        /// For each <c>ByteMatchTuple</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>ByteMatchSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <c>User-Agent</c> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bytes (typically a string that corresponds with ASCII characters) that you want
        /// AWS WAF to look for. For more information, including how you specify the values for
        /// the AWS WAF API and the AWS CLI or SDKs, see <c>TargetString</c> in the <a>ByteMatchTuple</a>
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
        /// For example, you can add a <c>ByteMatchSetUpdate</c> object that matches web requests
        /// in which <c>User-Agent</c> headers contain the string <c>BadBot</c>. You can then
        /// configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>ByteMatchSet.</c> For more information, see <a>CreateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateByteMatchSet</c> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
        /// you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="byteMatchSetId">The <c>ByteMatchSetId</c> of the <a>ByteMatchSet</a> that you want to update. <c>ByteMatchSetId</c> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="updates">An array of <c>ByteMatchSetUpdate</c> objects that you want to insert into or delete from a <a>ByteMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>ByteMatchSetUpdate</a>: Contains <c>Action</c> and <c>ByteMatchTuple</c>  </li> <li>  <a>ByteMatchTuple</a>: Contains <c>FieldToMatch</c>, <c>PositionalConstraint</c>, <c>TargetString</c>, and <c>TextTransformation</c>  </li> <li>  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the UpdateByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateByteMatchSet">REST API Reference for UpdateByteMatchSet Operation</seealso>
        UpdateByteMatchSetResponse UpdateByteMatchSet(string byteMatchSetId, List<ByteMatchSetUpdate> updates, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
        /// For each <c>ByteMatchTuple</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>ByteMatchSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <c>User-Agent</c> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bytes (typically a string that corresponds with ASCII characters) that you want
        /// AWS WAF to look for. For more information, including how you specify the values for
        /// the AWS WAF API and the AWS CLI or SDKs, see <c>TargetString</c> in the <a>ByteMatchTuple</a>
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
        /// For example, you can add a <c>ByteMatchSetUpdate</c> object that matches web requests
        /// in which <c>User-Agent</c> headers contain the string <c>BadBot</c>. You can then
        /// configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>ByteMatchSet.</c> For more information, see <a>CreateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateByteMatchSet</c> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
        /// you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateByteMatchSet service method.</param>
        /// 
        /// <returns>The response from the UpdateByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateByteMatchSet">REST API Reference for UpdateByteMatchSet Operation</seealso>
        UpdateByteMatchSetResponse UpdateByteMatchSet(UpdateByteMatchSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
        /// For each <c>ByteMatchTuple</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>ByteMatchSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <c>User-Agent</c> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bytes (typically a string that corresponds with ASCII characters) that you want
        /// AWS WAF to look for. For more information, including how you specify the values for
        /// the AWS WAF API and the AWS CLI or SDKs, see <c>TargetString</c> in the <a>ByteMatchTuple</a>
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
        /// For example, you can add a <c>ByteMatchSetUpdate</c> object that matches web requests
        /// in which <c>User-Agent</c> headers contain the string <c>BadBot</c>. You can then
        /// configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>ByteMatchSet.</c> For more information, see <a>CreateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateByteMatchSet</c> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
        /// you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="byteMatchSetId">The <c>ByteMatchSetId</c> of the <a>ByteMatchSet</a> that you want to update. <c>ByteMatchSetId</c> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="updates">An array of <c>ByteMatchSetUpdate</c> objects that you want to insert into or delete from a <a>ByteMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>ByteMatchSetUpdate</a>: Contains <c>Action</c> and <c>ByteMatchTuple</c>  </li> <li>  <a>ByteMatchTuple</a>: Contains <c>FieldToMatch</c>, <c>PositionalConstraint</c>, <c>TargetString</c>, and <c>TextTransformation</c>  </li> <li>  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateByteMatchSet">REST API Reference for UpdateByteMatchSet Operation</seealso>
        Task<UpdateByteMatchSetResponse> UpdateByteMatchSetAsync(string byteMatchSetId, List<ByteMatchSetUpdate> updates, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
        /// For each <c>ByteMatchTuple</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>ByteMatchSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <c>User-Agent</c> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bytes (typically a string that corresponds with ASCII characters) that you want
        /// AWS WAF to look for. For more information, including how you specify the values for
        /// the AWS WAF API and the AWS CLI or SDKs, see <c>TargetString</c> in the <a>ByteMatchTuple</a>
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
        /// For example, you can add a <c>ByteMatchSetUpdate</c> object that matches web requests
        /// in which <c>User-Agent</c> headers contain the string <c>BadBot</c>. You can then
        /// configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>ByteMatchSet.</c> For more information, see <a>CreateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateByteMatchSet</c> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
        /// you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateByteMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateByteMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateByteMatchSet">REST API Reference for UpdateByteMatchSet Operation</seealso>
        Task<UpdateByteMatchSetResponse> UpdateByteMatchSetAsync(UpdateByteMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGeoMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>GeoMatchConstraint</a> objects in an <c>GeoMatchSet</c>. For
        /// each <c>GeoMatchConstraint</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <c>GeoMatchConstraint</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Type</c>. The only valid value for <c>Type</c> is <c>Country</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Value</c>, which is a two character code for the country to add to the <c>GeoMatchConstraint</c>
        /// object. Valid codes are listed in <a>GeoMatchConstraint$Value</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure an <c>GeoMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateGeoMatchSet</c> request to specify the country that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <c>GeoMatchSet</c>, you specify the country that you want to add
        /// and/or the country that you want to delete. If you want to change a country, you delete
        /// the existing country and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeoMatchSet service method.</param>
        /// 
        /// <returns>The response from the UpdateGeoMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateGeoMatchSet">REST API Reference for UpdateGeoMatchSet Operation</seealso>
        UpdateGeoMatchSetResponse UpdateGeoMatchSet(UpdateGeoMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>GeoMatchConstraint</a> objects in an <c>GeoMatchSet</c>. For
        /// each <c>GeoMatchConstraint</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <c>GeoMatchConstraint</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Type</c>. The only valid value for <c>Type</c> is <c>Country</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Value</c>, which is a two character code for the country to add to the <c>GeoMatchConstraint</c>
        /// object. Valid codes are listed in <a>GeoMatchConstraint$Value</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure an <c>GeoMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateGeoMatchSet</c> request to specify the country that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <c>GeoMatchSet</c>, you specify the country that you want to add
        /// and/or the country that you want to delete. If you want to change a country, you delete
        /// the existing country and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeoMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGeoMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateGeoMatchSet">REST API Reference for UpdateGeoMatchSet Operation</seealso>
        Task<UpdateGeoMatchSetResponse> UpdateGeoMatchSetAsync(UpdateGeoMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIPSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <c>IPSet</c>. For each <c>IPSetDescriptor</c>
        /// object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <c>IPSetDescriptor</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address version, <c>IPv4</c> or <c>IPv6</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address in CIDR notation, for example, <c>192.0.2.0/24</c> (for the range of
        /// IP addresses from <c>192.0.2.0</c> to <c>192.0.2.255</c>) or <c>192.0.2.44/32</c>
        /// (for the individual IP address <c>192.0.2.44</c>). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS WAF supports IPv4 address ranges: /8 and any range between /16 through /32. AWS
        /// WAF supports IPv6 address ranges: /24, /32, /48, /56, /64, and /128. For more information
        /// about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
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
        /// You use an <c>IPSet</c> to specify which web requests you want to allow or block based
        /// on the IP addresses that the requests originated from. For example, if you're receiving
        /// a lot of requests from one or a small number of IP addresses and you want to block
        /// the requests, you can create an <c>IPSet</c> that specifies those IP addresses, and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <c>IPSet</c>, you specify the IP addresses that you want to add
        /// and/or the IP addresses that you want to delete. If you want to change an IP address,
        /// you delete the existing IP address and add the new one.
        /// </para>
        ///  
        /// <para>
        /// You can insert a maximum of 1000 addresses in a single request.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ipSetId">The <c>IPSetId</c> of the <a>IPSet</a> that you want to update. <c>IPSetId</c> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="updates">An array of <c>IPSetUpdate</c> objects that you want to insert into or delete from an <a>IPSet</a>. For more information, see the applicable data types: <ul> <li>  <a>IPSetUpdate</a>: Contains <c>Action</c> and <c>IPSetDescriptor</c>  </li> <li>  <a>IPSetDescriptor</a>: Contains <c>Type</c> and <c>Value</c>  </li> </ul> You can insert a maximum of 1000 addresses in a single request.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        UpdateIPSetResponse UpdateIPSet(string ipSetId, List<IPSetUpdate> updates, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <c>IPSet</c>. For each <c>IPSetDescriptor</c>
        /// object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <c>IPSetDescriptor</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address version, <c>IPv4</c> or <c>IPv6</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address in CIDR notation, for example, <c>192.0.2.0/24</c> (for the range of
        /// IP addresses from <c>192.0.2.0</c> to <c>192.0.2.255</c>) or <c>192.0.2.44/32</c>
        /// (for the individual IP address <c>192.0.2.44</c>). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS WAF supports IPv4 address ranges: /8 and any range between /16 through /32. AWS
        /// WAF supports IPv6 address ranges: /24, /32, /48, /56, /64, and /128. For more information
        /// about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
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
        /// You use an <c>IPSet</c> to specify which web requests you want to allow or block based
        /// on the IP addresses that the requests originated from. For example, if you're receiving
        /// a lot of requests from one or a small number of IP addresses and you want to block
        /// the requests, you can create an <c>IPSet</c> that specifies those IP addresses, and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <c>IPSet</c>, you specify the IP addresses that you want to add
        /// and/or the IP addresses that you want to delete. If you want to change an IP address,
        /// you delete the existing IP address and add the new one.
        /// </para>
        ///  
        /// <para>
        /// You can insert a maximum of 1000 addresses in a single request.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <c>IPSet</c>. For each <c>IPSetDescriptor</c>
        /// object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <c>IPSetDescriptor</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address version, <c>IPv4</c> or <c>IPv6</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address in CIDR notation, for example, <c>192.0.2.0/24</c> (for the range of
        /// IP addresses from <c>192.0.2.0</c> to <c>192.0.2.255</c>) or <c>192.0.2.44/32</c>
        /// (for the individual IP address <c>192.0.2.44</c>). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS WAF supports IPv4 address ranges: /8 and any range between /16 through /32. AWS
        /// WAF supports IPv6 address ranges: /24, /32, /48, /56, /64, and /128. For more information
        /// about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
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
        /// You use an <c>IPSet</c> to specify which web requests you want to allow or block based
        /// on the IP addresses that the requests originated from. For example, if you're receiving
        /// a lot of requests from one or a small number of IP addresses and you want to block
        /// the requests, you can create an <c>IPSet</c> that specifies those IP addresses, and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <c>IPSet</c>, you specify the IP addresses that you want to add
        /// and/or the IP addresses that you want to delete. If you want to change an IP address,
        /// you delete the existing IP address and add the new one.
        /// </para>
        ///  
        /// <para>
        /// You can insert a maximum of 1000 addresses in a single request.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ipSetId">The <c>IPSetId</c> of the <a>IPSet</a> that you want to update. <c>IPSetId</c> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="updates">An array of <c>IPSetUpdate</c> objects that you want to insert into or delete from an <a>IPSet</a>. For more information, see the applicable data types: <ul> <li>  <a>IPSetUpdate</a>: Contains <c>Action</c> and <c>IPSetDescriptor</c>  </li> <li>  <a>IPSetDescriptor</a>: Contains <c>Type</c> and <c>Value</c>  </li> </ul> You can insert a maximum of 1000 addresses in a single request.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        Task<UpdateIPSetResponse> UpdateIPSetAsync(string ipSetId, List<IPSetUpdate> updates, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <c>IPSet</c>. For each <c>IPSetDescriptor</c>
        /// object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <c>IPSetDescriptor</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address version, <c>IPv4</c> or <c>IPv6</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address in CIDR notation, for example, <c>192.0.2.0/24</c> (for the range of
        /// IP addresses from <c>192.0.2.0</c> to <c>192.0.2.255</c>) or <c>192.0.2.44/32</c>
        /// (for the individual IP address <c>192.0.2.44</c>). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS WAF supports IPv4 address ranges: /8 and any range between /16 through /32. AWS
        /// WAF supports IPv6 address ranges: /24, /32, /48, /56, /64, and /128. For more information
        /// about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
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
        /// You use an <c>IPSet</c> to specify which web requests you want to allow or block based
        /// on the IP addresses that the requests originated from. For example, if you're receiving
        /// a lot of requests from one or a small number of IP addresses and you want to block
        /// the requests, you can create an <c>IPSet</c> that specifies those IP addresses, and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <c>IPSet</c>, you specify the IP addresses that you want to add
        /// and/or the IP addresses that you want to delete. If you want to change an IP address,
        /// you delete the existing IP address and add the new one.
        /// </para>
        ///  
        /// <para>
        /// You can insert a maximum of 1000 addresses in a single request.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        Task<UpdateIPSetResponse> UpdateIPSetAsync(UpdateIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRateBasedRule


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>Predicate</a> objects in a rule and updates the <c>RateLimit</c>
        /// in the rule. 
        /// </para>
        ///  
        /// <para>
        /// Each <c>Predicate</c> object identifies a predicate, such as a <a>ByteMatchSet</a>
        /// or an <a>IPSet</a>, that specifies the web requests that you want to block or count.
        /// The <c>RateLimit</c> specifies the number of requests every five minutes that triggers
        /// the rule.
        /// </para>
        ///  
        /// <para>
        /// If you add more than one predicate to a <c>RateBasedRule</c>, a request must match
        /// all the predicates and exceed the <c>RateLimit</c> to be counted or blocked. For example,
        /// suppose you add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// You then add the <c>RateBasedRule</c> to a <c>WebACL</c> and specify that you want
        /// to block requests that satisfy the rule. For a request to be blocked, it must come
        /// from the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header in the request
        /// must contain the value <c>BadBot</c>. Further, requests that match these two conditions
        /// much be received at a rate of more than 1,000 every five minutes. If the rate drops
        /// below this limit, AWS WAF no longer blocks the requests.
        /// </para>
        ///  
        /// <para>
        /// As a second example, suppose you want to limit requests to a particular page on your
        /// site. To do this, you could add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> with <c>FieldToMatch</c> of <c>URI</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>PositionalConstraint</c> of <c>STARTS_WITH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>TargetString</c> of <c>login</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// By adding this <c>RateBasedRule</c> to a <c>WebACL</c>, you could limit requests to
        /// your login page without affecting the rest of your site.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRateBasedRule service method.</param>
        /// 
        /// <returns>The response from the UpdateRateBasedRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRateBasedRule">REST API Reference for UpdateRateBasedRule Operation</seealso>
        UpdateRateBasedRuleResponse UpdateRateBasedRule(UpdateRateBasedRuleRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>Predicate</a> objects in a rule and updates the <c>RateLimit</c>
        /// in the rule. 
        /// </para>
        ///  
        /// <para>
        /// Each <c>Predicate</c> object identifies a predicate, such as a <a>ByteMatchSet</a>
        /// or an <a>IPSet</a>, that specifies the web requests that you want to block or count.
        /// The <c>RateLimit</c> specifies the number of requests every five minutes that triggers
        /// the rule.
        /// </para>
        ///  
        /// <para>
        /// If you add more than one predicate to a <c>RateBasedRule</c>, a request must match
        /// all the predicates and exceed the <c>RateLimit</c> to be counted or blocked. For example,
        /// suppose you add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// You then add the <c>RateBasedRule</c> to a <c>WebACL</c> and specify that you want
        /// to block requests that satisfy the rule. For a request to be blocked, it must come
        /// from the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header in the request
        /// must contain the value <c>BadBot</c>. Further, requests that match these two conditions
        /// much be received at a rate of more than 1,000 every five minutes. If the rate drops
        /// below this limit, AWS WAF no longer blocks the requests.
        /// </para>
        ///  
        /// <para>
        /// As a second example, suppose you want to limit requests to a particular page on your
        /// site. To do this, you could add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> with <c>FieldToMatch</c> of <c>URI</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>PositionalConstraint</c> of <c>STARTS_WITH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>TargetString</c> of <c>login</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// By adding this <c>RateBasedRule</c> to a <c>WebACL</c>, you could limit requests to
        /// your login page without affecting the rest of your site.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRateBasedRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRateBasedRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRateBasedRule">REST API Reference for UpdateRateBasedRule Operation</seealso>
        Task<UpdateRateBasedRuleResponse> UpdateRateBasedRuleAsync(UpdateRateBasedRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRegexMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>RegexMatchTuple</a> objects (filters) in a <a>RegexMatchSet</a>.
        /// For each <c>RegexMatchSetUpdate</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>RegexMatchSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspectupdate, such as a query
        /// string or the value of the <c>User-Agent</c> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The identifier of the pattern (a regular expression) that you want AWS WAF to look
        /// for. For more information, see <a>RegexPatternSet</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any conversions on the request, such as converting it to lowercase,
        /// before inspecting it for the specified string.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For example, you can create a <c>RegexPatternSet</c> that matches any requests with
        /// <c>User-Agent</c> headers that contain the string <c>B[a@]dB[o0]t</c>. You can then
        /// configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RegexMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>RegexMatchSet.</c> For more information, see <a>CreateRegexMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRegexMatchSet</c> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the identifier
        /// of the <c>RegexPatternSet</c> that contain the regular expression patters you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexMatchSet service method.</param>
        /// 
        /// <returns>The response from the UpdateRegexMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRegexMatchSet">REST API Reference for UpdateRegexMatchSet Operation</seealso>
        UpdateRegexMatchSetResponse UpdateRegexMatchSet(UpdateRegexMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>RegexMatchTuple</a> objects (filters) in a <a>RegexMatchSet</a>.
        /// For each <c>RegexMatchSetUpdate</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>RegexMatchSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspectupdate, such as a query
        /// string or the value of the <c>User-Agent</c> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The identifier of the pattern (a regular expression) that you want AWS WAF to look
        /// for. For more information, see <a>RegexPatternSet</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any conversions on the request, such as converting it to lowercase,
        /// before inspecting it for the specified string.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For example, you can create a <c>RegexPatternSet</c> that matches any requests with
        /// <c>User-Agent</c> headers that contain the string <c>B[a@]dB[o0]t</c>. You can then
        /// configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RegexMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>RegexMatchSet.</c> For more information, see <a>CreateRegexMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRegexMatchSet</c> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the identifier
        /// of the <c>RegexPatternSet</c> that contain the regular expression patters you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegexMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRegexMatchSet">REST API Reference for UpdateRegexMatchSet Operation</seealso>
        Task<UpdateRegexMatchSetResponse> UpdateRegexMatchSetAsync(UpdateRegexMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRegexPatternSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <c>RegexPatternString</c> objects in a <a>RegexPatternSet</a>.
        /// For each <c>RegexPatternString</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the <c>RegexPatternString</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The regular expression pattern that you want to insert or delete. For more information,
        /// see <a>RegexPatternSet</a>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For example, you can create a <c>RegexPatternString</c> such as <c>B[a@]dB[o0]t</c>.
        /// AWS WAF will match this <c>RegexPatternString</c> to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// BadBot
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BadB0t
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// B@dBot
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// B@dB0t
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure a <c>RegexPatternSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>RegexPatternSet.</c> For more information, see <a>CreateRegexPatternSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRegexPatternSet</c> request to specify the regular expression pattern
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the UpdateRegexPatternSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidRegexPatternException">
        /// The regular expression (regex) you specified in <c>RegexPatternString</c> is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        UpdateRegexPatternSetResponse UpdateRegexPatternSet(UpdateRegexPatternSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <c>RegexPatternString</c> objects in a <a>RegexPatternSet</a>.
        /// For each <c>RegexPatternString</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the <c>RegexPatternString</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The regular expression pattern that you want to insert or delete. For more information,
        /// see <a>RegexPatternSet</a>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For example, you can create a <c>RegexPatternString</c> such as <c>B[a@]dB[o0]t</c>.
        /// AWS WAF will match this <c>RegexPatternString</c> to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// BadBot
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BadB0t
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// B@dBot
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// B@dB0t
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure a <c>RegexPatternSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>RegexPatternSet.</c> For more information, see <a>CreateRegexPatternSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRegexPatternSet</c> request to specify the regular expression pattern
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegexPatternSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidRegexPatternException">
        /// The regular expression (regex) you specified in <c>RegexPatternString</c> is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        Task<UpdateRegexPatternSetResponse> UpdateRegexPatternSetAsync(UpdateRegexPatternSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRule


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>Predicate</a> objects in a <c>Rule</c>. Each <c>Predicate</c>
        /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
        /// specifies the web requests that you want to allow, block, or count. If you add more
        /// than one predicate to a <c>Rule</c>, a request must match all of the specifications
        /// to be allowed, blocked, or counted. For example, suppose that you add the following
        /// to a <c>Rule</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches the value <c>BadBot</c> in the <c>User-Agent</c>
        /// header
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to block
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, the <c>User-Agent</c>
        /// header in the request must contain the value <c>BadBot</c> <i>and</i> the request
        /// must originate from the IP address 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the <c>Rule</c>. See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to add predicates to the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <c>ByteMatchSet</c> or <c>IPSet</c> with another, you delete
        /// the existing one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ruleId">The <c>RuleId</c> of the <c>Rule</c> that you want to update. <c>RuleId</c> is returned by <c>CreateRule</c> and by <a>ListRules</a>.</param>
        /// <param name="updates">An array of <c>RuleUpdate</c> objects that you want to insert into or delete from a <a>Rule</a>. For more information, see the applicable data types: <ul> <li>  <a>RuleUpdate</a>: Contains <c>Action</c> and <c>Predicate</c>  </li> <li>  <a>Predicate</a>: Contains <c>DataId</c>, <c>Negated</c>, and <c>Type</c>  </li> <li>  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        UpdateRuleResponse UpdateRule(string ruleId, List<RuleUpdate> updates, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>Predicate</a> objects in a <c>Rule</c>. Each <c>Predicate</c>
        /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
        /// specifies the web requests that you want to allow, block, or count. If you add more
        /// than one predicate to a <c>Rule</c>, a request must match all of the specifications
        /// to be allowed, blocked, or counted. For example, suppose that you add the following
        /// to a <c>Rule</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches the value <c>BadBot</c> in the <c>User-Agent</c>
        /// header
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to block
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, the <c>User-Agent</c>
        /// header in the request must contain the value <c>BadBot</c> <i>and</i> the request
        /// must originate from the IP address 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the <c>Rule</c>. See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to add predicates to the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <c>ByteMatchSet</c> or <c>IPSet</c> with another, you delete
        /// the existing one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        UpdateRuleResponse UpdateRule(UpdateRuleRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>Predicate</a> objects in a <c>Rule</c>. Each <c>Predicate</c>
        /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
        /// specifies the web requests that you want to allow, block, or count. If you add more
        /// than one predicate to a <c>Rule</c>, a request must match all of the specifications
        /// to be allowed, blocked, or counted. For example, suppose that you add the following
        /// to a <c>Rule</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches the value <c>BadBot</c> in the <c>User-Agent</c>
        /// header
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to block
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, the <c>User-Agent</c>
        /// header in the request must contain the value <c>BadBot</c> <i>and</i> the request
        /// must originate from the IP address 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the <c>Rule</c>. See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to add predicates to the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <c>ByteMatchSet</c> or <c>IPSet</c> with another, you delete
        /// the existing one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ruleId">The <c>RuleId</c> of the <c>Rule</c> that you want to update. <c>RuleId</c> is returned by <c>CreateRule</c> and by <a>ListRules</a>.</param>
        /// <param name="updates">An array of <c>RuleUpdate</c> objects that you want to insert into or delete from a <a>Rule</a>. For more information, see the applicable data types: <ul> <li>  <a>RuleUpdate</a>: Contains <c>Action</c> and <c>Predicate</c>  </li> <li>  <a>Predicate</a>: Contains <c>DataId</c>, <c>Negated</c>, and <c>Type</c>  </li> <li>  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        Task<UpdateRuleResponse> UpdateRuleAsync(string ruleId, List<RuleUpdate> updates, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>Predicate</a> objects in a <c>Rule</c>. Each <c>Predicate</c>
        /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
        /// specifies the web requests that you want to allow, block, or count. If you add more
        /// than one predicate to a <c>Rule</c>, a request must match all of the specifications
        /// to be allowed, blocked, or counted. For example, suppose that you add the following
        /// to a <c>Rule</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches the value <c>BadBot</c> in the <c>User-Agent</c>
        /// header
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to block
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, the <c>User-Agent</c>
        /// header in the request must contain the value <c>BadBot</c> <i>and</i> the request
        /// must originate from the IP address 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the <c>Rule</c>. See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to add predicates to the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <c>ByteMatchSet</c> or <c>IPSet</c> with another, you delete
        /// the existing one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRuleGroup


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ActivatedRule</a> objects in a <c>RuleGroup</c>.
        /// </para>
        ///  
        /// <para>
        /// You can only insert <c>REGULAR</c> rules into a rule group.
        /// </para>
        ///  
        /// <para>
        /// You can have a maximum of ten rules per rule group.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RuleGroup</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the <c>Rules</c> that you want to include in the <c>RuleGroup</c>.
        /// See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRuleGroup</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRuleGroup</c> request to add <c>Rules</c> to the <c>RuleGroup</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>RuleGroup</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <c>Rule</c> with another, you delete the existing one and
        /// add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleGroup service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        UpdateRuleGroupResponse UpdateRuleGroup(UpdateRuleGroupRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ActivatedRule</a> objects in a <c>RuleGroup</c>.
        /// </para>
        ///  
        /// <para>
        /// You can only insert <c>REGULAR</c> rules into a rule group.
        /// </para>
        ///  
        /// <para>
        /// You can have a maximum of ten rules per rule group.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RuleGroup</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the <c>Rules</c> that you want to include in the <c>RuleGroup</c>.
        /// See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRuleGroup</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRuleGroup</c> request to add <c>Rules</c> to the <c>RuleGroup</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>RuleGroup</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <c>Rule</c> with another, you delete the existing one and
        /// add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleGroup service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        Task<UpdateRuleGroupResponse> UpdateRuleGroupAsync(UpdateRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSizeConstraintSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>SizeConstraint</a> objects (filters) in a <a>SizeConstraintSet</a>.
        /// For each <c>SizeConstraint</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>SizeConstraintSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to evaluate, such as the length of
        /// a query string or the length of the <c>User-Agent</c> header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any transformations on the request, such as converting it to lowercase,
        /// before checking its length. Note that transformations of the request body are not
        /// supported because the AWS resource forwards only the first <c>8192</c> bytes of your
        /// request to AWS WAF.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ComparisonOperator</c> used for evaluating the selected part of the request against
        /// the specified <c>Size</c>, such as equals, greater than, less than, and so on.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The length, in bytes, that you want AWS WAF to watch for in selected part of the request.
        /// The length is computed after applying the transformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, you can add a <c>SizeConstraintSetUpdate</c> object that matches web
        /// requests in which the length of the <c>User-Agent</c> header is greater than 100 bytes.
        /// You can then configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SizeConstraintSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>SizeConstraintSet.</c> For more information, see <a>CreateSizeConstraintSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateSizeConstraintSet</c> request to specify the part of the request
        /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSizeConstraintSet service method.</param>
        /// 
        /// <returns>The response from the UpdateSizeConstraintSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateSizeConstraintSet">REST API Reference for UpdateSizeConstraintSet Operation</seealso>
        UpdateSizeConstraintSetResponse UpdateSizeConstraintSet(UpdateSizeConstraintSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>SizeConstraint</a> objects (filters) in a <a>SizeConstraintSet</a>.
        /// For each <c>SizeConstraint</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>SizeConstraintSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to evaluate, such as the length of
        /// a query string or the length of the <c>User-Agent</c> header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any transformations on the request, such as converting it to lowercase,
        /// before checking its length. Note that transformations of the request body are not
        /// supported because the AWS resource forwards only the first <c>8192</c> bytes of your
        /// request to AWS WAF.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ComparisonOperator</c> used for evaluating the selected part of the request against
        /// the specified <c>Size</c>, such as equals, greater than, less than, and so on.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The length, in bytes, that you want AWS WAF to watch for in selected part of the request.
        /// The length is computed after applying the transformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, you can add a <c>SizeConstraintSetUpdate</c> object that matches web
        /// requests in which the length of the <c>User-Agent</c> header is greater than 100 bytes.
        /// You can then configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SizeConstraintSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>SizeConstraintSet.</c> For more information, see <a>CreateSizeConstraintSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateSizeConstraintSet</c> request to specify the part of the request
        /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSizeConstraintSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSizeConstraintSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateSizeConstraintSet">REST API Reference for UpdateSizeConstraintSet Operation</seealso>
        Task<UpdateSizeConstraintSetResponse> UpdateSizeConstraintSetAsync(UpdateSizeConstraintSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSqlInjectionMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
        /// For each <c>SqlInjectionMatchTuple</c> object, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Action</c>: Whether to insert the object into or delete the object from the array.
        /// To change a <c>SqlInjectionMatchTuple</c>, you delete the existing object and add
        /// a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FieldToMatch</c>: The part of web requests that you want AWS WAF to inspect and,
        /// if you want AWS WAF to inspect a header or custom query parameter, the name of the
        /// header or parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TextTransformation</c>: Which text transformation, if any, to perform on the web
        /// request before inspecting the request for snippets of malicious SQL code.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <c>SqlInjectionMatchSet</c> objects to specify which CloudFront requests that
        /// you want to allow, block, or count. For example, if you're receiving requests that
        /// contain snippets of SQL code in the query string and you want to block the requests,
        /// you can create a <c>SqlInjectionMatchSet</c> with the applicable settings, and then
        /// configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateSqlInjectionMatchSet</c> request to specify the parts of web requests
        /// that you want AWS WAF to inspect for snippets of SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <c>SqlInjectionMatchSetId</c> of the <c>SqlInjectionMatchSet</c> that you want to update. <c>SqlInjectionMatchSetId</c> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="updates">An array of <c>SqlInjectionMatchSetUpdate</c> objects that you want to insert into or delete from a <a>SqlInjectionMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>SqlInjectionMatchSetUpdate</a>: Contains <c>Action</c> and <c>SqlInjectionMatchTuple</c>  </li> <li>  <a>SqlInjectionMatchTuple</a>: Contains <c>FieldToMatch</c> and <c>TextTransformation</c>  </li> <li>  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// 
        /// <returns>The response from the UpdateSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateSqlInjectionMatchSet">REST API Reference for UpdateSqlInjectionMatchSet Operation</seealso>
        UpdateSqlInjectionMatchSetResponse UpdateSqlInjectionMatchSet(string sqlInjectionMatchSetId, List<SqlInjectionMatchSetUpdate> updates, string changeToken);

        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
        /// For each <c>SqlInjectionMatchTuple</c> object, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Action</c>: Whether to insert the object into or delete the object from the array.
        /// To change a <c>SqlInjectionMatchTuple</c>, you delete the existing object and add
        /// a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FieldToMatch</c>: The part of web requests that you want AWS WAF to inspect and,
        /// if you want AWS WAF to inspect a header or custom query parameter, the name of the
        /// header or parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TextTransformation</c>: Which text transformation, if any, to perform on the web
        /// request before inspecting the request for snippets of malicious SQL code.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <c>SqlInjectionMatchSet</c> objects to specify which CloudFront requests that
        /// you want to allow, block, or count. For example, if you're receiving requests that
        /// contain snippets of SQL code in the query string and you want to block the requests,
        /// you can create a <c>SqlInjectionMatchSet</c> with the applicable settings, and then
        /// configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateSqlInjectionMatchSet</c> request to specify the parts of web requests
        /// that you want AWS WAF to inspect for snippets of SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSqlInjectionMatchSet service method.</param>
        /// 
        /// <returns>The response from the UpdateSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateSqlInjectionMatchSet">REST API Reference for UpdateSqlInjectionMatchSet Operation</seealso>
        UpdateSqlInjectionMatchSetResponse UpdateSqlInjectionMatchSet(UpdateSqlInjectionMatchSetRequest request);


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
        /// For each <c>SqlInjectionMatchTuple</c> object, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Action</c>: Whether to insert the object into or delete the object from the array.
        /// To change a <c>SqlInjectionMatchTuple</c>, you delete the existing object and add
        /// a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FieldToMatch</c>: The part of web requests that you want AWS WAF to inspect and,
        /// if you want AWS WAF to inspect a header or custom query parameter, the name of the
        /// header or parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TextTransformation</c>: Which text transformation, if any, to perform on the web
        /// request before inspecting the request for snippets of malicious SQL code.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <c>SqlInjectionMatchSet</c> objects to specify which CloudFront requests that
        /// you want to allow, block, or count. For example, if you're receiving requests that
        /// contain snippets of SQL code in the query string and you want to block the requests,
        /// you can create a <c>SqlInjectionMatchSet</c> with the applicable settings, and then
        /// configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateSqlInjectionMatchSet</c> request to specify the parts of web requests
        /// that you want AWS WAF to inspect for snippets of SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <c>SqlInjectionMatchSetId</c> of the <c>SqlInjectionMatchSet</c> that you want to update. <c>SqlInjectionMatchSetId</c> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="updates">An array of <c>SqlInjectionMatchSetUpdate</c> objects that you want to insert into or delete from a <a>SqlInjectionMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>SqlInjectionMatchSetUpdate</a>: Contains <c>Action</c> and <c>SqlInjectionMatchTuple</c>  </li> <li>  <a>SqlInjectionMatchTuple</a>: Contains <c>FieldToMatch</c> and <c>TextTransformation</c>  </li> <li>  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateSqlInjectionMatchSet">REST API Reference for UpdateSqlInjectionMatchSet Operation</seealso>
        Task<UpdateSqlInjectionMatchSetResponse> UpdateSqlInjectionMatchSetAsync(string sqlInjectionMatchSetId, List<SqlInjectionMatchSetUpdate> updates, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
        /// For each <c>SqlInjectionMatchTuple</c> object, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Action</c>: Whether to insert the object into or delete the object from the array.
        /// To change a <c>SqlInjectionMatchTuple</c>, you delete the existing object and add
        /// a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FieldToMatch</c>: The part of web requests that you want AWS WAF to inspect and,
        /// if you want AWS WAF to inspect a header or custom query parameter, the name of the
        /// header or parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TextTransformation</c>: Which text transformation, if any, to perform on the web
        /// request before inspecting the request for snippets of malicious SQL code.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <c>SqlInjectionMatchSet</c> objects to specify which CloudFront requests that
        /// you want to allow, block, or count. For example, if you're receiving requests that
        /// contain snippets of SQL code in the query string and you want to block the requests,
        /// you can create a <c>SqlInjectionMatchSet</c> with the applicable settings, and then
        /// configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateSqlInjectionMatchSet</c> request to specify the parts of web requests
        /// that you want AWS WAF to inspect for snippets of SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSqlInjectionMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSqlInjectionMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateSqlInjectionMatchSet">REST API Reference for UpdateSqlInjectionMatchSet Operation</seealso>
        Task<UpdateSqlInjectionMatchSetResponse> UpdateSqlInjectionMatchSetAsync(UpdateSqlInjectionMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWebACL


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ActivatedRule</a> objects in a <c>WebACL</c>. Each <c>Rule</c>
        /// identifies web requests that you want to allow, block, or count. When you update a
        /// <c>WebACL</c>, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A default action for the <c>WebACL</c>, either <c>ALLOW</c> or <c>BLOCK</c>. AWS WAF
        /// performs the default action if a request doesn't match the criteria in any of the
        /// <c>Rules</c> in a <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Rules</c> that you want to add or delete. If you want to replace one <c>Rule</c>
        /// with another, you delete the existing <c>Rule</c> and add the new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each <c>Rule</c>, whether you want AWS WAF to allow requests, block requests,
        /// or count requests that match the conditions in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order in which you want AWS WAF to evaluate the <c>Rules</c> in a <c>WebACL</c>.
        /// If you add more than one <c>Rule</c> to a <c>WebACL</c>, AWS WAF evaluates each request
        /// against the <c>Rules</c> in order based on the value of <c>Priority</c>. (The <c>Rule</c>
        /// that has the lowest value for <c>Priority</c> is evaluated first.) When a web request
        /// matches all the predicates (such as <c>ByteMatchSets</c> and <c>IPSets</c>) in a <c>Rule</c>,
        /// AWS WAF immediately takes the corresponding action, allow or block, and doesn't evaluate
        /// the request against the remaining <c>Rules</c> in the <c>WebACL</c>, if any. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in <c>Rules</c>. For more
        /// information, see <a>CreateByteMatchSet</a>, <a>UpdateByteMatchSet</a>, <a>CreateIPSet</a>,
        /// <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>, and <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update the <c>Rules</c> that you want to include in the <c>WebACL</c>.
        /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a <c>WebACL</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateWebACL</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateWebACL</c> request to specify the <c>Rules</c> that you want to
        /// include in the <c>WebACL</c>, to specify the default action, and to associate the
        /// <c>WebACL</c> with a CloudFront distribution. 
        /// </para>
        ///  
        /// <para>
        /// The <c>ActivatedRule</c> can be a rule group. If you specify a rule group as your
        /// <c>ActivatedRule</c> , you can exclude specific rules from that rule group.
        /// </para>
        ///  
        /// <para>
        /// If you already have a rule group associated with a web ACL and want to submit an <c>UpdateWebACL</c>
        /// request to exclude certain rules from that rule group, you must first remove the rule
        /// group from the web ACL, the re-insert it again, specifying the excluded rules. For
        /// details, see <a>ActivatedRule$ExcludedRules</a> . 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// Be aware that if you try to add a RATE_BASED rule to a web ACL without setting the
        /// rule type when first creating the rule, the <a>UpdateWebACL</a> request will fail
        /// because the request tries to add a REGULAR rule (the default rule type) with the specified
        /// ID, which does not exist. 
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFSubscriptionNotFoundException">
        /// The specified subscription does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        UpdateWebACLResponse UpdateWebACL(UpdateWebACLRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ActivatedRule</a> objects in a <c>WebACL</c>. Each <c>Rule</c>
        /// identifies web requests that you want to allow, block, or count. When you update a
        /// <c>WebACL</c>, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A default action for the <c>WebACL</c>, either <c>ALLOW</c> or <c>BLOCK</c>. AWS WAF
        /// performs the default action if a request doesn't match the criteria in any of the
        /// <c>Rules</c> in a <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Rules</c> that you want to add or delete. If you want to replace one <c>Rule</c>
        /// with another, you delete the existing <c>Rule</c> and add the new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each <c>Rule</c>, whether you want AWS WAF to allow requests, block requests,
        /// or count requests that match the conditions in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order in which you want AWS WAF to evaluate the <c>Rules</c> in a <c>WebACL</c>.
        /// If you add more than one <c>Rule</c> to a <c>WebACL</c>, AWS WAF evaluates each request
        /// against the <c>Rules</c> in order based on the value of <c>Priority</c>. (The <c>Rule</c>
        /// that has the lowest value for <c>Priority</c> is evaluated first.) When a web request
        /// matches all the predicates (such as <c>ByteMatchSets</c> and <c>IPSets</c>) in a <c>Rule</c>,
        /// AWS WAF immediately takes the corresponding action, allow or block, and doesn't evaluate
        /// the request against the remaining <c>Rules</c> in the <c>WebACL</c>, if any. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in <c>Rules</c>. For more
        /// information, see <a>CreateByteMatchSet</a>, <a>UpdateByteMatchSet</a>, <a>CreateIPSet</a>,
        /// <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>, and <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update the <c>Rules</c> that you want to include in the <c>WebACL</c>.
        /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a <c>WebACL</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateWebACL</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateWebACL</c> request to specify the <c>Rules</c> that you want to
        /// include in the <c>WebACL</c>, to specify the default action, and to associate the
        /// <c>WebACL</c> with a CloudFront distribution. 
        /// </para>
        ///  
        /// <para>
        /// The <c>ActivatedRule</c> can be a rule group. If you specify a rule group as your
        /// <c>ActivatedRule</c> , you can exclude specific rules from that rule group.
        /// </para>
        ///  
        /// <para>
        /// If you already have a rule group associated with a web ACL and want to submit an <c>UpdateWebACL</c>
        /// request to exclude certain rules from that rule group, you must first remove the rule
        /// group from the web ACL, the re-insert it again, specifying the excluded rules. For
        /// details, see <a>ActivatedRule$ExcludedRules</a> . 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// Be aware that if you try to add a RATE_BASED rule to a web ACL without setting the
        /// rule type when first creating the rule, the <a>UpdateWebACL</a> request will fail
        /// because the request tries to add a REGULAR rule (the default rule type) with the specified
        /// ID, which does not exist. 
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFSubscriptionNotFoundException">
        /// The specified subscription does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        Task<UpdateWebACLResponse> UpdateWebACLAsync(UpdateWebACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateXssMatchSet


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>XssMatchTuple</a> objects (filters) in an <a>XssMatchSet</a>.
        /// For each <c>XssMatchTuple</c> object, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Action</c>: Whether to insert the object into or delete the object from the array.
        /// To change an <c>XssMatchTuple</c>, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FieldToMatch</c>: The part of web requests that you want AWS WAF to inspect and,
        /// if you want AWS WAF to inspect a header or custom query parameter, the name of the
        /// header or parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TextTransformation</c>: Which text transformation, if any, to perform on the web
        /// request before inspecting the request for cross-site scripting attacks.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <c>XssMatchSet</c> objects to specify which CloudFront requests that you want
        /// to allow, block, or count. For example, if you're receiving requests that contain
        /// cross-site scripting attacks in the request body and you want to block the requests,
        /// you can create an <c>XssMatchSet</c> with the applicable settings, and then configure
        /// AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>XssMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateXssMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateXssMatchSet</c> request to specify the parts of web requests that
        /// you want AWS WAF to inspect for cross-site scripting attacks.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateXssMatchSet service method.</param>
        /// 
        /// <returns>The response from the UpdateXssMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateXssMatchSet">REST API Reference for UpdateXssMatchSet Operation</seealso>
        UpdateXssMatchSetResponse UpdateXssMatchSet(UpdateXssMatchSetRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>XssMatchTuple</a> objects (filters) in an <a>XssMatchSet</a>.
        /// For each <c>XssMatchTuple</c> object, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Action</c>: Whether to insert the object into or delete the object from the array.
        /// To change an <c>XssMatchTuple</c>, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FieldToMatch</c>: The part of web requests that you want AWS WAF to inspect and,
        /// if you want AWS WAF to inspect a header or custom query parameter, the name of the
        /// header or parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TextTransformation</c>: Which text transformation, if any, to perform on the web
        /// request before inspecting the request for cross-site scripting attacks.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <c>XssMatchSet</c> objects to specify which CloudFront requests that you want
        /// to allow, block, or count. For example, if you're receiving requests that contain
        /// cross-site scripting attacks in the request body and you want to block the requests,
        /// you can create an <c>XssMatchSet</c> with the applicable settings, and then configure
        /// AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>XssMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateXssMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateXssMatchSet</c> request to specify the parts of web requests that
        /// you want AWS WAF to inspect for cross-site scripting attacks.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateXssMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateXssMatchSet service method, as returned by WAF.</returns>
        /// <exception cref="Amazon.WAF.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFInvalidParameterException">
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
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAF.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-2015-08-24/UpdateXssMatchSet">REST API Reference for UpdateXssMatchSet Operation</seealso>
        Task<UpdateXssMatchSetResponse> UpdateXssMatchSetAsync(UpdateXssMatchSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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