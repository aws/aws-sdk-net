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
    /// Summarized information about Kafka Cluster used as source / target for replication.
    /// </summary>
    public partial class KafkaClusterSummary
    {
        private AmazonMskCluster _amazonMskCluster;
        private string _kafkaClusterAlias;

        /// <summary>
        /// Gets and sets the property AmazonMskCluster. 
        /// <para>
        /// Details of an Amazon MSK Cluster.
        /// </para>
        /// </summary>
        public AmazonMskCluster AmazonMskCluster
        {
            get { return this._amazonMskCluster; }
            set { this._amazonMskCluster = value; }
        }

        // Check to see if AmazonMskCluster property is set
        internal bool IsSetAmazonMskCluster()
        {
            return this._amazonMskCluster != null;
        }

        /// <summary>
        /// Gets and sets the property KafkaClusterAlias. 
        /// <para>
        /// The alias of the Kafka cluster. Used to prefix names of replicated topics.
        /// </para>
        /// </summary>
        public string KafkaClusterAlias
        {
            get { return this._kafkaClusterAlias; }
            set { this._kafkaClusterAlias = value; }
        }

        // Check to see if KafkaClusterAlias property is set
        internal bool IsSetKafkaClusterAlias()
        {
            return this._kafkaClusterAlias != null;
        }

    }
}