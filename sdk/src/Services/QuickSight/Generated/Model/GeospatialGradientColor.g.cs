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
    /// The definition for a gradient color.
    /// </summary>
    public partial class GeospatialGradientColor
    {
        /// <summary>
        /// Gets and sets the property DefaultOpacity. 
        /// <para>
        /// The default opacity for the gradient color.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? DefaultOpacity { get; set; }

        /// <summary>
        /// Checks to see if the DefaultOpacity property is set.
        /// </summary>
        internal bool IsSetDefaultOpacity() => this.DefaultOpacity.HasValue;

        /// <summary>
        /// Gets and sets the property NullDataSettings. 
        /// <para>
        /// The null data visualization settings.
        /// </para>
        /// </summary>
        public GeospatialNullDataSettings NullDataSettings { get; set; }

        /// <summary>
        /// Checks to see if the NullDataSettings property is set.
        /// </summary>
        internal bool IsSetNullDataSettings() => this.NullDataSettings != null;

        /// <summary>
        /// Gets and sets the property NullDataVisibility. 
        /// <para>
        /// The state of visibility for null data.
        /// </para>
        /// </summary>
        public Visibility NullDataVisibility { get; set; }

        /// <summary>
        /// Checks to see if the NullDataVisibility property is set.
        /// </summary>
        internal bool IsSetNullDataVisibility() => this.NullDataVisibility != null;

        /// <summary>
        /// Gets and sets the property StepColors. 
        /// <para>
        /// A list of gradient step colors for the gradient.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 3)]
        public List<GeospatialGradientStepColor> StepColors { get; set; } = AWSConfigs.InitializeCollections ? new List<GeospatialGradientStepColor>() : null;

        /// <summary>
        /// Checks to see if the StepColors property is set.
        /// </summary>
        internal bool IsSetStepColors() => this.StepColors != null && (this.StepColors.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
