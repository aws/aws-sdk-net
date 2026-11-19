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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The number of targets in a rate control execution, and the status of the child executions
    /// that it started for those targets.
    /// </summary>
    public partial class TargetsSummary
    {
        /// <summary>
        /// Gets and sets the property CompletedCount. 
        /// <para>
        /// The number of child executions that finished, whether they succeeded or failed.
        /// </para>
        /// </summary>
        public int? CompletedCount { get; set; }

        /// <summary>
        /// Checks to see if the CompletedCount property is set.
        /// </summary>
        internal bool IsSetCompletedCount() => this.CompletedCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailedCount. 
        /// <para>
        /// The number of child executions that failed, timed out, or were canceled.
        /// </para>
        /// </summary>
        public int? FailedCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedCount property is set.
        /// </summary>
        internal bool IsSetFailedCount() => this.FailedCount.HasValue;

        /// <summary>
        /// Gets and sets the property StartedCount. 
        /// <para>
        /// The number of child executions that started.
        /// </para>
        /// </summary>
        public int? StartedCount { get; set; }

        /// <summary>
        /// Checks to see if the StartedCount property is set.
        /// </summary>
        internal bool IsSetStartedCount() => this.StartedCount.HasValue;

        /// <summary>
        /// Gets and sets the property SuccessfulCount. 
        /// <para>
        /// The number of child executions that succeeded.
        /// </para>
        /// </summary>
        public int? SuccessfulCount { get; set; }

        /// <summary>
        /// Checks to see if the SuccessfulCount property is set.
        /// </summary>
        internal bool IsSetSuccessfulCount() => this.SuccessfulCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of targets in the rate control execution.
        /// </para>
        /// </summary>
        public int? TotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCount property is set.
        /// </summary>
        internal bool IsSetTotalCount() => this.TotalCount.HasValue;
    }
}
