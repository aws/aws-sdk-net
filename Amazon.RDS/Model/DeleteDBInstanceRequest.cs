/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> The DeleteDBInstance API deletes a previously provisioned RDS
    /// instance. A successful response from the web service indicates the
    /// request was received correctly. If a final DBSnapshot is requested the
    /// status of the RDS instance will be "deleting" until the DBSnapshot is
    /// created. DescribeDBInstance is used to monitor the status of this
    /// operation. This cannot be canceled or reverted once submitted. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBInstance"/>
    public class DeleteDBInstanceRequest : AmazonWebServiceRequest
    {
        private string dBInstanceIdentifier;
        private bool? skipFinalSnapshot;
        private string finalDBSnapshotIdentifier;

        /// <summary>
        /// The DB Instance identifier for the DB Instance to be deleted. This
        /// parameter isn't case sensitive.
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
        }

        /// <summary>
        /// Sets the DBInstanceIdentifier property
        /// </summary>
        /// <param name="dBInstanceIdentifier">The value to set for the DBInstanceIdentifier property </param>
        /// <returns>this instance</returns>
        public DeleteDBInstanceRequest WithDBInstanceIdentifier(string dBInstanceIdentifier)
        {
            this.dBInstanceIdentifier = dBInstanceIdentifier;
            return this;
        }
            
        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this.dBInstanceIdentifier != null;       
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public bool SkipFinalSnapshot
        {
            get { return this.skipFinalSnapshot ?? default(bool); }
            set { this.skipFinalSnapshot = value; }
        }

        /// <summary>
        /// Sets the SkipFinalSnapshot property
        /// </summary>
        /// <param name="skipFinalSnapshot">The value to set for the SkipFinalSnapshot property </param>
        /// <returns>this instance</returns>
        public DeleteDBInstanceRequest WithSkipFinalSnapshot(bool skipFinalSnapshot)
        {
            this.skipFinalSnapshot = skipFinalSnapshot;
            return this;
        }
            
        // Check to see if SkipFinalSnapshot property is set
        internal bool IsSetSkipFinalSnapshot()
        {
            return this.skipFinalSnapshot.HasValue;         
        }

        /// <summary>
        /// Determines whether a final DB Snapshot is created before the DB
        /// Instance is deleted. If <i>true</i>, no DBSnapshot is created. If
        /// <i>false</i>, a DB Snapshot is created before the DB Instance is
        /// deleted.
        ///  
        /// </summary>
        public string FinalDBSnapshotIdentifier
        {
            get { return this.finalDBSnapshotIdentifier; }
            set { this.finalDBSnapshotIdentifier = value; }
        }

        /// <summary>
        /// Sets the FinalDBSnapshotIdentifier property
        /// </summary>
        /// <param name="finalDBSnapshotIdentifier">The value to set for the FinalDBSnapshotIdentifier property </param>
        /// <returns>this instance</returns>
        public DeleteDBInstanceRequest WithFinalDBSnapshotIdentifier(string finalDBSnapshotIdentifier)
        {
            this.finalDBSnapshotIdentifier = finalDBSnapshotIdentifier;
            return this;
        }
            
        // Check to see if FinalDBSnapshotIdentifier property is set
        internal bool IsSetFinalDBSnapshotIdentifier()
        {
            return this.finalDBSnapshotIdentifier != null;      
        }
    }
}
    
