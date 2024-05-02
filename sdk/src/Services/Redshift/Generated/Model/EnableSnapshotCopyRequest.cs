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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// Container for the parameters to the EnableSnapshotCopy operation.
    /// Enables the automatic copy of snapshots from one region to another region for a specified
    /// cluster.
    /// </summary>
    public partial class EnableSnapshotCopyRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private string _destinationRegion;
        private int? _manualSnapshotRetentionPeriod;
        private int? _retentionPeriod;
        private string _snapshotCopyGrantName;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the source cluster to copy snapshots from.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be the valid name of an existing cluster that does not already have
        /// cross-region snapshot copy enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination Amazon Web Services Region that you want to copy snapshots to.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be the name of a valid Amazon Web Services Region. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#redshift_region">Regions
        /// and Endpoints</a> in the Amazon Web Services General Reference. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// The number of days to retain newly copied snapshots in the destination Amazon Web
        /// Services Region after they are copied from the source Amazon Web Services Region.
        /// If the value is -1, the manual snapshot is retained indefinitely. 
        /// </para>
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </summary>
        public int? ManualSnapshotRetentionPeriod
        {
            get { return this._manualSnapshotRetentionPeriod; }
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
        /// The number of days to retain automated snapshots in the destination region after they
        /// are copied from the source region.
        /// </para>
        ///  
        /// <para>
        /// Default: 7.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be at least 1 and no more than 35.
        /// </para>
        /// </summary>
        public int? RetentionPeriod
        {
            get { return this._retentionPeriod; }
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
        /// The name of the snapshot copy grant to use when snapshots of an Amazon Web Services
        /// KMS-encrypted cluster are copied to the destination region.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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