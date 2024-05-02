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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Workflow specific execution metrics for <c>APPFLOW_INTEGRATION</c> workflow.
    /// </summary>
    public partial class AppflowIntegrationWorkflowMetrics
    {
        private long? _recordsProcessed;
        private long? _stepsCompleted;
        private long? _totalSteps;

        /// <summary>
        /// Gets and sets the property RecordsProcessed. 
        /// <para>
        /// Number of records processed in <c>APPFLOW_INTEGRATION</c> workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? RecordsProcessed
        {
            get { return this._recordsProcessed; }
            set { this._recordsProcessed = value; }
        }

        // Check to see if RecordsProcessed property is set
        internal bool IsSetRecordsProcessed()
        {
            return this._recordsProcessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepsCompleted. 
        /// <para>
        /// Total steps completed in <c>APPFLOW_INTEGRATION</c> workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? StepsCompleted
        {
            get { return this._stepsCompleted; }
            set { this._stepsCompleted = value; }
        }

        // Check to see if StepsCompleted property is set
        internal bool IsSetStepsCompleted()
        {
            return this._stepsCompleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSteps. 
        /// <para>
        /// Total steps in <c>APPFLOW_INTEGRATION</c> workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TotalSteps
        {
            get { return this._totalSteps; }
            set { this._totalSteps = value; }
        }

        // Check to see if TotalSteps property is set
        internal bool IsSetTotalSteps()
        {
            return this._totalSteps.HasValue; 
        }

    }
}