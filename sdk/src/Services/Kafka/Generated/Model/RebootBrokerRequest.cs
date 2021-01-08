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
    /// Container for the parameters to the RebootBroker operation.
    /// Reboots brokers.
    /// </summary>
    public partial class RebootBrokerRequest : AmazonKafkaRequest
    {
        private List<string> _brokerIds = new List<string>();
        private string _clusterArn;

        /// <summary>
        /// Gets and sets the property BrokerIds.             
        /// <para>
        /// The list of broker IDs to be rebooted. The reboot-broker operation supports rebooting
        /// one broker at a time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> BrokerIds
        {
            get { return this._brokerIds; }
            set { this._brokerIds = value; }
        }

        // Check to see if BrokerIds property is set
        internal bool IsSetBrokerIds()
        {
            return this._brokerIds != null && this._brokerIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster to be updated.
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

    }
}