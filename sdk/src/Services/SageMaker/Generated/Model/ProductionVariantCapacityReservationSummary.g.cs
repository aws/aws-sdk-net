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
    /// Details about an ML capacity reservation.
    /// </summary>
    public partial class ProductionVariantCapacityReservationSummary
    {
        /// <summary>
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of instances that are currently available in the ML capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AvailableInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableInstanceCount property is set.
        /// </summary>
        internal bool IsSetAvailableInstanceCount() => this.AvailableInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityReservationPreference. 
        /// <para>
        /// The option that you chose for the capacity reservation. SageMaker AI supports the
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
        /// Gets and sets the property Ec2CapacityReservations. 
        /// <para>
        /// The EC2 capacity reservations that are shared to this ML capacity reservation, if
        /// any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ec2CapacityReservation> Ec2CapacityReservations { get; set; } = AWSConfigs.InitializeCollections ? new List<Ec2CapacityReservation>() : null;

        /// <summary>
        /// Checks to see if the Ec2CapacityReservations property is set.
        /// </summary>
        internal bool IsSetEc2CapacityReservations() => this.Ec2CapacityReservations != null && (this.Ec2CapacityReservations.Count > 0 || !AWSConfigs.InitializeCollections);

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

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The number of instances that you allocated to the ML capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalInstanceCount property is set.
        /// </summary>
        internal bool IsSetTotalInstanceCount() => this.TotalInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property UsedByCurrentEndpoint. 
        /// <para>
        /// The number of instances from the ML capacity reservation that are being used by the
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? UsedByCurrentEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UsedByCurrentEndpoint property is set.
        /// </summary>
        internal bool IsSetUsedByCurrentEndpoint() => this.UsedByCurrentEndpoint.HasValue;
    }
}
