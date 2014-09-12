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
    /// Container for the parameters to the CreateDBSnapshot operation.
    /// Creates a DBSnapshot. The source DBInstance must be in "available" state.
    /// </summary>
    public partial class CreateDBSnapshotRequest : AmazonRDSRequest
    {
        private string _dBInstanceIdentifier;
        private string _dBSnapshotIdentifier;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBSnapshotRequest() { }

        /// <summary>
        /// Instantiates CreateDBSnapshotRequest with the parameterized properties
        /// </summary>
        /// <param name="dbSnapshotIdentifier"> The identifier for the DB snapshot.  Constraints: <ul> <li>Cannot be null, empty, or blank</li> <li>Must contain from 1 to 255 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul> Example: <code>my-snapshot-id</code></param>
        /// <param name="dbInstanceIdentifier"> The DB instance identifier. This is the unique key that identifies a DB instance. This parameter isn't case sensitive.  Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul></param>
        public CreateDBSnapshotRequest(string dbSnapshotIdentifier, string dbInstanceIdentifier)
        {
            _dBSnapshotIdentifier = dbSnapshotIdentifier;
            _dBInstanceIdentifier = dbInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        ///  The DB instance identifier. This is the unique key that identifies a DB instance.
        /// This parameter isn't case sensitive. 
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
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        ///  The identifier for the DB snapshot. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Cannot be null, empty, or blank</li> <li>Must contain from 1 to 255 alphanumeric
        /// characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end
        /// with a hyphen or contain two consecutive hyphens</li> </ul> 
        /// <para>
        /// Example: <code>my-snapshot-id</code>
        /// </para>
        /// </summary>
        public string DBSnapshotIdentifier
        {
            get { return this._dBSnapshotIdentifier; }
            set { this._dBSnapshotIdentifier = value; }
        }

        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this._dBSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}