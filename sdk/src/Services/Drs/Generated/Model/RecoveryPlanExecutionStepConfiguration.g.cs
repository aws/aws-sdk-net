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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Type-specific configuration for an execution step response. Mirrors RecoveryPlanStepConfiguration
    /// but uses execution-enriched server shapes.
    /// </summary>
    public partial class RecoveryPlanExecutionStepConfiguration
    {
        /// <summary>
        /// Gets and sets the property ExecutionServerStepConfiguration. Configuration for a SERVER
        /// type step (with execution state like jobID).
        /// </summary>
        public ExecutionServerStepConfiguration ExecutionServerStepConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionServerStepConfiguration property is set.
        /// </summary>
        internal bool IsSetExecutionServerStepConfiguration() => this.ExecutionServerStepConfiguration != null;

        /// <summary>
        /// Gets and sets the property WaitStepConfiguration. Configuration for a WAIT type step.
        /// </summary>
        public WaitStepConfiguration WaitStepConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WaitStepConfiguration property is set.
        /// </summary>
        internal bool IsSetWaitStepConfiguration() => this.WaitStepConfiguration != null;
    }
}
