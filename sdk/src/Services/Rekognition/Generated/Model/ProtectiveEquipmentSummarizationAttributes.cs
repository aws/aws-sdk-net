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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Specifies summary attributes to return from a call to <a>DetectProtectiveEquipment</a>.
    /// You can specify which types of PPE to summarize. You can also specify a minimum confidence
    /// value for detections. Summary information is returned in the <code>Summary</code>
    /// (<a>ProtectiveEquipmentSummary</a>) field of the response from <code>DetectProtectiveEquipment</code>.
    /// The summary includes which persons in an image were detected wearing the requested
    /// types of person protective equipment (PPE), which persons were detected as not wearing
    /// PPE, and the persons in which a determination could not be made. For more information,
    /// see <a>ProtectiveEquipmentSummary</a>.
    /// </summary>
    public partial class ProtectiveEquipmentSummarizationAttributes
    {
        private float? _minConfidence;
        private List<string> _requiredEquipmentTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property MinConfidence. 
        /// <para>
        /// The minimum confidence level for which you want summary information. The confidence
        /// level applies to person detection, body part detection, equipment detection, and body
        /// part coverage. Amazon Rekognition doesn't return summary information with a confidence
        /// than this specified value. There isn't a default value.
        /// </para>
        ///  
        /// <para>
        /// Specify a <code>MinConfidence</code> value that is between 50-100% as <code>DetectProtectiveEquipment</code>
        /// returns predictions only where the detection confidence is between 50% - 100%. If
        /// you specify a value that is less than 50%, the results are the same specifying a value
        /// of 50%.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public float MinConfidence
        {
            get { return this._minConfidence.GetValueOrDefault(); }
            set { this._minConfidence = value; }
        }

        // Check to see if MinConfidence property is set
        internal bool IsSetMinConfidence()
        {
            return this._minConfidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiredEquipmentTypes. 
        /// <para>
        /// An array of personal protective equipment types for which you want summary information.
        /// If a person is detected wearing a required requipment type, the person's ID is added
        /// to the <code>PersonsWithRequiredEquipment</code> array field returned in <a>ProtectiveEquipmentSummary</a>
        /// by <code>DetectProtectiveEquipment</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RequiredEquipmentTypes
        {
            get { return this._requiredEquipmentTypes; }
            set { this._requiredEquipmentTypes = value; }
        }

        // Check to see if RequiredEquipmentTypes property is set
        internal bool IsSetRequiredEquipmentTypes()
        {
            return this._requiredEquipmentTypes != null && this._requiredEquipmentTypes.Count > 0; 
        }

    }
}