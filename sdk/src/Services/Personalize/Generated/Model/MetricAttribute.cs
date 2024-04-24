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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Contains information on a metric that a metric attribution reports on. For more information,
    /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/measuring-recommendation-impact.html">Measuring
    /// impact of recommendations</a>.
    /// </summary>
    public partial class MetricAttribute
    {
        private string _eventType;
        private string _expression;
        private string _metricName;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The metric's event type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The attribute's expression. Available functions are <c>SUM()</c> or <c>SAMPLECOUNT()</c>.
        /// For SUM() functions, provide the dataset type (either Interactions or Items) and column
        /// to sum as a parameter. For example SUM(Items.PRICE).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric's name. The name helps you identify the metric in Amazon CloudWatch or
        /// Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

    }
}