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
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBInstance operation.
    /// The DeleteDBInstance action deletes a previously provisioned DB instance. A successful
    /// response from the web service indicates the request was received correctly. When you
    /// delete a DB instance, all automated backups for that instance are deleted and cannot
    /// be recovered. Manual DB snapshots of the DB instance to be deleted are not deleted.
    /// 
    /// 
    ///  
    /// <para>
    ///  If a final DB snapshot is requested the status of the RDS instance will be "deleting"
    /// until the DB snapshot is created. The API action <code>DescribeDBInstance</code> is
    /// used to monitor the status of this operation. The action cannot be canceled or reverted
    /// once submitted. 
    /// </para>
    /// </summary>
    public partial class DeleteDBInstanceRequest : AmazonRDSRequest
    {
        private string _dBInstanceIdentifier;
        private string _finalDBSnapshotIdentifier;
        private bool? _skipFinalSnapshot;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteDBInstanceRequest() { }

        /// <summary>
        /// Instantiates DeleteDBInstanceRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier"> The DB instance identifier for the DB instance to be deleted. This parameter isn't case sensitive.  Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul></param>
        public DeleteDBInstanceRequest(string dbInstanceIdentifier)
        {
            _dBInstanceIdentifier = dbInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        ///  The DB instance identifier for the DB instance to be deleted. This parameter isn't
        /// case sensitive. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First
        /// character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens</li> </ul>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dBInstanceIdentifier; }
            set { this._dBInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dBInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FinalDBSnapshotIdentifier. 
        /// <para>
        ///  The DBSnapshotIdentifier of the new DBSnapshot created when SkipFinalSnapshot is
        /// set to <code>false</code>. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be
        /// a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li>
        /// <li>Cannot be specified when deleting a read replica.</li> </ul>
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
        /// Specify <code>true</code> when deleting a read replica.
        /// </para>
        ///  
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