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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
    /// 
    /// </summary>
    public partial class GetMinuteUsageResponse : AmazonWebServiceResponse
    {
        private int? _estimatedMinutesRemaining;
        private bool? _isReservedMinutesCustomer;
        private int? _totalReservedMinuteAllocation;
        private int? _totalScheduledMinutes;
        private int? _upcomingMinutesScheduled;

        /// <summary>
        /// Gets and sets the property EstimatedMinutesRemaining. 
        /// <para>
        /// Estimated number of minutes remaining for an account, specific to the month being
        /// requested.
        /// </para>
        /// </summary>
        public int? EstimatedMinutesRemaining
        {
            get { return this._estimatedMinutesRemaining; }
            set { this._estimatedMinutesRemaining = value; }
        }

        // Check to see if EstimatedMinutesRemaining property is set
        internal bool IsSetEstimatedMinutesRemaining()
        {
            return this._estimatedMinutesRemaining.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsReservedMinutesCustomer. 
        /// <para>
        /// Returns whether or not an account has signed up for the reserved minutes pricing plan,
        /// specific to the month being requested.
        /// </para>
        /// </summary>
        public bool? IsReservedMinutesCustomer
        {
            get { return this._isReservedMinutesCustomer; }
            set { this._isReservedMinutesCustomer = value; }
        }

        // Check to see if IsReservedMinutesCustomer property is set
        internal bool IsSetIsReservedMinutesCustomer()
        {
            return this._isReservedMinutesCustomer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalReservedMinuteAllocation. 
        /// <para>
        /// Total number of reserved minutes allocated, specific to the month being requested.
        /// </para>
        /// </summary>
        public int? TotalReservedMinuteAllocation
        {
            get { return this._totalReservedMinuteAllocation; }
            set { this._totalReservedMinuteAllocation = value; }
        }

        // Check to see if TotalReservedMinuteAllocation property is set
        internal bool IsSetTotalReservedMinuteAllocation()
        {
            return this._totalReservedMinuteAllocation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalScheduledMinutes. 
        /// <para>
        /// Total scheduled minutes for an account, specific to the month being requested.
        /// </para>
        /// </summary>
        public int? TotalScheduledMinutes
        {
            get { return this._totalScheduledMinutes; }
            set { this._totalScheduledMinutes = value; }
        }

        // Check to see if TotalScheduledMinutes property is set
        internal bool IsSetTotalScheduledMinutes()
        {
            return this._totalScheduledMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpcomingMinutesScheduled. 
        /// <para>
        /// Upcoming minutes scheduled for an account, specific to the month being requested.
        /// </para>
        /// </summary>
        public int? UpcomingMinutesScheduled
        {
            get { return this._upcomingMinutesScheduled; }
            set { this._upcomingMinutesScheduled = value; }
        }

        // Check to see if UpcomingMinutesScheduled property is set
        internal bool IsSetUpcomingMinutesScheduled()
        {
            return this._upcomingMinutesScheduled.HasValue; 
        }

    }
}