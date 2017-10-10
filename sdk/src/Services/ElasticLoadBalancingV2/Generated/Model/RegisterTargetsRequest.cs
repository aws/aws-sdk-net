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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterTargets operation.
    /// Registers the specified targets with the specified target group.
    /// 
    ///  
    /// <para>
    /// You can register targets by instance ID or by IP address. If the target is an EC2
    /// instance, it must be in the <code>running</code> state when you register it.
    /// </para>
    ///  
    /// <para>
    /// By default, the load balancer routes requests to registered targets using the protocol
    /// and port for the target group. Alternatively, you can override the port for a target
    /// when you register it. You can register each EC2 instance or IP address with the same
    /// target group multiple times using different ports.
    /// </para>
    ///  
    /// <para>
    /// With a Network Load Balancer, you cannot register instances by instance ID if they
    /// have the following instance types: C1, CC1, CC2, CG1, CG2, CR1, CS1, G1, G2, HI1,
    /// HS1, M1, M2, M3, and T1. You can register instances of these types by IP address.
    /// </para>
    ///  
    /// <para>
    /// To remove a target from a target group, use <a>DeregisterTargets</a>.
    /// </para>
    /// </summary>
    public partial class RegisterTargetsRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _targetGroupArn;
        private List<TargetDescription> _targets = new List<TargetDescription>();

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target group.
        /// </para>
        /// </summary>
        public string TargetGroupArn
        {
            get { return this._targetGroupArn; }
            set { this._targetGroupArn = value; }
        }

        // Check to see if TargetGroupArn property is set
        internal bool IsSetTargetGroupArn()
        {
            return this._targetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets.
        /// </para>
        /// </summary>
        public List<TargetDescription> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

    }
}