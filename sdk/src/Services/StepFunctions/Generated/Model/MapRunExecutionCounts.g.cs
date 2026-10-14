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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Aborted. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run and were
        /// running, but were either stopped by the user or by Step Functions because the Map
        /// Run failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Aborted { get; set; }

        /// <summary>
        /// Checks to see if the Aborted property is set.
        /// </summary>
        internal bool IsSetAborted() => this.Aborted.HasValue;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run, but
        /// have failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Failed { get; set; }

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed.HasValue;

        /// <summary>
        /// Gets and sets the property FailuresNotRedrivable. 
        /// <para>
        /// The number of <c>FAILED</c>, <c>ABORTED</c>, or <c>TIMED_OUT</c> child workflow executions
        /// that cannot be redriven because their execution status is terminal. For example, child
        /// workflows with an execution status of <c>FAILED</c>, <c>ABORTED</c>, or <c>TIMED_OUT</c>
        /// and a <c>redriveStatus</c> of <c>NOT_REDRIVABLE</c>.
        /// </para>
        /// </summary>
        public long? FailuresNotRedrivable { get; set; }

        /// <summary>
        /// Checks to see if the FailuresNotRedrivable property is set.
        /// </summary>
        internal bool IsSetFailuresNotRedrivable() => this.FailuresNotRedrivable.HasValue;

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run, but
        /// haven't started executing yet. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Pending { get; set; }

        /// <summary>
        /// Checks to see if the Pending property is set.
        /// </summary>
        internal bool IsSetPending() => this.Pending.HasValue;

        /// <summary>
        /// Gets and sets the property PendingRedrive. 
        /// <para>
        /// The number of unsuccessful child workflow executions currently waiting to be redriven.
        /// The status of these child workflow executions could be <c>FAILED</c>, <c>ABORTED</c>,
        /// or <c>TIMED_OUT</c> in the original execution attempt or a previous redrive attempt.
        /// </para>
        /// </summary>
        public long? PendingRedrive { get; set; }

        /// <summary>
        /// Checks to see if the PendingRedrive property is set.
        /// </summary>
        internal bool IsSetPendingRedrive() => this.PendingRedrive.HasValue;

        /// <summary>
        /// Gets and sets the property ResultsWritten. 
        /// <para>
        /// Returns the count of child workflow executions whose results were written by <c>ResultWriter</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/input-output-resultwriter.html">ResultWriter</a>
        /// in the <i>Step Functions Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? ResultsWritten { get; set; }

        /// <summary>
        /// Checks to see if the ResultsWritten property is set.
        /// </summary>
        internal bool IsSetResultsWritten() => this.ResultsWritten.HasValue;

        /// <summary>
        /// Gets and sets the property Running. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run and are
        /// currently in-progress.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Running { get; set; }

        /// <summary>
        /// Checks to see if the Running property is set.
        /// </summary>
        internal bool IsSetRunning() => this.Running.HasValue;

        /// <summary>
        /// Gets and sets the property Succeeded. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run and have
        /// completed successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Succeeded { get; set; }

        /// <summary>
        /// Checks to see if the Succeeded property is set.
        /// </summary>
        internal bool IsSetSucceeded() => this.Succeeded.HasValue;

        /// <summary>
        /// Gets and sets the property TimedOut. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run and have
        /// timed out.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? TimedOut { get; set; }

        /// <summary>
        /// Checks to see if the TimedOut property is set.
        /// </summary>
        internal bool IsSetTimedOut() => this.TimedOut.HasValue;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of child workflow executions that were started by a Map Run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Total { get; set; }

        /// <summary>
        /// Checks to see if the Total property is set.
        /// </summary>
        internal bool IsSetTotal() => this.Total.HasValue;
    }
}
