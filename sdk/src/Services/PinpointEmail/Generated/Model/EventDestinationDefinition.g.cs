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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that defines the event destination. Specifically, it defines which services
    /// receive events from emails sent using the configuration set that the event destination
    /// is associated with. Also defines the types of events that are sent to the event destination.
    /// </summary>
    public partial class EventDestinationDefinition
    {
        /// <summary>
        /// Gets and sets the property CloudWatchDestination. 
        /// <para>
        /// An object that defines an Amazon CloudWatch destination for email events. You can
        /// use Amazon CloudWatch to monitor and gain insights on your email sending metrics.
        /// </para>
        /// </summary>
        public CloudWatchDestination CloudWatchDestination { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchDestination property is set.
        /// </summary>
        internal bool IsSetCloudWatchDestination() => this.CloudWatchDestination != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If <c>true</c>, the event destination is enabled. When the event destination is enabled,
        /// the specified event types are sent to the destinations in this <c>EventDestinationDefinition</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>false</c>, the event destination is disabled. When the event destination is
        /// disabled, events aren't sent to the specified destinations.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property KinesisFirehoseDestination. 
        /// <para>
        /// An object that defines an Amazon Kinesis Data Firehose destination for email events.
        /// You can use Amazon Kinesis Data Firehose to stream data to other services, such as
        /// Amazon S3 and Amazon Redshift.
        /// </para>
        /// </summary>
        public KinesisFirehoseDestination KinesisFirehoseDestination { get; set; }

        /// <summary>
        /// Checks to see if the KinesisFirehoseDestination property is set.
        /// </summary>
        internal bool IsSetKinesisFirehoseDestination() => this.KinesisFirehoseDestination != null;

        /// <summary>
        /// Gets and sets the property MatchingEventTypes. 
        /// <para>
        /// An array that specifies which events Amazon Pinpoint should send to the destinations
        /// in this <c>EventDestinationDefinition</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchingEventTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchingEventTypes property is set.
        /// </summary>
        internal bool IsSetMatchingEventTypes() => this.MatchingEventTypes != null && (this.MatchingEventTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PinpointDestination. 
        /// <para>
        /// An object that defines a Amazon Pinpoint destination for email events. You can use
        /// Amazon Pinpoint events to create attributes in Amazon Pinpoint projects. You can use
        /// these attributes to create segments for your campaigns.
        /// </para>
        /// </summary>
        public PinpointDestination PinpointDestination { get; set; }

        /// <summary>
        /// Checks to see if the PinpointDestination property is set.
        /// </summary>
        internal bool IsSetPinpointDestination() => this.PinpointDestination != null;

        /// <summary>
        /// Gets and sets the property SnsDestination. 
        /// <para>
        /// An object that defines an Amazon SNS destination for email events. You can use Amazon
        /// SNS to send notification when certain email events occur.
        /// </para>
        /// </summary>
        public SnsDestination SnsDestination { get; set; }

        /// <summary>
        /// Checks to see if the SnsDestination property is set.
        /// </summary>
        internal bool IsSetSnsDestination() => this.SnsDestination != null;
    }
}
