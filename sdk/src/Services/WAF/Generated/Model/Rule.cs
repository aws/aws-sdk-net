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
    /// A combination of <a>ByteMatchSet</a>, <a>IPSet</a>, and/or <a>SqlInjectionMatchSet</a>
    /// objects that identify the web requests that you want to allow, block, or count. For
    /// example, you might create a <code>Rule</code> that includes the following predicates:
    /// 
    ///  <ul> <li>An <code>IPSet</code> that causes AWS WAF to search for web requests that
    /// originate from the IP address <code>192.0.2.44</code> </li> <li>A <code>ByteMatchSet</code>
    /// that causes AWS WAF to search for web requests for which the value of the <code>User-Agent</code>
    /// header is <code>BadBot</code>.</li> </ul> 
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
        /// </summary>
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
        /// <code>RuleId</code> is returned by <a>CreateRule</a> and by <a>ListRules</a>.
        /// </para>
        /// </summary>
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