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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Identifying information for a traffic source.
    /// </summary>
    public partial class TrafficSourceIdentifier
    {
        private string _identifier;
        private string _type;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Identifies the traffic source.
        /// </para>
        ///  
        /// <para>
        /// For Application Load Balancers, Gateway Load Balancers, Network Load Balancers, and
        /// VPC Lattice, this will be the Amazon Resource Name (ARN) for a target group in this
        /// account and Region. For Classic Load Balancers, this will be the name of the Classic
        /// Load Balancer in this account and Region.
        /// </para>
        ///  
        /// <para>
        /// For example: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Application Load Balancer ARN: <code>arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/1234567890123456</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Classic Load Balancer name: <code>my-classic-load-balancer</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VPC Lattice ARN: <code>arn:aws:vpc-lattice:us-west-2:123456789012:targetgroup/tg-1234567890123456</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the ARN of a target group for a Application Load Balancer, Gateway Load Balancer,
        /// or Network Load Balancer, or the name of a Classic Load Balancer, use the Elastic
        /// Load Balancing <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeTargetGroups.html">DescribeTargetGroups</a>
        /// and <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
        /// API operations.
        /// </para>
        ///  
        /// <para>
        /// To get the ARN of a target group for VPC Lattice, use the VPC Lattice <a href="https://docs.aws.amazon.com/vpc-lattice/latest/APIReference/API_GetTargetGroup.html">GetTargetGroup</a>
        /// API operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=511)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Provides additional context for the value of <code>Identifier</code>.
        /// </para>
        ///  
        /// <para>
        /// The following lists the valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elb</code> if <code>Identifier</code> is the name of a Classic Load Balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>elbv2</code> if <code>Identifier</code> is the ARN of an Application Load Balancer,
        /// Gateway Load Balancer, or Network Load Balancer target group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-lattice</code> if <code>Identifier</code> is the ARN of a VPC Lattice target
        /// group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Required if the identifier is the name of a Classic Load Balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=511)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}