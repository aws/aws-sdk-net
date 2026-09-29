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
    /// Details for a patient
    /// </summary>
    public partial class PatientInsightsPatientContext
    {
        /// <summary>
        /// Gets and sets the property DateOfBirth. 
        /// <para>
        /// Date of birth of the patient.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Checks to see if the DateOfBirth property is set.
        /// </summary>
        internal bool IsSetDateOfBirth() => this.DateOfBirth != null;

        /// <summary>
        /// Gets and sets the property PatientId. 
        /// <para>
        /// Unique identifier of the patient
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string PatientId { get; set; }

        /// <summary>
        /// Checks to see if the PatientId property is set.
        /// </summary>
        internal bool IsSetPatientId() => this.PatientId != null;

        /// <summary>
        /// Gets and sets the property Pronouns. 
        /// <para>
        /// Pronouns preferred by the patient.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Pronouns Pronouns { get; set; }

        /// <summary>
        /// Checks to see if the Pronouns property is set.
        /// </summary>
        internal bool IsSetPronouns() => this.Pronouns != null;
    }
}
