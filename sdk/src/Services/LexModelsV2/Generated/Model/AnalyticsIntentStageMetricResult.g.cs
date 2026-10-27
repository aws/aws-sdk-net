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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// An object containing the results for an intent stage metric you requested.
    /// </summary>
    public partial class AnalyticsIntentStageMetricResult
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The metric that you requested.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Count</c> – The number of times the intent stage occurred.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Success</c> – The number of times the intent stage succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failure</c> – The number of times the intent stage failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Dropped</c> – The number of times the user dropped the intent stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Retry</c> – The number of times the bot tried to elicit a response from the user
        /// at this stage.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnalyticsIntentStageMetricName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The summary statistic that you requested to calculate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Sum</c> – The total count for the category you provide in <c>name</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Average</c> – The total count divided by the number of intent stages in the category
        /// you provide in <c>name</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Max</c> – The highest count in the category you provide in <c>name</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnalyticsMetricStatistic Statistic { get; set; }

        /// <summary>
        /// Checks to see if the Statistic property is set.
        /// </summary>
        internal bool IsSetStatistic() => this.Statistic != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the summary statistic for the metric that you requested.
        /// </para>
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
