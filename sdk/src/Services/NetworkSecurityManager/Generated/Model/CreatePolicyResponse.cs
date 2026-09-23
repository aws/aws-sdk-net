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
    /// This is the response object from the CreatePolicy operation.
    /// </summary>
    public partial class CreatePolicyResponse : AmazonWebServiceResponse
    {
        private List<AssociatedTemplateOrRule> _associatedTemplateAndRuleList = AWSConfigs.InitializeCollections ? new List<AssociatedTemplateOrRule>() : null;
        private PolicyFirewallType _firewallType;
        private bool? _hasPublishedVersion;
        private bool? _isSnapshot;
        private string _policyArn;
        private PolicyConfiguration _policyConfiguration;
        private string _policyDescription;
        private string _policyId;
        private string _policyName;
        private int? _priority;
        private EntityStatus _status;
        private DateTime? _updatedAt;
        private string _updateToken;
        private string _version;

        /// <summary>
        /// Gets and sets the property AssociatedTemplateAndRuleList. 
        /// <para>
        /// The templates and rules associated with the policy. For AWS WAF policies, this list
        /// contains 1 to 100 templates or rules, of which at most 2 can be templates. For AWS
        /// Shield Advanced policies, this list is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<AssociatedTemplateOrRule> AssociatedTemplateAndRuleList
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
        /// Gets and sets the property HasPublishedVersion. 
        /// <para>
        /// Specifies whether a published version of the resource exists.
        /// </para>
        /// </summary>
        public bool? HasPublishedVersion
        {
            get { return this._hasPublishedVersion; }
            set { this._hasPublishedVersion = value; }
        }

        // Check to see if HasPublishedVersion property is set
        internal bool IsSetHasPublishedVersion()
        {
            return this._hasPublishedVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsSnapshot. 
        /// <para>
        /// Specifies whether the resource is a snapshot of a published version.
        /// </para>
        /// </summary>
        public bool? IsSnapshot
        {
            get { return this._isSnapshot; }
            set { this._isSnapshot = value; }
        }

        // Check to see if IsSnapshot property is set
        internal bool IsSetIsSnapshot()
        {
            return this._isSnapshot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1010)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
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
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The service-generated id of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the resource: <c>DRAFT</c> (unpublished, editable) or <c>ACTIVE</c>
        /// (published, in use).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntityStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the resource was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic concurrency control. Each read and write returns an <c>updateToken</c>.
        /// Provide the most recent value on your next update to detect and prevent conflicting
        /// concurrent modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}