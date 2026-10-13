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
    /// Information about an item of Personal Protective Equipment (PPE) detected by <a>DetectProtectiveEquipment</a>.
    /// For more information, see <a>DetectProtectiveEquipment</a>.
    /// </summary>
    public partial class EquipmentDetection
    {
        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// A bounding box surrounding the item of detected PPE.
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
        /// The confidence that Amazon Rekognition has that the bounding box (<c>BoundingBox</c>)
        /// contains an item of PPE.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property CoversBodyPart. 
        /// <para>
        /// Information about the body part covered by the detected PPE.
        /// </para>
        /// </summary>
        public CoversBodyPart CoversBodyPart { get; set; }

        /// <summary>
        /// Checks to see if the CoversBodyPart property is set.
        /// </summary>
        internal bool IsSetCoversBodyPart() => this.CoversBodyPart != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of detected PPE.
        /// </para>
        /// </summary>
        public ProtectiveEquipmentType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
