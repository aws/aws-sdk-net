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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The allocated storage size in gibibytes (GiB) for database engines. For Neptune, <c>AllocatedStorage</c>
        /// always returns 1, because Neptune DB cluster storage size isn't fixed, but instead
        /// automatically adjusts as needed.
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automatic DB snapshots are retained.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriod() => this.BackupRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DBClusterIdentifier value for the DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The database engine version.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// A value that indicates whether mapping of Amazon Web Services Identity and Access
        /// Management (IAM) accounts to database accounts is enabled.
        /// </para>
        /// </summary>
        public bool? IAMDatabaseAuthenticationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IAMDatabaseAuthenticationEnabled property is set.
        /// </summary>
        internal bool IsSetIAMDatabaseAuthenticationEnabled() => this.IAMDatabaseAuthenticationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The Provisioned IOPS (I/O operations per second) value. This setting is only for Multi-AZ
        /// DB clusters.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The pending change in network type for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>IPV4</c>, <c>DUAL</c> 
        /// </para>
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property PendingCloudwatchLogsExports. 
        /// <para>
        /// This <c>PendingCloudwatchLogsExports</c> structure specifies pending changes to which
        /// CloudWatch logs are enabled and which are disabled.
        /// </para>
        /// </summary>
        public PendingCloudwatchLogsExports PendingCloudwatchLogsExports { get; set; }

        /// <summary>
        /// Checks to see if the PendingCloudwatchLogsExports property is set.
        /// </summary>
        internal bool IsSetPendingCloudwatchLogsExports() => this.PendingCloudwatchLogsExports != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The pending change in storage type for the DB cluster. Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>standard</c> </b> – ( <i>the default</i> ) Configures cost-effective database
        /// storage for applications with moderate to small I/O usage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>iopt1</c> </b> – Enables <a href="https://docs.aws.amazon.com/neptune/latest/userguide/storage-types.html#provisioned-iops-storage">I/O-Optimized
        /// storage</a> that's designed to meet the needs of I/O-intensive graph workloads that
        /// require predictable pricing with low I/O latency and consistent I/O throughput.
        /// </para>
        ///  
        /// <para>
        /// Neptune I/O-Optimized storage is only available starting with engine release 1.3.0.0.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;
    }
}
