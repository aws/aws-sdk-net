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
    /// Describes an IPAM prefix list resolver target.
    /// 
    ///  
    /// <para>
    /// An IPAM prefix list resolver target is an association between a specific customer-managed
    /// prefix list and an IPAM prefix list resolver. The target enables the resolver to synchronize
    /// CIDRs selected by its rules into the specified prefix list, which can then be referenced
    /// in Amazon Web Services resources.
    /// </para>
    /// </summary>
    public partial class IpamPrefixListResolverTarget
    {
        private long? _desiredVersion;
        private string _ipamPrefixListResolverId;
        private string _ipamPrefixListResolverTargetArn;
        private string _ipamPrefixListResolverTargetId;
        private long? _lastSyncedVersion;
        private string _ownerId;
        private string _prefixListId;
        private string _prefixListRegion;
        private IpamPrefixListResolverTargetState _state;
        private string _stateMessage;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _trackLatestVersion;

        /// <summary>
        /// Gets and sets the property DesiredVersion. 
        /// <para>
        /// The desired version of the prefix list that this target should synchronize with.
        /// </para>
        /// </summary>
        public long DesiredVersion
        {
            get { return this._desiredVersion.GetValueOrDefault(); }
            set { this._desiredVersion = value; }
        }

        // Check to see if DesiredVersion property is set
        internal bool IsSetDesiredVersion()
        {
            return this._desiredVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver associated with this target.
        /// </para>
        /// </summary>
        public string IpamPrefixListResolverId
        {
            get { return this._ipamPrefixListResolverId; }
            set { this._ipamPrefixListResolverId = value; }
        }

        // Check to see if IpamPrefixListResolverId property is set
        internal bool IsSetIpamPrefixListResolverId()
        {
            return this._ipamPrefixListResolverId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverTargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IPAM prefix list resolver target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string IpamPrefixListResolverTargetArn
        {
            get { return this._ipamPrefixListResolverTargetArn; }
            set { this._ipamPrefixListResolverTargetArn = value; }
        }

        // Check to see if IpamPrefixListResolverTargetArn property is set
        internal bool IsSetIpamPrefixListResolverTargetArn()
        {
            return this._ipamPrefixListResolverTargetArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverTargetId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver target.
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
        /// Gets and sets the property LastSyncedVersion. 
        /// <para>
        /// The version of the prefix list that was last successfully synchronized by this target.
        /// </para>
        /// </summary>
        public long LastSyncedVersion
        {
            get { return this._lastSyncedVersion.GetValueOrDefault(); }
            set { this._lastSyncedVersion = value; }
        }

        // Check to see if LastSyncedVersion property is set
        internal bool IsSetLastSyncedVersion()
        {
            return this._lastSyncedVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the IPAM prefix list resolver
        /// target.
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
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the managed prefix list associated with this target.
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
        /// Gets and sets the property PrefixListRegion. 
        /// <para>
        /// The Amazon Web Services Region where the prefix list associated with this target is
        /// located.
        /// </para>
        /// </summary>
        public string PrefixListRegion
        {
            get { return this._prefixListRegion; }
            set { this._prefixListRegion = value; }
        }

        // Check to see if PrefixListRegion property is set
        internal bool IsSetPrefixListRegion()
        {
            return this._prefixListRegion != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the IPAM prefix list resolver target. Valid values include <c>create-in-progress</c>,
        /// <c>create-complete</c>, <c>create-failed</c>, <c>modify-in-progress</c>, <c>modify-complete</c>,
        /// <c>modify-failed</c>, <c>delete-in-progress</c>, <c>delete-complete</c>, and <c>delete-failed</c>.
        /// </para>
        /// </summary>
        public IpamPrefixListResolverTargetState State
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
        /// A message describing the current state of the IPAM prefix list resolver target, including
        /// any error information.
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
        /// The tags assigned to the IPAM prefix list resolver target.
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
        /// Gets and sets the property TrackLatestVersion. 
        /// <para>
        /// Indicates whether this target automatically tracks the latest version of the prefix
        /// list.
        /// </para>
        /// </summary>
        public bool TrackLatestVersion
        {
            get { return this._trackLatestVersion.GetValueOrDefault(); }
            set { this._trackLatestVersion = value; }
        }

        // Check to see if TrackLatestVersion property is set
        internal bool IsSetTrackLatestVersion()
        {
            return this._trackLatestVersion.HasValue; 
        }

    }
}