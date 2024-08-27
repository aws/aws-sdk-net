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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the SetInstanceHealth operation.
    /// Sets the health status of the specified instance.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/set-up-a-custom-health-check.html">Set
    /// up a custom health check for your Auto Scaling group</a> in the <i>Amazon EC2 Auto
    /// Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class SetInstanceHealthRequest : AmazonAutoScalingRequest
    {
        private string _healthStatus;
        private string _instanceId;
        private bool? _shouldRespectGracePeriod;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status of the instance. Set to <c>Healthy</c> to have the instance remain
        /// in service. Set to <c>Unhealthy</c> to have the instance be out of service. Amazon
        /// EC2 Auto Scaling terminates and replaces the unhealthy instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=19)]
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
        /// Gets and sets the property ShouldRespectGracePeriod. 
        /// <para>
        /// If the Auto Scaling group of the specified instance has a <c>HealthCheckGracePeriod</c>
        /// specified for the group, by default, this call respects the grace period. Set this
        /// to <c>False</c>, to have the call not respect the grace period associated with the
        /// group.
        /// </para>
        ///  
        /// <para>
        /// For more information about the health check grace period, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/health-check-grace-period.html">Set
        /// the health check grace period for an Auto Scaling group</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public bool? ShouldRespectGracePeriod
        {
            get { return this._shouldRespectGracePeriod; }
            set { this._shouldRespectGracePeriod = value; }
        }

        // Check to see if ShouldRespectGracePeriod property is set
        internal bool IsSetShouldRespectGracePeriod()
        {
            return this._shouldRespectGracePeriod.HasValue; 
        }

    }
}