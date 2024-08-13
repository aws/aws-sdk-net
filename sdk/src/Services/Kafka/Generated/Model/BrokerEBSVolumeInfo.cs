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
    /// Specifies the EBS volume upgrade information. The broker identifier must be set to
    /// the keyword ALL. This means the changes apply to all the brokers in the cluster.
    /// </summary>
    public partial class BrokerEBSVolumeInfo
    {
        private string _kafkaBrokerNodeId;
        private ProvisionedThroughput _provisionedThroughput;
        private int? _volumeSizeGB;

        /// <summary>
        /// Gets and sets the property KafkaBrokerNodeId.             
        /// <para>
        /// The ID of the broker to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KafkaBrokerNodeId
        {
            get { return this._kafkaBrokerNodeId; }
            set { this._kafkaBrokerNodeId = value; }
        }

        // Check to see if KafkaBrokerNodeId property is set
        internal bool IsSetKafkaBrokerNodeId()
        {
            return this._kafkaBrokerNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput.             
        /// <para>
        /// EBS volume provisioned throughput information.
        /// </para>
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput
        {
            get { return this._provisionedThroughput; }
            set { this._provisionedThroughput = value; }
        }

        // Check to see if ProvisionedThroughput property is set
        internal bool IsSetProvisionedThroughput()
        {
            return this._provisionedThroughput != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeSizeGB.             
        /// <para>
        /// Size of the EBS volume to update.
        /// </para>
        /// </summary>
        public int? VolumeSizeGB
        {
            get { return this._volumeSizeGB; }
            set { this._volumeSizeGB = value; }
        }

        // Check to see if VolumeSizeGB property is set
        internal bool IsSetVolumeSizeGB()
        {
            return this._volumeSizeGB.HasValue; 
        }

    }
}