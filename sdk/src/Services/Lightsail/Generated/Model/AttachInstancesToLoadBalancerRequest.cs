/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the AttachInstancesToLoadBalancer operation.
    /// Attaches one or more Lightsail instances to a load balancer.
    /// 
    ///  
    /// <para>
    /// After some time, the instances are attached to the load balancer and the health check
    /// status is available.
    /// </para>
    /// </summary>
    public partial class AttachInstancesToLoadBalancerRequest : AmazonLightsailRequest
    {
        private List<string> _instanceNames = new List<string>();
        private string _loadBalancerName;

        /// <summary>
        /// Gets and sets the property InstanceNames. 
        /// <para>
        /// An array of strings representing the instance name(s) you want to attach to your load
        /// balancer.
        /// </para>
        ///  
        /// <para>
        /// An instance must be <code>running</code> before you can attach it to your load balancer.
        /// </para>
        ///  
        /// <para>
        /// There are no additional limits on the number of instances you can attach to your load
        /// balancer, aside from the limit of Lightsail instances you can create in your account
        /// (20).
        /// </para>
        /// </summary>
        public List<string> InstanceNames
        {
            get { return this._instanceNames; }
            set { this._instanceNames = value; }
        }

        // Check to see if InstanceNames property is set
        internal bool IsSetInstanceNames()
        {
            return this._instanceNames != null && this._instanceNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

    }
}