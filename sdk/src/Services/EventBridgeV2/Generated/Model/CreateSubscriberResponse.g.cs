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
    /// This is the response object from the CreateSubscriber operation.
    /// </summary>
    public partial class CreateSubscriberResponse : AmazonWebServiceResponse
    {
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
