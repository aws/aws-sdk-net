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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
    /// The amount of instance usage, in normalized units. You can use normalized units to
    /// see your EC2 usage for multiple sizes of instances in a uniform way. For example,
    /// suppose that you run an xlarge instance and a 2xlarge instance. If you run both instances
    /// for the same amount of time, the 2xlarge instance uses twice as much of your reservation
    /// as the xlarge instance, even though both instances show only one instance-hour. When
    /// you use normalized units instead of instance-hours, the xlarge instance used 8 normalized
    /// units, and the 2xlarge instance used 16 normalized units.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
    /// Reserved Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux
    /// Instances</i>.
    /// </para>
    /// </summary>
    public partial class CoverageNormalizedUnits
    {
        private string _coverageNormalizedUnitsPercentage;
        private string _onDemandNormalizedUnits;
        private string _reservedNormalizedUnits;
        private string _totalRunningNormalizedUnits;

        /// <summary>
        /// Gets and sets the property CoverageNormalizedUnitsPercentage. 
        /// <para>
        /// The percentage of your used instance normalized units that a reservation covers.
        /// </para>
        /// </summary>
        public string CoverageNormalizedUnitsPercentage
        {
            get { return this._coverageNormalizedUnitsPercentage; }
            set { this._coverageNormalizedUnitsPercentage = value; }
        }

        // Check to see if CoverageNormalizedUnitsPercentage property is set
        internal bool IsSetCoverageNormalizedUnitsPercentage()
        {
            return this._coverageNormalizedUnitsPercentage != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandNormalizedUnits. 
        /// <para>
        /// The number of normalized units that are covered by On-Demand Instances instead of
        /// a reservation.
        /// </para>
        /// </summary>
        public string OnDemandNormalizedUnits
        {
            get { return this._onDemandNormalizedUnits; }
            set { this._onDemandNormalizedUnits = value; }
        }

        // Check to see if OnDemandNormalizedUnits property is set
        internal bool IsSetOnDemandNormalizedUnits()
        {
            return this._onDemandNormalizedUnits != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedNormalizedUnits. 
        /// <para>
        /// The number of normalized units that a reservation covers.
        /// </para>
        /// </summary>
        public string ReservedNormalizedUnits
        {
            get { return this._reservedNormalizedUnits; }
            set { this._reservedNormalizedUnits = value; }
        }

        // Check to see if ReservedNormalizedUnits property is set
        internal bool IsSetReservedNormalizedUnits()
        {
            return this._reservedNormalizedUnits != null;
        }

        /// <summary>
        /// Gets and sets the property TotalRunningNormalizedUnits. 
        /// <para>
        /// The total number of normalized units that you used.
        /// </para>
        /// </summary>
        public string TotalRunningNormalizedUnits
        {
            get { return this._totalRunningNormalizedUnits; }
            set { this._totalRunningNormalizedUnits = value; }
        }

        // Check to see if TotalRunningNormalizedUnits property is set
        internal bool IsSetTotalRunningNormalizedUnits()
        {
            return this._totalRunningNormalizedUnits != null;
        }

    }
}