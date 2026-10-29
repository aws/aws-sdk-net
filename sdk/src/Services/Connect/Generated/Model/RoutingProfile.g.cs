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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about a routing profile.
    /// </summary>
    public partial class RoutingProfile
    {
        /// <summary>
        /// Gets and sets the property AgentAvailabilityTimer. 
        /// <para>
        /// Whether agents with this routing profile will have their routing order calculated
        /// based on <i>time since their last inbound contact</i> or <i>longest idle time</i>.
        /// 
        /// </para>
        /// </summary>
        public AgentAvailabilityTimer AgentAvailabilityTimer { get; set; }

        /// <summary>
        /// Checks to see if the AgentAvailabilityTimer property is set.
        /// </summary>
        internal bool IsSetAgentAvailabilityTimer() => this.AgentAvailabilityTimer != null;

        /// <summary>
        /// Gets and sets the property AssociatedManualAssignmentQueueIds. 
        /// <para>
        /// The IDs of the associated manual assignment queues.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedManualAssignmentQueueIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedManualAssignmentQueueIds property is set.
        /// </summary>
        internal bool IsSetAssociatedManualAssignmentQueueIds() => this.AssociatedManualAssignmentQueueIds != null && (this.AssociatedManualAssignmentQueueIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssociatedQueueIds. 
        /// <para>
        /// The IDs of the associated queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedQueueIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedQueueIds property is set.
        /// </summary>
        internal bool IsSetAssociatedQueueIds() => this.AssociatedQueueIds != null && (this.AssociatedQueueIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultOutboundQueueId. 
        /// <para>
        /// The identifier of the default outbound queue for this routing profile.
        /// </para>
        /// </summary>
        public string DefaultOutboundQueueId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultOutboundQueueId property is set.
        /// </summary>
        internal bool IsSetDefaultOutboundQueueId() => this.DefaultOutboundQueueId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the routing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Whether this a default routing profile.
        /// </para>
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The Amazon Web Services Region where this resource was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedRegion property is set.
        /// </summary>
        internal bool IsSetLastModifiedRegion() => this.LastModifiedRegion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when this resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MediaConcurrencies. 
        /// <para>
        /// The channels agents can handle in the Contact Control Panel (CCP) for this routing
        /// profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaConcurrency> MediaConcurrencies { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaConcurrency>() : null;

        /// <summary>
        /// Checks to see if the MediaConcurrencies property is set.
        /// </summary>
        internal bool IsSetMediaConcurrencies() => this.MediaConcurrencies != null && (this.MediaConcurrencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the routing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberOfAssociatedManualAssignmentQueues. 
        /// <para>
        /// The number of associated manual assignment queues in routing profile.
        /// </para>
        /// </summary>
        public long? NumberOfAssociatedManualAssignmentQueues { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssociatedManualAssignmentQueues property is set.
        /// </summary>
        internal bool IsSetNumberOfAssociatedManualAssignmentQueues() => this.NumberOfAssociatedManualAssignmentQueues.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfAssociatedQueues. 
        /// <para>
        /// The number of associated queues in routing profile.
        /// </para>
        /// </summary>
        public long? NumberOfAssociatedQueues { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssociatedQueues property is set.
        /// </summary>
        internal bool IsSetNumberOfAssociatedQueues() => this.NumberOfAssociatedQueues.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfAssociatedUsers. 
        /// <para>
        /// The number of associated users in routing profile.
        /// </para>
        /// </summary>
        public long? NumberOfAssociatedUsers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssociatedUsers property is set.
        /// </summary>
        internal bool IsSetNumberOfAssociatedUsers() => this.NumberOfAssociatedUsers.HasValue;

        /// <summary>
        /// Gets and sets the property RoutingProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the routing profile.
        /// </para>
        /// </summary>
        public string RoutingProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the RoutingProfileArn property is set.
        /// </summary>
        internal bool IsSetRoutingProfileArn() => this.RoutingProfileArn != null;

        /// <summary>
        /// Gets and sets the property RoutingProfileId. 
        /// <para>
        /// The identifier of the routing profile.
        /// </para>
        /// </summary>
        public string RoutingProfileId { get; set; }

        /// <summary>
        /// Checks to see if the RoutingProfileId property is set.
        /// </summary>
        internal bool IsSetRoutingProfileId() => this.RoutingProfileId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
