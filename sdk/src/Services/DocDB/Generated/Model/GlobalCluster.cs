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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// A data type representing an Amazon DocumentDB global cluster.
    /// </summary>
    public partial class GlobalCluster
    {
        private string _databaseName;
        private bool? _deletionProtection;
        private string _engine;
        private string _engineVersion;
        private string _globalClusterArn;
        private string _globalClusterIdentifier;
        private List<GlobalClusterMember> _globalClusterMembers = AWSConfigs.InitializeCollections ? new List<GlobalClusterMember>() : null;
        private string _globalClusterResourceId;
        private string _status;
        private bool? _storageEncrypted;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The default database name within the new global cluster.
        /// </para>
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
        /// The deletion protection setting for the new global cluster.
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
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
        /// The Amazon DocumentDB database engine used by the global cluster. 
        /// </para>
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
        /// Indicates the database engine version.
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

        /// <summary>
        /// Gets and sets the property GlobalClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the global cluster.
        /// </para>
        /// </summary>
        public string GlobalClusterArn
        {
            get { return this._globalClusterArn; }
            set { this._globalClusterArn = value; }
        }

        // Check to see if GlobalClusterArn property is set
        internal bool IsSetGlobalClusterArn()
        {
            return this._globalClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// Contains a user-supplied global cluster identifier. This identifier is the unique
        /// key that identifies a global cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property GlobalClusterMembers. 
        /// <para>
        /// The list of cluster IDs for secondary clusters within the global cluster. Currently
        /// limited to one item. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalClusterMember> GlobalClusterMembers
        {
            get { return this._globalClusterMembers; }
            set { this._globalClusterMembers = value; }
        }

        // Check to see if GlobalClusterMembers property is set
        internal bool IsSetGlobalClusterMembers()
        {
            return this._globalClusterMembers != null && (this._globalClusterMembers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GlobalClusterResourceId. 
        /// <para>
        /// The Amazon Web Services RegionRegion-unique, immutable identifier for the global database
        /// cluster. This identifier is found in CloudTrail log entries whenever the KMS customer
        /// master key (CMK) for the cluster is accessed. 
        /// </para>
        /// </summary>
        public string GlobalClusterResourceId
        {
            get { return this._globalClusterResourceId; }
            set { this._globalClusterResourceId = value; }
        }

        // Check to see if GlobalClusterResourceId property is set
        internal bool IsSetGlobalClusterResourceId()
        {
            return this._globalClusterResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the current state of this global cluster.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// The storage encryption setting for the global cluster.
        /// </para>
        /// </summary>
        public bool? StorageEncrypted
        {
            get { return this._storageEncrypted; }
            set { this._storageEncrypted = value; }
        }

        // Check to see if StorageEncrypted property is set
        internal bool IsSetStorageEncrypted()
        {
            return this._storageEncrypted.HasValue; 
        }

    }
}