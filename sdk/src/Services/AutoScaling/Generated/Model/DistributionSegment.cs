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
    /// Use this structure to specify the capacity types that Amazon EC2 Auto Scaling prioritizes
    /// when it launches instances.
    /// </summary>
    public partial class DistributionSegment
    {
        private List<string> _targetCapacityTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property TargetCapacityTypes. 
        /// <para>
        /// The capacity types to prioritize, in order. Amazon EC2 Auto Scaling attempts to launch
        /// instances in the priority order of the capacity types, and within each capacity type,
        /// in the order of instance types listed in your launch template <c>Overrides</c>.
        /// </para>
        ///  
        /// <para>
        /// The following lists the valid values:
        /// </para>
        ///  <dl> <dt>on-demand-capacity-reservation</dt> <dd> 
        /// <para>
        /// On-Demand Capacity Reservations.
        /// </para>
        ///  </dd> <dt>capacity-block</dt> <dd> 
        /// <para>
        /// Capacity Blocks.
        /// </para>
        ///  </dd> <dt>interruptible-capacity-reservation</dt> <dd> 
        /// <para>
        /// Interruptible Capacity Reservations.
        /// </para>
        ///  </dd> <dt>on-demand</dt> <dd> 
        /// <para>
        /// On-Demand capacity. Include this value to allow the group to fall back to On-Demand
        /// capacity when the preceding capacity types are unavailable.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TargetCapacityTypes
        {
            get { return this._targetCapacityTypes; }
            set { this._targetCapacityTypes = value; }
        }

        // Check to see if TargetCapacityTypes property is set
        internal bool IsSetTargetCapacityTypes()
        {
            return this._targetCapacityTypes != null && (this._targetCapacityTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}