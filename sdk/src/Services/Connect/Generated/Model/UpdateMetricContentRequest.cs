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
    /// Container for the parameters to the UpdateMetricContent operation.
    /// Updates the calculation, unit, and/or trend indicator of an existing metric in the
    /// specified Connect Customer instance.
    /// </summary>
    public partial class UpdateMetricContentRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private MetricCalculation _metricCalculation;
        private string _metricId;
        private TrendIndicator _positiveTrendIndicator;
        private MetricUnit _unit;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MetricCalculation. 
        /// <para>
        /// The updated calculation definition for the metric.
        /// </para>
        /// </summary>
        public MetricCalculation MetricCalculation
        {
            get { return this._metricCalculation; }
            set { this._metricCalculation = value; }
        }

        // Check to see if MetricCalculation property is set
        internal bool IsSetMetricCalculation()
        {
            return this._metricCalculation != null;
        }

        /// <summary>
        /// Gets and sets the property MetricId. 
        /// <para>
        /// The identifier of the metric to update. Adding the <c>$SAVED</c> qualifier will update
        /// the saved version of the metric. Adding <c>$LATEST</c> or omitting a qualifier will
        /// update the published version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
        public string MetricId
        {
            get { return this._metricId; }
            set { this._metricId = value; }
        }

        // Check to see if MetricId property is set
        internal bool IsSetMetricId()
        {
            return this._metricId != null;
        }

        /// <summary>
        /// Gets and sets the property PositiveTrendIndicator. 
        /// <para>
        /// How an increase in the metric value should be interpreted. Valid values: <c>POSITIVE</c>,
        /// <c>NEUTRAL</c>, <c>NEGATIVE</c>.
        /// </para>
        /// </summary>
        public TrendIndicator PositiveTrendIndicator
        {
            get { return this._positiveTrendIndicator; }
            set { this._positiveTrendIndicator = value; }
        }

        // Check to see if PositiveTrendIndicator property is set
        internal bool IsSetPositiveTrendIndicator()
        {
            return this._positiveTrendIndicator != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The updated display unit for the metric.
        /// </para>
        /// </summary>
        public MetricUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}