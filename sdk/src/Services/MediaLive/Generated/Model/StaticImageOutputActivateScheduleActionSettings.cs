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
    /// Settings for the action to activate a static image.
    /// </summary>
    public partial class StaticImageOutputActivateScheduleActionSettings
    {
        private int? _duration;
        private int? _fadeIn;
        private int? _fadeOut;
        private int? _height;
        private InputLocation _image;
        private int? _imageX;
        private int? _imageY;
        private int? _layer;
        private int? _opacity;
        private List<string> _outputNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _width;

        /// <summary>
        /// Gets and sets the property Duration. The duration in milliseconds for the image to
        /// remain on the video. If omitted or set to 0 the duration is unlimited and the image
        /// will remain until it is explicitly deactivated.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FadeIn. The time in milliseconds for the image to fade
        /// in. The fade-in starts at the start time of the overlay. Default is 0 (no fade-in).
        /// </summary>
        [AWSProperty(Min=0)]
        public int? FadeIn
        {
            get { return this._fadeIn; }
            set { this._fadeIn = value; }
        }

        // Check to see if FadeIn property is set
        internal bool IsSetFadeIn()
        {
            return this._fadeIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FadeOut. Applies only if a duration is specified. The time
        /// in milliseconds for the image to fade out. The fade-out starts when the duration time
        /// is hit, so it effectively extends the duration. Default is 0 (no fade-out).
        /// </summary>
        [AWSProperty(Min=0)]
        public int? FadeOut
        {
            get { return this._fadeOut; }
            set { this._fadeOut = value; }
        }

        // Check to see if FadeOut property is set
        internal bool IsSetFadeOut()
        {
            return this._fadeOut.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Height. The height of the image when inserted into the
        /// video, in pixels. The overlay will be scaled up or down to the specified height. Leave
        /// blank to use the native height of the overlay.
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property Image. The location and filename of the image file to overlay
        /// on the video. The file must be a 32-bit BMP, PNG, or TGA file, and must not be larger
        /// (in pixels) than the input video.
        /// </summary>
        [AWSProperty(Required=true)]
        public InputLocation Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property ImageX. Placement of the left edge of the overlay relative
        /// to the left edge of the video frame, in pixels. 0 (the default) is the left edge of
        /// the frame. If the placement causes the overlay to extend beyond the right edge of
        /// the underlying video, then the overlay is cropped on the right.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ImageX
        {
            get { return this._imageX; }
            set { this._imageX = value; }
        }

        // Check to see if ImageX property is set
        internal bool IsSetImageX()
        {
            return this._imageX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageY. Placement of the top edge of the overlay relative
        /// to the top edge of the video frame, in pixels. 0 (the default) is the top edge of
        /// the frame. If the placement causes the overlay to extend beyond the bottom edge of
        /// the underlying video, then the overlay is cropped on the bottom.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ImageY
        {
            get { return this._imageY; }
            set { this._imageY = value; }
        }

        // Check to see if ImageY property is set
        internal bool IsSetImageY()
        {
            return this._imageY.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Layer. The number of the layer, 0 to 7. There are 8 layers
        /// that can be overlaid on the video, each layer with a different image. The layers are
        /// in Z order, which means that overlays with higher values of layer are inserted on
        /// top of overlays with lower values of layer. Default is 0.
        /// </summary>
        [AWSProperty(Min=0, Max=7)]
        public int? Layer
        {
            get { return this._layer; }
            set { this._layer = value; }
        }

        // Check to see if Layer property is set
        internal bool IsSetLayer()
        {
            return this._layer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Opacity. Opacity of image where 0 is transparent and 100
        /// is fully opaque. Default is 100.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Opacity
        {
            get { return this._opacity; }
            set { this._opacity = value; }
        }

        // Check to see if Opacity property is set
        internal bool IsSetOpacity()
        {
            return this._opacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputNames. The name(s) of the output(s) the activation
        /// should apply to.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> OutputNames
        {
            get { return this._outputNames; }
            set { this._outputNames = value; }
        }

        // Check to see if OutputNames property is set
        internal bool IsSetOutputNames()
        {
            return this._outputNames != null && (this._outputNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Width. The width of the image when inserted into the video,
        /// in pixels. The overlay will be scaled up or down to the specified width. Leave blank
        /// to use the native width of the overlay.
        /// </summary>
        [AWSProperty(Min=1)]
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