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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Detailed information about the attributes that are associated with a cluster snapshot.
    /// </summary>
    public partial class DBClusterSnapshotAttributesResult
    {
        private List<DBClusterSnapshotAttribute> _dbClusterSnapshotAttributes = new List<DBClusterSnapshotAttribute>();
        private string _dbClusterSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotAttributes. 
        /// <para>
        /// The list of attributes and values for the cluster snapshot.
        /// </para>
        /// </summary>
        public List<DBClusterSnapshotAttribute> DBClusterSnapshotAttributes
        {
            get { return this._dbClusterSnapshotAttributes; }
            set { this._dbClusterSnapshotAttributes = value; }
        }

        // Check to see if DBClusterSnapshotAttributes property is set
        internal bool IsSetDBClusterSnapshotAttributes()
        {
            return this._dbClusterSnapshotAttributes != null && this._dbClusterSnapshotAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotIdentifier. 
        /// <para>
        /// The identifier of the cluster snapshot that the attributes apply to.
        /// </para>
        /// </summary>
        public string DBClusterSnapshotIdentifier
        {
            get { return this._dbClusterSnapshotIdentifier; }
            set { this._dbClusterSnapshotIdentifier = value; }
        }

        // Check to see if DBClusterSnapshotIdentifier property is set
        internal bool IsSetDBClusterSnapshotIdentifier()
        {
            return this._dbClusterSnapshotIdentifier != null;
        }

    }
}