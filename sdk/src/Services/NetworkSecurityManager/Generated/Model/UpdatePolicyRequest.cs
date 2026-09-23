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
    /// Container for the parameters to the UpdatePolicy operation.
    /// Updates the specified policy. To prevent conflicting concurrent updates, provide the
    /// current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep the
    /// policy as a draft.
    /// </summary>
    public partial class UpdatePolicyRequest : AmazonNetworkSecurityManagerRequest
    {
        private List<TemplateOrRuleReference> _associatedTemplateAndRuleList = AWSConfigs.InitializeCollections ? new List<TemplateOrRuleReference>() : null;
        private string _clientToken;
        private bool? _isPublished;
        private PolicyConfiguration _policyConfiguration;
        private string _policyDescription;
        private string _policyIdentifier;
        private int? _priority;
        private string _updateToken;

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
        /// Gets and sets the property IsPublished. 
        /// <para>
        /// Specifies whether to publish the resource. When <c>true</c>, the resource is saved
        /// in published (<c>ACTIVE</c>) state. When <c>false</c>, it is saved as a draft (<c>DRAFT</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PolicyIdentifier. 
        /// <para>
        /// The identifier of the policy. This is the policy's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1010)]
        public string PolicyIdentifier
        {
            get { return this._policyIdentifier; }
            set { this._policyIdentifier = value; }
        }

        // Check to see if PolicyIdentifier property is set
        internal bool IsSetPolicyIdentifier()
        {
            return this._policyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the resource. A lower number indicates a higher priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic concurrency control. Each read and write returns an <c>updateToken</c>.
        /// Provide the most recent value on your next update to detect and prevent conflicting
        /// concurrent modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}