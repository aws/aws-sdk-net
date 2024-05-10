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
    /// Container for the parameters to the ModifySnapshotCopyRetentionPeriod operation.
    /// Modifies the number of days to retain snapshots in the destination Amazon Web Services
    /// Region after they are copied from the source Amazon Web Services Region. By default,
    /// this operation only changes the retention period of copied automated snapshots. The
    /// retention periods for both new and existing copied automated snapshots are updated
    /// with the new retention period. You can set the manual option to change only the retention
    /// periods of copied manual snapshots. If you set this option, only newly copied manual
    /// snapshots have the new retention period.
    /// </summary>
    public partial class ModifySnapshotCopyRetentionPeriodRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private bool? _manual;
        private int? _retentionPeriod;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster for which you want to change the retention period
        /// for either automated or manual snapshots that are copied to a destination Amazon Web
        /// Services Region.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be the valid name of an existing cluster that has cross-region snapshot
        /// copy enabled.
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
        /// Gets and sets the property Manual. 
        /// <para>
        /// Indicates whether to apply the snapshot retention period to newly copied manual snapshots
        /// instead of automated snapshots.
        /// </para>
        /// </summary>
        public bool? Manual
        {
            get { return this._manual; }
            set { this._manual = value; }
        }

        // Check to see if Manual property is set
        internal bool IsSetManual()
        {
            return this._manual.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The number of days to retain automated snapshots in the destination Amazon Web Services
        /// Region after they are copied from the source Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// By default, this only changes the retention period of copied automated snapshots.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you decrease the retention period for automated snapshots that are copied to a
        /// destination Amazon Web Services Region, Amazon Redshift deletes any existing automated
        /// snapshots that were copied to the destination Amazon Web Services Region and that
        /// fall outside of the new retention period.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be at least 1 and no more than 35 for automated snapshots. 
        /// </para>
        ///  
        /// <para>
        /// If you specify the <c>manual</c> option, only newly copied manual snapshots will have
        /// the new retention period. 
        /// </para>
        ///  
        /// <para>
        /// If you specify the value of -1 newly copied manual snapshots are retained indefinitely.
        /// </para>
        ///  
        /// <para>
        /// Constraints: The number of days must be either -1 or an integer between 1 and 3,653
        /// for manual snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}