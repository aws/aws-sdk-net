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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// The configuration parameters that are specific to DICOM JSON metadata import operations.
    /// </summary>
    public partial class DicomJsonMetadataImportConfiguration
    {
        private List<DicomMetadataMapping> _dicomMetadataMappings = AWSConfigs.InitializeCollections ? new List<DicomMetadataMapping>() : null;

        /// <summary>
        /// Gets and sets the property DicomMetadataMappings. 
        /// <para>
        /// Maps DCM files to their metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public List<DicomMetadataMapping> DicomMetadataMappings
        {
            get { return this._dicomMetadataMappings; }
            set { this._dicomMetadataMappings = value; }
        }

        // Check to see if DicomMetadataMappings property is set
        internal bool IsSetDicomMetadataMappings()
        {
            return this._dicomMetadataMappings != null && (this._dicomMetadataMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}