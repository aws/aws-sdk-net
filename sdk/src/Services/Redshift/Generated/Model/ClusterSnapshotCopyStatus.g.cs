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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Returns the destination region and retention period that are configured for cross-region
    /// snapshot copy.
    /// </summary>
    public partial class ClusterSnapshotCopyStatus
    {
        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination region that snapshots are automatically copied to when cross-region
        /// snapshot copy is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRegion property is set.
        /// </summary>
        internal bool IsSetDestinationRegion() => this.DestinationRegion != null;

        /// <summary>
        /// Gets and sets the property ManualSnapshotRetentionPeriod. 
        /// <para>
        /// The number of days that automated snapshots are retained in the destination region
        /// after they are copied from a source region. If the value is -1, the manual snapshot
        /// is retained indefinitely. 
        /// </para>
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </summary>
        public int? ManualSnapshotRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the ManualSnapshotRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetManualSnapshotRetentionPeriod() => this.ManualSnapshotRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The number of days that automated snapshots are retained in the destination region
        /// after they are copied from a source region.
        /// </para>
        /// </summary>
        public long? RetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriod property is set.
        /// </summary>
        internal bool IsSetRetentionPeriod() => this.RetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotCopyGrantName. 
        /// <para>
        /// The name of the snapshot copy grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotCopyGrantName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCopyGrantName property is set.
        /// </summary>
        internal bool IsSetSnapshotCopyGrantName() => this.SnapshotCopyGrantName != null;
    }
}
