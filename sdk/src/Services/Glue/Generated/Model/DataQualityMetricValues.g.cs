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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Describes the data quality metric value according to the analysis of historical data.
    /// </summary>
    public partial class DataQualityMetricValues
    {
        /// <summary>
        /// Gets and sets the property ActualValue. 
        /// <para>
        /// The actual value of the data quality metric.
        /// </para>
        /// </summary>
        public double? ActualValue { get; set; }

        /// <summary>
        /// Checks to see if the ActualValue property is set.
        /// </summary>
        internal bool IsSetActualValue() => this.ActualValue.HasValue;

        /// <summary>
        /// Gets and sets the property ExpectedValue. 
        /// <para>
        /// The expected value of the data quality metric according to the analysis of historical
        /// data.
        /// </para>
        /// </summary>
        public double? ExpectedValue { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedValue property is set.
        /// </summary>
        internal bool IsSetExpectedValue() => this.ExpectedValue.HasValue;

        /// <summary>
        /// Gets and sets the property LowerLimit. 
        /// <para>
        /// The lower limit of the data quality metric value according to the analysis of historical
        /// data.
        /// </para>
        /// </summary>
        public double? LowerLimit { get; set; }

        /// <summary>
        /// Checks to see if the LowerLimit property is set.
        /// </summary>
        internal bool IsSetLowerLimit() => this.LowerLimit.HasValue;

        /// <summary>
        /// Gets and sets the property UpperLimit. 
        /// <para>
        /// The upper limit of the data quality metric value according to the analysis of historical
        /// data.
        /// </para>
        /// </summary>
        public double? UpperLimit { get; set; }

        /// <summary>
        /// Checks to see if the UpperLimit property is set.
        /// </summary>
        internal bool IsSetUpperLimit() => this.UpperLimit.HasValue;
    }
}
