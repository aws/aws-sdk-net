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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Amazon MQ message broker. A message broker allows software
    /// applications and components to communicate using various programming languages, operating
    /// systems, and formal messaging protocols.
    /// </summary>
    public partial class AwsAmazonMqBrokerDetails
    {
        private string _authenticationStrategy;
        private bool? _autoMinorVersionUpgrade;
        private string _brokerArn;
        private string _brokerId;
        private string _brokerName;
        private string _deploymentMode;
        private AwsAmazonMqBrokerEncryptionOptionsDetails _encryptionOptions;
        private string _engineType;
        private string _engineVersion;
        private string _hostInstanceType;
        private AwsAmazonMqBrokerLdapServerMetadataDetails _ldapServerMetadata;
        private AwsAmazonMqBrokerLogsDetails _logs;
        private AwsAmazonMqBrokerMaintenanceWindowStartTimeDetails _maintenanceWindowStartTime;
        private bool? _publiclyAccessible;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _storageType;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<AwsAmazonMqBrokerUsersDetails> _users = AWSConfigs.InitializeCollections ? new List<AwsAmazonMqBrokerUsersDetails>() : null;

        /// <summary>
        /// Gets and sets the property AuthenticationStrategy. 
        /// <para>
        ///  The authentication strategy used to secure the broker. The default is <c>SIMPLE</c>.
        /// 
        /// </para>
        /// </summary>
        public string AuthenticationStrategy
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
        ///  Whether automatically upgrade new minor versions for brokers, as new versions are
        /// released and supported by Amazon MQ. Automatic upgrades occur during the scheduled
        /// maintenance window of the broker or after a manual broker reboot. 
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
        ///  The Amazon Resource Name (ARN) of the broker. 
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
        ///  The unique ID that Amazon MQ generates for the broker. 
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
        /// Gets and sets the property BrokerName. 
        /// <para>
        /// The broker's name. 
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
        /// Gets and sets the property DeploymentMode. 
        /// <para>
        ///  The broker's deployment mode. 
        /// </para>
        /// </summary>
        public string DeploymentMode
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
        ///  Encryption options for the broker. Doesn’t apply to RabbitMQ brokers. 
        /// </para>
        /// </summary>
        public AwsAmazonMqBrokerEncryptionOptionsDetails EncryptionOptions
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
        ///  The type of broker engine. 
        /// </para>
        /// </summary>
        public string EngineType
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
        ///  The version of the broker engine. 
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
        ///  The broker's instance type. 
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
        ///  The metadata of the Lightweight Directory Access Protocol (LDAP) server used to authenticate
        /// and authorize connections to the broker. This is an optional failover server. 
        /// </para>
        /// </summary>
        public AwsAmazonMqBrokerLdapServerMetadataDetails LdapServerMetadata
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
        ///  Turns on Amazon CloudWatch logging for brokers. 
        /// </para>
        /// </summary>
        public AwsAmazonMqBrokerLogsDetails Logs
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
        ///  The scheduled time period (UTC) during which Amazon MQ begins to apply pending updates
        /// or patches to the broker. 
        /// </para>
        /// </summary>
        public AwsAmazonMqBrokerMaintenanceWindowStartTimeDetails MaintenanceWindowStartTime
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
        ///  Permits connections from applications outside of the VPC that hosts the broker's
        /// subnets. 
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
        ///  The list of rules (one minimum, 125 maximum) that authorize connections to brokers.
        /// 
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
        ///  The broker's storage type. 
        /// </para>
        /// </summary>
        public string StorageType
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
        ///  The list of groups that define which subnets and IP ranges the broker can use from
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
        /// Gets and sets the property Users. 
        /// <para>
        ///  The list of all broker usernames for the specified broker. Doesn't apply to RabbitMQ
        /// brokers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsAmazonMqBrokerUsersDetails> Users
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