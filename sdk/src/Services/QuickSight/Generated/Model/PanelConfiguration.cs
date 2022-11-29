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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A collection of options that configure how each panel displays in a small multiples
    /// chart.
    /// </summary>
    public partial class PanelConfiguration
    {
        private string _backgroundColor;
        private Visibility _backgroundVisibility;
        private string _borderColor;
        private PanelBorderStyle _borderStyle;
        private string _borderThickness;
        private Visibility _borderVisibility;
        private string _gutterSpacing;
        private Visibility _gutterVisibility;
        private PanelTitleOptions _title;

        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// Sets the background color for each panel.
        /// </para>
        /// </summary>
        public string BackgroundColor
        {
            get { return this._backgroundColor; }
            set { this._backgroundColor = value; }
        }

        // Check to see if BackgroundColor property is set
        internal bool IsSetBackgroundColor()
        {
            return this._backgroundColor != null;
        }

        /// <summary>
        /// Gets and sets the property BackgroundVisibility. 
        /// <para>
        /// Determines whether or not a background for each small multiples panel is rendered.
        /// </para>
        /// </summary>
        public Visibility BackgroundVisibility
        {
            get { return this._backgroundVisibility; }
            set { this._backgroundVisibility = value; }
        }

        // Check to see if BackgroundVisibility property is set
        internal bool IsSetBackgroundVisibility()
        {
            return this._backgroundVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property BorderColor. 
        /// <para>
        /// Sets the line color of panel borders.
        /// </para>
        /// </summary>
        public string BorderColor
        {
            get { return this._borderColor; }
            set { this._borderColor = value; }
        }

        // Check to see if BorderColor property is set
        internal bool IsSetBorderColor()
        {
            return this._borderColor != null;
        }

        /// <summary>
        /// Gets and sets the property BorderStyle. 
        /// <para>
        /// Sets the line style of panel borders.
        /// </para>
        /// </summary>
        public PanelBorderStyle BorderStyle
        {
            get { return this._borderStyle; }
            set { this._borderStyle = value; }
        }

        // Check to see if BorderStyle property is set
        internal bool IsSetBorderStyle()
        {
            return this._borderStyle != null;
        }

        /// <summary>
        /// Gets and sets the property BorderThickness. 
        /// <para>
        /// Sets the line thickness of panel borders.
        /// </para>
        /// </summary>
        public string BorderThickness
        {
            get { return this._borderThickness; }
            set { this._borderThickness = value; }
        }

        // Check to see if BorderThickness property is set
        internal bool IsSetBorderThickness()
        {
            return this._borderThickness != null;
        }

        /// <summary>
        /// Gets and sets the property BorderVisibility. 
        /// <para>
        /// Determines whether or not each panel displays a border.
        /// </para>
        /// </summary>
        public Visibility BorderVisibility
        {
            get { return this._borderVisibility; }
            set { this._borderVisibility = value; }
        }

        // Check to see if BorderVisibility property is set
        internal bool IsSetBorderVisibility()
        {
            return this._borderVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property GutterSpacing. 
        /// <para>
        /// Sets the total amount of negative space to display between sibling panels.
        /// </para>
        /// </summary>
        public string GutterSpacing
        {
            get { return this._gutterSpacing; }
            set { this._gutterSpacing = value; }
        }

        // Check to see if GutterSpacing property is set
        internal bool IsSetGutterSpacing()
        {
            return this._gutterSpacing != null;
        }

        /// <summary>
        /// Gets and sets the property GutterVisibility. 
        /// <para>
        /// Determines whether or not negative space between sibling panels is rendered.
        /// </para>
        /// </summary>
        public Visibility GutterVisibility
        {
            get { return this._gutterVisibility; }
            set { this._gutterVisibility = value; }
        }

        // Check to see if GutterVisibility property is set
        internal bool IsSetGutterVisibility()
        {
            return this._gutterVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Configures the title display within each small multiples panel.
        /// </para>
        /// </summary>
        public PanelTitleOptions Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}