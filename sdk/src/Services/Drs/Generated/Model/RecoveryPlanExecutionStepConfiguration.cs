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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
        private ExecutionServerStepConfiguration _executionServerStepConfiguration;
        private WaitStepConfiguration _waitStepConfiguration;

        /// <summary>
        /// Gets and sets the property ExecutionServerStepConfiguration. 
        /// <para>
        /// Configuration for a SERVER type step (with execution state like jobID).
        /// </para>
        /// </summary>
        public ExecutionServerStepConfiguration ExecutionServerStepConfiguration
        {
            get { return this._executionServerStepConfiguration; }
            set { this._executionServerStepConfiguration = value; }
        }

        // Check to see if ExecutionServerStepConfiguration property is set
        internal bool IsSetExecutionServerStepConfiguration()
        {
            return this._executionServerStepConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WaitStepConfiguration. 
        /// <para>
        /// Configuration for a WAIT type step.
        /// </para>
        /// </summary>
        public WaitStepConfiguration WaitStepConfiguration
        {
            get { return this._waitStepConfiguration; }
            set { this._waitStepConfiguration = value; }
        }

        // Check to see if WaitStepConfiguration property is set
        internal bool IsSetWaitStepConfiguration()
        {
            return this._waitStepConfiguration != null;
        }

    }
}