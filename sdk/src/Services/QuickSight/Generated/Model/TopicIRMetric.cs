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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private List<Identifier> _calculatedFieldReferences = AWSConfigs.InitializeCollections ? new List<Identifier>() : null;
        private TopicIRComparisonMethod _comparisonMethod;
        private DisplayFormat _displayFormat;
        private DisplayFormatOptions _displayFormatOptions;
        private string _expression;
        private AggFunction _function;
        private Identifier _metricId;
        private NamedEntityRef _namedEntity;
        private List<Identifier> _operands = AWSConfigs.InitializeCollections ? new List<Identifier>() : null;

        /// <summary>
        /// Gets and sets the property CalculatedFieldReferences. 
        /// <para>
        /// The calculated field references for the <c>TopicIRMetric</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=250)]
        public List<Identifier> CalculatedFieldReferences
        {
            get { return this._calculatedFieldReferences; }
            set { this._calculatedFieldReferences = value; }
        }

        // Check to see if CalculatedFieldReferences property is set
        internal bool IsSetCalculatedFieldReferences()
        {
            return this._calculatedFieldReferences != null && (this._calculatedFieldReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComparisonMethod. 
        /// <para>
        /// The comparison method for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        public TopicIRComparisonMethod ComparisonMethod
        {
            get { return this._comparisonMethod; }
            set { this._comparisonMethod = value; }
        }

        // Check to see if ComparisonMethod property is set
        internal bool IsSetComparisonMethod()
        {
            return this._comparisonMethod != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayFormat. 
        /// <para>
        /// The display format for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        public DisplayFormat DisplayFormat
        {
            get { return this._displayFormat; }
            set { this._displayFormat = value; }
        }

        // Check to see if DisplayFormat property is set
        internal bool IsSetDisplayFormat()
        {
            return this._displayFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayFormatOptions.
        /// </summary>
        public DisplayFormatOptions DisplayFormatOptions
        {
            get { return this._displayFormatOptions; }
            set { this._displayFormatOptions = value; }
        }

        // Check to see if DisplayFormatOptions property is set
        internal bool IsSetDisplayFormatOptions()
        {
            return this._displayFormatOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// The function for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        public AggFunction Function
        {
            get { return this._function; }
            set { this._function = value; }
        }

        // Check to see if Function property is set
        internal bool IsSetFunction()
        {
            return this._function != null;
        }

        /// <summary>
        /// Gets and sets the property MetricId. 
        /// <para>
        /// The metric ID for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        public Identifier MetricId
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
        /// Gets and sets the property NamedEntity. 
        /// <para>
        /// The named entity for the <c>TopicIRMetric</c>.
        /// </para>
        /// </summary>
        public NamedEntityRef NamedEntity
        {
            get { return this._namedEntity; }
            set { this._namedEntity = value; }
        }

        // Check to see if NamedEntity property is set
        internal bool IsSetNamedEntity()
        {
            return this._namedEntity != null;
        }

        /// <summary>
        /// Gets and sets the property Operands. 
        /// <para>
        /// The operands for the <c>TopicIRMetric</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=25)]
        public List<Identifier> Operands
        {
            get { return this._operands; }
            set { this._operands = value; }
        }

        // Check to see if Operands property is set
        internal bool IsSetOperands()
        {
            return this._operands != null && (this._operands.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}