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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object representing the progress of a replication backfill, including the total,
    /// completed, and failed replication counts.
    /// </summary>
    public partial class ReplicationBackfillProgress
    {
        /// <summary>
        /// Gets and sets the property CompletedReplicationCount. 
        /// <para>
        /// The number of replications that have completed successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? CompletedReplicationCount { get; set; }

        /// <summary>
        /// Checks to see if the CompletedReplicationCount property is set.
        /// </summary>
        internal bool IsSetCompletedReplicationCount() => this.CompletedReplicationCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailedReplicationCount. 
        /// <para>
        /// The number of replications that have failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? FailedReplicationCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedReplicationCount property is set.
        /// </summary>
        internal bool IsSetFailedReplicationCount() => this.FailedReplicationCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailureCodes. 
        /// <para>
        /// The distinct failure codes for the replications that have failed. Each failure code
        /// appears at most once, regardless of how many replications failed with that code.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> FailureCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureCodes property is set.
        /// </summary>
        internal bool IsSetFailureCodes() => this.FailureCodes != null && (this.FailureCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalReplicationCount. 
        /// <para>
        /// The total number of replications that the backfill will perform. Each image and tag
        /// combination is counted as a single replication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? TotalReplicationCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalReplicationCount property is set.
        /// </summary>
        internal bool IsSetTotalReplicationCount() => this.TotalReplicationCount.HasValue;
    }
}
