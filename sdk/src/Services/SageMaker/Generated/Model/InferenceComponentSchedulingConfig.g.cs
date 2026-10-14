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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The scheduling configuration that determines how inference component copies are placed
    /// across available instances when copies are added or removed.
    /// </summary>
    public partial class InferenceComponentSchedulingConfig
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZoneBalance. 
        /// <para>
        /// Configuration for balancing inference component copies across Availability Zones.
        /// </para>
        /// </summary>
        public InferenceComponentAvailabilityZoneBalance AvailabilityZoneBalance { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneBalance property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneBalance() => this.AvailabilityZoneBalance != null;

        /// <summary>
        /// Gets and sets the property PlacementStrategy. 
        /// <para>
        /// The strategy for placing inference component copies across available instances. If
        /// you also set <c>AvailabilityZoneBalance</c>, this strategy applies to placement within
        /// each Availability Zone.
        /// </para>
        ///  <dl> <dt>SPREAD</dt> <dd> 
        /// <para>
        /// Distributes copies evenly across available instances for better resilience.
        /// </para>
        ///  </dd> <dt>BINPACK</dt> <dd> 
        /// <para>
        /// Packs copies onto fewer instances to optimize resource utilization.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceComponentPlacementStrategy PlacementStrategy { get; set; }

        /// <summary>
        /// Checks to see if the PlacementStrategy property is set.
        /// </summary>
        internal bool IsSetPlacementStrategy() => this.PlacementStrategy != null;
    }
}
