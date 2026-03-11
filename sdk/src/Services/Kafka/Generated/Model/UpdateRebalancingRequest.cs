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
    /// Container for the parameters to the UpdateRebalancing operation.
    /// Use this resource to update the intelligent rebalancing status of an Amazon MSK Provisioned
    /// cluster with Express brokers.
    /// </summary>
    public partial class UpdateRebalancingRequest : AmazonKafkaRequest
    {
        private string _clusterArn;
        private string _currentVersion;
        private Rebalancing _rebalancing;

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentVersion.             
        /// <para>
        /// The current version of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Rebalancing.             
        /// <para>
        /// Specifies if intelligent rebalancing should be turned on for your cluster. The default
        /// intelligent rebalancing status is ACTIVE for all new MSK Provisioned clusters that
        /// you create with Express brokers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Rebalancing Rebalancing
        {
            get { return this._rebalancing; }
            set { this._rebalancing = value; }
        }

        // Check to see if Rebalancing property is set
        internal bool IsSetRebalancing()
        {
            return this._rebalancing != null;
        }

    }
}