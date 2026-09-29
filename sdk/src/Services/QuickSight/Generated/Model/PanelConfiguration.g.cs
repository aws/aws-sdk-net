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
    /// A collection of options that configure how each panel displays in a small multiples
    /// chart.
    /// </summary>
    public partial class PanelConfiguration
    {
        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// Sets the background color for each panel.
        /// </para>
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundColor property is set.
        /// </summary>
        internal bool IsSetBackgroundColor() => this.BackgroundColor != null;

        /// <summary>
        /// Gets and sets the property BackgroundVisibility. 
        /// <para>
        /// Determines whether or not a background for each small multiples panel is rendered.
        /// </para>
        /// </summary>
        public Visibility BackgroundVisibility { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundVisibility property is set.
        /// </summary>
        internal bool IsSetBackgroundVisibility() => this.BackgroundVisibility != null;

        /// <summary>
        /// Gets and sets the property BorderColor. 
        /// <para>
        /// Sets the line color of panel borders.
        /// </para>
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Checks to see if the BorderColor property is set.
        /// </summary>
        internal bool IsSetBorderColor() => this.BorderColor != null;

        /// <summary>
        /// Gets and sets the property BorderStyle. 
        /// <para>
        /// Sets the line style of panel borders.
        /// </para>
        /// </summary>
        public PanelBorderStyle BorderStyle { get; set; }

        /// <summary>
        /// Checks to see if the BorderStyle property is set.
        /// </summary>
        internal bool IsSetBorderStyle() => this.BorderStyle != null;

        /// <summary>
        /// Gets and sets the property BorderThickness. 
        /// <para>
        /// Sets the line thickness of panel borders.
        /// </para>
        /// </summary>
        public string BorderThickness { get; set; }

        /// <summary>
        /// Checks to see if the BorderThickness property is set.
        /// </summary>
        internal bool IsSetBorderThickness() => this.BorderThickness != null;

        /// <summary>
        /// Gets and sets the property BorderVisibility. 
        /// <para>
        /// Determines whether or not each panel displays a border.
        /// </para>
        /// </summary>
        public Visibility BorderVisibility { get; set; }

        /// <summary>
        /// Checks to see if the BorderVisibility property is set.
        /// </summary>
        internal bool IsSetBorderVisibility() => this.BorderVisibility != null;

        /// <summary>
        /// Gets and sets the property GutterSpacing. 
        /// <para>
        /// Sets the total amount of negative space to display between sibling panels.
        /// </para>
        /// </summary>
        public string GutterSpacing { get; set; }

        /// <summary>
        /// Checks to see if the GutterSpacing property is set.
        /// </summary>
        internal bool IsSetGutterSpacing() => this.GutterSpacing != null;

        /// <summary>
        /// Gets and sets the property GutterVisibility. 
        /// <para>
        /// Determines whether or not negative space between sibling panels is rendered.
        /// </para>
        /// </summary>
        public Visibility GutterVisibility { get; set; }

        /// <summary>
        /// Checks to see if the GutterVisibility property is set.
        /// </summary>
        internal bool IsSetGutterVisibility() => this.GutterVisibility != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Configures the title display within each small multiples panel.
        /// </para>
        /// </summary>
        public PanelTitleOptions Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
