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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// This is the response object from the DescribeBroker operation.
    /// </summary>
    public partial class DescribeBrokerResponse : AmazonWebServiceResponse
    {
        private AuthenticationStrategy _authenticationStrategy;
        private bool? _autoMinorVersionUpgrade;
        private string _brokerArn;
        private string _brokerId;
        private List<BrokerInstance> _brokerInstances = new List<BrokerInstance>();
        private string _brokerName;
        private BrokerState _brokerState;
        private Configurations _configurations;
        private DateTime? _created;
        private DeploymentMode _deploymentMode;
        private EncryptionOptions _encryptionOptions;
        private EngineType _engineType;
        private string _engineVersion;
        private string _hostInstanceType;
        private LdapServerMetadataOutput _ldapServerMetadata;
        private LogsSummary _logs;
        private WeeklyStartTime _maintenanceWindowStartTime;
        private AuthenticationStrategy _pendingAuthenticationStrategy;
        private string _pendingEngineVersion;
        private string _pendingHostInstanceType;
        private LdapServerMetadataOutput _pendingLdapServerMetadata;
        private List<string> _pendingSecurityGroups = new List<string>();
        private bool? _publiclyAccessible;
        private List<string> _securityGroups = new List<string>();
        private BrokerStorageType _storageType;
        private List<string> _subnetIds = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<UserSummary> _users = new List<UserSummary>();

        /// <summary>
        /// Gets and sets the property AuthenticationStrategy. The authentication strategy used
        /// to secure the broker.
        /// </summary>
        public AuthenticationStrategy AuthenticationStrategy
        {
            get { return this._authenticationStrategy; }
            set { this._authenticationStrategy = value; }
        }

        // Check to see if AuthenticationStrategy property is set
        internal bool IsSetAuthenticationStrategy()
        {
            return this._authenticationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. Required. Enables automatic upgrades
        /// to new minor versions for brokers, as Apache releases the versions. The automatic
        /// upgrades occur during the maintenance window of the broker or after a manual broker
        /// reboot.
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade.GetValueOrDefault(); }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BrokerArn. The Amazon Resource Name (ARN) of the broker.
        /// </summary>
        public string BrokerArn
        {
            get { return this._brokerArn; }
            set { this._brokerArn = value; }
        }

        // Check to see if BrokerArn property is set
        internal bool IsSetBrokerArn()
        {
            return this._brokerArn != null;
        }

        /// <summary>
        /// Gets and sets the property BrokerId. The unique ID that Amazon MQ generates for the
        /// broker.
        /// </summary>
        public string BrokerId
        {
            get { return this._brokerId; }
            set { this._brokerId = value; }
        }

        // Check to see if BrokerId property is set
        internal bool IsSetBrokerId()
        {
            return this._brokerId != null;
        }

        /// <summary>
        /// Gets and sets the property BrokerInstances. A list of information about allocated
        /// brokers.
        /// </summary>
        public List<BrokerInstance> BrokerInstances
        {
            get { return this._brokerInstances; }
            set { this._brokerInstances = value; }
        }

        // Check to see if BrokerInstances property is set
        internal bool IsSetBrokerInstances()
        {
            return this._brokerInstances != null && this._brokerInstances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BrokerName. The name of the broker. This value must be
        /// unique in your AWS account, 1-50 characters long, must contain only letters, numbers,
        /// dashes, and underscores, and must not contain whitespaces, brackets, wildcard characters,
        /// or special characters.
        /// </summary>
        public string BrokerName
        {
            get { return this._brokerName; }
            set { this._brokerName = value; }
        }

        // Check to see if BrokerName property is set
        internal bool IsSetBrokerName()
        {
            return this._brokerName != null;
        }

        /// <summary>
        /// Gets and sets the property BrokerState. The status of the broker.
        /// </summary>
        public BrokerState BrokerState
        {
            get { return this._brokerState; }
            set { this._brokerState = value; }
        }

        // Check to see if BrokerState property is set
        internal bool IsSetBrokerState()
        {
            return this._brokerState != null;
        }

        /// <summary>
        /// Gets and sets the property Configurations. The list of all revisions for the specified
        /// configuration.
        /// </summary>
        public Configurations Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null;
        }

        /// <summary>
        /// Gets and sets the property Created. The time when the broker was created.
        /// </summary>
        public DateTime Created
        {
            get { return this._created.GetValueOrDefault(); }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentMode. Required. The deployment mode of the broker.
        /// </summary>
        public DeploymentMode DeploymentMode
        {
            get { return this._deploymentMode; }
            set { this._deploymentMode = value; }
        }

        // Check to see if DeploymentMode property is set
        internal bool IsSetDeploymentMode()
        {
            return this._deploymentMode != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionOptions. Encryption options for the broker.
        /// </summary>
        public EncryptionOptions EncryptionOptions
        {
            get { return this._encryptionOptions; }
            set { this._encryptionOptions = value; }
        }

        // Check to see if EncryptionOptions property is set
        internal bool IsSetEncryptionOptions()
        {
            return this._encryptionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property EngineType. Required. The type of broker engine. Note:
        /// Currently, Amazon MQ supports ACTIVEMQ and RABBITMQ.
        /// </summary>
        public EngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. The version of the broker engine. For a
        /// list of supported engine versions, see https://docs.aws.amazon.com/amazon-mq/latest/developer-guide/broker-engine.html
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property HostInstanceType. The broker's instance type.
        /// </summary>
        public string HostInstanceType
        {
            get { return this._hostInstanceType; }
            set { this._hostInstanceType = value; }
        }

        // Check to see if HostInstanceType property is set
        internal bool IsSetHostInstanceType()
        {
            return this._hostInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LdapServerMetadata. The metadata of the LDAP server used
        /// to authenticate and authorize connections to the broker.
        /// </summary>
        public LdapServerMetadataOutput LdapServerMetadata
        {
            get { return this._ldapServerMetadata; }
            set { this._ldapServerMetadata = value; }
        }

        // Check to see if LdapServerMetadata property is set
        internal bool IsSetLdapServerMetadata()
        {
            return this._ldapServerMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Logs. The list of information about logs currently enabled
        /// and pending to be deployed for the specified broker.
        /// </summary>
        public LogsSummary Logs
        {
            get { return this._logs; }
            set { this._logs = value; }
        }

        // Check to see if Logs property is set
        internal bool IsSetLogs()
        {
            return this._logs != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceWindowStartTime. The parameters that determine
        /// the WeeklyStartTime.
        /// </summary>
        public WeeklyStartTime MaintenanceWindowStartTime
        {
            get { return this._maintenanceWindowStartTime; }
            set { this._maintenanceWindowStartTime = value; }
        }

        // Check to see if MaintenanceWindowStartTime property is set
        internal bool IsSetMaintenanceWindowStartTime()
        {
            return this._maintenanceWindowStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property PendingAuthenticationStrategy. The authentication strategy
        /// that will be applied when the broker is rebooted.
        /// </summary>
        public AuthenticationStrategy PendingAuthenticationStrategy
        {
            get { return this._pendingAuthenticationStrategy; }
            set { this._pendingAuthenticationStrategy = value; }
        }

        // Check to see if PendingAuthenticationStrategy property is set
        internal bool IsSetPendingAuthenticationStrategy()
        {
            return this._pendingAuthenticationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property PendingEngineVersion. The version of the broker engine
        /// to upgrade to. For a list of supported engine versions, see https://docs.aws.amazon.com/amazon-mq/latest/developer-guide/broker-engine.html
        /// </summary>
        public string PendingEngineVersion
        {
            get { return this._pendingEngineVersion; }
            set { this._pendingEngineVersion = value; }
        }

        // Check to see if PendingEngineVersion property is set
        internal bool IsSetPendingEngineVersion()
        {
            return this._pendingEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PendingHostInstanceType. The host instance type of the
        /// broker to upgrade to. For a list of supported instance types, see https://docs.aws.amazon.com/amazon-mq/latest/developer-guide//broker.html#broker-instance-types
        /// </summary>
        public string PendingHostInstanceType
        {
            get { return this._pendingHostInstanceType; }
            set { this._pendingHostInstanceType = value; }
        }

        // Check to see if PendingHostInstanceType property is set
        internal bool IsSetPendingHostInstanceType()
        {
            return this._pendingHostInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property PendingLdapServerMetadata. The metadata of the LDAP server
        /// that will be used to authenticate and authorize connections to the broker once it
        /// is rebooted.
        /// </summary>
        public LdapServerMetadataOutput PendingLdapServerMetadata
        {
            get { return this._pendingLdapServerMetadata; }
            set { this._pendingLdapServerMetadata = value; }
        }

        // Check to see if PendingLdapServerMetadata property is set
        internal bool IsSetPendingLdapServerMetadata()
        {
            return this._pendingLdapServerMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property PendingSecurityGroups. The list of pending security groups
        /// to authorize connections to brokers.
        /// </summary>
        public List<string> PendingSecurityGroups
        {
            get { return this._pendingSecurityGroups; }
            set { this._pendingSecurityGroups = value; }
        }

        // Check to see if PendingSecurityGroups property is set
        internal bool IsSetPendingSecurityGroups()
        {
            return this._pendingSecurityGroups != null && this._pendingSecurityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. Required. Enables connections from
        /// applications outside of the VPC that hosts the broker's subnets.
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this._publiclyAccessible.GetValueOrDefault(); }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. The list of security groups (1 minimum,
        /// 5 maximum) that authorizes connections to brokers.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. The broker's storage type.
        /// </summary>
        public BrokerStorageType StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. The list of groups that define which subnets
        /// and IP ranges the broker can use from different Availability Zones. A SINGLE_INSTANCE
        /// deployment requires one subnet (for example, the default subnet). An ACTIVE_STANDBY_MULTI_AZ
        /// deployment (ACTIVEMQ) requires two subnets. A CLUSTER_MULTI_AZ deployment (RABBITMQ)
        /// has no subnet requirements when deployed with public accessibility, deployment without
        /// public accessibility requires at least one subnet.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. The list of all tags associated with this broker.
        /// </summary>
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
        /// Gets and sets the property Users. The list of all broker usernames for the specified
        /// broker.
        /// </summary>
        public List<UserSummary> Users
        {
            get { return this._users; }
            set { this._users = value; }
        }

        // Check to see if Users property is set
        internal bool IsSetUsers()
        {
            return this._users != null && this._users.Count > 0; 
        }

    }
}