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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Contains information about tables that are managed by S3 Tables, including replication
    /// information for replica tables.
    /// </summary>
    public partial class ManagedTableInformation
    {
        private ReplicationInformation _replicationInformation;

        /// <summary>
        /// Gets and sets the property ReplicationInformation. 
        /// <para>
        /// If this table is a replica, contains information about the source table from which
        /// it is replicated.
        /// </para>
        /// </summary>
        public ReplicationInformation ReplicationInformation
        {
            get { return this._replicationInformation; }
            set { this._replicationInformation = value; }
        }

        // Check to see if ReplicationInformation property is set
        internal bool IsSetReplicationInformation()
        {
            return this._replicationInformation != null;
        }

    }
}