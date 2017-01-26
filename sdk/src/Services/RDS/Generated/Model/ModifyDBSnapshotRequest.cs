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
    /// Container for the parameters to the ModifyDBSnapshot operation.
    /// Updates a manual DB snapshot, which can be encrypted or not encrypted, with a new
    /// engine version. You can update the engine version to either a new major or minor engine
    /// version. 
    /// 
    ///  
    /// <para>
    /// Amazon RDS supports upgrading a MySQL DB snapshot from MySQL 5.1 to MySQL 5.5.
    /// </para>
    /// </summary>
    public partial class ModifyDBSnapshotRequest : AmazonRDSRequest
    {
        private string _dbSnapshotIdentifier;
        private string _engineVersion;

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// The identifier of the DB snapshot to modify.
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

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version to update the DB snapshot to. 
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

    }
}