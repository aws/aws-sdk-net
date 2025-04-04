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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// This is the response object from the GetMedicalScribeStream operation.
    /// </summary>
    public partial class GetMedicalScribeStreamResponse : AmazonWebServiceResponse
    {
        private MedicalScribeStreamDetails _medicalScribeStreamDetails;

        /// <summary>
        /// Gets and sets the property MedicalScribeStreamDetails. 
        /// <para>
        /// Provides details about a HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribeStreamDetails MedicalScribeStreamDetails
        {
            get { return this._medicalScribeStreamDetails; }
            set { this._medicalScribeStreamDetails = value; }
        }

        // Check to see if MedicalScribeStreamDetails property is set
        internal bool IsSetMedicalScribeStreamDetails()
        {
            return this._medicalScribeStreamDetails != null;
        }

    }
}