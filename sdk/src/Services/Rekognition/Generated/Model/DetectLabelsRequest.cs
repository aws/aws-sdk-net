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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DetectLabels operation.
    /// Detects instances of real-world labels within an image (JPEG or PNG) provided as input.
    /// This includes objects like flower, tree, and table; events like wedding, graduation,
    /// and birthday party; and concepts like landscape, evening, and nature. For an example,
    /// see <a>get-started-exercise-detect-labels</a>.
    /// 
    ///  
    /// <para>
    ///  For each object, scene, and concept the API returns one or more labels. Each label
    /// provides the object name, and the level of confidence that the image contains the
    /// object. For example, suppose the input image has a lighthouse, the sea, and a rock.
    /// The response will include all three labels, one for each object. 
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
    ///  In the preceding example, the operation returns one label for each of the three objects.
    /// The operation can also return multiple labels for the same object in the image. For
    /// example, if the input image shows a flower (for example, a tulip), the operation might
    /// return the following three labels. 
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
    ///  
    /// <para>
    /// You can provide the input image as an S3 object or as base64-encoded bytes. In response,
    /// the API returns an array of labels. In addition, the response also includes the orientation
    /// correction. Optionally, you can specify <code>MinConfidence</code> to control the
    /// confidence threshold for the labels returned. The default is 50%. You can also add
    /// the <code>MaxLabels</code> parameter to limit the number of labels returned. 
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
        private Image _image;
        private int? _maxLabels;
        private float? _minConfidence;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The input image. You can provide a blob of image bytes or an S3 object.
        /// </para>
        /// </summary>
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
        /// If <code>minConfidence</code> is not specified, the operation returns labels with
        /// a confidence values greater than or equal to 50 percent.
        /// </para>
        /// </summary>
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

    }
}