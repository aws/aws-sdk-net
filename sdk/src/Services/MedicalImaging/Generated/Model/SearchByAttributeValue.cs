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
    /// The search input attribute value.
    /// </summary>
    public partial class SearchByAttributeValue
    {
        private DateTime? _createdAt;
        private string _dicomAccessionNumber;
        private string _dicomPatientId;
        private string _dicomSeriesInstanceUID;
        private DICOMStudyDateAndTime _dicomStudyDateAndTime;
        private string _dicomStudyId;
        private string _dicomStudyInstanceUID;
        private bool? _isPrimary;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The created at time of the image set provided for search.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DICOMAccessionNumber. 
        /// <para>
        /// The DICOM accession number for search.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string DICOMAccessionNumber
        {
            get { return this._dicomAccessionNumber; }
            set { this._dicomAccessionNumber = value; }
        }

        // Check to see if DICOMAccessionNumber property is set
        internal bool IsSetDICOMAccessionNumber()
        {
            return this._dicomAccessionNumber != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMPatientId. 
        /// <para>
        /// The patient ID input for search.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string DICOMPatientId
        {
            get { return this._dicomPatientId; }
            set { this._dicomPatientId = value; }
        }

        // Check to see if DICOMPatientId property is set
        internal bool IsSetDICOMPatientId()
        {
            return this._dicomPatientId != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMSeriesInstanceUID. 
        /// <para>
        /// The Series Instance UID input for search.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string DICOMSeriesInstanceUID
        {
            get { return this._dicomSeriesInstanceUID; }
            set { this._dicomSeriesInstanceUID = value; }
        }

        // Check to see if DICOMSeriesInstanceUID property is set
        internal bool IsSetDICOMSeriesInstanceUID()
        {
            return this._dicomSeriesInstanceUID != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMStudyDateAndTime. 
        /// <para>
        /// The aggregated structure containing DICOM study date and study time for search.
        /// </para>
        /// </summary>
        public DICOMStudyDateAndTime DICOMStudyDateAndTime
        {
            get { return this._dicomStudyDateAndTime; }
            set { this._dicomStudyDateAndTime = value; }
        }

        // Check to see if DICOMStudyDateAndTime property is set
        internal bool IsSetDICOMStudyDateAndTime()
        {
            return this._dicomStudyDateAndTime != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMStudyId. 
        /// <para>
        /// The DICOM study ID for search.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string DICOMStudyId
        {
            get { return this._dicomStudyId; }
            set { this._dicomStudyId = value; }
        }

        // Check to see if DICOMStudyId property is set
        internal bool IsSetDICOMStudyId()
        {
            return this._dicomStudyId != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMStudyInstanceUID. 
        /// <para>
        /// The DICOM study instance UID for search.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string DICOMStudyInstanceUID
        {
            get { return this._dicomStudyInstanceUID; }
            set { this._dicomStudyInstanceUID = value; }
        }

        // Check to see if DICOMStudyInstanceUID property is set
        internal bool IsSetDICOMStudyInstanceUID()
        {
            return this._dicomStudyInstanceUID != null;
        }

        /// <summary>
        /// Gets and sets the property IsPrimary. 
        /// <para>
        /// The primary image set flag provided for search.
        /// </para>
        /// </summary>
        public bool? IsPrimary
        {
            get { return this._isPrimary; }
            set { this._isPrimary = value; }
        }

        // Check to see if IsPrimary property is set
        internal bool IsSetIsPrimary()
        {
            return this._isPrimary.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp input for search.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}