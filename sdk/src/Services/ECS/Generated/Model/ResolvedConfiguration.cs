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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The resolved configuration for a service revision, which contains the actual resources
    /// your service revision uses, such as which target groups serve traffic.
    /// </summary>
    public partial class ResolvedConfiguration
    {
        private List<ServiceRevisionLoadBalancer> _loadBalancers = AWSConfigs.InitializeCollections ? new List<ServiceRevisionLoadBalancer>() : null;

        /// <summary>
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// The resolved load balancer configuration for the service revision. This includes information
        /// about which target groups serve traffic and which listener rules direct traffic to
        /// them.
        /// </para>
        /// </summary>
        public List<ServiceRevisionLoadBalancer> LoadBalancers
        {
            get { return this._loadBalancers; }
            set { this._loadBalancers = value; }
        }

        // Check to see if LoadBalancers property is set
        internal bool IsSetLoadBalancers()
        {
            return this._loadBalancers != null && (this._loadBalancers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}