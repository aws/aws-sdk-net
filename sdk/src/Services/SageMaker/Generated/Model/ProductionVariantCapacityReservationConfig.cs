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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private CapacityReservationPreference _capacityReservationPreference;
        private string _mlReservationArn;

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
        public CapacityReservationPreference CapacityReservationPreference
        {
            get { return this._capacityReservationPreference; }
            set { this._capacityReservationPreference = value; }
        }

        // Check to see if CapacityReservationPreference property is set
        internal bool IsSetCapacityReservationPreference()
        {
            return this._capacityReservationPreference != null;
        }

        /// <summary>
        /// Gets and sets the property MlReservationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the ML capacity reservation
        /// that SageMaker AI applies when it deploys the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=258)]
        public string MlReservationArn
        {
            get { return this._mlReservationArn; }
            set { this._mlReservationArn = value; }
        }

        // Check to see if MlReservationArn property is set
        internal bool IsSetMlReservationArn()
        {
            return this._mlReservationArn != null;
        }

    }
}