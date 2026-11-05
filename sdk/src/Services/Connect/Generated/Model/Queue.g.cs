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
    /// Contains information about a queue.
    /// </summary>
    public partial class Queue
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HoursOfOperationId. 
        /// <para>
        /// The identifier for the hours of operation.
        /// </para>
        /// </summary>
        public string HoursOfOperationId { get; set; }

        /// <summary>
        /// Checks to see if the HoursOfOperationId property is set.
        /// </summary>
        internal bool IsSetHoursOfOperationId() => this.HoursOfOperationId != null;

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
        /// Gets and sets the property MaxContacts. 
        /// <para>
        /// The maximum number of contacts that can be in the queue before it is considered full.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxContacts { get; set; }

        /// <summary>
        /// Checks to see if the MaxContacts property is set.
        /// </summary>
        internal bool IsSetMaxContacts() => this.MaxContacts.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutboundCallerConfig. 
        /// <para>
        /// The outbound caller ID name, number, and outbound whisper flow.
        /// </para>
        /// </summary>
        public OutboundCallerConfig OutboundCallerConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutboundCallerConfig property is set.
        /// </summary>
        internal bool IsSetOutboundCallerConfig() => this.OutboundCallerConfig != null;

        /// <summary>
        /// Gets and sets the property OutboundEmailConfig. 
        /// <para>
        /// The outbound email address ID for a specified queue.
        /// </para>
        /// </summary>
        public OutboundEmailConfig OutboundEmailConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutboundEmailConfig property is set.
        /// </summary>
        internal bool IsSetOutboundEmailConfig() => this.OutboundEmailConfig != null;

        /// <summary>
        /// Gets and sets the property QueueArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the queue.
        /// </para>
        /// </summary>
        public string QueueArn { get; set; }

        /// <summary>
        /// Checks to see if the QueueArn property is set.
        /// </summary>
        internal bool IsSetQueueArn() => this.QueueArn != null;

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The identifier for the queue.
        /// </para>
        /// </summary>
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the queue.
        /// </para>
        /// </summary>
        public QueueStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
