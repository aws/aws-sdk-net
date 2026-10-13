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
    /// Information about a recognized celebrity.
    /// </summary>
    public partial class CelebrityDetail
    {
        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Bounding box around the body of a celebrity.
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
        /// The confidence, in percentage, that Amazon Rekognition has that the recognized face
        /// is the celebrity. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Face. 
        /// <para>
        /// Face details for the recognized celebrity.
        /// </para>
        /// </summary>
        public FaceDetail Face { get; set; }

        /// <summary>
        /// Checks to see if the Face property is set.
        /// </summary>
        internal bool IsSetFace() => this.Face != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the celebrity. 
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property KnownGender. 
        /// <para>
        /// Retrieves the known gender for the celebrity.
        /// </para>
        /// </summary>
        public KnownGender KnownGender { get; set; }

        /// <summary>
        /// Checks to see if the KnownGender property is set.
        /// </summary>
        internal bool IsSetKnownGender() => this.KnownGender != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the celebrity.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Urls. 
        /// <para>
        /// An array of URLs pointing to additional celebrity information. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public List<string> Urls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Urls property is set.
        /// </summary>
        internal bool IsSetUrls() => this.Urls != null && (this.Urls.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
