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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeManagedRuleGroup operation.
    /// </summary>
    public partial class DescribeManagedRuleGroupResponse : AmazonWebServiceResponse
    {
        private List<LabelSummary> _availableLabels = new List<LabelSummary>();
        private long? _capacity;
        private List<LabelSummary> _consumedLabels = new List<LabelSummary>();
        private string _labelNamespace;
        private List<RuleSummary> _rules = new List<RuleSummary>();
        private string _snsTopicArn;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property AvailableLabels. 
        /// <para>
        /// The labels that one or more rules in this rule group add to matching web requests.
        /// These labels are defined in the <code>RuleLabels</code> for a <a>Rule</a>.
        /// </para>
        /// </summary>
        public List<LabelSummary> AvailableLabels
        {
            get { return this._availableLabels; }
            set { this._availableLabels = value; }
        }

        // Check to see if AvailableLabels property is set
        internal bool IsSetAvailableLabels()
        {
            return this._availableLabels != null && this._availableLabels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The web ACL capacity units (WCUs) required for this rule group. WAF uses web ACL capacity
        /// units (WCU) to calculate and control the operating resources that are used to run
        /// your rules, rule groups, and web ACLs. WAF calculates capacity differently for each
        /// rule type, to reflect each rule's relative cost. Rule group capacity is fixed at creation,
        /// so users can plan their web ACL WCU usage when they use a rule group. The WCU limit
        /// for web ACLs is 1,500. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long Capacity
        {
            get { return this._capacity.GetValueOrDefault(); }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumedLabels. 
        /// <para>
        /// The labels that one or more rules in this rule group match against in label match
        /// statements. These labels are defined in a <code>LabelMatchStatement</code> specification,
        /// in the <a>Statement</a> definition of a rule. 
        /// </para>
        /// </summary>
        public List<LabelSummary> ConsumedLabels
        {
            get { return this._consumedLabels; }
            set { this._consumedLabels = value; }
        }

        // Check to see if ConsumedLabels property is set
        internal bool IsSetConsumedLabels()
        {
            return this._consumedLabels != null && this._consumedLabels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LabelNamespace. 
        /// <para>
        /// The label namespace prefix for this rule group. All labels added by rules in this
        /// rule group have this prefix. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The syntax for the label namespace prefix for a managed rule group is the following:
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>awswaf:managed:&lt;vendor&gt;:&lt;rule group name&gt;</code>:
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When a rule with a label matches a web request, WAF adds the fully qualified label
        /// to the request. A fully qualified label is made up of the label namespace from the
        /// rule group or web ACL where the rule is defined and the label from the rule, separated
        /// by a colon: 
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;label namespace&gt;:&lt;label from rule&gt;</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string LabelNamespace
        {
            get { return this._labelNamespace; }
            set { this._labelNamespace = value; }
        }

        // Check to see if LabelNamespace property is set
        internal bool IsSetLabelNamespace()
        {
            return this._labelNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Rules.
        /// </summary>
        public List<RuleSummary> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the Amazon Simple Notification Service SNS topic
        /// that's used to record changes to the managed rule group. You can subscribe to the
        /// SNS topic to receive notifications when the managed rule group is modified, such as
        /// for new versions and for version expiration. For more information, see the <a href="https://docs.aws.amazon.com/sns/latest/dg/welcome.html">Amazon
        /// Simple Notification Service Developer Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The managed rule group's version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}