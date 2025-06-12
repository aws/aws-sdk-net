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
    /// Summary information for required items of personal protective equipment (PPE) detected
    /// on persons by a call to <a>DetectProtectiveEquipment</a>. You specify the required
    /// type of PPE in the <c>SummarizationAttributes</c> (<a>ProtectiveEquipmentSummarizationAttributes</a>)
    /// input parameter. The summary includes which persons were detected wearing the required
    /// personal protective equipment (<c>PersonsWithRequiredEquipment</c>), which persons
    /// were detected as not wearing the required PPE (<c>PersonsWithoutRequiredEquipment</c>),
    /// and the persons in which a determination could not be made (<c>PersonsIndeterminate</c>).
    /// 
    ///  
    /// <para>
    /// To get a total for each category, use the size of the field array. For example, to
    /// find out how many people were detected as wearing the specified PPE, use the size
    /// of the <c>PersonsWithRequiredEquipment</c> array. If you want to find out more about
    /// a person, such as the location (<a>BoundingBox</a>) of the person on the image, use
    /// the person ID in each array element. Each person ID matches the ID field of a <a>ProtectiveEquipmentPerson</a>
    /// object returned in the <c>Persons</c> array by <c>DetectProtectiveEquipment</c>.
    /// </para>
    /// </summary>
    public partial class ProtectiveEquipmentSummary
    {
        private List<int> _personsIndeterminate = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _personsWithoutRequiredEquipment = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _personsWithRequiredEquipment = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Gets and sets the property PersonsIndeterminate. 
        /// <para>
        /// An array of IDs for persons where it was not possible to determine if they are wearing
        /// personal protective equipment. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> PersonsIndeterminate
        {
            get { return this._personsIndeterminate; }
            set { this._personsIndeterminate = value; }
        }

        // Check to see if PersonsIndeterminate property is set
        internal bool IsSetPersonsIndeterminate()
        {
            return this._personsIndeterminate != null && (this._personsIndeterminate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PersonsWithoutRequiredEquipment. 
        /// <para>
        /// An array of IDs for persons who are not wearing all of the types of PPE specified
        /// in the <c>RequiredEquipmentTypes</c> field of the detected personal protective equipment.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> PersonsWithoutRequiredEquipment
        {
            get { return this._personsWithoutRequiredEquipment; }
            set { this._personsWithoutRequiredEquipment = value; }
        }

        // Check to see if PersonsWithoutRequiredEquipment property is set
        internal bool IsSetPersonsWithoutRequiredEquipment()
        {
            return this._personsWithoutRequiredEquipment != null && (this._personsWithoutRequiredEquipment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PersonsWithRequiredEquipment. 
        /// <para>
        /// An array of IDs for persons who are wearing detected personal protective equipment.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> PersonsWithRequiredEquipment
        {
            get { return this._personsWithRequiredEquipment; }
            set { this._personsWithRequiredEquipment = value; }
        }

        // Check to see if PersonsWithRequiredEquipment property is set
        internal bool IsSetPersonsWithRequiredEquipment()
        {
            return this._personsWithRequiredEquipment != null && (this._personsWithRequiredEquipment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}