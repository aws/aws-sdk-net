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
    /// Container for the parameters to the UpdateRegexMatchSet operation.
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
    public partial class UpdateRegexMatchSetRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _regexMatchSetId;
        private List<RegexMatchSetUpdate> _updates = AWSConfigs.InitializeCollections ? new List<RegexMatchSetUpdate>() : null;

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
        /// Gets and sets the property RegexMatchSetId. 
        /// <para>
        /// The <c>RegexMatchSetId</c> of the <a>RegexMatchSet</a> that you want to update. <c>RegexMatchSetId</c>
        /// is returned by <a>CreateRegexMatchSet</a> and by <a>ListRegexMatchSets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// An array of <c>RegexMatchSetUpdate</c> objects that you want to insert into or delete
        /// from a <a>RegexMatchSet</a>. For more information, see <a>RegexMatchTuple</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<RegexMatchSetUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && (this._updates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}