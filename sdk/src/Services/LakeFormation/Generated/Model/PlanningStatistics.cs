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
    public partial class PlanningStatistics
    {
        private long? _estimatedDataToScanBytes;
        private long? _planningTimeMillis;
        private long? _queueTimeMillis;
        private long? _workUnitsGeneratedCount;

        /// <summary>
        /// Gets and sets the property EstimatedDataToScanBytes. 
        /// <para>
        /// An estimate of the data that was scanned in bytes.
        /// </para>
        /// </summary>
        public long? EstimatedDataToScanBytes
        {
            get { return this._estimatedDataToScanBytes; }
            set { this._estimatedDataToScanBytes = value; }
        }

        // Check to see if EstimatedDataToScanBytes property is set
        internal bool IsSetEstimatedDataToScanBytes()
        {
            return this._estimatedDataToScanBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlanningTimeMillis. 
        /// <para>
        /// The time that it took to process the request.
        /// </para>
        /// </summary>
        public long? PlanningTimeMillis
        {
            get { return this._planningTimeMillis; }
            set { this._planningTimeMillis = value; }
        }

        // Check to see if PlanningTimeMillis property is set
        internal bool IsSetPlanningTimeMillis()
        {
            return this._planningTimeMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueueTimeMillis. 
        /// <para>
        /// The time the request was in queue to be processed.
        /// </para>
        /// </summary>
        public long? QueueTimeMillis
        {
            get { return this._queueTimeMillis; }
            set { this._queueTimeMillis = value; }
        }

        // Check to see if QueueTimeMillis property is set
        internal bool IsSetQueueTimeMillis()
        {
            return this._queueTimeMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkUnitsGeneratedCount. 
        /// <para>
        /// The number of work units generated.
        /// </para>
        /// </summary>
        public long? WorkUnitsGeneratedCount
        {
            get { return this._workUnitsGeneratedCount; }
            set { this._workUnitsGeneratedCount = value; }
        }

        // Check to see if WorkUnitsGeneratedCount property is set
        internal bool IsSetWorkUnitsGeneratedCount()
        {
            return this._workUnitsGeneratedCount.HasValue; 
        }

    }
}