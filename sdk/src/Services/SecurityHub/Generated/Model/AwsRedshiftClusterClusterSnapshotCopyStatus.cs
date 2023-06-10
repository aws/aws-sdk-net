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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// You can configure Amazon Redshift to copy snapshots for a cluster to another Amazon
    /// Web Services Region. This parameter provides information about a cross-Region snapshot
    /// copy.
    /// </summary>
    public partial class AwsRedshiftClusterClusterSnapshotCopyStatus
    {
        private string _destinationRegion;
        private int? _manualSnapshotRetentionPeriod;
        private int? _retentionPeriod;
        private string _snapshotCopyGrantName;

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination Region that snapshots are automatically copied to when cross-Region
        /// snapshot copy is enabled.
        /// </para>
        /// </summary>
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ManualSnapshotRetentionPeriod. 
        /// <para>
        /// The number of days that manual snapshots are retained in the destination Region after
        /// they are copied from a source Region.
        /// </para>
        ///  
        /// <para>
        /// If the value is <code>-1</code>, then the manual snapshot is retained indefinitely.
        /// </para>
        ///  
        /// <para>
        /// Valid values: Either <code>-1</code> or an integer between 1 and 3,653
        /// </para>
        /// </summary>
        public int ManualSnapshotRetentionPeriod
        {
            get { return this._manualSnapshotRetentionPeriod.GetValueOrDefault(); }
            set { this._manualSnapshotRetentionPeriod = value; }
        }

        // Check to see if ManualSnapshotRetentionPeriod property is set
        internal bool IsSetManualSnapshotRetentionPeriod()
        {
            return this._manualSnapshotRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The number of days to retain automated snapshots in the destination Region after they
        /// are copied from a source Region.
        /// </para>
        /// </summary>
        public int RetentionPeriod
        {
            get { return this._retentionPeriod.GetValueOrDefault(); }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotCopyGrantName. 
        /// <para>
        /// The name of the snapshot copy grant.
        /// </para>
        /// </summary>
        public string SnapshotCopyGrantName
        {
            get { return this._snapshotCopyGrantName; }
            set { this._snapshotCopyGrantName = value; }
        }

        // Check to see if SnapshotCopyGrantName property is set
        internal bool IsSetSnapshotCopyGrantName()
        {
            return this._snapshotCopyGrantName != null;
        }

    }
}