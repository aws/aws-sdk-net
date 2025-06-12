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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Container for the parameters to the ListBatchJobExecutions operation.
    /// Lists historical, current, and scheduled batch job executions for a specific application.
    /// </summary>
    public partial class ListBatchJobExecutionsRequest : AmazonMainframeModernizationRequest
    {
        private string _applicationId;
        private List<string> _executionIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _jobName;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startedAfter;
        private DateTime? _startedBefore;
        private BatchJobExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionIds. 
        /// <para>
        /// The unique identifier of each batch job execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ExecutionIds
        {
            get { return this._executionIds; }
            set { this._executionIds = value; }
        }

        // Check to see if ExecutionIds property is set
        internal bool IsSetExecutionIds()
        {
            return this._executionIds != null && (this._executionIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of each batch job execution.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of batch job executions to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// A pagination token to control the number of batch job executions displayed in the
        /// list.
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
        /// Gets and sets the property StartedAfter. 
        /// <para>
        /// The time after which the batch job executions started.
        /// </para>
        /// </summary>
        public DateTime? StartedAfter
        {
            get { return this._startedAfter; }
            set { this._startedAfter = value; }
        }

        // Check to see if StartedAfter property is set
        internal bool IsSetStartedAfter()
        {
            return this._startedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedBefore. 
        /// <para>
        /// The time before the batch job executions started.
        /// </para>
        /// </summary>
        public DateTime? StartedBefore
        {
            get { return this._startedBefore; }
            set { this._startedBefore = value; }
        }

        // Check to see if StartedBefore property is set
        internal bool IsSetStartedBefore()
        {
            return this._startedBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the batch job executions.
        /// </para>
        /// </summary>
        public BatchJobExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}