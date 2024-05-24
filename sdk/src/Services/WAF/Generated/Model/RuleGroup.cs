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
    /// A collection of predefined rules that you can add to a web ACL.
    /// </para>
    ///  
    /// <para>
    /// Rule groups are subject to the following limits:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Three rule groups per account. You can request an increase to this limit by contacting
    /// customer support.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// One rule group per web ACL.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Ten rules per rule group.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RuleGroup
    {
        private string _metricName;
        private string _name;
        private string _ruleGroupId;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A friendly name or description for the metrics for this <c>RuleGroup</c>. The name
        /// can contain only alphanumeric characters (A-Z, a-z, 0-9), with maximum length 128
        /// and minimum length one. It can't contain whitespace or metric names reserved for AWS
        /// WAF, including "All" and "Default_Action." You can't change the name of the metric
        /// after you create the <c>RuleGroup</c>.
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
        /// The friendly name or description for the <c>RuleGroup</c>. You can't change the name
        /// of a <c>RuleGroup</c> after you create it.
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
        /// Gets and sets the property RuleGroupId. 
        /// <para>
        /// A unique identifier for a <c>RuleGroup</c>. You use <c>RuleGroupId</c> to get more
        /// information about a <c>RuleGroup</c> (see <a>GetRuleGroup</a>), update a <c>RuleGroup</c>
        /// (see <a>UpdateRuleGroup</a>), insert a <c>RuleGroup</c> into a <c>WebACL</c> or delete
        /// a one from a <c>WebACL</c> (see <a>UpdateWebACL</a>), or delete a <c>RuleGroup</c>
        /// from AWS WAF (see <a>DeleteRuleGroup</a>).
        /// </para>
        ///  
        /// <para>
        ///  <c>RuleGroupId</c> is returned by <a>CreateRuleGroup</a> and by <a>ListRuleGroups</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RuleGroupId
        {
            get { return this._ruleGroupId; }
            set { this._ruleGroupId = value; }
        }

        // Check to see if RuleGroupId property is set
        internal bool IsSetRuleGroupId()
        {
            return this._ruleGroupId != null;
        }

    }
}