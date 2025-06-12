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
    /// Container for the parameters to the BatchModifyClusterSnapshots operation.
    /// Modifies the settings for a set of cluster snapshots.
    /// </summary>
    public partial class BatchModifyClusterSnapshotsRequest : AmazonRedshiftRequest
    {
        private bool? _force;
        private int? _manualSnapshotRetentionPeriod;
        private List<string> _snapshotIdentifierList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// A boolean value indicating whether to override an exception if the retention period
        /// has passed. 
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManualSnapshotRetentionPeriod. 
        /// <para>
        /// The number of days that a manual snapshot is retained. If you specify the value -1,
        /// the manual snapshot is retained indefinitely.
        /// </para>
        ///  
        /// <para>
        /// The number must be either -1 or an integer between 1 and 3,653.
        /// </para>
        ///  
        /// <para>
        /// If you decrease the manual snapshot retention period from its current value, existing
        /// manual snapshots that fall outside of the new retention period will return an error.
        /// If you want to suppress the errors and delete the snapshots, use the force option.
        /// 
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
        /// Gets and sets the property SnapshotIdentifierList. 
        /// <para>
        /// A list of snapshot identifiers you want to modify.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SnapshotIdentifierList
        {
            get { return this._snapshotIdentifierList; }
            set { this._snapshotIdentifierList = value; }
        }

        // Check to see if SnapshotIdentifierList property is set
        internal bool IsSetSnapshotIdentifierList()
        {
            return this._snapshotIdentifierList != null && (this._snapshotIdentifierList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}