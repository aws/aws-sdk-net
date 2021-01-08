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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRegexPatternSet operation.
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
    /// Inserts or deletes <code>RegexPatternString</code> objects in a <a>RegexPatternSet</a>.
    /// For each <code>RegexPatternString</code> object, you specify the following values:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Whether to insert or delete the <code>RegexPatternString</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The regular expression pattern that you want to insert or delete. For more information,
    /// see <a>RegexPatternSet</a>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For example, you can create a <code>RegexPatternString</code> such as <code>B[a@]dB[o0]t</code>.
    /// AWS WAF will match this <code>RegexPatternString</code> to:
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
    /// To create and configure a <code>RegexPatternSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create a <code>RegexPatternSet.</code> For more information, see <a>CreateRegexPatternSet</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <code>UpdateRegexPatternSet</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <code>UpdateRegexPatternSet</code> request to specify the regular expression
    /// pattern that you want AWS WAF to watch for.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateRegexPatternSetRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _regexPatternSetId;
        private List<RegexPatternSetUpdate> _updates = new List<RegexPatternSetUpdate>();

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
        /// Gets and sets the property RegexPatternSetId. 
        /// <para>
        /// The <code>RegexPatternSetId</code> of the <a>RegexPatternSet</a> that you want to
        /// update. <code>RegexPatternSetId</code> is returned by <a>CreateRegexPatternSet</a>
        /// and by <a>ListRegexPatternSets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RegexPatternSetId
        {
            get { return this._regexPatternSetId; }
            set { this._regexPatternSetId = value; }
        }

        // Check to see if RegexPatternSetId property is set
        internal bool IsSetRegexPatternSetId()
        {
            return this._regexPatternSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of <code>RegexPatternSetUpdate</code> objects that you want to insert into
        /// or delete from a <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<RegexPatternSetUpdate> Updates
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