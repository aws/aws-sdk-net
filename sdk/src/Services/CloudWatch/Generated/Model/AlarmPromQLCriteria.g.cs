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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Contains the configuration that determines how a PromQL alarm evaluates its contributors,
    /// including the query to run and the durations that define when contributors transition
    /// between states.
    /// </summary>
    public partial class AlarmPromQLCriteria
    {
        /// <summary>
        /// Gets and sets the property PendingPeriod. 
        /// <para>
        /// The duration, in seconds, that a contributor must be continuously breaching before
        /// it transitions to the <c>ALARM</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 86400)]
        public int? PendingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the PendingPeriod property is set.
        /// </summary>
        internal bool IsSetPendingPeriod() => this.PendingPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The PromQL query that the alarm evaluates. The query must return a result of vector
        /// type. Each entry in the vector result represents an alarm contributor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10000)]
        public string Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => this.Query != null;

        /// <summary>
        /// Gets and sets the property RecoveryPeriod. 
        /// <para>
        /// The duration, in seconds, that a contributor must continuously not be breaching before
        /// it transitions back to the <c>OK</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 86400)]
        public int? RecoveryPeriod { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPeriod property is set.
        /// </summary>
        internal bool IsSetRecoveryPeriod() => this.RecoveryPeriod.HasValue;
    }
}
