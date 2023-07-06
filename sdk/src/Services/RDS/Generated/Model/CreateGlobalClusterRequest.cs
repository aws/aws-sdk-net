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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGlobalCluster operation.
    /// Creates an Aurora global database spread across multiple Amazon Web Services Regions.
    /// The global database contains a single primary cluster with read-write capability,
    /// and a read-only secondary cluster that receives data from the primary cluster through
    /// high-speed replication performed by the Aurora storage subsystem.
    /// 
    ///  
    /// <para>
    /// You can create a global database that is initially empty, and then add a primary cluster
    /// and a secondary cluster to it. Or you can specify an existing Aurora cluster during
    /// the create operation, and this cluster becomes the primary cluster of the global database.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation applies only to Aurora DB clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateGlobalClusterRequest : AmazonRDSRequest
    {
        private string _databaseName;
        private bool? _deletionProtection;
        private string _engine;
        private string _engineVersion;
        private string _globalClusterIdentifier;
        private string _sourceDBClusterIdentifier;
        private bool? _storageEncrypted;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name for your database of up to 64 alphanumeric characters. If you don't specify
        /// a name, Amazon Aurora doesn't create a database in the global database cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be specified if <code>SourceDBClusterIdentifier</code> is specified. In this
        /// case, Amazon Aurora uses the database name from the source DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether to enable deletion protection for the new global database cluster.
        /// The global database can't be deleted when deletion protection is enabled.
        /// </para>
        /// </summary>
        public bool DeletionProtection
        {
            get { return this._deletionProtection.GetValueOrDefault(); }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine to use for this global database cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>aurora-mysql | aurora-postgresql</code> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be specified if <code>SourceDBClusterIdentifier</code> is specified. In this
        /// case, Amazon Aurora uses the engine of the source DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version to use for this global database cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be specified if <code>SourceDBClusterIdentifier</code> is specified. In this
        /// case, Amazon Aurora uses the engine version of the source DB cluster.
        /// </para>
        ///  </li> </ul>
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

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The cluster identifier for this global database cluster. This parameter is stored
        /// as a lowercase string.
        /// </para>
        /// </summary>
        public string GlobalClusterIdentifier
        {
            get { return this._globalClusterIdentifier; }
            set { this._globalClusterIdentifier = value; }
        }

        // Check to see if GlobalClusterIdentifier property is set
        internal bool IsSetGlobalClusterIdentifier()
        {
            return this._globalClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDBClusterIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) to use as the primary cluster of the global database.
        /// </para>
        ///  
        /// <para>
        /// If you provide a value for this parameter, don't specify values for the following
        /// settings because Amazon Aurora uses the values from the specified source DB cluster:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatabaseName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Engine</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EngineVersion</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StorageEncrypted</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceDBClusterIdentifier
        {
            get { return this._sourceDBClusterIdentifier; }
            set { this._sourceDBClusterIdentifier = value; }
        }

        // Check to see if SourceDBClusterIdentifier property is set
        internal bool IsSetSourceDBClusterIdentifier()
        {
            return this._sourceDBClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifies whether to enable storage encryption for the new global database cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be specified if <code>SourceDBClusterIdentifier</code> is specified. In this
        /// case, Amazon Aurora uses the setting from the source DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool StorageEncrypted
        {
            get { return this._storageEncrypted.GetValueOrDefault(); }
            set { this._storageEncrypted = value; }
        }

        // Check to see if StorageEncrypted property is set
        internal bool IsSetStorageEncrypted()
        {
            return this._storageEncrypted.HasValue; 
        }

    }
}