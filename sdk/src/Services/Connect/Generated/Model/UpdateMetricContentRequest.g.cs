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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMetricContent operation. Updates the calculation,
    /// unit, and/or trend indicator of an existing metric in the specified Connect Customer
    /// instance.
    /// </summary>
    public partial class UpdateMetricContentRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MetricCalculation. 
        /// <para>
        /// The updated calculation definition for the metric.
        /// </para>
        /// </summary>
        public MetricCalculation MetricCalculation { get; set; }

        /// <summary>
        /// Checks to see if the MetricCalculation property is set.
        /// </summary>
        internal bool IsSetMetricCalculation() => this.MetricCalculation != null;

        /// <summary>
        /// Gets and sets the property MetricId. 
        /// <para>
        /// The identifier of the metric to update. Adding the <c>$SAVED</c> qualifier will update
        /// the saved version of the metric. Adding <c>$LATEST</c> or omitting a qualifier will
        /// update the published version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 150)]
        public string MetricId { get; set; }

        /// <summary>
        /// Checks to see if the MetricId property is set.
        /// </summary>
        internal bool IsSetMetricId() => this.MetricId != null;

        /// <summary>
        /// Gets and sets the property PositiveTrendIndicator. 
        /// <para>
        /// How an increase in the metric value should be interpreted. Valid values: <c>POSITIVE</c>,
        /// <c>NEUTRAL</c>, <c>NEGATIVE</c>.
        /// </para>
        /// </summary>
        public TrendIndicator PositiveTrendIndicator { get; set; }

        /// <summary>
        /// Checks to see if the PositiveTrendIndicator property is set.
        /// </summary>
        internal bool IsSetPositiveTrendIndicator() => this.PositiveTrendIndicator != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The updated display unit for the metric.
        /// </para>
        /// </summary>
        public MetricUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
