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
    /// The aggregated field wells of a combo chart.
    /// </summary>
    public partial class ComboChartAggregatedFieldWells
    {
        /// <summary>
        /// Gets and sets the property BarValues. 
        /// <para>
        /// The aggregated <c>BarValues</c> field well of a combo chart.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<MeasureField> BarValues { get; set; } = AWSConfigs.InitializeCollections ? new List<MeasureField>() : null;

        /// <summary>
        /// Checks to see if the BarValues property is set.
        /// </summary>
        internal bool IsSetBarValues() => this.BarValues != null && (this.BarValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The aggregated category field wells of a combo chart.
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
        /// Gets and sets the property Colors. 
        /// <para>
        /// The aggregated colors field well of a combo chart.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<DimensionField> Colors { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionField>() : null;

        /// <summary>
        /// Checks to see if the Colors property is set.
        /// </summary>
        internal bool IsSetColors() => this.Colors != null && (this.Colors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LineValues. 
        /// <para>
        /// The aggregated <c>LineValues</c> field well of a combo chart.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<MeasureField> LineValues { get; set; } = AWSConfigs.InitializeCollections ? new List<MeasureField>() : null;

        /// <summary>
        /// Checks to see if the LineValues property is set.
        /// </summary>
        internal bool IsSetLineValues() => this.LineValues != null && (this.LineValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
