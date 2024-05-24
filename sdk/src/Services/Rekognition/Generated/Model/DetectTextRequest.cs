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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DetectText operation.
    /// Detects text in the input image and converts it into machine-readable text.
    /// 
    ///  
    /// <para>
    /// Pass the input image as base64-encoded image bytes or as a reference to an image in
    /// an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
    /// you must pass it as a reference to an image in an Amazon S3 bucket. For the AWS CLI,
    /// passing image bytes is not supported. The image must be either a .png or .jpeg formatted
    /// file. 
    /// </para>
    ///  
    /// <para>
    /// The <c>DetectText</c> operation returns text in an array of <a>TextDetection</a> elements,
    /// <c>TextDetections</c>. Each <c>TextDetection</c> element provides information about
    /// a single word or line of text that was detected in the image. 
    /// </para>
    ///  
    /// <para>
    /// A word is one or more script characters that are not separated by spaces. <c>DetectText</c>
    /// can detect up to 100 words in an image.
    /// </para>
    ///  
    /// <para>
    /// A line is a string of equally spaced words. A line isn't necessarily a complete sentence.
    /// For example, a driver's license number is detected as a line. A line ends when there
    /// is no aligned text after it. Also, a line ends when there is a large gap between words,
    /// relative to the length of the words. This means, depending on the gap between words,
    /// Amazon Rekognition may detect multiple lines in text aligned in the same direction.
    /// Periods don't represent the end of a line. If a sentence spans multiple lines, the
    /// <c>DetectText</c> operation returns multiple lines.
    /// </para>
    ///  
    /// <para>
    /// To determine whether a <c>TextDetection</c> element is a line of text or a word, use
    /// the <c>TextDetection</c> object <c>Type</c> field. 
    /// </para>
    ///  
    /// <para>
    /// To be detected, text must be within +/- 90 degrees orientation of the horizontal axis.
    /// </para>
    ///  
    /// <para>
    /// For more information, see Detecting text in the Amazon Rekognition Developer Guide.
    /// </para>
    /// </summary>
    public partial class DetectTextRequest : AmazonRekognitionRequest
    {
        private DetectTextFilters _filters;
        private Image _image;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Optional parameters that let you set the criteria that the text must meet to be included
        /// in your response.
        /// </para>
        /// </summary>
        public DetectTextFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The input image as base64-encoded bytes or an Amazon S3 object. If you use the AWS
        /// CLI to call Amazon Rekognition operations, you can't pass image bytes. 
        /// </para>
        ///  
        /// <para>
        /// If you are using an AWS SDK to call Amazon Rekognition, you might not need to base64-encode
        /// image bytes passed using the <c>Bytes</c> field. For more information, see Images
        /// in the Amazon Rekognition developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Image Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

    }
}