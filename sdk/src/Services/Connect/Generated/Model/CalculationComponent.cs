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
    /// Represents a component metric referenced in a custom metric calculation formula.
    /// </summary>
    public partial class CalculationComponent
    {
        private string _alias;
        private List<MetricFilter> _metricFilters = AWSConfigs.InitializeCollections ? new List<MetricFilter>() : null;
        private string _metricId;
        private string _metricName;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias used to reference this component in the calculation expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property MetricFilters. 
        /// <para>
        /// The filters applied to the calculation component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<MetricFilter> MetricFilters
        {
            get { return this._metricFilters; }
            set { this._metricFilters = value; }
        }

        // Check to see if MetricFilters property is set
        internal bool IsSetMetricFilters()
        {
            return this._metricFilters != null && (this._metricFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricId. 
        /// <para>
        /// The ARN of an AWS-managed metric used in this calculation component. Mutually exclusive
        /// with <c>MetricName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
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
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of an AWS-managed metric used in this calculation component (for example,
        /// <c>CONTACTS_HANDLED</c>). Mutually exclusive with <c>MetricId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

    }
}