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
        /// Gets and sets the property Height. Output video height (in pixels). Leave blank to
        /// use source video height. If left blank, width must also be unspecified.
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
        /// in the input stream. Setting to "respond" causes input video to be clipped, depending
        /// on AFD value, input display aspect ratio and output display aspect ratio.
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
        /// Gets and sets the property ScalingBehavior. When set to "stretchToOutput", automatically
        /// configures the output position to stretch the video to the specified output resolution.
        /// This option will override any position value.
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
        /// Gets and sets the property Sharpness. Changes the width of the anti-alias filter kernel
        /// used for scaling. Only applies if scaling is being performed and antiAlias is set
        /// to true. 0 is the softest setting, 100 the sharpest, and 50 recommended for most content.
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
        /// Gets and sets the property Width. Output video width (in pixels). Leave out to use
        /// source video width.  If left out, height must also be left out. Display aspect ratio
        /// is always preserved by letterboxing or pillarboxing when necessary.
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