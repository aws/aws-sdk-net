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
    /// A combination of <a>ByteMatchSet</a>, <a>IPSet</a>, and/or <a>SqlInjectionMatchSet</a>
    /// objects that identify the web requests that you want to allow, block, or count. For
    /// example, you might create a <c>Rule</c> that includes the following predicates:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An <c>IPSet</c> that causes AWS WAF to search for web requests that originate from
    /// the IP address <c>192.0.2.44</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>ByteMatchSet</c> that causes AWS WAF to search for web requests for which the
    /// value of the <c>User-Agent</c> header is <c>BadBot</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To match the settings in this <c>Rule</c>, a request must originate from <c>192.0.2.44</c>
    /// AND include a <c>User-Agent</c> header for which the value is <c>BadBot</c>.
    /// </para>
    /// </summary>
    public partial class Rule
    {
        private string _metricName;
        private string _name;
        private List<Predicate> _predicates = AWSConfigs.InitializeCollections ? new List<Predicate>() : null;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A friendly name or description for the metrics for this <c>Rule</c>. The name can
        /// contain only alphanumeric characters (A-Z, a-z, 0-9), with maximum length 128 and
        /// minimum length one. It can't contain whitespace or metric names reserved for AWS WAF,
        /// including "All" and "Default_Action." You can't change <c>MetricName</c> after you
        /// create the <c>Rule</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name or description for the <c>Rule</c>. You can't change the name of
        /// a <c>Rule</c> after you create it.
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
        /// Gets and sets the property Predicates. 
        /// <para>
        /// The <c>Predicates</c> object contains one <c>Predicate</c> element for each <a>ByteMatchSet</a>,
        /// <a>IPSet</a>, or <a>SqlInjectionMatchSet</a> object that you want to include in a
        /// <c>Rule</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Predicate> Predicates
        {
            get { return this._predicates; }
            set { this._predicates = value; }
        }

        // Check to see if Predicates property is set
        internal bool IsSetPredicates()
        {
            return this._predicates != null && (this._predicates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// A unique identifier for a <c>Rule</c>. You use <c>RuleId</c> to get more information
        /// about a <c>Rule</c> (see <a>GetRule</a>), update a <c>Rule</c> (see <a>UpdateRule</a>),
        /// insert a <c>Rule</c> into a <c>WebACL</c> or delete a one from a <c>WebACL</c> (see
        /// <a>UpdateWebACL</a>), or delete a <c>Rule</c> from AWS WAF (see <a>DeleteRule</a>).
        /// </para>
        ///  
        /// <para>
        ///  <c>RuleId</c> is returned by <a>CreateRule</a> and by <a>ListRules</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

    }
}