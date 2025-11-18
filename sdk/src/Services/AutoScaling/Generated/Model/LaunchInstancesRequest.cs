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
    /// Container for the parameters to the LaunchInstances operation.
    /// Launches a specified number of instances in an Auto Scaling group. Returns instance
    /// IDs and other details if launch is successful or error details if launch is unsuccessful.
    /// </summary>
    public partial class LaunchInstancesRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _availabilityZoneIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private int? _requestedCapacity;
        private RetryStrategy _retryStrategy;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///  The name of the Auto Scaling group to launch instances into. 
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
        /// Gets and sets the property AvailabilityZoneIds. 
        /// <para>
        ///  A list of Availability Zone IDs where instances should be launched. Must match or
        /// be included in the group's AZ configuration. You cannot specify both AvailabilityZones
        /// and AvailabilityZoneIds. Required for multi-AZ groups, optional for single-AZ groups.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> AvailabilityZoneIds
        {
            get { return this._availabilityZoneIds; }
            set { this._availabilityZoneIds = value; }
        }

        // Check to see if AvailabilityZoneIds property is set
        internal bool IsSetAvailabilityZoneIds()
        {
            return this._availabilityZoneIds != null && (this._availabilityZoneIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        ///  The Availability Zones for the instance launch. Must match or be included in the
        /// Auto Scaling group's Availability Zone configuration. Either <c>AvailabilityZones</c>
        /// or <c>SubnetIds</c> must be specified for groups with multiple Availability Zone configurations.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique, case-sensitive identifier to ensure idempotency of the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedCapacity. 
        /// <para>
        ///  The number of instances to launch. Although this value can exceed 100 for instance
        /// weights, the actual instance count is limited to 100 instances per launch. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int RequestedCapacity
        {
            get { return this._requestedCapacity.GetValueOrDefault(); }
            set { this._requestedCapacity = value; }
        }

        // Check to see if RequestedCapacity property is set
        internal bool IsSetRequestedCapacity()
        {
            return this._requestedCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        ///  Specifies whether to retry asynchronously if the synchronous launch fails. Valid
        /// values are NONE (default, no async retry) and RETRY_WITH_GROUP_CONFIGURATION (increase
        /// desired capacity and retry with group configuration). 
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy
        {
            get { return this._retryStrategy; }
            set { this._retryStrategy = value; }
        }

        // Check to see if RetryStrategy property is set
        internal bool IsSetRetryStrategy()
        {
            return this._retryStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        ///  The subnet IDs for the instance launch. Either <c>AvailabilityZones</c> or <c>SubnetIds</c>
        /// must be specified. If both are specified, the subnets must reside in the specified
        /// Availability Zones. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}