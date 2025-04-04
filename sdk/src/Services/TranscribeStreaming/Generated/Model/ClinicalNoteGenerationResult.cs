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
    /// The details for clinical note generation, including status, and output locations for
    /// clinical note and aggregated transcript if the analytics completed, or failure reason
    /// if the analytics failed.
    /// </summary>
    public partial class ClinicalNoteGenerationResult
    {
        private string _clinicalNoteOutputLocation;
        private string _failureReason;
        private ClinicalNoteGenerationStatus _status;
        private string _transcriptOutputLocation;

        /// <summary>
        /// Gets and sets the property ClinicalNoteOutputLocation. 
        /// <para>
        /// Holds the Amazon S3 URI for the output Clinical Note. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string ClinicalNoteOutputLocation
        {
            get { return this._clinicalNoteOutputLocation; }
            set { this._clinicalNoteOutputLocation = value; }
        }

        // Check to see if ClinicalNoteOutputLocation property is set
        internal bool IsSetClinicalNoteOutputLocation()
        {
            return this._clinicalNoteOutputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <c>ClinicalNoteGenerationResult</c> is <c>FAILED</c>, information about why it
        /// failed. 
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the clinical note generation.
        /// </para>
        ///  
        /// <para>
        /// Possible Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  After audio streaming finishes, and you send a <c>MedicalScribeSessionControlEvent</c>
        /// event (with END_OF_SESSION as the Type), the status is set to <c>IN_PROGRESS</c>.
        /// If the status is <c>COMPLETED</c>, the analytics completed successfully, and you can
        /// find the results at the locations specified in <c>ClinicalNoteOutputLocation</c> and
        /// <c>TranscriptOutputLocation</c>. If the status is <c>FAILED</c>, <c>FailureReason</c>
        /// provides details about the failure. 
        /// </para>
        /// </summary>
        public ClinicalNoteGenerationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TranscriptOutputLocation. 
        /// <para>
        /// Holds the Amazon S3 URI for the output Transcript. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string TranscriptOutputLocation
        {
            get { return this._transcriptOutputLocation; }
            set { this._transcriptOutputLocation = value; }
        }

        // Check to see if TranscriptOutputLocation property is set
        internal bool IsSetTranscriptOutputLocation()
        {
            return this._transcriptOutputLocation != null;
        }

    }
}