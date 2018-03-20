/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// How long a running instance either used a reservation or was On-Demand.
    /// </summary>
    public partial class CoverageHours
    {
        private string _coverageHoursPercentage;
        private string _onDemandHours;
        private string _reservedHours;
        private string _totalRunningHours;

        /// <summary>
        /// Gets and sets the property CoverageHoursPercentage. 
        /// <para>
        /// The percentage of instance hours that are covered by a reservation.
        /// </para>
        /// </summary>
        public string CoverageHoursPercentage
        {
            get { return this._coverageHoursPercentage; }
            set { this._coverageHoursPercentage = value; }
        }

        // Check to see if CoverageHoursPercentage property is set
        internal bool IsSetCoverageHoursPercentage()
        {
            return this._coverageHoursPercentage != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandHours. 
        /// <para>
        /// The number of instance running hours that are covered by On-Demand Instances.
        /// </para>
        /// </summary>
        public string OnDemandHours
        {
            get { return this._onDemandHours; }
            set { this._onDemandHours = value; }
        }

        // Check to see if OnDemandHours property is set
        internal bool IsSetOnDemandHours()
        {
            return this._onDemandHours != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedHours. 
        /// <para>
        /// The number of instance running hours that are covered by reservations.
        /// </para>
        /// </summary>
        public string ReservedHours
        {
            get { return this._reservedHours; }
            set { this._reservedHours = value; }
        }

        // Check to see if ReservedHours property is set
        internal bool IsSetReservedHours()
        {
            return this._reservedHours != null;
        }

        /// <summary>
        /// Gets and sets the property TotalRunningHours. 
        /// <para>
        /// The total instance usage, in hours.
        /// </para>
        /// </summary>
        public string TotalRunningHours
        {
            get { return this._totalRunningHours; }
            set { this._totalRunningHours = value; }
        }

        // Check to see if TotalRunningHours property is set
        internal bool IsSetTotalRunningHours()
        {
            return this._totalRunningHours != null;
        }

    }
}