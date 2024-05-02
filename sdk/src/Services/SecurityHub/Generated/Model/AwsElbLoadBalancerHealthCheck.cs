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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about the health checks that are conducted on the load balancer.
    /// </summary>
    public partial class AwsElbLoadBalancerHealthCheck
    {
        private int? _healthyThreshold;
        private int? _interval;
        private string _target;
        private int? _timeout;
        private int? _unhealthyThreshold;

        /// <summary>
        /// Gets and sets the property HealthyThreshold. 
        /// <para>
        /// The number of consecutive health check successes required before the instance is moved
        /// to the Healthy state.
        /// </para>
        /// </summary>
        public int? HealthyThreshold
        {
            get { return this._healthyThreshold; }
            set { this._healthyThreshold = value; }
        }

        // Check to see if HealthyThreshold property is set
        internal bool IsSetHealthyThreshold()
        {
            return this._healthyThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The approximate interval, in seconds, between health checks of an individual instance.
        /// </para>
        /// </summary>
        public int? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The instance that is being checked. The target specifies the protocol and port. The
        /// available protocols are TCP, SSL, HTTP, and HTTPS. The range of valid ports is 1 through
        /// 65535.
        /// </para>
        ///  
        /// <para>
        /// For the HTTP and HTTPS protocols, the target also specifies the ping path.
        /// </para>
        ///  
        /// <para>
        /// For the TCP protocol, the target is specified as <c>TCP: <i>&lt;port&gt;</i> </c>.
        /// </para>
        ///  
        /// <para>
        /// For the SSL protocol, the target is specified as <c>SSL.<i>&lt;port&gt;</i> </c>.
        /// </para>
        ///  
        /// <para>
        /// For the HTTP and HTTPS protocols, the target is specified as <c> <i>&lt;protocol&gt;</i>:<i>&lt;port&gt;</i>/<i>&lt;path
        /// to ping&gt;</i> </c>.
        /// </para>
        /// </summary>
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The amount of time, in seconds, during which no response means a failed health check.
        /// </para>
        /// </summary>
        public int? Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyThreshold. 
        /// <para>
        /// The number of consecutive health check failures that must occur before the instance
        /// is moved to the Unhealthy state.
        /// </para>
        /// </summary>
        public int? UnhealthyThreshold
        {
            get { return this._unhealthyThreshold; }
            set { this._unhealthyThreshold = value; }
        }

        // Check to see if UnhealthyThreshold property is set
        internal bool IsSetUnhealthyThreshold()
        {
            return this._unhealthyThreshold.HasValue; 
        }

    }
}