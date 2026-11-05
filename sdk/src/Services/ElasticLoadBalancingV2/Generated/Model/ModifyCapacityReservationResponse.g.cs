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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// This is the response object from the ModifyCapacityReservation operation.
    /// </summary>
    public partial class ModifyCapacityReservationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CapacityReservationState. 
        /// <para>
        /// The state of the capacity reservation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ZonalCapacityReservationState> CapacityReservationState { get; set; } = AWSConfigs.InitializeCollections ? new List<ZonalCapacityReservationState>() : null;

        /// <summary>
        /// Checks to see if the CapacityReservationState property is set.
        /// </summary>
        internal bool IsSetCapacityReservationState() => this.CapacityReservationState != null && (this.CapacityReservationState.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DecreaseRequestsRemaining. 
        /// <para>
        /// The amount of daily capacity decreases remaining.
        /// </para>
        /// </summary>
        public int? DecreaseRequestsRemaining { get; set; }

        /// <summary>
        /// Checks to see if the DecreaseRequestsRemaining property is set.
        /// </summary>
        internal bool IsSetDecreaseRequestsRemaining() => this.DecreaseRequestsRemaining.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time the capacity reservation was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumLoadBalancerCapacity. 
        /// <para>
        /// The requested minimum capacity reservation for the load balancer
        /// </para>
        /// </summary>
        public MinimumLoadBalancerCapacity MinimumLoadBalancerCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MinimumLoadBalancerCapacity property is set.
        /// </summary>
        internal bool IsSetMinimumLoadBalancerCapacity() => this.MinimumLoadBalancerCapacity != null;
    }
}
