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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Statistics related to the processing of a query statement.
    /// </summary>
    public partial class PlanningStatistics
    {
        /// <summary>
        /// Gets and sets the property EstimatedDataToScanBytes. 
        /// <para>
        /// An estimate of the data that was scanned in bytes.
        /// </para>
        /// </summary>
        public long? EstimatedDataToScanBytes { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedDataToScanBytes property is set.
        /// </summary>
        internal bool IsSetEstimatedDataToScanBytes() => this.EstimatedDataToScanBytes.HasValue;

        /// <summary>
        /// Gets and sets the property PlanningTimeMillis. 
        /// <para>
        /// The time that it took to process the request.
        /// </para>
        /// </summary>
        public long? PlanningTimeMillis { get; set; }

        /// <summary>
        /// Checks to see if the PlanningTimeMillis property is set.
        /// </summary>
        internal bool IsSetPlanningTimeMillis() => this.PlanningTimeMillis.HasValue;

        /// <summary>
        /// Gets and sets the property QueueTimeMillis. 
        /// <para>
        /// The time the request was in queue to be processed.
        /// </para>
        /// </summary>
        public long? QueueTimeMillis { get; set; }

        /// <summary>
        /// Checks to see if the QueueTimeMillis property is set.
        /// </summary>
        internal bool IsSetQueueTimeMillis() => this.QueueTimeMillis.HasValue;

        /// <summary>
        /// Gets and sets the property WorkUnitsGeneratedCount. 
        /// <para>
        /// The number of work units generated.
        /// </para>
        /// </summary>
        public long? WorkUnitsGeneratedCount { get; set; }

        /// <summary>
        /// Checks to see if the WorkUnitsGeneratedCount property is set.
        /// </summary>
        internal bool IsSetWorkUnitsGeneratedCount() => this.WorkUnitsGeneratedCount.HasValue;
    }
}
