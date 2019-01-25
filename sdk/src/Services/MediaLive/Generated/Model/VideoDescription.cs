/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        public int Height
        {
            get { return this._height.GetValueOrDefault(); }
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
        /// Gets and sets the property RespondToAfd. Indicates how to respond to the AFD values
        /// in the input stream. RESPOND causes input video to be clipped, depending on the AFD
        /// value, input display aspect ratio, and output display aspect ratio, and (except for
        /// FRAMECAPTURE codec) includes the values in the output. PASSTHROUGH (does not apply
        /// to FRAMECAPTURE codec) ignores the AFD values and includes the values in the output,
        /// so input video is not clipped. NONE ignores the AFD values and does not include the
        /// values through to the output, so input video is not clipped.
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
        /// Gets and sets the property ScalingBehavior. STRETCHTOOUTPUT configures the output
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
        public int Sharpness
        {
            get { return this._sharpness.GetValueOrDefault(); }
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
        public int Width
        {
            get { return this._width.GetValueOrDefault(); }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}