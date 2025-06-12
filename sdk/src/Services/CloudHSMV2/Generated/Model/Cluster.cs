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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
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
namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Contains information about an CloudHSM cluster.
    /// </summary>
    public partial class Cluster
    {
        private BackupPolicy _backupPolicy;
        private BackupRetentionPolicy _backupRetentionPolicy;
        private Certificates _certificates;
        private string _clusterId;
        private DateTime? _createTimestamp;
        private List<Hsm> _hsms = AWSConfigs.InitializeCollections ? new List<Hsm>() : null;
        private string _hsmType;
        private DateTime? _hsmTypeRollbackExpiration;
        private ClusterMode _mode;
        private NetworkType _networkType;
        private string _preCoPassword;
        private string _securityGroup;
        private string _sourceBackupId;
        private ClusterState _state;
        private string _stateMessage;
        private Dictionary<string, string> _subnetMapping = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property BackupPolicy. 
        /// <para>
        /// The cluster's backup policy.
        /// </para>
        /// </summary>
        public BackupPolicy BackupPolicy
        {
            get { return this._backupPolicy; }
            set { this._backupPolicy = value; }
        }

        // Check to see if BackupPolicy property is set
        internal bool IsSetBackupPolicy()
        {
            return this._backupPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPolicy. 
        /// <para>
        /// A policy that defines how the service retains backups.
        /// </para>
        /// </summary>
        public BackupRetentionPolicy BackupRetentionPolicy
        {
            get { return this._backupRetentionPolicy; }
            set { this._backupRetentionPolicy = value; }
        }

        // Check to see if BackupRetentionPolicy property is set
        internal bool IsSetBackupRetentionPolicy()
        {
            return this._backupRetentionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// Contains one or more certificates or a certificate signing request (CSR).
        /// </para>
        /// </summary>
        public Certificates Certificates
        {
            get { return this._certificates; }
            set { this._certificates = value; }
        }

        // Check to see if Certificates property is set
        internal bool IsSetCertificates()
        {
            return this._certificates != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The cluster's identifier (ID).
        /// </para>
        /// </summary>
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time when the cluster was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp
        {
            get { return this._createTimestamp; }
            set { this._createTimestamp = value; }
        }

        // Check to see if CreateTimestamp property is set
        internal bool IsSetCreateTimestamp()
        {
            return this._createTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Hsms. 
        /// <para>
        /// Contains information about the HSMs in the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Hsm> Hsms
        {
            get { return this._hsms; }
            set { this._hsms = value; }
        }

        // Check to see if Hsms property is set
        internal bool IsSetHsms()
        {
            return this._hsms != null && (this._hsms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The type of HSM that the cluster contains.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public string HsmType
        {
            get { return this._hsmType; }
            set { this._hsmType = value; }
        }

        // Check to see if HsmType property is set
        internal bool IsSetHsmType()
        {
            return this._hsmType != null;
        }

        /// <summary>
        /// Gets and sets the property HsmTypeRollbackExpiration. 
        /// <para>
        /// The timestamp until when the cluster can be rolled back to its original HSM type.
        /// </para>
        /// </summary>
        public DateTime? HsmTypeRollbackExpiration
        {
            get { return this._hsmTypeRollbackExpiration; }
            set { this._hsmTypeRollbackExpiration = value; }
        }

        // Check to see if HsmTypeRollbackExpiration property is set
        internal bool IsSetHsmTypeRollbackExpiration()
        {
            return this._hsmTypeRollbackExpiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the cluster.
        /// </para>
        /// </summary>
        public ClusterMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The cluster's NetworkType can be IPv4 (the default) or DUALSTACK. The IPv4 NetworkType
        /// restricts communication between your application and the hardware security modules
        /// (HSMs) to the IPv4 protocol only. The DUALSTACK NetworkType enables communication
        /// over both IPv4 and IPv6 protocols. To use DUALSTACK, configure your virtual private
        /// cloud (VPC) and subnets to support both IPv4 and IPv6. This configuration involves
        /// adding IPv6 Classless Inter-Domain Routing (CIDR) blocks to the existing IPv4 CIDR
        /// blocks in your subnets. The NetworkType you choose affects the network addressing
        /// options for your cluster. DUALSTACK provides more flexibility by supporting both IPv4
        /// and IPv6 communication.
        /// </para>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property PreCoPassword. 
        /// <para>
        /// The default password for the cluster's Pre-Crypto Officer (PRECO) user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=32)]
        public string PreCoPassword
        {
            get { return this._preCoPassword; }
            set { this._preCoPassword = value; }
        }

        // Check to see if PreCoPassword property is set
        internal bool IsSetPreCoPassword()
        {
            return this._preCoPassword != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroup. 
        /// <para>
        /// The identifier (ID) of the cluster's security group.
        /// </para>
        /// </summary>
        public string SecurityGroup
        {
            get { return this._securityGroup; }
            set { this._securityGroup = value; }
        }

        // Check to see if SecurityGroup property is set
        internal bool IsSetSecurityGroup()
        {
            return this._securityGroup != null;
        }

        /// <summary>
        /// Gets and sets the property SourceBackupId. 
        /// <para>
        /// The identifier (ID) of the backup used to create the cluster. This value exists only
        /// when the cluster was created from a backup.
        /// </para>
        /// </summary>
        public string SourceBackupId
        {
            get { return this._sourceBackupId; }
            set { this._sourceBackupId = value; }
        }

        // Check to see if SourceBackupId property is set
        internal bool IsSetSourceBackupId()
        {
            return this._sourceBackupId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The cluster's state.
        /// </para>
        /// </summary>
        public ClusterState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A description of the cluster's state.
        /// </para>
        /// </summary>
        [AWSProperty(Max=300)]
        public string StateMessage
        {
            get { return this._stateMessage; }
            set { this._stateMessage = value; }
        }

        // Check to see if StateMessage property is set
        internal bool IsSetStateMessage()
        {
            return this._stateMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetMapping. 
        /// <para>
        /// A map from availability zone to the cluster’s subnet in that availability zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SubnetMapping
        {
            get { return this._subnetMapping; }
            set { this._subnetMapping = value; }
        }

        // Check to see if SubnetMapping property is set
        internal bool IsSetSubnetMapping()
        {
            return this._subnetMapping != null && (this._subnetMapping.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The list of tags for the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier (ID) of the virtual private cloud (VPC) that contains the cluster.
        /// </para>
        /// </summary>
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

    }
}