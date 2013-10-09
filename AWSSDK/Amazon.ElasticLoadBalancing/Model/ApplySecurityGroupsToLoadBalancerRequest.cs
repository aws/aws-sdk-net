/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the ApplySecurityGroupsToLoadBalancer operation.
    /// <para> Associates one or more security groups with your load balancer in Amazon Virtual Private Cloud (Amazon VPC). The provided security
    /// group IDs will override any currently applied security groups. </para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/USVPC_ApplySG.html" >Manage Security Groups in Amazon VPC</a> in
    /// the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ApplySecurityGroupsToLoadBalancer"/>
    public class ApplySecurityGroupsToLoadBalancerRequest : AmazonWebServiceRequest
    {
        private string loadBalancerName;
        private List<string> securityGroups = new List<string>();

        /// <summary>
        /// The name associated with the load balancer. The name must be unique within the set of load balancers associated with your AWS account.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The value to set for the LoadBalancerName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ApplySecurityGroupsToLoadBalancerRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
            return this;
        }
            

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;
        }

        /// <summary>
        /// A list of security group IDs to associate with your load balancer in VPC. The security group IDs must be provided as the ID and not the
        /// security group name (For example, sg-1234).
        ///  
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this.securityGroups; }
            set { this.securityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the SecurityGroups collection
        /// </summary>
        /// <param name="securityGroups">The values to add to the SecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ApplySecurityGroupsToLoadBalancerRequest WithSecurityGroups(params string[] securityGroups)
        {
            foreach (string element in securityGroups)
            {
                this.securityGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the SecurityGroups collection
        /// </summary>
        /// <param name="securityGroups">The values to add to the SecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ApplySecurityGroupsToLoadBalancerRequest WithSecurityGroups(IEnumerable<string> securityGroups)
        {
            foreach (string element in securityGroups)
            {
                this.securityGroups.Add(element);
            }

            return this;
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this.securityGroups.Count > 0;
        }
    }
}
    
