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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The status, the iteration-step counts, and the selector information for a ForEach
    /// step execution.
    /// </summary>
    public partial class ForEachStepMetadata
    {
        /// <summary>
        /// Gets and sets the property FailedStepCount. 
        /// <para>
        /// The number of iteration steps that failed.
        /// </para>
        /// </summary>
        public int? FailedStepCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedStepCount property is set.
        /// </summary>
        internal bool IsSetFailedStepCount() => this.FailedStepCount.HasValue;

        /// <summary>
        /// Gets and sets the property InputItemCount. 
        /// <para>
        /// The number of input items that the ForEach step iterates over.
        /// </para>
        /// </summary>
        public int? InputItemCount { get; set; }

        /// <summary>
        /// Checks to see if the InputItemCount property is set.
        /// </summary>
        internal bool IsSetInputItemCount() => this.InputItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property Selector. 
        /// <para>
        /// Identifies the body step and iteration selected within the ForEach step.
        /// </para>
        /// </summary>
        public ForEachSelectorResult Selector { get; set; }

        /// <summary>
        /// Checks to see if the Selector property is set.
        /// </summary>
        internal bool IsSetSelector() => this.Selector != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ForEach step execution.
        /// </para>
        /// </summary>
        public ForEachStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StoppedStepCount. 
        /// <para>
        /// The number of iteration steps that were stopped.
        /// </para>
        /// </summary>
        public int? StoppedStepCount { get; set; }

        /// <summary>
        /// Checks to see if the StoppedStepCount property is set.
        /// </summary>
        internal bool IsSetStoppedStepCount() => this.StoppedStepCount.HasValue;

        /// <summary>
        /// Gets and sets the property SucceededStepCount. 
        /// <para>
        /// The number of iteration steps that completed successfully.
        /// </para>
        /// </summary>
        public int? SucceededStepCount { get; set; }

        /// <summary>
        /// Checks to see if the SucceededStepCount property is set.
        /// </summary>
        internal bool IsSetSucceededStepCount() => this.SucceededStepCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalStepCount. 
        /// <para>
        /// The total number of steps generated across all iterations of the ForEach step.
        /// </para>
        /// </summary>
        public int? TotalStepCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalStepCount property is set.
        /// </summary>
        internal bool IsSetTotalStepCount() => this.TotalStepCount.HasValue;
    }
}
