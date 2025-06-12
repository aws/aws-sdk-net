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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MQ.Model
{
    /// <summary>
    /// This is the response object from the DescribeBroker operation.
    /// </summary>
    public partial class DescribeBrokerResponse : AmazonWebServiceResponse
    {
        private List<ActionRequired> _actionsRequired = AWSConfigs.InitializeCollections ? new List<ActionRequired>() : null;
        private AuthenticationStrategy _authenticationStrategy;
        private bool? _autoMinorVersionUpgrade;
        private string _brokerArn;
        private string _brokerId;
        private List<BrokerInstance> _brokerInstances = AWSConfigs.InitializeCollections ? new List<BrokerInstance>() : null;
        private string _brokerName;
        private BrokerState _brokerState;
        private Configurations _configurations;
        private DateTime? _created;
        private DataReplicationMetadataOutput _dataReplicationMetadata;
        private DataReplicationMode _dataReplicationMode;
        private DeploymentMode _deploymentMode;
        private EncryptionOptions _encryptionOptions;
        private EngineType _engineType;
        private string _engineVersion;
        private string _hostInstanceType;
        private LdapServerMetadataOutput _ldapServerMetadata;
        private LogsSummary _logs;
        private WeeklyStartTime _maintenanceWindowStartTime;
        private AuthenticationStrategy _pendingAuthenticationStrategy;
        private DataReplicationMetadataOutput _pendingDataReplicationMetadata;
        private DataReplicationMode _pendingDataReplicationMode;
        private string _pendingEngineVersion;
        private string _pendingHostInstanceType;
        private LdapServerMetadataOutput _pendingLdapServerMetadata;
        private List<string> _pendingSecurityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _publiclyAccessible;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private BrokerStorageType _storageType;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<UserSummary> _users = AWSConfigs.InitializeCollections ? new List<UserSummary>() : null;

        /// <summary>
        /// Gets and sets the property ActionsRequired. 
        /// <para>
        /// Actions required for a broker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ActionRequired> ActionsRequired
        {
            get { return this._actionsRequired; }
            set { this._actionsRequired = value; }
        }

        // Check to see if ActionsRequired property is set
        internal bool IsSetActionsRequired()
        {
            return this._actionsRequired != null && (this._actionsRequired.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationStrategy. 
        /// <para>
        /// The authentication strategy used to secure the broker. The default is SIMPLE.
        /// </para>
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
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Enables automatic upgrades to new patch versions for brokers as new versions are released
        /// and supported by Amazon MQ. Automatic upgrades occur during the scheduled maintenance
        /// window or after a manual broker reboot.
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade; }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BrokerArn. 
        /// <para>
        /// The broker's Amazon Resource Name (ARN).
        /// </para>
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
        /// Gets and sets the property BrokerId. 
        /// <para>
        /// The unique ID that Amazon MQ generates for the broker.
        /// </para>
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
        /// Gets and sets the property BrokerInstances. 
        /// <para>
        /// A list of information about allocated brokers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BrokerInstance> BrokerInstances
        {
            get { return this._brokerInstances; }
            set { this._brokerInstances = value; }
        }

        // Check to see if BrokerInstances property is set
        internal bool IsSetBrokerInstances()
        {
            return this._brokerInstances != null && (this._brokerInstances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BrokerName. 
        /// <para>
        /// The broker's name. This value must be unique in your Amazon Web Services account account,
        /// 1-50 characters long, must contain only letters, numbers, dashes, and underscores,
        /// and must not contain white spaces, brackets, wildcard characters, or special characters.
        /// </para>
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
        /// Gets and sets the property BrokerState. 
        /// <para>
        /// The broker's status.
        /// </para>
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
        /// Gets and sets the property Configurations. 
        /// <para>
        /// The list of all revisions for the specified configuration.
        /// </para>
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
        /// Gets and sets the property Created. 
        /// <para>
        /// The time when the broker was created.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataReplicationMetadata. 
        /// <para>
        /// The replication details of the data replication-enabled broker. Only returned if dataReplicationMode
        /// is set to CRDR.
        /// </para>
        /// </summary>
        public DataReplicationMetadataOutput DataReplicationMetadata
        {
            get { return this._dataReplicationMetadata; }
            set { this._dataReplicationMetadata = value; }
        }

        // Check to see if DataReplicationMetadata property is set
        internal bool IsSetDataReplicationMetadata()
        {
            return this._dataReplicationMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property DataReplicationMode. 
        /// <para>
        /// Describes whether this broker is a part of a data replication pair.
        /// </para>
        /// </summary>
        public DataReplicationMode DataReplicationMode
        {
            get { return this._dataReplicationMode; }
            set { this._dataReplicationMode = value; }
        }

        // Check to see if DataReplicationMode property is set
        internal bool IsSetDataReplicationMode()
        {
            return this._dataReplicationMode != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentMode. 
        /// <para>
        /// The broker's deployment mode.
        /// </para>
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
        /// Gets and sets the property EncryptionOptions. 
        /// <para>
        /// Encryption options for the broker.
        /// </para>
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
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The type of broker engine. Currently, Amazon MQ supports ACTIVEMQ and RABBITMQ.
        /// </para>
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The broker engine version. For more information, see the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/activemq-version-management.html">ActiveMQ
        /// version management</a> and the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/rabbitmq-version-management.html">RabbitMQ
        /// version management</a> sections in the Amazon MQ Developer Guide.
        /// </para>
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
        /// Gets and sets the property HostInstanceType. 
        /// <para>
        /// The broker's instance type.
        /// </para>
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
        /// Gets and sets the property LdapServerMetadata. 
        /// <para>
        /// The metadata of the LDAP server used to authenticate and authorize connections to
        /// the broker.
        /// </para>
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
        /// Gets and sets the property Logs. 
        /// <para>
        /// The list of information about logs currently enabled and pending to be deployed for
        /// the specified broker.
        /// </para>
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
        /// Gets and sets the property MaintenanceWindowStartTime. 
        /// <para>
        /// The parameters that determine the WeeklyStartTime.
        /// </para>
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
        /// Gets and sets the property PendingAuthenticationStrategy. 
        /// <para>
        /// The authentication strategy that will be applied when the broker is rebooted. The
        /// default is SIMPLE.
        /// </para>
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
        /// Gets and sets the property PendingDataReplicationMetadata. 
        /// <para>
        /// The pending replication details of the data replication-enabled broker. Only returned
        /// if pendingDataReplicationMode is set to CRDR.
        /// </para>
        /// </summary>
        public DataReplicationMetadataOutput PendingDataReplicationMetadata
        {
            get { return this._pendingDataReplicationMetadata; }
            set { this._pendingDataReplicationMetadata = value; }
        }

        // Check to see if PendingDataReplicationMetadata property is set
        internal bool IsSetPendingDataReplicationMetadata()
        {
            return this._pendingDataReplicationMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property PendingDataReplicationMode. 
        /// <para>
        /// Describes whether this broker will be a part of a data replication pair after reboot.
        /// </para>
        /// </summary>
        public DataReplicationMode PendingDataReplicationMode
        {
            get { return this._pendingDataReplicationMode; }
            set { this._pendingDataReplicationMode = value; }
        }

        // Check to see if PendingDataReplicationMode property is set
        internal bool IsSetPendingDataReplicationMode()
        {
            return this._pendingDataReplicationMode != null;
        }

        /// <summary>
        /// Gets and sets the property PendingEngineVersion. 
        /// <para>
        /// The broker engine version to upgrade to. For more information, see the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/activemq-version-management.html">ActiveMQ
        /// version management</a> and the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/rabbitmq-version-management.html">RabbitMQ
        /// version management</a> sections in the Amazon MQ Developer Guide.
        /// </para>
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
        /// Gets and sets the property PendingHostInstanceType. 
        /// <para>
        /// The broker's host instance type to upgrade to. For a list of supported instance types,
        /// see <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/broker.html#broker-instance-types">Broker
        /// instance types</a>.
        /// </para>
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
        /// Gets and sets the property PendingLdapServerMetadata. 
        /// <para>
        /// The metadata of the LDAP server that will be used to authenticate and authorize connections
        /// to the broker after it is rebooted.
        /// </para>
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
        /// Gets and sets the property PendingSecurityGroups. 
        /// <para>
        /// The list of pending security groups to authorize connections to brokers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PendingSecurityGroups
        {
            get { return this._pendingSecurityGroups; }
            set { this._pendingSecurityGroups = value; }
        }

        // Check to see if PendingSecurityGroups property is set
        internal bool IsSetPendingSecurityGroups()
        {
            return this._pendingSecurityGroups != null && (this._pendingSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Enables connections from applications outside of the VPC that hosts the broker's subnets.
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
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The list of rules (1 minimum, 125 maximum) that authorize connections to brokers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The broker's storage type.
        /// </para>
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The list of groups that define which subnets and IP ranges the broker can use from
        /// different Availability Zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of all tags associated with this broker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property Users. 
        /// <para>
        /// The list of all broker usernames for the specified broker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserSummary> Users
        {
            get { return this._users; }
            set { this._users = value; }
        }

        // Check to see if Users property is set
        internal bool IsSetUsers()
        {
            return this._users != null && (this._users.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}