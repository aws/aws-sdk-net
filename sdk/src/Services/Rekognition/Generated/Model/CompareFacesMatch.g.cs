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
    /// Provides information about a face in a target image that matches the source image
    /// face analyzed by <c>CompareFaces</c>. The <c>Face</c> property contains the bounding
    /// box of the face in the target image. The <c>Similarity</c> property is the confidence
    /// that the source image face matches the face in the bounding box.
    /// </summary>
    public partial class CompareFacesMatch
    {
        /// <summary>
        /// Gets and sets the property Face. 
        /// <para>
        /// Provides face metadata (bounding box and confidence that the bounding box actually
        /// contains a face).
        /// </para>
        /// </summary>
        public ComparedFace Face { get; set; }

        /// <summary>
        /// Checks to see if the Face property is set.
        /// </summary>
        internal bool IsSetFace() => this.Face != null;

        /// <summary>
        /// Gets and sets the property Similarity. 
        /// <para>
        /// Level of confidence that the faces match.
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
