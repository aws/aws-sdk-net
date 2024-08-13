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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
    /// An object containing the results for the intent metric you requested.
    /// </summary>
    public partial class AnalyticsIntentMetricResult
    {
        private AnalyticsIntentMetricName _name;
        private AnalyticsMetricStatistic _statistic;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The metric that you requested. See <a href="https://docs.aws.amazon.com/lexv2/latest/dg/analytics-key-definitions.html">Key
        /// definitions</a> for more details about these metrics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Count</c> – The number of times the intent was invoked.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Success</c> – The number of times the intent succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failure</c> – The number of times the intent failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Switched</c> – The number of times there was a switch to a different intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Dropped</c> – The number of times the user dropped the intent.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnalyticsIntentMetricName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic that you requested to calculate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Sum</c> – The total count for the category you provide in <c>name</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Average</c> – The total count divided by the number of intents in the category
        /// you provide in <c>name</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Max</c> – The highest count in the category you provide in <c>name</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnalyticsMetricStatistic Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the summary statistic for the metric that you requested.
        /// </para>
        /// </summary>
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}