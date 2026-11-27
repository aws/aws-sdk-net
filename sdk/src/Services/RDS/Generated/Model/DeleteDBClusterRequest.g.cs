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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBCluster operation. The DeleteDBCluster
    /// action deletes a previously provisioned DB cluster. When you delete a DB cluster,
    /// all automated backups for that DB cluster are deleted and can't be recovered. Manual
    /// DB cluster snapshots of the specified DB cluster are not deleted. <para> If you're
    /// deleting a Multi-AZ DB cluster with read replicas, all cluster members are terminated
    /// and read replicas are promoted to standalone instances. </para> <para> To delete an
    /// Amazon Aurora DB cluster and all of its DB instances in a single call, set <c>DeleteDBInstances</c>
    /// to <c>true</c>. Otherwise, delete each DB instance in the DB cluster before you delete
    /// the DB cluster. </para> <para> For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>. </para> <para>
    /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
    /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>. </para>
    /// </summary>
    public partial class DeleteDBClusterRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier for the DB cluster to be deleted. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match an existing DBClusterIdentifier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DeleteAutomatedBackups. 
        /// <para>
        /// Specifies whether to remove automated backups immediately after the DB cluster is
        /// deleted. This parameter isn't case-sensitive. The default is to remove automated backups
        /// immediately after the DB cluster is deleted, unless the Amazon Web Services Backup
        /// policy specifies a point-in-time restore rule.
        /// </para>
        /// </summary>
        public bool? DeleteAutomatedBackups { get; set; }

        /// <summary>
        /// Checks to see if the DeleteAutomatedBackups property is set.
        /// </summary>
        internal bool IsSetDeleteAutomatedBackups() => this.DeleteAutomatedBackups.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteDBInstances. 
        /// <para>
        /// Specifies whether to delete all DB instances in the DB cluster together with the DB
        /// cluster. If you set this value to <c>true</c>, RDS deletes every DB instance in the
        /// DB cluster and then deletes the DB cluster. You don't need to call <c>DeleteDBInstance</c>
        /// for each DB instance first. If you set this value to <c>false</c> or don't specify
        /// it, RDS deletes the DB cluster only after you delete each of its DB instances.
        /// </para>
        ///  
        /// <para>
        /// You must have permission to call <c>DeleteDBInstance</c> on every DB instance in the
        /// DB cluster. If RDS can't delete a DB instance in the DB cluster, the request fails
        /// and RDS doesn't delete the DB cluster or any of its DB instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't specify this parameter for a DB cluster that is a member of an Aurora global
        /// database. Remove the DB cluster from the global database first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't specify this parameter for an Aurora Limitless Database DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deletion protection must be turned off for the DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No DB instance in the DB cluster can be in the <c>deleting</c> state or be switching
        /// over, be the blue DB instance of an active blue/green deployment, or have an active
        /// zero-ETL integration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No DB instance in the DB cluster can be the source of an Aurora read replica DB cluster,
        /// or have a read replica that is being created or a cross-Region read replica that is
        /// being restored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The DB cluster can't be in the <c>stopping</c> state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the DB cluster doesn't contain any DB instances, RDS deletes the DB cluster the
        /// same way as when you don't specify this parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora MySQL and Aurora PostgreSQL DB clusters only
        /// </para>
        /// </summary>
        public bool? DeleteDBInstances { get; set; }

        /// <summary>
        /// Checks to see if the DeleteDBInstances property is set.
        /// </summary>
        internal bool IsSetDeleteDBInstances() => this.DeleteDBInstances.HasValue;

        /// <summary>
        /// Gets and sets the property FinalDBSnapshotIdentifier. 
        /// <para>
        /// The DB cluster snapshot identifier of the new DB cluster snapshot created when <c>SkipFinalSnapshot</c>
        /// is disabled.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify this parameter and also skip the creation of a final DB cluster snapshot
        /// with the <c>SkipFinalShapshot</c> parameter, the request results in an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FinalDBSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FinalDBSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetFinalDBSnapshotIdentifier() => this.FinalDBSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property SkipFinalSnapshot. 
        /// <para>
        /// Specifies whether to skip the creation of a final DB cluster snapshot before RDS deletes
        /// the DB cluster. If you set this value to <c>true</c>, RDS doesn't create a final DB
        /// cluster snapshot. If you set this value to <c>false</c> or don't specify it, RDS creates
        /// a DB cluster snapshot before it deletes the DB cluster. By default, this parameter
        /// is disabled, so RDS creates a final DB cluster snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>SkipFinalSnapshot</c> is disabled, you must specify a value for the <c>FinalDBSnapshotIdentifier</c>
        /// parameter.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? SkipFinalSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the SkipFinalSnapshot property is set.
        /// </summary>
        internal bool IsSetSkipFinalSnapshot() => this.SkipFinalSnapshot.HasValue;
    }
}
