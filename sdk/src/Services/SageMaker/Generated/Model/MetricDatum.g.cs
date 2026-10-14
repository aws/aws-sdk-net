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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information about the metric for a candidate produced by an AutoML job.
    /// </summary>
    public partial class MetricDatum
    {
        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric.
        /// </para>
        /// </summary>
        public AutoMLMetricEnum MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Set. 
        /// <para>
        /// The dataset split from which the AutoML job produced the metric.
        /// </para>
        /// </summary>
        public MetricSetSource Set { get; set; }

        /// <summary>
        /// Checks to see if the Set property is set.
        /// </summary>
        internal bool IsSetSet() => this.Set != null;

        /// <summary>
        /// Gets and sets the property StandardMetricName. 
        /// <para>
        /// The name of the standard metric. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For definitions of the standard metrics, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-model-support-validation.html#autopilot-metrics">
        /// <c>Autopilot candidate metrics</c> </a>.
        /// </para>
        ///  </note>
        /// </summary>
        public AutoMLMetricExtendedEnum StandardMetricName { get; set; }

        /// <summary>
        /// Checks to see if the StandardMetricName property is set.
        /// </summary>
        internal bool IsSetStandardMetricName() => this.StandardMetricName != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the metric.
        /// </para>
        /// </summary>
        public float? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
