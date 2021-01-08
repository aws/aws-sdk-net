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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListMonitoringSchedules operation.
    /// Returns list of all monitoring schedules.
    /// </summary>
    public partial class ListMonitoringSchedulesRequest : AmazonSageMakerRequest
    {
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private string _endpointName;
        private DateTime? _lastModifiedTimeAfter;
        private DateTime? _lastModifiedTimeBefore;
        private int? _maxResults;
        private string _monitoringJobDefinitionName;
        private MonitoringType _monitoringTypeEquals;
        private string _nameContains;
        private string _nextToken;
        private MonitoringScheduleSortKey _sortBy;
        private SortOrder _sortOrder;
        private ScheduleStatus _statusEquals;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns only monitoring schedules created after a specified time.
        /// </para>
        /// </summary>
        public DateTime CreationTimeAfter
        {
            get { return this._creationTimeAfter.GetValueOrDefault(); }
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
        /// A filter that returns only monitoring schedules created before a specified time.
        /// </para>
        /// </summary>
        public DateTime CreationTimeBefore
        {
            get { return this._creationTimeBefore.GetValueOrDefault(); }
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
        /// Name of a specific endpoint to fetch schedules for.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
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
        /// A filter that returns only monitoring schedules modified after a specified time.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTimeAfter
        {
            get { return this._lastModifiedTimeAfter.GetValueOrDefault(); }
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
        /// A filter that returns only monitoring schedules modified before a specified time.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTimeBefore
        {
            get { return this._lastModifiedTimeBefore.GetValueOrDefault(); }
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
        /// Gets and sets the property MonitoringJobDefinitionName. 
        /// <para>
        /// Gets a list of the monitoring schedules for the specified monitoring job definition.
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
        /// Gets and sets the property MonitoringTypeEquals. 
        /// <para>
        /// A filter that returns only the monitoring schedules for the specified monitoring type.
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
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Filter for monitoring schedules whose name contains a specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned if the response is truncated. To retrieve the next set of job executions,
        /// use it in the next request.
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Whether to sort results by <code>Status</code>, <code>CreationTime</code>, <code>ScheduledTime</code>
        /// field. The default is <code>CreationTime</code>.
        /// </para>
        /// </summary>
        public MonitoringScheduleSortKey SortBy
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
        /// Whether to sort the results in <code>Ascending</code> or <code>Descending</code> order.
        /// The default is <code>Descending</code>.
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
        /// A filter that returns only monitoring schedules modified before a specified time.
        /// </para>
        /// </summary>
        public ScheduleStatus StatusEquals
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