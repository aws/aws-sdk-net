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
    /// Information of returned contact.
    /// </summary>
    public partial class ContactSearchSummary
    {
        /// <summary>
        /// Gets and sets the property AgentInfo. 
        /// <para>
        /// Information about the agent who accepted the contact.
        /// </para>
        /// </summary>
        public ContactSearchSummaryAgentInfo AgentInfo { get; set; }

        /// <summary>
        /// Checks to see if the AgentInfo property is set.
        /// </summary>
        internal bool IsSetAgentInfo() => this.AgentInfo != null;

        /// <summary>
        /// Gets and sets the property AiAgentInfo. 
        /// <para>
        /// Information about the AI agents involved in the contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContactSearchSummaryAiAgentInfo> AiAgentInfo { get; set; } = AWSConfigs.InitializeCollections ? new List<ContactSearchSummaryAiAgentInfo>() : null;

        /// <summary>
        /// Checks to see if the AiAgentInfo property is set.
        /// </summary>
        internal bool IsSetAiAgentInfo() => this.AiAgentInfo != null && (this.AiAgentInfo.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// How the contact reached your contact center.
        /// </para>
        /// </summary>
        public Channel Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property DisconnectTimestamp. 
        /// <para>
        /// The timestamp when the customer endpoint disconnected from Connect Customer.
        /// </para>
        /// </summary>
        public DateTime? DisconnectTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectTimestamp property is set.
        /// </summary>
        internal bool IsSetDisconnectTimestamp() => this.DisconnectTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property GlobalResiliencyMetadata. 
        /// <para>
        /// Additional routing information for contacts created in ACGR instances.
        /// </para>
        /// </summary>
        public GlobalResiliencyMetadata GlobalResiliencyMetadata { get; set; }

        /// <summary>
        /// Checks to see if the GlobalResiliencyMetadata property is set.
        /// </summary>
        internal bool IsSetGlobalResiliencyMetadata() => this.GlobalResiliencyMetadata != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the contact summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// If this contact is related to other contacts, this is the ID of the initial contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InitialContactId { get; set; }

        /// <summary>
        /// Checks to see if the InitialContactId property is set.
        /// </summary>
        internal bool IsSetInitialContactId() => this.InitialContactId != null;

        /// <summary>
        /// Gets and sets the property InitiationMethod. 
        /// <para>
        /// Indicates how the contact was initiated.
        /// </para>
        /// </summary>
        public ContactInitiationMethod InitiationMethod { get; set; }

        /// <summary>
        /// Checks to see if the InitiationMethod property is set.
        /// </summary>
        internal bool IsSetInitiationMethod() => this.InitiationMethod != null;

        /// <summary>
        /// Gets and sets the property InitiationTimestamp. 
        /// <para>
        /// The date and time this contact was initiated, in UTC time. For <c>INBOUND</c>, this
        /// is when the contact arrived. For <c>OUTBOUND</c>, this is when the agent began dialing.
        /// For <c>CALLBACK</c>, this is when the callback contact was created. For <c>TRANSFER</c>
        /// and <c>QUEUE_TRANSFER</c>, this is when the transfer was initiated. For API, this
        /// is when the request arrived. For <c>EXTERNAL_OUTBOUND</c>, this is when the agent
        /// started dialing the external participant. For <c>MONITOR</c>, this is when the supervisor
        /// started listening to a contact.
        /// </para>
        /// </summary>
        public DateTime? InitiationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the InitiationTimestamp property is set.
        /// </summary>
        internal bool IsSetInitiationTimestamp() => this.InitiationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Indicates name of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PreviousContactId. 
        /// <para>
        /// If this contact is not the first contact, this is the ID of the previous contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PreviousContactId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousContactId property is set.
        /// </summary>
        internal bool IsSetPreviousContactId() => this.PreviousContactId != null;

        /// <summary>
        /// Gets and sets the property QueueInfo. 
        /// <para>
        /// If this contact was queued, this contains information about the queue.
        /// </para>
        /// </summary>
        public ContactSearchSummaryQueueInfo QueueInfo { get; set; }

        /// <summary>
        /// Checks to see if the QueueInfo property is set.
        /// </summary>
        internal bool IsSetQueueInfo() => this.QueueInfo != null;

        /// <summary>
        /// Gets and sets the property RoutingCriteria.
        /// </summary>
        public RoutingCriteria RoutingCriteria { get; set; }

        /// <summary>
        /// Checks to see if the RoutingCriteria property is set.
        /// </summary>
        internal bool IsSetRoutingCriteria() => this.RoutingCriteria != null;

        /// <summary>
        /// Gets and sets the property ScheduledTimestamp. 
        /// <para>
        /// The timestamp, in Unix epoch time format, at which to start running the inbound flow.
        /// </para>
        /// </summary>
        public DateTime? ScheduledTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledTimestamp property is set.
        /// </summary>
        internal bool IsSetScheduledTimestamp() => this.ScheduledTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentAttributes. 
        /// <para>
        /// Set of segment attributes for a contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, ContactSearchSummarySegmentAttributeValue> SegmentAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ContactSearchSummarySegmentAttributeValue>() : null;

        /// <summary>
        /// Checks to see if the SegmentAttributes property is set.
        /// </summary>
        internal bool IsSetSegmentAttributes() => this.SegmentAttributes != null && (this.SegmentAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the contact. This contains both Amazon Web Services generated
        /// and user-defined tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 6)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
