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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// This is the response object from the GetMinuteUsage operation.
    /// </summary>
    public partial class GetMinuteUsageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EstimatedMinutesRemaining. 
        /// <para>
        /// Estimated number of minutes remaining for an account, specific to the month being
        /// requested.
        /// </para>
        /// </summary>
        public int? EstimatedMinutesRemaining { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMinutesRemaining property is set.
        /// </summary>
        internal bool IsSetEstimatedMinutesRemaining() => this.EstimatedMinutesRemaining.HasValue;

        /// <summary>
        /// Gets and sets the property IsReservedMinutesCustomer. 
        /// <para>
        /// Returns whether or not an account has signed up for the reserved minutes pricing plan,
        /// specific to the month being requested.
        /// </para>
        /// </summary>
        public bool? IsReservedMinutesCustomer { get; set; }

        /// <summary>
        /// Checks to see if the IsReservedMinutesCustomer property is set.
        /// </summary>
        internal bool IsSetIsReservedMinutesCustomer() => this.IsReservedMinutesCustomer.HasValue;

        /// <summary>
        /// Gets and sets the property TotalReservedMinuteAllocation. 
        /// <para>
        /// Total number of reserved minutes allocated, specific to the month being requested.
        /// </para>
        /// </summary>
        public int? TotalReservedMinuteAllocation { get; set; }

        /// <summary>
        /// Checks to see if the TotalReservedMinuteAllocation property is set.
        /// </summary>
        internal bool IsSetTotalReservedMinuteAllocation() => this.TotalReservedMinuteAllocation.HasValue;

        /// <summary>
        /// Gets and sets the property TotalScheduledMinutes. 
        /// <para>
        /// Total scheduled minutes for an account, specific to the month being requested.
        /// </para>
        /// </summary>
        public int? TotalScheduledMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TotalScheduledMinutes property is set.
        /// </summary>
        internal bool IsSetTotalScheduledMinutes() => this.TotalScheduledMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property UpcomingMinutesScheduled. 
        /// <para>
        /// Upcoming minutes scheduled for an account, specific to the month being requested.
        /// </para>
        /// </summary>
        public int? UpcomingMinutesScheduled { get; set; }

        /// <summary>
        /// Checks to see if the UpcomingMinutesScheduled property is set.
        /// </summary>
        internal bool IsSetUpcomingMinutesScheduled() => this.UpcomingMinutesScheduled.HasValue;
    }
}
