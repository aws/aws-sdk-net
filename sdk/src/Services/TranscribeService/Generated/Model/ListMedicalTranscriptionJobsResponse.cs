/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// This is the response object from the ListMedicalTranscriptionJobs operation.
    /// </summary>
    public partial class ListMedicalTranscriptionJobsResponse : AmazonWebServiceResponse
    {
        private List<MedicalTranscriptionJobSummary> _medicalTranscriptionJobSummaries = new List<MedicalTranscriptionJobSummary>();
        private string _nextToken;
        private TranscriptionJobStatus _status;

        /// <summary>
        /// Gets and sets the property MedicalTranscriptionJobSummaries. 
        /// <para>
        /// A list of objects containing summary information for a transcription job.
        /// </para>
        /// </summary>
        public List<MedicalTranscriptionJobSummary> MedicalTranscriptionJobSummaries
        {
            get { return this._medicalTranscriptionJobSummaries; }
            set { this._medicalTranscriptionJobSummaries = value; }
        }

        // Check to see if MedicalTranscriptionJobSummaries property is set
        internal bool IsSetMedicalTranscriptionJobSummaries()
        {
            return this._medicalTranscriptionJobSummaries != null && this._medicalTranscriptionJobSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>ListMedicalTranscriptionJobs</code> operation returns a page of jobs at
        /// a time. The maximum size of the page is set by the <code>MaxResults</code> parameter.
        /// If the number of jobs exceeds what can fit on a page, Amazon Transcribe Medical returns
        /// the <code>NextPage</code> token. Include the token in the next request to the <code>ListMedicalTranscriptionJobs</code>
        /// operation to return in the next page of jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The requested status of the medical transcription jobs returned.
        /// </para>
        /// </summary>
        public TranscriptionJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}