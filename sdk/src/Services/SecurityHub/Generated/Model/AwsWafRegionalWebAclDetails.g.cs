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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// The action to perform if none of the rules contained in the web ACL match. 
        /// </para>
        /// </summary>
        public string DefaultAction { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAction property is set.
        /// </summary>
        internal bool IsSetDefaultAction() => this.DefaultAction != null;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A name for the metrics for this web ACL. 
        /// </para>
        /// </summary>
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the web ACL. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RulesList. 
        /// <para>
        /// An array that contains the action for each rule in a web ACL, the priority of the
        /// rule, and the ID of the rule. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsWafRegionalWebAclRulesListDetails> RulesList { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsWafRegionalWebAclRulesListDetails>() : null;

        /// <summary>
        /// Checks to see if the RulesList property is set.
        /// </summary>
        internal bool IsSetRulesList() => this.RulesList != null && (this.RulesList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WebAclId. 
        /// <para>
        /// The ID of the web ACL. 
        /// </para>
        /// </summary>
        public string WebAclId { get; set; }

        /// <summary>
        /// Checks to see if the WebAclId property is set.
        /// </summary>
        internal bool IsSetWebAclId() => this.WebAclId != null;
    }
}
