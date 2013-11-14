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
using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes a snapshot.</para>
    /// </summary>
    public partial class Snapshot : AmazonWebServiceResponse
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
        private bool? encryptedWithHSM;
        private List<AccountWithRestoreAccess> accountsWithRestoreAccess = new List<AccountWithRestoreAccess>();
        private string ownerAccount;
        private double? totalBackupSizeInMegaBytes;
        private double? actualIncrementalBackupSizeInMegaBytes;
        private double? backupProgressInMegaBytes;
        private double? currentBackupRateInMegaBytesPerSecond;
        private long? estimatedSecondsToCompletion;
        private long? elapsedTimeInSeconds;
        private string sourceRegion;


        /// <summary>
        /// The snapshot identifier that is provided in the request.
        ///  
        /// </summary>
        public string SnapshotIdentifier
        {
            get { return this.snapshotIdentifier; }
            set { this.snapshotIdentifier = value; }
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

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this.encrypted.HasValue;
        }

        /// <summary>
        /// A boolean that indicates whether the snapshot data is encrypted using the HSM keys of the source cluster. <c>true</c> indicates that the
        /// data is encrypted using HSM keys.
        ///  
        /// </summary>
        public bool EncryptedWithHSM
        {
            get { return this.encryptedWithHSM ?? default(bool); }
            set { this.encryptedWithHSM = value; }
        }

        // Check to see if EncryptedWithHSM property is set
        internal bool IsSetEncryptedWithHSM()
        {
            return this.encryptedWithHSM.HasValue;
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

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this.ownerAccount != null;
        }

        /// <summary>
        /// The size of the complete set of backup data that would be used to restore the cluster.
        ///  
        /// </summary>
        public double TotalBackupSizeInMegaBytes
        {
            get { return this.totalBackupSizeInMegaBytes ?? default(double); }
            set { this.totalBackupSizeInMegaBytes = value; }
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

        // Check to see if ElapsedTimeInSeconds property is set
        internal bool IsSetElapsedTimeInSeconds()
        {
            return this.elapsedTimeInSeconds.HasValue;
        }

        /// <summary>
        /// The source region from which the snapshot was copied.
        ///  
        /// </summary>
        public string SourceRegion
        {
            get { return this.sourceRegion; }
            set { this.sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this.sourceRegion != null;
        }
    }
}
