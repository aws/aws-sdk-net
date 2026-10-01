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
    /// Container for the parameters to the CreateSignalingChannel operation. Creates a signaling
    /// channel. <para> <c>CreateSignalingChannel</c> is an asynchronous operation. </para>
    /// </summary>
    public partial class CreateSignalingChannelRequest : AmazonKinesisVideoRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// A name for the signaling channel that you are creating. It must be unique for each
        /// Amazon Web Services account and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ChannelType. 
        /// <para>
        /// A type of the signaling channel that you are creating. Currently, <c>SINGLE_MASTER</c>
        /// is the only supported channel type. 
        /// </para>
        /// </summary>
        public ChannelType ChannelType { get; set; }

        /// <summary>
        /// Checks to see if the ChannelType property is set.
        /// </summary>
        internal bool IsSetChannelType() => this.ChannelType != null;

        /// <summary>
        /// Gets and sets the property SingleMasterConfiguration. 
        /// <para>
        /// A structure containing the configuration for the <c>SINGLE_MASTER</c> channel type.
        /// The default configuration for the channel message's time to live is 60 seconds (1
        /// minute).
        /// </para>
        /// </summary>
        public SingleMasterConfiguration SingleMasterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SingleMasterConfiguration property is set.
        /// </summary>
        internal bool IsSetSingleMasterConfiguration() => this.SingleMasterConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags (key-value pairs) that you want to associate with this channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
