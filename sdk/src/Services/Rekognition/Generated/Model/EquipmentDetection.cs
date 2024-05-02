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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Information about an item of Personal Protective Equipment (PPE) detected by <a>DetectProtectiveEquipment</a>.
    /// For more information, see <a>DetectProtectiveEquipment</a>.
    /// </summary>
    public partial class EquipmentDetection
    {
        private BoundingBox _boundingBox;
        private float? _confidence;
        private CoversBodyPart _coversBodyPart;
        private ProtectiveEquipmentType _type;

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// A bounding box surrounding the item of detected PPE.
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
        /// The confidence that Amazon Rekognition has that the bounding box (<c>BoundingBox</c>)
        /// contains an item of PPE.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CoversBodyPart. 
        /// <para>
        /// Information about the body part covered by the detected PPE.
        /// </para>
        /// </summary>
        public CoversBodyPart CoversBodyPart
        {
            get { return this._coversBodyPart; }
            set { this._coversBodyPart = value; }
        }

        // Check to see if CoversBodyPart property is set
        internal bool IsSetCoversBodyPart()
        {
            return this._coversBodyPart != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of detected PPE.
        /// </para>
        /// </summary>
        public ProtectiveEquipmentType Type
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