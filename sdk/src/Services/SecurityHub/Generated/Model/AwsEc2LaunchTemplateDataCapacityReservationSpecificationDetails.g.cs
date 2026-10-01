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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies the Capacity Reservation targeting option of an Amazon EC2 instance.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails
    {
        /// <summary>
        /// Gets and sets the property CapacityReservationPreference. 
        /// <para>
        ///  Indicates the instance's Capacity Reservation preferences. If equal to <c>open</c>,
        /// the instance can run in any open Capacity Reservation that has matching attributes
        /// (instance type, platform, Availability Zone). If equal to <c>none</c>, the instance
        /// avoids running in a Capacity Reservation even if one is available. The instance runs
        /// in On-Demand capacity. 
        /// </para>
        /// </summary>
        public string CapacityReservationPreference { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationPreference property is set.
        /// </summary>
        internal bool IsSetCapacityReservationPreference() => this.CapacityReservationPreference != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationTarget. 
        /// <para>
        ///  Specifies a target Capacity Reservation. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataCapacityReservationSpecificationCapacityReservationTargetDetails CapacityReservationTarget { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationTarget property is set.
        /// </summary>
        internal bool IsSetCapacityReservationTarget() => this.CapacityReservationTarget != null;
    }
}
