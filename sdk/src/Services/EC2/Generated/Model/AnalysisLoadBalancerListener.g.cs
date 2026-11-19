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
    /// Describes a load balancer listener.
    /// </summary>
    public partial class AnalysisLoadBalancerListener
    {
        /// <summary>
        /// Gets and sets the property InstancePort. 
        /// <para>
        /// [Classic Load Balancers] The back-end port for the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? InstancePort { get; set; }

        /// <summary>
        /// Checks to see if the InstancePort property is set.
        /// </summary>
        internal bool IsSetInstancePort() => this.InstancePort.HasValue;

        /// <summary>
        /// Gets and sets the property LoadBalancerPort. 
        /// <para>
        /// The port on which the load balancer is listening.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? LoadBalancerPort { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerPort property is set.
        /// </summary>
        internal bool IsSetLoadBalancerPort() => this.LoadBalancerPort.HasValue;
    }
}
