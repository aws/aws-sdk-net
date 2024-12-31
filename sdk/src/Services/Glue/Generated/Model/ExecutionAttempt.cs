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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private string _columnStatisticsTaskRunId;
        private string _errorMessage;
        private DateTime? _executionTimestamp;
        private ExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property ColumnStatisticsTaskRunId. 
        /// <para>
        /// A task run ID for the last column statistics task run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ColumnStatisticsTaskRunId
        {
            get { return this._columnStatisticsTaskRunId; }
            set { this._columnStatisticsTaskRunId = value; }
        }

        // Check to see if ColumnStatisticsTaskRunId property is set
        internal bool IsSetColumnStatisticsTaskRunId()
        {
            return this._columnStatisticsTaskRunId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message associated with the last column statistics task run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTimestamp. 
        /// <para>
        /// A timestamp when the last column statistics task run occurred.
        /// </para>
        /// </summary>
        public DateTime? ExecutionTimestamp
        {
            get { return this._executionTimestamp; }
            set { this._executionTimestamp = value; }
        }

        // Check to see if ExecutionTimestamp property is set
        internal bool IsSetExecutionTimestamp()
        {
            return this._executionTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the last column statistics task run.
        /// </para>
        /// </summary>
        public ExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}