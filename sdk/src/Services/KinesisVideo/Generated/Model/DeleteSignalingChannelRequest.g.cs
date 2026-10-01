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
    /// Container for the parameters to the DeleteSignalingChannel operation. Deletes a specified
    /// signaling channel. <c>DeleteSignalingChannel</c> is an asynchronous operation. If
    /// you don't specify the channel's current version, the most recent version is deleted.
    /// </summary>
    public partial class DeleteSignalingChannelRequest : AmazonKinesisVideoRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the signaling channel that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ChannelARN { get; set; }

        /// <summary>
        /// Checks to see if the ChannelARN property is set.
        /// </summary>
        internal bool IsSetChannelARN() => this.ChannelARN != null;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current version of the signaling channel that you want to delete. You can obtain
        /// the current version by invoking the <c>DescribeSignalingChannel</c> or <c>ListSignalingChannels</c>
        /// API operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;
    }
}
