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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Specifies the end result of the flow run.
    /// </summary>
    public partial class ExecutionResult
    {
        /// <summary>
        /// Gets and sets the property BytesProcessed. 
        /// <para>
        ///  The total number of bytes processed by the flow run. 
        /// </para>
        /// </summary>
        public long? BytesProcessed { get; set; }

        /// <summary>
        /// Checks to see if the BytesProcessed property is set.
        /// </summary>
        internal bool IsSetBytesProcessed() => this.BytesProcessed.HasValue;

        /// <summary>
        /// Gets and sets the property BytesWritten. 
        /// <para>
        ///  The total number of bytes written as a result of the flow run. 
        /// </para>
        /// </summary>
        public long? BytesWritten { get; set; }

        /// <summary>
        /// Checks to see if the BytesWritten property is set.
        /// </summary>
        internal bool IsSetBytesWritten() => this.BytesWritten.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        ///  Provides any error message information related to the flow run. 
        /// </para>
        /// </summary>
        public ErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInfo property is set.
        /// </summary>
        internal bool IsSetErrorInfo() => this.ErrorInfo != null;

        /// <summary>
        /// Gets and sets the property MaxPageSize. 
        /// <para>
        /// The maximum number of records that Amazon AppFlow receives in each page of the response
        /// from your SAP application.
        /// </para>
        /// </summary>
        public long? MaxPageSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxPageSize property is set.
        /// </summary>
        internal bool IsSetMaxPageSize() => this.MaxPageSize.HasValue;

        /// <summary>
        /// Gets and sets the property NumParallelProcesses. 
        /// <para>
        /// The number of processes that Amazon AppFlow ran at the same time when it retrieved
        /// your data.
        /// </para>
        /// </summary>
        public long? NumParallelProcesses { get; set; }

        /// <summary>
        /// Checks to see if the NumParallelProcesses property is set.
        /// </summary>
        internal bool IsSetNumParallelProcesses() => this.NumParallelProcesses.HasValue;

        /// <summary>
        /// Gets and sets the property RecordsProcessed. 
        /// <para>
        ///  The number of records processed in the flow run. 
        /// </para>
        /// </summary>
        public long? RecordsProcessed { get; set; }

        /// <summary>
        /// Checks to see if the RecordsProcessed property is set.
        /// </summary>
        internal bool IsSetRecordsProcessed() => this.RecordsProcessed.HasValue;
    }
}
