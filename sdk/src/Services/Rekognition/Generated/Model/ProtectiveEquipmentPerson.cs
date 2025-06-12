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
    /// A person detected by a call to <a>DetectProtectiveEquipment</a>. The API returns all
    /// persons detected in the input image in an array of <c>ProtectiveEquipmentPerson</c>
    /// objects.
    /// </summary>
    public partial class ProtectiveEquipmentPerson
    {
        private List<ProtectiveEquipmentBodyPart> _bodyParts = AWSConfigs.InitializeCollections ? new List<ProtectiveEquipmentBodyPart>() : null;
        private BoundingBox _boundingBox;
        private float? _confidence;
        private int? _id;

        /// <summary>
        /// Gets and sets the property BodyParts. 
        /// <para>
        /// An array of body parts detected on a person's body (including body parts without PPE).
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProtectiveEquipmentBodyPart> BodyParts
        {
            get { return this._bodyParts; }
            set { this._bodyParts = value; }
        }

        // Check to see if BodyParts property is set
        internal bool IsSetBodyParts()
        {
            return this._bodyParts != null && (this._bodyParts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// A bounding box around the detected person.
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
        /// The confidence that Amazon Rekognition has that the bounding box contains a person.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the detected person. The identifier is only unique for a single
        /// call to <c>DetectProtectiveEquipment</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id.HasValue; 
        }

    }
}