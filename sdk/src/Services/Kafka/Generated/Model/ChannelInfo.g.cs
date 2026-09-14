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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Summary information about a channel returned by ListChannels.
    /// </summary>
    public partial class ChannelInfo
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ClusterOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the in-flight cluster operation. Returned only while
        /// the channel is in CREATING, UPDATING, or DELETING.
        /// </para>
        /// </summary>
        public string ClusterOperationArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterOperationArn property is set.
        /// </summary>
        internal bool IsSetClusterOperationArn() => this.ClusterOperationArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// The type of destination configured for the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelDestinationType DestinationType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationType property is set.
        /// </summary>
        internal bool IsSetDestinationType() => this.DestinationType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current lifecycle state of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
