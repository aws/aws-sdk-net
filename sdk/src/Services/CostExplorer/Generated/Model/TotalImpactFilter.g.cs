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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Filters cost anomalies based on the total impact.
    /// </summary>
    public partial class TotalImpactFilter
    {
        /// <summary>
        /// Gets and sets the property EndValue. 
        /// <para>
        /// The upper bound dollar value that's used in the filter. 
        /// </para>
        /// </summary>
        public double? EndValue { get; set; }

        /// <summary>
        /// Checks to see if the EndValue property is set.
        /// </summary>
        internal bool IsSetEndValue() => this.EndValue.HasValue;

        /// <summary>
        /// Gets and sets the property NumericOperator. 
        /// <para>
        /// The comparing value that's used in the filter. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NumericOperator NumericOperator { get; set; }

        /// <summary>
        /// Checks to see if the NumericOperator property is set.
        /// </summary>
        internal bool IsSetNumericOperator() => this.NumericOperator != null;

        /// <summary>
        /// Gets and sets the property StartValue. 
        /// <para>
        /// The lower bound dollar value that's used in the filter. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? StartValue { get; set; }

        /// <summary>
        /// Checks to see if the StartValue property is set.
        /// </summary>
        internal bool IsSetStartValue() => this.StartValue.HasValue;
    }
}
