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

namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Configuration for threshold settings that determine when values near expected values
    /// should be ignored during anomaly detection.
    /// </summary>
    public partial class IgnoreNearExpected
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The absolute amount by which values can differ from expected values before being considered
        /// anomalous.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount.HasValue;

        /// <summary>
        /// Gets and sets the property Ratio. 
        /// <para>
        /// The ratio by which values can differ from expected values before being considered
        /// anomalous.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? Ratio { get; set; }

        /// <summary>
        /// Checks to see if the Ratio property is set.
        /// </summary>
        internal bool IsSetRatio() => this.Ratio.HasValue;
    }
}
