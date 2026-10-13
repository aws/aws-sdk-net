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
    /// The model latency threshold.
    /// </summary>
    public partial class ModelLatencyThreshold
    {
        /// <summary>
        /// Gets and sets the property Percentile. 
        /// <para>
        /// The model latency percentile threshold. Acceptable values are <c>P95</c> and <c>P99</c>.
        /// For custom load tests, specify the value as <c>P95</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Percentile { get; set; }

        /// <summary>
        /// Checks to see if the Percentile property is set.
        /// </summary>
        internal bool IsSetPercentile() => this.Percentile != null;

        /// <summary>
        /// Gets and sets the property ValueInMilliseconds. 
        /// <para>
        /// The model latency percentile value in milliseconds.
        /// </para>
        /// </summary>
        public int? ValueInMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the ValueInMilliseconds property is set.
        /// </summary>
        internal bool IsSetValueInMilliseconds() => this.ValueInMilliseconds.HasValue;
    }
}
