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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a cluster.
    /// </summary>
    public partial class Cluster
    {
        private bool? _allowVersionUpgrade;
        private AquaConfiguration _aquaConfiguration;
        private int? _automatedSnapshotRetentionPeriod;
        private string _availabilityZone;
        private string _availabilityZoneRelocationStatus;
        private string _clusterAvailabilityStatus;
        private DateTime? _clusterCreateTime;
        private string _clusterIdentifier;
        private string _clusterNamespaceArn;
        private List<ClusterNode> _clusterNodes = AWSConfigs.InitializeCollections ? new List<ClusterNode>() : null;
        private List<ClusterParameterGroupStatus> _clusterParameterGroups = AWSConfigs.InitializeCollections ? new List<ClusterParameterGroupStatus>() : null;
        private string _clusterPublicKey;
        private string _clusterRevisionNumber;
        private List<ClusterSecurityGroupMembership> _clusterSecurityGroups = AWSConfigs.InitializeCollections ? new List<ClusterSecurityGroupMembership>() : null;
        private ClusterSnapshotCopyStatus _clusterSnapshotCopyStatus;
        private string _clusterStatus;
        private string _clusterSubnetGroupName;
        private string _clusterVersion;
        private string _customDomainCertificateArn;
        private DateTime? _customDomainCertificateExpiryDate;
        private string _customDomainName;
        private DataTransferProgress _dataTransferProgress;
        private string _dbName;
        private string _defaultIamRoleArn;
        private List<DeferredMaintenanceWindow> _deferredMaintenanceWindows = AWSConfigs.InitializeCollections ? new List<DeferredMaintenanceWindow>() : null;
        private ElasticIpStatus _elasticIpStatus;
        private string _elasticResizeNumberOfNodeOptions;
        private bool? _encrypted;
        private Endpoint _endpoint;
        private bool? _enhancedVpcRouting;
        private DateTime? _expectedNextSnapshotScheduleTime;
        private string _expectedNextSnapshotScheduleTimeStatus;
        private HsmStatus _hsmStatus;
        private List<ClusterIamRole> _iamRoles = AWSConfigs.InitializeCollections ? new List<ClusterIamRole>() : null;
        private string _ipAddressType;
        private string _kmsKeyId;
        private string _maintenanceTrackName;
        private int? _manualSnapshotRetentionPeriod;
        private string _masterPasswordSecretArn;
        private string _masterPasswordSecretKmsKeyId;
        private string _masterUsername;
        private string _modifyStatus;
        private string _multiAZ;
        private SecondaryClusterInfo _multiAZSecondary;
        private DateTime? _nextMaintenanceWindowStartTime;
        private string _nodeType;
        private int? _numberOfNodes;
        private List<string> _pendingActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PendingModifiedValues _pendingModifiedValues;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private ReservedNodeExchangeStatus _reservedNodeExchangeStatus;
        private ResizeInfo _resizeInfo;
        private RestoreStatus _restoreStatus;
        private string _snapshotScheduleIdentifier;
        private ScheduleState _snapshotScheduleState;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private long? _totalStorageCapacityInMegaBytes;
        private string _vpcId;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroups = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Gets and sets the property AllowVersionUpgrade. 
        /// <para>
        /// A boolean value that, if <c>true</c>, indicates that major version upgrades will be
        /// applied automatically to the cluster during the maintenance window. 
        /// </para>
        /// </summary>
        public bool? AllowVersionUpgrade
        {
            get { return this._allowVersionUpgrade; }
            set { this._allowVersionUpgrade = value; }
        }

        // Check to see if AllowVersionUpgrade property is set
        internal bool IsSetAllowVersionUpgrade()
        {
            return this._allowVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AquaConfiguration. 
        /// <para>
        /// This field is retired. Amazon Redshift automatically determines whether to use AQUA
        /// (Advanced Query Accelerator).
        /// </para>
        /// </summary>
        public AquaConfiguration AquaConfiguration
        {
            get { return this._aquaConfiguration; }
            set { this._aquaConfiguration = value; }
        }

        // Check to see if AquaConfiguration property is set
        internal bool IsSetAquaConfiguration()
        {
            return this._aquaConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AutomatedSnapshotRetentionPeriod. 
        /// <para>
        /// The number of days that automatic cluster snapshots are retained.
        /// </para>
        /// </summary>
        public int? AutomatedSnapshotRetentionPeriod
        {
            get { return this._automatedSnapshotRetentionPeriod; }
            set { this._automatedSnapshotRetentionPeriod = value; }
        }

        // Check to see if AutomatedSnapshotRetentionPeriod property is set
        internal bool IsSetAutomatedSnapshotRetentionPeriod()
        {
            return this._automatedSnapshotRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone in which the cluster is located.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneRelocationStatus. 
        /// <para>
        /// Describes the status of the Availability Zone relocation operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string AvailabilityZoneRelocationStatus
        {
            get { return this._availabilityZoneRelocationStatus; }
            set { this._availabilityZoneRelocationStatus = value; }
        }

        // Check to see if AvailabilityZoneRelocationStatus property is set
        internal bool IsSetAvailabilityZoneRelocationStatus()
        {
            return this._availabilityZoneRelocationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterAvailabilityStatus. 
        /// <para>
        /// The availability status of the cluster for queries. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Available - The cluster is available for queries. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unavailable - The cluster is not available for queries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maintenance - The cluster is intermittently available for queries due to maintenance
        /// activities.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifying - The cluster is intermittently available for queries due to changes that
        /// modify the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed - The cluster failed and is not available for queries.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterAvailabilityStatus
        {
            get { return this._clusterAvailabilityStatus; }
            set { this._clusterAvailabilityStatus = value; }
        }

        // Check to see if ClusterAvailabilityStatus property is set
        internal bool IsSetClusterAvailabilityStatus()
        {
            return this._clusterAvailabilityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        /// The date and time that the cluster was created.
        /// </para>
        /// </summary>
        public DateTime? ClusterCreateTime
        {
            get { return this._clusterCreateTime; }
            set { this._clusterCreateTime = value; }
        }

        // Check to see if ClusterCreateTime property is set
        internal bool IsSetClusterCreateTime()
        {
            return this._clusterCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterNamespaceArn. 
        /// <para>
        /// The namespace Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterNamespaceArn
        {
            get { return this._clusterNamespaceArn; }
            set { this._clusterNamespaceArn = value; }
        }

        // Check to see if ClusterNamespaceArn property is set
        internal bool IsSetClusterNamespaceArn()
        {
            return this._clusterNamespaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterNodes. 
        /// <para>
        /// The nodes in the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterNode> ClusterNodes
        {
            get { return this._clusterNodes; }
            set { this._clusterNodes = value; }
        }

        // Check to see if ClusterNodes property is set
        internal bool IsSetClusterNodes()
        {
            return this._clusterNodes != null && (this._clusterNodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClusterParameterGroups. 
        /// <para>
        /// The list of cluster parameter groups that are associated with this cluster. Each parameter
        /// group in the list is returned with its status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterParameterGroupStatus> ClusterParameterGroups
        {
            get { return this._clusterParameterGroups; }
            set { this._clusterParameterGroups = value; }
        }

        // Check to see if ClusterParameterGroups property is set
        internal bool IsSetClusterParameterGroups()
        {
            return this._clusterParameterGroups != null && (this._clusterParameterGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClusterPublicKey. 
        /// <para>
        /// The public key for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterPublicKey
        {
            get { return this._clusterPublicKey; }
            set { this._clusterPublicKey = value; }
        }

        // Check to see if ClusterPublicKey property is set
        internal bool IsSetClusterPublicKey()
        {
            return this._clusterPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterRevisionNumber. 
        /// <para>
        /// The specific revision number of the database in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterRevisionNumber
        {
            get { return this._clusterRevisionNumber; }
            set { this._clusterRevisionNumber = value; }
        }

        // Check to see if ClusterRevisionNumber property is set
        internal bool IsSetClusterRevisionNumber()
        {
            return this._clusterRevisionNumber != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterSecurityGroups. 
        /// <para>
        /// A list of cluster security group that are associated with the cluster. Each security
        /// group is represented by an element that contains <c>ClusterSecurityGroup.Name</c>
        /// and <c>ClusterSecurityGroup.Status</c> subelements. 
        /// </para>
        ///  
        /// <para>
        /// Cluster security groups are used when the cluster is not created in an Amazon Virtual
        /// Private Cloud (VPC). Clusters that are created in a VPC use VPC security groups, which
        /// are listed by the <b>VpcSecurityGroups</b> parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterSecurityGroupMembership> ClusterSecurityGroups
        {
            get { return this._clusterSecurityGroups; }
            set { this._clusterSecurityGroups = value; }
        }

        // Check to see if ClusterSecurityGroups property is set
        internal bool IsSetClusterSecurityGroups()
        {
            return this._clusterSecurityGroups != null && (this._clusterSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClusterSnapshotCopyStatus. 
        /// <para>
        /// A value that returns the destination region and retention period that are configured
        /// for cross-region snapshot copy.
        /// </para>
        /// </summary>
        public ClusterSnapshotCopyStatus ClusterSnapshotCopyStatus
        {
            get { return this._clusterSnapshotCopyStatus; }
            set { this._clusterSnapshotCopyStatus = value; }
        }

        // Check to see if ClusterSnapshotCopyStatus property is set
        internal bool IsSetClusterSnapshotCopyStatus()
        {
            return this._clusterSnapshotCopyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        ///  The current state of the cluster. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>available</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available, prep-for-resize</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available, resize-cleanup</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cancelling-resize</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>creating</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>final-snapshot</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hardware-failure</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>incompatible-hsm</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>incompatible-network</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>incompatible-parameters</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>incompatible-restore</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modifying</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>paused</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rebooting</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>renaming</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resizing</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rotating-keys</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>storage-full</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>updating-hsm</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterStatus
        {
            get { return this._clusterStatus; }
            set { this._clusterStatus = value; }
        }

        // Check to see if ClusterStatus property is set
        internal bool IsSetClusterStatus()
        {
            return this._clusterStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterSubnetGroupName. 
        /// <para>
        /// The name of the subnet group that is associated with the cluster. This parameter is
        /// valid only when the cluster is in a VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterSubnetGroupName
        {
            get { return this._clusterSubnetGroupName; }
            set { this._clusterSubnetGroupName = value; }
        }

        // Check to see if ClusterSubnetGroupName property is set
        internal bool IsSetClusterSubnetGroupName()
        {
            return this._clusterSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        /// The version ID of the Amazon Redshift engine that is running on the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterVersion
        {
            get { return this._clusterVersion; }
            set { this._clusterVersion = value; }
        }

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this._clusterVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateArn. 
        /// <para>
        /// The certificate Amazon Resource Name (ARN) for the custom domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string CustomDomainCertificateArn
        {
            get { return this._customDomainCertificateArn; }
            set { this._customDomainCertificateArn = value; }
        }

        // Check to see if CustomDomainCertificateArn property is set
        internal bool IsSetCustomDomainCertificateArn()
        {
            return this._customDomainCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateExpiryDate. 
        /// <para>
        /// The expiration date for the certificate associated with the custom domain name.
        /// </para>
        /// </summary>
        public DateTime? CustomDomainCertificateExpiryDate
        {
            get { return this._customDomainCertificateExpiryDate; }
            set { this._customDomainCertificateExpiryDate = value; }
        }

        // Check to see if CustomDomainCertificateExpiryDate property is set
        internal bool IsSetCustomDomainCertificateExpiryDate()
        {
            return this._customDomainCertificateExpiryDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name associated with the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string CustomDomainName
        {
            get { return this._customDomainName; }
            set { this._customDomainName = value; }
        }

        // Check to see if CustomDomainName property is set
        internal bool IsSetCustomDomainName()
        {
            return this._customDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property DataTransferProgress.
        /// </summary>
        public DataTransferProgress DataTransferProgress
        {
            get { return this._dataTransferProgress; }
            set { this._dataTransferProgress = value; }
        }

        // Check to see if DataTransferProgress property is set
        internal bool IsSetDataTransferProgress()
        {
            return this._dataTransferProgress != null;
        }

        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        /// The name of the initial database that was created when the cluster was created. This
        /// same name is returned for the life of the cluster. If an initial database was not
        /// specified, a database named <c>dev</c>dev was created by default. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string DBName
        {
            get { return this._dbName; }
            set { this._dbName = value; }
        }

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this._dbName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultIamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM role set as default for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string DefaultIamRoleArn
        {
            get { return this._defaultIamRoleArn; }
            set { this._defaultIamRoleArn = value; }
        }

        // Check to see if DefaultIamRoleArn property is set
        internal bool IsSetDefaultIamRoleArn()
        {
            return this._defaultIamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeferredMaintenanceWindows. 
        /// <para>
        /// Describes a group of <c>DeferredMaintenanceWindow</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeferredMaintenanceWindow> DeferredMaintenanceWindows
        {
            get { return this._deferredMaintenanceWindows; }
            set { this._deferredMaintenanceWindows = value; }
        }

        // Check to see if DeferredMaintenanceWindows property is set
        internal bool IsSetDeferredMaintenanceWindows()
        {
            return this._deferredMaintenanceWindows != null && (this._deferredMaintenanceWindows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ElasticIpStatus. 
        /// <para>
        /// The status of the elastic IP (EIP) address.
        /// </para>
        /// </summary>
        public ElasticIpStatus ElasticIpStatus
        {
            get { return this._elasticIpStatus; }
            set { this._elasticIpStatus = value; }
        }

        // Check to see if ElasticIpStatus property is set
        internal bool IsSetElasticIpStatus()
        {
            return this._elasticIpStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticResizeNumberOfNodeOptions. 
        /// <para>
        /// The number of nodes that you can resize the cluster to with the elastic resize method.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ElasticResizeNumberOfNodeOptions
        {
            get { return this._elasticResizeNumberOfNodeOptions; }
            set { this._elasticResizeNumberOfNodeOptions = value; }
        }

        // Check to see if ElasticResizeNumberOfNodeOptions property is set
        internal bool IsSetElasticResizeNumberOfNodeOptions()
        {
            return this._elasticResizeNumberOfNodeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// A boolean value that, if <c>true</c>, indicates that data in the cluster is encrypted
        /// at rest.
        /// </para>
        /// </summary>
        public bool? Encrypted
        {
            get { return this._encrypted; }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connection endpoint.
        /// </para>
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property EnhancedVpcRouting. 
        /// <para>
        /// An option that specifies whether to create the cluster with enhanced VPC routing enabled.
        /// To create a cluster that uses enhanced VPC routing, the cluster must be in a VPC.
        /// For more information, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/enhanced-vpc-routing.html">Enhanced
        /// VPC Routing</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        ///  
        /// <para>
        /// If this option is <c>true</c>, enhanced VPC routing is enabled. 
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? EnhancedVpcRouting
        {
            get { return this._enhancedVpcRouting; }
            set { this._enhancedVpcRouting = value; }
        }

        // Check to see if EnhancedVpcRouting property is set
        internal bool IsSetEnhancedVpcRouting()
        {
            return this._enhancedVpcRouting.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpectedNextSnapshotScheduleTime. 
        /// <para>
        /// The date and time when the next snapshot is expected to be taken for clusters with
        /// a valid snapshot schedule and backups enabled. 
        /// </para>
        /// </summary>
        public DateTime? ExpectedNextSnapshotScheduleTime
        {
            get { return this._expectedNextSnapshotScheduleTime; }
            set { this._expectedNextSnapshotScheduleTime = value; }
        }

        // Check to see if ExpectedNextSnapshotScheduleTime property is set
        internal bool IsSetExpectedNextSnapshotScheduleTime()
        {
            return this._expectedNextSnapshotScheduleTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpectedNextSnapshotScheduleTimeStatus. 
        /// <para>
        ///  The status of next expected snapshot for clusters having a valid snapshot schedule
        /// and backups enabled. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// OnTrack - The next snapshot is expected to be taken on time. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending - The next snapshot is pending to be taken. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ExpectedNextSnapshotScheduleTimeStatus
        {
            get { return this._expectedNextSnapshotScheduleTimeStatus; }
            set { this._expectedNextSnapshotScheduleTimeStatus = value; }
        }

        // Check to see if ExpectedNextSnapshotScheduleTimeStatus property is set
        internal bool IsSetExpectedNextSnapshotScheduleTimeStatus()
        {
            return this._expectedNextSnapshotScheduleTimeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HsmStatus. 
        /// <para>
        /// A value that reports whether the Amazon Redshift cluster has finished applying any
        /// hardware security module (HSM) settings changes specified in a modify cluster command.
        /// </para>
        ///  
        /// <para>
        /// Values: active, applying
        /// </para>
        /// </summary>
        public HsmStatus HsmStatus
        {
            get { return this._hsmStatus; }
            set { this._hsmStatus = value; }
        }

        // Check to see if HsmStatus property is set
        internal bool IsSetHsmStatus()
        {
            return this._hsmStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoles. 
        /// <para>
        /// A list of Identity and Access Management (IAM) roles that can be used by the cluster
        /// to access other Amazon Web Services services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterIamRole> IamRoles
        {
            get { return this._iamRoles; }
            set { this._iamRoles = value; }
        }

        // Check to see if IamRoles property is set
        internal bool IsSetIamRoles()
        {
            return this._iamRoles != null && (this._iamRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the cluster. Possible values are <c>ipv4</c> and <c>dualstack</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Key Management Service (KMS) key ID of the encryption key used to encrypt data
        /// in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// The name of the maintenance track for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string MaintenanceTrackName
        {
            get { return this._maintenanceTrackName; }
            set { this._maintenanceTrackName = value; }
        }

        // Check to see if MaintenanceTrackName property is set
        internal bool IsSetMaintenanceTrackName()
        {
            return this._maintenanceTrackName != null;
        }

        /// <summary>
        /// Gets and sets the property ManualSnapshotRetentionPeriod. 
        /// <para>
        /// The default number of days to retain a manual snapshot. If the value is -1, the snapshot
        /// is retained indefinitely. This setting doesn't change the retention period of existing
        /// snapshots.
        /// </para>
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </summary>
        public int? ManualSnapshotRetentionPeriod
        {
            get { return this._manualSnapshotRetentionPeriod; }
            set { this._manualSnapshotRetentionPeriod = value; }
        }

        // Check to see if ManualSnapshotRetentionPeriod property is set
        internal bool IsSetManualSnapshotRetentionPeriod()
        {
            return this._manualSnapshotRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterPasswordSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the cluster's admin user credentials secret.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string MasterPasswordSecretArn
        {
            get { return this._masterPasswordSecretArn; }
            set { this._masterPasswordSecretArn = value; }
        }

        // Check to see if MasterPasswordSecretArn property is set
        internal bool IsSetMasterPasswordSecretArn()
        {
            return this._masterPasswordSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property MasterPasswordSecretKmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt and store the cluster's
        /// admin credentials secret.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string MasterPasswordSecretKmsKeyId
        {
            get { return this._masterPasswordSecretKmsKeyId; }
            set { this._masterPasswordSecretKmsKeyId = value; }
        }

        // Check to see if MasterPasswordSecretKmsKeyId property is set
        internal bool IsSetMasterPasswordSecretKmsKeyId()
        {
            return this._masterPasswordSecretKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The admin user name for the cluster. This name is used to connect to the database
        /// that is specified in the <b>DBName</b> parameter. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string MasterUsername
        {
            get { return this._masterUsername; }
            set { this._masterUsername = value; }
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this._masterUsername != null;
        }

        /// <summary>
        /// Gets and sets the property ModifyStatus. 
        /// <para>
        /// The status of a modify operation, if any, initiated for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ModifyStatus
        {
            get { return this._modifyStatus; }
            set { this._modifyStatus = value; }
        }

        // Check to see if ModifyStatus property is set
        internal bool IsSetModifyStatus()
        {
            return this._modifyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// A boolean value that, if true, indicates that the cluster is deployed in two Availability
        /// Zones.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string MultiAZ
        {
            get { return this._multiAZ; }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZSecondary. 
        /// <para>
        /// The secondary compute unit of a cluster, if Multi-AZ deployment is turned on.
        /// </para>
        /// </summary>
        public SecondaryClusterInfo MultiAZSecondary
        {
            get { return this._multiAZSecondary; }
            set { this._multiAZSecondary = value; }
        }

        // Check to see if MultiAZSecondary property is set
        internal bool IsSetMultiAZSecondary()
        {
            return this._multiAZSecondary != null;
        }

        /// <summary>
        /// Gets and sets the property NextMaintenanceWindowStartTime. 
        /// <para>
        /// The date and time in UTC when system maintenance can begin.
        /// </para>
        /// </summary>
        public DateTime? NextMaintenanceWindowStartTime
        {
            get { return this._nextMaintenanceWindowStartTime; }
            set { this._nextMaintenanceWindowStartTime = value; }
        }

        // Check to see if NextMaintenanceWindowStartTime property is set
        internal bool IsSetNextMaintenanceWindowStartTime()
        {
            return this._nextMaintenanceWindowStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type for the nodes in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The number of compute nodes in the cluster.
        /// </para>
        /// </summary>
        public int? NumberOfNodes
        {
            get { return this._numberOfNodes; }
            set { this._numberOfNodes = value; }
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this._numberOfNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingActions. 
        /// <para>
        /// Cluster operations that are waiting to be started.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PendingActions
        {
            get { return this._pendingActions; }
            set { this._pendingActions = value; }
        }

        // Check to see if PendingActions property is set
        internal bool IsSetPendingActions()
        {
            return this._pendingActions != null && (this._pendingActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// A value that, if present, indicates that changes to the cluster are pending. Specific
        /// pending changes are identified by subelements.
        /// </para>
        /// </summary>
        public PendingModifiedValues PendingModifiedValues
        {
            get { return this._pendingModifiedValues; }
            set { this._pendingModifiedValues = value; }
        }

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this._pendingModifiedValues != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range, in Universal Coordinated Time (UTC), during which system maintenance
        /// can occur.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// A boolean value that, if <c>true</c>, indicates that the cluster can be accessed from
        /// a public network.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservedNodeExchangeStatus. 
        /// <para>
        /// The status of the reserved-node exchange request. Statuses include in-progress and
        /// requested.
        /// </para>
        /// </summary>
        public ReservedNodeExchangeStatus ReservedNodeExchangeStatus
        {
            get { return this._reservedNodeExchangeStatus; }
            set { this._reservedNodeExchangeStatus = value; }
        }

        // Check to see if ReservedNodeExchangeStatus property is set
        internal bool IsSetReservedNodeExchangeStatus()
        {
            return this._reservedNodeExchangeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResizeInfo. 
        /// <para>
        /// Returns the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AllowCancelResize: a boolean value indicating if the resize operation can be cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ResizeType: Returns ClassicResize
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResizeInfo ResizeInfo
        {
            get { return this._resizeInfo; }
            set { this._resizeInfo = value; }
        }

        // Check to see if ResizeInfo property is set
        internal bool IsSetResizeInfo()
        {
            return this._resizeInfo != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreStatus. 
        /// <para>
        /// A value that describes the status of a cluster restore action. This parameter returns
        /// null if the cluster was not created by restoring a snapshot.
        /// </para>
        /// </summary>
        public RestoreStatus RestoreStatus
        {
            get { return this._restoreStatus; }
            set { this._restoreStatus = value; }
        }

        // Check to see if RestoreStatus property is set
        internal bool IsSetRestoreStatus()
        {
            return this._restoreStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotScheduleIdentifier. 
        /// <para>
        /// A unique identifier for the cluster snapshot schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotScheduleIdentifier
        {
            get { return this._snapshotScheduleIdentifier; }
            set { this._snapshotScheduleIdentifier = value; }
        }

        // Check to see if SnapshotScheduleIdentifier property is set
        internal bool IsSetSnapshotScheduleIdentifier()
        {
            return this._snapshotScheduleIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotScheduleState. 
        /// <para>
        /// The current state of the cluster snapshot schedule.
        /// </para>
        /// </summary>
        public ScheduleState SnapshotScheduleState
        {
            get { return this._snapshotScheduleState; }
            set { this._snapshotScheduleState = value; }
        }

        // Check to see if SnapshotScheduleState property is set
        internal bool IsSetSnapshotScheduleState()
        {
            return this._snapshotScheduleState != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags for the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalStorageCapacityInMegaBytes. 
        /// <para>
        /// The total storage capacity of the cluster in megabytes. 
        /// </para>
        /// </summary>
        public long? TotalStorageCapacityInMegaBytes
        {
            get { return this._totalStorageCapacityInMegaBytes; }
            set { this._totalStorageCapacityInMegaBytes = value; }
        }

        // Check to see if TotalStorageCapacityInMegaBytes property is set
        internal bool IsSetTotalStorageCapacityInMegaBytes()
        {
            return this._totalStorageCapacityInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC the cluster is in, if the cluster is in a VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// A list of Amazon Virtual Private Cloud (Amazon VPC) security groups that are associated
        /// with the cluster. This parameter is returned only if the cluster is in a VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups
        {
            get { return this._vpcSecurityGroups; }
            set { this._vpcSecurityGroups = value; }
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this._vpcSecurityGroups != null && (this._vpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}