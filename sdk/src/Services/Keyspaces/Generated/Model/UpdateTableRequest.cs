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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTable operation.
    /// Adds new columns to the table or updates one of the table's settings, for example
    /// capacity mode, auto scaling, encryption, point-in-time recovery, or ttl settings.
    /// Note that you can only update one specific table setting per update operation.
    /// </summary>
    public partial class UpdateTableRequest : AmazonKeyspacesRequest
    {
        private List<ColumnDefinition> _addColumns = AWSConfigs.InitializeCollections ? new List<ColumnDefinition>() : null;
        private AutoScalingSpecification _autoScalingSpecification;
        private CapacitySpecification _capacitySpecification;
        private CdcSpecification _cdcSpecification;
        private ClientSideTimestamps _clientSideTimestamps;
        private int? _defaultTimeToLive;
        private EncryptionSpecification _encryptionSpecification;
        private string _keyspaceName;
        private PointInTimeRecovery _pointInTimeRecovery;
        private List<ReplicaSpecification> _replicaSpecifications = AWSConfigs.InitializeCollections ? new List<ReplicaSpecification>() : null;
        private string _tableName;
        private TimeToLive _ttl;

        /// <summary>
        /// Gets and sets the property AddColumns. 
        /// <para>
        /// For each column to be added to the specified table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>name</c> - The name of the column.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type</c> - An Amazon Keyspaces data type. For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/cql.elements.html#cql.data-types">Data
        /// types</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ColumnDefinition> AddColumns
        {
            get { return this._addColumns; }
            set { this._addColumns = value; }
        }

        // Check to see if AddColumns property is set
        internal bool IsSetAddColumns()
        {
            return this._addColumns != null && (this._addColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoScalingSpecification. 
        /// <para>
        /// The optional auto scaling settings to update for a table in provisioned capacity mode.
        /// Specifies if the service can manage throughput capacity of a provisioned table automatically
        /// on your behalf. Amazon Keyspaces auto scaling helps you provision throughput capacity
        /// for variable workloads efficiently by increasing and decreasing your table's read
        /// and write capacity automatically in response to application traffic.
        /// </para>
        ///  
        /// <para>
        /// If auto scaling is already enabled for the table, you can use <c>UpdateTable</c> to
        /// update the minimum and maximum values or the auto scaling policy settings independently.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/autoscaling.html">Managing
        /// throughput capacity automatically with Amazon Keyspaces auto scaling</a> in the <i>Amazon
        /// Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        public AutoScalingSpecification AutoScalingSpecification
        {
            get { return this._autoScalingSpecification; }
            set { this._autoScalingSpecification = value; }
        }

        // Check to see if AutoScalingSpecification property is set
        internal bool IsSetAutoScalingSpecification()
        {
            return this._autoScalingSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property CapacitySpecification. 
        /// <para>
        /// Modifies the read/write throughput capacity mode for the table. The options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>throughputMode:PAY_PER_REQUEST</c> and 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>throughputMode:PROVISIONED</c> - Provisioned capacity mode requires <c>readCapacityUnits</c>
        /// and <c>writeCapacityUnits</c> as input.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>throughput_mode:PAY_PER_REQUEST</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/ReadWriteCapacityMode.html">Read/write
        /// capacity modes</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        public CapacitySpecification CapacitySpecification
        {
            get { return this._capacitySpecification; }
            set { this._capacitySpecification = value; }
        }

        // Check to see if CapacitySpecification property is set
        internal bool IsSetCapacitySpecification()
        {
            return this._capacitySpecification != null;
        }

        /// <summary>
        /// Gets and sets the property CdcSpecification. 
        /// <para>
        /// The CDC stream settings of the table.
        /// </para>
        /// </summary>
        public CdcSpecification CdcSpecification
        {
            get { return this._cdcSpecification; }
            set { this._cdcSpecification = value; }
        }

        // Check to see if CdcSpecification property is set
        internal bool IsSetCdcSpecification()
        {
            return this._cdcSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSideTimestamps. 
        /// <para>
        /// Enables client-side timestamps for the table. By default, the setting is disabled.
        /// You can enable client-side timestamps with the following option:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>status: "enabled"</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Once client-side timestamps are enabled for a table, this setting cannot be disabled.
        /// </para>
        /// </summary>
        public ClientSideTimestamps ClientSideTimestamps
        {
            get { return this._clientSideTimestamps; }
            set { this._clientSideTimestamps = value; }
        }

        // Check to see if ClientSideTimestamps property is set
        internal bool IsSetClientSideTimestamps()
        {
            return this._clientSideTimestamps != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTimeToLive. 
        /// <para>
        /// The default Time to Live setting in seconds for the table.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/TTL-how-it-works.html#ttl-howitworks_default_ttl">Setting
        /// the default TTL value for a table</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=630720000)]
        public int? DefaultTimeToLive
        {
            get { return this._defaultTimeToLive; }
            set { this._defaultTimeToLive = value; }
        }

        // Check to see if DefaultTimeToLive property is set
        internal bool IsSetDefaultTimeToLive()
        {
            return this._defaultTimeToLive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionSpecification. 
        /// <para>
        /// Modifies the encryption settings of the table. You can choose one of the following
        /// KMS key (KMS key):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>type:AWS_OWNED_KMS_KEY</c> - This key is owned by Amazon Keyspaces. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type:CUSTOMER_MANAGED_KMS_KEY</c> - This key is stored in your account and is
        /// created, owned, and managed by you. This option requires the <c>kms_key_identifier</c>
        /// of the KMS key in Amazon Resource Name (ARN) format as input. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>AWS_OWNED_KMS_KEY</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/EncryptionAtRest.html">Encryption
        /// at rest</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        public EncryptionSpecification EncryptionSpecification
        {
            get { return this._encryptionSpecification; }
            set { this._encryptionSpecification = value; }
        }

        // Check to see if EncryptionSpecification property is set
        internal bool IsSetEncryptionSpecification()
        {
            return this._encryptionSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace the specified table is stored in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property PointInTimeRecovery. 
        /// <para>
        /// Modifies the <c>pointInTimeRecovery</c> settings of the table. The options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>status=ENABLED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status=DISABLED</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If it's not specified, the default is <c>status=DISABLED</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/PointInTimeRecovery.html">Point-in-time
        /// recovery</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        public PointInTimeRecovery PointInTimeRecovery
        {
            get { return this._pointInTimeRecovery; }
            set { this._pointInTimeRecovery = value; }
        }

        // Check to see if PointInTimeRecovery property is set
        internal bool IsSetPointInTimeRecovery()
        {
            return this._pointInTimeRecovery != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaSpecifications. 
        /// <para>
        /// The Region specific settings of a multi-Regional table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ReplicaSpecification> ReplicaSpecifications
        {
            get { return this._replicaSpecifications; }
            set { this._replicaSpecifications = value; }
        }

        // Check to see if ReplicaSpecifications property is set
        internal bool IsSetReplicaSpecifications()
        {
            return this._replicaSpecifications != null && (this._replicaSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        /// Modifies Time to Live custom settings for the table. The options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>status:enabled</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status:disabled</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>status:disabled</c>. After <c>ttl</c> is enabled, you can't disable
        /// it for the table.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/TTL.html">Expiring
        /// data by using Amazon Keyspaces Time to Live (TTL)</a> in the <i>Amazon Keyspaces Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public TimeToLive Ttl
        {
            get { return this._ttl; }
            set { this._ttl = value; }
        }

        // Check to see if Ttl property is set
        internal bool IsSetTtl()
        {
            return this._ttl != null;
        }

    }
}