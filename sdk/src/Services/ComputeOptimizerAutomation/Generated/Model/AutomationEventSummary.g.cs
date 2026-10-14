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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// A summary of automation events grouped by specified dimensions.
    /// </summary>
    public partial class AutomationEventSummary
    {
        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions used to group this summary, such as event status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SummaryDimension> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<SummaryDimension>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key identifier for this summary grouping.
        /// </para>
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period covered by this summary, with inclusive start time and exclusive end
        /// time.
        /// </para>
        /// </summary>
        public TimePeriod TimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the TimePeriod property is set.
        /// </summary>
        internal bool IsSetTimePeriod() => this.TimePeriod != null;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The aggregated totals for this summary, including event count and estimated savings.
        /// </para>
        /// </summary>
        public SummaryTotals Total { get; set; }

        /// <summary>
        /// Checks to see if the Total property is set.
        /// </summary>
        internal bool IsSetTotal() => this.Total != null;
    }
}
