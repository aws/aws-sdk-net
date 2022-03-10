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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the GetMedicalTranscriptionJob operation.
    /// Retrieves information about a medical transcription job.
    /// 
    ///  
    /// <para>
    /// To view the job's status, refer to the <code>TranscriptionJobStatus</code> field.
    /// If the status is <code>COMPLETED</code>, the job is finished. You can then find your
    /// transcript at the URI specified in the <code>TranscriptFileUri</code> field.
    /// </para>
    /// </summary>
    public partial class GetMedicalTranscriptionJobRequest : AmazonTranscribeServiceRequest
    {
        private string _medicalTranscriptionJobName;

        /// <summary>
        /// Gets and sets the property MedicalTranscriptionJobName. 
        /// <para>
        /// The name of the medical transcription job you want information about. This value is
        /// case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string MedicalTranscriptionJobName
        {
            get { return this._medicalTranscriptionJobName; }
            set { this._medicalTranscriptionJobName = value; }
        }

        // Check to see if MedicalTranscriptionJobName property is set
        internal bool IsSetMedicalTranscriptionJobName()
        {
            return this._medicalTranscriptionJobName != null;
        }

    }
}