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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// To secure and define access to your event source, you can specify the authentication
    /// protocol, VPC components, or virtual host.
    /// </summary>
    public partial class SourceAccessConfiguration
    {
        private SourceAccessType _type;
        private string _uri;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of authentication protocol, VPC components, or virtual host for your event
        /// source. For example: <code>"Type":"SASL_SCRAM_512_AUTH"</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BASIC_AUTH</code> – (Amazon MQ) The Secrets Manager secret that stores your
        /// broker credentials.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BASIC_AUTH</code> – (Self-managed Apache Kafka) The Secrets Manager ARN of
        /// your secret key used for SASL/PLAIN authentication of your Apache Kafka brokers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VPC_SUBNET</code> – (Self-managed Apache Kafka) The subnets associated with
        /// your VPC. Lambda connects to these subnets to fetch data from your self-managed Apache
        /// Kafka cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VPC_SECURITY_GROUP</code> – (Self-managed Apache Kafka) The VPC security group
        /// used to manage access to your self-managed Apache Kafka brokers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SASL_SCRAM_256_AUTH</code> – (Self-managed Apache Kafka) The Secrets Manager
        /// ARN of your secret key used for SASL SCRAM-256 authentication of your self-managed
        /// Apache Kafka brokers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SASL_SCRAM_512_AUTH</code> – (Amazon MSK, Self-managed Apache Kafka) The Secrets
        /// Manager ARN of your secret key used for SASL SCRAM-512 authentication of your self-managed
        /// Apache Kafka brokers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VIRTUAL_HOST</code> –- (RabbitMQ) The name of the virtual host in your RabbitMQ
        /// broker. Lambda uses this RabbitMQ host as the event source. This property cannot be
        /// specified in an UpdateEventSourceMapping API call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CLIENT_CERTIFICATE_TLS_AUTH</code> – (Amazon MSK, self-managed Apache Kafka)
        /// The Secrets Manager ARN of your secret key containing the certificate chain (X.509
        /// PEM), private key (PKCS#8 PEM), and private key password (optional) used for mutual
        /// TLS authentication of your MSK/Apache Kafka brokers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SERVER_ROOT_CA_CERTIFICATE</code> – (Self-managed Apache Kafka) The Secrets
        /// Manager ARN of your secret key containing the root CA certificate (X.509 PEM) used
        /// for TLS encryption of your Apache Kafka brokers. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SourceAccessType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property URI. 
        /// <para>
        /// The value for your chosen configuration in <code>Type</code>. For example: <code>"URI":
        /// "arn:aws:secretsmanager:us-east-1:01234567890:secret:MyBrokerSecretName"</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string URI
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if URI property is set
        internal bool IsSetURI()
        {
            return this._uri != null;
        }

    }
}