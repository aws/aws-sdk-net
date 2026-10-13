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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// How long a running instance either used a reservation or was On-Demand.
    /// </summary>
    public partial class CoverageHours
    {
        /// <summary>
        /// Gets and sets the property CoverageHoursPercentage. 
        /// <para>
        /// The percentage of instance hours that a reservation covered.
        /// </para>
        /// </summary>
        public string CoverageHoursPercentage { get; set; }

        /// <summary>
        /// Checks to see if the CoverageHoursPercentage property is set.
        /// </summary>
        internal bool IsSetCoverageHoursPercentage() => this.CoverageHoursPercentage != null;

        /// <summary>
        /// Gets and sets the property OnDemandHours. 
        /// <para>
        /// The number of instance running hours that On-Demand Instances covered.
        /// </para>
        /// </summary>
        public string OnDemandHours { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandHours property is set.
        /// </summary>
        internal bool IsSetOnDemandHours() => this.OnDemandHours != null;

        /// <summary>
        /// Gets and sets the property ReservedHours. 
        /// <para>
        /// The number of instance running hours that reservations covered.
        /// </para>
        /// </summary>
        public string ReservedHours { get; set; }

        /// <summary>
        /// Checks to see if the ReservedHours property is set.
        /// </summary>
        internal bool IsSetReservedHours() => this.ReservedHours != null;

        /// <summary>
        /// Gets and sets the property TotalRunningHours. 
        /// <para>
        /// The total instance usage, in hours.
        /// </para>
        /// </summary>
        public string TotalRunningHours { get; set; }

        /// <summary>
        /// Checks to see if the TotalRunningHours property is set.
        /// </summary>
        internal bool IsSetTotalRunningHours() => this.TotalRunningHours != null;
    }
}
