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
    /// Information about a body part detected by <a>DetectProtectiveEquipment</a> that contains
    /// PPE. An array of <c>ProtectiveEquipmentBodyPart</c> objects is returned for each person
    /// detected by <c>DetectProtectiveEquipment</c>.
    /// </summary>
    public partial class ProtectiveEquipmentBodyPart
    {
        private float? _confidence;
        private List<EquipmentDetection> _equipmentDetections = AWSConfigs.InitializeCollections ? new List<EquipmentDetection>() : null;
        private BodyPart _name;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence that Amazon Rekognition has in the detection accuracy of the detected
        /// body part. 
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
        /// Gets and sets the property EquipmentDetections. 
        /// <para>
        /// An array of Personal Protective Equipment items detected around a body part.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EquipmentDetection> EquipmentDetections
        {
            get { return this._equipmentDetections; }
            set { this._equipmentDetections = value; }
        }

        // Check to see if EquipmentDetections property is set
        internal bool IsSetEquipmentDetections()
        {
            return this._equipmentDetections != null && (this._equipmentDetections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The detected body part.
        /// </para>
        /// </summary>
        public BodyPart Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}