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
    /// The definition for a gradient color.
    /// </summary>
    public partial class GeospatialGradientColor
    {
        private double? _defaultOpacity;
        private GeospatialNullDataSettings _nullDataSettings;
        private Visibility _nullDataVisibility;
        private List<GeospatialGradientStepColor> _stepColors = AWSConfigs.InitializeCollections ? new List<GeospatialGradientStepColor>() : null;

        /// <summary>
        /// Gets and sets the property DefaultOpacity. 
        /// <para>
        /// The default opacity for the gradient color.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? DefaultOpacity
        {
            get { return this._defaultOpacity; }
            set { this._defaultOpacity = value; }
        }

        // Check to see if DefaultOpacity property is set
        internal bool IsSetDefaultOpacity()
        {
            return this._defaultOpacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NullDataSettings. 
        /// <para>
        /// The null data visualization settings.
        /// </para>
        /// </summary>
        public GeospatialNullDataSettings NullDataSettings
        {
            get { return this._nullDataSettings; }
            set { this._nullDataSettings = value; }
        }

        // Check to see if NullDataSettings property is set
        internal bool IsSetNullDataSettings()
        {
            return this._nullDataSettings != null;
        }

        /// <summary>
        /// Gets and sets the property NullDataVisibility. 
        /// <para>
        /// The state of visibility for null data.
        /// </para>
        /// </summary>
        public Visibility NullDataVisibility
        {
            get { return this._nullDataVisibility; }
            set { this._nullDataVisibility = value; }
        }

        // Check to see if NullDataVisibility property is set
        internal bool IsSetNullDataVisibility()
        {
            return this._nullDataVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property StepColors. 
        /// <para>
        /// A list of gradient step colors for the gradient.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=3)]
        public List<GeospatialGradientStepColor> StepColors
        {
            get { return this._stepColors; }
            set { this._stepColors = value; }
        }

        // Check to see if StepColors property is set
        internal bool IsSetStepColors()
        {
            return this._stepColors != null && (this._stepColors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}