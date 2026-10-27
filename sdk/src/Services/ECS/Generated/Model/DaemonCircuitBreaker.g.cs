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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Information about the circuit breaker used to determine when a daemon deployment has
    /// failed.
    /// </summary>
    public partial class DaemonCircuitBreaker
    {
        /// <summary>
        /// Gets and sets the property FailureCount. 
        /// <para>
        /// The number of times the circuit breaker detected a daemon deployment failure.
        /// </para>
        /// </summary>
        public int? FailureCount { get; set; }

        /// <summary>
        /// Checks to see if the FailureCount property is set.
        /// </summary>
        internal bool IsSetFailureCount() => this.FailureCount.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The circuit breaker status. Amazon ECS is not using the circuit breaker for daemon
        /// deployment failures when the status is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public DaemonDeploymentRollbackMonitorsStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The threshold which determines that the daemon deployment failed.
        /// </para>
        /// </summary>
        public int? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;
    }
}
