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
    /// Provides face metadata. In addition, it also provides the confidence in the match
    /// of this face with the input face.
    /// </summary>
    public partial class FaceMatch
    {
        /// <summary>
        /// Gets and sets the property Face. 
        /// <para>
        /// Describes the face properties such as the bounding box, face ID, image ID of the source
        /// image, and external image ID that you assigned.
        /// </para>
        /// </summary>
        public Face Face { get; set; }

        /// <summary>
        /// Checks to see if the Face property is set.
        /// </summary>
        internal bool IsSetFace() => this.Face != null;

        /// <summary>
        /// Gets and sets the property Similarity. 
        /// <para>
        /// Confidence in the match of this face with the input face.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? Similarity { get; set; }

        /// <summary>
        /// Checks to see if the Similarity property is set.
        /// </summary>
        internal bool IsSetSimilarity() => this.Similarity.HasValue;
    }
}
