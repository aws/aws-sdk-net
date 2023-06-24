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
    /// The options that determine the presentation of histogram bins.
    /// </summary>
    public partial class HistogramBinOptions
    {
        private BinCountOptions _binCount;
        private BinWidthOptions _binWidth;
        private HistogramBinType _selectedBinType;
        private double? _startValue;

        /// <summary>
        /// Gets and sets the property BinCount. 
        /// <para>
        /// The options that determine the bin count of a histogram.
        /// </para>
        /// </summary>
        public BinCountOptions BinCount
        {
            get { return this._binCount; }
            set { this._binCount = value; }
        }

        // Check to see if BinCount property is set
        internal bool IsSetBinCount()
        {
            return this._binCount != null;
        }

        /// <summary>
        /// Gets and sets the property BinWidth. 
        /// <para>
        /// The options that determine the bin width of a histogram.
        /// </para>
        /// </summary>
        public BinWidthOptions BinWidth
        {
            get { return this._binWidth; }
            set { this._binWidth = value; }
        }

        // Check to see if BinWidth property is set
        internal bool IsSetBinWidth()
        {
            return this._binWidth != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedBinType. 
        /// <para>
        /// The options that determine the selected bin type.
        /// </para>
        /// </summary>
        public HistogramBinType SelectedBinType
        {
            get { return this._selectedBinType; }
            set { this._selectedBinType = value; }
        }

        // Check to see if SelectedBinType property is set
        internal bool IsSetSelectedBinType()
        {
            return this._selectedBinType != null;
        }

        /// <summary>
        /// Gets and sets the property StartValue. 
        /// <para>
        /// The options that determine the bin start value.
        /// </para>
        /// </summary>
        public double StartValue
        {
            get { return this._startValue.GetValueOrDefault(); }
            set { this._startValue = value; }
        }

        // Check to see if StartValue property is set
        internal bool IsSetStartValue()
        {
            return this._startValue.HasValue; 
        }

    }
}