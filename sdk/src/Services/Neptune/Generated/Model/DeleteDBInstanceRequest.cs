/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
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
    ///  If you request a final DB snapshot the status of the Amazon Neptune DB instance is
    /// <code>deleting</code> until the DB snapshot is created. The API action <code>DescribeDBInstance</code>
    /// is used to monitor the status of this operation. The action can't be canceled or reverted
    /// once submitted. 
    /// </para>
    ///  
    /// <para>
    /// Note that when a DB instance is in a failure state and has a status of <code>failed</code>,
    /// <code>incompatible-restore</code>, or <code>incompatible-network</code>, you can only
    /// delete it when the <code>SkipFinalSnapshot</code> parameter is set to <code>true</code>.
    /// </para>
    ///  
    /// <para>
    /// If the specified DB instance is part of an Amazon Aurora DB cluster, you can't delete
    /// the DB instance if both of the following conditions are true:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The DB cluster is a Read Replica of another Amazon Aurora DB cluster.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The DB instance is the only instance in the DB cluster.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To delete a DB instance in this case, first call the <a>PromoteReadReplicaDBCluster</a>
    /// API action to promote the DB cluster so it's no longer a Read Replica. After the promotion
    /// completes, then call the <code>DeleteDBInstance</code> API action to delete the final
    /// instance in the DB cluster.
    /// </para>
    /// </summary>
    public partial class DeleteDBInstanceRequest : AmazonNeptuneRequest
    {
        private string _dbInstanceIdentifier;
        private string _finalDBSnapshotIdentifier;
        private bool? _skipFinalSnapshot;

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
        /// Gets and sets the property FinalDBSnapshotIdentifier. 
        /// <para>
        ///  The DBSnapshotIdentifier of the new DBSnapshot created when SkipFinalSnapshot is
        /// set to <code>false</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Specifying this parameter and also setting the SkipFinalShapshot parameter to true
        /// results in an error.
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
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be specified when deleting a Read Replica.
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
        ///  Determines whether a final DB snapshot is created before the DB instance is deleted.
        /// If <code>true</code> is specified, no DBSnapshot is created. If <code>false</code>
        /// is specified, a DB snapshot is created before the DB instance is deleted. 
        /// </para>
        ///  
        /// <para>
        /// Note that when a DB instance is in a failure state and has a status of 'failed', 'incompatible-restore',
        /// or 'incompatible-network', it can only be deleted when the SkipFinalSnapshot parameter
        /// is set to "true".
        /// </para>
        ///  
        /// <para>
        /// Specify <code>true</code> when deleting a Read Replica.
        /// </para>
        ///  <note> 
        /// <para>
        /// The FinalDBSnapshotIdentifier parameter must be specified if SkipFinalSnapshot is
        /// <code>false</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
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