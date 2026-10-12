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
    /// Container for the parameters to the ListFHIRExportJobs operation. Lists all FHIR export
    /// jobs associated with an account and their statuses.
    /// </summary>
    public partial class ListFHIRExportJobsRequest : AmazonHealthLakeRequest
    {
        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// Limits the response to the export job with the specified data store ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string DatastoreId { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreId property is set.
        /// </summary>
        internal bool IsSetDatastoreId() => this.DatastoreId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// Limits the response to the export job with the specified job name. 
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
        /// Limits the response to export jobs with the specified job status. 
        /// </para>
        /// </summary>
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Limits the number of results returned for a ListFHIRExportJobs to a maximum quantity
        /// specified by the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token used to identify the next page of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SubmittedAfter. 
        /// <para>
        /// Limits the response to FHIR export jobs submitted after a user-specified date.
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
        /// Limits the response to FHIR export jobs submitted before a user- specified date.
        /// </para>
        /// </summary>
        public DateTime? SubmittedBefore { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedBefore property is set.
        /// </summary>
        internal bool IsSetSubmittedBefore() => this.SubmittedBefore.HasValue;
    }
}
