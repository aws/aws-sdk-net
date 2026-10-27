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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the ListMedicalScribeJobs operation. Provides a list
    /// of Medical Scribe jobs that match the specified criteria. If no criteria are specified,
    /// all Medical Scribe jobs are returned. <para> To get detailed information about a specific
    /// Medical Scribe job, use the operation. </para>
    /// </summary>
    public partial class ListMedicalScribeJobsRequest : AmazonTranscribeServiceRequest
    {
        /// <summary>
        /// Gets and sets the property JobNameContains. 
        /// <para>
        /// Returns only the Medical Scribe jobs that contain the specified string. The search
        /// is not case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string JobNameContains { get; set; }

        /// <summary>
        /// Checks to see if the JobNameContains property is set.
        /// </summary>
        internal bool IsSetJobNameContains() => this.JobNameContains != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of Medical Scribe jobs to return in each page of results. If there
        /// are fewer results than the value that you specify, only the actual results are returned.
        /// If you do not specify a value, a default of 5 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If your <c>ListMedicalScribeJobs</c> request returns more results than can be displayed,
        /// <c>NextToken</c> is displayed in the response with an associated string. To get the
        /// next page of results, copy this string and repeat your request, including <c>NextToken</c>
        /// with the value of the copied string. Repeat as needed to view all your results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Returns only Medical Scribe jobs with the specified status. Jobs are ordered by creation
        /// date, with the newest job first. If you do not include <c>Status</c>, all Medical
        /// Scribe jobs are returned.
        /// </para>
        /// </summary>
        public MedicalScribeJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
