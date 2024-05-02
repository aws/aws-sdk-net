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
    /// Container for the parameters to the CreateRegexMatchSet operation.
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
    public partial class CreateRegexMatchSetRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _name;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>RegexMatchSet</a>. You can't change <c>Name</c>
        /// after you create a <c>RegexMatchSet</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}