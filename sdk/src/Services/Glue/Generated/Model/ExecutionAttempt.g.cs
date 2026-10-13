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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A run attempt for a column statistics task run.
    /// </summary>
    public partial class ExecutionAttempt
    {
        /// <summary>
        /// Gets and sets the property ColumnStatisticsTaskRunId. 
        /// <para>
        /// A task run ID for the last column statistics task run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ColumnStatisticsTaskRunId { get; set; }

        /// <summary>
        /// Checks to see if the ColumnStatisticsTaskRunId property is set.
        /// </summary>
        internal bool IsSetColumnStatisticsTaskRunId() => this.ColumnStatisticsTaskRunId != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message associated with the last column statistics task run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ExecutionTimestamp. 
        /// <para>
        /// A timestamp when the last column statistics task run occurred.
        /// </para>
        /// </summary>
        public DateTime? ExecutionTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTimestamp property is set.
        /// </summary>
        internal bool IsSetExecutionTimestamp() => this.ExecutionTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the last column statistics task run.
        /// </para>
        /// </summary>
        public ExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
