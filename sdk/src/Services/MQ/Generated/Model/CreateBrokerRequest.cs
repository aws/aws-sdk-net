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
    /// Container for the parameters to the CreateBroker operation.
    /// Creates a broker. Note: This API is asynchronous.
    /// 
    ///  
    /// <para>
    /// To create a broker, you must either use the AmazonMQFullAccess IAM policy or include
    /// the following EC2 permissions in your IAM policy.
    /// </para>
    ///  <ul><li>
    /// <para>
    /// ec2:CreateNetworkInterface
    /// </para>
    ///  
    /// <para>
    /// This permission is required to allow Amazon MQ to create an elastic network interface
    /// (ENI) on behalf of your account.
    /// </para>
    /// </li> <li>
    /// <para>
    /// ec2:CreateNetworkInterfacePermission
    /// </para>
    ///  
    /// <para>
    /// This permission is required to attach the ENI to the broker instance.
    /// </para>
    /// </li> <li>
    /// <para>
    /// ec2:DeleteNetworkInterface
    /// </para>
    /// </li> <li>
    /// <para>
    /// ec2:DeleteNetworkInterfacePermission
    /// </para>
    /// </li> <li>
    /// <para>
    /// ec2:DetachNetworkInterface
    /// </para>
    /// </li> <li>
    /// <para>
    /// ec2:DescribeInternetGateways
    /// </para>
    /// </li> <li>
    /// <para>
    /// ec2:DescribeNetworkInterfaces
    /// </para>
    /// </li> <li>
    /// <para>
    /// ec2:DescribeNetworkInterfacePermissions
    /// </para>
    /// </li> <li>
    /// <para>
    /// ec2:DescribeRouteTables
    /// </para>
    /// </li> <li>
    /// <para>
    /// ec2:DescribeSecurityGroups
    /// </para>
    /// </li> <li>
    /// <para>
    /// ec2:DescribeSubnets
    /// </para>
    /// </li> <li>
    /// <para>
    /// ec2:DescribeVpcs
    /// </para>
    /// </li></ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/amazon-mq-setting-up.html#create-iam-user">Create
    /// an IAM User and Get Your Amazon Web Services Credentials</a> and <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/connecting-to-amazon-mq.html#never-modify-delete-elastic-network-interface">Never
    /// Modify or Delete the Amazon MQ Elastic Network Interface</a> in the <i>Amazon MQ Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateBrokerRequest : AmazonMQRequest
    {
        private AuthenticationStrategy _authenticationStrategy;
        private bool? _autoMinorVersionUpgrade;
        private string _brokerName;
        private ConfigurationId _configuration;
        private string _creatorRequestId;
        private DataReplicationMode _dataReplicationMode;
        private string _dataReplicationPrimaryBrokerArn;
        private DeploymentMode _deploymentMode;
        private EncryptionOptions _encryptionOptions;
        private EngineType _engineType;
        private string _engineVersion;
        private string _hostInstanceType;
        private LdapServerMetadataInput _ldapServerMetadata;
        private Logs _logs;
        private WeeklyStartTime _maintenanceWindowStartTime;
        private bool? _publiclyAccessible;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private BrokerStorageType _storageType;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<User> _users = AWSConfigs.InitializeCollections ? new List<User>() : null;

        /// <summary>
        /// Gets and sets the property AuthenticationStrategy. 
        /// <para>
        /// Optional. The authentication strategy used to secure the broker. The default is SIMPLE.
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
        /// window or after a manual broker reboot. Set to true by default, if no value is specified.
        /// </para>
        ///  <note>
        /// <para>
        /// Must be set to true for ActiveMQ brokers version 5.18 and above and for RabbitMQ brokers
        /// version 3.13 and above.
        /// </para>
        /// </note>
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
        /// Gets and sets the property BrokerName. 
        /// <para>
        /// Required. The broker's name. This value must be unique in your Amazon Web Services
        /// account, 1-50 characters long, must contain only letters, numbers, dashes, and underscores,
        /// and must not contain white spaces, brackets, wildcard characters, or special characters.
        /// </para>
        ///  <important>
        /// <para>
        /// Do not add personally identifiable information (PII) or other confidential or sensitive
        /// information in broker names. Broker names are accessible to other Amazon Web Services
        /// services, including CloudWatch Logs. Broker names are not intended to be used for
        /// private or sensitive data.
        /// </para>
        /// </important>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Configuration. 
        /// <para>
        /// A list of information about the configuration.
        /// </para>
        /// </summary>
        public ConfigurationId Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// The unique ID that the requester receives for the created broker. Amazon MQ passes
        /// your ID with the API action.
        /// </para>
        ///  <note>
        /// <para>
        /// We recommend using a Universally Unique Identifier (UUID) for the creatorRequestId.
        /// You may omit the creatorRequestId if your application doesn't require idempotency.
        /// </para>
        /// </note>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property DataReplicationMode. 
        /// <para>
        /// Defines whether this broker is a part of a data replication pair.
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
        /// Gets and sets the property DataReplicationPrimaryBrokerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the primary broker that is used to replicate data
        /// from in a data replication pair, and is applied to the replica broker. Must be set
        /// when dataReplicationMode is set to CRDR.
        /// </para>
        /// </summary>
        public string DataReplicationPrimaryBrokerArn
        {
            get { return this._dataReplicationPrimaryBrokerArn; }
            set { this._dataReplicationPrimaryBrokerArn = value; }
        }

        // Check to see if DataReplicationPrimaryBrokerArn property is set
        internal bool IsSetDataReplicationPrimaryBrokerArn()
        {
            return this._dataReplicationPrimaryBrokerArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentMode. 
        /// <para>
        /// Required. The broker's deployment mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Required. The type of broker engine. Currently, Amazon MQ supports ACTIVEMQ and RABBITMQ.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The broker engine version. Defaults to the latest available version for the specified
        /// broker engine type. For more information, see the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/activemq-version-management.html">ActiveMQ
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
        /// Required. The broker's instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Optional. The metadata of the LDAP server used to authenticate and authorize connections
        /// to the broker. Does not apply to RabbitMQ brokers.
        /// </para>
        /// </summary>
        public LdapServerMetadataInput LdapServerMetadata
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
        /// Enables Amazon CloudWatch logging for brokers.
        /// </para>
        /// </summary>
        public Logs Logs
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
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Enables connections from applications outside of the VPC that hosts the broker's subnets.
        /// Set to false by default, if no value is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// different Availability Zones. If you specify more than one subnet, the subnets must
        /// be in different Availability Zones. Amazon MQ will not be able to create VPC endpoints
        /// for your broker with multiple subnets in the same Availability Zone. A SINGLE_INSTANCE
        /// deployment requires one subnet (for example, the default subnet). An ACTIVE_STANDBY_MULTI_AZ
        /// Amazon MQ for ActiveMQ deployment requires two subnets. A CLUSTER_MULTI_AZ Amazon
        /// MQ for RabbitMQ deployment has no subnet requirements when deployed with public accessibility.
        /// Deployment without public accessibility requires at least one subnet.
        /// </para>
        ///  <important>
        /// <para>
        /// If you specify subnets in a <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-sharing.html">shared
        /// VPC</a> for a RabbitMQ broker, the associated VPC to which the specified subnets belong
        /// must be owned by your Amazon Web Services account. Amazon MQ will not be able to create
        /// VPC endpoints in VPCs that are not owned by your Amazon Web Services account.
        /// </para>
        /// </important>
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
        /// Create tags when creating the broker.
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
        /// The list of broker users (persons or applications) who can access queues and topics.
        /// For Amazon MQ for RabbitMQ brokers, an administrative user is required if using simple
        /// authentication and authorization. For brokers using OAuth2, this user is optional.
        /// When provided, one and only one administrative user is accepted and created when a
        /// broker is first provisioned. All subsequent broker users are created by making RabbitMQ
        /// API calls directly to brokers or via the RabbitMQ web console.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<User> Users
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