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
    /// An element within a free-form layout.
    /// </summary>
    public partial class FreeFormLayoutElement
    {
        private FreeFormLayoutElementBackgroundStyle _backgroundStyle;
        private FreeFormLayoutElementBorderStyle _borderStyle;
        private string _elementId;
        private LayoutElementType _elementType;
        private string _height;
        private LoadingAnimation _loadingAnimation;
        private List<SheetElementRenderingRule> _renderingRules = new List<SheetElementRenderingRule>();
        private FreeFormLayoutElementBorderStyle _selectedBorderStyle;
        private Visibility _visibility;
        private string _width;
        private string _xAxisLocation;
        private string _yAxisLocation;

        /// <summary>
        /// Gets and sets the property BackgroundStyle. 
        /// <para>
        /// The background style configuration of a free-form layout element.
        /// </para>
        /// </summary>
        public FreeFormLayoutElementBackgroundStyle BackgroundStyle
        {
            get { return this._backgroundStyle; }
            set { this._backgroundStyle = value; }
        }

        // Check to see if BackgroundStyle property is set
        internal bool IsSetBackgroundStyle()
        {
            return this._backgroundStyle != null;
        }

        /// <summary>
        /// Gets and sets the property BorderStyle. 
        /// <para>
        /// The border style configuration of a free-form layout element.
        /// </para>
        /// </summary>
        public FreeFormLayoutElementBorderStyle BorderStyle
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
        /// Gets and sets the property ElementId. 
        /// <para>
        /// A unique identifier for an element within a free-form layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ElementId
        {
            get { return this._elementId; }
            set { this._elementId = value; }
        }

        // Check to see if ElementId property is set
        internal bool IsSetElementId()
        {
            return this._elementId != null;
        }

        /// <summary>
        /// Gets and sets the property ElementType. 
        /// <para>
        /// The type of element.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LayoutElementType ElementType
        {
            get { return this._elementType; }
            set { this._elementType = value; }
        }

        // Check to see if ElementType property is set
        internal bool IsSetElementType()
        {
            return this._elementType != null;
        }

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height of an element within a free-form layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height != null;
        }

        /// <summary>
        /// Gets and sets the property LoadingAnimation. 
        /// <para>
        /// The loading animation configuration of a free-form layout element.
        /// </para>
        /// </summary>
        public LoadingAnimation LoadingAnimation
        {
            get { return this._loadingAnimation; }
            set { this._loadingAnimation = value; }
        }

        // Check to see if LoadingAnimation property is set
        internal bool IsSetLoadingAnimation()
        {
            return this._loadingAnimation != null;
        }

        /// <summary>
        /// Gets and sets the property RenderingRules. 
        /// <para>
        /// The rendering rules that determine when an element should be displayed within a free-form
        /// layout.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public List<SheetElementRenderingRule> RenderingRules
        {
            get { return this._renderingRules; }
            set { this._renderingRules = value; }
        }

        // Check to see if RenderingRules property is set
        internal bool IsSetRenderingRules()
        {
            return this._renderingRules != null && this._renderingRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SelectedBorderStyle. 
        /// <para>
        /// The border style configuration of a free-form layout element. This border style is
        /// used when the element is selected.
        /// </para>
        /// </summary>
        public FreeFormLayoutElementBorderStyle SelectedBorderStyle
        {
            get { return this._selectedBorderStyle; }
            set { this._selectedBorderStyle = value; }
        }

        // Check to see if SelectedBorderStyle property is set
        internal bool IsSetSelectedBorderStyle()
        {
            return this._selectedBorderStyle != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of an element within a free-form layout.
        /// </para>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width of an element within a free-form layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width != null;
        }

        /// <summary>
        /// Gets and sets the property XAxisLocation. 
        /// <para>
        /// The x-axis coordinate of the element.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string XAxisLocation
        {
            get { return this._xAxisLocation; }
            set { this._xAxisLocation = value; }
        }

        // Check to see if XAxisLocation property is set
        internal bool IsSetXAxisLocation()
        {
            return this._xAxisLocation != null;
        }

        /// <summary>
        /// Gets and sets the property YAxisLocation. 
        /// <para>
        /// The y-axis coordinate of the element.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string YAxisLocation
        {
            get { return this._yAxisLocation; }
            set { this._yAxisLocation = value; }
        }

        // Check to see if YAxisLocation property is set
        internal bool IsSetYAxisLocation()
        {
            return this._yAxisLocation != null;
        }

    }
}