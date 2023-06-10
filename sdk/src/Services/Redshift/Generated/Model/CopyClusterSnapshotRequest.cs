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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CopyClusterSnapshot operation.
    /// Copies the specified automated cluster snapshot to a new manual cluster snapshot.
    /// The source must be an automated snapshot and it must be in the available state.
    /// 
    ///  
    /// <para>
    /// When you delete a cluster, Amazon Redshift deletes any automated snapshots of the
    /// cluster. Also, when the retention period of the snapshot expires, Amazon Redshift
    /// automatically deletes it. If you want to keep an automated snapshot for a longer period,
    /// you can make a manual copy of the snapshot. Manual snapshots are retained until you
    /// delete them.
    /// </para>
    ///  
    /// <para>
    ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
    /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class CopyClusterSnapshotRequest : AmazonRedshiftRequest
    {
        private int? _manualSnapshotRetentionPeriod;
        private string _sourceSnapshotClusterIdentifier;
        private string _sourceSnapshotIdentifier;
        private string _targetSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property ManualSnapshotRetentionPeriod. 
        /// <para>
        /// The number of days that a manual snapshot is retained. If the value is -1, the manual
        /// snapshot is retained indefinitely. 
        /// </para>
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        ///  
        /// <para>
        /// The default value is -1.
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
        /// Gets and sets the property SourceSnapshotClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster the source snapshot was created from. This parameter
        /// is required if your IAM user or role has a policy containing a snapshot resource element
        /// that specifies anything other than * for the cluster name.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be the identifier for a valid cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SourceSnapshotClusterIdentifier
        {
            get { return this._sourceSnapshotClusterIdentifier; }
            set { this._sourceSnapshotClusterIdentifier = value; }
        }

        // Check to see if SourceSnapshotClusterIdentifier property is set
        internal bool IsSetSourceSnapshotClusterIdentifier()
        {
            return this._sourceSnapshotClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotIdentifier. 
        /// <para>
        /// The identifier for the source snapshot.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be the identifier for a valid automated snapshot whose state is <code>available</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string SourceSnapshotIdentifier
        {
            get { return this._sourceSnapshotIdentifier; }
            set { this._sourceSnapshotIdentifier = value; }
        }

        // Check to see if SourceSnapshotIdentifier property is set
        internal bool IsSetSourceSnapshotIdentifier()
        {
            return this._sourceSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TargetSnapshotIdentifier. 
        /// <para>
        /// The identifier given to the new manual snapshot.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Cannot be null, empty, or blank.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 255 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be unique for the Amazon Web Services account that is making the request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string TargetSnapshotIdentifier
        {
            get { return this._targetSnapshotIdentifier; }
            set { this._targetSnapshotIdentifier = value; }
        }

        // Check to see if TargetSnapshotIdentifier property is set
        internal bool IsSetTargetSnapshotIdentifier()
        {
            return this._targetSnapshotIdentifier != null;
        }

    }
}