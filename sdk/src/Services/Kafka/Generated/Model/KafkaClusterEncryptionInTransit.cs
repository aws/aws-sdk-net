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
    /// Details of encryption in transit to the Apache Kafka cluster.
    /// </summary>
    public partial class KafkaClusterEncryptionInTransit
    {
        private KafkaClusterEncryptionInTransitType _encryptionType;
        private string _rootCaCertificate;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of encryption in transit to the Apache Kafka cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KafkaClusterEncryptionInTransitType EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property RootCaCertificate. 
        /// <para>
        /// The root CA certificate.
        /// </para>
        /// </summary>
        public string RootCaCertificate
        {
            get { return this._rootCaCertificate; }
            set { this._rootCaCertificate = value; }
        }

        // Check to see if RootCaCertificate property is set
        internal bool IsSetRootCaCertificate()
        {
            return this._rootCaCertificate != null;
        }

    }
}