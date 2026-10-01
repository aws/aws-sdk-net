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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// A structure that encapsulates a signaling channel's metadata and properties.
    /// </summary>
    public partial class ChannelInfo
    {
        /// <summary>
        /// Gets and sets the property ChannelARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the signaling channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ChannelARN { get; set; }

        /// <summary>
        /// Checks to see if the ChannelARN property is set.
        /// </summary>
        internal bool IsSetChannelARN() => this.ChannelARN != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the signaling channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ChannelStatus. 
        /// <para>
        /// Current status of the signaling channel.
        /// </para>
        /// </summary>
        public Status ChannelStatus { get; set; }

        /// <summary>
        /// Checks to see if the ChannelStatus property is set.
        /// </summary>
        internal bool IsSetChannelStatus() => this.ChannelStatus != null;

        /// <summary>
        /// Gets and sets the property ChannelType. 
        /// <para>
        /// The type of the signaling channel.
        /// </para>
        /// </summary>
        public ChannelType ChannelType { get; set; }

        /// <summary>
        /// Checks to see if the ChannelType property is set.
        /// </summary>
        internal bool IsSetChannelType() => this.ChannelType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the signaling channel was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property SingleMasterConfiguration. 
        /// <para>
        /// A structure that contains the configuration for the <c>SINGLE_MASTER</c> channel type.
        /// </para>
        /// </summary>
        public SingleMasterConfiguration SingleMasterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SingleMasterConfiguration property is set.
        /// </summary>
        internal bool IsSetSingleMasterConfiguration() => this.SingleMasterConfiguration != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The current version of the signaling channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
