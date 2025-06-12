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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAF.Model
{
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
    /// In a <a>GetRegexMatchSet</a> request, <c>RegexMatchSet</c> is a complex type that
    /// contains the <c>RegexMatchSetId</c> and <c>Name</c> of a <c>RegexMatchSet</c>, and
    /// the values that you specified when you updated the <c>RegexMatchSet</c>.
    /// </para>
    ///  
    /// <para>
    ///  The values are contained in a <c>RegexMatchTuple</c> object, which specify the parts
    /// of web requests that you want AWS WAF to inspect and the values that you want AWS
    /// WAF to search for. If a <c>RegexMatchSet</c> contains more than one <c>RegexMatchTuple</c>
    /// object, a request needs to match the settings in only one <c>ByteMatchTuple</c> to
    /// be considered a match.
    /// </para>
    /// </summary>
    public partial class RegexMatchSet
    {
        private string _name;
        private string _regexMatchSetId;
        private List<RegexMatchTuple> _regexMatchTuples = AWSConfigs.InitializeCollections ? new List<RegexMatchTuple>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>RegexMatchSet</a>. You can't change <c>Name</c>
        /// after you create a <c>RegexMatchSet</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property RegexMatchSetId. 
        /// <para>
        /// The <c>RegexMatchSetId</c> for a <c>RegexMatchSet</c>. You use <c>RegexMatchSetId</c>
        /// to get information about a <c>RegexMatchSet</c> (see <a>GetRegexMatchSet</a>), update
        /// a <c>RegexMatchSet</c> (see <a>UpdateRegexMatchSet</a>), insert a <c>RegexMatchSet</c>
        /// into a <c>Rule</c> or delete one from a <c>Rule</c> (see <a>UpdateRule</a>), and delete
        /// a <c>RegexMatchSet</c> from AWS WAF (see <a>DeleteRegexMatchSet</a>).
        /// </para>
        ///  
        /// <para>
        ///  <c>RegexMatchSetId</c> is returned by <a>CreateRegexMatchSet</a> and by <a>ListRegexMatchSets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property RegexMatchTuples. 
        /// <para>
        /// Contains an array of <a>RegexMatchTuple</a> objects. Each <c>RegexMatchTuple</c> object
        /// contains: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <c>User-Agent</c> header. 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegexMatchTuple> RegexMatchTuples
        {
            get { return this._regexMatchTuples; }
            set { this._regexMatchTuples = value; }
        }

        // Check to see if RegexMatchTuples property is set
        internal bool IsSetRegexMatchTuples()
        {
            return this._regexMatchTuples != null && (this._regexMatchTuples.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}