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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Specifies the end result of the flow run.
    /// </summary>
    public partial class ExecutionResult
    {
        private long? _bytesProcessed;
        private long? _bytesWritten;
        private ErrorInfo _errorInfo;
        private long? _recordsProcessed;

        /// <summary>
        /// Gets and sets the property BytesProcessed. 
        /// <para>
        ///  The total number of bytes processed by the flow run. 
        /// </para>
        /// </summary>
        public long BytesProcessed
        {
            get { return this._bytesProcessed.GetValueOrDefault(); }
            set { this._bytesProcessed = value; }
        }

        // Check to see if BytesProcessed property is set
        internal bool IsSetBytesProcessed()
        {
            return this._bytesProcessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BytesWritten. 
        /// <para>
        ///  The total number of bytes written as a result of the flow run. 
        /// </para>
        /// </summary>
        public long BytesWritten
        {
            get { return this._bytesWritten.GetValueOrDefault(); }
            set { this._bytesWritten = value; }
        }

        // Check to see if BytesWritten property is set
        internal bool IsSetBytesWritten()
        {
            return this._bytesWritten.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        ///  Provides any error message information related to the flow run. 
        /// </para>
        /// </summary>
        public ErrorInfo ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property RecordsProcessed. 
        /// <para>
        ///  The number of records processed in the flow run. 
        /// </para>
        /// </summary>
        public long RecordsProcessed
        {
            get { return this._recordsProcessed.GetValueOrDefault(); }
            set { this._recordsProcessed = value; }
        }

        // Check to see if RecordsProcessed property is set
        internal bool IsSetRecordsProcessed()
        {
            return this._recordsProcessed.HasValue; 
        }

    }
}