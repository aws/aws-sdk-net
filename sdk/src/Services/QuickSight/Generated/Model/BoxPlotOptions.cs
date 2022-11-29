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
    /// The options of a box plot visual.
    /// </summary>
    public partial class BoxPlotOptions
    {
        private Visibility _allDataPointsVisibility;
        private Visibility _outlierVisibility;
        private BoxPlotStyleOptions _styleOptions;

        /// <summary>
        /// Gets and sets the property AllDataPointsVisibility. 
        /// <para>
        /// Determines the visibility of all data points of the box plot.
        /// </para>
        /// </summary>
        public Visibility AllDataPointsVisibility
        {
            get { return this._allDataPointsVisibility; }
            set { this._allDataPointsVisibility = value; }
        }

        // Check to see if AllDataPointsVisibility property is set
        internal bool IsSetAllDataPointsVisibility()
        {
            return this._allDataPointsVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property OutlierVisibility. 
        /// <para>
        /// Determines the visibility of the outlier in a box plot.
        /// </para>
        /// </summary>
        public Visibility OutlierVisibility
        {
            get { return this._outlierVisibility; }
            set { this._outlierVisibility = value; }
        }

        // Check to see if OutlierVisibility property is set
        internal bool IsSetOutlierVisibility()
        {
            return this._outlierVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property StyleOptions. 
        /// <para>
        /// The style options of the box plot.
        /// </para>
        /// </summary>
        public BoxPlotStyleOptions StyleOptions
        {
            get { return this._styleOptions; }
            set { this._styleOptions = value; }
        }

        // Check to see if StyleOptions property is set
        internal bool IsSetStyleOptions()
        {
            return this._styleOptions != null;
        }

    }
}