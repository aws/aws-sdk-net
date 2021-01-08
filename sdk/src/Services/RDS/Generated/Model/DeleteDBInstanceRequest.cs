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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBInstance operation.
    /// The DeleteDBInstance action deletes a previously provisioned DB instance. When you
    /// delete a DB instance, all automated backups for that instance are deleted and can't
    /// be recovered. Manual DB snapshots of the DB instance to be deleted by <code>DeleteDBInstance</code>
    /// are not deleted.
    /// 
    ///  
    /// <para>
    ///  If you request a final DB snapshot the status of the Amazon RDS DB instance is <code>deleting</code>
    /// until the DB snapshot is created. The API action <code>DescribeDBInstance</code> is
    /// used to monitor the status of this operation. The action can't be canceled or reverted
    /// once submitted. 
    /// </para>
    ///  
    /// <para>
    /// When a DB instance is in a failure state and has a status of <code>failed</code>,
    /// <code>incompatible-restore</code>, or <code>incompatible-network</code>, you can only
    /// delete it when you skip creation of the final snapshot with the <code>SkipFinalSnapshot</code>
    /// parameter.
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
    /// To delete a DB instance in this case, first call the <code>PromoteReadReplicaDBCluster</code>
    /// API action to promote the DB cluster so it's no longer a read replica. After the promotion
    /// completes, then call the <code>DeleteDBInstance</code> API action to delete the final
    /// instance in the DB cluster.
    /// </para>
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
        /// A value that indicates whether to remove automated backups immediately after the DB
        /// instance is deleted. This parameter isn't case-sensitive. The default is to remove
        /// automated backups immediately after the DB instance is deleted.
        /// </para>
        /// </summary>
        public bool DeleteAutomatedBackups
        {
            get { return this._deleteAutomatedBackups.GetValueOrDefault(); }
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
        ///  The <code>DBSnapshotIdentifier</code> of the new <code>DBSnapshot</code> created
        /// when the <code>SkipFinalSnapshot</code> parameter is disabled. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Specifying this parameter and also specifying to skip final DB snapshot creation in
        /// SkipFinalShapshot results in an error.
        /// </para>
        ///  </note> 
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
        /// A value that indicates whether to skip the creation of a final DB snapshot before
        /// the DB instance is deleted. If skip is specified, no DB snapshot is created. If skip
        /// isn't specified, a DB snapshot is created before the DB instance is deleted. By default,
        /// skip isn't specified, and the DB snapshot is created.
        /// </para>
        ///  
        /// <para>
        /// When a DB instance is in a failure state and has a status of 'failed', 'incompatible-restore',
        /// or 'incompatible-network', it can only be deleted when skip is specified.
        /// </para>
        ///  
        /// <para>
        /// Specify skip when deleting a read replica.
        /// </para>
        ///  <note> 
        /// <para>
        /// The FinalDBSnapshotIdentifier parameter must be specified if skip isn't specified.
        /// </para>
        ///  </note>
        /// </summary>
        public bool SkipFinalSnapshot
        {
            get { return this._skipFinalSnapshot.GetValueOrDefault(); }
            set { this._skipFinalSnapshot = value; }
        }

        // Check to see if SkipFinalSnapshot property is set
        internal bool IsSetSkipFinalSnapshot()
        {
            return this._skipFinalSnapshot.HasValue; 
        }

    }
}