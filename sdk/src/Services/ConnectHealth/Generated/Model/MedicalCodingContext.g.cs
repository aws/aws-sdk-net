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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Patient and encounter context for medical code generation. Providing this information
    /// can improve the accuracy of the medical codes. To provide it, you must also set enabled
    /// to true in medicalCodeGenerationSettings. All fields are optional. The service generates
    /// medical codes without any field that you leave out.
    /// </summary>
    public partial class MedicalCodingContext
    {
        /// <summary>
        /// Gets and sets the property AfterHours. 
        /// <para>
        /// Specifies whether the encounter took place outside regular business hours.
        /// </para>
        /// </summary>
        public bool? AfterHours { get; set; }

        /// <summary>
        /// Checks to see if the AfterHours property is set.
        /// </summary>
        internal bool IsSetAfterHours() => this.AfterHours.HasValue;

        /// <summary>
        /// Gets and sets the property DateOfBirth. 
        /// <para>
        /// The date of birth of the patient, in YYYY-MM-DD format. The date can't be after the
        /// current date in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Checks to see if the DateOfBirth property is set.
        /// </summary>
        internal bool IsSetDateOfBirth() => this.DateOfBirth != null;

        /// <summary>
        /// Gets and sets the property EncounterDate. 
        /// <para>
        /// The date of the encounter, in YYYY-MM-DD format. The date can't be more than one day
        /// after the current date in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string EncounterDate { get; set; }

        /// <summary>
        /// Checks to see if the EncounterDate property is set.
        /// </summary>
        internal bool IsSetEncounterDate() => this.EncounterDate != null;

        /// <summary>
        /// Gets and sets the property EncounterReason. 
        /// <para>
        /// The reason for the encounter. The reason can contain letters, numbers, spaces, periods,
        /// commas, and hyphens, and can't contain only spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 256)]
        public string EncounterReason { get; set; }

        /// <summary>
        /// Checks to see if the EncounterReason property is set.
        /// </summary>
        internal bool IsSetEncounterReason() => this.EncounterReason != null;

        /// <summary>
        /// Gets and sets the property EncounterType. 
        /// <para>
        /// The type of the encounter, either in person or telehealth.
        /// </para>
        /// </summary>
        public EncounterType EncounterType { get; set; }

        /// <summary>
        /// Checks to see if the EncounterType property is set.
        /// </summary>
        internal bool IsSetEncounterType() => this.EncounterType != null;

        /// <summary>
        /// Gets and sets the property Sex. 
        /// <para>
        /// The sex of the patient.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Sex Sex { get; set; }

        /// <summary>
        /// Checks to see if the Sex property is set.
        /// </summary>
        internal bool IsSetSex() => this.Sex != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the patient, either new or established.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public PatientStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
