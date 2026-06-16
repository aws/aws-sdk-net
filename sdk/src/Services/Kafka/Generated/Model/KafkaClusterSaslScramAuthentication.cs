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
    /// Details for SASL/SCRAM client authentication.
    /// </summary>
    public partial class KafkaClusterSaslScramAuthentication
    {
        private KafkaClusterSaslScramMechanism _mechanism;
        private string _secretArn;

        /// <summary>
        /// Gets and sets the property Mechanism. 
        /// <para>
        /// The SASL/SCRAM authentication mechanism.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KafkaClusterSaslScramMechanism Mechanism
        {
            get { return this._mechanism; }
            set { this._mechanism = value; }
        }

        // Check to see if Mechanism property is set
        internal bool IsSetMechanism()
        {
            return this._mechanism != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

    }
}