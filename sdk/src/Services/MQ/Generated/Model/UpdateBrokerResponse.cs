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
    /// This is the response object from the UpdateBroker operation.
    /// </summary>
    public partial class UpdateBrokerResponse : AmazonWebServiceResponse
    {
        private AuthenticationStrategy _authenticationStrategy;
        private bool? _autoMinorVersionUpgrade;
        private string _brokerId;
        private ConfigurationId _configuration;
        private DataReplicationMetadataOutput _dataReplicationMetadata;
        private DataReplicationMode _dataReplicationMode;
        private string _engineVersion;
        private string _hostInstanceType;
        private LdapServerMetadataOutput _ldapServerMetadata;
        private Logs _logs;
        private WeeklyStartTime _maintenanceWindowStartTime;
        private DataReplicationMetadataOutput _pendingDataReplicationMetadata;
        private DataReplicationMode _pendingDataReplicationMode;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property BrokerId. 
        /// <para>
        /// Required. The unique ID that Amazon MQ generates for the broker.
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
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The ID of the updated configuration.
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The broker engine version to upgrade to. For more information, see the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/activemq-version-management.html">ActiveMQ
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
        /// The broker's host instance type to upgrade to. For a list of supported instance types,
        /// see <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/broker.html#broker-instance-types">Broker
        /// instance types</a>.
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
        /// Optional. The metadata of the LDAP server used to authenticate and authorize connections
        /// to the broker. Does not apply to RabbitMQ brokers.
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
        /// The list of information about logs to be enabled for the specified broker.
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
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The list of security groups (1 minimum, 5 maximum) that authorizes connections to
        /// brokers.
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

    }
}