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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
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
        private CostAndUsageQuery _costAndUsage;
        private ReservationCoverageQuery _reservationCoverage;
        private ReservationUtilizationQuery _reservationUtilization;
        private SavingsPlansCoverageQuery _savingsPlansCoverage;
        private SavingsPlansUtilizationQuery _savingsPlansUtilization;

        /// <summary>
        /// Gets and sets the property CostAndUsage. 
        /// <para>
        /// The parameters for querying cost and usage data, including metrics, time range, granularity,
        /// grouping dimensions, and filters.
        /// </para>
        /// </summary>
        public CostAndUsageQuery CostAndUsage
        {
            get { return this._costAndUsage; }
            set { this._costAndUsage = value; }
        }

        // Check to see if CostAndUsage property is set
        internal bool IsSetCostAndUsage()
        {
            return this._costAndUsage != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationCoverage. 
        /// <para>
        /// The parameters for querying Reserved Instance coverage data, showing how much of your
        /// eligible instance usage is covered by Reserved Instances.
        /// </para>
        /// </summary>
        public ReservationCoverageQuery ReservationCoverage
        {
            get { return this._reservationCoverage; }
            set { this._reservationCoverage = value; }
        }

        // Check to see if ReservationCoverage property is set
        internal bool IsSetReservationCoverage()
        {
            return this._reservationCoverage != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationUtilization. 
        /// <para>
        /// The parameters for querying Reserved Instance utilization data, showing how effectively
        /// your Reserved Instances are being used.
        /// </para>
        /// </summary>
        public ReservationUtilizationQuery ReservationUtilization
        {
            get { return this._reservationUtilization; }
            set { this._reservationUtilization = value; }
        }

        // Check to see if ReservationUtilization property is set
        internal bool IsSetReservationUtilization()
        {
            return this._reservationUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansCoverage. 
        /// <para>
        /// The parameters for querying Savings Plans coverage data, showing how much of your
        /// eligible compute usage is covered by Savings Plans.
        /// </para>
        /// </summary>
        public SavingsPlansCoverageQuery SavingsPlansCoverage
        {
            get { return this._savingsPlansCoverage; }
            set { this._savingsPlansCoverage = value; }
        }

        // Check to see if SavingsPlansCoverage property is set
        internal bool IsSetSavingsPlansCoverage()
        {
            return this._savingsPlansCoverage != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansUtilization. 
        /// <para>
        /// The parameters for querying Savings Plans utilization data, showing how effectively
        /// your Savings Plans are being used.
        /// </para>
        /// </summary>
        public SavingsPlansUtilizationQuery SavingsPlansUtilization
        {
            get { return this._savingsPlansUtilization; }
            set { this._savingsPlansUtilization = value; }
        }

        // Check to see if SavingsPlansUtilization property is set
        internal bool IsSetSavingsPlansUtilization()
        {
            return this._savingsPlansUtilization != null;
        }

    }
}