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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
        private string _channelARN;
        private DateTime? _channelCreationTimestamp;
        private ChannelDestinationType _channelDestinationType;
        private string _channelId;
        private string _channelName;
        private ChannelStatus _channelStatus;
        private string _channelStatusReason;
        private List<ChannelStreamIdentifier> _streams = AWSConfigs.InitializeCollections ? new List<ChannelStreamIdentifier>() : null;

        /// <summary>
        /// Gets and sets the property ChannelARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ChannelARN
        {
            get { return this._channelARN; }
            set { this._channelARN = value; }
        }

        // Check to see if ChannelARN property is set
        internal bool IsSetChannelARN()
        {
            return this._channelARN != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelCreationTimestamp. 
        /// <para>
        /// The time at which the channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ChannelCreationTimestamp
        {
            get { return this._channelCreationTimestamp; }
            set { this._channelCreationTimestamp = value; }
        }

        // Check to see if ChannelCreationTimestamp property is set
        internal bool IsSetChannelCreationTimestamp()
        {
            return this._channelCreationTimestamp.HasValue; 
        }

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
        [AWSProperty(Required=true)]
        public ChannelDestinationType ChannelDestinationType
        {
            get { return this._channelDestinationType; }
            set { this._channelDestinationType = value; }
        }

        // Check to see if ChannelDestinationType property is set
        internal bool IsSetChannelDestinationType()
        {
            return this._channelDestinationType != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The unique identifier of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelStatus. 
        /// <para>
        /// The current status of the channel. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - See <c>ChannelStatusReason</c> for the failure cause.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelStatus ChannelStatus
        {
            get { return this._channelStatus; }
            set { this._channelStatus = value; }
        }

        // Check to see if ChannelStatus property is set
        internal bool IsSetChannelStatus()
        {
            return this._channelStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelStatusReason. 
        /// <para>
        /// A message describing the reason for a <c>FAILED</c> status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ChannelStatusReason
        {
            get { return this._channelStatusReason; }
            set { this._channelStatusReason = value; }
        }

        // Check to see if ChannelStatusReason property is set
        internal bool IsSetChannelStatusReason()
        {
            return this._channelStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        /// The source streams associated with the channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public List<ChannelStreamIdentifier> Streams
        {
            get { return this._streams; }
            set { this._streams = value; }
        }

        // Check to see if Streams property is set
        internal bool IsSetStreams()
        {
            return this._streams != null && (this._streams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}