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
    /// Container for the parameters to the CreateFirewallPolicy operation.
    /// Creates the firewall policy for the firewall according to the specifications. 
    /// 
    ///  
    /// <para>
    /// An Network Firewall firewall policy defines the behavior of a firewall, in a collection
    /// of stateless and stateful rule groups and other settings. You can use one firewall
    /// policy for multiple firewalls. 
    /// </para>
    /// </summary>
    public partial class CreateFirewallPolicyRequest : AmazonNetworkFirewallRequest
    {
        private string _description;
        private bool? _dryRun;
        private EncryptionConfiguration _encryptionConfiguration;
        private FirewallPolicy _firewallPolicy;
        private string _firewallPolicyName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Indicates whether you want Network Firewall to just check the validity of the request,
        /// rather than run the request. 
        /// </para>
        ///  
        /// <para>
        /// If set to <c>TRUE</c>, Network Firewall checks whether the request can run successfully,
        /// but doesn't actually make the requested changes. The call returns the value that the
        /// request would return if you ran it with dry run set to <c>FALSE</c>, but doesn't make
        /// additions or changes to your resources. This option allows you to make sure that you
        /// have the required permissions to run the request and that your request parameters
        /// are valid. 
        /// </para>
        ///  
        /// <para>
        /// If set to <c>FALSE</c>, Network Firewall makes the requested changes to your resources.
        /// 
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A complex type that contains settings for encryption of your firewall policy resources.
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
        /// Gets and sets the property FirewallPolicy. 
        /// <para>
        /// The rule groups and policy actions to use in the firewall policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FirewallPolicy FirewallPolicy
        {
            get { return this._firewallPolicy; }
            set { this._firewallPolicy = value; }
        }

        // Check to see if FirewallPolicy property is set
        internal bool IsSetFirewallPolicy()
        {
            return this._firewallPolicy != null;
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