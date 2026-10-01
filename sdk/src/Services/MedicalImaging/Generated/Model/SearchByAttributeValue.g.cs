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

namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// The search input attribute value.
    /// </summary>
    public partial class SearchByAttributeValue
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The created at time of the image set provided for search.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DICOMAccessionNumber. 
        /// <para>
        /// The DICOM accession number for search.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string DICOMAccessionNumber { get; set; }

        /// <summary>
        /// Checks to see if the DICOMAccessionNumber property is set.
        /// </summary>
        internal bool IsSetDICOMAccessionNumber() => this.DICOMAccessionNumber != null;

        /// <summary>
        /// Gets and sets the property DICOMPatientId. 
        /// <para>
        /// The patient ID input for search.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string DICOMPatientId { get; set; }

        /// <summary>
        /// Checks to see if the DICOMPatientId property is set.
        /// </summary>
        internal bool IsSetDICOMPatientId() => this.DICOMPatientId != null;

        /// <summary>
        /// Gets and sets the property DICOMSeriesInstanceUID. 
        /// <para>
        /// The Series Instance UID input for search.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string DICOMSeriesInstanceUID { get; set; }

        /// <summary>
        /// Checks to see if the DICOMSeriesInstanceUID property is set.
        /// </summary>
        internal bool IsSetDICOMSeriesInstanceUID() => this.DICOMSeriesInstanceUID != null;

        /// <summary>
        /// Gets and sets the property DICOMStudyDateAndTime. 
        /// <para>
        /// The aggregated structure containing DICOM study date and study time for search.
        /// </para>
        /// </summary>
        public DICOMStudyDateAndTime DICOMStudyDateAndTime { get; set; }

        /// <summary>
        /// Checks to see if the DICOMStudyDateAndTime property is set.
        /// </summary>
        internal bool IsSetDICOMStudyDateAndTime() => this.DICOMStudyDateAndTime != null;

        /// <summary>
        /// Gets and sets the property DICOMStudyId. 
        /// <para>
        /// The DICOM study ID for search.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string DICOMStudyId { get; set; }

        /// <summary>
        /// Checks to see if the DICOMStudyId property is set.
        /// </summary>
        internal bool IsSetDICOMStudyId() => this.DICOMStudyId != null;

        /// <summary>
        /// Gets and sets the property DICOMStudyInstanceUID. 
        /// <para>
        /// The DICOM study instance UID for search.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string DICOMStudyInstanceUID { get; set; }

        /// <summary>
        /// Checks to see if the DICOMStudyInstanceUID property is set.
        /// </summary>
        internal bool IsSetDICOMStudyInstanceUID() => this.DICOMStudyInstanceUID != null;

        /// <summary>
        /// Gets and sets the property IsPrimary. 
        /// <para>
        /// The primary image set flag provided for search.
        /// </para>
        /// </summary>
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Checks to see if the IsPrimary property is set.
        /// </summary>
        internal bool IsSetIsPrimary() => this.IsPrimary.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp input for search.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
