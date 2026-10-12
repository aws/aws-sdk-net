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

namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// A configurable visualization component within a dashboard that displays specific cost
    /// and usage metrics. Each widget can show data as charts or tables and includes settings
    /// for data querying, filtering, and visual presentation.
    /// </summary>
    public partial class Widget
    {
        /// <summary>
        /// Gets and sets the property Configs. 
        /// <para>
        /// An array of configurations that define the data queries and display settings for the
        /// widget.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<WidgetConfig> Configs { get; set; } = AWSConfigs.InitializeCollections ? new List<WidgetConfig>() : null;

        /// <summary>
        /// Checks to see if the Configs property is set.
        /// </summary>
        internal bool IsSetConfigs() => this.Configs != null && (this.Configs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the widget's purpose or the data it displays.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height of the widget in row spans. The dashboard layout consists of a grid system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 10)]
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property HorizontalOffset. 
        /// <para>
        /// Specifies the starting column position of the widget in the dashboard's grid layout.
        /// Used to control widget placement.
        /// </para>
        /// </summary>
        public int? HorizontalOffset { get; set; }

        /// <summary>
        /// Checks to see if the HorizontalOffset property is set.
        /// </summary>
        internal bool IsSetHorizontalOffset() => this.HorizontalOffset.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the widget.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the widget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 50)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width of the widget in column spans. The dashboard layout consists of a grid system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 6)]
        public int? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
