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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Video settings for this stream.
    /// </summary>
    public partial class VideoDescription
    {
        private VideoCodecSettings _codecSettings;
        private int? _height;
        private string _name;
        private VideoDescriptionRespondToAfd _respondToAfd;
        private VideoDescriptionScalingBehavior _scalingBehavior;
        private int? _sharpness;
        private int? _width;

        /// <summary>
        /// Gets and sets the property CodecSettings. Video codec settings.
        /// </summary>
        public VideoCodecSettings CodecSettings
        {
            get { return this._codecSettings; }
            set { this._codecSettings = value; }
        }

        // Check to see if CodecSettings property is set
        internal bool IsSetCodecSettings()
        {
            return this._codecSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Height. Output video height, in pixels. Must be an even
        /// number. For most codecs, you can leave this field and width blank in order to use
        /// the height and width (resolution) from the source. Note, however, that leaving blank
        /// is not recommended. For the Frame Capture codec, height and width are required.
        /// </summary>
        public int? Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. The name of this VideoDescription. Outputs will use
        /// this name to uniquely identify this Description.  Description names should be unique
        /// within this Live Event.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RespondToAfd. Indicates how MediaLive will respond to the
        /// AFD values that might be in the input video. If you do not know what AFD signaling
        /// is, or if your downstream system has not given you guidance, choose PASSTHROUGH.RESPOND:
        /// MediaLive clips the input video using a formula that uses the AFD values (configured
        /// in afdSignaling ), the input display aspect ratio, and the output display aspect ratio.
        /// MediaLive also includes the AFD values in the output, unless the codec for this encode
        /// is FRAME_CAPTURE.PASSTHROUGH: MediaLive ignores the AFD values and does not clip the
        /// video. But MediaLive does include the values in the output.NONE: MediaLive does not
        /// clip the input video and does not include the AFD values in the output
        /// </summary>
        public VideoDescriptionRespondToAfd RespondToAfd
        {
            get { return this._respondToAfd; }
            set { this._respondToAfd = value; }
        }

        // Check to see if RespondToAfd property is set
        internal bool IsSetRespondToAfd()
        {
            return this._respondToAfd != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingBehavior. STRETCH_TO_OUTPUT configures the output
        /// position to stretch the video to the specified output resolution (height and width).
        /// This option will override any position value. DEFAULT may insert black boxes (pillar
        /// boxes or letter boxes) around the video to provide the specified output resolution.
        /// </summary>
        public VideoDescriptionScalingBehavior ScalingBehavior
        {
            get { return this._scalingBehavior; }
            set { this._scalingBehavior = value; }
        }

        // Check to see if ScalingBehavior property is set
        internal bool IsSetScalingBehavior()
        {
            return this._scalingBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Sharpness. Changes the strength of the anti-alias filter
        /// used for scaling. 0 is the softest setting, 100 is the sharpest. A setting of 50 is
        /// recommended for most content.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Sharpness
        {
            get { return this._sharpness; }
            set { this._sharpness = value; }
        }

        // Check to see if Sharpness property is set
        internal bool IsSetSharpness()
        {
            return this._sharpness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Width. Output video width, in pixels. Must be an even number.
        /// For most codecs, you can leave this field and height blank in order to use the height
        /// and width (resolution) from the source. Note, however, that leaving blank is not recommended.
        /// For the Frame Capture codec, height and width are required.
        /// </summary>
        public int? Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}