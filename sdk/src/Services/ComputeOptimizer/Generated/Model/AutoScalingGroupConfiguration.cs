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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
        private AllocationStrategy _allocationStrategy;
        private int? _desiredCapacity;
        private double? _estimatedInstanceHourReductionPercentage;
        private string _instanceType;
        private int? _maxSize;
        private int? _minSize;
        private List<string> _mixedInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AsgType _type;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        ///  Describes the allocation strategy that the EC2 Auto Scaling group uses. This field
        /// is only available for EC2 Auto Scaling groups with mixed instance types. 
        /// </para>
        /// </summary>
        public AllocationStrategy AllocationStrategy
        {
            get { return this._allocationStrategy; }
            set { this._allocationStrategy = value; }
        }

        // Check to see if AllocationStrategy property is set
        internal bool IsSetAllocationStrategy()
        {
            return this._allocationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The desired capacity, or number of instances, for the EC2 Auto Scaling group.
        /// </para>
        /// </summary>
        public int? DesiredCapacity
        {
            get { return this._desiredCapacity; }
            set { this._desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedInstanceHourReductionPercentage. 
        /// <para>
        ///  Describes the projected percentage reduction in instance hours after adopting the
        /// recommended configuration. This field is only available for EC2 Auto Scaling groups
        /// with scaling policies. 
        /// </para>
        /// </summary>
        public double? EstimatedInstanceHourReductionPercentage
        {
            get { return this._estimatedInstanceHourReductionPercentage; }
            set { this._estimatedInstanceHourReductionPercentage = value; }
        }

        // Check to see if EstimatedInstanceHourReductionPercentage property is set
        internal bool IsSetEstimatedInstanceHourReductionPercentage()
        {
            return this._estimatedInstanceHourReductionPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type for the EC2 Auto Scaling group.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum size, or maximum number of instances, for the EC2 Auto Scaling group.
        /// </para>
        /// </summary>
        public int? MaxSize
        {
            get { return this._maxSize; }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum size, or minimum number of instances, for the EC2 Auto Scaling group.
        /// </para>
        /// </summary>
        public int? MinSize
        {
            get { return this._minSize; }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MixedInstanceTypes. 
        /// <para>
        ///  List the instance types within an EC2 Auto Scaling group that has mixed instance
        /// types. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MixedInstanceTypes
        {
            get { return this._mixedInstanceTypes; }
            set { this._mixedInstanceTypes = value; }
        }

        // Check to see if MixedInstanceTypes property is set
        internal bool IsSetMixedInstanceTypes()
        {
            return this._mixedInstanceTypes != null && (this._mixedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  Describes whether the EC2 Auto Scaling group has a single instance type or a mixed
        /// instance type configuration. 
        /// </para>
        /// </summary>
        public AsgType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}