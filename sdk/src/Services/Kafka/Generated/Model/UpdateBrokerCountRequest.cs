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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBrokerCount operation.
    /// Updates the number of broker nodes in the cluster.
    /// </summary>
    public partial class UpdateBrokerCountRequest : AmazonKafkaRequest
    {
        private string _clusterArn;
        private string _currentVersion;
        private int? _targetNumberOfBrokerNodes;

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the cluster.
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
        /// The version of cluster to update from. A successful operation will then generate a
        /// new version.
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
        /// Gets and sets the property TargetNumberOfBrokerNodes.             
        /// <para>
        /// The number of broker nodes that you want the cluster to have after this operation
        /// completes successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=15)]
        public int TargetNumberOfBrokerNodes
        {
            get { return this._targetNumberOfBrokerNodes.GetValueOrDefault(); }
            set { this._targetNumberOfBrokerNodes = value; }
        }

        // Check to see if TargetNumberOfBrokerNodes property is set
        internal bool IsSetTargetNumberOfBrokerNodes()
        {
            return this._targetNumberOfBrokerNodes.HasValue; 
        }

    }
}