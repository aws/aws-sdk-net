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
    /// Settings for the capacity reservation for the compute instances that SageMaker AI
    /// reserves for an endpoint.
    /// </summary>
    public partial class ProductionVariantCapacityReservationConfig
    {
        /// <summary>
        /// Gets and sets the property CapacityReservationPreference. 
        /// <para>
        /// Options that you can choose for the capacity reservation. SageMaker AI supports the
        /// following options:
        /// </para>
        ///  <dl> <dt>capacity-reservations-only</dt> <dd> 
        /// <para>
        /// SageMaker AI launches instances only into an ML capacity reservation. If no capacity
        /// is available, the instances fail to launch.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public CapacityReservationPreference CapacityReservationPreference { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationPreference property is set.
        /// </summary>
        internal bool IsSetCapacityReservationPreference() => this.CapacityReservationPreference != null;

        /// <summary>
        /// Gets and sets the property MlReservationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the ML capacity reservation
        /// that SageMaker AI applies when it deploys the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 258)]
        public string MlReservationArn { get; set; }

        /// <summary>
        /// Checks to see if the MlReservationArn property is set.
        /// </summary>
        internal bool IsSetMlReservationArn() => this.MlReservationArn != null;
    }
}
