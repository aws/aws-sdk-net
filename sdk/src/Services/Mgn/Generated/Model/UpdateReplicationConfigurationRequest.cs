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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateReplicationConfiguration operation.
    /// Allows you to update multiple ReplicationConfigurations by Source Server ID.
    /// </summary>
    public partial class UpdateReplicationConfigurationRequest : AmazonMgnRequest
    {
        private string _accountid;
        private bool? _associateDefaultSecurityGroup;
        private long? _bandwidthThrottling;
        private bool? _createPublicIP;
        private ReplicationConfigurationDataPlaneRouting _dataPlaneRouting;
        private ReplicationConfigurationDefaultLargeStagingDiskType _defaultLargeStagingDiskType;
        private ReplicationConfigurationEbsEncryption _ebsEncryption;
        private string _ebsEncryptionKeyArn;
        private string _name;
        private List<ReplicationConfigurationReplicatedDisk> _replicatedDisks = AWSConfigs.InitializeCollections ? new List<ReplicationConfigurationReplicatedDisk>() : null;
        private string _replicationServerInstanceType;
        private List<string> _replicationServersSecurityGroupsIDs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sourceServerID;
        private string _stagingAreaSubnetId;
        private Dictionary<string, string> _stagingAreaTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _useDedicatedReplicationServer;
        private bool? _useFipsEndpoint;

        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// Update replication configuration Account ID request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountID
        {
            get { return this._accountid; }
            set { this._accountid = value; }
        }

        // Check to see if AccountID property is set
        internal bool IsSetAccountID()
        {
            return this._accountid != null;
        }

        /// <summary>
        /// Gets and sets the property AssociateDefaultSecurityGroup. 
        /// <para>
        /// Update replication configuration associate default Application Migration Service Security
        /// group request.
        /// </para>
        /// </summary>
        public bool? AssociateDefaultSecurityGroup
        {
            get { return this._associateDefaultSecurityGroup; }
            set { this._associateDefaultSecurityGroup = value; }
        }

        // Check to see if AssociateDefaultSecurityGroup property is set
        internal bool IsSetAssociateDefaultSecurityGroup()
        {
            return this._associateDefaultSecurityGroup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BandwidthThrottling. 
        /// <para>
        /// Update replication configuration bandwidth throttling request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public long? BandwidthThrottling
        {
            get { return this._bandwidthThrottling; }
            set { this._bandwidthThrottling = value; }
        }

        // Check to see if BandwidthThrottling property is set
        internal bool IsSetBandwidthThrottling()
        {
            return this._bandwidthThrottling.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatePublicIP. 
        /// <para>
        /// Update replication configuration create Public IP request.
        /// </para>
        /// </summary>
        public bool? CreatePublicIP
        {
            get { return this._createPublicIP; }
            set { this._createPublicIP = value; }
        }

        // Check to see if CreatePublicIP property is set
        internal bool IsSetCreatePublicIP()
        {
            return this._createPublicIP.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataPlaneRouting. 
        /// <para>
        /// Update replication configuration data plane routing request.
        /// </para>
        /// </summary>
        public ReplicationConfigurationDataPlaneRouting DataPlaneRouting
        {
            get { return this._dataPlaneRouting; }
            set { this._dataPlaneRouting = value; }
        }

        // Check to see if DataPlaneRouting property is set
        internal bool IsSetDataPlaneRouting()
        {
            return this._dataPlaneRouting != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultLargeStagingDiskType. 
        /// <para>
        /// Update replication configuration use default large Staging Disk type request.
        /// </para>
        /// </summary>
        public ReplicationConfigurationDefaultLargeStagingDiskType DefaultLargeStagingDiskType
        {
            get { return this._defaultLargeStagingDiskType; }
            set { this._defaultLargeStagingDiskType = value; }
        }

        // Check to see if DefaultLargeStagingDiskType property is set
        internal bool IsSetDefaultLargeStagingDiskType()
        {
            return this._defaultLargeStagingDiskType != null;
        }

        /// <summary>
        /// Gets and sets the property EbsEncryption. 
        /// <para>
        /// Update replication configuration EBS encryption request.
        /// </para>
        /// </summary>
        public ReplicationConfigurationEbsEncryption EbsEncryption
        {
            get { return this._ebsEncryption; }
            set { this._ebsEncryption = value; }
        }

        // Check to see if EbsEncryption property is set
        internal bool IsSetEbsEncryption()
        {
            return this._ebsEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property EbsEncryptionKeyArn. 
        /// <para>
        /// Update replication configuration EBS encryption key ARN request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string EbsEncryptionKeyArn
        {
            get { return this._ebsEncryptionKeyArn; }
            set { this._ebsEncryptionKeyArn = value; }
        }

        // Check to see if EbsEncryptionKeyArn property is set
        internal bool IsSetEbsEncryptionKeyArn()
        {
            return this._ebsEncryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Update replication configuration name request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicatedDisks. 
        /// <para>
        /// Update replication configuration replicated disks request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
        public List<ReplicationConfigurationReplicatedDisk> ReplicatedDisks
        {
            get { return this._replicatedDisks; }
            set { this._replicatedDisks = value; }
        }

        // Check to see if ReplicatedDisks property is set
        internal bool IsSetReplicatedDisks()
        {
            return this._replicatedDisks != null && (this._replicatedDisks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationServerInstanceType. 
        /// <para>
        /// Update replication configuration Replication Server instance type request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string ReplicationServerInstanceType
        {
            get { return this._replicationServerInstanceType; }
            set { this._replicationServerInstanceType = value; }
        }

        // Check to see if ReplicationServerInstanceType property is set
        internal bool IsSetReplicationServerInstanceType()
        {
            return this._replicationServerInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationServersSecurityGroupsIDs. 
        /// <para>
        /// Update replication configuration Replication Server Security Groups IDs request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public List<string> ReplicationServersSecurityGroupsIDs
        {
            get { return this._replicationServersSecurityGroupsIDs; }
            set { this._replicationServersSecurityGroupsIDs = value; }
        }

        // Check to see if ReplicationServersSecurityGroupsIDs property is set
        internal bool IsSetReplicationServersSecurityGroupsIDs()
        {
            return this._replicationServersSecurityGroupsIDs != null && (this._replicationServersSecurityGroupsIDs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Update replication configuration Source Server ID request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string SourceServerID
        {
            get { return this._sourceServerID; }
            set { this._sourceServerID = value; }
        }

        // Check to see if SourceServerID property is set
        internal bool IsSetSourceServerID()
        {
            return this._sourceServerID != null;
        }

        /// <summary>
        /// Gets and sets the property StagingAreaSubnetId. 
        /// <para>
        /// Update replication configuration Staging Area subnet request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string StagingAreaSubnetId
        {
            get { return this._stagingAreaSubnetId; }
            set { this._stagingAreaSubnetId = value; }
        }

        // Check to see if StagingAreaSubnetId property is set
        internal bool IsSetStagingAreaSubnetId()
        {
            return this._stagingAreaSubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property StagingAreaTags. 
        /// <para>
        /// Update replication configuration Staging Area Tags request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> StagingAreaTags
        {
            get { return this._stagingAreaTags; }
            set { this._stagingAreaTags = value; }
        }

        // Check to see if StagingAreaTags property is set
        internal bool IsSetStagingAreaTags()
        {
            return this._stagingAreaTags != null && (this._stagingAreaTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UseDedicatedReplicationServer. 
        /// <para>
        /// Update replication configuration use dedicated Replication Server request.
        /// </para>
        /// </summary>
        public bool? UseDedicatedReplicationServer
        {
            get { return this._useDedicatedReplicationServer; }
            set { this._useDedicatedReplicationServer = value; }
        }

        // Check to see if UseDedicatedReplicationServer property is set
        internal bool IsSetUseDedicatedReplicationServer()
        {
            return this._useDedicatedReplicationServer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseFipsEndpoint. 
        /// <para>
        /// Update replication configuration use Fips Endpoint.
        /// </para>
        /// </summary>
        public bool? UseFipsEndpoint
        {
            get { return this._useFipsEndpoint; }
            set { this._useFipsEndpoint = value; }
        }

        // Check to see if UseFipsEndpoint property is set
        internal bool IsSetUseFipsEndpoint()
        {
            return this._useFipsEndpoint.HasValue; 
        }

    }
}