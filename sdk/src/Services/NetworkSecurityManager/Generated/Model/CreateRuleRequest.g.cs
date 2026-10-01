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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRule operation. Creates a rule. A rule defines
    /// a network security configuration to enforce, such as an AWS WAF rule group or configuration
    /// data. Use <c>isPublished</c> to create the rule in published (<c>ACTIVE</c>) or draft
    /// (<c>DRAFT</c>) state.
    /// </summary>
    public partial class CreateRuleRequest : AmazonNetworkSecurityManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure that the operation completes
        /// no more than one time. If you retry a request with the same client token and the same
        /// parameters, the service returns the result of the original successful request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The firewall configuration for the rule, as a JSON document. The structure depends
        /// on the rule's firewall type and rule type. For an AWS WAF <c>INSPECTION</c> rule,
        /// provide an AWS WAF rule group. For an AWS WAF <c>CONFIGURATION</c> rule, provide a
        /// single web ACL setting, such as <c>DefaultAction</c> or <c>VisibilityConfig</c>; use
        /// <c>wafConfigDataType</c> to declare which setting the document contains. For the schema
        /// of each setting and complete examples, see <a href="https://docs.aws.amazon.com/network-security-manager/latest/devguide/what-is.html">Writing
        /// rule configurations</a> in the <i>AWS Network Security Manager Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amazon.Runtime.Documents.Document Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => !this.Configuration.IsNull();

        /// <summary>
        /// Gets and sets the property FirewallType. 
        /// <para>
        /// The firewall type associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleFirewallType FirewallType { get; set; }

        /// <summary>
        /// Checks to see if the FirewallType property is set.
        /// </summary>
        internal bool IsSetFirewallType() => this.FirewallType != null;

        /// <summary>
        /// Gets and sets the property IsPublished. 
        /// <para>
        /// Specifies whether to publish the resource. When <c>true</c>, the resource is saved
        /// in published (<c>ACTIVE</c>) state. When <c>false</c>, it is saved as a draft (<c>DRAFT</c>).
        /// Default: <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Checks to see if the IsPublished property is set.
        /// </summary>
        internal bool IsSetIsPublished() => this.IsPublished.HasValue;

        /// <summary>
        /// Gets and sets the property RuleDescription. 
        /// <para>
        /// A description of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// Checks to see if the RuleDescription property is set.
        /// </summary>
        internal bool IsSetRuleDescription() => this.RuleDescription != null;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleName property is set.
        /// </summary>
        internal bool IsSetRuleName() => this.RuleName != null;

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// The type of the rule. <c>CONFIGURATION</c> rules contain firewall settings, and <c>INSPECTION</c>
        /// rules contain rule groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleType RuleType { get; set; }

        /// <summary>
        /// Checks to see if the RuleType property is set.
        /// </summary>
        internal bool IsSetRuleType() => this.RuleType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the resource when it is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
