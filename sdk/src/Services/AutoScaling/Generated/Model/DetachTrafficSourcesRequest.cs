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
    /// Container for the parameters to the DetachTrafficSources operation.
    /// Detaches one or more traffic sources from the specified Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// When you detach a traffic source, it enters the <c>Removing</c> state while deregistering
    /// the instances in the group. When all instances are deregistered, then you can no longer
    /// describe the traffic source using the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeTrafficSources.html">DescribeTrafficSources</a>
    /// API call. The instances continue to run.
    /// </para>
    /// </summary>
    public partial class DetachTrafficSourcesRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<TrafficSourceIdentifier> _trafficSources = AWSConfigs.InitializeCollections ? new List<TrafficSourceIdentifier>() : null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._trafficSources != null && (this._trafficSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}