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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information about an optional custom health check. A
    /// custom health check, which requires that you use a third-party health checker to evaluate
    /// the health of your resources, is useful in the following circumstances:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You can't use a health check that is defined by <code>HealthCheckConfig</code> because
    /// the resource isn't available over the internet. For example, you can use a custom
    /// health check when the instance is in an Amazon VPC. (To check the health of resources
    /// in a VPC, the health checker must also be in the VPC.)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You want to use a third-party health checker regardless of where your resources are.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// If you specify a health check configuration, you can specify either <code>HealthCheckCustomConfig</code>
    /// or <code>HealthCheckConfig</code> but not both.
    /// </para>
    ///  </important> 
    /// <para>
    /// To change the status of a custom health check, submit an <code>UpdateInstanceCustomHealthStatus</code>
    /// request. Cloud Map doesn't monitor the status of the resource, it just keeps a record
    /// of the status specified in the most recent <code>UpdateInstanceCustomHealthStatus</code>
    /// request.
    /// </para>
    ///  
    /// <para>
    /// Here's how custom health checks work:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// You create a service and specify a value for <code>FailureThreshold</code>. 
    /// </para>
    ///  
    /// <para>
    /// The failure threshold indicates the number of 30-second intervals you want AWS Cloud
    /// Map to wait between the time that your application sends an <a>UpdateInstanceCustomHealthStatus</a>
    /// request and the time that AWS Cloud Map stops routing internet traffic to the corresponding
    /// resource.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You register an instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You configure a third-party health checker to monitor the resource that is associated
    /// with the new instance. 
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS Cloud Map doesn't check the health of the resource directly. 
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// The third-party health-checker determines that the resource is unhealthy and notifies
    /// your application.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your application submits an <code>UpdateInstanceCustomHealthStatus</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Cloud Map waits for (<code>FailureThreshold</code> x 30) seconds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If another <code>UpdateInstanceCustomHealthStatus</code> request doesn't arrive during
    /// that time to change the status back to healthy, AWS Cloud Map stops routing traffic
    /// to the resource.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// Note the following about configuring custom health checks.
    /// </para>
    /// </summary>
    public partial class HealthCheckCustomConfig
    {
        private int? _failureThreshold;

        /// <summary>
        /// Gets and sets the property FailureThreshold. 
        /// <para>
        /// The number of 30-second intervals that you want Cloud Map to wait after receiving
        /// an <code>UpdateInstanceCustomHealthStatus</code> request before it changes the health
        /// status of a service instance. For example, suppose you specify a value of <code>2</code>
        /// for <code>FailureTheshold</code>, and then your application sends an <code>UpdateInstanceCustomHealthStatus</code>
        /// request. Cloud Map waits for approximately 60 seconds (2 x 30) before changing the
        /// status of the service instance based on that request.
        /// </para>
        ///  
        /// <para>
        /// Sending a second or subsequent <code>UpdateInstanceCustomHealthStatus</code> request
        /// with the same value before <code>FailureThreshold x 30</code> seconds has passed doesn't
        /// accelerate the change. Cloud Map still waits <code>FailureThreshold x 30</code> seconds
        /// after the first request to make the change.
        /// </para>
        /// </summary>
        public int FailureThreshold
        {
            get { return this._failureThreshold.GetValueOrDefault(); }
            set { this._failureThreshold = value; }
        }

        // Check to see if FailureThreshold property is set
        internal bool IsSetFailureThreshold()
        {
            return this._failureThreshold.HasValue; 
        }

    }
}