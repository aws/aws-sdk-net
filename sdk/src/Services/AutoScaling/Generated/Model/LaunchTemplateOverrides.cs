/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes an override for a launch template.
    /// </summary>
    public partial class LaunchTemplateOverrides
    {
        private string _instanceType;
        private string _weightedCapacity;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        ///  
        /// <para>
        /// For information about available instance types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#AvailableInstanceTypes">Available
        /// Instance Types</a> in the <i>Amazon Elastic Compute Cloud User Guide.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property WeightedCapacity. 
        /// <para>
        /// The number of capacity units, which gives the instance type a proportional weight
        /// to other instance types. For example, larger instance types are generally weighted
        /// more than smaller instance types. These are the same units that you chose to set the
        /// desired capacity in terms of instances, or a performance attribute such as vCPUs,
        /// memory, or I/O.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 1. Maximum value of 999.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string WeightedCapacity
        {
            get { return this._weightedCapacity; }
            set { this._weightedCapacity = value; }
        }

        // Check to see if WeightedCapacity property is set
        internal bool IsSetWeightedCapacity()
        {
            return this._weightedCapacity != null;
        }

    }
}