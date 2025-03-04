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
    /// This is the response object from the UpdateDbCluster operation.
    /// </summary>
    public partial class UpdateDbClusterResponse : AmazonWebServiceResponse
    {
        private ClusterStatus _dbClusterStatus;

        /// <summary>
        /// Gets and sets the property DbClusterStatus. 
        /// <para>
        /// The status of the DB cluster.
        /// </para>
        /// </summary>
        public ClusterStatus DbClusterStatus
        {
            get { return this._dbClusterStatus; }
            set { this._dbClusterStatus = value; }
        }

        // Check to see if DbClusterStatus property is set
        internal bool IsSetDbClusterStatus()
        {
            return this._dbClusterStatus != null;
        }

    }
}