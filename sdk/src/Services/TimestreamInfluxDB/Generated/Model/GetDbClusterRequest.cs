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
    /// Container for the parameters to the GetDbCluster operation.
    /// Retrieves information about a Timestream for InfluxDB cluster.
    /// </summary>
    public partial class GetDbClusterRequest : AmazonTimestreamInfluxDBRequest
    {
        private string _dbClusterId;

        /// <summary>
        /// Gets and sets the property DbClusterId. 
        /// <para>
        /// Service-generated unique identifier of the DB cluster to retrieve.
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

    }
}