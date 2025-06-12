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
    /// Container for the parameters to the UpdateBrokerStorage operation.
    /// Updates the EBS storage associated with MSK brokers.
    /// </summary>
    public partial class UpdateBrokerStorageRequest : AmazonKafkaRequest
    {
        private string _clusterArn;
        private string _currentVersion;
        private List<BrokerEBSVolumeInfo> _targetBrokerEBSVolumeInfo = AWSConfigs.InitializeCollections ? new List<BrokerEBSVolumeInfo>() : null;

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
        /// Gets and sets the property TargetBrokerEBSVolumeInfo.             
        /// <para>
        /// Describes the target volume size and the ID of the broker to apply the update to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BrokerEBSVolumeInfo> TargetBrokerEBSVolumeInfo
        {
            get { return this._targetBrokerEBSVolumeInfo; }
            set { this._targetBrokerEBSVolumeInfo = value; }
        }

        // Check to see if TargetBrokerEBSVolumeInfo property is set
        internal bool IsSetTargetBrokerEBSVolumeInfo()
        {
            return this._targetBrokerEBSVolumeInfo != null && (this._targetBrokerEBSVolumeInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}