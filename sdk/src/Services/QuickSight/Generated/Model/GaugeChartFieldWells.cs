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
    /// The field well configuration of a <c>GaugeChartVisual</c>.
    /// </summary>
    public partial class GaugeChartFieldWells
    {
        private List<MeasureField> _targetValues = AWSConfigs.InitializeCollections ? new List<MeasureField>() : null;
        private List<MeasureField> _values = AWSConfigs.InitializeCollections ? new List<MeasureField>() : null;

        /// <summary>
        /// Gets and sets the property TargetValues. 
        /// <para>
        /// The target value field wells of a <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<MeasureField> TargetValues
        {
            get { return this._targetValues; }
            set { this._targetValues = value; }
        }

        // Check to see if TargetValues property is set
        internal bool IsSetTargetValues()
        {
            return this._targetValues != null && (this._targetValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value field wells of a <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<MeasureField> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}