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
    /// Container for the parameters to the ModifyProvisionedCapacity operation.
    /// 
    /// </summary>
    public partial class ModifyProvisionedCapacityRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _loadBalancerArn;
        private int? _minimumLBCapacityUnits;

        /// <summary>
        /// Gets and sets the property LoadBalancerArn.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property MinimumLBCapacityUnits.
        /// </summary>
        public int MinimumLBCapacityUnits
        {
            get { return this._minimumLBCapacityUnits.GetValueOrDefault(); }
            set { this._minimumLBCapacityUnits = value; }
        }

        // Check to see if MinimumLBCapacityUnits property is set
        internal bool IsSetMinimumLBCapacityUnits()
        {
            return this._minimumLBCapacityUnits.HasValue; 
        }

    }
}