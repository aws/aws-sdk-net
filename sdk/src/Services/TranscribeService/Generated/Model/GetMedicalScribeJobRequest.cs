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
    /// Container for the parameters to the GetMedicalScribeJob operation.
    /// Provides information about the specified Medical Scribe job.
    /// 
    ///  
    /// <para>
    /// To view the status of the specified medical transcription job, check the <c>MedicalScribeJobStatus</c>
    /// field. If the status is <c>COMPLETED</c>, the job is finished. You can find the results
    /// at the location specified in <c>MedicalScribeOutput</c>. If the status is <c>FAILED</c>,
    /// <c>FailureReason</c> provides details on why your Medical Scribe job failed.
    /// </para>
    ///  
    /// <para>
    /// To get a list of your Medical Scribe jobs, use the operation.
    /// </para>
    /// </summary>
    public partial class GetMedicalScribeJobRequest : AmazonTranscribeServiceRequest
    {
        private string _medicalScribeJobName;

        /// <summary>
        /// Gets and sets the property MedicalScribeJobName. 
        /// <para>
        /// The name of the Medical Scribe job you want information about. Job names are case
        /// sensitive.
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