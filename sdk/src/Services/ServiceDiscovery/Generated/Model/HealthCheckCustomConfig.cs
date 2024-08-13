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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information about an optional custom health check. A
    /// custom health check, which requires that you use a third-party health checker to evaluate
    /// the health of your resources, is useful in the following circumstances:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You can't use a health check that's defined by <c>HealthCheckConfig</c> because the
    /// resource isn't available over the internet. For example, you can use a custom health
    /// check when the instance is in an Amazon VPC. (To check the health of resources in
    /// a VPC, the health checker must also be in the VPC.)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You want to use a third-party health checker regardless of where your resources are
    /// located.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// If you specify a health check configuration, you can specify either <c>HealthCheckCustomConfig</c>
    /// or <c>HealthCheckConfig</c> but not both.
    /// </para>
    ///  </important> 
    /// <para>
    /// To change the status of a custom health check, submit an <c>UpdateInstanceCustomHealthStatus</c>
    /// request. Cloud Map doesn't monitor the status of the resource, it just keeps a record
    /// of the status specified in the most recent <c>UpdateInstanceCustomHealthStatus</c>
    /// request.
    /// </para>
    ///  
    /// <para>
    /// Here's how custom health checks work:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// You create a service.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You register an instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You configure a third-party health checker to monitor the resource that's associated
    /// with the new instance. 
    /// </para>
    ///  <note> 
    /// <para>
    /// Cloud Map doesn't check the health of the resource directly. 
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// The third-party health-checker determines that the resource is unhealthy and notifies
    /// your application.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your application submits an <c>UpdateInstanceCustomHealthStatus</c> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cloud Map waits for 30 seconds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If another <c>UpdateInstanceCustomHealthStatus</c> request doesn't arrive during that
    /// time to change the status back to healthy, Cloud Map stops routing traffic to the
    /// resource.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class HealthCheckCustomConfig
    {
        private int? _failureThreshold;

        /// <summary>
        /// Gets and sets the property FailureThreshold. <important> 
        /// <para>
        /// This parameter is no longer supported and is always set to 1. Cloud Map waits for
        /// approximately 30 seconds after receiving an <c>UpdateInstanceCustomHealthStatus</c>
        /// request before changing the status of the service instance.
        /// </para>
        ///  </important> 
        /// <para>
        /// The number of 30-second intervals that you want Cloud Map to wait after receiving
        /// an <c>UpdateInstanceCustomHealthStatus</c> request before it changes the health status
        /// of a service instance.
        /// </para>
        ///  
        /// <para>
        /// Sending a second or subsequent <c>UpdateInstanceCustomHealthStatus</c> request with
        /// the same value before 30 seconds has passed doesn't accelerate the change. Cloud Map
        /// still waits <c>30</c> seconds after the first request to make the change.
        /// </para>
        /// </summary>
        [Obsolete("Configurable FailureThreshold of HealthCheckCustomConfig is deprecated.  It will always have value 1.")]
        [AWSProperty(Min=1, Max=10)]
        public int? FailureThreshold
        {
            get { return this._failureThreshold; }
            set { this._failureThreshold = value; }
        }

        // Check to see if FailureThreshold property is set
        internal bool IsSetFailureThreshold()
        {
            return this._failureThreshold.HasValue; 
        }

    }
}