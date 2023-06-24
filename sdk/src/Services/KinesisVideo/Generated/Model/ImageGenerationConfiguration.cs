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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// The structure that contains the information required for the KVS images delivery.
    /// If null, the configuration will be deleted from the stream.
    /// </summary>
    public partial class ImageGenerationConfiguration
    {
        private ImageGenerationDestinationConfig _destinationConfig;
        private Format _format;
        private Dictionary<string, string> _formatConfig = new Dictionary<string, string>();
        private int? _heightPixels;
        private ImageSelectorType _imageSelectorType;
        private int? _samplingInterval;
        private ConfigurationStatus _status;
        private int? _widthPixels;

        /// <summary>
        /// Gets and sets the property DestinationConfig. 
        /// <para>
        /// The structure that contains the information required to deliver images to a customer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageGenerationDestinationConfig DestinationConfig
        {
            get { return this._destinationConfig; }
            set { this._destinationConfig = value; }
        }

        // Check to see if DestinationConfig property is set
        internal bool IsSetDestinationConfig()
        {
            return this._destinationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The accepted image format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Format Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property FormatConfig. 
        /// <para>
        /// The list of a key-value pair structure that contains extra parameters that can be
        /// applied when the image is generated. The <code>FormatConfig</code> key is the <code>JPEGQuality</code>,
        /// which indicates the JPEG quality key to be used to generate the image. The <code>FormatConfig</code>
        /// value accepts ints from 1 to 100. If the value is 1, the image will be generated with
        /// less quality and the best compression. If the value is 100, the image will be generated
        /// with the best quality and less compression. If no value is provided, the default value
        /// of the <code>JPEGQuality</code> key will be set to 80.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public Dictionary<string, string> FormatConfig
        {
            get { return this._formatConfig; }
            set { this._formatConfig = value; }
        }

        // Check to see if FormatConfig property is set
        internal bool IsSetFormatConfig()
        {
            return this._formatConfig != null && this._formatConfig.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HeightPixels. 
        /// <para>
        /// The height of the output image that is used in conjunction with the <code>WidthPixels</code>
        /// parameter. When both <code>HeightPixels</code> and <code>WidthPixels</code> parameters
        /// are provided, the image will be stretched to fit the specified aspect ratio. If only
        /// the <code>HeightPixels</code> parameter is provided, its original aspect ratio will
        /// be used to calculate the <code>WidthPixels</code> ratio. If neither parameter is provided,
        /// the original image size will be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2160)]
        public int HeightPixels
        {
            get { return this._heightPixels.GetValueOrDefault(); }
            set { this._heightPixels = value; }
        }

        // Check to see if HeightPixels property is set
        internal bool IsSetHeightPixels()
        {
            return this._heightPixels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageSelectorType. 
        /// <para>
        /// The origin of the Server or Producer timestamps to use to generate the images.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageSelectorType ImageSelectorType
        {
            get { return this._imageSelectorType; }
            set { this._imageSelectorType = value; }
        }

        // Check to see if ImageSelectorType property is set
        internal bool IsSetImageSelectorType()
        {
            return this._imageSelectorType != null;
        }

        /// <summary>
        /// Gets and sets the property SamplingInterval. 
        /// <para>
        /// The time interval in milliseconds (ms) at which the images need to be generated from
        /// the stream. The minimum value that can be provided is 33 ms, because a camera that
        /// generates content at 30 FPS would create a frame every 33.3 ms. If the timestamp range
        /// is less than the sampling interval, the Image from the <code>StartTimestamp</code>
        /// will be returned if available. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3000, Max=20000)]
        public int SamplingInterval
        {
            get { return this._samplingInterval.GetValueOrDefault(); }
            set { this._samplingInterval = value; }
        }

        // Check to see if SamplingInterval property is set
        internal bool IsSetSamplingInterval()
        {
            return this._samplingInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates whether the <code>ContinuousImageGenerationConfigurations</code> API is
        /// enabled or disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WidthPixels. 
        /// <para>
        /// The width of the output image that is used in conjunction with the <code>HeightPixels</code>
        /// parameter. When both <code>WidthPixels</code> and <code>HeightPixels</code> parameters
        /// are provided, the image will be stretched to fit the specified aspect ratio. If only
        /// the <code>WidthPixels</code> parameter is provided, its original aspect ratio will
        /// be used to calculate the <code>HeightPixels</code> ratio. If neither parameter is
        /// provided, the original image size will be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3840)]
        public int WidthPixels
        {
            get { return this._widthPixels.GetValueOrDefault(); }
            set { this._widthPixels = value; }
        }

        // Check to see if WidthPixels property is set
        internal bool IsSetWidthPixels()
        {
            return this._widthPixels.HasValue; 
        }

    }
}