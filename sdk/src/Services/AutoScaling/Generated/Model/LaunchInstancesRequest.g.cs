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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the LaunchInstances operation. Launches a specified
    /// number of instances in an Auto Scaling group. Returns instance IDs and other details
    /// if launch is successful or error details if launch is unsuccessful.
    /// </summary>
    public partial class LaunchInstancesRequest : AmazonAutoScalingRequest
    {
        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///  The name of the Auto Scaling group to launch instances into. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AutoScalingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupName property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupName() => this.AutoScalingGroupName != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneIds. 
        /// <para>
        ///  A list of Availability Zone IDs where instances should be launched. Must match or
        /// be included in the group's AZ configuration. You cannot specify both AvailabilityZones
        /// and AvailabilityZoneIds. Required for multi-AZ groups, optional for single-AZ groups.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> AvailabilityZoneIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZoneIds property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneIds() => this.AvailabilityZoneIds != null && (this.AvailabilityZoneIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        ///  The Availability Zones for the instance launch. Must match or be included in the
        /// Auto Scaling group's Availability Zone configuration. Either <c>AvailabilityZones</c>
        /// or <c>SubnetIds</c> must be specified for groups with multiple Availability Zone configurations.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique, case-sensitive identifier to ensure idempotency of the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property RequestedCapacity. 
        /// <para>
        ///  The number of instances to launch. Although this value can exceed 100 for instance
        /// weights, the actual instance count is limited to 100 instances per launch. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? RequestedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the RequestedCapacity property is set.
        /// </summary>
        internal bool IsSetRequestedCapacity() => this.RequestedCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        ///  Specifies whether to retry asynchronously if the synchronous launch fails. Valid
        /// values are NONE (default, no async retry) and RETRY_WITH_GROUP_CONFIGURATION (increase
        /// desired capacity and retry with group configuration). 
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the RetryStrategy property is set.
        /// </summary>
        internal bool IsSetRetryStrategy() => this.RetryStrategy != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        ///  The subnet IDs for the instance launch. Either <c>AvailabilityZones</c> or <c>SubnetIds</c>
        /// must be specified. If both are specified, the subnets must reside in the specified
        /// Availability Zones. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
