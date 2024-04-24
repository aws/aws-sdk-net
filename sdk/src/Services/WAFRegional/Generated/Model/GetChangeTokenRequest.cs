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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// Container for the parameters to the GetChangeToken operation.
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
    public partial class GetChangeTokenRequest : AmazonWAFRegionalRequest
    {

    }
}