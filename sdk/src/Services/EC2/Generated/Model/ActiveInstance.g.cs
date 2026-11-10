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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a running instance in a Spot Fleet.
    /// </summary>
    public partial class ActiveInstance
    {
        /// <summary>
        /// Gets and sets the property InstanceHealth. 
        /// <para>
        /// The health status of the instance. If the status of either the instance status check
        /// or the system status check is <c>impaired</c>, the health status of the instance is
        /// <c>unhealthy</c>. Otherwise, the health status is <c>healthy</c>.
        /// </para>
        /// </summary>
        public InstanceHealthStatus InstanceHealth { get; set; }

        /// <summary>
        /// Checks to see if the InstanceHealth property is set.
        /// </summary>
        internal bool IsSetInstanceHealth() => this.InstanceHealth != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property SpotInstanceRequestId. 
        /// <para>
        /// The ID of the Spot Instance request.
        /// </para>
        /// </summary>
        public string SpotInstanceRequestId { get; set; }

        /// <summary>
        /// Checks to see if the SpotInstanceRequestId property is set.
        /// </summary>
        internal bool IsSetSpotInstanceRequestId() => this.SpotInstanceRequestId != null;
    }
}
