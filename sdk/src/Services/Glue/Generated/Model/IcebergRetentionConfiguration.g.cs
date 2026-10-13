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
    /// The configuration for an Iceberg snapshot retention optimizer.
    /// </summary>
    public partial class IcebergRetentionConfiguration
    {
        /// <summary>
        /// Gets and sets the property CleanExpiredFiles. 
        /// <para>
        /// If set to false, snapshots are only deleted from table metadata, and the underlying
        /// data and metadata files are not deleted.
        /// </para>
        /// </summary>
        public bool? CleanExpiredFiles { get; set; }

        /// <summary>
        /// Checks to see if the CleanExpiredFiles property is set.
        /// </summary>
        internal bool IsSetCleanExpiredFiles() => this.CleanExpiredFiles.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfSnapshotsToRetain. 
        /// <para>
        /// The number of Iceberg snapshots to retain within the retention period. If an input
        /// is not provided, the corresponding Iceberg table configuration field will be used
        /// or if not present, the default value 1 will be used.
        /// </para>
        /// </summary>
        public int? NumberOfSnapshotsToRetain { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfSnapshotsToRetain property is set.
        /// </summary>
        internal bool IsSetNumberOfSnapshotsToRetain() => this.NumberOfSnapshotsToRetain.HasValue;

        /// <summary>
        /// Gets and sets the property RunRateInHours. 
        /// <para>
        /// The interval in hours between retention job runs. This parameter controls how frequently
        /// the retention optimizer will run to clean up expired snapshots. The value must be
        /// between 3 and 168 hours (7 days). If an input is not provided, the default value 24
        /// will be used.
        /// </para>
        /// </summary>
        public int? RunRateInHours { get; set; }

        /// <summary>
        /// Checks to see if the RunRateInHours property is set.
        /// </summary>
        internal bool IsSetRunRateInHours() => this.RunRateInHours.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionPeriodInDays. 
        /// <para>
        /// The number of days to retain the Iceberg snapshots. If an input is not provided, the
        /// corresponding Iceberg table configuration field will be used or if not present, the
        /// default value 5 will be used.
        /// </para>
        /// </summary>
        public int? SnapshotRetentionPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotRetentionPeriodInDays property is set.
        /// </summary>
        internal bool IsSetSnapshotRetentionPeriodInDays() => this.SnapshotRetentionPeriodInDays.HasValue;
    }
}
