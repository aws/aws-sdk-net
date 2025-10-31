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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _addressFamily;
        private bool? _ipamPrefixListResolverSyncEnabled;
        private string _ipamPrefixListResolverTargetId;
        private int? _maxEntries;
        private string _ownerId;
        private string _prefixListArn;
        private string _prefixListId;
        private string _prefixListName;
        private PrefixListState _state;
        private string _stateMessage;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private long? _version;

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The IP address version.
        /// </para>
        /// </summary>
        public string AddressFamily
        {
            get { return this._addressFamily; }
            set { this._addressFamily = value; }
        }

        // Check to see if AddressFamily property is set
        internal bool IsSetAddressFamily()
        {
            return this._addressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverSyncEnabled. 
        /// <para>
        /// Indicates whether synchronization with an IPAM prefix list resolver is enabled for
        /// this managed prefix list. When enabled, the prefix list CIDRs are automatically updated
        /// based on the resolver's CIDR selection rules.
        /// </para>
        /// </summary>
        public bool IpamPrefixListResolverSyncEnabled
        {
            get { return this._ipamPrefixListResolverSyncEnabled.GetValueOrDefault(); }
            set { this._ipamPrefixListResolverSyncEnabled = value; }
        }

        // Check to see if IpamPrefixListResolverSyncEnabled property is set
        internal bool IsSetIpamPrefixListResolverSyncEnabled()
        {
            return this._ipamPrefixListResolverSyncEnabled.HasValue; 
        }

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
        public string IpamPrefixListResolverTargetId
        {
            get { return this._ipamPrefixListResolverTargetId; }
            set { this._ipamPrefixListResolverTargetId = value; }
        }

        // Check to see if IpamPrefixListResolverTargetId property is set
        internal bool IsSetIpamPrefixListResolverTargetId()
        {
            return this._ipamPrefixListResolverTargetId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxEntries. 
        /// <para>
        /// The maximum number of entries for the prefix list.
        /// </para>
        /// </summary>
        public int MaxEntries
        {
            get { return this._maxEntries.GetValueOrDefault(); }
            set { this._maxEntries = value; }
        }

        // Check to see if MaxEntries property is set
        internal bool IsSetMaxEntries()
        {
            return this._maxEntries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the owner of the prefix list.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the prefix list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string PrefixListArn
        {
            get { return this._prefixListArn; }
            set { this._prefixListArn = value; }
        }

        // Check to see if PrefixListArn property is set
        internal bool IsSetPrefixListArn()
        {
            return this._prefixListArn != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list.
        /// </para>
        /// </summary>
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListName. 
        /// <para>
        /// The name of the prefix list.
        /// </para>
        /// </summary>
        public string PrefixListName
        {
            get { return this._prefixListName; }
            set { this._prefixListName = value; }
        }

        // Check to see if PrefixListName property is set
        internal bool IsSetPrefixListName()
        {
            return this._prefixListName != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the prefix list.
        /// </para>
        /// </summary>
        public PrefixListState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// The state message.
        /// </para>
        /// </summary>
        public string StateMessage
        {
            get { return this._stateMessage; }
            set { this._stateMessage = value; }
        }

        // Check to see if StateMessage property is set
        internal bool IsSetStateMessage()
        {
            return this._stateMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the prefix list.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the prefix list.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}