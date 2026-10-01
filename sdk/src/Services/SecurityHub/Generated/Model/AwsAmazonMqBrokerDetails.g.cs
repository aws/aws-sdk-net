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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Amazon MQ message broker. A message broker allows software
    /// applications and components to communicate using various programming languages, operating
    /// systems, and formal messaging protocols.
    /// </summary>
    public partial class AwsAmazonMqBrokerDetails
    {
        /// <summary>
        /// Gets and sets the property AuthenticationStrategy. 
        /// <para>
        ///  The authentication strategy used to secure the broker. The default is <c>SIMPLE</c>.
        /// 
        /// </para>
        /// </summary>
        public string AuthenticationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationStrategy property is set.
        /// </summary>
        internal bool IsSetAuthenticationStrategy() => this.AuthenticationStrategy != null;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        ///  Whether automatically upgrade new minor versions for brokers, as new versions are
        /// released and supported by Amazon MQ. Automatic upgrades occur during the scheduled
        /// maintenance window of the broker or after a manual broker reboot. 
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
        ///  The Amazon Resource Name (ARN) of the broker. 
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
        ///  The unique ID that Amazon MQ generates for the broker. 
        /// </para>
        /// </summary>
        public string BrokerId { get; set; }

        /// <summary>
        /// Checks to see if the BrokerId property is set.
        /// </summary>
        internal bool IsSetBrokerId() => this.BrokerId != null;

        /// <summary>
        /// Gets and sets the property BrokerName. 
        /// <para>
        /// The broker's name. 
        /// </para>
        /// </summary>
        public string BrokerName { get; set; }

        /// <summary>
        /// Checks to see if the BrokerName property is set.
        /// </summary>
        internal bool IsSetBrokerName() => this.BrokerName != null;

        /// <summary>
        /// Gets and sets the property DeploymentMode. 
        /// <para>
        ///  The broker's deployment mode. 
        /// </para>
        /// </summary>
        public string DeploymentMode { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentMode property is set.
        /// </summary>
        internal bool IsSetDeploymentMode() => this.DeploymentMode != null;

        /// <summary>
        /// Gets and sets the property EncryptionOptions. 
        /// <para>
        ///  Encryption options for the broker. Doesn’t apply to RabbitMQ brokers. 
        /// </para>
        /// </summary>
        public AwsAmazonMqBrokerEncryptionOptionsDetails EncryptionOptions { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionOptions property is set.
        /// </summary>
        internal bool IsSetEncryptionOptions() => this.EncryptionOptions != null;

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        ///  The type of broker engine. 
        /// </para>
        /// </summary>
        public string EngineType { get; set; }

        /// <summary>
        /// Checks to see if the EngineType property is set.
        /// </summary>
        internal bool IsSetEngineType() => this.EngineType != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        ///  The version of the broker engine. 
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
        ///  The broker's instance type. 
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
        ///  The metadata of the Lightweight Directory Access Protocol (LDAP) server used to authenticate
        /// and authorize connections to the broker. This is an optional failover server. 
        /// </para>
        /// </summary>
        public AwsAmazonMqBrokerLdapServerMetadataDetails LdapServerMetadata { get; set; }

        /// <summary>
        /// Checks to see if the LdapServerMetadata property is set.
        /// </summary>
        internal bool IsSetLdapServerMetadata() => this.LdapServerMetadata != null;

        /// <summary>
        /// Gets and sets the property Logs. 
        /// <para>
        ///  Turns on Amazon CloudWatch logging for brokers. 
        /// </para>
        /// </summary>
        public AwsAmazonMqBrokerLogsDetails Logs { get; set; }

        /// <summary>
        /// Checks to see if the Logs property is set.
        /// </summary>
        internal bool IsSetLogs() => this.Logs != null;

        /// <summary>
        /// Gets and sets the property MaintenanceWindowStartTime. 
        /// <para>
        ///  The scheduled time period (UTC) during which Amazon MQ begins to apply pending updates
        /// or patches to the broker. 
        /// </para>
        /// </summary>
        public AwsAmazonMqBrokerMaintenanceWindowStartTimeDetails MaintenanceWindowStartTime { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceWindowStartTime property is set.
        /// </summary>
        internal bool IsSetMaintenanceWindowStartTime() => this.MaintenanceWindowStartTime != null;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        ///  Permits connections from applications outside of the VPC that hosts the broker's
        /// subnets. 
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
        ///  The list of rules (one minimum, 125 maximum) that authorize connections to brokers.
        /// 
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
        /// Gets and sets the property StorageType. 
        /// <para>
        ///  The broker's storage type. 
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        ///  The list of groups that define which subnets and IP ranges the broker can use from
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
        /// Gets and sets the property Users. 
        /// <para>
        ///  The list of all broker usernames for the specified broker. Doesn't apply to RabbitMQ
        /// brokers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsAmazonMqBrokerUsersDetails> Users { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsAmazonMqBrokerUsersDetails>() : null;

        /// <summary>
        /// Checks to see if the Users property is set.
        /// </summary>
        internal bool IsSetUsers() => this.Users != null && (this.Users.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
