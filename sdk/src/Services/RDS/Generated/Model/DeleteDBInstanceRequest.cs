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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
    /// Container for the parameters to the DeleteDBInstance operation.
    /// Deletes a previously provisioned DB instance. When you delete a DB instance, all automated
    /// backups for that instance are deleted and can't be recovered. However, manual DB snapshots
    /// of the DB instance aren't deleted.
    /// 
    ///  
    /// <para>
    /// If you request a final DB snapshot, the status of the Amazon RDS DB instance is <c>deleting</c>
    /// until the DB snapshot is created. This operation can't be canceled or reverted after
    /// it begins. To monitor the status of this operation, use <c>DescribeDBInstance</c>.
    /// </para>
    ///  
    /// <para>
    /// When a DB instance is in a failure state and has a status of <c>failed</c>, <c>incompatible-restore</c>,
    /// or <c>incompatible-network</c>, you can only delete it when you skip creation of the
    /// final snapshot with the <c>SkipFinalSnapshot</c> parameter.
    /// </para>
    ///  
    /// <para>
    /// If the specified DB instance is part of an Amazon Aurora DB cluster, you can't delete
    /// the DB instance if both of the following conditions are true:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The DB cluster is a read replica of another Amazon Aurora DB cluster.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The DB instance is the only instance in the DB cluster.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To delete a DB instance in this case, first use the <c>PromoteReadReplicaDBCluster</c>
    /// operation to promote the DB cluster so that it's no longer a read replica. After the
    /// promotion completes, use the <c>DeleteDBInstance</c> operation to delete the final
    /// instance in the DB cluster.
    /// </para>
    ///  <important> 
    /// <para>
    /// For RDS Custom DB instances, deleting the DB instance permanently deletes the EC2
    /// instance and the associated EBS volumes. Make sure that you don't terminate or delete
    /// these resources before you delete the DB instance. Otherwise, deleting the DB instance
    /// and creation of the final snapshot might fail.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteDBInstanceRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private bool? _deleteAutomatedBackups;
        private string _finalDBSnapshotIdentifier;
        private bool? _skipFinalSnapshot;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteDBInstanceRequest() { }

        /// <summary>
        /// Instantiates DeleteDBInstanceRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier">The DB instance identifier for the DB instance to be deleted. This parameter isn't case-sensitive. Constraints: <ul> <li> Must match the name of an existing DB instance. </li> </ul></param>
        public DeleteDBInstanceRequest(string dbInstanceIdentifier)
        {
            _dbInstanceIdentifier = dbInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The DB instance identifier for the DB instance to be deleted. This parameter isn't
        /// case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the name of an existing DB instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteAutomatedBackups. 
        /// <para>
        /// Specifies whether to remove automated backups immediately after the DB instance is
        /// deleted. This parameter isn't case-sensitive. The default is to remove automated backups
        /// immediately after the DB instance is deleted.
        /// </para>
        /// </summary>
        public bool? DeleteAutomatedBackups
        {
            get { return this._deleteAutomatedBackups; }
            set { this._deleteAutomatedBackups = value; }
        }

        // Check to see if DeleteAutomatedBackups property is set
        internal bool IsSetDeleteAutomatedBackups()
        {
            return this._deleteAutomatedBackups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FinalDBSnapshotIdentifier. 
        /// <para>
        /// The <c>DBSnapshotIdentifier</c> of the new <c>DBSnapshot</c> created when the <c>SkipFinalSnapshot</c>
        /// parameter is disabled.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you enable this parameter and also enable SkipFinalShapshot, the command results
        /// in an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 letters or numbers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified when deleting a read replica.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FinalDBSnapshotIdentifier
        {
            get { return this._finalDBSnapshotIdentifier; }
            set { this._finalDBSnapshotIdentifier = value; }
        }

        // Check to see if FinalDBSnapshotIdentifier property is set
        internal bool IsSetFinalDBSnapshotIdentifier()
        {
            return this._finalDBSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SkipFinalSnapshot. 
        /// <para>
        /// Specifies whether to skip the creation of a final DB snapshot before deleting the
        /// instance. If you enable this parameter, RDS doesn't create a DB snapshot. If you don't
        /// enable this parameter, RDS creates a DB snapshot before the DB instance is deleted.
        /// By default, skip isn't enabled, and the DB snapshot is created.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't enable this parameter, you must specify the <c>FinalDBSnapshotIdentifier</c>
        /// parameter.
        /// </para>
        ///  </note> 
        /// <para>
        /// When a DB instance is in a failure state and has a status of <c>failed</c>, <c>incompatible-restore</c>,
        /// or <c>incompatible-network</c>, RDS can delete the instance only if you enable this
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// If you delete a read replica or an RDS Custom instance, you must enable this setting.
        /// </para>
        ///  
        /// <para>
        /// This setting is required for RDS Custom.
        /// </para>
        /// </summary>
        public bool? SkipFinalSnapshot
        {
            get { return this._skipFinalSnapshot; }
            set { this._skipFinalSnapshot = value; }
        }

        // Check to see if SkipFinalSnapshot property is set
        internal bool IsSetSkipFinalSnapshot()
        {
            return this._skipFinalSnapshot.HasValue; 
        }

    }
}