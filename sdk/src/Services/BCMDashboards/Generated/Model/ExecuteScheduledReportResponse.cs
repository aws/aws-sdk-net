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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
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
namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// This is the response object from the ExecuteScheduledReport operation.
    /// </summary>
    public partial class ExecuteScheduledReportResponse : AmazonWebServiceResponse
    {
        private bool? _executionTriggered;
        private HealthStatus _healthStatus;

        /// <summary>
        /// Gets and sets the property ExecutionTriggered. 
        /// <para>
        /// Indicates whether the execution was successfully triggered.
        /// </para>
        /// </summary>
        public bool? ExecutionTriggered
        {
            get { return this._executionTriggered; }
            set { this._executionTriggered = value; }
        }

        // Check to see if ExecutionTriggered property is set
        internal bool IsSetExecutionTriggered()
        {
            return this._executionTriggered.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status of the scheduled report after the execution request.
        /// </para>
        /// </summary>
        public HealthStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

    }
}