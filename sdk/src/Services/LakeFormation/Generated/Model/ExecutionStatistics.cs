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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Statistics related to the processing of a query statement.
    /// </summary>
    public partial class ExecutionStatistics
    {
        private long? _averageExecutionTimeMillis;
        private long? _dataScannedBytes;
        private long? _workUnitsExecutedCount;

        /// <summary>
        /// Gets and sets the property AverageExecutionTimeMillis. 
        /// <para>
        /// The average time the request took to be executed.
        /// </para>
        /// </summary>
        public long? AverageExecutionTimeMillis
        {
            get { return this._averageExecutionTimeMillis; }
            set { this._averageExecutionTimeMillis = value; }
        }

        // Check to see if AverageExecutionTimeMillis property is set
        internal bool IsSetAverageExecutionTimeMillis()
        {
            return this._averageExecutionTimeMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataScannedBytes. 
        /// <para>
        /// The amount of data that was scanned in bytes.
        /// </para>
        /// </summary>
        public long? DataScannedBytes
        {
            get { return this._dataScannedBytes; }
            set { this._dataScannedBytes = value; }
        }

        // Check to see if DataScannedBytes property is set
        internal bool IsSetDataScannedBytes()
        {
            return this._dataScannedBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkUnitsExecutedCount. 
        /// <para>
        /// The number of work units executed.
        /// </para>
        /// </summary>
        public long? WorkUnitsExecutedCount
        {
            get { return this._workUnitsExecutedCount; }
            set { this._workUnitsExecutedCount = value; }
        }

        // Check to see if WorkUnitsExecutedCount property is set
        internal bool IsSetWorkUnitsExecutedCount()
        {
            return this._workUnitsExecutedCount.HasValue; 
        }

    }
}