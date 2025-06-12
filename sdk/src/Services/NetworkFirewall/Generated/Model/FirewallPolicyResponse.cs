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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The high-level properties of a firewall policy. This, along with the <a>FirewallPolicy</a>,
    /// define the policy. You can retrieve all objects for a firewall policy by calling <a>DescribeFirewallPolicy</a>.
    /// </summary>
    public partial class FirewallPolicyResponse
    {
        private int? _consumedStatefulRuleCapacity;
        private int? _consumedStatelessRuleCapacity;
        private string _description;
        private EncryptionConfiguration _encryptionConfiguration;
        private string _firewallPolicyArn;
        private string _firewallPolicyId;
        private string _firewallPolicyName;
        private ResourceStatus _firewallPolicyStatus;
        private DateTime? _lastModifiedTime;
        private int? _numberOfAssociations;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ConsumedStatefulRuleCapacity. 
        /// <para>
        /// The number of capacity units currently consumed by the policy's stateful rules.
        /// </para>
        /// </summary>
        public int? ConsumedStatefulRuleCapacity
        {
            get { return this._consumedStatefulRuleCapacity; }
            set { this._consumedStatefulRuleCapacity = value; }
        }

        // Check to see if ConsumedStatefulRuleCapacity property is set
        internal bool IsSetConsumedStatefulRuleCapacity()
        {
            return this._consumedStatefulRuleCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumedStatelessRuleCapacity. 
        /// <para>
        /// The number of capacity units currently consumed by the policy's stateless rules.
        /// </para>
        /// </summary>
        public int? ConsumedStatelessRuleCapacity
        {
            get { return this._consumedStatelessRuleCapacity; }
            set { this._consumedStatelessRuleCapacity = value; }
        }

        // Check to see if ConsumedStatelessRuleCapacity property is set
        internal bool IsSetConsumedStatelessRuleCapacity()
        {
            return this._consumedStatelessRuleCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the firewall policy.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A complex type that contains the Amazon Web Services KMS encryption configuration
        /// settings for your firewall policy.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall policy.
        /// </para>
        ///  <note> 
        /// <para>
        /// If this response is for a create request that had <c>DryRun</c> set to <c>TRUE</c>,
        /// then this ARN is a placeholder that isn't attached to a valid resource.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FirewallPolicyArn
        {
            get { return this._firewallPolicyArn; }
            set { this._firewallPolicyArn = value; }
        }

        // Check to see if FirewallPolicyArn property is set
        internal bool IsSetFirewallPolicyArn()
        {
            return this._firewallPolicyArn != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallPolicyId. 
        /// <para>
        /// The unique identifier for the firewall policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string FirewallPolicyId
        {
            get { return this._firewallPolicyId; }
            set { this._firewallPolicyId = value; }
        }

        // Check to see if FirewallPolicyId property is set
        internal bool IsSetFirewallPolicyId()
        {
            return this._firewallPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallPolicyName. 
        /// <para>
        /// The descriptive name of the firewall policy. You can't change the name of a firewall
        /// policy after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string FirewallPolicyName
        {
            get { return this._firewallPolicyName; }
            set { this._firewallPolicyName = value; }
        }

        // Check to see if FirewallPolicyName property is set
        internal bool IsSetFirewallPolicyName()
        {
            return this._firewallPolicyName != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallPolicyStatus. 
        /// <para>
        /// The current status of the firewall policy. You can retrieve this for a firewall policy
        /// by calling <a>DescribeFirewallPolicy</a> and providing the firewall policy's name
        /// or ARN.
        /// </para>
        /// </summary>
        public ResourceStatus FirewallPolicyStatus
        {
            get { return this._firewallPolicyStatus; }
            set { this._firewallPolicyStatus = value; }
        }

        // Check to see if FirewallPolicyStatus property is set
        internal bool IsSetFirewallPolicyStatus()
        {
            return this._firewallPolicyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that the firewall policy was changed.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfAssociations. 
        /// <para>
        /// The number of firewalls that are associated with this firewall policy.
        /// </para>
        /// </summary>
        public int? NumberOfAssociations
        {
            get { return this._numberOfAssociations; }
            set { this._numberOfAssociations = value; }
        }

        // Check to see if NumberOfAssociations property is set
        internal bool IsSetNumberOfAssociations()
        {
            return this._numberOfAssociations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
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