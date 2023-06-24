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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReplicationConfigurationTemplate operation.
    /// Creates a new ReplicationConfigurationTemplate.
    /// </summary>
    public partial class CreateReplicationConfigurationTemplateRequest : AmazonMgnRequest
    {
        private bool? _associateDefaultSecurityGroup;
        private long? _bandwidthThrottling;
        private bool? _createPublicIP;
        private ReplicationConfigurationDataPlaneRouting _dataPlaneRouting;
        private ReplicationConfigurationDefaultLargeStagingDiskType _defaultLargeStagingDiskType;
        private ReplicationConfigurationEbsEncryption _ebsEncryption;
        private string _ebsEncryptionKeyArn;
        private string _replicationServerInstanceType;
        private List<string> _replicationServersSecurityGroupsIDs = new List<string>();
        private string _stagingAreaSubnetId;
        private Dictionary<string, string> _stagingAreaTags = new Dictionary<string, string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private bool? _useDedicatedReplicationServer;

        /// <summary>
        /// Gets and sets the property AssociateDefaultSecurityGroup. 
        /// <para>
        /// Request to associate the default Application Migration Service Security group with
        /// the Replication Settings template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property BandwidthThrottling. 
        /// <para>
        /// Request to configure bandwidth throttling during Replication Settings template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
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
        /// Request to create Public IP during Replication Settings template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Request to configure data plane routing during Replication Settings template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Request to configure the default large staging disk EBS volume type during Replication
        /// Settings template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Request to configure EBS encryption during Replication Settings template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Request to configure an EBS encryption key during Replication Settings template creation.
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
        /// Gets and sets the property ReplicationServerInstanceType. 
        /// <para>
        /// Request to configure the Replication Server instance type during Replication Settings
        /// template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
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
        /// Request to configure the Replication Server Security group ID during Replication Settings
        /// template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32)]
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
        /// Request to configure the Staging Area subnet ID during Replication Settings template
        /// creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
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
        /// Request to configure Staging Area tags during Replication Settings template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Request to configure tags during Replication Settings template creation.
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
        /// Request to use Dedicated Replication Servers during Replication Settings template
        /// creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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