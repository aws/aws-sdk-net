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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFirewallPolicyV2 operation. Creates a Next
    /// Generation policy according to the specifications. <para> A Next Generation policy
    /// defines the behavior of a firewall in a collection of firewall engine and IPS engine
    /// rule groups and other settings. You can use one firewall policy for multiple firewalls.
    /// For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/firewall-policies-v2.html">Next
    /// Generation policies</a> in the <i>Network Firewall Developer Guide</i>. </para>
    /// </summary>
    public partial class CreateFirewallPolicyV2Request : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the firewall policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A complex type that contains settings for encryption of your firewall policy resources.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyV2. 
        /// <para>
        /// The rule groups and other settings that define the Next Generation policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FirewallPolicyV2 FirewallPolicyV2 { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyV2 property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyV2() => this.FirewallPolicyV2 != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyV2Name. 
        /// <para>
        /// The descriptive name of the Next Generation policy. You can't change the name of a
        /// firewall policy after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string FirewallPolicyV2Name { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyV2Name property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyV2Name() => this.FirewallPolicyV2Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
