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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes an Apache Kafka endpoint. This information includes
    /// the output format of records applied to the endpoint and details of transaction and
    /// control table data information.
    /// </summary>
    public partial class KafkaSettings
    {
        /// <summary>
        /// Gets and sets the property Broker. 
        /// <para>
        /// A comma-separated list of one or more broker locations in your Kafka cluster that
        /// host your Kafka instance. Specify each broker location in the form <c> <i>broker-hostname-or-ip</i>:<i>port</i>
        /// </c>. For example, <c>"ec2-12-345-678-901.compute-1.amazonaws.com:2345"</c>. For more
        /// information and examples of specifying a list of broker locations, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Kafka.html">Using
        /// Apache Kafka as a target for Database Migration Service</a> in the <i>Database Migration
        /// Service User Guide</i>. 
        /// </para>
        /// </summary>
        public string Broker { get; set; }

        /// <summary>
        /// Checks to see if the Broker property is set.
        /// </summary>
        internal bool IsSetBroker() => this.Broker != null;

        /// <summary>
        /// Gets and sets the property IncludeControlDetails. 
        /// <para>
        /// Shows detailed control information for table definition, column definition, and table
        /// and column changes in the Kafka message output. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeControlDetails { get; set; }

        /// <summary>
        /// Checks to see if the IncludeControlDetails property is set.
        /// </summary>
        internal bool IsSetIncludeControlDetails() => this.IncludeControlDetails.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeNullAndEmpty. 
        /// <para>
        /// Include NULL and empty columns for records migrated to the endpoint. The default is
        /// <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeNullAndEmpty { get; set; }

        /// <summary>
        /// Checks to see if the IncludeNullAndEmpty property is set.
        /// </summary>
        internal bool IsSetIncludeNullAndEmpty() => this.IncludeNullAndEmpty.HasValue;

        /// <summary>
        /// Gets and sets the property IncludePartitionValue. 
        /// <para>
        /// Shows the partition value within the Kafka message output unless the partition type
        /// is <c>schema-table-type</c>. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludePartitionValue { get; set; }

        /// <summary>
        /// Checks to see if the IncludePartitionValue property is set.
        /// </summary>
        internal bool IsSetIncludePartitionValue() => this.IncludePartitionValue.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeTableAlterOperations. 
        /// <para>
        /// Includes any data definition language (DDL) operations that change the table in the
        /// control data, such as <c>rename-table</c>, <c>drop-table</c>, <c>add-column</c>, <c>drop-column</c>,
        /// and <c>rename-column</c>. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeTableAlterOperations { get; set; }

        /// <summary>
        /// Checks to see if the IncludeTableAlterOperations property is set.
        /// </summary>
        internal bool IsSetIncludeTableAlterOperations() => this.IncludeTableAlterOperations.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeTransactionDetails. 
        /// <para>
        /// Provides detailed transaction information from the source database. This information
        /// includes a commit timestamp, a log position, and values for <c>transaction_id</c>,
        /// previous <c>transaction_id</c>, and <c>transaction_record_id</c> (the record offset
        /// within a transaction). The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeTransactionDetails { get; set; }

        /// <summary>
        /// Checks to see if the IncludeTransactionDetails property is set.
        /// </summary>
        internal bool IsSetIncludeTransactionDetails() => this.IncludeTransactionDetails.HasValue;

        /// <summary>
        /// Gets and sets the property MessageFormat. 
        /// <para>
        /// The output format for the records created on the endpoint. The message format is <c>JSON</c>
        /// (default) or <c>JSON_UNFORMATTED</c> (a single line with no tab).
        /// </para>
        /// </summary>
        public MessageFormatValue MessageFormat { get; set; }

        /// <summary>
        /// Checks to see if the MessageFormat property is set.
        /// </summary>
        internal bool IsSetMessageFormat() => this.MessageFormat != null;

        /// <summary>
        /// Gets and sets the property MessageMaxBytes. 
        /// <para>
        /// The maximum size in bytes for records created on the endpoint The default is 1,000,000.
        /// </para>
        /// </summary>
        public int? MessageMaxBytes { get; set; }

        /// <summary>
        /// Checks to see if the MessageMaxBytes property is set.
        /// </summary>
        internal bool IsSetMessageMaxBytes() => this.MessageMaxBytes.HasValue;

        /// <summary>
        /// Gets and sets the property NoHexPrefix. 
        /// <para>
        /// Set this optional parameter to <c>true</c> to avoid adding a '0x' prefix to raw data
        /// in hexadecimal format. For example, by default, DMS adds a '0x' prefix to the LOB
        /// column type in hexadecimal format moving from an Oracle source to a Kafka target.
        /// Use the <c>NoHexPrefix</c> endpoint setting to enable migration of RAW data type columns
        /// without adding the '0x' prefix.
        /// </para>
        /// </summary>
        public bool? NoHexPrefix { get; set; }

        /// <summary>
        /// Checks to see if the NoHexPrefix property is set.
        /// </summary>
        internal bool IsSetNoHexPrefix() => this.NoHexPrefix.HasValue;

        /// <summary>
        /// Gets and sets the property PartitionIncludeSchemaTable. 
        /// <para>
        /// Prefixes schema and table names to partition values, when the partition type is <c>primary-key-type</c>.
        /// Doing this increases data distribution among Kafka partitions. For example, suppose
        /// that a SysBench schema has thousands of tables and each table has only limited range
        /// for a primary key. In this case, the same primary key is sent from thousands of tables
        /// to the same partition, which causes throttling. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? PartitionIncludeSchemaTable { get; set; }

        /// <summary>
        /// Checks to see if the PartitionIncludeSchemaTable property is set.
        /// </summary>
        internal bool IsSetPartitionIncludeSchemaTable() => this.PartitionIncludeSchemaTable.HasValue;

        /// <summary>
        /// Gets and sets the property SaslMechanism. 
        /// <para>
        /// For SASL/SSL authentication, DMS supports the <c>SCRAM-SHA-512</c> mechanism by default.
        /// DMS versions 3.5.0 and later also support the <c>PLAIN</c> mechanism. To use the <c>PLAIN</c>
        /// mechanism, set this parameter to <c>PLAIN.</c> 
        /// </para>
        /// </summary>
        public KafkaSaslMechanism SaslMechanism { get; set; }

        /// <summary>
        /// Checks to see if the SaslMechanism property is set.
        /// </summary>
        internal bool IsSetSaslMechanism() => this.SaslMechanism != null;

        /// <summary>
        /// Gets and sets the property SaslPassword. 
        /// <para>
        /// The secure password you created when you first set up your MSK cluster to validate
        /// a client identity and make an encrypted connection between server and client using
        /// SASL-SSL authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SaslPassword { get; set; }

        /// <summary>
        /// Checks to see if the SaslPassword property is set.
        /// </summary>
        internal bool IsSetSaslPassword() => this.SaslPassword != null;

        /// <summary>
        /// Gets and sets the property SaslUsername. 
        /// <para>
        ///  The secure user name you created when you first set up your MSK cluster to validate
        /// a client identity and make an encrypted connection between server and client using
        /// SASL-SSL authentication.
        /// </para>
        /// </summary>
        public string SaslUsername { get; set; }

        /// <summary>
        /// Checks to see if the SaslUsername property is set.
        /// </summary>
        internal bool IsSetSaslUsername() => this.SaslUsername != null;

        /// <summary>
        /// Gets and sets the property SecurityProtocol. 
        /// <para>
        /// Set secure connection to a Kafka target endpoint using Transport Layer Security (TLS).
        /// Options include <c>ssl-encryption</c>, <c>ssl-authentication</c>, and <c>sasl-ssl</c>.
        /// <c>sasl-ssl</c> requires <c>SaslUsername</c> and <c>SaslPassword</c>.
        /// </para>
        /// </summary>
        public KafkaSecurityProtocol SecurityProtocol { get; set; }

        /// <summary>
        /// Checks to see if the SecurityProtocol property is set.
        /// </summary>
        internal bool IsSetSecurityProtocol() => this.SecurityProtocol != null;

        /// <summary>
        /// Gets and sets the property SslCaCertificateArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the private certificate authority (CA) cert that
        /// DMS uses to securely connect to your Kafka target endpoint.
        /// </para>
        /// </summary>
        public string SslCaCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the SslCaCertificateArn property is set.
        /// </summary>
        internal bool IsSetSslCaCertificateArn() => this.SslCaCertificateArn != null;

        /// <summary>
        /// Gets and sets the property SslClientCertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the client certificate used to securely connect
        /// to a Kafka target endpoint.
        /// </para>
        /// </summary>
        public string SslClientCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the SslClientCertificateArn property is set.
        /// </summary>
        internal bool IsSetSslClientCertificateArn() => this.SslClientCertificateArn != null;

        /// <summary>
        /// Gets and sets the property SslClientKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the client private key used to securely connect
        /// to a Kafka target endpoint.
        /// </para>
        /// </summary>
        public string SslClientKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the SslClientKeyArn property is set.
        /// </summary>
        internal bool IsSetSslClientKeyArn() => this.SslClientKeyArn != null;

        /// <summary>
        /// Gets and sets the property SslClientKeyPassword. 
        /// <para>
        ///  The password for the client private key used to securely connect to a Kafka target
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SslClientKeyPassword { get; set; }

        /// <summary>
        /// Checks to see if the SslClientKeyPassword property is set.
        /// </summary>
        internal bool IsSetSslClientKeyPassword() => this.SslClientKeyPassword != null;

        /// <summary>
        /// Gets and sets the property SslEndpointIdentificationAlgorithm. 
        /// <para>
        /// Sets hostname verification for the certificate. This setting is supported in DMS version
        /// 3.5.1 and later. 
        /// </para>
        /// </summary>
        public KafkaSslEndpointIdentificationAlgorithm SslEndpointIdentificationAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SslEndpointIdentificationAlgorithm property is set.
        /// </summary>
        internal bool IsSetSslEndpointIdentificationAlgorithm() => this.SslEndpointIdentificationAlgorithm != null;

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The topic to which you migrate the data. If you don't specify a topic, DMS specifies
        /// <c>"kafka-default-topic"</c> as the migration topic.
        /// </para>
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Checks to see if the Topic property is set.
        /// </summary>
        internal bool IsSetTopic() => this.Topic != null;

        /// <summary>
        /// Gets and sets the property UseLargeIntegerValue. 
        /// <para>
        /// Specifies using the large integer value with Kafka.
        /// </para>
        /// </summary>
        public bool? UseLargeIntegerValue { get; set; }

        /// <summary>
        /// Checks to see if the UseLargeIntegerValue property is set.
        /// </summary>
        internal bool IsSetUseLargeIntegerValue() => this.UseLargeIntegerValue.HasValue;
    }
}
