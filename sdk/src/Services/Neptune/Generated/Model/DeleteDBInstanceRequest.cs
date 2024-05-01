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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBInstance operation.
    /// The DeleteDBInstance action deletes a previously provisioned DB instance. When you
    /// delete a DB instance, all automated backups for that instance are deleted and can't
    /// be recovered. Manual DB snapshots of the DB instance to be deleted by <c>DeleteDBInstance</c>
    /// are not deleted.
    /// 
    ///  
    /// <para>
    ///  If you request a final DB snapshot the status of the Amazon Neptune DB instance is
    /// <c>deleting</c> until the DB snapshot is created. The API action <c>DescribeDBInstance</c>
    /// is used to monitor the status of this operation. The action can't be canceled or reverted
    /// once submitted.
    /// </para>
    ///  
    /// <para>
    /// Note that when a DB instance is in a failure state and has a status of <c>failed</c>,
    /// <c>incompatible-restore</c>, or <c>incompatible-network</c>, you can only delete it
    /// when the <c>SkipFinalSnapshot</c> parameter is set to <c>true</c>.
    /// </para>
    ///  
    /// <para>
    /// You can't delete a DB instance if it is the only instance in the DB cluster, or if
    /// it has deletion protection enabled.
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
        /// Gets and sets the property FinalDBSnapshotIdentifier. 
        /// <para>
        ///  The DBSnapshotIdentifier of the new DBSnapshot created when SkipFinalSnapshot is
        /// set to <c>false</c>.
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
        /// If <c>true</c> is specified, no DBSnapshot is created. If <c>false</c> is specified,
        /// a DB snapshot is created before the DB instance is deleted.
        /// </para>
        ///  
        /// <para>
        /// Note that when a DB instance is in a failure state and has a status of 'failed', 'incompatible-restore',
        /// or 'incompatible-network', it can only be deleted when the SkipFinalSnapshot parameter
        /// is set to "true".
        /// </para>
        ///  
        /// <para>
        /// Specify <c>true</c> when deleting a Read Replica.
        /// </para>
        ///  <note> 
        /// <para>
        /// The FinalDBSnapshotIdentifier parameter must be specified if SkipFinalSnapshot is
        /// <c>false</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>false</c> 
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