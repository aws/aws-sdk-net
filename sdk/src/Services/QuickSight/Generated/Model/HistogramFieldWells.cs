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
    /// The field well configuration of a histogram.
    /// </summary>
    public partial class HistogramFieldWells
    {
        private HistogramAggregatedFieldWells _histogramAggregatedFieldWells;

        /// <summary>
        /// Gets and sets the property HistogramAggregatedFieldWells. 
        /// <para>
        /// The field well configuration of a histogram.
        /// </para>
        /// </summary>
        public HistogramAggregatedFieldWells HistogramAggregatedFieldWells
        {
            get { return this._histogramAggregatedFieldWells; }
            set { this._histogramAggregatedFieldWells = value; }
        }

        // Check to see if HistogramAggregatedFieldWells property is set
        internal bool IsSetHistogramAggregatedFieldWells()
        {
            return this._histogramAggregatedFieldWells != null;
        }

    }
}