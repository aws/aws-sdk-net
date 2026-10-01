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

namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// Container for the parameters to the GetImages operation. Retrieves a list of images
    /// corresponding to each timestamp for a given time range, sampling interval, and image
    /// format configuration.
    /// </summary>
    public partial class GetImagesRequest : AmazonKinesisVideoArchivedMediaRequest
    {
        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The end timestamp for the range of images to be generated. If the time range between
        /// <c>StartTimestamp</c> and <c>EndTimestamp</c> is more than 300 seconds above <c>StartTimestamp</c>,
        /// you will receive an <c>IllegalArgumentException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestamp property is set.
        /// </summary>
        internal bool IsSetEndTimestamp() => this.EndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format that will be used to encode the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Format Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public Dictionary<string, string> FormatConfig { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the FormatConfig property is set.
        /// </summary>
        internal bool IsSetFormatConfig() => this.FormatConfig != null && (this.FormatConfig.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 1, Max = 2160)]
        public int? HeightPixels { get; set; }

        /// <summary>
        /// Checks to see if the HeightPixels property is set.
        /// </summary>
        internal bool IsSetHeightPixels() => this.HeightPixels.HasValue;

        /// <summary>
        /// Gets and sets the property ImageSelectorType. 
        /// <para>
        /// The origin of the Server or Producer timestamps to use to generate the images.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageSelectorType ImageSelectorType { get; set; }

        /// <summary>
        /// Checks to see if the ImageSelectorType property is set.
        /// </summary>
        internal bool IsSetImageSelectorType() => this.ImageSelectorType != null;

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
        [AWSProperty(Min = 1, Max = 100)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that specifies where to start paginating the next set of Images. This is the
        /// <c>GetImages:NextToken</c> from a previously truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SamplingInterval. 
        /// <para>
        /// The time interval in milliseconds (ms) at which the images need to be generated from
        /// the stream. The minimum value that can be provided is 200 ms (5 images per second).
        /// If the timestamp range is less than the sampling interval, the image from the <c>startTimestamp</c>
        /// will be returned if available. 
        /// </para>
        /// </summary>
        public int? SamplingInterval { get; set; }

        /// <summary>
        /// Checks to see if the SamplingInterval property is set.
        /// </summary>
        internal bool IsSetSamplingInterval() => this.SamplingInterval.HasValue;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The starting point from which the images should be generated. This <c>StartTimestamp</c>
        /// must be within an inclusive range of timestamps for an image to be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream from which to retrieve the images. You
        /// must specify either the <c>StreamName</c> or the <c>StreamARN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream from which to retrieve the images. You must specify either
        /// the <c>StreamName</c> or the <c>StreamARN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

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
        [AWSProperty(Min = 1, Max = 3840)]
        public int? WidthPixels { get; set; }

        /// <summary>
        /// Checks to see if the WidthPixels property is set.
        /// </summary>
        internal bool IsSetWidthPixels() => this.WidthPixels.HasValue;
    }
}
