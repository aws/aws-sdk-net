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
    /// Contains the metric and the summary statistic you want to calculate, and the order
    /// in which to sort the results, for the utterances across the user sessions with the
    /// bot.
    /// </summary>
    public partial class AnalyticsUtteranceMetric
    {
        private AnalyticsUtteranceMetricName _name;
        private AnalyticsSortOrder _order;
        private AnalyticsMetricStatistic _statistic;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The metric for which you want to get utterance summary statistics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Count</c> – The number of utterances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Missed</c> – The number of utterances that Amazon Lex failed to recognize.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Detected</c> – The number of utterances that Amazon Lex managed to detect.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UtteranceTimestamp</c> – The date and time of the utterance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalyticsUtteranceMetricName Name
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
        /// Gets and sets the property Order. 
        /// <para>
        /// Specifies whether to sort the results in ascending or descending order.
        /// </para>
        /// </summary>
        public AnalyticsSortOrder Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order != null;
        }

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The summary statistic to calculate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Sum</c> – The total count for the category you provide in <c>name</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Average</c> – The total count divided by the number of utterances in the category
        /// you provide in <c>name</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Max</c> – The highest count in the category you provide in <c>name</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}