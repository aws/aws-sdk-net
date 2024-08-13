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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListAuditMitigationActionsTasks operation.
    /// Gets a list of audit mitigation action tasks that match the specified filters.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuditMitigationActionsTasks</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class ListAuditMitigationActionsTasksRequest : AmazonIoTRequest
    {
        private string _auditTaskId;
        private DateTime? _endTime;
        private string _findingId;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startTime;
        private AuditMitigationActionsTaskStatus _taskStatus;

        /// <summary>
        /// Gets and sets the property AuditTaskId. 
        /// <para>
        /// Specify this filter to limit results to tasks that were applied to results for a specific
        /// audit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string AuditTaskId
        {
            get { return this._auditTaskId; }
            set { this._auditTaskId = value; }
        }

        // Check to see if AuditTaskId property is set
        internal bool IsSetAuditTaskId()
        {
            return this._auditTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Specify this filter to limit results to tasks that were completed or canceled on or
        /// before a specific date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// Specify this filter to limit results to tasks that were applied to a specific audit
        /// finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FindingId
        {
            get { return this._findingId; }
            set { this._findingId = value; }
        }

        // Check to see if FindingId property is set
        internal bool IsSetFindingId()
        {
            return this._findingId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time. The default is 25.
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
        /// The token for the next set of results.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Specify this filter to limit results to tasks that began on or after a specific date
        /// and time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// Specify this filter to limit results to tasks that are in a specific state.
        /// </para>
        /// </summary>
        public AuditMitigationActionsTaskStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

    }
}