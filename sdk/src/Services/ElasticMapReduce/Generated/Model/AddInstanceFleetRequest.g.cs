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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the AddInstanceFleet operation. Adds an instance fleet
    /// to a running cluster. <note> <para> The instance fleet configuration is available
    /// only in Amazon EMR releases 4.8.0 and later, excluding 5.0.x. </para> </note>
    /// </summary>
    public partial class AddInstanceFleetRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The unique identifier of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property InstanceFleet. 
        /// <para>
        /// Specifies the configuration of the instance fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceFleetConfig InstanceFleet { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFleet property is set.
        /// </summary>
        internal bool IsSetInstanceFleet() => this.InstanceFleet != null;
    }
}
