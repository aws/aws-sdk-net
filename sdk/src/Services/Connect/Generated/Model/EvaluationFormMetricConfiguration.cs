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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the metric configuration for an evaluation form question. Use this
    /// to associate a business outcome metric with a question.
    /// </summary>
    public partial class EvaluationFormMetricConfiguration
    {
        private string _metricName;
        private EvaluationFormMetricType _metricType;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SALE_SUCCESS</c> – Sale success.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CSAT</c> – Customer satisfaction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CHURN_PROPENSITY</c> – Churn propensity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SELF_SERVICE_SUCCESS</c> – Self-service success.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTIAL_SELF_SERVICE_SUCCESS</c> – Partial self-service success.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property MetricType. 
        /// <para>
        /// The type of metric. Currently, only <c>BUSINESS_OUTCOME</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationFormMetricType MetricType
        {
            get { return this._metricType; }
            set { this._metricType = value; }
        }

        // Check to see if MetricType property is set
        internal bool IsSetMetricType()
        {
            return this._metricType != null;
        }

    }
}