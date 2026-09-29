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
    /// The unaggregated field wells of a scatter plot.
    /// </summary>
    public partial class ScatterPlotUnaggregatedFieldWells
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category field well of a scatter plot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<DimensionField> Category { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionField>() : null;

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null && (this.Category.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label field well of a scatter plot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<DimensionField> Label { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionField>() : null;

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null && (this.Label.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size field well of a scatter plot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<MeasureField> Size { get; set; } = AWSConfigs.InitializeCollections ? new List<MeasureField>() : null;

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size != null && (this.Size.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property XAxis. 
        /// <para>
        /// The x-axis field well of a scatter plot.
        /// </para>
        ///  
        /// <para>
        /// The x-axis is a dimension field and cannot be aggregated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<DimensionField> XAxis { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionField>() : null;

        /// <summary>
        /// Checks to see if the XAxis property is set.
        /// </summary>
        internal bool IsSetXAxis() => this.XAxis != null && (this.XAxis.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property YAxis. 
        /// <para>
        /// The y-axis field well of a scatter plot.
        /// </para>
        ///  
        /// <para>
        /// The y-axis is a dimension field and cannot be aggregated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<DimensionField> YAxis { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionField>() : null;

        /// <summary>
        /// Checks to see if the YAxis property is set.
        /// </summary>
        internal bool IsSetYAxis() => this.YAxis != null && (this.YAxis.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
