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

namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// A numeric value corresponding to the severity of a finding, such as the number of
    /// open findings or the average time it takes to close findings of a given severity.
    /// </summary>
    public partial class FindingMetricsValuePerSeverity
    {
        /// <summary>
        /// Gets and sets the property Critical. 
        /// <para>
        /// A numeric value corresponding to a critical finding.
        /// </para>
        /// </summary>
        public double? Critical { get; set; }

        /// <summary>
        /// Checks to see if the Critical property is set.
        /// </summary>
        internal bool IsSetCritical() => this.Critical.HasValue;

        /// <summary>
        /// Gets and sets the property High. 
        /// <para>
        /// A numeric value corresponding to a high severity finding.
        /// </para>
        /// </summary>
        public double? High { get; set; }

        /// <summary>
        /// Checks to see if the High property is set.
        /// </summary>
        internal bool IsSetHigh() => this.High.HasValue;

        /// <summary>
        /// Gets and sets the property Info. 
        /// <para>
        /// A numeric value corresponding to an informational finding.
        /// </para>
        /// </summary>
        public double? Info { get; set; }

        /// <summary>
        /// Checks to see if the Info property is set.
        /// </summary>
        internal bool IsSetInfo() => this.Info.HasValue;

        /// <summary>
        /// Gets and sets the property Low. 
        /// <para>
        /// A numeric value corresponding to a low severity finding.
        /// </para>
        /// </summary>
        public double? Low { get; set; }

        /// <summary>
        /// Checks to see if the Low property is set.
        /// </summary>
        internal bool IsSetLow() => this.Low.HasValue;

        /// <summary>
        /// Gets and sets the property Medium. 
        /// <para>
        /// A numeric value corresponding to a medium severity finding.
        /// </para>
        /// </summary>
        public double? Medium { get; set; }

        /// <summary>
        /// Checks to see if the Medium property is set.
        /// </summary>
        internal bool IsSetMedium() => this.Medium.HasValue;
    }
}
