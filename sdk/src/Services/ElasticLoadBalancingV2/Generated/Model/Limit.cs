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
    /// Information about an Elastic Load Balancing resource limit for your Amazon Web Services
    /// account.
    /// 
    ///  
    /// <para>
    /// For more information, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-limits.html">Quotas
    /// for your Application Load Balancers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-limits.html">Quotas
    /// for your Network Load Balancers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/quotas-limits.html">Quotas
    /// for your Gateway Load Balancers</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Limit
    {
        private string _max;
        private string _name;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum value of the limit.
        /// </para>
        /// </summary>
        public string Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the limit. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// application-load-balancers
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// condition-values-per-alb-rule
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// condition-wildcards-per-alb-rule
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// gateway-load-balancers
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// gateway-load-balancers-per-vpc
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// geneve-target-groups
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// listeners-per-application-load-balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// listeners-per-network-load-balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// network-load-balancers
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// rules-per-application-load-balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// target-groups
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// target-groups-per-action-on-application-load-balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// target-groups-per-action-on-network-load-balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// target-groups-per-application-load-balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// targets-per-application-load-balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// targets-per-availability-zone-per-gateway-load-balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// targets-per-availability-zone-per-network-load-balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// targets-per-network-load-balancer
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}