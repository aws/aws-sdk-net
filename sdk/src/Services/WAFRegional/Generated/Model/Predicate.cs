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
    /// Specifies the <a>ByteMatchSet</a>, <a>IPSet</a>, <a>SqlInjectionMatchSet</a>, <a>XssMatchSet</a>,
    /// <a>RegexMatchSet</a>, <a>GeoMatchSet</a>, and <a>SizeConstraintSet</a> objects that
    /// you want to add to a <c>Rule</c> and, for each object, indicates whether you want
    /// to negate the settings, for example, requests that do NOT originate from the IP address
    /// 192.0.2.44. 
    /// </para>
    /// </summary>
    public partial class Predicate
    {
        private string _dataId;
        private bool? _negated;
        private PredicateType _type;

        /// <summary>
        /// Gets and sets the property DataId. 
        /// <para>
        /// A unique identifier for a predicate in a <c>Rule</c>, such as <c>ByteMatchSetId</c>
        /// or <c>IPSetId</c>. The ID is returned by the corresponding <c>Create</c> or <c>List</c>
        /// command.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DataId
        {
            get { return this._dataId; }
            set { this._dataId = value; }
        }

        // Check to see if DataId property is set
        internal bool IsSetDataId()
        {
            return this._dataId != null;
        }

        /// <summary>
        /// Gets and sets the property Negated. 
        /// <para>
        /// Set <c>Negated</c> to <c>False</c> if you want AWS WAF to allow, block, or count requests
        /// based on the settings in the specified <a>ByteMatchSet</a>, <a>IPSet</a>, <a>SqlInjectionMatchSet</a>,
        /// <a>XssMatchSet</a>, <a>RegexMatchSet</a>, <a>GeoMatchSet</a>, or <a>SizeConstraintSet</a>.
        /// For example, if an <c>IPSet</c> includes the IP address <c>192.0.2.44</c>, AWS WAF
        /// will allow or block requests based on that IP address.
        /// </para>
        ///  
        /// <para>
        /// Set <c>Negated</c> to <c>True</c> if you want AWS WAF to allow or block a request
        /// based on the negation of the settings in the <a>ByteMatchSet</a>, <a>IPSet</a>, <a>SqlInjectionMatchSet</a>,
        /// <a>XssMatchSet</a>, <a>RegexMatchSet</a>, <a>GeoMatchSet</a>, or <a>SizeConstraintSet</a>.
        /// For example, if an <c>IPSet</c> includes the IP address <c>192.0.2.44</c>, AWS WAF
        /// will allow, block, or count requests based on all IP addresses <i>except</i> <c>192.0.2.44</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Negated
        {
            get { return this._negated; }
            set { this._negated = value; }
        }

        // Check to see if Negated property is set
        internal bool IsSetNegated()
        {
            return this._negated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of predicate in a <c>Rule</c>, such as <c>ByteMatch</c> or <c>IPSet</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PredicateType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}