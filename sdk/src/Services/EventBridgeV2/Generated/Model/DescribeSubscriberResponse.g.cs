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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeSubscriber operation.
    /// </summary>
    public partial class DescribeSubscriberResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BatchConfiguration. 
        /// <para>
        /// Batching configuration for a subscriber.
        /// </para>
        /// </summary>
        public BatchConfiguration BatchConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BatchConfiguration property is set.
        /// </summary>
        internal bool IsSetBatchConfiguration() => this.BatchConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the subscriber was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Free-text description. Used by every resource type that has one: event buses, subscribers,
        /// and event sources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventBusArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies an event bus.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string EventBusArn { get; set; }

        /// <summary>
        /// Checks to see if the EventBusArn property is set.
        /// </summary>
        internal bool IsSetEventBusArn() => this.EventBusArn != null;

        /// <summary>
        /// Gets and sets the property FilterConfiguration. 
        /// <para>
        /// Configuration for filtering events delivered to a subscriber. On CreateSubscriber,
        /// Filters is required and must contain at least one Filter with a non-empty Pattern.
        /// On UpdateSubscriber, an empty <c>FilterConfiguration:{}</c> clears the existing filter.
        /// Any non-empty shape (including <c>{Language:X}</c> without Filters) must contain a
        /// valid Filters list — same contract as CreateSubscriber. A non-empty Filters list overwrites;
        /// an omitted FilterConfiguration preserves existing state. All Filters are implicitly
        /// ANDed — an event must match every Filter to be delivered.
        /// </para>
        /// </summary>
        public FilterConfiguration FilterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FilterConfiguration property is set.
        /// </summary>
        internal bool IsSetFilterConfiguration() => this.FilterConfiguration != null;

        /// <summary>
        /// Gets and sets the property InvokeConfiguration. 
        /// <para>
        /// Configuration for how the subscriber invokes its target.
        /// </para>
        /// </summary>
        public InvokeConfiguration InvokeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InvokeConfiguration property is set.
        /// </summary>
        internal bool IsSetInvokeConfiguration() => this.InvokeConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time the subscriber was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// Log configuration for a subscriber.
        /// </para>
        /// </summary>
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of a subscriber. The first character must be alphanumeric; the remaining characters
        /// may also include '.', '-', and '_'.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OnFailureConfiguration. 
        /// <para>
        /// On-failure configuration: where a failed delivery is sent. Shared by the subscriber
        /// and the EventSource.
        /// </para>
        /// </summary>
        public OnFailureConfiguration OnFailureConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OnFailureConfiguration property is set.
        /// </summary>
        internal bool IsSetOnFailureConfiguration() => this.OnFailureConfiguration != null;

        /// <summary>
        /// Gets and sets the property PointInTimeConfiguration. 
        /// <para>
        /// Point-in-time configuration for a subscriber. Only applicable when StartingPosition
        /// is POINT_IN_TIME.
        /// </para>
        /// </summary>
        public PointInTimeConfiguration PointInTimeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PointInTimeConfiguration property is set.
        /// </summary>
        internal bool IsSetPointInTimeConfiguration() => this.PointInTimeConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetryPolicy. 
        /// <para>
        /// Retry policy for a subscriber.
        /// </para>
        /// </summary>
        public RetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RetryPolicy property is set.
        /// </summary>
        internal bool IsSetRetryPolicy() => this.RetryPolicy != null;

        /// <summary>
        /// Gets and sets the property Revoked. 
        /// <para>
        /// True when the bus owner has revoked this subscriber. Present only when true, so an
        /// absent member means the subscriber is not revoked. Revocation is terminal: it never
        /// returns to false. Mutating operations on a revoked subscriber fail with InvalidStateException,
        /// except DeleteSubscriber, which stays available so a revoked subscriber can still be
        /// cleaned up.
        /// </para>
        /// </summary>
        public bool? Revoked { get; set; }

        /// <summary>
        /// Checks to see if the Revoked property is set.
        /// </summary>
        internal bool IsSetRevoked() => this.Revoked.HasValue;

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// Starting position for a subscriber.
        /// </para>
        /// </summary>
        public StartingPosition StartingPosition { get; set; }

        /// <summary>
        /// Checks to see if the StartingPosition property is set.
        /// </summary>
        internal bool IsSetStartingPosition() => this.StartingPosition != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Customer-controlled run state of a subscriber, set on create or update. Distinct from
        /// the bus lifecycle vocabulary, where ACTIVE means "provisioned and healthy". Delivery
        /// requires State RUNNING on a subscriber that is not revoked.
        /// </para>
        /// </summary>
        public SubscriberState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubscriberArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies a subscriber.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string SubscriberArn { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberArn property is set.
        /// </summary>
        internal bool IsSetSubscriberArn() => this.SubscriberArn != null;

        /// <summary>
        /// Gets and sets the property SubscriberDetails.
        /// </summary>
        public SubscriberDetails SubscriberDetails { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberDetails property is set.
        /// </summary>
        internal bool IsSetSubscriberDetails() => this.SubscriberDetails != null;

        /// <summary>
        /// Gets and sets the property Transformer. 
        /// <para>
        /// Transformer configuration for a subscriber.
        /// </para>
        /// </summary>
        public Transformer Transformer { get; set; }

        /// <summary>
        /// Checks to see if the Transformer property is set.
        /// </summary>
        internal bool IsSetTransformer() => this.Transformer != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Delivery ordering mode of a subscriber: FIFO delivers events in order within an event
        /// group; UNORDERED delivers without an ordering guarantee.
        /// </para>
        /// </summary>
        public OrderingType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
