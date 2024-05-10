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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about all of the child workflow executions started by a Map Run.
    /// </summary>
    public partial class MapRunExecutionCounts
    {
        private long? _aborted;
        private long? _failed;
        private long? _failuresNotRedrivable;
        private long? _pending;
        private long? _pendingRedrive;
        private long? _resultsWritten;
        private long? _running;
        private long? _succeeded;
        private long? _timedOut;
        private long? _total;

        /// <summary>
        /// Gets and sets the property Aborted. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run and were
        /// running, but were either stopped by the user or by Step Functions because the Map
        /// Run failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? Aborted
        {
            get { return this._aborted; }
            set { this._aborted = value; }
        }

        // Check to see if Aborted property is set
        internal bool IsSetAborted()
        {
            return this._aborted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run, but
        /// have failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailuresNotRedrivable. 
        /// <para>
        /// The number of <c>FAILED</c>, <c>ABORTED</c>, or <c>TIMED_OUT</c> child workflow executions
        /// that cannot be redriven because their execution status is terminal. For example, child
        /// workflows with an execution status of <c>FAILED</c>, <c>ABORTED</c>, or <c>TIMED_OUT</c>
        /// and a <c>redriveStatus</c> of <c>NOT_REDRIVABLE</c>.
        /// </para>
        /// </summary>
        public long? FailuresNotRedrivable
        {
            get { return this._failuresNotRedrivable; }
            set { this._failuresNotRedrivable = value; }
        }

        // Check to see if FailuresNotRedrivable property is set
        internal bool IsSetFailuresNotRedrivable()
        {
            return this._failuresNotRedrivable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run, but
        /// haven't started executing yet. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? Pending
        {
            get { return this._pending; }
            set { this._pending = value; }
        }

        // Check to see if Pending property is set
        internal bool IsSetPending()
        {
            return this._pending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingRedrive. 
        /// <para>
        /// The number of unsuccessful child workflow executions currently waiting to be redriven.
        /// The status of these child workflow executions could be <c>FAILED</c>, <c>ABORTED</c>,
        /// or <c>TIMED_OUT</c> in the original execution attempt or a previous redrive attempt.
        /// </para>
        /// </summary>
        public long? PendingRedrive
        {
            get { return this._pendingRedrive; }
            set { this._pendingRedrive = value; }
        }

        // Check to see if PendingRedrive property is set
        internal bool IsSetPendingRedrive()
        {
            return this._pendingRedrive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultsWritten. 
        /// <para>
        /// Returns the count of child workflow executions whose results were written by <c>ResultWriter</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/input-output-resultwriter.html">ResultWriter</a>
        /// in the <i>Step Functions Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? ResultsWritten
        {
            get { return this._resultsWritten; }
            set { this._resultsWritten = value; }
        }

        // Check to see if ResultsWritten property is set
        internal bool IsSetResultsWritten()
        {
            return this._resultsWritten.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Running. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run and are
        /// currently in-progress.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? Running
        {
            get { return this._running; }
            set { this._running = value; }
        }

        // Check to see if Running property is set
        internal bool IsSetRunning()
        {
            return this._running.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Succeeded. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run and have
        /// completed successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? Succeeded
        {
            get { return this._succeeded; }
            set { this._succeeded = value; }
        }

        // Check to see if Succeeded property is set
        internal bool IsSetSucceeded()
        {
            return this._succeeded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimedOut. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run and have
        /// timed out.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? TimedOut
        {
            get { return this._timedOut; }
            set { this._timedOut = value; }
        }

        // Check to see if TimedOut property is set
        internal bool IsSetTimedOut()
        {
            return this._timedOut.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}