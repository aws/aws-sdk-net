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

namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// Defines the data retrieval parameters for a widget.
    /// </summary>
    public partial class QueryParameters
    {
        /// <summary>
        /// Gets and sets the property CostAndUsage. 
        /// <para>
        /// The parameters for querying cost and usage data, including metrics, time range, granularity,
        /// grouping dimensions, and filters.
        /// </para>
        /// </summary>
        public CostAndUsageQuery CostAndUsage { get; set; }

        /// <summary>
        /// Checks to see if the CostAndUsage property is set.
        /// </summary>
        internal bool IsSetCostAndUsage() => this.CostAndUsage != null;

        /// <summary>
        /// Gets and sets the property ReservationCoverage. 
        /// <para>
        /// The parameters for querying Reserved Instance coverage data, showing how much of your
        /// eligible instance usage is covered by Reserved Instances.
        /// </para>
        /// </summary>
        public ReservationCoverageQuery ReservationCoverage { get; set; }

        /// <summary>
        /// Checks to see if the ReservationCoverage property is set.
        /// </summary>
        internal bool IsSetReservationCoverage() => this.ReservationCoverage != null;

        /// <summary>
        /// Gets and sets the property ReservationUtilization. 
        /// <para>
        /// The parameters for querying Reserved Instance utilization data, showing how effectively
        /// your Reserved Instances are being used.
        /// </para>
        /// </summary>
        public ReservationUtilizationQuery ReservationUtilization { get; set; }

        /// <summary>
        /// Checks to see if the ReservationUtilization property is set.
        /// </summary>
        internal bool IsSetReservationUtilization() => this.ReservationUtilization != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansCoverage. 
        /// <para>
        /// The parameters for querying Savings Plans coverage data, showing how much of your
        /// eligible compute usage is covered by Savings Plans.
        /// </para>
        /// </summary>
        public SavingsPlansCoverageQuery SavingsPlansCoverage { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansCoverage property is set.
        /// </summary>
        internal bool IsSetSavingsPlansCoverage() => this.SavingsPlansCoverage != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansUtilization. 
        /// <para>
        /// The parameters for querying Savings Plans utilization data, showing how effectively
        /// your Savings Plans are being used.
        /// </para>
        /// </summary>
        public SavingsPlansUtilizationQuery SavingsPlansUtilization { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansUtilization property is set.
        /// </summary>
        internal bool IsSetSavingsPlansUtilization() => this.SavingsPlansUtilization != null;
    }
}
