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
    /// Container for the parameters to the UpdateInstanceCustomHealthStatus operation.
    /// Submits a request to change the health status of a custom health check to healthy
    /// or unhealthy.
    /// 
    ///  
    /// <para>
    /// You can use <c>UpdateInstanceCustomHealthStatus</c> to change the status only for
    /// custom health checks, which you define using <c>HealthCheckCustomConfig</c> when you
    /// create a service. You can't use it to change the status for Route 53 health checks,
    /// which you define using <c>HealthCheckConfig</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_HealthCheckCustomConfig.html">HealthCheckCustomConfig</a>.
    /// </para>
    /// </summary>
    public partial class UpdateInstanceCustomHealthStatusRequest : AmazonServiceDiscoveryRequest
    {
        private string _instanceId;
        private string _serviceId;
        private CustomHealthStatus _status;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance that you want to change the health status for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the service that includes the configuration
        /// for the custom health check that you want to change the status for. For services created
        /// in a shared namespace, specify the service ARN. For more information about shared
        /// namespaces, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/sharing-namespaces.html">Cross-account
        /// Cloud Map namespace sharing</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status of the instance, <c>HEALTHY</c> or <c>UNHEALTHY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomHealthStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}