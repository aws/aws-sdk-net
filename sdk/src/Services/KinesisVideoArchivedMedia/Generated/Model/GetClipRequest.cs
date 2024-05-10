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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// Container for the parameters to the GetClip operation.
    /// Downloads an MP4 file (clip) containing the archived, on-demand media from the specified
    /// video stream over the specified time range. 
    /// 
    ///  
    /// <para>
    /// Both the StreamName and the StreamARN parameters are optional, but you must specify
    /// either the StreamName or the StreamARN when invoking this API operation. 
    /// </para>
    ///  
    /// <para>
    /// As a prerequisite to using GetCLip API, you must obtain an endpoint using <c>GetDataEndpoint</c>,
    /// specifying GET_CLIP for<code/> the <c>APIName</c> parameter. 
    /// </para>
    ///  
    /// <para>
    /// An Amazon Kinesis video stream has the following requirements for providing data through
    /// MP4:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The media must contain h.264 or h.265 encoded video and, optionally, AAC or G.711
    /// encoded audio. Specifically, the codec ID of track 1 should be <c>V_MPEG/ISO/AVC</c>
    /// (for h.264) or V_MPEGH/ISO/HEVC (for H.265). Optionally, the codec ID of track 2 should
    /// be <c>A_AAC</c> (for AAC) or A_MS/ACM (for G.711).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Data retention must be greater than 0.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The video track of each fragment must contain codec private data in the Advanced Video
    /// Coding (AVC) for H.264 format and HEVC for H.265 format. For more information, see
    /// <a href="https://www.iso.org/standard/55980.html">MPEG-4 specification ISO/IEC 14496-15</a>.
    /// For information about adapting stream data to a given format, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/producer-reference-nal.html">NAL
    /// Adaptation Flags</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The audio track (if present) of each fragment must contain codec private data in the
    /// AAC format (<a href="https://www.iso.org/standard/43345.html">AAC specification ISO/IEC
    /// 13818-7</a>) or the <a href="http://www-mmsp.ece.mcgill.ca/Documents/AudioFormats/WAVE/WAVE.html">MS
    /// Wave format</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can monitor the amount of outgoing data by monitoring the <c>GetClip.OutgoingBytes</c>
    /// Amazon CloudWatch metric. For information about using CloudWatch to monitor Kinesis
    /// Video Streams, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/monitoring.html">Monitoring
    /// Kinesis Video Streams</a>. For pricing information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Amazon
    /// Kinesis Video Streams Pricing</a> and <a href="https://aws.amazon.com/pricing/"> Amazon
    /// Web Services Pricing</a>. Charges for outgoing Amazon Web Services data apply.
    /// </para>
    /// </summary>
    public partial class GetClipRequest : AmazonKinesisVideoArchivedMediaRequest
    {
        private ClipFragmentSelector _clipFragmentSelector;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property ClipFragmentSelector. 
        /// <para>
        /// The time range of the requested clip and the source of the timestamps.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClipFragmentSelector ClipFragmentSelector
        {
            get { return this._clipFragmentSelector; }
            set { this._clipFragmentSelector = value; }
        }

        // Check to see if ClipFragmentSelector property is set
        internal bool IsSetClipFragmentSelector()
        {
            return this._clipFragmentSelector != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream for which to retrieve the media clip.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must specify either the StreamName or the StreamARN. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream for which to retrieve the media clip. 
        /// </para>
        ///  
        /// <para>
        /// You must specify either the StreamName or the StreamARN. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}