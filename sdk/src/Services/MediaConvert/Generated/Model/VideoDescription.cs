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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for video outputs
    /// </summary>
    public partial class VideoDescription
    {
        private AfdSignaling _afdSignaling;
        private AntiAlias _antiAlias;
        private VideoCodecSettings _codecSettings;
        private ColorMetadata _colorMetadata;
        private Rectangle _crop;
        private DropFrameTimecode _dropFrameTimecode;
        private int? _fixedAfd;
        private int? _height;
        private Rectangle _position;
        private RespondToAfd _respondToAfd;
        private ScalingBehavior _scalingBehavior;
        private int? _sharpness;
        private VideoTimecodeInsertion _timecodeInsertion;
        private VideoPreprocessor _videoPreprocessors;
        private int? _width;

        /// <summary>
        /// Gets and sets the property AfdSignaling.
        /// </summary>
        public AfdSignaling AfdSignaling
        {
            get { return this._afdSignaling; }
            set { this._afdSignaling = value; }
        }

        // Check to see if AfdSignaling property is set
        internal bool IsSetAfdSignaling()
        {
            return this._afdSignaling != null;
        }

        /// <summary>
        /// Gets and sets the property AntiAlias.
        /// </summary>
        public AntiAlias AntiAlias
        {
            get { return this._antiAlias; }
            set { this._antiAlias = value; }
        }

        // Check to see if AntiAlias property is set
        internal bool IsSetAntiAlias()
        {
            return this._antiAlias != null;
        }

        /// <summary>
        /// Gets and sets the property CodecSettings.
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
        /// Gets and sets the property ColorMetadata.
        /// </summary>
        public ColorMetadata ColorMetadata
        {
            get { return this._colorMetadata; }
            set { this._colorMetadata = value; }
        }

        // Check to see if ColorMetadata property is set
        internal bool IsSetColorMetadata()
        {
            return this._colorMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Crop. Applies only if your input aspect ratio is different
        /// from your output aspect ratio. Use Input cropping rectangle (Crop) to specify the
        ///  video area the service will include in the output. This will crop the input source,
        /// causing video pixels to be removed on encode. If you crop your input frame size to
        /// smaller than your output frame size, make sure to specify the behavior you want in
        /// your output setting "Scaling behavior".
        /// </summary>
        public Rectangle Crop
        {
            get { return this._crop; }
            set { this._crop = value; }
        }

        // Check to see if Crop property is set
        internal bool IsSetCrop()
        {
            return this._crop != null;
        }

        /// <summary>
        /// Gets and sets the property DropFrameTimecode.
        /// </summary>
        public DropFrameTimecode DropFrameTimecode
        {
            get { return this._dropFrameTimecode; }
            set { this._dropFrameTimecode = value; }
        }

        // Check to see if DropFrameTimecode property is set
        internal bool IsSetDropFrameTimecode()
        {
            return this._dropFrameTimecode != null;
        }

        /// <summary>
        /// Gets and sets the property FixedAfd. Applies only if you set AFD Signaling(AfdSignaling)
        /// to Fixed (FIXED). Use Fixed (FixedAfd) to specify a four-bit AFD value which the service
        /// will write on all  frames of this video output.
        /// </summary>
        public int FixedAfd
        {
            get { return this._fixedAfd.GetValueOrDefault(); }
            set { this._fixedAfd = value; }
        }

        // Check to see if FixedAfd property is set
        internal bool IsSetFixedAfd()
        {
            return this._fixedAfd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Height. Use the Height (Height) setting to define the video
        /// resolution height for this output. Specify in pixels. If you don't provide a value
        /// here, the service will use the input height.
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
        /// Gets and sets the property Position. Use Position (Position) to point to a rectangle
        /// object to define your position. This setting overrides any other aspect ratio.
        /// </summary>
        public Rectangle Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property RespondToAfd.
        /// </summary>
        public RespondToAfd RespondToAfd
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
        /// Gets and sets the property ScalingBehavior.
        /// </summary>
        public ScalingBehavior ScalingBehavior
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
        /// Gets and sets the property Sharpness. Use Sharpness (Sharpness)setting to specify
        /// the strength of anti-aliasing. This setting changes the width of the anti-alias filter
        /// kernel used for scaling. Sharpness only applies if your output resolution is different
        /// from your input resolution, and if you set Anti-alias (AntiAlias) to ENABLED. 0 is
        /// the softest setting, 100 the sharpest, and 50 recommended for most content.
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
        /// Gets and sets the property TimecodeInsertion.
        /// </summary>
        public VideoTimecodeInsertion TimecodeInsertion
        {
            get { return this._timecodeInsertion; }
            set { this._timecodeInsertion = value; }
        }

        // Check to see if TimecodeInsertion property is set
        internal bool IsSetTimecodeInsertion()
        {
            return this._timecodeInsertion != null;
        }

        /// <summary>
        /// Gets and sets the property VideoPreprocessors. Find additional transcoding features
        /// under Preprocessors (VideoPreprocessors). Enable the features at each output individually.
        /// These features are disabled by default.
        /// </summary>
        public VideoPreprocessor VideoPreprocessors
        {
            get { return this._videoPreprocessors; }
            set { this._videoPreprocessors = value; }
        }

        // Check to see if VideoPreprocessors property is set
        internal bool IsSetVideoPreprocessors()
        {
            return this._videoPreprocessors != null;
        }

        /// <summary>
        /// Gets and sets the property Width. Use Width (Width) to define the video resolution
        /// width, in pixels, for this output. If you don't provide a value here, the service
        /// will use the input width.
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