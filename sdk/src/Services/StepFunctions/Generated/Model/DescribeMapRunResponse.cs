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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the DescribeMapRun operation.
    /// </summary>
    public partial class DescribeMapRunResponse : AmazonWebServiceResponse
    {
        private string _executionArn;
        private MapRunExecutionCounts _executionCounts;
        private MapRunItemCounts _itemCounts;
        private string _mapRunArn;
        private int? _maxConcurrency;
        private DateTime? _startDate;
        private MapRunStatus _status;
        private DateTime? _stopDate;
        private long? _toleratedFailureCount;
        private float? _toleratedFailurePercentage;

        /// <summary>
        /// Gets and sets the property ExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the execution in which the Map Run
        /// was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ExecutionArn
        {
            get { return this._executionArn; }
            set { this._executionArn = value; }
        }

        // Check to see if ExecutionArn property is set
        internal bool IsSetExecutionArn()
        {
            return this._executionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionCounts. 
        /// <para>
        /// A JSON object that contains information about the total number of child workflow executions
        /// for the Map Run, and the count of child workflow executions for each status, such
        /// as <code>failed</code> and <code>succeeded</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MapRunExecutionCounts ExecutionCounts
        {
            get { return this._executionCounts; }
            set { this._executionCounts = value; }
        }

        // Check to see if ExecutionCounts property is set
        internal bool IsSetExecutionCounts()
        {
            return this._executionCounts != null;
        }

        /// <summary>
        /// Gets and sets the property ItemCounts. 
        /// <para>
        /// A JSON object that contains information about the total number of items, and the item
        /// count for each processing status, such as <code>pending</code> and <code>failed</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MapRunItemCounts ItemCounts
        {
            get { return this._itemCounts; }
            set { this._itemCounts = value; }
        }

        // Check to see if ItemCounts property is set
        internal bool IsSetItemCounts()
        {
            return this._itemCounts != null;
        }

        /// <summary>
        /// Gets and sets the property MapRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies a Map Run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string MapRunArn
        {
            get { return this._mapRunArn; }
            set { this._mapRunArn = value; }
        }

        // Check to see if MapRunArn property is set
        internal bool IsSetMapRunArn()
        {
            return this._mapRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of child workflow executions configured to run in parallel for
        /// the Map Run at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int MaxConcurrency
        {
            get { return this._maxConcurrency.GetValueOrDefault(); }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date when the Map Run was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
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
        /// The current status of the Map Run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MapRunStatus Status
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
        /// Gets and sets the property StopDate. 
        /// <para>
        /// The date when the Map Run was stopped.
        /// </para>
        /// </summary>
        public DateTime StopDate
        {
            get { return this._stopDate.GetValueOrDefault(); }
            set { this._stopDate = value; }
        }

        // Check to see if StopDate property is set
        internal bool IsSetStopDate()
        {
            return this._stopDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ToleratedFailureCount. 
        /// <para>
        /// The maximum number of failed child workflow executions before the Map Run fails.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long ToleratedFailureCount
        {
            get { return this._toleratedFailureCount.GetValueOrDefault(); }
            set { this._toleratedFailureCount = value; }
        }

        // Check to see if ToleratedFailureCount property is set
        internal bool IsSetToleratedFailureCount()
        {
            return this._toleratedFailureCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ToleratedFailurePercentage. 
        /// <para>
        /// The maximum percentage of failed child workflow executions before the Map Run fails.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public float ToleratedFailurePercentage
        {
            get { return this._toleratedFailurePercentage.GetValueOrDefault(); }
            set { this._toleratedFailurePercentage = value; }
        }

        // Check to see if ToleratedFailurePercentage property is set
        internal bool IsSetToleratedFailurePercentage()
        {
            return this._toleratedFailurePercentage.HasValue; 
        }

    }
}