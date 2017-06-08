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
    /// Container for the parameters to the DetectModerationLabels operation.
    /// Detects explicit or suggestive adult content in a specified JPEG or PNG format image.
    /// Use <code>DetectModerationLabels</code> to moderate images depending on your requirements.
    /// For example, you might want to filter images that contain nudity, but not images containing
    /// suggestive content.
    /// 
    ///  
    /// <para>
    /// To filter images, use the labels returned by <code>DetectModerationLabels</code> to
    /// determine which types of content are appropriate. For information about moderation
    /// labels, see <a>image-moderation</a>.
    /// </para>
    /// </summary>
    public partial class DetectModerationLabelsRequest : AmazonRekognitionRequest
    {
        private Image _image;
        private float? _minConfidence;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The input image as bytes or an S3 object.
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
        /// Gets and sets the property MinConfidence. 
        /// <para>
        /// Specifies the minimum confidence level for the labels to return. Amazon Rekognition
        /// doesn't return any labels with a confidence level lower than this specified value.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <code>MinConfidence</code>, the operation returns labels with
        /// confidence values greater than or equal to 50 percent.
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