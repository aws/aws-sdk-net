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
    /// Container for the parameters to the CreateRoutingProfile operation. Creates a new
    /// routing profile.
    /// </summary>
    public partial class CreateRoutingProfileRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AgentAvailabilityTimer. 
        /// <para>
        /// Whether agents with this routing profile will have their routing order calculated
        /// based on <i>longest idle time</i> or <i>time since their last inbound contact</i>.
        /// 
        /// </para>
        /// </summary>
        public AgentAvailabilityTimer AgentAvailabilityTimer { get; set; }

        /// <summary>
        /// Checks to see if the AgentAvailabilityTimer property is set.
        /// </summary>
        internal bool IsSetAgentAvailabilityTimer() => this.AgentAvailabilityTimer != null;

        /// <summary>
        /// Gets and sets the property DefaultOutboundQueueId. 
        /// <para>
        /// The default outbound queue for the routing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DefaultOutboundQueueId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultOutboundQueueId property is set.
        /// </summary>
        internal bool IsSetDefaultOutboundQueueId() => this.DefaultOutboundQueueId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the routing profile. Must not be more than 250 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 250)]
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
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property ManualAssignmentQueueConfigs. 
        /// <para>
        /// The manual assignment queues associated with the routing profile. If no queue is added,
        /// agents and supervisors can't pick or assign any contacts from this routing profile.
        /// The limit of 10 array members applies to the maximum number of RoutingProfileManualAssignmentQueueConfig
        /// objects that can be passed during a CreateRoutingProfile API request. It is different
        /// from the quota of 50 queues per routing profile per instance that is listed in Connect
        /// Customer service quotas.
        /// </para>
        ///  <note> 
        /// <para>
        /// For voice contacts, manual assignment supports only agent-first callback contacts.
        /// Chat, email, and task contacts are fully supported.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<RoutingProfileManualAssignmentQueueConfig> ManualAssignmentQueueConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutingProfileManualAssignmentQueueConfig>() : null;

        /// <summary>
        /// Checks to see if the ManualAssignmentQueueConfigs property is set.
        /// </summary>
        internal bool IsSetManualAssignmentQueueConfigs() => this.ManualAssignmentQueueConfigs != null && (this.ManualAssignmentQueueConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MediaConcurrencies. 
        /// <para>
        /// The channels that agents can handle in the Contact Control Panel (CCP) for this routing
        /// profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<MediaConcurrency> MediaConcurrencies { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaConcurrency>() : null;

        /// <summary>
        /// Checks to see if the MediaConcurrencies property is set.
        /// </summary>
        internal bool IsSetMediaConcurrencies() => this.MediaConcurrencies != null && (this.MediaConcurrencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the routing profile. Must not be more than 127 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property QueueConfigs. 
        /// <para>
        /// The inbound queues associated with the routing profile. If no queue is added, the
        /// agent can make only outbound calls.
        /// </para>
        ///  
        /// <para>
        /// The limit of 10 array members applies to the maximum number of <c>RoutingProfileQueueConfig</c>
        /// objects that can be passed during a CreateRoutingProfile API request. It is different
        /// from the quota of 50 queues per routing profile per instance that is listed in <a
        /// href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Connect
        /// Customer service quotas</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<RoutingProfileQueueConfig> QueueConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutingProfileQueueConfig>() : null;

        /// <summary>
        /// Checks to see if the QueueConfigs property is set.
        /// </summary>
        internal bool IsSetQueueConfigs() => this.QueueConfigs != null && (this.QueueConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

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
