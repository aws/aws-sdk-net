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
    /// This is the response object from the ListMedicalScribeJobs operation.
    /// </summary>
    public partial class ListMedicalScribeJobsResponse : AmazonWebServiceResponse
    {
        private List<MedicalScribeJobSummary> _medicalScribeJobSummaries = AWSConfigs.InitializeCollections ? new List<MedicalScribeJobSummary>() : null;
        private string _nextToken;
        private MedicalScribeJobStatus _status;

        /// <summary>
        /// Gets and sets the property MedicalScribeJobSummaries. 
        /// <para>
        /// Provides a summary of information about each result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MedicalScribeJobSummary> MedicalScribeJobSummaries
        {
            get { return this._medicalScribeJobSummaries; }
            set { this._medicalScribeJobSummaries = value; }
        }

        // Check to see if MedicalScribeJobSummaries property is set
        internal bool IsSetMedicalScribeJobSummaries()
        {
            return this._medicalScribeJobSummaries != null && (this._medicalScribeJobSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <c>NextToken</c> is present in your response, it indicates that not all results
        /// are displayed. To view the next set of results, copy the string associated with the
        /// <c>NextToken</c> parameter in your results output, then run your request again including
        /// <c>NextToken</c> with the value of the copied string. Repeat as needed to view all
        /// your results.
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
        /// Lists all Medical Scribe jobs that have the status specified in your request. Jobs
        /// are ordered by creation date, with the newest job first.
        /// </para>
        /// </summary>
        public MedicalScribeJobStatus Status
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