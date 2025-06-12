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
    /// Container for the parameters to the AttachTrafficSources operation.
    /// Attaches one or more traffic sources to the specified Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// You can use any of the following as traffic sources for an Auto Scaling group:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Application Load Balancer
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Classic Load Balancer
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Gateway Load Balancer
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Network Load Balancer
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// VPC Lattice
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation is additive and does not detach existing traffic sources from the Auto
    /// Scaling group. 
    /// </para>
    ///  
    /// <para>
    /// After the operation completes, use the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeTrafficSources.html">DescribeTrafficSources</a>
    /// API to return details about the state of the attachments between traffic sources and
    /// your Auto Scaling group. To detach a traffic source from the Auto Scaling group, call
    /// the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DetachTrafficSources.html">DetachTrafficSources</a>
    /// API.
    /// </para>
    /// </summary>
    public partial class AttachTrafficSourcesRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private bool? _skipZonalShiftValidation;
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
        /// Gets and sets the property SkipZonalShiftValidation. 
        /// <para>
        ///  If you enable zonal shift with cross-zone disabled load balancers, capacity could
        /// become imbalanced across Availability Zones. To skip the validation, specify <c>true</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-zonal-shift.html">Auto
        /// Scaling group zonal shift</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        public bool? SkipZonalShiftValidation
        {
            get { return this._skipZonalShiftValidation; }
            set { this._skipZonalShiftValidation = value; }
        }

        // Check to see if SkipZonalShiftValidation property is set
        internal bool IsSetSkipZonalShiftValidation()
        {
            return this._skipZonalShiftValidation.HasValue; 
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