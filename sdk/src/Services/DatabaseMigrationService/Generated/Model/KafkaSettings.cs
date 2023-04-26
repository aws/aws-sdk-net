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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes an Apache Kafka endpoint. This information includes
    /// the output format of records applied to the endpoint and details of transaction and
    /// control table data information.
    /// </summary>
    public partial class KafkaSettings
    {
        private string _broker;
        private bool? _includeControlDetails;
        private bool? _includeNullAndEmpty;
        private bool? _includePartitionValue;
        private bool? _includeTableAlterOperations;
        private bool? _includeTransactionDetails;
        private MessageFormatValue _messageFormat;
        private int? _messageMaxBytes;
        private bool? _noHexPrefix;
        private bool? _partitionIncludeSchemaTable;
        private KafkaSaslMechanism _saslMechanism;
        private string _saslPassword;
        private string _saslUsername;
        private KafkaSecurityProtocol _securityProtocol;
        private string _sslCaCertificateArn;
        private string _sslClientCertificateArn;
        private string _sslClientKeyArn;
        private string _sslClientKeyPassword;
        private string _topic;

        /// <summary>
        /// Gets and sets the property Broker. 
        /// <para>
        /// A comma-separated list of one or more broker locations in your Kafka cluster that
        /// host your Kafka instance. Specify each broker location in the form <code> <i>broker-hostname-or-ip</i>:<i>port</i>
        /// </code>. For example, <code>"ec2-12-345-678-901.compute-1.amazonaws.com:2345"</code>.
        /// For more information and examples of specifying a list of broker locations, see <a
        /// href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Kafka.html">Using
        /// Apache Kafka as a target for Database Migration Service</a> in the <i>Database Migration
        /// Service User Guide</i>. 
        /// </para>
        /// </summary>
        public string Broker
        {
            get { return this._broker; }
            set { this._broker = value; }
        }

        // Check to see if Broker property is set
        internal bool IsSetBroker()
        {
            return this._broker != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeControlDetails. 
        /// <para>
        /// Shows detailed control information for table definition, column definition, and table
        /// and column changes in the Kafka message output. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool IncludeControlDetails
        {
            get { return this._includeControlDetails.GetValueOrDefault(); }
            set { this._includeControlDetails = value; }
        }

        // Check to see if IncludeControlDetails property is set
        internal bool IsSetIncludeControlDetails()
        {
            return this._includeControlDetails.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeNullAndEmpty. 
        /// <para>
        /// Include NULL and empty columns for records migrated to the endpoint. The default is
        /// <code>false</code>.
        /// </para>
        /// </summary>
        public bool IncludeNullAndEmpty
        {
            get { return this._includeNullAndEmpty.GetValueOrDefault(); }
            set { this._includeNullAndEmpty = value; }
        }

        // Check to see if IncludeNullAndEmpty property is set
        internal bool IsSetIncludeNullAndEmpty()
        {
            return this._includeNullAndEmpty.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludePartitionValue. 
        /// <para>
        /// Shows the partition value within the Kafka message output unless the partition type
        /// is <code>schema-table-type</code>. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool IncludePartitionValue
        {
            get { return this._includePartitionValue.GetValueOrDefault(); }
            set { this._includePartitionValue = value; }
        }

        // Check to see if IncludePartitionValue property is set
        internal bool IsSetIncludePartitionValue()
        {
            return this._includePartitionValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeTableAlterOperations. 
        /// <para>
        /// Includes any data definition language (DDL) operations that change the table in the
        /// control data, such as <code>rename-table</code>, <code>drop-table</code>, <code>add-column</code>,
        /// <code>drop-column</code>, and <code>rename-column</code>. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool IncludeTableAlterOperations
        {
            get { return this._includeTableAlterOperations.GetValueOrDefault(); }
            set { this._includeTableAlterOperations = value; }
        }

        // Check to see if IncludeTableAlterOperations property is set
        internal bool IsSetIncludeTableAlterOperations()
        {
            return this._includeTableAlterOperations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeTransactionDetails. 
        /// <para>
        /// Provides detailed transaction information from the source database. This information
        /// includes a commit timestamp, a log position, and values for <code>transaction_id</code>,
        /// previous <code>transaction_id</code>, and <code>transaction_record_id</code> (the
        /// record offset within a transaction). The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool IncludeTransactionDetails
        {
            get { return this._includeTransactionDetails.GetValueOrDefault(); }
            set { this._includeTransactionDetails = value; }
        }

        // Check to see if IncludeTransactionDetails property is set
        internal bool IsSetIncludeTransactionDetails()
        {
            return this._includeTransactionDetails.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageFormat. 
        /// <para>
        /// The output format for the records created on the endpoint. The message format is <code>JSON</code>
        /// (default) or <code>JSON_UNFORMATTED</code> (a single line with no tab).
        /// </para>
        /// </summary>
        public MessageFormatValue MessageFormat
        {
            get { return this._messageFormat; }
            set { this._messageFormat = value; }
        }

        // Check to see if MessageFormat property is set
        internal bool IsSetMessageFormat()
        {
            return this._messageFormat != null;
        }

        /// <summary>
        /// Gets and sets the property MessageMaxBytes. 
        /// <para>
        /// The maximum size in bytes for records created on the endpoint The default is 1,000,000.
        /// </para>
        /// </summary>
        public int MessageMaxBytes
        {
            get { return this._messageMaxBytes.GetValueOrDefault(); }
            set { this._messageMaxBytes = value; }
        }

        // Check to see if MessageMaxBytes property is set
        internal bool IsSetMessageMaxBytes()
        {
            return this._messageMaxBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoHexPrefix. 
        /// <para>
        /// Set this optional parameter to <code>true</code> to avoid adding a '0x' prefix to
        /// raw data in hexadecimal format. For example, by default, DMS adds a '0x' prefix to
        /// the LOB column type in hexadecimal format moving from an Oracle source to a Kafka
        /// target. Use the <code>NoHexPrefix</code> endpoint setting to enable migration of RAW
        /// data type columns without adding the '0x' prefix.
        /// </para>
        /// </summary>
        public bool NoHexPrefix
        {
            get { return this._noHexPrefix.GetValueOrDefault(); }
            set { this._noHexPrefix = value; }
        }

        // Check to see if NoHexPrefix property is set
        internal bool IsSetNoHexPrefix()
        {
            return this._noHexPrefix.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartitionIncludeSchemaTable. 
        /// <para>
        /// Prefixes schema and table names to partition values, when the partition type is <code>primary-key-type</code>.
        /// Doing this increases data distribution among Kafka partitions. For example, suppose
        /// that a SysBench schema has thousands of tables and each table has only limited range
        /// for a primary key. In this case, the same primary key is sent from thousands of tables
        /// to the same partition, which causes throttling. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool PartitionIncludeSchemaTable
        {
            get { return this._partitionIncludeSchemaTable.GetValueOrDefault(); }
            set { this._partitionIncludeSchemaTable = value; }
        }

        // Check to see if PartitionIncludeSchemaTable property is set
        internal bool IsSetPartitionIncludeSchemaTable()
        {
            return this._partitionIncludeSchemaTable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SaslMechanism. 
        /// <para>
        /// For SASL/SSL authentication, DMS supports the <code>SCRAM-SHA-512</code> mechanism
        /// by default. DMS versions 3.5.0 and later also support the <code>PLAIN</code> mechanism.
        /// To use the <code>PLAIN</code> mechanism, set this parameter to <code>PLAIN.</code>
        /// 
        /// </para>
        /// </summary>
        public KafkaSaslMechanism SaslMechanism
        {
            get { return this._saslMechanism; }
            set { this._saslMechanism = value; }
        }

        // Check to see if SaslMechanism property is set
        internal bool IsSetSaslMechanism()
        {
            return this._saslMechanism != null;
        }

        /// <summary>
        /// Gets and sets the property SaslPassword. 
        /// <para>
        /// The secure password you created when you first set up your MSK cluster to validate
        /// a client identity and make an encrypted connection between server and client using
        /// SASL-SSL authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SaslPassword
        {
            get { return this._saslPassword; }
            set { this._saslPassword = value; }
        }

        // Check to see if SaslPassword property is set
        internal bool IsSetSaslPassword()
        {
            return this._saslPassword != null;
        }

        /// <summary>
        /// Gets and sets the property SaslUsername. 
        /// <para>
        ///  The secure user name you created when you first set up your MSK cluster to validate
        /// a client identity and make an encrypted connection between server and client using
        /// SASL-SSL authentication.
        /// </para>
        /// </summary>
        public string SaslUsername
        {
            get { return this._saslUsername; }
            set { this._saslUsername = value; }
        }

        // Check to see if SaslUsername property is set
        internal bool IsSetSaslUsername()
        {
            return this._saslUsername != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProtocol. 
        /// <para>
        /// Set secure connection to a Kafka target endpoint using Transport Layer Security (TLS).
        /// Options include <code>ssl-encryption</code>, <code>ssl-authentication</code>, and
        /// <code>sasl-ssl</code>. <code>sasl-ssl</code> requires <code>SaslUsername</code> and
        /// <code>SaslPassword</code>.
        /// </para>
        /// </summary>
        public KafkaSecurityProtocol SecurityProtocol
        {
            get { return this._securityProtocol; }
            set { this._securityProtocol = value; }
        }

        // Check to see if SecurityProtocol property is set
        internal bool IsSetSecurityProtocol()
        {
            return this._securityProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property SslCaCertificateArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the private certificate authority (CA) cert that
        /// DMS uses to securely connect to your Kafka target endpoint.
        /// </para>
        /// </summary>
        public string SslCaCertificateArn
        {
            get { return this._sslCaCertificateArn; }
            set { this._sslCaCertificateArn = value; }
        }

        // Check to see if SslCaCertificateArn property is set
        internal bool IsSetSslCaCertificateArn()
        {
            return this._sslCaCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property SslClientCertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the client certificate used to securely connect
        /// to a Kafka target endpoint.
        /// </para>
        /// </summary>
        public string SslClientCertificateArn
        {
            get { return this._sslClientCertificateArn; }
            set { this._sslClientCertificateArn = value; }
        }

        // Check to see if SslClientCertificateArn property is set
        internal bool IsSetSslClientCertificateArn()
        {
            return this._sslClientCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property SslClientKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the client private key used to securely connect
        /// to a Kafka target endpoint.
        /// </para>
        /// </summary>
        public string SslClientKeyArn
        {
            get { return this._sslClientKeyArn; }
            set { this._sslClientKeyArn = value; }
        }

        // Check to see if SslClientKeyArn property is set
        internal bool IsSetSslClientKeyArn()
        {
            return this._sslClientKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property SslClientKeyPassword. 
        /// <para>
        ///  The password for the client private key used to securely connect to a Kafka target
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SslClientKeyPassword
        {
            get { return this._sslClientKeyPassword; }
            set { this._sslClientKeyPassword = value; }
        }

        // Check to see if SslClientKeyPassword property is set
        internal bool IsSetSslClientKeyPassword()
        {
            return this._sslClientKeyPassword != null;
        }

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The topic to which you migrate the data. If you don't specify a topic, DMS specifies
        /// <code>"kafka-default-topic"</code> as the migration topic.
        /// </para>
        /// </summary>
        public string Topic
        {
            get { return this._topic; }
            set { this._topic = value; }
        }

        // Check to see if Topic property is set
        internal bool IsSetTopic()
        {
            return this._topic != null;
        }

    }
}