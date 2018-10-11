/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// The amount of data scanned during the query execution and the amount of time that
    /// it took to execute, and the type of statement that was run.
    /// </summary>
    public partial class QueryExecutionStatistics
    {
        private long? _dataScannedInBytes;
        private long? _engineExecutionTimeInMillis;

        /// <summary>
        /// Gets and sets the property DataScannedInBytes. 
        /// <para>
        /// The number of bytes in the data that was queried.
        /// </para>
        /// </summary>
        public long DataScannedInBytes
        {
            get { return this._dataScannedInBytes.GetValueOrDefault(); }
            set { this._dataScannedInBytes = value; }
        }

        // Check to see if DataScannedInBytes property is set
        internal bool IsSetDataScannedInBytes()
        {
            return this._dataScannedInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineExecutionTimeInMillis. 
        /// <para>
        /// The number of milliseconds that the query took to execute.
        /// </para>
        /// </summary>
        public long EngineExecutionTimeInMillis
        {
            get { return this._engineExecutionTimeInMillis.GetValueOrDefault(); }
            set { this._engineExecutionTimeInMillis = value; }
        }

        // Check to see if EngineExecutionTimeInMillis property is set
        internal bool IsSetEngineExecutionTimeInMillis()
        {
            return this._engineExecutionTimeInMillis.HasValue; 
        }

    }
}