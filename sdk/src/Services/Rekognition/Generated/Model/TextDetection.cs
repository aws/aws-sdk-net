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
    /// Information about a word or line of text detected by <a>DetectText</a>.
    /// 
    ///  
    /// <para>
    /// The <code>DetectedText</code> field contains the text that Amazon Rekognition detected
    /// in the image. 
    /// </para>
    ///  
    /// <para>
    /// Every word and line has an identifier (<code>Id</code>). Each word belongs to a line
    /// and has a parent identifier (<code>ParentId</code>) that identifies the line of text
    /// in which the word appears. The word <code>Id</code> is also an index for the word
    /// within a line of words. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see Detecting Text in the Amazon Rekognition Developer Guide.
    /// </para>
    /// </summary>
    public partial class TextDetection
    {
        private float? _confidence;
        private string _detectedText;
        private Geometry _geometry;
        private int? _id;
        private int? _parentId;
        private TextTypes _type;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence that Amazon Rekognition has in the accuracy of the detected text and
        /// the accuracy of the geometry points around the detected text.
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
        /// Gets and sets the property DetectedText. 
        /// <para>
        /// The word or line of text recognized by Amazon Rekognition. 
        /// </para>
        /// </summary>
        public string DetectedText
        {
            get { return this._detectedText; }
            set { this._detectedText = value; }
        }

        // Check to see if DetectedText property is set
        internal bool IsSetDetectedText()
        {
            return this._detectedText != null;
        }

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// The location of the detected text on the image. Includes an axis aligned coarse bounding
        /// box surrounding the text and a finer grain polygon for more accurate spatial information.
        /// </para>
        /// </summary>
        public Geometry Geometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        // Check to see if Geometry property is set
        internal bool IsSetGeometry()
        {
            return this._geometry != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the detected text. The identifier is only unique for a single call
        /// to <code>DetectText</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int Id
        {
            get { return this._id.GetValueOrDefault(); }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The Parent identifier for the detected text identified by the value of <code>ID</code>.
        /// If the type of detected text is <code>LINE</code>, the value of <code>ParentId</code>
        /// is <code>Null</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int ParentId
        {
            get { return this._parentId.GetValueOrDefault(); }
            set { this._parentId = value; }
        }

        // Check to see if ParentId property is set
        internal bool IsSetParentId()
        {
            return this._parentId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of text that was detected.
        /// </para>
        /// </summary>
        public TextTypes Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}