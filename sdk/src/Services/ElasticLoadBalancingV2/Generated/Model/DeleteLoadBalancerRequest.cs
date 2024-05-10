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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteLoadBalancer operation.
    /// Deletes the specified Application Load Balancer, Network Load Balancer, or Gateway
    /// Load Balancer. Deleting a load balancer also deletes its listeners.
    /// 
    ///  
    /// <para>
    /// You can't delete a load balancer if deletion protection is enabled. If the load balancer
    /// does not exist or has already been deleted, the call succeeds.
    /// </para>
    ///  
    /// <para>
    /// Deleting a load balancer does not affect its registered targets. For example, your
    /// EC2 instances continue to run and are still registered to their target groups. If
    /// you no longer need these EC2 instances, you can stop or terminate them.
    /// </para>
    /// </summary>
    public partial class DeleteLoadBalancerRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _loadBalancerArn;

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoadBalancerArn
        {
            get { return this._loadBalancerArn; }
            set { this._loadBalancerArn = value; }
        }

        // Check to see if LoadBalancerArn property is set
        internal bool IsSetLoadBalancerArn()
        {
            return this._loadBalancerArn != null;
        }

    }
}