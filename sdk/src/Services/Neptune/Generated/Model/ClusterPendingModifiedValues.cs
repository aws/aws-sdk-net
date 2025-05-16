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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// This data type is used as a response element in the <c>ModifyDBCluster</c> operation
    /// and contains changes that will be applied during the next maintenance window.
    /// </summary>
    public partial class ClusterPendingModifiedValues
    {
        private int? _allocatedStorage;
        private int? _backupRetentionPeriod;
        private string _dbClusterIdentifier;
        private string _engineVersion;
        private bool? _iamDatabaseAuthenticationEnabled;
        private int? _iops;
        private PendingCloudwatchLogsExports _pendingCloudwatchLogsExports;
        private string _storageType;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The allocated storage size in gibibytes (GiB) for database engines. For Neptune, <c>AllocatedStorage</c>
        /// always returns 1, because Neptune DB cluster storage size isn't fixed, but instead
        /// automatically adjusts as needed.
        /// </para>
        /// </summary>
        public int? AllocatedStorage
        {
            get { return this._allocatedStorage; }
            set { this._allocatedStorage = value; }
        }

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this._allocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automatic DB snapshots are retained.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod
        {
            get { return this._backupRetentionPeriod; }
            set { this._backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this._backupRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DBClusterIdentifier value for the DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The database engine version.
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
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// A value that indicates whether mapping of Amazon Web Services Identity and Access
        /// Management (IAM) accounts to database accounts is enabled.
        /// </para>
        /// </summary>
        public bool? IAMDatabaseAuthenticationEnabled
        {
            get { return this._iamDatabaseAuthenticationEnabled; }
            set { this._iamDatabaseAuthenticationEnabled = value; }
        }

        // Check to see if IAMDatabaseAuthenticationEnabled property is set
        internal bool IsSetIAMDatabaseAuthenticationEnabled()
        {
            return this._iamDatabaseAuthenticationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The Provisioned IOPS (I/O operations per second) value. This setting is only for Multi-AZ
        /// DB clusters.
        /// </para>
        /// </summary>
        public int? Iops
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingCloudwatchLogsExports. 
        /// <para>
        /// This <c>PendingCloudwatchLogsExports</c> structure specifies pending changes to which
        /// CloudWatch logs are enabled and which are disabled.
        /// </para>
        /// </summary>
        public PendingCloudwatchLogsExports PendingCloudwatchLogsExports
        {
            get { return this._pendingCloudwatchLogsExports; }
            set { this._pendingCloudwatchLogsExports = value; }
        }

        // Check to see if PendingCloudwatchLogsExports property is set
        internal bool IsSetPendingCloudwatchLogsExports()
        {
            return this._pendingCloudwatchLogsExports != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The pending change in storage type for the DB cluster.   Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>standard</c> </b>   –   ( <i>the default</i> ) Configures cost-effective database
        /// storage for applications with moderate to small I/O usage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>iopt1</c> </b>   –   Enables <a href="https://docs.aws.amazon.com/neptune/latest/userguide/storage-types.html#provisioned-iops-storage">I/O-Optimized
        /// storage</a> that's designed to meet the needs of I/O-intensive graph workloads that
        /// require predictable pricing with low I/O latency and consistent I/O throughput.
        /// </para>
        ///  
        /// <para>
        /// Neptune I/O-Optimized storage is only available starting with engine release 1.3.0.0.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

    }
}