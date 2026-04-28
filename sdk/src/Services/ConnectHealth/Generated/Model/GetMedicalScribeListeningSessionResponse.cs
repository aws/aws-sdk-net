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
    /// This is the response object from the GetMedicalScribeListeningSession operation.
    /// </summary>
    public partial class GetMedicalScribeListeningSessionResponse : AmazonWebServiceResponse
    {
        private MedicalScribeListeningSessionDetails _medicalScribeListeningSessionDetails;

        /// <summary>
        /// Gets and sets the property MedicalScribeListeningSessionDetails. 
        /// <para>
        /// Details about the Medical Scribe listening session
        /// </para>
        /// </summary>
        public MedicalScribeListeningSessionDetails MedicalScribeListeningSessionDetails
        {
            get { return this._medicalScribeListeningSessionDetails; }
            set { this._medicalScribeListeningSessionDetails = value; }
        }

        // Check to see if MedicalScribeListeningSessionDetails property is set
        internal bool IsSetMedicalScribeListeningSessionDetails()
        {
            return this._medicalScribeListeningSessionDetails != null;
        }

    }
}