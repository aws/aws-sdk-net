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
    /// You can filter the results by job status with the <code>jobStatus</code> parameter.
    /// If you don't specify a status, only <code>RUNNING</code> jobs are returned.
    /// </para>
    /// </summary>
    public partial class ListJobsRequest : AmazonBatchRequest
    {
        private string _arrayJobId;
        private List<KeyValuesPair> _filters = new List<KeyValuesPair>();
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
        /// filter is used, <code>jobStatus</code> is ignored. The filter doesn't apply to child
        /// jobs in an array or multi-node parallel (MNP) jobs. The results are sorted by the
        /// <code>createdAt</code> field, with the most recent jobs being first.
        /// </para>
        ///  <dl> <dt>JOB_NAME</dt> <dd> 
        /// <para>
        /// The value of the filter is a case-insensitive match for the job name. If the value
        /// ends with an asterisk (*), the filter matches any job name that begins with the string
        /// before the '*'. This corresponds to the <code>jobName</code> value. For example, <code>test1</code>
        /// matches both <code>Test1</code> and <code>test1</code>, and <code>test1*</code> matches
        /// both <code>test1</code> and <code>Test10</code>. When the <code>JOB_NAME</code> filter
        /// is used, the results are grouped by the job name and version.
        /// </para>
        ///  </dd> <dt>JOB_DEFINITION</dt> <dd> 
        /// <para>
        /// The value for the filter is the name or Amazon Resource Name (ARN) of the job definition.
        /// This corresponds to the <code>jobDefinition</code> value. The value is case sensitive.
        /// When the value for the filter is the job definition name, the results include all
        /// the jobs that used any revision of that job definition name. If the value ends with
        /// an asterisk (*), the filter matches any job definition name that begins with the string
        /// before the '*'. For example, <code>jd1</code> matches only <code>jd1</code>, and <code>jd1*</code>
        /// matches both <code>jd1</code> and <code>jd1A</code>. The version of the job definition
        /// that's used doesn't affect the sort order. When the <code>JOB_DEFINITION</code> filter
        /// is used and the ARN is used (which is in the form <code>arn:${Partition}:batch:${Region}:${Account}:job-definition/${JobDefinitionName}:${Revision}</code>),
        /// the results include jobs that used the specified revision of the job definition. Asterisk
        /// (*) isn't supported when the ARN is used.
        /// </para>
        ///  </dd> <dt>BEFORE_CREATED_AT</dt> <dd> 
        /// <para>
        /// The value for the filter is the time that's before the job was created. This corresponds
        /// to the <code>createdAt</code> value. The value is a string representation of the number
        /// of milliseconds since 00:00:00 UTC (midnight) on January 1, 1970.
        /// </para>
        ///  </dd> <dt>AFTER_CREATED_AT</dt> <dd> 
        /// <para>
        /// The value for the filter is the time that's after the job was created. This corresponds
        /// to the <code>createdAt</code> value. The value is a string representation of the number
        /// of milliseconds since 00:00:00 UTC (midnight) on January 1, 1970.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public List<KeyValuesPair> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
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
        /// The job status used to filter jobs in the specified queue. If the <code>filters</code>
        /// parameter is specified, the <code>jobStatus</code> parameter is ignored and jobs with
        /// any status are returned. If you don't specify a status, only <code>RUNNING</code>
        /// jobs are returned.
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
        /// The maximum number of results returned by <code>ListJobs</code> in paginated output.
        /// When this parameter is used, <code>ListJobs</code> only returns <code>maxResults</code>
        /// results in a single page and a <code>nextToken</code> response element. The remaining
        /// results of the initial request can be seen by sending another <code>ListJobs</code>
        /// request with the returned <code>nextToken</code> value. This value can be between
        /// 1 and 100. If this parameter isn't used, then <code>ListJobs</code> returns up to
        /// 100 results and a <code>nextToken</code> value if applicable.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The <code>nextToken</code> value returned from a previous paginated <code>ListJobs</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value. This value is <code>null</code> when there
        /// are no more results to return.
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