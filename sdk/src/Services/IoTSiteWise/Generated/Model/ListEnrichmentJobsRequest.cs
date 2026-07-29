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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListEnrichmentJobs operation.
    /// Lists enrichment jobs within a workspace with optional filtering and pagination. Results
    /// are ordered by createdAt timestamp descending (newest first).
    /// 
    ///  <h2>Filtering</h2> 
    /// <para>
    /// Combine filters to narrow results:
    /// </para>
    ///  <ul> <li><strong>datasetId</strong>: Filter by dataset</li> <li><strong>propertyAlias</strong>
    /// OR <strong>timeSeriesId</strong>: Filter by time series (specify one, not both)</li>
    /// <li><strong>status</strong>: Filter by job status (e.g., RUNNING to find active jobs)</li>
    /// <li><strong>jobType</strong>: Filter by enrichment type (currently only EVENT_DETECTION)</li>
    /// <li><strong>startDate</strong> and <strong>endDate</strong>: Filter by job creation
    /// time range</li> </ul> <h2>Important Constraints</h2> <ul> <li>You must specify either
    /// propertyAlias OR timeSeriesId, but not both</li> <li>Attempting to specify both results
    /// in an InvalidRequestException</li> <li>Date filters use ISO 8601 format</li> <li>startDate
    /// is exclusive, endDate is inclusive</li> </ul> <h2>Pagination</h2> 
    /// <para>
    /// The operation returns up to maxResults jobs per page (default 50). If more results
    /// exist, the response includes a nextToken. Submit this token in a subsequent request
    /// to retrieve the next page.
    /// </para>
    ///  <h2>Common Use Cases</h2> <ul> <li>Find all running jobs: Filter by status=RUNNING</li>
    /// <li>List recent jobs for a dataset: Filter by datasetId with optional date range</li>
    /// <li>Monitor jobs for a specific sensor: Filter by propertyAlias or timeSeriesId</li>
    /// <li>Track all event detection jobs: Filter by jobType=EVENT_DETECTION</li> </ul> <h2>Performance</h2>
    /// 
    /// <para>
    /// Performance is optimal when filtering by supported fields (datasetId, propertyAlias,
    /// timeSeriesId, status, jobType).
    /// </para>
    /// </summary>
    public partial class ListEnrichmentJobsRequest : AmazonIoTSiteWiseRequest
    {
        private string _datasetId;
        private DateTime? _endDate;
        private JobType _jobType;
        private int? _maxResults;
        private string _nextToken;
        private string _propertyAlias;
        private DateTime? _startDate;
        private EnrichmentJobStatus _status;
        private string _timeSeriesId;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// Filter jobs by dataset ID. Returns only jobs analyzing data from the specified dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The inclusive end of the date range for filtering jobs by creation time. Jobs created
        /// on or before this timestamp are included. Use ISO 8601 format (e.g., 2024-01-31T23:59:59Z).
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// Filter by enrichment job type. Currently only EVENT_DETECTION is supported. Use this
        /// filter to future-proof queries when additional job types are added.
        /// </para>
        /// </summary>
        public JobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of jobs to return per page. Defaults to 50 if not specified. Use smaller
        /// values for faster responses, larger values to reduce API calls.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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
        /// Pagination token from a previous ListEnrichmentJobs response. Include this token to
        /// retrieve the next page of results. Omit for the first request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property PropertyAlias. 
        /// <para>
        /// Filter by property alias (human-readable sensor name). Specify either propertyAlias
        /// or timeSeriesId, but not both. Returns only jobs analyzing the specified property
        /// alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PropertyAlias
        {
            get { return this._propertyAlias; }
            set { this._propertyAlias = value; }
        }

        // Check to see if PropertyAlias property is set
        internal bool IsSetPropertyAlias()
        {
            return this._propertyAlias != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The exclusive start of the date range for filtering jobs by creation time. Jobs created
        /// after this timestamp are included. Use ISO 8601 format (e.g., 2024-01-01T00:00:00Z).
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter by job status. Returns only jobs in the specified status. Use RUNNING to find
        /// active jobs, or FAILED to identify jobs requiring attention.
        /// </para>
        /// </summary>
        public EnrichmentJobStatus Status
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
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// Filter by time series ID (system identifier). Specify either timeSeriesId or propertyAlias,
        /// but not both. Returns only jobs analyzing the specified time series.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=73)]
        public string TimeSeriesId
        {
            get { return this._timeSeriesId; }
            set { this._timeSeriesId = value; }
        }

        // Check to see if TimeSeriesId property is set
        internal bool IsSetTimeSeriesId()
        {
            return this._timeSeriesId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the IoT SiteWise workspace to list enrichment jobs from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}