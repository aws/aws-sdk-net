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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// A summary of the runs in a batch.
    /// </summary>
    public partial class RunSummary
    {
        private int? _cancelledRunCount;
        private int? _completedRunCount;
        private int? _deletedRunCount;
        private int? _failedRunCount;
        private int? _pendingRunCount;
        private int? _runningRunCount;
        private int? _startingRunCount;
        private int? _stoppingRunCount;

        /// <summary>
        /// Gets and sets the property CancelledRunCount. 
        /// <para>
        /// The number of cancelled runs.
        /// </para>
        /// </summary>
        public int CancelledRunCount
        {
            get { return this._cancelledRunCount.GetValueOrDefault(); }
            set { this._cancelledRunCount = value; }
        }

        // Check to see if CancelledRunCount property is set
        internal bool IsSetCancelledRunCount()
        {
            return this._cancelledRunCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompletedRunCount. 
        /// <para>
        /// The number of completed runs.
        /// </para>
        /// </summary>
        public int CompletedRunCount
        {
            get { return this._completedRunCount.GetValueOrDefault(); }
            set { this._completedRunCount = value; }
        }

        // Check to see if CompletedRunCount property is set
        internal bool IsSetCompletedRunCount()
        {
            return this._completedRunCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletedRunCount. 
        /// <para>
        /// The number of deleted runs.
        /// </para>
        /// </summary>
        public int DeletedRunCount
        {
            get { return this._deletedRunCount.GetValueOrDefault(); }
            set { this._deletedRunCount = value; }
        }

        // Check to see if DeletedRunCount property is set
        internal bool IsSetDeletedRunCount()
        {
            return this._deletedRunCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedRunCount. 
        /// <para>
        /// The number of failed runs.
        /// </para>
        /// </summary>
        public int FailedRunCount
        {
            get { return this._failedRunCount.GetValueOrDefault(); }
            set { this._failedRunCount = value; }
        }

        // Check to see if FailedRunCount property is set
        internal bool IsSetFailedRunCount()
        {
            return this._failedRunCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingRunCount. 
        /// <para>
        /// The number of pending runs.
        /// </para>
        /// </summary>
        public int PendingRunCount
        {
            get { return this._pendingRunCount.GetValueOrDefault(); }
            set { this._pendingRunCount = value; }
        }

        // Check to see if PendingRunCount property is set
        internal bool IsSetPendingRunCount()
        {
            return this._pendingRunCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningRunCount. 
        /// <para>
        /// The number of running runs.
        /// </para>
        /// </summary>
        public int RunningRunCount
        {
            get { return this._runningRunCount.GetValueOrDefault(); }
            set { this._runningRunCount = value; }
        }

        // Check to see if RunningRunCount property is set
        internal bool IsSetRunningRunCount()
        {
            return this._runningRunCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartingRunCount. 
        /// <para>
        /// The number of starting runs.
        /// </para>
        /// </summary>
        public int StartingRunCount
        {
            get { return this._startingRunCount.GetValueOrDefault(); }
            set { this._startingRunCount = value; }
        }

        // Check to see if StartingRunCount property is set
        internal bool IsSetStartingRunCount()
        {
            return this._startingRunCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StoppingRunCount. 
        /// <para>
        /// The number of stopping runs.
        /// </para>
        /// </summary>
        public int StoppingRunCount
        {
            get { return this._stoppingRunCount.GetValueOrDefault(); }
            set { this._stoppingRunCount = value; }
        }

        // Check to see if StoppingRunCount property is set
        internal bool IsSetStoppingRunCount()
        {
            return this._stoppingRunCount.HasValue; 
        }

    }
}