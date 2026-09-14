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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Information about Kafka Cluster to be used as source / target for replication.
    /// </summary>
    public partial class KafkaCluster
    {
        /// <summary>
        /// Gets and sets the property AmazonMskCluster. 
        /// <para>
        /// Details of an Amazon MSK Cluster.
        /// </para>
        /// </summary>
        public AmazonMskCluster AmazonMskCluster { get; set; }

        /// <summary>
        /// Checks to see if the AmazonMskCluster property is set.
        /// </summary>
        internal bool IsSetAmazonMskCluster() => this.AmazonMskCluster != null;

        /// <summary>
        /// Gets and sets the property ApacheKafkaCluster. 
        /// <para>
        /// Details of an Apache Kafka Cluster.
        /// </para>
        /// </summary>
        public ApacheKafkaCluster ApacheKafkaCluster { get; set; }

        /// <summary>
        /// Checks to see if the ApacheKafkaCluster property is set.
        /// </summary>
        internal bool IsSetApacheKafkaCluster() => this.ApacheKafkaCluster != null;

        /// <summary>
        /// Gets and sets the property ClientAuthentication. 
        /// <para>
        /// Details of the client authentication used by the Apache Kafka cluster.
        /// </para>
        /// </summary>
        public KafkaClusterClientAuthentication ClientAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the ClientAuthentication property is set.
        /// </summary>
        internal bool IsSetClientAuthentication() => this.ClientAuthentication != null;

        /// <summary>
        /// Gets and sets the property EncryptionInTransit. 
        /// <para>
        /// Details of encryption in transit to the Apache Kafka cluster.
        /// </para>
        /// </summary>
        public KafkaClusterEncryptionInTransit EncryptionInTransit { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionInTransit property is set.
        /// </summary>
        internal bool IsSetEncryptionInTransit() => this.EncryptionInTransit != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster.
        /// </para>
        /// </summary>
        public KafkaClusterClientVpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
