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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// You can configure Amazon Redshift to copy snapshots for a cluster to another Amazon
    /// Web Services Region. This parameter provides information about a cross-Region snapshot
    /// copy.
    /// </summary>
    public partial class AwsRedshiftClusterClusterSnapshotCopyStatus
    {
        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination Region that snapshots are automatically copied to when cross-Region
        /// snapshot copy is enabled.
        /// </para>
        /// </summary>
        public string DestinationRegion { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRegion property is set.
        /// </summary>
        internal bool IsSetDestinationRegion() => this.DestinationRegion != null;

        /// <summary>
        /// Gets and sets the property ManualSnapshotRetentionPeriod. 
        /// <para>
        /// The number of days that manual snapshots are retained in the destination Region after
        /// they are copied from a source Region.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>-1</c>, then the manual snapshot is retained indefinitely.
        /// </para>
        ///  
        /// <para>
        /// Valid values: Either <c>-1</c> or an integer between 1 and 3,653
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
        /// The number of days to retain automated snapshots in the destination Region after they
        /// are copied from a source Region.
        /// </para>
        /// </summary>
        public int? RetentionPeriod { get; set; }

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
        public string SnapshotCopyGrantName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCopyGrantName property is set.
        /// </summary>
        internal bool IsSetSnapshotCopyGrantName() => this.SnapshotCopyGrantName != null;
    }
}
