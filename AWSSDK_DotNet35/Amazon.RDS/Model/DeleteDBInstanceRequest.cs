/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> The DeleteDBInstance action deletes a previously provisioned DB instance. A successful response from the web service indicates the
    /// request was received correctly. When you delete a DB instance, all automated backups for that instance are deleted and cannot be recovered.
    /// Manual DB snapshots of the DB instance to be deleted are not deleted. </para> <para> If a final DB snapshot is requested the status of the
    /// RDS instance will be "deleting" until the DB snapshot is created. The API action <c>DescribeDBInstance</c> is used to monitor the status of
    /// this operation. The action cannot be canceled or reverted once submitted. </para>
    /// </summary>
    public partial class DeleteDBInstanceRequest : AmazonRDSRequest
    {
        private string dBInstanceIdentifier;
        private bool? skipFinalSnapshot;
        private string finalDBSnapshotIdentifier;


        /// <summary>
        /// The DB instance identifier for the DB instance to be deleted. This parameter isn't case sensitive. Constraints: <ul> <li>Must contain from 1
        /// to 63 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two
        /// consecutive hyphens</li> </ul>
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this.dBInstanceIdentifier != null;
        }

        /// <summary>
        /// Determines whether a final DB snapshot is created before the DB instance is deleted. If <c>true</c> is specified, no DBSnapshot is created.
        /// If <c>false</c> is specified, a DB snapshot is created before the DB instance is deleted. Specify <c>true</c> when deleting a read replica.
        /// <note>The FinalDBSnapshotIdentifier parameter must be specified if SkipFinalSnapshot is <c>false</c>.</note> Default: <c>false</c>
        ///  
        /// </summary>
        public bool SkipFinalSnapshot
        {
            get { return this.skipFinalSnapshot ?? default(bool); }
            set { this.skipFinalSnapshot = value; }
        }

        // Check to see if SkipFinalSnapshot property is set
        internal bool IsSetSkipFinalSnapshot()
        {
            return this.skipFinalSnapshot.HasValue;
        }

        /// <summary>
        /// The DBSnapshotIdentifier of the new DBSnapshot created when SkipFinalSnapshot is set to <c>false</c>. <note> Specifying this parameter and
        /// also setting the SkipFinalShapshot parameter to true results in an error. </note> Constraints: <ul> <li>Must be 1 to 255 alphanumeric
        /// characters</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> <li>Cannot be
        /// specified when deleting a read replica.</li> </ul>
        ///  
        /// </summary>
        public string FinalDBSnapshotIdentifier
        {
            get { return this.finalDBSnapshotIdentifier; }
            set { this.finalDBSnapshotIdentifier = value; }
        }

        // Check to see if FinalDBSnapshotIdentifier property is set
        internal bool IsSetFinalDBSnapshotIdentifier()
        {
            return this.finalDBSnapshotIdentifier != null;
        }

    }
}
    
