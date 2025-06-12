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
    /// This is the response object from the DetectProtectiveEquipment operation.
    /// </summary>
    public partial class DetectProtectiveEquipmentResponse : AmazonWebServiceResponse
    {
        private List<ProtectiveEquipmentPerson> _persons = AWSConfigs.InitializeCollections ? new List<ProtectiveEquipmentPerson>() : null;
        private string _protectiveEquipmentModelVersion;
        private ProtectiveEquipmentSummary _summary;

        /// <summary>
        /// Gets and sets the property Persons. 
        /// <para>
        /// An array of persons detected in the image (including persons not wearing PPE).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProtectiveEquipmentPerson> Persons
        {
            get { return this._persons; }
            set { this._persons = value; }
        }

        // Check to see if Persons property is set
        internal bool IsSetPersons()
        {
            return this._persons != null && (this._persons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProtectiveEquipmentModelVersion. 
        /// <para>
        /// The version number of the PPE detection model used to detect PPE in the image.
        /// </para>
        /// </summary>
        public string ProtectiveEquipmentModelVersion
        {
            get { return this._protectiveEquipmentModelVersion; }
            set { this._protectiveEquipmentModelVersion = value; }
        }

        // Check to see if ProtectiveEquipmentModelVersion property is set
        internal bool IsSetProtectiveEquipmentModelVersion()
        {
            return this._protectiveEquipmentModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Summary information for the types of PPE specified in the <c>SummarizationAttributes</c>
        /// input parameter.
        /// </para>
        /// </summary>
        public ProtectiveEquipmentSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}