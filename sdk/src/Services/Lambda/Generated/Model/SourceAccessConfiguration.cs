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
    /// You can specify the authentication protocol, or the VPC components to secure access
    /// to your event source.
    /// </summary>
    public partial class SourceAccessConfiguration
    {
        private SourceAccessType _type;
        private string _uri;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of authentication protocol or the VPC components for your event source. For
        /// example: <code>"Type":"SASL_SCRAM_512_AUTH"</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BASIC_AUTH</code> - (MQ) The Secrets Manager secret that stores your broker
        /// credentials.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VPC_SUBNET</code> - The subnets associated with your VPC. Lambda connects to
        /// these subnets to fetch data from your Kafka cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VPC_SECURITY_GROUP</code> - The VPC security group used to manage access to
        /// your Kafka brokers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SASL_SCRAM_256_AUTH</code> - The ARN of your secret key used for SASL SCRAM-256
        /// authentication of your Kafka brokers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SASL_SCRAM_512_AUTH</code> - The ARN of your secret key used for SASL SCRAM-512
        /// authentication of your Kafka brokers.
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