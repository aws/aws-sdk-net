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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
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
namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Container for the parameters to the RebootDbCluster operation.
    /// Reboots a Timestream for InfluxDB cluster.
    /// </summary>
    public partial class RebootDbClusterRequest : AmazonTimestreamInfluxDBRequest
    {
        private string _dbClusterId;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DbClusterId. 
        /// <para>
        /// Service-generated unique identifier of the DB cluster to reboot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string DbClusterId
        {
            get { return this._dbClusterId; }
            set { this._dbClusterId = value; }
        }

        // Check to see if DbClusterId property is set
        internal bool IsSetDbClusterId()
        {
            return this._dbClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// A list of service-generated unique DB Instance Ids belonging to the DB Cluster to
        /// reboot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}