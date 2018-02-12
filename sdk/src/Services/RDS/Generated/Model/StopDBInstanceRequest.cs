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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
    /// Container for the parameters to the StopDBInstance operation.
    /// Stops a DB instance. When you stop a DB instance, Amazon RDS retains the DB instance's
    /// metadata, including its endpoint, DB parameter group, and option group membership.
    /// Amazon RDS also retains the transaction logs so you can do a point-in-time restore
    /// if necessary. For more information, see Stopping and Starting a DB instance in the
    /// AWS RDS user guide. 
    /// 
    ///  <note> 
    /// <para>
    /// This command doesn't apply to Aurora MySQL and Aurora PostgreSQL.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StopDBInstanceRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private string _dbSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        ///  The user-supplied instance identifier. 
        /// </para>
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
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        ///  The user-supplied instance identifier of the DB Snapshot created immediately before
        /// the DB instance is stopped. 
        /// </para>
        /// </summary>
        public string DBSnapshotIdentifier
        {
            get { return this._dbSnapshotIdentifier; }
            set { this._dbSnapshotIdentifier = value; }
        }

        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this._dbSnapshotIdentifier != null;
        }

    }
}