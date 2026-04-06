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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
    /// Details for a patient
    /// </summary>
    public partial class PatientInsightsPatientContext
    {
        private string _dateOfBirth;
        private string _patientId;
        private Pronouns _pronouns;

        /// <summary>
        /// Gets and sets the property DateOfBirth. 
        /// <para>
        /// Date of birth of the patient.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string DateOfBirth
        {
            get { return this._dateOfBirth; }
            set { this._dateOfBirth = value; }
        }

        // Check to see if DateOfBirth property is set
        internal bool IsSetDateOfBirth()
        {
            return this._dateOfBirth != null;
        }

        /// <summary>
        /// Gets and sets the property PatientId. 
        /// <para>
        /// Unique identifier of the patient
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string PatientId
        {
            get { return this._patientId; }
            set { this._patientId = value; }
        }

        // Check to see if PatientId property is set
        internal bool IsSetPatientId()
        {
            return this._patientId != null;
        }

        /// <summary>
        /// Gets and sets the property Pronouns. 
        /// <para>
        /// Pronouns preferred by the patient.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Pronouns Pronouns
        {
            get { return this._pronouns; }
            set { this._pronouns = value; }
        }

        // Check to see if Pronouns property is set
        internal bool IsSetPronouns()
        {
            return this._pronouns != null;
        }

    }
}