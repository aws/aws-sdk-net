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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the web access control list (web ACL). The web ACL contains
    /// the rules that identify the requests that you want to allow, block, or count.
    /// </summary>
    public partial class AwsWafRegionalWebAclDetails
    {
        private string _defaultAction;
        private string _metricName;
        private string _name;
        private List<AwsWafRegionalWebAclRulesListDetails> _rulesList = AWSConfigs.InitializeCollections ? new List<AwsWafRegionalWebAclRulesListDetails>() : null;
        private string _webAclId;

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// The action to perform if none of the rules contained in the web ACL match. 
        /// </para>
        /// </summary>
        public string DefaultAction
        {
            get { return this._defaultAction; }
            set { this._defaultAction = value; }
        }

        // Check to see if DefaultAction property is set
        internal bool IsSetDefaultAction()
        {
            return this._defaultAction != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A name for the metrics for this web ACL. 
        /// </para>
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
        /// A descriptive name for the web ACL. 
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
        /// Gets and sets the property RulesList. 
        /// <para>
        /// An array that contains the action for each rule in a web ACL, the priority of the
        /// rule, and the ID of the rule. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsWafRegionalWebAclRulesListDetails> RulesList
        {
            get { return this._rulesList; }
            set { this._rulesList = value; }
        }

        // Check to see if RulesList property is set
        internal bool IsSetRulesList()
        {
            return this._rulesList != null && (this._rulesList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WebAclId. 
        /// <para>
        /// The ID of the web ACL. 
        /// </para>
        /// </summary>
        public string WebAclId
        {
            get { return this._webAclId; }
            set { this._webAclId = value; }
        }

        // Check to see if WebAclId property is set
        internal bool IsSetWebAclId()
        {
            return this._webAclId != null;
        }

    }
}