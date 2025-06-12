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
    /// Container for the parameters to the CreateClusterSnapshot operation.
    /// Creates a manual snapshot of the specified cluster. The cluster must be in the <c>available</c>
    /// state. 
    /// 
    ///  
    /// <para>
    ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
    /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateClusterSnapshotRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private int? _manualSnapshotRetentionPeriod;
        private string _snapshotIdentifier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier for which you want a snapshot.
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
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// A unique identifier for the snapshot that you are requesting. This identifier must
        /// be unique for all snapshots within the Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Cannot be null, empty, or blank
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 255 alphanumeric characters or hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-snapshot-id</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string SnapshotIdentifier
        {
            get { return this._snapshotIdentifier; }
            set { this._snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this._snapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}