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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DetachInstancesFromLoadBalancer operation.
    /// Detaches the specified instances from a Lightsail load balancer.
    /// 
    ///  
    /// <para>
    /// This operation waits until the instances are no longer needed before they are detached
    /// from the load balancer.
    /// </para>
    ///  
    /// <para>
    /// The <code>detach instances from load balancer</code> operation supports tag-based
    /// access control via resource tags applied to the resource identified by <code>load
    /// balancer name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class DetachInstancesFromLoadBalancerRequest : AmazonLightsailRequest
    {
        private List<string> _instanceNames = new List<string>();
        private string _loadBalancerName;

        /// <summary>
        /// Gets and sets the property InstanceNames. 
        /// <para>
        /// An array of strings containing the names of the instances you want to detach from
        /// the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name of the Lightsail load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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