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
    /// A collection of field wells for a plugin visual.
    /// </summary>
    public partial class PluginVisualFieldWell
    {
        private PluginVisualAxisName _axisName;
        private List<DimensionField> _dimensions = AWSConfigs.InitializeCollections ? new List<DimensionField>() : null;
        private List<MeasureField> _measures = AWSConfigs.InitializeCollections ? new List<MeasureField>() : null;
        private List<UnaggregatedField> _unaggregated = AWSConfigs.InitializeCollections ? new List<UnaggregatedField>() : null;

        /// <summary>
        /// Gets and sets the property AxisName. 
        /// <para>
        /// The semantic axis name for the field well.
        /// </para>
        /// </summary>
        public PluginVisualAxisName AxisName
        {
            get { return this._axisName; }
            set { this._axisName = value; }
        }

        // Check to see if AxisName property is set
        internal bool IsSetAxisName()
        {
            return this._axisName != null;
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// A list of dimensions for the field well.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<DimensionField> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Measures. 
        /// <para>
        /// A list of measures that exist in the field well.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<MeasureField> Measures
        {
            get { return this._measures; }
            set { this._measures = value; }
        }

        // Check to see if Measures property is set
        internal bool IsSetMeasures()
        {
            return this._measures != null && (this._measures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Unaggregated. 
        /// <para>
        /// A list of unaggregated fields that exist in the field well.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<UnaggregatedField> Unaggregated
        {
            get { return this._unaggregated; }
            set { this._unaggregated = value; }
        }

        // Check to see if Unaggregated property is set
        internal bool IsSetUnaggregated()
        {
            return this._unaggregated != null && (this._unaggregated.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}