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
    /// The definition for a categorical color.
    /// </summary>
    public partial class GeospatialCategoricalColor
    {
        private List<GeospatialCategoricalDataColor> _categoryDataColors = AWSConfigs.InitializeCollections ? new List<GeospatialCategoricalDataColor>() : null;
        private double? _defaultOpacity;
        private GeospatialNullDataSettings _nullDataSettings;
        private Visibility _nullDataVisibility;

        /// <summary>
        /// Gets and sets the property CategoryDataColors. 
        /// <para>
        /// A list of categorical data colors for each category.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GeospatialCategoricalDataColor> CategoryDataColors
        {
            get { return this._categoryDataColors; }
            set { this._categoryDataColors = value; }
        }

        // Check to see if CategoryDataColors property is set
        internal bool IsSetCategoryDataColors()
        {
            return this._categoryDataColors != null && (this._categoryDataColors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultOpacity. 
        /// <para>
        /// The default opacity of a categorical color.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double DefaultOpacity
        {
            get { return this._defaultOpacity.GetValueOrDefault(); }
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

    }
}