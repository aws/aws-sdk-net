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
    /// A combination of <a>ByteMatchSet</a>, <a>IPSet</a>, and/or <a>SqlInjectionMatchSet</a>
    /// objects that identify the web requests that you want to allow, block, or count. For
    /// example, you might create a <code>Rule</code> that includes the following predicates:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An <code>IPSet</code> that causes AWS WAF to search for web requests that originate
    /// from the IP address <code>192.0.2.44</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <code>ByteMatchSet</code> that causes AWS WAF to search for web requests for which
    /// the value of the <code>User-Agent</code> header is <code>BadBot</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To match the settings in this <code>Rule</code>, a request must originate from <code>192.0.2.44</code>
    /// AND include a <code>User-Agent</code> header for which the value is <code>BadBot</code>.
    /// </para>
    /// </summary>
    public partial class Rule
    {
        private string _metricName;
        private string _name;
        private List<Predicate> _predicates = new List<Predicate>();
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A friendly name or description for the metrics for this <code>Rule</code>. The name
        /// can contain only alphanumeric characters (A-Z, a-z, 0-9), with maximum length 128
        /// and minimum length one. It can't contain whitespace or metric names reserved for AWS
        /// WAF, including "All" and "Default_Action." You can't change <code>MetricName</code>
        /// after you create the <code>Rule</code>.
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
        /// The friendly name or description for the <code>Rule</code>. You can't change the name
        /// of a <code>Rule</code> after you create it.
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
        /// The <code>Predicates</code> object contains one <code>Predicate</code> element for
        /// each <a>ByteMatchSet</a>, <a>IPSet</a>, or <a>SqlInjectionMatchSet</a> object that
        /// you want to include in a <code>Rule</code>.
        /// </para>
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
            return this._predicates != null && this._predicates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// A unique identifier for a <code>Rule</code>. You use <code>RuleId</code> to get more
        /// information about a <code>Rule</code> (see <a>GetRule</a>), update a <code>Rule</code>
        /// (see <a>UpdateRule</a>), insert a <code>Rule</code> into a <code>WebACL</code> or
        /// delete a one from a <code>WebACL</code> (see <a>UpdateWebACL</a>), or delete a <code>Rule</code>
        /// from AWS WAF (see <a>DeleteRule</a>).
        /// </para>
        ///  
        /// <para>
        ///  <code>RuleId</code> is returned by <a>CreateRule</a> and by <a>ListRules</a>.
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