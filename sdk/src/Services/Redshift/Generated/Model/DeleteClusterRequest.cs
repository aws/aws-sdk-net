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
    /// Container for the parameters to the DeleteCluster operation.
    /// Deletes a previously provisioned cluster without its final snapshot being created.
    /// A successful response from the web service indicates that the request was received
    /// correctly. Use <a>DescribeClusters</a> to monitor the status of the deletion. The
    /// delete operation cannot be canceled or reverted once submitted. For more information
    /// about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
    /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// 
    ///  
    /// <para>
    /// If you want to shut down the cluster and retain it for future use, set <i>SkipFinalClusterSnapshot</i>
    /// to <c>false</c> and specify a name for <i>FinalClusterSnapshotIdentifier</i>. You
    /// can later restore this snapshot to resume using the cluster. If a final cluster snapshot
    /// is requested, the status of the cluster will be "final-snapshot" while the snapshot
    /// is being taken, then it's "deleting" once Amazon Redshift begins deleting the cluster.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
    /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteClusterRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private string _finalClusterSnapshotIdentifier;
        private int? _finalClusterSnapshotRetentionPeriod;
        private bool? _skipFinalClusterSnapshot;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster to be deleted.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain lowercase characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property FinalClusterSnapshotIdentifier. 
        /// <para>
        /// The identifier of the final snapshot that is to be created immediately before deleting
        /// the cluster. If this parameter is provided, <i>SkipFinalClusterSnapshot</i> must be
        /// <c>false</c>. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 alphanumeric characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string FinalClusterSnapshotIdentifier
        {
            get { return this._finalClusterSnapshotIdentifier; }
            set { this._finalClusterSnapshotIdentifier = value; }
        }

        // Check to see if FinalClusterSnapshotIdentifier property is set
        internal bool IsSetFinalClusterSnapshotIdentifier()
        {
            return this._finalClusterSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FinalClusterSnapshotRetentionPeriod. 
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
        public int? FinalClusterSnapshotRetentionPeriod
        {
            get { return this._finalClusterSnapshotRetentionPeriod; }
            set { this._finalClusterSnapshotRetentionPeriod = value; }
        }

        // Check to see if FinalClusterSnapshotRetentionPeriod property is set
        internal bool IsSetFinalClusterSnapshotRetentionPeriod()
        {
            return this._finalClusterSnapshotRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SkipFinalClusterSnapshot. 
        /// <para>
        /// Determines whether a final snapshot of the cluster is created before Amazon Redshift
        /// deletes the cluster. If <c>true</c>, a final cluster snapshot is not created. If <c>false</c>,
        /// a final cluster snapshot is created before the cluster is deleted. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <i>FinalClusterSnapshotIdentifier</i> parameter must be specified if <i>SkipFinalClusterSnapshot</i>
        /// is <c>false</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? SkipFinalClusterSnapshot
        {
            get { return this._skipFinalClusterSnapshot; }
            set { this._skipFinalClusterSnapshot = value; }
        }

        // Check to see if SkipFinalClusterSnapshot property is set
        internal bool IsSetSkipFinalClusterSnapshot()
        {
            return this._skipFinalClusterSnapshot.HasValue; 
        }

    }
}