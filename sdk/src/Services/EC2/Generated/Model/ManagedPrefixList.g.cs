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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a managed prefix list.
    /// </summary>
    public partial class ManagedPrefixList
    {
        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The IP address version.
        /// </para>
        /// </summary>
        public string AddressFamily { get; set; }

        /// <summary>
        /// Checks to see if the AddressFamily property is set.
        /// </summary>
        internal bool IsSetAddressFamily() => this.AddressFamily != null;

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverSyncEnabled. 
        /// <para>
        /// Indicates whether synchronization with an IPAM prefix list resolver is enabled for
        /// this managed prefix list. When enabled, the prefix list CIDRs are automatically updated
        /// based on the resolver's CIDR selection rules.
        /// </para>
        /// </summary>
        public bool? IpamPrefixListResolverSyncEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IpamPrefixListResolverSyncEnabled property is set.
        /// </summary>
        internal bool IsSetIpamPrefixListResolverSyncEnabled() => this.IpamPrefixListResolverSyncEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverTargetId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver target associated with this managed prefix
        /// list. When set, this prefix list becomes an IPAM managed prefix list.
        /// </para>
        ///  
        /// <para>
        /// An IPAM-managed prefix list is a customer-managed prefix list that has been associated
        /// with an IPAM prefix list resolver target. When a prefix list becomes IPAM managed,
        /// its CIDRs are automatically synchronized based on the IPAM prefix list resolver's
        /// CIDR selection rules, and direct CIDR modifications are restricted.
        /// </para>
        /// </summary>
        public string IpamPrefixListResolverTargetId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPrefixListResolverTargetId property is set.
        /// </summary>
        internal bool IsSetIpamPrefixListResolverTargetId() => this.IpamPrefixListResolverTargetId != null;

        /// <summary>
        /// Gets and sets the property MaxEntries. 
        /// <para>
        /// The maximum number of entries for the prefix list.
        /// </para>
        /// </summary>
        public int? MaxEntries { get; set; }

        /// <summary>
        /// Checks to see if the MaxEntries property is set.
        /// </summary>
        internal bool IsSetMaxEntries() => this.MaxEntries.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the owner of the prefix list.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PrefixListArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the prefix list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string PrefixListArn { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListArn property is set.
        /// </summary>
        internal bool IsSetPrefixListArn() => this.PrefixListArn != null;

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list.
        /// </para>
        /// </summary>
        public string PrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListId property is set.
        /// </summary>
        internal bool IsSetPrefixListId() => this.PrefixListId != null;

        /// <summary>
        /// Gets and sets the property PrefixListName. 
        /// <para>
        /// The name of the prefix list.
        /// </para>
        /// </summary>
        public string PrefixListName { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListName property is set.
        /// </summary>
        internal bool IsSetPrefixListName() => this.PrefixListName != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the prefix list.
        /// </para>
        /// </summary>
        public PrefixListState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// The state message.
        /// </para>
        /// </summary>
        public string StateMessage { get; set; }

        /// <summary>
        /// Checks to see if the StateMessage property is set.
        /// </summary>
        internal bool IsSetStateMessage() => this.StateMessage != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the prefix list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the prefix list.
        /// </para>
        /// </summary>
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
