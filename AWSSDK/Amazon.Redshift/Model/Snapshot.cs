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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a snapshot.
    /// </summary>
    public partial class Snapshot
    {
        private List<AccountWithRestoreAccess> _accountsWithRestoreAccess = new List<AccountWithRestoreAccess>();
        private double? _actualIncrementalBackupSizeInMegaBytes;
        private string _availabilityZone;
        private double? _backupProgressInMegaBytes;
        private DateTime? _clusterCreateTime;
        private string _clusterIdentifier;
        private string _clusterVersion;
        private double? _currentBackupRateInMegaBytesPerSecond;
        private string _dBName;
        private long? _elapsedTimeInSeconds;
        private bool? _encrypted;
        private bool? _encryptedWithHSM;
        private long? _estimatedSecondsToCompletion;
        private string _masterUsername;
        private string _nodeType;
        private int? _numberOfNodes;
        private string _ownerAccount;
        private int? _port;
        private DateTime? _snapshotCreateTime;
        private string _snapshotIdentifier;
        private string _snapshotType;
        private string _sourceRegion;
        private string _status;
        private double? _totalBackupSizeInMegaBytes;
        private string _vpcId;


        /// <summary>
        /// Gets and sets the property AccountsWithRestoreAccess. 
        /// <para>
        ///             A list of the AWS customer accounts authorized to restore the snapshot.
        /// Returns <code>null</code> if no accounts are authorized. Visible only to the snapshot
        /// owner.        
        /// </para>
        /// </summary>
        public List<AccountWithRestoreAccess> AccountsWithRestoreAccess
        {
            get { return this._accountsWithRestoreAccess; }
            set { this._accountsWithRestoreAccess = value; }
        }

        /// <summary>
        /// Sets the AccountsWithRestoreAccess property
        /// </summary>
        /// <param name="accountsWithRestoreAccess">The values to add to the AccountsWithRestoreAccess collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithAccountsWithRestoreAccess(params AccountWithRestoreAccess[] accountsWithRestoreAccess)
        {
            foreach (var element in accountsWithRestoreAccess)
            {
                this._accountsWithRestoreAccess.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the AccountsWithRestoreAccess property
        /// </summary>
        /// <param name="accountsWithRestoreAccess">The values to add to the AccountsWithRestoreAccess collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithAccountsWithRestoreAccess(IEnumerable<AccountWithRestoreAccess> accountsWithRestoreAccess)
        {
            foreach (var element in accountsWithRestoreAccess)
            {
                this._accountsWithRestoreAccess.Add(element);
            }
            return this;
        }
        // Check to see if AccountsWithRestoreAccess property is set
        internal bool IsSetAccountsWithRestoreAccess()
        {
            return this._accountsWithRestoreAccess != null && this._accountsWithRestoreAccess.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property ActualIncrementalBackupSizeInMegaBytes. 
        /// <para>
        ///             The size of the incremental backup.        
        /// </para>
        /// </summary>
        public double ActualIncrementalBackupSizeInMegaBytes
        {
            get { return this._actualIncrementalBackupSizeInMegaBytes.GetValueOrDefault(); }
            set { this._actualIncrementalBackupSizeInMegaBytes = value; }
        }


        /// <summary>
        /// Sets the ActualIncrementalBackupSizeInMegaBytes property
        /// </summary>
        /// <param name="actualIncrementalBackupSizeInMegaBytes">The value to set for the ActualIncrementalBackupSizeInMegaBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithActualIncrementalBackupSizeInMegaBytes(double actualIncrementalBackupSizeInMegaBytes)
        {
            this._actualIncrementalBackupSizeInMegaBytes = actualIncrementalBackupSizeInMegaBytes;
            return this;
        }

        // Check to see if ActualIncrementalBackupSizeInMegaBytes property is set
        internal bool IsSetActualIncrementalBackupSizeInMegaBytes()
        {
            return this._actualIncrementalBackupSizeInMegaBytes.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///             The Availability Zone in which the cluster was created.        
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }


        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithAvailabilityZone(string availabilityZone)
        {
            this._availabilityZone = availabilityZone;
            return this;
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }


        /// <summary>
        /// Gets and sets the property BackupProgressInMegaBytes. 
        /// <para>
        ///             The number of megabytes that have been transferred to the snapshot backup.
        ///        
        /// </para>
        /// </summary>
        public double BackupProgressInMegaBytes
        {
            get { return this._backupProgressInMegaBytes.GetValueOrDefault(); }
            set { this._backupProgressInMegaBytes = value; }
        }


        /// <summary>
        /// Sets the BackupProgressInMegaBytes property
        /// </summary>
        /// <param name="backupProgressInMegaBytes">The value to set for the BackupProgressInMegaBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithBackupProgressInMegaBytes(double backupProgressInMegaBytes)
        {
            this._backupProgressInMegaBytes = backupProgressInMegaBytes;
            return this;
        }

        // Check to see if BackupProgressInMegaBytes property is set
        internal bool IsSetBackupProgressInMegaBytes()
        {
            return this._backupProgressInMegaBytes.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        ///         The time (UTC) when the cluster was originally created.        
        /// </para>
        /// </summary>
        public DateTime ClusterCreateTime
        {
            get { return this._clusterCreateTime.GetValueOrDefault(); }
            set { this._clusterCreateTime = value; }
        }


        /// <summary>
        /// Sets the ClusterCreateTime property
        /// </summary>
        /// <param name="clusterCreateTime">The value to set for the ClusterCreateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithClusterCreateTime(DateTime clusterCreateTime)
        {
            this._clusterCreateTime = clusterCreateTime;
            return this;
        }

        // Check to see if ClusterCreateTime property is set
        internal bool IsSetClusterCreateTime()
        {
            return this._clusterCreateTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        ///         The identifier of the cluster for which the snapshot was taken.        
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }


        /// <summary>
        /// Sets the ClusterIdentifier property
        /// </summary>
        /// <param name="clusterIdentifier">The value to set for the ClusterIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithClusterIdentifier(string clusterIdentifier)
        {
            this._clusterIdentifier = clusterIdentifier;
            return this;
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        ///         The version ID of the Amazon Redshift engine that is running on the cluster.
        ///        
        /// </para>
        /// </summary>
        public string ClusterVersion
        {
            get { return this._clusterVersion; }
            set { this._clusterVersion = value; }
        }


        /// <summary>
        /// Sets the ClusterVersion property
        /// </summary>
        /// <param name="clusterVersion">The value to set for the ClusterVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithClusterVersion(string clusterVersion)
        {
            this._clusterVersion = clusterVersion;
            return this;
        }

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this._clusterVersion != null;
        }


        /// <summary>
        /// Gets and sets the property CurrentBackupRateInMegaBytesPerSecond. 
        /// <para>
        ///             The number of megabytes per second being transferred to the snapshot backup.
        /// Returns <code>0</code> for a completed backup.        
        /// </para>
        /// </summary>
        public double CurrentBackupRateInMegaBytesPerSecond
        {
            get { return this._currentBackupRateInMegaBytesPerSecond.GetValueOrDefault(); }
            set { this._currentBackupRateInMegaBytesPerSecond = value; }
        }


        /// <summary>
        /// Sets the CurrentBackupRateInMegaBytesPerSecond property
        /// </summary>
        /// <param name="currentBackupRateInMegaBytesPerSecond">The value to set for the CurrentBackupRateInMegaBytesPerSecond property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithCurrentBackupRateInMegaBytesPerSecond(double currentBackupRateInMegaBytesPerSecond)
        {
            this._currentBackupRateInMegaBytesPerSecond = currentBackupRateInMegaBytesPerSecond;
            return this;
        }

        // Check to see if CurrentBackupRateInMegaBytesPerSecond property is set
        internal bool IsSetCurrentBackupRateInMegaBytesPerSecond()
        {
            return this._currentBackupRateInMegaBytesPerSecond.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        /// The name of the database that was created when the cluster was created. 
        /// </para>
        /// </summary>
        public string DBName
        {
            get { return this._dBName; }
            set { this._dBName = value; }
        }


        /// <summary>
        /// Sets the DBName property
        /// </summary>
        /// <param name="dBName">The value to set for the DBName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithDBName(string dBName)
        {
            this._dBName = dBName;
            return this;
        }

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this._dBName != null;
        }


        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        ///             The amount of time an in-progress snapshot backup has been running, or
        /// the amount of time it took a completed backup to finish.        
        /// </para>
        /// </summary>
        public long ElapsedTimeInSeconds
        {
            get { return this._elapsedTimeInSeconds.GetValueOrDefault(); }
            set { this._elapsedTimeInSeconds = value; }
        }


        /// <summary>
        /// Sets the ElapsedTimeInSeconds property
        /// </summary>
        /// <param name="elapsedTimeInSeconds">The value to set for the ElapsedTimeInSeconds property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithElapsedTimeInSeconds(long elapsedTimeInSeconds)
        {
            this._elapsedTimeInSeconds = elapsedTimeInSeconds;
            return this;
        }

        // Check to see if ElapsedTimeInSeconds property is set
        internal bool IsSetElapsedTimeInSeconds()
        {
            return this._elapsedTimeInSeconds.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// If <code>true</code>, the data in the snapshot is encrypted at rest.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }


        /// <summary>
        /// Sets the Encrypted property
        /// </summary>
        /// <param name="encrypted">The value to set for the Encrypted property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithEncrypted(bool encrypted)
        {
            this._encrypted = encrypted;
            return this;
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property EncryptedWithHSM. 
        /// <para>
        /// A boolean that indicates whether the snapshot data is encrypted using the HSM keys
        ///            of the source cluster. <code>true</code> indicates that the data is encrypted
        /// using HSM keys.
        /// </para>
        /// </summary>
        public bool EncryptedWithHSM
        {
            get { return this._encryptedWithHSM.GetValueOrDefault(); }
            set { this._encryptedWithHSM = value; }
        }


        /// <summary>
        /// Sets the EncryptedWithHSM property
        /// </summary>
        /// <param name="encryptedWithHSM">The value to set for the EncryptedWithHSM property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithEncryptedWithHSM(bool encryptedWithHSM)
        {
            this._encryptedWithHSM = encryptedWithHSM;
            return this;
        }

        // Check to see if EncryptedWithHSM property is set
        internal bool IsSetEncryptedWithHSM()
        {
            return this._encryptedWithHSM.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property EstimatedSecondsToCompletion. 
        /// <para>
        ///             The estimate of the time remaining before the snapshot backup will complete.
        /// Returns <code>0</code> for a completed backup.         
        /// </para>
        /// </summary>
        public long EstimatedSecondsToCompletion
        {
            get { return this._estimatedSecondsToCompletion.GetValueOrDefault(); }
            set { this._estimatedSecondsToCompletion = value; }
        }


        /// <summary>
        /// Sets the EstimatedSecondsToCompletion property
        /// </summary>
        /// <param name="estimatedSecondsToCompletion">The value to set for the EstimatedSecondsToCompletion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithEstimatedSecondsToCompletion(long estimatedSecondsToCompletion)
        {
            this._estimatedSecondsToCompletion = estimatedSecondsToCompletion;
            return this;
        }

        // Check to see if EstimatedSecondsToCompletion property is set
        internal bool IsSetEstimatedSecondsToCompletion()
        {
            return this._estimatedSecondsToCompletion.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        ///         The master user name for the cluster.        
        /// </para>
        /// </summary>
        public string MasterUsername
        {
            get { return this._masterUsername; }
            set { this._masterUsername = value; }
        }


        /// <summary>
        /// Sets the MasterUsername property
        /// </summary>
        /// <param name="masterUsername">The value to set for the MasterUsername property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithMasterUsername(string masterUsername)
        {
            this._masterUsername = masterUsername;
            return this;
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this._masterUsername != null;
        }


        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type of the nodes in the cluster.
        /// </para>
        /// </summary>
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }


        /// <summary>
        /// Sets the NodeType property
        /// </summary>
        /// <param name="nodeType">The value to set for the NodeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithNodeType(string nodeType)
        {
            this._nodeType = nodeType;
            return this;
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }


        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The number of nodes in the cluster.
        /// </para>
        /// </summary>
        public int NumberOfNodes
        {
            get { return this._numberOfNodes.GetValueOrDefault(); }
            set { this._numberOfNodes = value; }
        }


        /// <summary>
        /// Sets the NumberOfNodes property
        /// </summary>
        /// <param name="numberOfNodes">The value to set for the NumberOfNodes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithNumberOfNodes(int numberOfNodes)
        {
            this._numberOfNodes = numberOfNodes;
            return this;
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this._numberOfNodes.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        ///             For manual snapshots, the AWS customer account used to create or copy
        /// the snapshot. For automatic snapshots, the owner of the cluster. The owner can perform
        /// all snapshot actions, such as sharing a manual snapshot.        
        /// </para>
        /// </summary>
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }


        /// <summary>
        /// Sets the OwnerAccount property
        /// </summary>
        /// <param name="ownerAccount">The value to set for the OwnerAccount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithOwnerAccount(string ownerAccount)
        {
            this._ownerAccount = ownerAccount;
            return this;
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }


        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///         The port that the cluster is listening on.        
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }


        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">The value to set for the Port property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithPort(int port)
        {
            this._port = port;
            return this;
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        ///             The time (UTC) when Amazon Redshift began the snapshot.             A
        /// snapshot contains a copy of the cluster data as of this exact time.         
        /// </para>
        /// </summary>
        public DateTime SnapshotCreateTime
        {
            get { return this._snapshotCreateTime.GetValueOrDefault(); }
            set { this._snapshotCreateTime = value; }
        }


        /// <summary>
        /// Sets the SnapshotCreateTime property
        /// </summary>
        /// <param name="snapshotCreateTime">The value to set for the SnapshotCreateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotCreateTime(DateTime snapshotCreateTime)
        {
            this._snapshotCreateTime = snapshotCreateTime;
            return this;
        }

        // Check to see if SnapshotCreateTime property is set
        internal bool IsSetSnapshotCreateTime()
        {
            return this._snapshotCreateTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        ///         The snapshot identifier that is provided in the request.        
        /// </para>
        /// </summary>
        public string SnapshotIdentifier
        {
            get { return this._snapshotIdentifier; }
            set { this._snapshotIdentifier = value; }
        }


        /// <summary>
        /// Sets the SnapshotIdentifier property
        /// </summary>
        /// <param name="snapshotIdentifier">The value to set for the SnapshotIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotIdentifier(string snapshotIdentifier)
        {
            this._snapshotIdentifier = snapshotIdentifier;
            return this;
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this._snapshotIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        ///             The snapshot type. Snapshots created using <a>CreateClusterSnapshot</a>
        /// and <a>CopyClusterSnapshot</a> will be of type "manual".        
        /// </para>
        /// </summary>
        public string SnapshotType
        {
            get { return this._snapshotType; }
            set { this._snapshotType = value; }
        }


        /// <summary>
        /// Sets the SnapshotType property
        /// </summary>
        /// <param name="snapshotType">The value to set for the SnapshotType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotType(string snapshotType)
        {
            this._snapshotType = snapshotType;
            return this;
        }

        // Check to see if SnapshotType property is set
        internal bool IsSetSnapshotType()
        {
            return this._snapshotType != null;
        }


        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        ///             The source region from which the snapshot was copied.        
        /// </para>
        /// </summary>
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }


        /// <summary>
        /// Sets the SourceRegion property
        /// </summary>
        /// <param name="sourceRegion">The value to set for the SourceRegion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSourceRegion(string sourceRegion)
        {
            this._sourceRegion = sourceRegion;
            return this;
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///         The snapshot status. The value of the status depends on the API operation
        /// used.            <ul>                <li><a>CreateClusterSnapshot</a> and <a>CopyClusterSnapshot</a>
        /// returns status as "creating". </li>                <li><a>DescribeClusterSnapshots</a>
        /// returns status as                      "creating", "available", "final snapshot",
        /// or "failed".</li>                <li><a>DeleteClusterSnapshot</a> returns status as
        /// "deleted".</li>            </ul>        
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }


        /// <summary>
        /// Gets and sets the property TotalBackupSizeInMegaBytes. 
        /// <para>
        ///             The size of the complete set of backup data that would be used to restore
        /// the cluster.        
        /// </para>
        /// </summary>
        public double TotalBackupSizeInMegaBytes
        {
            get { return this._totalBackupSizeInMegaBytes.GetValueOrDefault(); }
            set { this._totalBackupSizeInMegaBytes = value; }
        }


        /// <summary>
        /// Sets the TotalBackupSizeInMegaBytes property
        /// </summary>
        /// <param name="totalBackupSizeInMegaBytes">The value to set for the TotalBackupSizeInMegaBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithTotalBackupSizeInMegaBytes(double totalBackupSizeInMegaBytes)
        {
            this._totalBackupSizeInMegaBytes = totalBackupSizeInMegaBytes;
            return this;
        }

        // Check to see if TotalBackupSizeInMegaBytes property is set
        internal bool IsSetTotalBackupSizeInMegaBytes()
        {
            return this._totalBackupSizeInMegaBytes.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC identifier of the cluster if the snapshot is from a cluster in a VPC. Otherwise,
        ///        this field is not in the output.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }


        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The value to set for the VpcId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithVpcId(string vpcId)
        {
            this._vpcId = vpcId;
            return this;
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}