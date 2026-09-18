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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateChannel operation. Update the specified
    /// channel. You can edit if MediaPackage sends ingest or egress access logs to the CloudWatch
    /// log group, if content will be encrypted, the description on a channel, and your channel's
    /// policy settings. You can't edit the name of the channel or CloudFront distribution
    /// details. <para> Any edits you make that impact the video output may not be reflected
    /// for a few minutes. </para>
    /// </summary>
    public partial class UpdateChannelRequest : AmazonMediaPackageV2Request
    {
        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name that describes the channel group. The name is the primary identifier for
        /// the channel group, and must be unique for your account in the AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelGroupName property is set.
        /// </summary>
        internal bool IsSetChannelGroupName() => this.ChannelGroupName != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name that describes the channel. The name is the primary identifier for the channel,
        /// and must be unique for your account in the AWS Region and channel group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Any descriptive information that you want to add to the channel for future identification
        /// purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The expected current Entity Tag (ETag) for the resource. If the specified ETag does
        /// not match the resource's current entity tag, the update request will be rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property InputSwitchConfiguration. 
        /// <para>
        /// The configuration for input switching based on the media quality confidence score
        /// (MQCS) as provided from AWS Elemental MediaLive. This setting is valid only when <c>InputType</c>
        /// is <c>CMAF</c>.
        /// </para>
        /// </summary>
        public InputSwitchConfiguration InputSwitchConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputSwitchConfiguration property is set.
        /// </summary>
        internal bool IsSetInputSwitchConfiguration() => this.InputSwitchConfiguration != null;

        /// <summary>
        /// Gets and sets the property MultiviewConfiguration. 
        /// <para>
        /// The multiview configuration for the channel. This setting is required when the channel's
        /// <c>InputType</c> is <c>MULTIVIEW</c>, and can't be set for any other input type. Because
        /// <c>InputType</c> is immutable, you can change a multiview channel's sources and layouts.
        /// You can't add or remove the multiview configuration itself.
        /// </para>
        /// </summary>
        public MultiviewConfiguration MultiviewConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MultiviewConfiguration property is set.
        /// </summary>
        internal bool IsSetMultiviewConfiguration() => this.MultiviewConfiguration != null;

        /// <summary>
        /// Gets and sets the property OutputHeaderConfiguration. 
        /// <para>
        /// The settings for what common media server data (CMSD) headers AWS Elemental MediaPackage
        /// includes in responses to the CDN. This setting is valid only when <c>InputType</c>
        /// is <c>CMAF</c>.
        /// </para>
        /// </summary>
        public OutputHeaderConfiguration OutputHeaderConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputHeaderConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputHeaderConfiguration() => this.OutputHeaderConfiguration != null;
    }
}
