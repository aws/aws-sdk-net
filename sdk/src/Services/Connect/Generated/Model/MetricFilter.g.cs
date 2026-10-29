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
    /// A filter condition applied to a metric component in a calculation. Filters restrict
    /// the data included in the metric computation.
    /// </summary>
    public partial class MetricFilter
    {
        /// <summary>
        /// Gets and sets the property BooleanCondition. 
        /// <para>
        /// A boolean comparison condition.
        /// </para>
        /// </summary>
        public MetricFilterBooleanCondition BooleanCondition { get; set; }

        /// <summary>
        /// Checks to see if the BooleanCondition property is set.
        /// </summary>
        internal bool IsSetBooleanCondition() => this.BooleanCondition != null;

        /// <summary>
        /// Gets and sets the property MetricFilterKey. 
        /// <para>
        /// The key identifying the field to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string MetricFilterKey { get; set; }

        /// <summary>
        /// Checks to see if the MetricFilterKey property is set.
        /// </summary>
        internal bool IsSetMetricFilterKey() => this.MetricFilterKey != null;

        /// <summary>
        /// Gets and sets the property Negate. 
        /// <para>
        /// Specifies whether the filter condition is negated. When set to <c>true</c>, the filter
        /// excludes matching data instead of including it.
        /// </para>
        /// </summary>
        public bool? Negate { get; set; }

        /// <summary>
        /// Checks to see if the Negate property is set.
        /// </summary>
        internal bool IsSetNegate() => this.Negate.HasValue;

        /// <summary>
        /// Gets and sets the property NumberCondition. 
        /// <para>
        /// A numeric comparison condition.
        /// </para>
        /// </summary>
        public MetricFilterNumberCondition NumberCondition { get; set; }

        /// <summary>
        /// Checks to see if the NumberCondition property is set.
        /// </summary>
        internal bool IsSetNumberCondition() => this.NumberCondition != null;

        /// <summary>
        /// Gets and sets the property StringCondition. 
        /// <para>
        /// A string comparison condition.
        /// </para>
        /// </summary>
        public MetricFilterStringCondition StringCondition { get; set; }

        /// <summary>
        /// Checks to see if the StringCondition property is set.
        /// </summary>
        internal bool IsSetStringCondition() => this.StringCondition != null;
    }
}
