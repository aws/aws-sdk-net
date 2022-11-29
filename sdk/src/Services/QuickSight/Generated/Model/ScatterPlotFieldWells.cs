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
    /// The field well configuration of a scatter plot.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class ScatterPlotFieldWells
    {
        private ScatterPlotCategoricallyAggregatedFieldWells _scatterPlotCategoricallyAggregatedFieldWells;
        private ScatterPlotUnaggregatedFieldWells _scatterPlotUnaggregatedFieldWells;

        /// <summary>
        /// Gets and sets the property ScatterPlotCategoricallyAggregatedFieldWells. 
        /// <para>
        /// The aggregated field wells of a scatter plot. Scatter plots that have a field in the
        /// category (group/color) field will have aggregated field wells. The x and y-axes of
        /// these scatter plots are aggregated by category.
        /// </para>
        /// </summary>
        public ScatterPlotCategoricallyAggregatedFieldWells ScatterPlotCategoricallyAggregatedFieldWells
        {
            get { return this._scatterPlotCategoricallyAggregatedFieldWells; }
            set { this._scatterPlotCategoricallyAggregatedFieldWells = value; }
        }

        // Check to see if ScatterPlotCategoricallyAggregatedFieldWells property is set
        internal bool IsSetScatterPlotCategoricallyAggregatedFieldWells()
        {
            return this._scatterPlotCategoricallyAggregatedFieldWells != null;
        }

        /// <summary>
        /// Gets and sets the property ScatterPlotUnaggregatedFieldWells. 
        /// <para>
        /// The unaggregated field wells of a scatter plot. Scatter plots without a category field
        /// well have unaggregated field wells. The x and y-axes of these scatter plots are unaggregated.
        /// </para>
        /// </summary>
        public ScatterPlotUnaggregatedFieldWells ScatterPlotUnaggregatedFieldWells
        {
            get { return this._scatterPlotUnaggregatedFieldWells; }
            set { this._scatterPlotUnaggregatedFieldWells = value; }
        }

        // Check to see if ScatterPlotUnaggregatedFieldWells property is set
        internal bool IsSetScatterPlotUnaggregatedFieldWells()
        {
            return this._scatterPlotUnaggregatedFieldWells != null;
        }

    }
}