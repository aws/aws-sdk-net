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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
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
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Describes the protection on a file system.
    /// </summary>
    public partial class FileSystemProtectionDescription
    {
        private ReplicationOverwriteProtection _replicationOverwriteProtection;

        /// <summary>
        /// Gets and sets the property ReplicationOverwriteProtection. 
        /// <para>
        /// The status of the file system's replication overwrite protection.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> – The file system cannot be used as the destination file system in
        /// a replication configuration. The file system is writeable. Replication overwrite protection
        /// is <c>ENABLED</c> by default. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – The file system can be used as the destination file system in a
        /// replication configuration. The file system is read-only and can only be modified by
        /// EFS replication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPLICATING</c> – The file system is being used as the destination file system
        /// in a replication configuration. The file system is read-only and is modified only
        /// by EFS replication.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the replication configuration is deleted, the file system's replication overwrite
        /// protection is re-enabled, the file system becomes writeable.
        /// </para>
        /// </summary>
        public ReplicationOverwriteProtection ReplicationOverwriteProtection
        {
            get { return this._replicationOverwriteProtection; }
            set { this._replicationOverwriteProtection = value; }
        }

        // Check to see if ReplicationOverwriteProtection property is set
        internal bool IsSetReplicationOverwriteProtection()
        {
            return this._replicationOverwriteProtection != null;
        }

    }
}