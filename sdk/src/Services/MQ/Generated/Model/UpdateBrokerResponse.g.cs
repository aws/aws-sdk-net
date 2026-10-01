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
    /// This is the response object from the UpdateBroker operation.
    /// </summary>
    public partial class UpdateBrokerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthenticationStrategy. 
        /// <para>
        /// Optional. The authentication strategy used to secure the broker. The default is SIMPLE.
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
        /// Gets and sets the property BrokerId. 
        /// <para>
        /// Required. The unique ID that Amazon MQ generates for the broker.
        /// </para>
        /// </summary>
        public string BrokerId { get; set; }

        /// <summary>
        /// Checks to see if the BrokerId property is set.
        /// </summary>
        internal bool IsSetBrokerId() => this.BrokerId != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The ID of the updated configuration.
        /// </para>
        /// </summary>
        public ConfigurationId Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The broker engine version to upgrade to. For more information, see the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/activemq-version-management.html">ActiveMQ
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
        /// The broker's host instance type to upgrade to. For a list of supported instance types,
        /// see <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/broker.html#broker-instance-types">Broker
        /// instance types</a>.
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
        /// Optional. The metadata of the LDAP server used to authenticate and authorize connections
        /// to the broker. Does not apply to RabbitMQ brokers.
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
        /// The list of information about logs to be enabled for the specified broker.
        /// </para>
        /// </summary>
        public Logs Logs { get; set; }

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
        /// Gets and sets the property ResourceShareArns. 
        /// <para>
        /// The pending broker's target list of resource shares
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceShareArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceShareArns property is set.
        /// </summary>
        internal bool IsSetResourceShareArns() => this.ResourceShareArns != null && (this.ResourceShareArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The list of security groups (1 minimum, 5 maximum) that authorizes connections to
        /// brokers.
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
    }
}
