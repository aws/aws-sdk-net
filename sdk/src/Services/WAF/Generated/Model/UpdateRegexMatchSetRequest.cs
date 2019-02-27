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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRegexMatchSet operation.
    /// Inserts or deletes <a>RegexMatchTuple</a> objects (filters) in a <a>RegexMatchSet</a>.
    /// For each <code>RegexMatchSetUpdate</code> object, you specify the following values:
    /// 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Whether to insert or delete the object from the array. If you want to change a <code>RegexMatchSetUpdate</code>
    /// object, you delete the existing object and add a new one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The part of a web request that you want AWS WAF to inspectupdate, such as a query
    /// string or the value of the <code>User-Agent</code> header. 
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
    ///  For example, you can create a <code>RegexPatternSet</code> that matches any requests
    /// with <code>User-Agent</code> headers that contain the string <code>B[a@]dB[o0]t</code>.
    /// You can then configure AWS WAF to reject those requests.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <code>RegexMatchSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create a <code>RegexMatchSet.</code> For more information, see <a>CreateRegexMatchSet</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <code>UpdateRegexMatchSet</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <code>UpdateRegexMatchSet</code> request to specify the part of the request
    /// that you want AWS WAF to inspect (for example, the header or the URI) and the identifier
    /// of the <code>RegexPatternSet</code> that contain the regular expression patters you
    /// want AWS WAF to watch for.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateRegexMatchSetRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _regexMatchSetId;
        private List<RegexMatchSetUpdate> _updates = new List<RegexMatchSetUpdate>();

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RegexMatchSetId. 
        /// <para>
        /// The <code>RegexMatchSetId</code> of the <a>RegexMatchSet</a> that you want to update.
        /// <code>RegexMatchSetId</code> is returned by <a>CreateRegexMatchSet</a> and by <a>ListRegexMatchSets</a>.
        /// </para>
        /// </summary>
        public string RegexMatchSetId
        {
            get { return this._regexMatchSetId; }
            set { this._regexMatchSetId = value; }
        }

        // Check to see if RegexMatchSetId property is set
        internal bool IsSetRegexMatchSetId()
        {
            return this._regexMatchSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of <code>RegexMatchSetUpdate</code> objects that you want to insert into
        /// or delete from a <a>RegexMatchSet</a>. For more information, see <a>RegexMatchTuple</a>.
        /// </para>
        /// </summary>
        public List<RegexMatchSetUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && this._updates.Count > 0; 
        }

    }
}