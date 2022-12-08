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
    /// Container for the parameters to the AttachTrafficSources operation.
    /// <b>Reserved for use with Amazon VPC Lattice, which is in preview and subject to change.
    /// Do not use this API for production workloads. This API is also subject to change.</b>
    /// 
    /// 
    ///  
    /// <para>
    /// Attaches one or more traffic sources to the specified Auto Scaling group.
    /// </para>
    ///  
    /// <para>
    /// To describe the traffic sources for an Auto Scaling group, call the <a>DescribeTrafficSources</a>
    /// API. To detach a traffic source from the Auto Scaling group, call the <a>DetachTrafficSources</a>
    /// API.
    /// </para>
    ///  
    /// <para>
    /// This operation is additive and does not detach existing traffic sources from the Auto
    /// Scaling group.
    /// </para>
    /// </summary>
    public partial class AttachTrafficSourcesRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<TrafficSourceIdentifier> _trafficSources = new List<TrafficSourceIdentifier>();

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficSources. 
        /// <para>
        /// The unique identifiers of one or more traffic sources. You can specify up to 10 traffic
        /// sources.
        /// </para>
        ///  
        /// <para>
        /// Currently, you must specify an Amazon Resource Name (ARN) for an existing VPC Lattice
        /// target group. Amazon EC2 Auto Scaling registers the running instances with the attached
        /// target groups. The target groups receive incoming traffic and route requests to one
        /// or more registered targets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TrafficSourceIdentifier> TrafficSources
        {
            get { return this._trafficSources; }
            set { this._trafficSources = value; }
        }

        // Check to see if TrafficSources property is set
        internal bool IsSetTrafficSources()
        {
            return this._trafficSources != null && this._trafficSources.Count > 0; 
        }

    }
}