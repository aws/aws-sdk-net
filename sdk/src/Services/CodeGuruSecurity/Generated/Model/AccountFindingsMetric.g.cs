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
    /// A summary of findings metrics for an account on a specified date.
    /// </summary>
    public partial class AccountFindingsMetric
    {
        /// <summary>
        /// Gets and sets the property ClosedFindings. 
        /// <para>
        /// The number of closed findings of each severity on the specified date.
        /// </para>
        /// </summary>
        public FindingMetricsValuePerSeverity ClosedFindings { get; set; }

        /// <summary>
        /// Checks to see if the ClosedFindings property is set.
        /// </summary>
        internal bool IsSetClosedFindings() => this.ClosedFindings != null;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date from which the findings metrics were retrieved.
        /// </para>
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date.HasValue;

        /// <summary>
        /// Gets and sets the property MeanTimeToClose. 
        /// <para>
        /// The average time in days it takes to close findings of each severity as of a specified
        /// date.
        /// </para>
        /// </summary>
        public FindingMetricsValuePerSeverity MeanTimeToClose { get; set; }

        /// <summary>
        /// Checks to see if the MeanTimeToClose property is set.
        /// </summary>
        internal bool IsSetMeanTimeToClose() => this.MeanTimeToClose != null;

        /// <summary>
        /// Gets and sets the property NewFindings. 
        /// <para>
        /// The number of new findings of each severity on the specified date.
        /// </para>
        /// </summary>
        public FindingMetricsValuePerSeverity NewFindings { get; set; }

        /// <summary>
        /// Checks to see if the NewFindings property is set.
        /// </summary>
        internal bool IsSetNewFindings() => this.NewFindings != null;

        /// <summary>
        /// Gets and sets the property OpenFindings. 
        /// <para>
        /// The number of open findings of each severity as of the specified date.
        /// </para>
        /// </summary>
        public FindingMetricsValuePerSeverity OpenFindings { get; set; }

        /// <summary>
        /// Checks to see if the OpenFindings property is set.
        /// </summary>
        internal bool IsSetOpenFindings() => this.OpenFindings != null;
    }
}
