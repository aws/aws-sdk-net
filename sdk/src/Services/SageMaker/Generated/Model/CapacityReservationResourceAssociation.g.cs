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
    /// An association between one type of resource in your account and a SageMaker Capacity
    /// Reservation. Each item contains exactly one member.
    /// </summary>
    public partial class CapacityReservationResourceAssociation
    {
        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The association between the SageMaker AI endpoints in your account and the SageMaker
        /// Capacity Reservation, through one ML capacity reservation. The response includes one
        /// item for each ML capacity reservation.
        /// </para>
        /// </summary>
        public CapacityReservationEndpointsAssociation Endpoints { get; set; }

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null;

        /// <summary>
        /// Gets and sets the property HyperPodClusters. 
        /// <para>
        /// The association between the SageMaker AI HyperPod clusters in your account and the
        /// SageMaker Capacity Reservation. The association applies to all HyperPod clusters in
        /// your account.
        /// </para>
        /// </summary>
        public CapacityReservationHyperPodClustersAssociation HyperPodClusters { get; set; }

        /// <summary>
        /// Checks to see if the HyperPodClusters property is set.
        /// </summary>
        internal bool IsSetHyperPodClusters() => this.HyperPodClusters != null;
    }
}
