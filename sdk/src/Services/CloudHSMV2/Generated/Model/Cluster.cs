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

/*
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Contains information about an AWS CloudHSM cluster.
    /// </summary>
    public partial class Cluster
    {
        private BackupPolicy _backupPolicy;
        private Certificates _certificates;
        private string _clusterId;
        private DateTime? _createTimestamp;
        private List<Hsm> _hsms = new List<Hsm>();
        private string _hsmType;
        private string _preCoPassword;
        private string _securityGroup;
        private string _sourceBackupId;
        private ClusterState _state;
        private string _stateMessage;
        private Dictionary<string, string> _subnetMapping = new Dictionary<string, string>();
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
        public DateTime CreateTimestamp
        {
            get { return this._createTimestamp.GetValueOrDefault(); }
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
        /// </summary>
        public List<Hsm> Hsms
        {
            get { return this._hsms; }
            set { this._hsms = value; }
        }

        // Check to see if Hsms property is set
        internal bool IsSetHsms()
        {
            return this._hsms != null && this._hsms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The type of HSM that the cluster contains.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PreCoPassword. 
        /// <para>
        /// The default password for the cluster's Pre-Crypto Officer (PRECO) user.
        /// </para>
        /// </summary>
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
        /// A map of the cluster's subnets and their corresponding Availability Zones.
        /// </para>
        /// </summary>
        public Dictionary<string, string> SubnetMapping
        {
            get { return this._subnetMapping; }
            set { this._subnetMapping = value; }
        }

        // Check to see if SubnetMapping property is set
        internal bool IsSetSubnetMapping()
        {
            return this._subnetMapping != null && this._subnetMapping.Count > 0; 
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