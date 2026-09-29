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
    /// The DICOM attributes returned as a part of a response. Each image set has these properties
    /// as part of a search result.
    /// </summary>
    public partial class DICOMTags
    {
        /// <summary>
        /// Gets and sets the property DICOMAccessionNumber. 
        /// <para>
        /// The accession number for the DICOM study.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string DICOMAccessionNumber { get; set; }

        /// <summary>
        /// Checks to see if the DICOMAccessionNumber property is set.
        /// </summary>
        internal bool IsSetDICOMAccessionNumber() => this.DICOMAccessionNumber != null;

        /// <summary>
        /// Gets and sets the property DICOMNumberOfStudyRelatedInstances. 
        /// <para>
        /// The total number of instances in the DICOM study.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public int? DICOMNumberOfStudyRelatedInstances { get; set; }

        /// <summary>
        /// Checks to see if the DICOMNumberOfStudyRelatedInstances property is set.
        /// </summary>
        internal bool IsSetDICOMNumberOfStudyRelatedInstances() => this.DICOMNumberOfStudyRelatedInstances.HasValue;

        /// <summary>
        /// Gets and sets the property DICOMNumberOfStudyRelatedSeries. 
        /// <para>
        /// The total number of series in the DICOM study.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public int? DICOMNumberOfStudyRelatedSeries { get; set; }

        /// <summary>
        /// Checks to see if the DICOMNumberOfStudyRelatedSeries property is set.
        /// </summary>
        internal bool IsSetDICOMNumberOfStudyRelatedSeries() => this.DICOMNumberOfStudyRelatedSeries.HasValue;

        /// <summary>
        /// Gets and sets the property DICOMPatientBirthDate. 
        /// <para>
        /// The patient birth date.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 36)]
        public string DICOMPatientBirthDate { get; set; }

        /// <summary>
        /// Checks to see if the DICOMPatientBirthDate property is set.
        /// </summary>
        internal bool IsSetDICOMPatientBirthDate() => this.DICOMPatientBirthDate != null;

        /// <summary>
        /// Gets and sets the property DICOMPatientId. 
        /// <para>
        /// The unique identifier for a patient in a DICOM Study.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string DICOMPatientId { get; set; }

        /// <summary>
        /// Checks to see if the DICOMPatientId property is set.
        /// </summary>
        internal bool IsSetDICOMPatientId() => this.DICOMPatientId != null;

        /// <summary>
        /// Gets and sets the property DICOMPatientName. 
        /// <para>
        /// The patient name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string DICOMPatientName { get; set; }

        /// <summary>
        /// Checks to see if the DICOMPatientName property is set.
        /// </summary>
        internal bool IsSetDICOMPatientName() => this.DICOMPatientName != null;

        /// <summary>
        /// Gets and sets the property DICOMPatientSex. 
        /// <para>
        /// The patient sex.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 16)]
        public string DICOMPatientSex { get; set; }

        /// <summary>
        /// Checks to see if the DICOMPatientSex property is set.
        /// </summary>
        internal bool IsSetDICOMPatientSex() => this.DICOMPatientSex != null;

        /// <summary>
        /// Gets and sets the property DICOMSeriesBodyPart. 
        /// <para>
        /// The DICOM provided identifier for the series Body Part Examined.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 128)]
        public string DICOMSeriesBodyPart { get; set; }

        /// <summary>
        /// Checks to see if the DICOMSeriesBodyPart property is set.
        /// </summary>
        internal bool IsSetDICOMSeriesBodyPart() => this.DICOMSeriesBodyPart != null;

        /// <summary>
        /// Gets and sets the property DICOMSeriesInstanceUID. 
        /// <para>
        /// The DICOM provided identifier for the Series Instance UID.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string DICOMSeriesInstanceUID { get; set; }

        /// <summary>
        /// Checks to see if the DICOMSeriesInstanceUID property is set.
        /// </summary>
        internal bool IsSetDICOMSeriesInstanceUID() => this.DICOMSeriesInstanceUID != null;

        /// <summary>
        /// Gets and sets the property DICOMSeriesModality. 
        /// <para>
        /// The DICOM provided identifier for the series Modality.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 32)]
        public string DICOMSeriesModality { get; set; }

        /// <summary>
        /// Checks to see if the DICOMSeriesModality property is set.
        /// </summary>
        internal bool IsSetDICOMSeriesModality() => this.DICOMSeriesModality != null;

        /// <summary>
        /// Gets and sets the property DICOMSeriesNumber. 
        /// <para>
        /// The DICOM provided identifier for the Series Number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = -2147483648, Max = 2147483647)]
        public int? DICOMSeriesNumber { get; set; }

        /// <summary>
        /// Checks to see if the DICOMSeriesNumber property is set.
        /// </summary>
        internal bool IsSetDICOMSeriesNumber() => this.DICOMSeriesNumber.HasValue;

        /// <summary>
        /// Gets and sets the property DICOMStudyDate. 
        /// <para>
        /// The study date.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 36)]
        public string DICOMStudyDate { get; set; }

        /// <summary>
        /// Checks to see if the DICOMStudyDate property is set.
        /// </summary>
        internal bool IsSetDICOMStudyDate() => this.DICOMStudyDate != null;

        /// <summary>
        /// Gets and sets the property DICOMStudyDescription. 
        /// <para>
        /// The DICOM provided Study Description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string DICOMStudyDescription { get; set; }

        /// <summary>
        /// Checks to see if the DICOMStudyDescription property is set.
        /// </summary>
        internal bool IsSetDICOMStudyDescription() => this.DICOMStudyDescription != null;

        /// <summary>
        /// Gets and sets the property DICOMStudyId. 
        /// <para>
        /// The DICOM provided identifier for the Study ID.
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
        /// The DICOM provided identifier for the Study Instance UID.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string DICOMStudyInstanceUID { get; set; }

        /// <summary>
        /// Checks to see if the DICOMStudyInstanceUID property is set.
        /// </summary>
        internal bool IsSetDICOMStudyInstanceUID() => this.DICOMStudyInstanceUID != null;

        /// <summary>
        /// Gets and sets the property DICOMStudyTime. 
        /// <para>
        /// The study time.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 56)]
        public string DICOMStudyTime { get; set; }

        /// <summary>
        /// Checks to see if the DICOMStudyTime property is set.
        /// </summary>
        internal bool IsSetDICOMStudyTime() => this.DICOMStudyTime != null;
    }
}
