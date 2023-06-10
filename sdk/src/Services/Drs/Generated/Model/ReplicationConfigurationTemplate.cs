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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReplicationConfigurationTemplate
    {
        private string _arn;
        private bool? _associateDefaultSecurityGroup;
        private bool? _autoReplicateNewDisks;
        private long? _bandwidthThrottling;
        private bool? _createPublicIP;
        private ReplicationConfigurationDataPlaneRouting _dataPlaneRouting;
        private ReplicationConfigurationDefaultLargeStagingDiskType _defaultLargeStagingDiskType;
        private ReplicationConfigurationEbsEncryption _ebsEncryption;
        private string _ebsEncryptionKeyArn;
        private List<PITPolicyRule> _pitPolicy = new List<PITPolicyRule>();
        private string _replicationConfigurationTemplateID;
        private string _replicationServerInstanceType;
        private List<string> _replicationServersSecurityGroupsIDs = new List<string>();
        private string _stagingAreaSubnetId;
        private Dictionary<string, string> _stagingAreaTags = new Dictionary<string, string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private bool? _useDedicatedReplicationServer;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Replication Configuration Template ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociateDefaultSecurityGroup. 
        /// <para>
        /// Whether to associate the default Elastic Disaster Recovery Security group with the
        /// Replication Configuration Template.
        /// </para>
        /// </summary>
        public bool AssociateDefaultSecurityGroup
        {
            get { return this._associateDefaultSecurityGroup.GetValueOrDefault(); }
            set { this._associateDefaultSecurityGroup = value; }
        }

        // Check to see if AssociateDefaultSecurityGroup property is set
        internal bool IsSetAssociateDefaultSecurityGroup()
        {
            return this._associateDefaultSecurityGroup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoReplicateNewDisks. 
        /// <para>
        /// Whether to allow the AWS replication agent to automatically replicate newly added
        /// disks.
        /// </para>
        /// </summary>
        public bool AutoReplicateNewDisks
        {
            get { return this._autoReplicateNewDisks.GetValueOrDefault(); }
            set { this._autoReplicateNewDisks = value; }
        }

        // Check to see if AutoReplicateNewDisks property is set
        internal bool IsSetAutoReplicateNewDisks()
        {
            return this._autoReplicateNewDisks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BandwidthThrottling. 
        /// <para>
        /// Configure bandwidth throttling for the outbound data transfer rate of the Source Server
        /// in Mbps.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long BandwidthThrottling
        {
            get { return this._bandwidthThrottling.GetValueOrDefault(); }
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
        /// Whether to create a Public IP for the Recovery Instance by default.
        /// </para>
        /// </summary>
        public bool CreatePublicIP
        {
            get { return this._createPublicIP.GetValueOrDefault(); }
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
        /// The data plane routing mechanism that will be used for replication.
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
        /// The Staging Disk EBS volume type to be used during replication.
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
        /// The type of EBS encryption to be used during replication.
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
        /// The ARN of the EBS encryption key to be used during replication.
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
        /// Gets and sets the property PitPolicy. 
        /// <para>
        /// The Point in time (PIT) policy to manage snapshots taken during replication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<PITPolicyRule> PitPolicy
        {
            get { return this._pitPolicy; }
            set { this._pitPolicy = value; }
        }

        // Check to see if PitPolicy property is set
        internal bool IsSetPitPolicy()
        {
            return this._pitPolicy != null && this._pitPolicy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationConfigurationTemplateID. 
        /// <para>
        /// The Replication Configuration Template ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string ReplicationConfigurationTemplateID
        {
            get { return this._replicationConfigurationTemplateID; }
            set { this._replicationConfigurationTemplateID = value; }
        }

        // Check to see if ReplicationConfigurationTemplateID property is set
        internal bool IsSetReplicationConfigurationTemplateID()
        {
            return this._replicationConfigurationTemplateID != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationServerInstanceType. 
        /// <para>
        /// The instance type to be used for the replication server.
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
        /// The security group IDs that will be used by the replication server.
        /// </para>
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
            return this._replicationServersSecurityGroupsIDs != null && this._replicationServersSecurityGroupsIDs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StagingAreaSubnetId. 
        /// <para>
        /// The subnet to be used by the replication staging area.
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
        /// A set of tags to be associated with all resources created in the replication staging
        /// area: EC2 replication server, EBS volumes, EBS snapshots, etc.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> StagingAreaTags
        {
            get { return this._stagingAreaTags; }
            set { this._stagingAreaTags = value; }
        }

        // Check to see if StagingAreaTags property is set
        internal bool IsSetStagingAreaTags()
        {
            return this._stagingAreaTags != null && this._stagingAreaTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags to be associated with the Replication Configuration Template resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UseDedicatedReplicationServer. 
        /// <para>
        /// Whether to use a dedicated Replication Server in the replication staging area.
        /// </para>
        /// </summary>
        public bool UseDedicatedReplicationServer
        {
            get { return this._useDedicatedReplicationServer.GetValueOrDefault(); }
            set { this._useDedicatedReplicationServer = value; }
        }

        // Check to see if UseDedicatedReplicationServer property is set
        internal bool IsSetUseDedicatedReplicationServer()
        {
            return this._useDedicatedReplicationServer.HasValue; 
        }

    }
}