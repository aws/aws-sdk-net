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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// The details of a channel.
    /// </summary>
    public partial class Channel
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of a channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 1600)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property ChannelFlowArn. 
        /// <para>
        /// The ARN of the channel flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 1600)]
        public string ChannelFlowArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelFlowArn property is set.
        /// </summary>
        internal bool IsSetChannelFlowArn() => this.ChannelFlowArn != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The <c>AppInstanceUser</c> who created the channel.
        /// </para>
        /// </summary>
        public Identity CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the <c>AppInstanceUser</c> created the channel.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ElasticChannelConfiguration. 
        /// <para>
        /// The attributes required to configure and create an elastic channel. An elastic channel
        /// can support a maximum of 1-million members.
        /// </para>
        /// </summary>
        public ElasticChannelConfiguration ElasticChannelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ElasticChannelConfiguration property is set.
        /// </summary>
        internal bool IsSetElasticChannelConfiguration() => this.ElasticChannelConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExpirationSettings. 
        /// <para>
        /// Settings that control when a channel expires.
        /// </para>
        /// </summary>
        public ExpirationSettings ExpirationSettings { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationSettings property is set.
        /// </summary>
        internal bool IsSetExpirationSettings() => this.ExpirationSettings != null;

        /// <summary>
        /// Gets and sets the property LastMessageTimestamp. 
        /// <para>
        /// The time at which a member sent the last message in the channel.
        /// </para>
        /// </summary>
        public DateTime? LastMessageTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastMessageTimestamp property is set.
        /// </summary>
        internal bool IsSetLastMessageTimestamp() => this.LastMessageTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The time at which a channel was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The channel's metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the channel.
        /// </para>
        /// </summary>
        public ChannelMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a channel.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Privacy. 
        /// <para>
        /// The channel's privacy setting.
        /// </para>
        /// </summary>
        public ChannelPrivacy Privacy { get; set; }

        /// <summary>
        /// Checks to see if the Privacy property is set.
        /// </summary>
        internal bool IsSetPrivacy() => this.Privacy != null;
    }
}
