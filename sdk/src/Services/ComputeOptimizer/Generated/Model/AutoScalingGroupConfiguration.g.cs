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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the configuration of an EC2 Auto Scaling group.
    /// </summary>
    public partial class AutoScalingGroupConfiguration
    {
        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        ///  Describes the allocation strategy that the EC2 Auto Scaling group uses. This field
        /// is only available for EC2 Auto Scaling groups with mixed instance types. 
        /// </para>
        /// </summary>
        public AllocationStrategy AllocationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the AllocationStrategy property is set.
        /// </summary>
        internal bool IsSetAllocationStrategy() => this.AllocationStrategy != null;

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The desired capacity, or number of instances, for the EC2 Auto Scaling group.
        /// </para>
        /// </summary>
        public int? DesiredCapacity { get; set; }

        /// <summary>
        /// Checks to see if the DesiredCapacity property is set.
        /// </summary>
        internal bool IsSetDesiredCapacity() => this.DesiredCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedInstanceHourReductionPercentage. 
        /// <para>
        ///  Describes the projected percentage reduction in instance hours after adopting the
        /// recommended configuration. This field is only available for EC2 Auto Scaling groups
        /// with scaling policies. 
        /// </para>
        /// </summary>
        public double? EstimatedInstanceHourReductionPercentage { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedInstanceHourReductionPercentage property is set.
        /// </summary>
        internal bool IsSetEstimatedInstanceHourReductionPercentage() => this.EstimatedInstanceHourReductionPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type for the EC2 Auto Scaling group.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum size, or maximum number of instances, for the EC2 Auto Scaling group.
        /// </para>
        /// </summary>
        public int? MaxSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxSize property is set.
        /// </summary>
        internal bool IsSetMaxSize() => this.MaxSize.HasValue;

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum size, or minimum number of instances, for the EC2 Auto Scaling group.
        /// </para>
        /// </summary>
        public int? MinSize { get; set; }

        /// <summary>
        /// Checks to see if the MinSize property is set.
        /// </summary>
        internal bool IsSetMinSize() => this.MinSize.HasValue;

        /// <summary>
        /// Gets and sets the property MixedInstanceTypes. 
        /// <para>
        ///  List the instance types within an EC2 Auto Scaling group that has mixed instance
        /// types. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MixedInstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MixedInstanceTypes property is set.
        /// </summary>
        internal bool IsSetMixedInstanceTypes() => this.MixedInstanceTypes != null && (this.MixedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  Describes whether the EC2 Auto Scaling group has a single instance type or a mixed
        /// instance type configuration. 
        /// </para>
        /// </summary>
        public AsgType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
