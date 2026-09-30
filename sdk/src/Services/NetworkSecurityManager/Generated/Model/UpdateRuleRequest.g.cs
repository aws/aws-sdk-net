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
    /// Container for the parameters to the UpdateRule operation. Updates the specified rule.
    /// To prevent conflicting concurrent updates, provide the current <c>updateToken</c>.
    /// Use <c>isPublished</c> to publish the update or keep the rule as a draft.
    /// </summary>
    public partial class UpdateRuleRequest : AmazonNetworkSecurityManagerRequest
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
        public Amazon.Runtime.Documents.Document Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => !this.Configuration.IsNull();

        /// <summary>
        /// Gets and sets the property IsPublished. 
        /// <para>
        /// Specifies whether to publish the resource. When <c>true</c>, the resource is saved
        /// in published (<c>ACTIVE</c>) state. When <c>false</c>, it is saved as a draft (<c>DRAFT</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// Gets and sets the property RuleIdentifier. 
        /// <para>
        /// The identifier of the rule. This is the rule's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1010)]
        public string RuleIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RuleIdentifier property is set.
        /// </summary>
        internal bool IsSetRuleIdentifier() => this.RuleIdentifier != null;

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// The type of the rule. <c>CONFIGURATION</c> rules contain firewall settings, and <c>INSPECTION</c>
        /// rules contain rule groups.
        /// </para>
        /// </summary>
        public RuleType RuleType { get; set; }

        /// <summary>
        /// Checks to see if the RuleType property is set.
        /// </summary>
        internal bool IsSetRuleType() => this.RuleType != null;

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic concurrency control. Each read and write returns an <c>updateToken</c>.
        /// Provide the most recent value on your next update to detect and prevent conflicting
        /// concurrent modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdateToken property is set.
        /// </summary>
        internal bool IsSetUpdateToken() => this.UpdateToken != null;
    }
}
