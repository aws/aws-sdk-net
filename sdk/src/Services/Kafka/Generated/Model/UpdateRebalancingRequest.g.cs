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
    /// Container for the parameters to the UpdateRebalancing operation. Use this resource
    /// to update the intelligent rebalancing status of an Amazon MSK Provisioned cluster
    /// with Express brokers.
    /// </summary>
    public partial class UpdateRebalancingRequest : AmazonKafkaRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current version of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property Rebalancing. 
        /// <para>
        /// Specifies if intelligent rebalancing should be turned on for your cluster. The default
        /// intelligent rebalancing status is ACTIVE for all new MSK Provisioned clusters that
        /// you create with Express brokers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Rebalancing Rebalancing { get; set; }

        /// <summary>
        /// Checks to see if the Rebalancing property is set.
        /// </summary>
        internal bool IsSetRebalancing() => this.Rebalancing != null;
    }
}
