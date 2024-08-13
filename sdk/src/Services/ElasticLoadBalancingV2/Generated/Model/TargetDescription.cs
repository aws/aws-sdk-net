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
    /// Information about a target.
    /// </summary>
    public partial class TargetDescription
    {
        private string _availabilityZone;
        private string _id;
        private int? _port;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// An Availability Zone or <c>all</c>. This determines whether the target receives traffic
        /// from the load balancer nodes in the specified Availability Zone or from all enabled
        /// Availability Zones for the load balancer.
        /// </para>
        ///  
        /// <para>
        /// For Application Load Balancer target groups, the specified Availability Zone value
        /// is only applicable when cross-zone load balancing is off. Otherwise the parameter
        /// is ignored and treated as <c>all</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported if the target type of the target group is <c>instance</c>
        /// or <c>alb</c>.
        /// </para>
        ///  
        /// <para>
        /// If the target type is <c>ip</c> and the IP address is in a subnet of the VPC for the
        /// target group, the Availability Zone is automatically detected and this parameter is
        /// optional. If the IP address is outside the VPC, this parameter is required.
        /// </para>
        ///  
        /// <para>
        /// For Application Load Balancer target groups with cross-zone load balancing off, if
        /// the target type is <c>ip</c> and the IP address is outside of the VPC for the target
        /// group, this should be an Availability Zone inside the VPC for the target group.
        /// </para>
        ///  
        /// <para>
        /// If the target type is <c>lambda</c>, this parameter is optional and the only supported
        /// value is <c>all</c>.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the target. If the target type of the target group is <c>instance</c>, specify
        /// an instance ID. If the target type is <c>ip</c>, specify an IP address. If the target
        /// type is <c>lambda</c>, specify the ARN of the Lambda function. If the target type
        /// is <c>alb</c>, specify the ARN of the Application Load Balancer target. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on which the target is listening. If the target group protocol is GENEVE,
        /// the supported port is 6081. If the target type is <c>alb</c>, the targeted Application
        /// Load Balancer must have at least one listener whose port matches the target group
        /// port. This parameter is not used if the target is a Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

    }
}