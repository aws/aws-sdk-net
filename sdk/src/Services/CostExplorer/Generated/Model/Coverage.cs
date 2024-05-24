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
    /// The amount of instance usage that a reservation covered.
    /// </summary>
    public partial class Coverage
    {
        private CoverageCost _coverageCost;
        private CoverageHours _coverageHours;
        private CoverageNormalizedUnits _coverageNormalizedUnits;

        /// <summary>
        /// Gets and sets the property CoverageCost. 
        /// <para>
        /// The amount of cost that the reservation covered.
        /// </para>
        /// </summary>
        public CoverageCost CoverageCost
        {
            get { return this._coverageCost; }
            set { this._coverageCost = value; }
        }

        // Check to see if CoverageCost property is set
        internal bool IsSetCoverageCost()
        {
            return this._coverageCost != null;
        }

        /// <summary>
        /// Gets and sets the property CoverageHours. 
        /// <para>
        /// The amount of instance usage that the reservation covered, in hours.
        /// </para>
        /// </summary>
        public CoverageHours CoverageHours
        {
            get { return this._coverageHours; }
            set { this._coverageHours = value; }
        }

        // Check to see if CoverageHours property is set
        internal bool IsSetCoverageHours()
        {
            return this._coverageHours != null;
        }

        /// <summary>
        /// Gets and sets the property CoverageNormalizedUnits. 
        /// <para>
        /// The amount of instance usage that the reservation covered, in normalized units.
        /// </para>
        /// </summary>
        public CoverageNormalizedUnits CoverageNormalizedUnits
        {
            get { return this._coverageNormalizedUnits; }
            set { this._coverageNormalizedUnits = value; }
        }

        // Check to see if CoverageNormalizedUnits property is set
        internal bool IsSetCoverageNormalizedUnits()
        {
            return this._coverageNormalizedUnits != null;
        }

    }
}