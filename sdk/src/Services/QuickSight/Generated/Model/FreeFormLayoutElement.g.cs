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
    /// An element within a free-form layout.
    /// </summary>
    public partial class FreeFormLayoutElement
    {
        /// <summary>
        /// Gets and sets the property BackgroundStyle. 
        /// <para>
        /// The background style configuration of a free-form layout element.
        /// </para>
        /// </summary>
        public FreeFormLayoutElementBackgroundStyle BackgroundStyle { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundStyle property is set.
        /// </summary>
        internal bool IsSetBackgroundStyle() => this.BackgroundStyle != null;

        /// <summary>
        /// Gets and sets the property BorderRadius. 
        /// <para>
        /// The border radius of a free-form layout element.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string BorderRadius { get; set; }

        /// <summary>
        /// Checks to see if the BorderRadius property is set.
        /// </summary>
        internal bool IsSetBorderRadius() => this.BorderRadius != null;

        /// <summary>
        /// Gets and sets the property BorderStyle. 
        /// <para>
        /// The border style configuration of a free-form layout element.
        /// </para>
        /// </summary>
        public FreeFormLayoutElementBorderStyle BorderStyle { get; set; }

        /// <summary>
        /// Checks to see if the BorderStyle property is set.
        /// </summary>
        internal bool IsSetBorderStyle() => this.BorderStyle != null;

        /// <summary>
        /// Gets and sets the property ElementId. 
        /// <para>
        /// A unique identifier for an element within a free-form layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ElementId { get; set; }

        /// <summary>
        /// Checks to see if the ElementId property is set.
        /// </summary>
        internal bool IsSetElementId() => this.ElementId != null;

        /// <summary>
        /// Gets and sets the property ElementType. 
        /// <para>
        /// The type of element.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LayoutElementType ElementType { get; set; }

        /// <summary>
        /// Checks to see if the ElementType property is set.
        /// </summary>
        internal bool IsSetElementType() => this.ElementType != null;

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height of an element within a free-form layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height != null;

        /// <summary>
        /// Gets and sets the property LoadingAnimation. 
        /// <para>
        /// The loading animation configuration of a free-form layout element.
        /// </para>
        /// </summary>
        public LoadingAnimation LoadingAnimation { get; set; }

        /// <summary>
        /// Checks to see if the LoadingAnimation property is set.
        /// </summary>
        internal bool IsSetLoadingAnimation() => this.LoadingAnimation != null;

        /// <summary>
        /// Gets and sets the property Padding. 
        /// <para>
        /// The padding of a free-form layout element.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Padding { get; set; }

        /// <summary>
        /// Checks to see if the Padding property is set.
        /// </summary>
        internal bool IsSetPadding() => this.Padding != null;

        /// <summary>
        /// Gets and sets the property RenderingRules. 
        /// <para>
        /// The rendering rules that determine when an element should be displayed within a free-form
        /// layout.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public List<SheetElementRenderingRule> RenderingRules { get; set; } = AWSConfigs.InitializeCollections ? new List<SheetElementRenderingRule>() : null;

        /// <summary>
        /// Checks to see if the RenderingRules property is set.
        /// </summary>
        internal bool IsSetRenderingRules() => this.RenderingRules != null && (this.RenderingRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SelectedBorderStyle. 
        /// <para>
        /// The border style configuration of a free-form layout element. This border style is
        /// used when the element is selected.
        /// </para>
        /// </summary>
        public FreeFormLayoutElementBorderStyle SelectedBorderStyle { get; set; }

        /// <summary>
        /// Checks to see if the SelectedBorderStyle property is set.
        /// </summary>
        internal bool IsSetSelectedBorderStyle() => this.SelectedBorderStyle != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of an element within a free-form layout.
        /// </para>
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width of an element within a free-form layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width != null;

        /// <summary>
        /// Gets and sets the property XAxisLocation. 
        /// <para>
        /// The x-axis coordinate of the element.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string XAxisLocation { get; set; }

        /// <summary>
        /// Checks to see if the XAxisLocation property is set.
        /// </summary>
        internal bool IsSetXAxisLocation() => this.XAxisLocation != null;

        /// <summary>
        /// Gets and sets the property YAxisLocation. 
        /// <para>
        /// The y-axis coordinate of the element.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string YAxisLocation { get; set; }

        /// <summary>
        /// Checks to see if the YAxisLocation property is set.
        /// </summary>
        internal bool IsSetYAxisLocation() => this.YAxisLocation != null;
    }
}
