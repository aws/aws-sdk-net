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
    /// Represents a component metric referenced in a custom metric calculation formula.
    /// </summary>
    public partial class CalculationComponent
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias used to reference this component in the calculation expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property MetricFilters. 
        /// <para>
        /// The filters applied to the calculation component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<MetricFilter> MetricFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricFilter>() : null;

        /// <summary>
        /// Checks to see if the MetricFilters property is set.
        /// </summary>
        internal bool IsSetMetricFilters() => this.MetricFilters != null && (this.MetricFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricId. 
        /// <para>
        /// The ARN of an AWS-managed metric used in this calculation component. Mutually exclusive
        /// with <c>MetricName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 150)]
        public string MetricId { get; set; }

        /// <summary>
        /// Checks to see if the MetricId property is set.
        /// </summary>
        internal bool IsSetMetricId() => this.MetricId != null;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of an AWS-managed metric used in this calculation component (for example,
        /// <c>CONTACTS_HANDLED</c>). Mutually exclusive with <c>MetricId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;
    }
}
