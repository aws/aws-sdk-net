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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListMonitoringExecutions operation.
    /// Returns list of all monitoring job executions.
    /// </summary>
    public partial class ListMonitoringExecutionsRequest : AmazonSageMakerRequest
    {
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private string _endpointName;
        private DateTime? _lastModifiedTimeAfter;
        private DateTime? _lastModifiedTimeBefore;
        private int? _maxResults;
        private string _monitoringJobDefinitionName;
        private string _monitoringScheduleName;
        private MonitoringType _monitoringTypeEquals;
        private string _nextToken;
        private DateTime? _scheduledTimeAfter;
        private DateTime? _scheduledTimeBefore;
        private MonitoringExecutionSortKey _sortBy;
        private SortOrder _sortOrder;
        private ExecutionStatus _statusEquals;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns only jobs created after a specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter
        {
            get { return this._creationTimeAfter; }
            set { this._creationTimeAfter = value; }
        }

        // Check to see if CreationTimeAfter property is set
        internal bool IsSetCreationTimeAfter()
        {
            return this._creationTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// A filter that returns only jobs created before a specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore
        {
            get { return this._creationTimeBefore; }
            set { this._creationTimeBefore = value; }
        }

        // Check to see if CreationTimeBefore property is set
        internal bool IsSetCreationTimeBefore()
        {
            return this._creationTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// Name of a specific endpoint to fetch jobs for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimeAfter. 
        /// <para>
        /// A filter that returns only jobs modified before a specified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeAfter
        {
            get { return this._lastModifiedTimeAfter; }
            set { this._lastModifiedTimeAfter = value; }
        }

        // Check to see if LastModifiedTimeAfter property is set
        internal bool IsSetLastModifiedTimeAfter()
        {
            return this._lastModifiedTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimeBefore. 
        /// <para>
        /// A filter that returns only jobs modified after a specified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeBefore
        {
            get { return this._lastModifiedTimeBefore; }
            set { this._lastModifiedTimeBefore = value; }
        }

        // Check to see if LastModifiedTimeBefore property is set
        internal bool IsSetLastModifiedTimeBefore()
        {
            return this._lastModifiedTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of jobs to return in the response. The default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property MonitoringJobDefinitionName. 
        /// <para>
        /// Gets a list of the monitoring job runs of the specified monitoring job definitions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string MonitoringJobDefinitionName
        {
            get { return this._monitoringJobDefinitionName; }
            set { this._monitoringJobDefinitionName = value; }
        }

        // Check to see if MonitoringJobDefinitionName property is set
        internal bool IsSetMonitoringJobDefinitionName()
        {
            return this._monitoringJobDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringScheduleName. 
        /// <para>
        /// Name of a specific schedule to fetch jobs for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string MonitoringScheduleName
        {
            get { return this._monitoringScheduleName; }
            set { this._monitoringScheduleName = value; }
        }

        // Check to see if MonitoringScheduleName property is set
        internal bool IsSetMonitoringScheduleName()
        {
            return this._monitoringScheduleName != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringTypeEquals. 
        /// <para>
        /// A filter that returns only the monitoring job runs of the specified monitoring type.
        /// </para>
        /// </summary>
        public MonitoringType MonitoringTypeEquals
        {
            get { return this._monitoringTypeEquals; }
            set { this._monitoringTypeEquals = value; }
        }

        // Check to see if MonitoringTypeEquals property is set
        internal bool IsSetMonitoringTypeEquals()
        {
            return this._monitoringTypeEquals != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned if the response is truncated. To retrieve the next set of job executions,
        /// use it in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// Gets and sets the property ScheduledTimeAfter. 
        /// <para>
        /// Filter for jobs scheduled after a specified time.
        /// </para>
        /// </summary>
        public DateTime? ScheduledTimeAfter
        {
            get { return this._scheduledTimeAfter; }
            set { this._scheduledTimeAfter = value; }
        }

        // Check to see if ScheduledTimeAfter property is set
        internal bool IsSetScheduledTimeAfter()
        {
            return this._scheduledTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledTimeBefore. 
        /// <para>
        /// Filter for jobs scheduled before a specified time.
        /// </para>
        /// </summary>
        public DateTime? ScheduledTimeBefore
        {
            get { return this._scheduledTimeBefore; }
            set { this._scheduledTimeBefore = value; }
        }

        // Check to see if ScheduledTimeBefore property is set
        internal bool IsSetScheduledTimeBefore()
        {
            return this._scheduledTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Whether to sort the results by the <c>Status</c>, <c>CreationTime</c>, or <c>ScheduledTime</c>
        /// field. The default is <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public MonitoringExecutionSortKey SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Whether to sort the results in <c>Ascending</c> or <c>Descending</c> order. The default
        /// is <c>Descending</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// A filter that retrieves only jobs with a specific status.
        /// </para>
        /// </summary>
        public ExecutionStatus StatusEquals
        {
            get { return this._statusEquals; }
            set { this._statusEquals = value; }
        }

        // Check to see if StatusEquals property is set
        internal bool IsSetStatusEquals()
        {
            return this._statusEquals != null;
        }

    }
}