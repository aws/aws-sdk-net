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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The definition for a <c>TopicIRMetric</c>.
    /// </summary>
    public partial class TopicIRMetric
    {
        /// <summary>
        /// Gets and sets the property CalculatedFieldReferences. 
        /// <para>
        /// The calculated field references for the <c>TopicIRMetric</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<Identifier> CalculatedFieldReferences { get; set; } = AWSConfigs.InitializeCollections ? new List<Identifier>() : null;

        /// <summary>
        /// Checks to see if the CalculatedFieldReferences property is set.
        /// </summary>
        internal bool IsSetCalculatedFieldReferences() => this.CalculatedFieldReferences != null && (this.CalculatedFieldReferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComparisonMethod. 
        /// <para>
        /// The comparison method for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        public TopicIRComparisonMethod ComparisonMethod { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonMethod property is set.
        /// </summary>
        internal bool IsSetComparisonMethod() => this.ComparisonMethod != null;

        /// <summary>
        /// Gets and sets the property DisplayFormat. 
        /// <para>
        /// The display format for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        public DisplayFormat DisplayFormat { get; set; }

        /// <summary>
        /// Checks to see if the DisplayFormat property is set.
        /// </summary>
        internal bool IsSetDisplayFormat() => this.DisplayFormat != null;

        /// <summary>
        /// Gets and sets the property DisplayFormatOptions.
        /// </summary>
        public DisplayFormatOptions DisplayFormatOptions { get; set; }

        /// <summary>
        /// Checks to see if the DisplayFormatOptions property is set.
        /// </summary>
        internal bool IsSetDisplayFormatOptions() => this.DisplayFormatOptions != null;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Expression { get; set; }

        /// <summary>
        /// Checks to see if the Expression property is set.
        /// </summary>
        internal bool IsSetExpression() => this.Expression != null;

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// The function for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        public AggFunction Function { get; set; }

        /// <summary>
        /// Checks to see if the Function property is set.
        /// </summary>
        internal bool IsSetFunction() => this.Function != null;

        /// <summary>
        /// Gets and sets the property MetricId. 
        /// <para>
        /// The metric ID for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        public Identifier MetricId { get; set; }

        /// <summary>
        /// Checks to see if the MetricId property is set.
        /// </summary>
        internal bool IsSetMetricId() => this.MetricId != null;

        /// <summary>
        /// Gets and sets the property NamedEntity. 
        /// <para>
        /// The named entity for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        public NamedEntityRef NamedEntity { get; set; }

        /// <summary>
        /// Checks to see if the NamedEntity property is set.
        /// </summary>
        internal bool IsSetNamedEntity() => this.NamedEntity != null;

        /// <summary>
        /// Gets and sets the property Operands. 
        /// <para>
        /// The operands for the <c>TopicIRMetric</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public List<Identifier> Operands { get; set; } = AWSConfigs.InitializeCollections ? new List<Identifier>() : null;

        /// <summary>
        /// Checks to see if the Operands property is set.
        /// </summary>
        internal bool IsSetOperands() => this.Operands != null && (this.Operands.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
