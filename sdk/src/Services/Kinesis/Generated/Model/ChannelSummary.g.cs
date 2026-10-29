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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// A summary of a channel, returned by <a>ListChannels</a>.
    /// </summary>
    public partial class ChannelSummary
    {
        /// <summary>
        /// Gets and sets the property ChannelARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ChannelARN { get; set; }

        /// <summary>
        /// Checks to see if the ChannelARN property is set.
        /// </summary>
        internal bool IsSetChannelARN() => this.ChannelARN != null;

        /// <summary>
        /// Gets and sets the property ChannelCreationTimestamp. 
        /// <para>
        /// The time at which the channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ChannelCreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ChannelCreationTimestamp property is set.
        /// </summary>
        internal bool IsSetChannelCreationTimestamp() => this.ChannelCreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ChannelDestinationType. 
        /// <para>
        /// The destination type of the channel. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>S3</c> - Delivery to a general purpose Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_TABLES</c> - Delivery to streaming tables on Apache Iceberg.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelDestinationType ChannelDestinationType { get; set; }

        /// <summary>
        /// Checks to see if the ChannelDestinationType property is set.
        /// </summary>
        internal bool IsSetChannelDestinationType() => this.ChannelDestinationType != null;

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The unique identifier of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ChannelStatus. 
        /// <para>
        /// The current status of the channel. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The channel is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The channel is ready to deliver records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The channel configuration is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The channel is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - See <c>ChannelStatusReason</c> for the failure cause.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelStatus ChannelStatus { get; set; }

        /// <summary>
        /// Checks to see if the ChannelStatus property is set.
        /// </summary>
        internal bool IsSetChannelStatus() => this.ChannelStatus != null;

        /// <summary>
        /// Gets and sets the property ChannelStatusReason. 
        /// <para>
        /// A message describing the reason for a <c>FAILED</c> status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ChannelStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the ChannelStatusReason property is set.
        /// </summary>
        internal bool IsSetChannelStatusReason() => this.ChannelStatusReason != null;

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        /// The source streams associated with the channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10000)]
        public List<ChannelStreamIdentifier> Streams { get; set; } = AWSConfigs.InitializeCollections ? new List<ChannelStreamIdentifier>() : null;

        /// <summary>
        /// Checks to see if the Streams property is set.
        /// </summary>
        internal bool IsSetStreams() => this.Streams != null && (this.Streams.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
