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
    /// The color field that defines a gradient or categorical style.
    /// </summary>
    public partial class GeospatialLayerColorField
    {
        /// <summary>
        /// Gets and sets the property ColorDimensionsFields. 
        /// <para>
        /// A list of color dimension fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<DimensionField> ColorDimensionsFields { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionField>() : null;

        /// <summary>
        /// Checks to see if the ColorDimensionsFields property is set.
        /// </summary>
        internal bool IsSetColorDimensionsFields() => this.ColorDimensionsFields != null && (this.ColorDimensionsFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ColorValuesFields. 
        /// <para>
        /// A list of color measure fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<MeasureField> ColorValuesFields { get; set; } = AWSConfigs.InitializeCollections ? new List<MeasureField>() : null;

        /// <summary>
        /// Checks to see if the ColorValuesFields property is set.
        /// </summary>
        internal bool IsSetColorValuesFields() => this.ColorValuesFields != null && (this.ColorValuesFields.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
