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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
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
        private MediaStreamType _mediaStreamType;
        private int? _reservedStreamCapacity;
        private string _sinkArn;
        private MediaStreamPipelineSinkType _sinkType;

        /// <summary>
        /// Gets and sets the property MediaStreamType. 
        /// <para>
        /// The media stream sink's media stream type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaStreamType MediaStreamType
        {
            get { return this._mediaStreamType; }
            set { this._mediaStreamType = value; }
        }

        // Check to see if MediaStreamType property is set
        internal bool IsSetMediaStreamType()
        {
            return this._mediaStreamType != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedStreamCapacity. 
        /// <para>
        /// Specifies the number of streams that the sink can accept.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public int? ReservedStreamCapacity
        {
            get { return this._reservedStreamCapacity; }
            set { this._reservedStreamCapacity = value; }
        }

        // Check to see if ReservedStreamCapacity property is set
        internal bool IsSetReservedStreamCapacity()
        {
            return this._reservedStreamCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SinkArn. 
        /// <para>
        /// The ARN of the Kinesis Video Stream pool returned by the <a>CreateMediaPipelineKinesisVideoStreamPool</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string SinkArn
        {
            get { return this._sinkArn; }
            set { this._sinkArn = value; }
        }

        // Check to see if SinkArn property is set
        internal bool IsSetSinkArn()
        {
            return this._sinkArn != null;
        }

        /// <summary>
        /// Gets and sets the property SinkType. 
        /// <para>
        /// The media stream sink's type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaStreamPipelineSinkType SinkType
        {
            get { return this._sinkType; }
            set { this._sinkType = value; }
        }

        // Check to see if SinkType property is set
        internal bool IsSetSinkType()
        {
            return this._sinkType != null;
        }

    }
}