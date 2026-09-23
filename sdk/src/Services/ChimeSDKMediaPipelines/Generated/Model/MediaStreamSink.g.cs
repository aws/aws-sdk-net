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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Structure that contains the settings for a media stream sink.
    /// </summary>
    public partial class MediaStreamSink
    {
        /// <summary>
        /// Gets and sets the property MediaStreamType. 
        /// <para>
        /// The media stream sink's media stream type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaStreamType MediaStreamType { get; set; }

        /// <summary>
        /// Checks to see if the MediaStreamType property is set.
        /// </summary>
        internal bool IsSetMediaStreamType() => this.MediaStreamType != null;

        /// <summary>
        /// Gets and sets the property ReservedStreamCapacity. 
        /// <para>
        /// Specifies the number of streams that the sink can accept.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public int? ReservedStreamCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ReservedStreamCapacity property is set.
        /// </summary>
        internal bool IsSetReservedStreamCapacity() => this.ReservedStreamCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property SinkArn. 
        /// <para>
        /// The ARN of the Kinesis Video Stream pool returned by the <a>CreateMediaPipelineKinesisVideoStreamPool</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string SinkArn { get; set; }

        /// <summary>
        /// Checks to see if the SinkArn property is set.
        /// </summary>
        internal bool IsSetSinkArn() => this.SinkArn != null;

        /// <summary>
        /// Gets and sets the property SinkType. 
        /// <para>
        /// The media stream sink's type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaStreamPipelineSinkType SinkType { get; set; }

        /// <summary>
        /// Checks to see if the SinkType property is set.
        /// </summary>
        internal bool IsSetSinkType() => this.SinkType != null;
    }
}
