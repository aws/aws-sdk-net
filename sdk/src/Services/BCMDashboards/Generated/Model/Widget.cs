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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
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
namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// A configurable visualization component within a dashboard that displays specific cost
    /// and usage metrics. Each widget can show data as charts or tables and includes settings
    /// for data querying, filtering, and visual presentation.
    /// </summary>
    public partial class Widget
    {
        private List<WidgetConfig> _configs = AWSConfigs.InitializeCollections ? new List<WidgetConfig>() : null;
        private string _description;
        private int? _height;
        private int? _horizontalOffset;
        private string _title;
        private int? _width;

        /// <summary>
        /// Gets and sets the property Configs. 
        /// <para>
        /// An array of configurations that define the data queries and display settings for the
        /// widget.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<WidgetConfig> Configs
        {
            get { return this._configs; }
            set { this._configs = value; }
        }

        // Check to see if Configs property is set
        internal bool IsSetConfigs()
        {
            return this._configs != null && (this._configs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the widget's purpose or the data it displays.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height of the widget in row spans. The dashboard layout consists of a grid system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=10)]
        public int? Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HorizontalOffset. 
        /// <para>
        /// Specifies the starting column position of the widget in the dashboard's grid layout.
        /// Used to control widget placement.
        /// </para>
        /// </summary>
        public int? HorizontalOffset
        {
            get { return this._horizontalOffset; }
            set { this._horizontalOffset = value; }
        }

        // Check to see if HorizontalOffset property is set
        internal bool IsSetHorizontalOffset()
        {
            return this._horizontalOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the widget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width of the widget in column spans. The dashboard layout consists of a grid system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=6)]
        public int? Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}