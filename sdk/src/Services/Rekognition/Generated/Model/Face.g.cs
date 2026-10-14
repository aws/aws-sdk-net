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
    /// Describes the face properties such as the bounding box, face ID, image ID of the input
    /// image, and external image ID that you assigned.
    /// </summary>
    public partial class Face
    {
        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Bounding box of the face.
        /// </para>
        /// </summary>
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// Checks to see if the BoundingBox property is set.
        /// </summary>
        internal bool IsSetBoundingBox() => this.BoundingBox != null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Confidence level that the bounding box contains a face (and not a different object
        /// such as a tree).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property ExternalImageId. 
        /// <para>
        /// Identifier that you assign to all the faces in the input image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ExternalImageId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalImageId property is set.
        /// </summary>
        internal bool IsSetExternalImageId() => this.ExternalImageId != null;

        /// <summary>
        /// Gets and sets the property FaceId. 
        /// <para>
        /// Unique identifier that Amazon Rekognition assigns to the face.
        /// </para>
        /// </summary>
        public string FaceId { get; set; }

        /// <summary>
        /// Checks to see if the FaceId property is set.
        /// </summary>
        internal bool IsSetFaceId() => this.FaceId != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// Unique identifier that Amazon Rekognition assigns to the input image.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property IndexFacesModelVersion. 
        /// <para>
        ///  The version of the face detect and storage model that was used when indexing the
        /// face vector. 
        /// </para>
        /// </summary>
        public string IndexFacesModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the IndexFacesModelVersion property is set.
        /// </summary>
        internal bool IsSetIndexFacesModelVersion() => this.IndexFacesModelVersion != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Unique identifier assigned to the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
