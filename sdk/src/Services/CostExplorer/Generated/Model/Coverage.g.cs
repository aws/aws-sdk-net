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
    /// The amount of instance usage that a reservation covered.
    /// </summary>
    public partial class Coverage
    {
        /// <summary>
        /// Gets and sets the property CoverageCost. 
        /// <para>
        /// The amount of cost that the reservation covered.
        /// </para>
        /// </summary>
        public CoverageCost CoverageCost { get; set; }

        /// <summary>
        /// Checks to see if the CoverageCost property is set.
        /// </summary>
        internal bool IsSetCoverageCost() => this.CoverageCost != null;

        /// <summary>
        /// Gets and sets the property CoverageHours. 
        /// <para>
        /// The amount of instance usage that the reservation covered, in hours.
        /// </para>
        /// </summary>
        public CoverageHours CoverageHours { get; set; }

        /// <summary>
        /// Checks to see if the CoverageHours property is set.
        /// </summary>
        internal bool IsSetCoverageHours() => this.CoverageHours != null;

        /// <summary>
        /// Gets and sets the property CoverageNormalizedUnits. 
        /// <para>
        /// The amount of instance usage that the reservation covered, in normalized units.
        /// </para>
        /// </summary>
        public CoverageNormalizedUnits CoverageNormalizedUnits { get; set; }

        /// <summary>
        /// Checks to see if the CoverageNormalizedUnits property is set.
        /// </summary>
        internal bool IsSetCoverageNormalizedUnits() => this.CoverageNormalizedUnits != null;
    }
}
