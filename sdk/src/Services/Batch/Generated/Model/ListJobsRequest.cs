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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobs operation.
    /// Returns a list of Batch jobs.
    /// 
    ///  
    /// <para>
    /// You must specify only one of the following items:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A job queue ID to return a list of jobs in that job queue
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A multi-node parallel job ID to return a list of nodes for that job
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An array job ID to return a list of the children for that job
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can filter the results by job status with the <c>jobStatus</c> parameter. If you
    /// don't specify a status, only <c>RUNNING</c> jobs are returned.
    /// </para>
    /// </summary>
    public partial class ListJobsRequest : AmazonBatchRequest
    {
        private string _arrayJobId;
        private List<KeyValuesPair> _filters = AWSConfigs.InitializeCollections ? new List<KeyValuesPair>() : null;
        private string _jobQueue;
        private JobStatus _jobStatus;
        private int? _maxResults;
        private string _multiNodeJobId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ArrayJobId. 
        /// <para>
        /// The job ID for an array job. Specifying an array job ID with this parameter lists
        /// all child jobs from within the specified array.
        /// </para>
        /// </summary>
        public string ArrayJobId
        {
            get { return this._arrayJobId; }
            set { this._arrayJobId = value; }
        }

        // Check to see if ArrayJobId property is set
        internal bool IsSetArrayJobId()
        {
            return this._arrayJobId != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filter to apply to the query. Only one filter can be used at a time. When the
        /// filter is used, <c>jobStatus</c> is ignored. The filter doesn't apply to child jobs
        /// in an array or multi-node parallel (MNP) jobs. The results are sorted by the <c>createdAt</c>
        /// field, with the most recent jobs being first.
        /// </para>
        ///  <dl> <dt>JOB_NAME</dt> <dd> 
        /// <para>
        /// The value of the filter is a case-insensitive match for the job name. If the value
        /// ends with an asterisk (*), the filter matches any job name that begins with the string
        /// before the '*'. This corresponds to the <c>jobName</c> value. For example, <c>test1</c>
        /// matches both <c>Test1</c> and <c>test1</c>, and <c>test1*</c> matches both <c>test1</c>
        /// and <c>Test10</c>. When the <c>JOB_NAME</c> filter is used, the results are grouped
        /// by the job name and version.
        /// </para>
        ///  </dd> <dt>JOB_DEFINITION</dt> <dd> 
        /// <para>
        /// The value for the filter is the name or Amazon Resource Name (ARN) of the job definition.
        /// This corresponds to the <c>jobDefinition</c> value. The value is case sensitive. When
        /// the value for the filter is the job definition name, the results include all the jobs
        /// that used any revision of that job definition name. If the value ends with an asterisk
        /// (*), the filter matches any job definition name that begins with the string before
        /// the '*'. For example, <c>jd1</c> matches only <c>jd1</c>, and <c>jd1*</c> matches
        /// both <c>jd1</c> and <c>jd1A</c>. The version of the job definition that's used doesn't
        /// affect the sort order. When the <c>JOB_DEFINITION</c> filter is used and the ARN is
        /// used (which is in the form <c>arn:${Partition}:batch:${Region}:${Account}:job-definition/${JobDefinitionName}:${Revision}</c>),
        /// the results include jobs that used the specified revision of the job definition. Asterisk
        /// (*) isn't supported when the ARN is used.
        /// </para>
        ///  </dd> <dt>BEFORE_CREATED_AT</dt> <dd> 
        /// <para>
        /// The value for the filter is the time that's before the job was created. This corresponds
        /// to the <c>createdAt</c> value. The value is a string representation of the number
        /// of milliseconds since 00:00:00 UTC (midnight) on January 1, 1970.
        /// </para>
        ///  </dd> <dt>AFTER_CREATED_AT</dt> <dd> 
        /// <para>
        /// The value for the filter is the time that's after the job was created. This corresponds
        /// to the <c>createdAt</c> value. The value is a string representation of the number
        /// of milliseconds since 00:00:00 UTC (midnight) on January 1, 1970.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuesPair> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The name or full Amazon Resource Name (ARN) of the job queue used to list jobs.
        /// </para>
        /// </summary>
        public string JobQueue
        {
            get { return this._jobQueue; }
            set { this._jobQueue = value; }
        }

        // Check to see if JobQueue property is set
        internal bool IsSetJobQueue()
        {
            return this._jobQueue != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The job status used to filter jobs in the specified queue. If the <c>filters</c> parameter
        /// is specified, the <c>jobStatus</c> parameter is ignored and jobs with any status are
        /// returned. If you don't specify a status, only <c>RUNNING</c> jobs are returned.
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
        /// The maximum number of results returned by <c>ListJobs</c> in a paginated output. When
        /// this parameter is used, <c>ListJobs</c> returns up to <c>maxResults</c> results in
        /// a single page and a <c>nextToken</c> response element, if applicable. The remaining
        /// results of the initial request can be seen by sending another <c>ListJobs</c> request
        /// with the returned <c>nextToken</c> value.
        /// </para>
        ///  
        /// <para>
        /// The following outlines key parameters and limitations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The minimum value is 1. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <c>--job-status</c> is used, Batch returns up to 1000 values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <c>--filters</c> is used, Batch returns up to 100 values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If neither parameter is used, then <c>ListJobs</c> returns up to 1000 results (jobs
        /// that are in the <c>RUNNING</c> status) and a <c>nextToken</c> value, if applicable.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Gets and sets the property MultiNodeJobId. 
        /// <para>
        /// The job ID for a multi-node parallel job. Specifying a multi-node parallel job ID
        /// with this parameter lists all nodes that are associated with the specified job.
        /// </para>
        /// </summary>
        public string MultiNodeJobId
        {
            get { return this._multiNodeJobId; }
            set { this._multiNodeJobId = value; }
        }

        // Check to see if MultiNodeJobId property is set
        internal bool IsSetMultiNodeJobId()
        {
            return this._multiNodeJobId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a previous paginated <c>ListJobs</c> request
        /// where <c>maxResults</c> was used and the results exceeded the value of that parameter.
        /// Pagination continues from the end of the previous results that returned the <c>nextToken</c>
        /// value. This value is <c>null</c> when there are no more results to return.
        /// </para>
        ///  <note> 
        /// <para>
        /// Treat this token as an opaque identifier that's only used to retrieve the next items
        /// in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
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

    }
}