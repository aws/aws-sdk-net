/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes a snapshot.</para>
    /// </summary>
    public class Snapshot
    {
        
        private string snapshotIdentifier;
        private string clusterIdentifier;
        private DateTime? snapshotCreateTime;
        private string status;
        private int? port;
        private string availabilityZone;
        private DateTime? clusterCreateTime;
        private string masterUsername;
        private string clusterVersion;
        private string snapshotType;
        private string nodeType;
        private int? numberOfNodes;
        private string dBName;
        private string vpcId;
        private bool? encrypted;
        private List<AccountWithRestoreAccess> accountsWithRestoreAccess = new List<AccountWithRestoreAccess>();
        private string ownerAccount;
        private double? totalBackupSizeInMegaBytes;
        private double? actualIncrementalBackupSizeInMegaBytes;
        private double? backupProgressInMegaBytes;
        private double? currentBackupRateInMegaBytesPerSecond;
        private long? estimatedSecondsToCompletion;
        private long? elapsedTimeInSeconds;

        /// <summary>
        /// The snapshot identifier that is provided in the request.
        ///  
        /// </summary>
        public string SnapshotIdentifier
        {
            get { return this.snapshotIdentifier; }
            set { this.snapshotIdentifier = value; }
        }

        /// <summary>
        /// Sets the SnapshotIdentifier property
        /// </summary>
        /// <param name="snapshotIdentifier">The value to set for the SnapshotIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotIdentifier(string snapshotIdentifier)
        {
            this.snapshotIdentifier = snapshotIdentifier;
            return this;
        }
            

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this.snapshotIdentifier != null;
        }

        /// <summary>
        /// The identifier of the cluster for which the snapshot was taken.
        ///  
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this.clusterIdentifier; }
            set { this.clusterIdentifier = value; }
        }

        /// <summary>
        /// Sets the ClusterIdentifier property
        /// </summary>
        /// <param name="clusterIdentifier">The value to set for the ClusterIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithClusterIdentifier(string clusterIdentifier)
        {
            this.clusterIdentifier = clusterIdentifier;
            return this;
        }
            

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this.clusterIdentifier != null;
        }

        /// <summary>
        /// The time (UTC) when Amazon Redshift began the snapshot. A snapshot contains a copy of the cluster data as of this exact time.
        ///  
        /// </summary>
        public DateTime SnapshotCreateTime
        {
            get { return this.snapshotCreateTime ?? default(DateTime); }
            set { this.snapshotCreateTime = value; }
        }

        /// <summary>
        /// Sets the SnapshotCreateTime property
        /// </summary>
        /// <param name="snapshotCreateTime">The value to set for the SnapshotCreateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotCreateTime(DateTime snapshotCreateTime)
        {
            this.snapshotCreateTime = snapshotCreateTime;
            return this;
        }
            

        // Check to see if SnapshotCreateTime property is set
        internal bool IsSetSnapshotCreateTime()
        {
            return this.snapshotCreateTime.HasValue;
        }

        /// <summary>
        /// The snapshot status. The value of the status depends on the API operation used. <ul> <li><a>CreateClusterSnapshot</a> and
        /// <a>CopyClusterSnapshot</a> returns status as "creating". </li> <li><a>DescribeClusterSnapshots</a> returns status as "creating",
        /// "available", or "failed".</li> <li><a>DeleteClusterSnapshot</a> returns status as "deleted".</li> </ul>
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The port that the cluster is listening on.
        ///  
        /// </summary>
        public int Port
        {
            get { return this.port ?? default(int); }
            set { this.port = value; }
        }

        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">The value to set for the Port property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithPort(int port)
        {
            this.port = port;
            return this;
        }
            

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;
        }

        /// <summary>
        /// The Availability Zone in which the cluster was created.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZone = availabilityZone;
            return this;
        }
            

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The time (UTC) when the cluster was originally created.
        ///  
        /// </summary>
        public DateTime ClusterCreateTime
        {
            get { return this.clusterCreateTime ?? default(DateTime); }
            set { this.clusterCreateTime = value; }
        }

        /// <summary>
        /// Sets the ClusterCreateTime property
        /// </summary>
        /// <param name="clusterCreateTime">The value to set for the ClusterCreateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithClusterCreateTime(DateTime clusterCreateTime)
        {
            this.clusterCreateTime = clusterCreateTime;
            return this;
        }
            

        // Check to see if ClusterCreateTime property is set
        internal bool IsSetClusterCreateTime()
        {
            return this.clusterCreateTime.HasValue;
        }

        /// <summary>
        /// The master user name for the cluster.
        ///  
        /// </summary>
        public string MasterUsername
        {
            get { return this.masterUsername; }
            set { this.masterUsername = value; }
        }

        /// <summary>
        /// Sets the MasterUsername property
        /// </summary>
        /// <param name="masterUsername">The value to set for the MasterUsername property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithMasterUsername(string masterUsername)
        {
            this.masterUsername = masterUsername;
            return this;
        }
            

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this.masterUsername != null;
        }

        /// <summary>
        /// The version ID of the Amazon Redshift engine that is running on the cluster.
        ///  
        /// </summary>
        public string ClusterVersion
        {
            get { return this.clusterVersion; }
            set { this.clusterVersion = value; }
        }

        /// <summary>
        /// Sets the ClusterVersion property
        /// </summary>
        /// <param name="clusterVersion">The value to set for the ClusterVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithClusterVersion(string clusterVersion)
        {
            this.clusterVersion = clusterVersion;
            return this;
        }
            

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this.clusterVersion != null;
        }

        /// <summary>
        /// The snapshot type. Snapshots created using <a>CreateClusterSnapshot</a> and <a>CopyClusterSnapshot</a> will be of type "manual".
        ///  
        /// </summary>
        public string SnapshotType
        {
            get { return this.snapshotType; }
            set { this.snapshotType = value; }
        }

        /// <summary>
        /// Sets the SnapshotType property
        /// </summary>
        /// <param name="snapshotType">The value to set for the SnapshotType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotType(string snapshotType)
        {
            this.snapshotType = snapshotType;
            return this;
        }
            

        // Check to see if SnapshotType property is set
        internal bool IsSetSnapshotType()
        {
            return this.snapshotType != null;
        }

        /// <summary>
        /// The node type of the nodes in the cluster.
        ///  
        /// </summary>
        public string NodeType
        {
            get { return this.nodeType; }
            set { this.nodeType = value; }
        }

        /// <summary>
        /// Sets the NodeType property
        /// </summary>
        /// <param name="nodeType">The value to set for the NodeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithNodeType(string nodeType)
        {
            this.nodeType = nodeType;
            return this;
        }
            

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this.nodeType != null;
        }

        /// <summary>
        /// The number of nodes in the cluster.
        ///  
        /// </summary>
        public int NumberOfNodes
        {
            get { return this.numberOfNodes ?? default(int); }
            set { this.numberOfNodes = value; }
        }

        /// <summary>
        /// Sets the NumberOfNodes property
        /// </summary>
        /// <param name="numberOfNodes">The value to set for the NumberOfNodes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithNumberOfNodes(int numberOfNodes)
        {
            this.numberOfNodes = numberOfNodes;
            return this;
        }
            

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this.numberOfNodes.HasValue;
        }

        /// <summary>
        /// The name of the database that was created when the cluster was created.
        ///  
        /// </summary>
        public string DBName
        {
            get { return this.dBName; }
            set { this.dBName = value; }
        }

        /// <summary>
        /// Sets the DBName property
        /// </summary>
        /// <param name="dBName">The value to set for the DBName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithDBName(string dBName)
        {
            this.dBName = dBName;
            return this;
        }
            

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this.dBName != null;
        }

        /// <summary>
        /// The VPC identifier of the cluster if the snapshot is from a cluster in a VPC. Otherwise, this field is not in the output.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The value to set for the VpcId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithVpcId(string vpcId)
        {
            this.vpcId = vpcId;
            return this;
        }
            

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// If <c>true</c>, the data in the snapshot is encrypted at rest.
        ///  
        /// </summary>
        public bool Encrypted
        {
            get { return this.encrypted ?? default(bool); }
            set { this.encrypted = value; }
        }

        /// <summary>
        /// Sets the Encrypted property
        /// </summary>
        /// <param name="encrypted">The value to set for the Encrypted property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithEncrypted(bool encrypted)
        {
            this.encrypted = encrypted;
            return this;
        }
            

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this.encrypted.HasValue;
        }

        /// <summary>
        /// A list of the AWS customer accounts authorized to restore the snapshot. Returns <c>null</c> if no accounts are authorized. Visible only to
        /// the snapshot owner.
        ///  
        /// </summary>
        public List<AccountWithRestoreAccess> AccountsWithRestoreAccess
        {
            get { return this.accountsWithRestoreAccess; }
            set { this.accountsWithRestoreAccess = value; }
        }
        /// <summary>
        /// Adds elements to the AccountsWithRestoreAccess collection
        /// </summary>
        /// <param name="accountsWithRestoreAccess">The values to add to the AccountsWithRestoreAccess collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithAccountsWithRestoreAccess(params AccountWithRestoreAccess[] accountsWithRestoreAccess)
        {
            foreach (AccountWithRestoreAccess element in accountsWithRestoreAccess)
            {
                this.accountsWithRestoreAccess.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the AccountsWithRestoreAccess collection
        /// </summary>
        /// <param name="accountsWithRestoreAccess">The values to add to the AccountsWithRestoreAccess collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithAccountsWithRestoreAccess(IEnumerable<AccountWithRestoreAccess> accountsWithRestoreAccess)
        {
            foreach (AccountWithRestoreAccess element in accountsWithRestoreAccess)
            {
                this.accountsWithRestoreAccess.Add(element);
            }

            return this;
        }

        // Check to see if AccountsWithRestoreAccess property is set
        internal bool IsSetAccountsWithRestoreAccess()
        {
            return this.accountsWithRestoreAccess.Count > 0;
        }

        /// <summary>
        /// For manual snapshots, the AWS customer account used to create or copy the snapshot. For automatic snapshots, the owner of the cluster. The
        /// owner can perform all snapshot actions, such as sharing a manual snapshot.
        ///  
        /// </summary>
        public string OwnerAccount
        {
            get { return this.ownerAccount; }
            set { this.ownerAccount = value; }
        }

        /// <summary>
        /// Sets the OwnerAccount property
        /// </summary>
        /// <param name="ownerAccount">The value to set for the OwnerAccount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithOwnerAccount(string ownerAccount)
        {
            this.ownerAccount = ownerAccount;
            return this;
        }
            

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this.ownerAccount != null;
        }

        /// <summary>
        /// The size of the complete set of backup data that would be used to restore the instance.
        ///  
        /// </summary>
        public double TotalBackupSizeInMegaBytes
        {
            get { return this.totalBackupSizeInMegaBytes ?? default(double); }
            set { this.totalBackupSizeInMegaBytes = value; }
        }

        /// <summary>
        /// Sets the TotalBackupSizeInMegaBytes property
        /// </summary>
        /// <param name="totalBackupSizeInMegaBytes">The value to set for the TotalBackupSizeInMegaBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithTotalBackupSizeInMegaBytes(double totalBackupSizeInMegaBytes)
        {
            this.totalBackupSizeInMegaBytes = totalBackupSizeInMegaBytes;
            return this;
        }
            

        // Check to see if TotalBackupSizeInMegaBytes property is set
        internal bool IsSetTotalBackupSizeInMegaBytes()
        {
            return this.totalBackupSizeInMegaBytes.HasValue;
        }

        /// <summary>
        /// The size of the incremental backup.
        ///  
        /// </summary>
        public double ActualIncrementalBackupSizeInMegaBytes
        {
            get { return this.actualIncrementalBackupSizeInMegaBytes ?? default(double); }
            set { this.actualIncrementalBackupSizeInMegaBytes = value; }
        }

        /// <summary>
        /// Sets the ActualIncrementalBackupSizeInMegaBytes property
        /// </summary>
        /// <param name="actualIncrementalBackupSizeInMegaBytes">The value to set for the ActualIncrementalBackupSizeInMegaBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithActualIncrementalBackupSizeInMegaBytes(double actualIncrementalBackupSizeInMegaBytes)
        {
            this.actualIncrementalBackupSizeInMegaBytes = actualIncrementalBackupSizeInMegaBytes;
            return this;
        }
            

        // Check to see if ActualIncrementalBackupSizeInMegaBytes property is set
        internal bool IsSetActualIncrementalBackupSizeInMegaBytes()
        {
            return this.actualIncrementalBackupSizeInMegaBytes.HasValue;
        }

        /// <summary>
        /// The number of megabytes that have been transferred to the snapshot backup.
        ///  
        /// </summary>
        public double BackupProgressInMegaBytes
        {
            get { return this.backupProgressInMegaBytes ?? default(double); }
            set { this.backupProgressInMegaBytes = value; }
        }

        /// <summary>
        /// Sets the BackupProgressInMegaBytes property
        /// </summary>
        /// <param name="backupProgressInMegaBytes">The value to set for the BackupProgressInMegaBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithBackupProgressInMegaBytes(double backupProgressInMegaBytes)
        {
            this.backupProgressInMegaBytes = backupProgressInMegaBytes;
            return this;
        }
            

        // Check to see if BackupProgressInMegaBytes property is set
        internal bool IsSetBackupProgressInMegaBytes()
        {
            return this.backupProgressInMegaBytes.HasValue;
        }

        /// <summary>
        /// The number of megabytes per second being transferred to the snapshot backup. Returns <c>0</c> for a completed backup.
        ///  
        /// </summary>
        public double CurrentBackupRateInMegaBytesPerSecond
        {
            get { return this.currentBackupRateInMegaBytesPerSecond ?? default(double); }
            set { this.currentBackupRateInMegaBytesPerSecond = value; }
        }

        /// <summary>
        /// Sets the CurrentBackupRateInMegaBytesPerSecond property
        /// </summary>
        /// <param name="currentBackupRateInMegaBytesPerSecond">The value to set for the CurrentBackupRateInMegaBytesPerSecond property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithCurrentBackupRateInMegaBytesPerSecond(double currentBackupRateInMegaBytesPerSecond)
        {
            this.currentBackupRateInMegaBytesPerSecond = currentBackupRateInMegaBytesPerSecond;
            return this;
        }
            

        // Check to see if CurrentBackupRateInMegaBytesPerSecond property is set
        internal bool IsSetCurrentBackupRateInMegaBytesPerSecond()
        {
            return this.currentBackupRateInMegaBytesPerSecond.HasValue;
        }

        /// <summary>
        /// The estimate of the time remaining before the snapshot backup will complete. Returns <c>0</c> for a completed backup.
        ///  
        /// </summary>
        public long EstimatedSecondsToCompletion
        {
            get { return this.estimatedSecondsToCompletion ?? default(long); }
            set { this.estimatedSecondsToCompletion = value; }
        }

        /// <summary>
        /// Sets the EstimatedSecondsToCompletion property
        /// </summary>
        /// <param name="estimatedSecondsToCompletion">The value to set for the EstimatedSecondsToCompletion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithEstimatedSecondsToCompletion(long estimatedSecondsToCompletion)
        {
            this.estimatedSecondsToCompletion = estimatedSecondsToCompletion;
            return this;
        }
            

        // Check to see if EstimatedSecondsToCompletion property is set
        internal bool IsSetEstimatedSecondsToCompletion()
        {
            return this.estimatedSecondsToCompletion.HasValue;
        }

        /// <summary>
        /// The amount of time an in-progress snapshot backup has been running, or the amount of time it took a completed backup to finish.
        ///  
        /// </summary>
        public long ElapsedTimeInSeconds
        {
            get { return this.elapsedTimeInSeconds ?? default(long); }
            set { this.elapsedTimeInSeconds = value; }
        }

        /// <summary>
        /// Sets the ElapsedTimeInSeconds property
        /// </summary>
        /// <param name="elapsedTimeInSeconds">The value to set for the ElapsedTimeInSeconds property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithElapsedTimeInSeconds(long elapsedTimeInSeconds)
        {
            this.elapsedTimeInSeconds = elapsedTimeInSeconds;
            return this;
        }
            

        // Check to see if ElapsedTimeInSeconds property is set
        internal bool IsSetElapsedTimeInSeconds()
        {
            return this.elapsedTimeInSeconds.HasValue;
        }
    }
}
