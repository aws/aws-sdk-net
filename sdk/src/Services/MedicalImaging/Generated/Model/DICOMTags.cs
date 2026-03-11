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
    /// The DICOM attributes returned as a part of a response. Each image set has these properties
    /// as part of a search result.
    /// </summary>
    public partial class DICOMTags
    {
        private string _dicomAccessionNumber;
        private int? _dicomNumberOfStudyRelatedInstances;
        private int? _dicomNumberOfStudyRelatedSeries;
        private string _dicomPatientBirthDate;
        private string _dicomPatientId;
        private string _dicomPatientName;
        private string _dicomPatientSex;
        private string _dicomSeriesBodyPart;
        private string _dicomSeriesInstanceUID;
        private string _dicomSeriesModality;
        private int? _dicomSeriesNumber;
        private string _dicomStudyDate;
        private string _dicomStudyDescription;
        private string _dicomStudyId;
        private string _dicomStudyInstanceUID;
        private string _dicomStudyTime;

        /// <summary>
        /// Gets and sets the property DICOMAccessionNumber. 
        /// <para>
        /// The accession number for the DICOM study.
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
        /// Gets and sets the property DICOMNumberOfStudyRelatedInstances. 
        /// <para>
        /// The total number of instances in the DICOM study.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public int? DICOMNumberOfStudyRelatedInstances
        {
            get { return this._dicomNumberOfStudyRelatedInstances; }
            set { this._dicomNumberOfStudyRelatedInstances = value; }
        }

        // Check to see if DICOMNumberOfStudyRelatedInstances property is set
        internal bool IsSetDICOMNumberOfStudyRelatedInstances()
        {
            return this._dicomNumberOfStudyRelatedInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DICOMNumberOfStudyRelatedSeries. 
        /// <para>
        /// The total number of series in the DICOM study.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public int? DICOMNumberOfStudyRelatedSeries
        {
            get { return this._dicomNumberOfStudyRelatedSeries; }
            set { this._dicomNumberOfStudyRelatedSeries = value; }
        }

        // Check to see if DICOMNumberOfStudyRelatedSeries property is set
        internal bool IsSetDICOMNumberOfStudyRelatedSeries()
        {
            return this._dicomNumberOfStudyRelatedSeries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DICOMPatientBirthDate. 
        /// <para>
        /// The patient birth date.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=18)]
        public string DICOMPatientBirthDate
        {
            get { return this._dicomPatientBirthDate; }
            set { this._dicomPatientBirthDate = value; }
        }

        // Check to see if DICOMPatientBirthDate property is set
        internal bool IsSetDICOMPatientBirthDate()
        {
            return this._dicomPatientBirthDate != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMPatientId. 
        /// <para>
        /// The unique identifier for a patient in a DICOM Study.
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
        /// Gets and sets the property DICOMPatientName. 
        /// <para>
        /// The patient name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string DICOMPatientName
        {
            get { return this._dicomPatientName; }
            set { this._dicomPatientName = value; }
        }

        // Check to see if DICOMPatientName property is set
        internal bool IsSetDICOMPatientName()
        {
            return this._dicomPatientName != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMPatientSex. 
        /// <para>
        /// The patient sex.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=16)]
        public string DICOMPatientSex
        {
            get { return this._dicomPatientSex; }
            set { this._dicomPatientSex = value; }
        }

        // Check to see if DICOMPatientSex property is set
        internal bool IsSetDICOMPatientSex()
        {
            return this._dicomPatientSex != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMSeriesBodyPart. 
        /// <para>
        /// The DICOM provided identifier for the series Body Part Examined.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=64)]
        public string DICOMSeriesBodyPart
        {
            get { return this._dicomSeriesBodyPart; }
            set { this._dicomSeriesBodyPart = value; }
        }

        // Check to see if DICOMSeriesBodyPart property is set
        internal bool IsSetDICOMSeriesBodyPart()
        {
            return this._dicomSeriesBodyPart != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMSeriesInstanceUID. 
        /// <para>
        /// The DICOM provided identifier for the Series Instance UID.
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
        /// Gets and sets the property DICOMSeriesModality. 
        /// <para>
        /// The DICOM provided identifier for the series Modality.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=16)]
        public string DICOMSeriesModality
        {
            get { return this._dicomSeriesModality; }
            set { this._dicomSeriesModality = value; }
        }

        // Check to see if DICOMSeriesModality property is set
        internal bool IsSetDICOMSeriesModality()
        {
            return this._dicomSeriesModality != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMSeriesNumber. 
        /// <para>
        /// The DICOM provided identifier for the Series Number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=-2147483648, Max=2147483647)]
        public int? DICOMSeriesNumber
        {
            get { return this._dicomSeriesNumber; }
            set { this._dicomSeriesNumber = value; }
        }

        // Check to see if DICOMSeriesNumber property is set
        internal bool IsSetDICOMSeriesNumber()
        {
            return this._dicomSeriesNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DICOMStudyDate. 
        /// <para>
        /// The study date.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=18)]
        public string DICOMStudyDate
        {
            get { return this._dicomStudyDate; }
            set { this._dicomStudyDate = value; }
        }

        // Check to see if DICOMStudyDate property is set
        internal bool IsSetDICOMStudyDate()
        {
            return this._dicomStudyDate != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMStudyDescription. 
        /// <para>
        /// The DICOM provided Study Description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string DICOMStudyDescription
        {
            get { return this._dicomStudyDescription; }
            set { this._dicomStudyDescription = value; }
        }

        // Check to see if DICOMStudyDescription property is set
        internal bool IsSetDICOMStudyDescription()
        {
            return this._dicomStudyDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMStudyId. 
        /// <para>
        /// The DICOM provided identifier for the Study ID.
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
        /// The DICOM provided identifier for the Study Instance UID.
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
        /// Gets and sets the property DICOMStudyTime. 
        /// <para>
        /// The study time.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=28)]
        public string DICOMStudyTime
        {
            get { return this._dicomStudyTime; }
            set { this._dicomStudyTime = value; }
        }

        // Check to see if DICOMStudyTime property is set
        internal bool IsSetDICOMStudyTime()
        {
            return this._dicomStudyTime != null;
        }

    }
}