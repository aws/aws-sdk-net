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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
    /// Container for the parameters to the ListFHIRExportJobs operation.
    /// Lists all FHIR export jobs associated with an account and their statuses.
    /// </summary>
    public partial class ListFHIRExportJobsRequest : AmazonHealthLakeRequest
    {
        private string _datastoreId;
        private string _jobName;
        private JobStatus _jobStatus;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _submittedAfter;
        private DateTime? _submittedBefore;

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// Limits the response to the export job with the specified data store ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// Limits the response to the export job with the specified job name. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// Limits the response to export jobs with the specified job status. 
        /// </para>
        /// </summary>
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Limits the number of results returned for a ListFHIRExportJobs to a maximum quantity
        /// specified by the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token used to identify the next page of results to return.
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
        /// Gets and sets the property SubmittedAfter. 
        /// <para>
        /// Limits the response to FHIR export jobs submitted after a user-specified date.
        /// </para>
        /// </summary>
        public DateTime? SubmittedAfter
        {
            get { return this._submittedAfter; }
            set { this._submittedAfter = value; }
        }

        // Check to see if SubmittedAfter property is set
        internal bool IsSetSubmittedAfter()
        {
            return this._submittedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubmittedBefore. 
        /// <para>
        /// Limits the response to FHIR export jobs submitted before a user- specified date.
        /// </para>
        /// </summary>
        public DateTime? SubmittedBefore
        {
            get { return this._submittedBefore; }
            set { this._submittedBefore = value; }
        }

        // Check to see if SubmittedBefore property is set
        internal bool IsSetSubmittedBefore()
        {
            return this._submittedBefore.HasValue; 
        }

    }
}