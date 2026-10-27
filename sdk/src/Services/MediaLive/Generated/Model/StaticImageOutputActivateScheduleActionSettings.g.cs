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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Settings for the action to activate a static image.
    /// </summary>
    public partial class StaticImageOutputActivateScheduleActionSettings
    {
        /// <summary>
        /// Gets and sets the property Duration. The duration in milliseconds for the image to
        /// remain on the video. If omitted or set to 0 the duration is unlimited and the image
        /// will remain until it is explicitly deactivated.
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property FadeIn. The time in milliseconds for the image to fade
        /// in. The fade-in starts at the start time of the overlay. Default is 0 (no fade-in).
        /// </summary>
        public int? FadeIn { get; set; }

        /// <summary>
        /// Checks to see if the FadeIn property is set.
        /// </summary>
        internal bool IsSetFadeIn() => this.FadeIn.HasValue;

        /// <summary>
        /// Gets and sets the property FadeOut. Applies only if a duration is specified. The time
        /// in milliseconds for the image to fade out. The fade-out starts when the duration time
        /// is hit, so it effectively extends the duration. Default is 0 (no fade-out).
        /// </summary>
        public int? FadeOut { get; set; }

        /// <summary>
        /// Checks to see if the FadeOut property is set.
        /// </summary>
        internal bool IsSetFadeOut() => this.FadeOut.HasValue;

        /// <summary>
        /// Gets and sets the property Height. The height of the image when inserted into the
        /// video, in pixels. The overlay will be scaled up or down to the specified height. Leave
        /// blank to use the native height of the overlay.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property Image. The location and filename of the image file to overlay
        /// on the video. The file must be a 32-bit BMP, PNG, or TGA file, and must not be larger
        /// (in pixels) than the input video.
        /// </summary>
        [AWSProperty(Required = true)]
        public InputLocation Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property ImageX. Placement of the left edge of the overlay relative
        /// to the left edge of the video frame, in pixels. 0 (the default) is the left edge of
        /// the frame. If the placement causes the overlay to extend beyond the right edge of
        /// the underlying video, then the overlay is cropped on the right.
        /// </summary>
        public int? ImageX { get; set; }

        /// <summary>
        /// Checks to see if the ImageX property is set.
        /// </summary>
        internal bool IsSetImageX() => this.ImageX.HasValue;

        /// <summary>
        /// Gets and sets the property ImageY. Placement of the top edge of the overlay relative
        /// to the top edge of the video frame, in pixels. 0 (the default) is the top edge of
        /// the frame. If the placement causes the overlay to extend beyond the bottom edge of
        /// the underlying video, then the overlay is cropped on the bottom.
        /// </summary>
        public int? ImageY { get; set; }

        /// <summary>
        /// Checks to see if the ImageY property is set.
        /// </summary>
        internal bool IsSetImageY() => this.ImageY.HasValue;

        /// <summary>
        /// Gets and sets the property Layer. The number of the layer, 0 to 7. There are 8 layers
        /// that can be overlaid on the video, each layer with a different image. The layers are
        /// in Z order, which means that overlays with higher values of layer are inserted on
        /// top of overlays with lower values of layer. Default is 0.
        /// </summary>
        public int? Layer { get; set; }

        /// <summary>
        /// Checks to see if the Layer property is set.
        /// </summary>
        internal bool IsSetLayer() => this.Layer.HasValue;

        /// <summary>
        /// Gets and sets the property Opacity. Opacity of image where 0 is transparent and 100
        /// is fully opaque. Default is 100.
        /// </summary>
        public int? Opacity { get; set; }

        /// <summary>
        /// Checks to see if the Opacity property is set.
        /// </summary>
        internal bool IsSetOpacity() => this.Opacity.HasValue;

        /// <summary>
        /// Gets and sets the property OutputNames. The name(s) of the output(s) the activation
        /// should apply to.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> OutputNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OutputNames property is set.
        /// </summary>
        internal bool IsSetOutputNames() => this.OutputNames != null && (this.OutputNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Width. The width of the image when inserted into the video,
        /// in pixels. The overlay will be scaled up or down to the specified width. Leave blank
        /// to use the native width of the overlay.
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
