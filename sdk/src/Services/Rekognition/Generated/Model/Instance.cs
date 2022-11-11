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
    /// An instance of a label returned by Amazon Rekognition Image (<a>DetectLabels</a>)
    /// or by Amazon Rekognition Video (<a>GetLabelDetection</a>).
    /// </summary>
    public partial class Instance
    {
        private BoundingBox _boundingBox;
        private float? _confidence;
        private List<DominantColor> _dominantColors = new List<DominantColor>();

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// The position of the label instance on the image.
        /// </para>
        /// </summary>
        public BoundingBox BoundingBox
        {
            get { return this._boundingBox; }
            set { this._boundingBox = value; }
        }

        // Check to see if BoundingBox property is set
        internal bool IsSetBoundingBox()
        {
            return this._boundingBox != null;
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence that Amazon Rekognition has in the accuracy of the bounding box.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DominantColors. 
        /// <para>
        /// The dominant colors found in an individual instance of a label.
        /// </para>
        /// </summary>
        public List<DominantColor> DominantColors
        {
            get { return this._dominantColors; }
            set { this._dominantColors = value; }
        }

        // Check to see if DominantColors property is set
        internal bool IsSetDominantColors()
        {
            return this._dominantColors != null && this._dominantColors.Count > 0; 
        }

    }
}