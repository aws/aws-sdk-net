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
    /// Container for the parameters to the GetImages operation.
    /// Retrieves a list of images corresponding to each timestamp for a given time range,
    /// sampling interval, and image format configuration.
    /// </summary>
    public partial class GetImagesRequest : AmazonKinesisVideoArchivedMediaRequest
    {
        private DateTime? _endTimestamp;
        private Format _format;
        private Dictionary<string, string> _formatConfig = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _heightPixels;
        private ImageSelectorType _imageSelectorType;
        private long? _maxResults;
        private string _nextToken;
        private int? _samplingInterval;
        private DateTime? _startTimestamp;
        private string _streamARN;
        private string _streamName;
        private int? _widthPixels;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The end timestamp for the range of images to be generated. If the time range between
        /// <c>StartTimestamp</c> and <c>EndTimestamp</c> is more than 300 seconds above <c>StartTimestamp</c>,
        /// you will receive an <c>IllegalArgumentException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTimestamp
        {
            get { return this._endTimestamp; }
            set { this._endTimestamp = value; }
        }

        // Check to see if EndTimestamp property is set
        internal bool IsSetEndTimestamp()
        {
            return this._endTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format that will be used to encode the image.
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
        /// applied when the image is generated. The <c>FormatConfig</c> key is the <c>JPEGQuality</c>,
        /// which indicates the JPEG quality key to be used to generate the image. The <c>FormatConfig</c>
        /// value accepts ints from 1 to 100. If the value is 1, the image will be generated with
        /// less quality and the best compression. If the value is 100, the image will be generated
        /// with the best quality and less compression. If no value is provided, the default value
        /// of the <c>JPEGQuality</c> key will be set to 80.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._formatConfig != null && (this._formatConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HeightPixels. 
        /// <para>
        /// The height of the output image that is used in conjunction with the <c>WidthPixels</c>
        /// parameter. When both <c>HeightPixels</c> and <c>WidthPixels</c> parameters are provided,
        /// the image will be stretched to fit the specified aspect ratio. If only the <c>HeightPixels</c>
        /// parameter is provided, its original aspect ratio will be used to calculate the <c>WidthPixels</c>
        /// ratio. If neither parameter is provided, the original image size will be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2160)]
        public int? HeightPixels
        {
            get { return this._heightPixels; }
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of images to be returned by the API. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The default limit is 25 images per API response. Providing a <c>MaxResults</c> greater
        /// than this value will result in a page size of 25. Any additional results will be paginated.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public long? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that specifies where to start paginating the next set of Images. This is the
        /// <c>GetImages:NextToken</c> from a previously truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SamplingInterval. 
        /// <para>
        /// The time interval in milliseconds (ms) at which the images need to be generated from
        /// the stream. The minimum value that can be provided is 200 ms (5 images per second).
        /// If the timestamp range is less than the sampling interval, the image from the <c>startTimestamp</c>
        /// will be returned if available. 
        /// </para>
        /// </summary>
        public int? SamplingInterval
        {
            get { return this._samplingInterval; }
            set { this._samplingInterval = value; }
        }

        // Check to see if SamplingInterval property is set
        internal bool IsSetSamplingInterval()
        {
            return this._samplingInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The starting point from which the images should be generated. This <c>StartTimestamp</c>
        /// must be within an inclusive range of timestamps for an image to be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream from which to retrieve the images. You
        /// must specify either the <c>StreamName</c> or the <c>StreamARN</c>.
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
        /// The name of the stream from which to retrieve the images. You must specify either
        /// the <c>StreamName</c> or the <c>StreamARN</c>.
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

        /// <summary>
        /// Gets and sets the property WidthPixels. 
        /// <para>
        /// The width of the output image that is used in conjunction with the <c>HeightPixels</c>
        /// parameter. When both <c>WidthPixels</c> and <c>HeightPixels</c> parameters are provided,
        /// the image will be stretched to fit the specified aspect ratio. If only the <c>WidthPixels</c>
        /// parameter is provided or if only the <c>HeightPixels</c> is provided, a <c>ValidationException</c>
        /// will be thrown. If neither parameter is provided, the original image size from the
        /// stream will be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3840)]
        public int? WidthPixels
        {
            get { return this._widthPixels; }
            set { this._widthPixels = value; }
        }

        // Check to see if WidthPixels property is set
        internal bool IsSetWidthPixels()
        {
            return this._widthPixels.HasValue; 
        }

    }
}