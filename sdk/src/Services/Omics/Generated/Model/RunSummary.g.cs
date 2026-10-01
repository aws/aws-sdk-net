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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// A summary of the runs in a batch.
    /// </summary>
    public partial class RunSummary
    {
        /// <summary>
        /// Gets and sets the property CancelledRunCount. 
        /// <para>
        /// The number of cancelled runs.
        /// </para>
        /// </summary>
        public int? CancelledRunCount { get; set; }

        /// <summary>
        /// Checks to see if the CancelledRunCount property is set.
        /// </summary>
        internal bool IsSetCancelledRunCount() => this.CancelledRunCount.HasValue;

        /// <summary>
        /// Gets and sets the property CompletedRunCount. 
        /// <para>
        /// The number of completed runs.
        /// </para>
        /// </summary>
        public int? CompletedRunCount { get; set; }

        /// <summary>
        /// Checks to see if the CompletedRunCount property is set.
        /// </summary>
        internal bool IsSetCompletedRunCount() => this.CompletedRunCount.HasValue;

        /// <summary>
        /// Gets and sets the property DeletedRunCount. 
        /// <para>
        /// The number of deleted runs.
        /// </para>
        /// </summary>
        public int? DeletedRunCount { get; set; }

        /// <summary>
        /// Checks to see if the DeletedRunCount property is set.
        /// </summary>
        internal bool IsSetDeletedRunCount() => this.DeletedRunCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailedRunCount. 
        /// <para>
        /// The number of failed runs.
        /// </para>
        /// </summary>
        public int? FailedRunCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedRunCount property is set.
        /// </summary>
        internal bool IsSetFailedRunCount() => this.FailedRunCount.HasValue;

        /// <summary>
        /// Gets and sets the property PendingRunCount. 
        /// <para>
        /// The number of pending runs.
        /// </para>
        /// </summary>
        public int? PendingRunCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingRunCount property is set.
        /// </summary>
        internal bool IsSetPendingRunCount() => this.PendingRunCount.HasValue;

        /// <summary>
        /// Gets and sets the property RunningRunCount. 
        /// <para>
        /// The number of running runs.
        /// </para>
        /// </summary>
        public int? RunningRunCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningRunCount property is set.
        /// </summary>
        internal bool IsSetRunningRunCount() => this.RunningRunCount.HasValue;

        /// <summary>
        /// Gets and sets the property StartingRunCount. 
        /// <para>
        /// The number of starting runs.
        /// </para>
        /// </summary>
        public int? StartingRunCount { get; set; }

        /// <summary>
        /// Checks to see if the StartingRunCount property is set.
        /// </summary>
        internal bool IsSetStartingRunCount() => this.StartingRunCount.HasValue;

        /// <summary>
        /// Gets and sets the property StoppingRunCount. 
        /// <para>
        /// The number of stopping runs.
        /// </para>
        /// </summary>
        public int? StoppingRunCount { get; set; }

        /// <summary>
        /// Checks to see if the StoppingRunCount property is set.
        /// </summary>
        internal bool IsSetStoppingRunCount() => this.StoppingRunCount.HasValue;
    }
}
