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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMedicalScribeJob operation.
    /// Deletes a Medical Scribe job. To use this operation, specify the name of the job you
    /// want to delete using <c>MedicalScribeJobName</c>. Job names are case sensitive.
    /// </summary>
    public partial class DeleteMedicalScribeJobRequest : AmazonTranscribeServiceRequest
    {
        private string _medicalScribeJobName;

        /// <summary>
        /// Gets and sets the property MedicalScribeJobName. 
        /// <para>
        /// The name of the Medical Scribe job you want to delete. Job names are case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string MedicalScribeJobName
        {
            get { return this._medicalScribeJobName; }
            set { this._medicalScribeJobName = value; }
        }

        // Check to see if MedicalScribeJobName property is set
        internal bool IsSetMedicalScribeJobName()
        {
            return this._medicalScribeJobName != null;
        }

    }
}