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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Information about a word or line of text detected by <a>DetectText</a>.
    /// 
    ///  
    /// <para>
    /// The <c>DetectedText</c> field contains the text that Amazon Rekognition detected in
    /// the image. 
    /// </para>
    ///  
    /// <para>
    /// Every word and line has an identifier (<c>Id</c>). Each word belongs to a line and
    /// has a parent identifier (<c>ParentId</c>) that identifies the line of text in which
    /// the word appears. The word <c>Id</c> is also an index for the word within a line of
    /// words. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see Detecting text in the Amazon Rekognition Developer Guide.
    /// </para>
    /// </summary>
    public partial class TextDetection
    {
        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence that Amazon Rekognition has in the accuracy of the detected text and
        /// the accuracy of the geometry points around the detected text.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property DetectedText. 
        /// <para>
        /// The word or line of text recognized by Amazon Rekognition. 
        /// </para>
        /// </summary>
        public string DetectedText { get; set; }

        /// <summary>
        /// Checks to see if the DetectedText property is set.
        /// </summary>
        internal bool IsSetDetectedText() => this.DetectedText != null;

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// The location of the detected text on the image. Includes an axis aligned coarse bounding
        /// box surrounding the text and a finer grain polygon for more accurate spatial information.
        /// </para>
        /// </summary>
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Checks to see if the Geometry property is set.
        /// </summary>
        internal bool IsSetGeometry() => this.Geometry != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the detected text. The identifier is only unique for a single call
        /// to <c>DetectText</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id.HasValue;

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The Parent identifier for the detected text identified by the value of <c>ID</c>.
        /// If the type of detected text is <c>LINE</c>, the value of <c>ParentId</c> is <c>Null</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ParentId { get; set; }

        /// <summary>
        /// Checks to see if the ParentId property is set.
        /// </summary>
        internal bool IsSetParentId() => this.ParentId.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of text that was detected.
        /// </para>
        /// </summary>
        public TextTypes Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
