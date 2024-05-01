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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyInstanceFleet operation.
    /// Modifies the target On-Demand and target Spot capacities for the instance fleet with
    /// the specified InstanceFleetID within the cluster specified using ClusterID. The call
    /// either succeeds or fails atomically.
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
    /// later, excluding 5.0.x versions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ModifyInstanceFleetRequest : AmazonElasticMapReduceRequest
    {
        private string _clusterId;
        private InstanceFleetModifyConfig _instanceFleet;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The unique identifier of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFleet. 
        /// <para>
        /// The configuration parameters of the instance fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceFleetModifyConfig InstanceFleet
        {
            get { return this._instanceFleet; }
            set { this._instanceFleet = value; }
        }

        // Check to see if InstanceFleet property is set
        internal bool IsSetInstanceFleet()
        {
            return this._instanceFleet != null;
        }

    }
}