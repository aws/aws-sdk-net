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
    /// The capacity reservation configuration for an AI recommendation job.
    /// </summary>
    public partial class AICapacityReservationConfig
    {
        private AICapacityReservationPreference _capacityReservationPreference;
        private List<string> _mlReservationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CapacityReservationPreference. 
        /// <para>
        /// The capacity reservation preference. The only valid value is <c>capacity-reservations-only</c>.
        /// </para>
        /// </summary>
        public AICapacityReservationPreference CapacityReservationPreference
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
        /// Gets and sets the property MlReservationArns. 
        /// <para>
        /// The list of ML reservation ARNs to use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MlReservationArns
        {
            get { return this._mlReservationArns; }
            set { this._mlReservationArns = value; }
        }

        // Check to see if MlReservationArns property is set
        internal bool IsSetMlReservationArns()
        {
            return this._mlReservationArns != null && (this._mlReservationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}