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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
    /// Container for the parameters to the CreatePolicy operation.
    /// Creates a policy. A policy combines templates and rules with enforcement settings
    /// for a firewall type, such as AWS WAF or AWS Shield Advanced. Use <c>isPublished</c>
    /// to create the policy in published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state.
    /// </summary>
    public partial class CreatePolicyRequest : AmazonNetworkSecurityManagerRequest
    {
        private List<TemplateOrRuleReference> _associatedTemplateAndRuleList = AWSConfigs.InitializeCollections ? new List<TemplateOrRuleReference>() : null;
        private string _clientToken;
        private PolicyFirewallType _firewallType;
        private bool? _isPublished;
        private PolicyConfiguration _policyConfiguration;
        private string _policyDescription;
        private string _policyName;
        private int? _priority;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedTemplateAndRuleList. 
        /// <para>
        /// The templates and rules to associate with the policy. For AWS WAF policies, specify
        /// 1 to 100 templates or rules, of which at most 2 can be templates. For AWS Shield Advanced
        /// policies, this list must be empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<TemplateOrRuleReference> AssociatedTemplateAndRuleList
        {
            get { return this._associatedTemplateAndRuleList; }
            set { this._associatedTemplateAndRuleList = value; }
        }

        // Check to see if AssociatedTemplateAndRuleList property is set
        internal bool IsSetAssociatedTemplateAndRuleList()
        {
            return this._associatedTemplateAndRuleList != null && (this._associatedTemplateAndRuleList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure that the operation completes
        /// no more than one time. If you retry a request with the same client token and the same
        /// parameters, the service returns the result of the original successful request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallType. 
        /// <para>
        /// The firewall type associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyFirewallType FirewallType
        {
            get { return this._firewallType; }
            set { this._firewallType = value; }
        }

        // Check to see if FirewallType property is set
        internal bool IsSetFirewallType()
        {
            return this._firewallType != null;
        }

        /// <summary>
        /// Gets and sets the property IsPublished. 
        /// <para>
        /// Specifies whether to publish the resource. When <c>true</c>, the resource is saved
        /// in published (<c>ACTIVE</c>) state. When <c>false</c>, it is saved as a draft (<c>DRAFT</c>).
        /// Default: <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IsPublished
        {
            get { return this._isPublished; }
            set { this._isPublished = value; }
        }

        // Check to see if IsPublished property is set
        internal bool IsSetIsPublished()
        {
            return this._isPublished.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyConfiguration. 
        /// <para>
        /// The configuration settings that control the policy's behavior, including remediation
        /// and firewall-type-specific settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyConfiguration PolicyConfiguration
        {
            get { return this._policyConfiguration; }
            set { this._policyConfiguration = value; }
        }

        // Check to see if PolicyConfiguration property is set
        internal bool IsSetPolicyConfiguration()
        {
            return this._policyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDescription. 
        /// <para>
        /// A description of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string PolicyDescription
        {
            get { return this._policyDescription; }
            set { this._policyDescription = value; }
        }

        // Check to see if PolicyDescription property is set
        internal bool IsSetPolicyDescription()
        {
            return this._policyDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the resource. A lower number indicates a higher priority.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the resource when it is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}