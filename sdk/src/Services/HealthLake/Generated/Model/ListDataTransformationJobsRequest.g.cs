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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Container for the parameters to the ListDataTransformationJobs operation. Lists data
    /// transformation jobs for your Amazon Web Services account. Results can be filtered
    /// by status, job name, and submit time window. Results are paginated. Use the <c>NextToken</c>
    /// parameter to retrieve additional results.
    /// </summary>
    public partial class ListDataTransformationJobsRequest : AmazonHealthLakeRequest
    {
        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// Filters the results to include only jobs with the specified name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// Filters the results to include only jobs with the specified status.
        /// </para>
        /// </summary>
        public TransformationJobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of jobs to return per page. If you don't specify a value, the service
        /// returns up to 100 results.
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
        /// The pagination token from a previous response. Pass this value to retrieve the next
        /// page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SubmittedAfter. 
        /// <para>
        /// Filters the results to include only jobs submitted at or after this timestamp.
        /// </para>
        /// </summary>
        public DateTime? SubmittedAfter { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedAfter property is set.
        /// </summary>
        internal bool IsSetSubmittedAfter() => this.SubmittedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property SubmittedBefore. 
        /// <para>
        /// Filters the results to include only jobs submitted at or before this timestamp.
        /// </para>
        /// </summary>
        public DateTime? SubmittedBefore { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedBefore property is set.
        /// </summary>
        internal bool IsSetSubmittedBefore() => this.SubmittedBefore.HasValue;
    }
}
