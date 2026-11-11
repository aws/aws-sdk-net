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
        /// <summary>
        /// Gets and sets the property DesiredVersion. 
        /// <para>
        /// The desired version of the prefix list that this target should synchronize with.
        /// </para>
        /// </summary>
        public long? DesiredVersion { get; set; }

        /// <summary>
        /// Checks to see if the DesiredVersion property is set.
        /// </summary>
        internal bool IsSetDesiredVersion() => this.DesiredVersion.HasValue;

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver associated with this target.
        /// </para>
        /// </summary>
        public string IpamPrefixListResolverId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPrefixListResolverId property is set.
        /// </summary>
        internal bool IsSetIpamPrefixListResolverId() => this.IpamPrefixListResolverId != null;

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverTargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IPAM prefix list resolver target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string IpamPrefixListResolverTargetArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamPrefixListResolverTargetArn property is set.
        /// </summary>
        internal bool IsSetIpamPrefixListResolverTargetArn() => this.IpamPrefixListResolverTargetArn != null;

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverTargetId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver target.
        /// </para>
        /// </summary>
        public string IpamPrefixListResolverTargetId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPrefixListResolverTargetId property is set.
        /// </summary>
        internal bool IsSetIpamPrefixListResolverTargetId() => this.IpamPrefixListResolverTargetId != null;

        /// <summary>
        /// Gets and sets the property LastSyncedVersion. 
        /// <para>
        /// The version of the prefix list that was last successfully synchronized by this target.
        /// </para>
        /// </summary>
        public long? LastSyncedVersion { get; set; }

        /// <summary>
        /// Checks to see if the LastSyncedVersion property is set.
        /// </summary>
        internal bool IsSetLastSyncedVersion() => this.LastSyncedVersion.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the IPAM prefix list resolver
        /// target.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the managed prefix list associated with this target.
        /// </para>
        /// </summary>
        public string PrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListId property is set.
        /// </summary>
        internal bool IsSetPrefixListId() => this.PrefixListId != null;

        /// <summary>
        /// Gets and sets the property PrefixListRegion. 
        /// <para>
        /// The Amazon Web Services Region where the prefix list associated with this target is
        /// located.
        /// </para>
        /// </summary>
        public string PrefixListRegion { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListRegion property is set.
        /// </summary>
        internal bool IsSetPrefixListRegion() => this.PrefixListRegion != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the IPAM prefix list resolver target. Valid values include <c>create-in-progress</c>,
        /// <c>create-complete</c>, <c>create-failed</c>, <c>modify-in-progress</c>, <c>modify-complete</c>,
        /// <c>modify-failed</c>, <c>delete-in-progress</c>, <c>delete-complete</c>, and <c>delete-failed</c>.
        /// </para>
        /// </summary>
        public IpamPrefixListResolverTargetState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A message describing the current state of the IPAM prefix list resolver target, including
        /// any error information.
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
        /// The tags assigned to the IPAM prefix list resolver target.
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
        /// Gets and sets the property TrackLatestVersion. 
        /// <para>
        /// Indicates whether this target automatically tracks the latest version of the prefix
        /// list.
        /// </para>
        /// </summary>
        public bool? TrackLatestVersion { get; set; }

        /// <summary>
        /// Checks to see if the TrackLatestVersion property is set.
        /// </summary>
        internal bool IsSetTrackLatestVersion() => this.TrackLatestVersion.HasValue;
    }
}
