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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The dynamic configuration of the reference line data configuration.
    /// </summary>
    public partial class ReferenceLineDynamicDataConfiguration
    {
        private NumericalAggregationFunction _calculation;
        private ColumnIdentifier _column;
        private AggregationFunction _measureAggregationFunction;

        /// <summary>
        /// Gets and sets the property Calculation. 
        /// <para>
        /// The calculation that is used in the dynamic data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NumericalAggregationFunction Calculation
        {
            get { return this._calculation; }
            set { this._calculation = value; }
        }

        // Check to see if Calculation property is set
        internal bool IsSetCalculation()
        {
            return this._calculation != null;
        }

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that the dynamic data targets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property MeasureAggregationFunction. 
        /// <para>
        /// The aggregation function that is used in the dynamic data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AggregationFunction MeasureAggregationFunction
        {
            get { return this._measureAggregationFunction; }
            set { this._measureAggregationFunction = value; }
        }

        // Check to see if MeasureAggregationFunction property is set
        internal bool IsSetMeasureAggregationFunction()
        {
            return this._measureAggregationFunction != null;
        }

    }
}