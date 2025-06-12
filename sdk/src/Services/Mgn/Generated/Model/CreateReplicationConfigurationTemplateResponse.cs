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
    /// This is the response object from the CreateReplicationConfigurationTemplate operation.
    /// </summary>
    public partial class CreateReplicationConfigurationTemplateResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private bool? _associateDefaultSecurityGroup;
        private long? _bandwidthThrottling;
        private bool? _createPublicIP;
        private ReplicationConfigurationDataPlaneRouting _dataPlaneRouting;
        private ReplicationConfigurationDefaultLargeStagingDiskType _defaultLargeStagingDiskType;
        private ReplicationConfigurationEbsEncryption _ebsEncryption;
        private string _ebsEncryptionKeyArn;
        private string _replicationConfigurationTemplateID;
        private string _replicationServerInstanceType;
        private List<string> _replicationServersSecurityGroupsIDs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _stagingAreaSubnetId;
        private Dictionary<string, string> _stagingAreaTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _useDedicatedReplicationServer;
        private bool? _useFipsEndpoint;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Replication Configuration template ARN.
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
        /// Replication Configuration template associate default Application Migration Service
        /// Security group.
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
        /// Replication Configuration template bandwidth throttling.
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
        /// Replication Configuration template create Public IP.
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
        /// Replication Configuration template data plane routing.
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
        /// Replication Configuration template use default large Staging Disk type.
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
        /// Replication Configuration template EBS encryption.
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
        /// Replication Configuration template EBS encryption key ARN.
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
        /// Gets and sets the property ReplicationConfigurationTemplateID. 
        /// <para>
        /// Replication Configuration template ID.
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
        /// Replication Configuration template server instance type.
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
        /// Replication Configuration template server Security Groups IDs.
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
        /// Gets and sets the property StagingAreaSubnetId. 
        /// <para>
        /// Replication Configuration template Staging Area subnet ID.
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
        /// Replication Configuration template Staging Area Tags.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Replication Configuration template Tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property UseDedicatedReplicationServer. 
        /// <para>
        /// Replication Configuration template use Dedicated Replication Server.
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
        /// Replication Configuration template use Fips Endpoint.
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