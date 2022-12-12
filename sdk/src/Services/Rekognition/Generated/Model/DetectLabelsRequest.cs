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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DetectLabels operation.
    /// Detects instances of real-world entities within an image (JPEG or PNG) provided as
    /// input. This includes objects like flower, tree, and table; events like wedding, graduation,
    /// and birthday party; and concepts like landscape, evening, and nature. 
    /// 
    ///  
    /// <para>
    /// For an example, see Analyzing images stored in an Amazon S3 bucket in the Amazon Rekognition
    /// Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// You pass the input image as base64-encoded image bytes or as a reference to an image
    /// in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
    /// passing image bytes is not supported. The image must be either a PNG or JPEG formatted
    /// file. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Optional Parameters</b> 
    /// </para>
    ///  
    /// <para>
    /// You can specify one or both of the <code>GENERAL_LABELS</code> and <code>IMAGE_PROPERTIES</code>
    /// feature types when calling the DetectLabels API. Including <code>GENERAL_LABELS</code>
    /// will ensure the response includes the labels detected in the input image, while including
    /// <code>IMAGE_PROPERTIES </code>will ensure the response includes information about
    /// the image quality and color.
    /// </para>
    ///  
    /// <para>
    /// When using <code>GENERAL_LABELS</code> and/or <code>IMAGE_PROPERTIES</code> you can
    /// provide filtering criteria to the Settings parameter. You can filter with sets of
    /// individual labels or with label categories. You can specify inclusive filters, exclusive
    /// filters, or a combination of inclusive and exclusive filters. For more information
    /// on filtering see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/labels-detect-labels-image.html">Detecting
    /// Labels in an Image</a>.
    /// </para>
    ///  
    /// <para>
    /// You can specify <code>MinConfidence</code> to control the confidence threshold for
    /// the labels returned. The default is 55%. You can also add the <code>MaxLabels</code>
    /// parameter to limit the number of labels returned. The default and upper limit is 1000
    /// labels.
    /// </para>
    ///  
    /// <para>
    ///  <b>Response Elements</b> 
    /// </para>
    ///  
    /// <para>
    ///  For each object, scene, and concept the API returns one or more labels. The API returns
    /// the following types of information regarding labels:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  Name - The name of the detected label. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Confidence - The level of confidence in the label assigned to a detected object.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Parents - The ancestor labels for a detected label. DetectLabels returns a hierarchical
    /// taxonomy of detected labels. For example, a detected car might be assigned the label
    /// car. The label car has two parent labels: Vehicle (its parent) and Transportation
    /// (its grandparent). The response includes the all ancestors for a label, where every
    /// ancestor is a unique label. In the previous example, Car, Vehicle, and Transportation
    /// are returned as unique labels in the response. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Aliases - Possible Aliases for the label. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Categories - The label categories that the detected label belongs to. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  BoundingBox — Bounding boxes are described for all instances of detected common object
    /// labels, returned in an array of Instance objects. An Instance object contains a BoundingBox
    /// object, describing the location of the label on the input image. It also includes
    /// the confidence for the accuracy of the detected bounding box. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  The API returns the following information regarding the image, as part of the ImageProperties
    /// structure:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Quality - Information about the Sharpness, Brightness, and Contrast of the input image,
    /// scored between 0 to 100. Image quality is returned for the entire image, as well as
    /// the background and the foreground. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Dominant Color - An array of the dominant colors in the image. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Foreground - Information about the sharpness, brightness, and dominant colors of the
    /// input image’s foreground. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Background - Information about the sharpness, brightness, and dominant colors of the
    /// input image’s background.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The list of returned labels will include at least one label for every detected object,
    /// along with information about that label. In the following example, suppose the input
    /// image has a lighthouse, the sea, and a rock. The response includes all three labels,
    /// one for each object, as well as the confidence in the label:
    /// </para>
    ///  
    /// <para>
    ///  <code>{Name: lighthouse, Confidence: 98.4629}</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>{Name: rock,Confidence: 79.2097}</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> {Name: sea,Confidence: 75.061}</code> 
    /// </para>
    ///  
    /// <para>
    /// The list of labels can include multiple labels for the same object. For example, if
    /// the input image shows a flower (for example, a tulip), the operation might return
    /// the following three labels. 
    /// </para>
    ///  
    /// <para>
    ///  <code>{Name: flower,Confidence: 99.0562}</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>{Name: plant,Confidence: 99.0562}</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>{Name: tulip,Confidence: 99.0562}</code> 
    /// </para>
    ///  
    /// <para>
    /// In this example, the detection algorithm more precisely identifies the flower as a
    /// tulip.
    /// </para>
    ///  <note> 
    /// <para>
    /// If the object detected is a person, the operation doesn't provide the same facial
    /// details that the <a>DetectFaces</a> operation provides.
    /// </para>
    ///  </note> 
    /// <para>
    /// This is a stateless API operation. That is, the operation does not persist any data.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:DetectLabels</code>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DetectLabelsRequest : AmazonRekognitionRequest
    {
        private List<string> _features = new List<string>();
        private Image _image;
        private int? _maxLabels;
        private float? _minConfidence;
        private DetectLabelsSettings _settings;

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// A list of the types of analysis to perform. Specifying GENERAL_LABELS uses the label
        /// detection feature, while specifying IMAGE_PROPERTIES returns information regarding
        /// image color and quality. If no option is specified GENERAL_LABELS is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && this._features.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The input image as base64-encoded bytes or an S3 object. If you use the AWS CLI to
        /// call Amazon Rekognition operations, passing image bytes is not supported. Images stored
        /// in an S3 Bucket do not need to be base64-encoded.
        /// </para>
        ///  
        /// <para>
        /// If you are using an AWS SDK to call Amazon Rekognition, you might not need to base64-encode
        /// image bytes passed using the <code>Bytes</code> field. For more information, see Images
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

        /// <summary>
        /// Gets and sets the property MaxLabels. 
        /// <para>
        /// Maximum number of labels you want the service to return in the response. The service
        /// returns the specified number of highest confidence labels. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MaxLabels
        {
            get { return this._maxLabels.GetValueOrDefault(); }
            set { this._maxLabels = value; }
        }

        // Check to see if MaxLabels property is set
        internal bool IsSetMaxLabels()
        {
            return this._maxLabels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinConfidence. 
        /// <para>
        /// Specifies the minimum confidence level for the labels to return. Amazon Rekognition
        /// doesn't return any labels with confidence lower than this specified value.
        /// </para>
        ///  
        /// <para>
        /// If <code>MinConfidence</code> is not specified, the operation returns labels with
        /// a confidence values greater than or equal to 55 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float MinConfidence
        {
            get { return this._minConfidence.GetValueOrDefault(); }
            set { this._minConfidence = value; }
        }

        // Check to see if MinConfidence property is set
        internal bool IsSetMinConfidence()
        {
            return this._minConfidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// A list of the filters to be applied to returned detected labels and image properties.
        /// Specified filters can be inclusive, exclusive, or a combination of both. Filters can
        /// be used for individual labels or label categories. The exact label names or label
        /// categories must be supplied. For a full list of labels and label categories, see LINK
        /// HERE.
        /// </para>
        /// </summary>
        public DetectLabelsSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

    }
}