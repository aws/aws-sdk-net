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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// The details of the Apache Kafka cluster to which the connector is connected.
    /// </summary>
    public partial class KafkaCluster
    {
        private ApacheKafkaCluster _apacheKafkaCluster;

        /// <summary>
        /// Gets and sets the property ApacheKafkaCluster. 
        /// <para>
        /// The Apache Kafka cluster to which the connector is connected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApacheKafkaCluster ApacheKafkaCluster
        {
            get { return this._apacheKafkaCluster; }
            set { this._apacheKafkaCluster = value; }
        }

        // Check to see if ApacheKafkaCluster property is set
        internal bool IsSetApacheKafkaCluster()
        {
            return this._apacheKafkaCluster != null;
        }

    }
}