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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// A record of a scheduled query execution, including its status and destination processing
    /// information.
    /// </summary>
    public partial class TriggerHistoryRecord
    {
        private List<ScheduledQueryDestination> _destinations = AWSConfigs.InitializeCollections ? new List<ScheduledQueryDestination>() : null;
        private string _errorMessage;
        private ExecutionStatus _executionStatus;
        private string _queryId;
        private long? _triggeredTimestamp;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// The list of destinations where the scheduled query results were delivered for this
        /// execution. This includes S3 buckets configured for the scheduled query.
        /// </para>
        /// </summary>
        public List<ScheduledQueryDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message if the scheduled query execution failed. This field is only populated
        /// when the execution status indicates a failure.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The status of the query execution (Running, Complete, Failed, Timeout, or InvalidQuery).
        /// </para>
        /// </summary>
        public ExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The unique identifier for the query execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

        /// <summary>
        /// Gets and sets the property TriggeredTimestamp. 
        /// <para>
        /// The time when the scheduled query was triggered, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long TriggeredTimestamp
        {
            get { return this._triggeredTimestamp.GetValueOrDefault(); }
            set { this._triggeredTimestamp = value; }
        }

        // Check to see if TriggeredTimestamp property is set
        internal bool IsSetTriggeredTimestamp()
        {
            return this._triggeredTimestamp.HasValue; 
        }

    }
}