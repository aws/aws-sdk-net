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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Details of the client authentication used by the Apache Kafka cluster.
    /// </summary>
    public partial class KafkaClusterClientAuthentication
    {
        private KafkaClusterMTLSAuthentication _mtls;
        private KafkaClusterSaslScramAuthentication _saslScram;

        /// <summary>
        /// Gets and sets the property MTLS. 
        /// <para>
        /// Details for mTLS client authentication.
        /// </para>
        /// </summary>
        public KafkaClusterMTLSAuthentication MTLS
        {
            get { return this._mtls; }
            set { this._mtls = value; }
        }

        // Check to see if MTLS property is set
        internal bool IsSetMTLS()
        {
            return this._mtls != null;
        }

        /// <summary>
        /// Gets and sets the property SaslScram. 
        /// <para>
        /// Details for SASL/SCRAM client authentication.
        /// </para>
        /// </summary>
        public KafkaClusterSaslScramAuthentication SaslScram
        {
            get { return this._saslScram; }
            set { this._saslScram = value; }
        }

        // Check to see if SaslScram property is set
        internal bool IsSetSaslScram()
        {
            return this._saslScram != null;
        }

    }
}