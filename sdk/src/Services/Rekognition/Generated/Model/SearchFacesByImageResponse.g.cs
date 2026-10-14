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
    /// This is the response object from the SearchFacesByImage operation.
    /// </summary>
    public partial class SearchFacesByImageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FaceMatches. 
        /// <para>
        /// An array of faces that match the input face, along with the confidence in the match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FaceMatch> FaceMatches { get; set; } = AWSConfigs.InitializeCollections ? new List<FaceMatch>() : null;

        /// <summary>
        /// Checks to see if the FaceMatches property is set.
        /// </summary>
        internal bool IsSetFaceMatches() => this.FaceMatches != null && (this.FaceMatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FaceModelVersion. 
        /// <para>
        /// Version number of the face detection model associated with the input collection (<c>CollectionId</c>).
        /// </para>
        /// </summary>
        public string FaceModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the FaceModelVersion property is set.
        /// </summary>
        internal bool IsSetFaceModelVersion() => this.FaceModelVersion != null;

        /// <summary>
        /// Gets and sets the property SearchedFaceBoundingBox. 
        /// <para>
        /// The bounding box around the face in the input image that Amazon Rekognition used for
        /// the search.
        /// </para>
        /// </summary>
        public BoundingBox SearchedFaceBoundingBox { get; set; }

        /// <summary>
        /// Checks to see if the SearchedFaceBoundingBox property is set.
        /// </summary>
        internal bool IsSetSearchedFaceBoundingBox() => this.SearchedFaceBoundingBox != null;

        /// <summary>
        /// Gets and sets the property SearchedFaceConfidence. 
        /// <para>
        /// The level of confidence that the <c>searchedFaceBoundingBox</c>, contains a face.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? SearchedFaceConfidence { get; set; }

        /// <summary>
        /// Checks to see if the SearchedFaceConfidence property is set.
        /// </summary>
        internal bool IsSetSearchedFaceConfidence() => this.SearchedFaceConfidence.HasValue;
    }
}
