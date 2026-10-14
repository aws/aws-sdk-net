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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// The metric to optimize during hyperparameter optimization (HPO).
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Personalize doesn't support configuring the <c>hpoObjective</c> at this time.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class HPOObjective
    {
        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property MetricRegex. 
        /// <para>
        /// A regular expression for finding the metric in the training job logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MetricRegex { get; set; }

        /// <summary>
        /// Checks to see if the MetricRegex property is set.
        /// </summary>
        internal bool IsSetMetricRegex() => this.MetricRegex != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the metric. Valid values are <c>Maximize</c> and <c>Minimize</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
