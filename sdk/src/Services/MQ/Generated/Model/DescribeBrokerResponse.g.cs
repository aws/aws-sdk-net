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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ActionsRequired. 
        /// <para>
        /// Actions required for a broker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ActionRequired> ActionsRequired { get; set; } = AWSConfigs.InitializeCollections ? new List<ActionRequired>() : null;

        /// <summary>
        /// Checks to see if the ActionsRequired property is set.
        /// </summary>
        internal bool IsSetActionsRequired() => this.ActionsRequired != null && (this.ActionsRequired.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationStrategy. 
        /// <para>
        /// The authentication strategy used to secure the broker. The default is SIMPLE.
        /// </para>
        /// </summary>
        public AuthenticationStrategy AuthenticationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationStrategy property is set.
        /// </summary>
        internal bool IsSetAuthenticationStrategy() => this.AuthenticationStrategy != null;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Enables automatic upgrades to new patch versions for brokers as new versions are released
        /// and supported by Amazon MQ. Automatic upgrades occur during the scheduled maintenance
        /// window or after a manual broker reboot.
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoMinorVersionUpgrade() => this.AutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property BrokerArn. 
        /// <para>
        /// The broker's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string BrokerArn { get; set; }

        /// <summary>
        /// Checks to see if the BrokerArn property is set.
        /// </summary>
        internal bool IsSetBrokerArn() => this.BrokerArn != null;

        /// <summary>
        /// Gets and sets the property BrokerId. 
        /// <para>
        /// The unique ID that Amazon MQ generates for the broker.
        /// </para>
        /// </summary>
        public string BrokerId { get; set; }

        /// <summary>
        /// Checks to see if the BrokerId property is set.
        /// </summary>
        internal bool IsSetBrokerId() => this.BrokerId != null;

        /// <summary>
        /// Gets and sets the property BrokerInstances. 
        /// <para>
        /// A list of information about allocated brokers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BrokerInstance> BrokerInstances { get; set; } = AWSConfigs.InitializeCollections ? new List<BrokerInstance>() : null;

        /// <summary>
        /// Checks to see if the BrokerInstances property is set.
        /// </summary>
        internal bool IsSetBrokerInstances() => this.BrokerInstances != null && (this.BrokerInstances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BrokerName. 
        /// <para>
        /// The broker's name. This value must be unique in your Amazon Web Services account account,
        /// 1-50 characters long, must contain only letters, numbers, dashes, and underscores,
        /// and must not contain white spaces, brackets, wildcard characters, or special characters.
        /// </para>
        /// </summary>
        public string BrokerName { get; set; }

        /// <summary>
        /// Checks to see if the BrokerName property is set.
        /// </summary>
        internal bool IsSetBrokerName() => this.BrokerName != null;

        /// <summary>
        /// Gets and sets the property BrokerState. 
        /// <para>
        /// The broker's status.
        /// </para>
        /// </summary>
        public BrokerState BrokerState { get; set; }

        /// <summary>
        /// Checks to see if the BrokerState property is set.
        /// </summary>
        internal bool IsSetBrokerState() => this.BrokerState != null;

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// The list of all revisions for the specified configuration.
        /// </para>
        /// </summary>
        public Configurations Configurations { get; set; }

        /// <summary>
        /// Checks to see if the Configurations property is set.
        /// </summary>
        internal bool IsSetConfigurations() => this.Configurations != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The time when the broker was created.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property DataReplicationMetadata. 
        /// <para>
        /// The replication details of the data replication-enabled broker. Only returned if dataReplicationMode
        /// is set to CRDR.
        /// </para>
        /// </summary>
        public DataReplicationMetadataOutput DataReplicationMetadata { get; set; }

        /// <summary>
        /// Checks to see if the DataReplicationMetadata property is set.
        /// </summary>
        internal bool IsSetDataReplicationMetadata() => this.DataReplicationMetadata != null;

        /// <summary>
        /// Gets and sets the property DataReplicationMode. 
        /// <para>
        /// Describes whether this broker is a part of a data replication pair.
        /// </para>
        /// </summary>
        public DataReplicationMode DataReplicationMode { get; set; }

        /// <summary>
        /// Checks to see if the DataReplicationMode property is set.
        /// </summary>
        internal bool IsSetDataReplicationMode() => this.DataReplicationMode != null;

        /// <summary>
        /// Gets and sets the property DeploymentMode. 
        /// <para>
        /// The broker's deployment mode.
        /// </para>
        /// </summary>
        public DeploymentMode DeploymentMode { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentMode property is set.
        /// </summary>
        internal bool IsSetDeploymentMode() => this.DeploymentMode != null;

        /// <summary>
        /// Gets and sets the property EncryptionOptions. 
        /// <para>
        /// Encryption options for the broker.
        /// </para>
        /// </summary>
        public EncryptionOptions EncryptionOptions { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionOptions property is set.
        /// </summary>
        internal bool IsSetEncryptionOptions() => this.EncryptionOptions != null;

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The type of broker engine. Currently, Amazon MQ supports ACTIVEMQ and RABBITMQ.
        /// </para>
        /// </summary>
        public EngineType EngineType { get; set; }

        /// <summary>
        /// Checks to see if the EngineType property is set.
        /// </summary>
        internal bool IsSetEngineType() => this.EngineType != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The broker engine version. For more information, see the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/activemq-version-management.html">ActiveMQ
        /// version management</a> and the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/rabbitmq-version-management.html">RabbitMQ
        /// version management</a> sections in the Amazon MQ Developer Guide.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property HostInstanceType. 
        /// <para>
        /// The broker's instance type.
        /// </para>
        /// </summary>
        public string HostInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the HostInstanceType property is set.
        /// </summary>
        internal bool IsSetHostInstanceType() => this.HostInstanceType != null;

        /// <summary>
        /// Gets and sets the property LdapServerMetadata. 
        /// <para>
        /// The metadata of the LDAP server used to authenticate and authorize connections to
        /// the broker.
        /// </para>
        /// </summary>
        public LdapServerMetadataOutput LdapServerMetadata { get; set; }

        /// <summary>
        /// Checks to see if the LdapServerMetadata property is set.
        /// </summary>
        internal bool IsSetLdapServerMetadata() => this.LdapServerMetadata != null;

        /// <summary>
        /// Gets and sets the property Logs. 
        /// <para>
        /// The list of information about logs currently enabled and pending to be deployed for
        /// the specified broker.
        /// </para>
        /// </summary>
        public LogsSummary Logs { get; set; }

        /// <summary>
        /// Checks to see if the Logs property is set.
        /// </summary>
        internal bool IsSetLogs() => this.Logs != null;

        /// <summary>
        /// Gets and sets the property MaintenanceWindowStartTime. 
        /// <para>
        /// The parameters that determine the WeeklyStartTime.
        /// </para>
        /// </summary>
        public WeeklyStartTime MaintenanceWindowStartTime { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceWindowStartTime property is set.
        /// </summary>
        internal bool IsSetMaintenanceWindowStartTime() => this.MaintenanceWindowStartTime != null;

        /// <summary>
        /// Gets and sets the property PendingAuthenticationStrategy. 
        /// <para>
        /// The authentication strategy that will be applied when the broker is rebooted. The
        /// default is SIMPLE.
        /// </para>
        /// </summary>
        public AuthenticationStrategy PendingAuthenticationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the PendingAuthenticationStrategy property is set.
        /// </summary>
        internal bool IsSetPendingAuthenticationStrategy() => this.PendingAuthenticationStrategy != null;

        /// <summary>
        /// Gets and sets the property PendingDataReplicationMetadata. 
        /// <para>
        /// The pending replication details of the data replication-enabled broker. Only returned
        /// if pendingDataReplicationMode is set to CRDR.
        /// </para>
        /// </summary>
        public DataReplicationMetadataOutput PendingDataReplicationMetadata { get; set; }

        /// <summary>
        /// Checks to see if the PendingDataReplicationMetadata property is set.
        /// </summary>
        internal bool IsSetPendingDataReplicationMetadata() => this.PendingDataReplicationMetadata != null;

        /// <summary>
        /// Gets and sets the property PendingDataReplicationMode. 
        /// <para>
        /// Describes whether this broker will be a part of a data replication pair after reboot.
        /// </para>
        /// </summary>
        public DataReplicationMode PendingDataReplicationMode { get; set; }

        /// <summary>
        /// Checks to see if the PendingDataReplicationMode property is set.
        /// </summary>
        internal bool IsSetPendingDataReplicationMode() => this.PendingDataReplicationMode != null;

        /// <summary>
        /// Gets and sets the property PendingEngineVersion. 
        /// <para>
        /// The broker engine version to upgrade to. For more information, see the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/activemq-version-management.html">ActiveMQ
        /// version management</a> and the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/rabbitmq-version-management.html">RabbitMQ
        /// version management</a> sections in the Amazon MQ Developer Guide.
        /// </para>
        /// </summary>
        public string PendingEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the PendingEngineVersion property is set.
        /// </summary>
        internal bool IsSetPendingEngineVersion() => this.PendingEngineVersion != null;

        /// <summary>
        /// Gets and sets the property PendingHostInstanceType. 
        /// <para>
        /// The broker's host instance type to upgrade to. For a list of supported instance types,
        /// see <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/broker.html#broker-instance-types">Broker
        /// instance types</a>.
        /// </para>
        /// </summary>
        public string PendingHostInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the PendingHostInstanceType property is set.
        /// </summary>
        internal bool IsSetPendingHostInstanceType() => this.PendingHostInstanceType != null;

        /// <summary>
        /// Gets and sets the property PendingLdapServerMetadata. 
        /// <para>
        /// The metadata of the LDAP server that will be used to authenticate and authorize connections
        /// to the broker after it is rebooted.
        /// </para>
        /// </summary>
        public LdapServerMetadataOutput PendingLdapServerMetadata { get; set; }

        /// <summary>
        /// Checks to see if the PendingLdapServerMetadata property is set.
        /// </summary>
        internal bool IsSetPendingLdapServerMetadata() => this.PendingLdapServerMetadata != null;

        /// <summary>
        /// Gets and sets the property PendingSecurityGroups. 
        /// <para>
        /// The list of pending security groups to authorize connections to brokers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PendingSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PendingSecurityGroups property is set.
        /// </summary>
        internal bool IsSetPendingSecurityGroups() => this.PendingSecurityGroups != null && (this.PendingSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PendingStorageSize. 
        /// <para>
        /// The pending storage size in GB, to be applied on the next broker restart.
        /// </para>
        /// </summary>
        public int? PendingStorageSize { get; set; }

        /// <summary>
        /// Checks to see if the PendingStorageSize property is set.
        /// </summary>
        internal bool IsSetPendingStorageSize() => this.PendingStorageSize.HasValue;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Enables connections from applications outside of the VPC that hosts the broker's subnets.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The list of rules (1 minimum, 125 maximum) that authorize connections to brokers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageSize. 
        /// <para>
        /// The broker's storage size in GB.
        /// </para>
        /// </summary>
        public int? StorageSize { get; set; }

        /// <summary>
        /// Checks to see if the StorageSize property is set.
        /// </summary>
        internal bool IsSetStorageSize() => this.StorageSize.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The broker's storage type.
        /// </para>
        /// </summary>
        public BrokerStorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The list of groups that define which subnets and IP ranges the broker can use from
        /// different Availability Zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of all tags associated with this broker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Users. 
        /// <para>
        /// The list of all broker usernames for the specified broker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserSummary> Users { get; set; } = AWSConfigs.InitializeCollections ? new List<UserSummary>() : null;

        /// <summary>
        /// Checks to see if the Users property is set.
        /// </summary>
        internal bool IsSetUsers() => this.Users != null && (this.Users.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
