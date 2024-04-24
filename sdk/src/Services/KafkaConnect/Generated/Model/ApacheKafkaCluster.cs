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
    public partial class ApacheKafkaCluster
    {
        private string _bootstrapServers;
        private Vpc _vpc;

        /// <summary>
        /// Gets and sets the property BootstrapServers. 
        /// <para>
        /// The bootstrap servers of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BootstrapServers
        {
            get { return this._bootstrapServers; }
            set { this._bootstrapServers = value; }
        }

        // Check to see if BootstrapServers property is set
        internal bool IsSetBootstrapServers()
        {
            return this._bootstrapServers != null;
        }

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Vpc Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

    }
}