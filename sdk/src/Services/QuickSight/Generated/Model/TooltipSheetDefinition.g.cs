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
    /// A tooltip sheet is an object that contains a set of visuals that are used as a tooltip.
    /// Every analysis and dashboard must contain at least one non-tooltip sheet.
    /// </summary>
    public partial class TooltipSheetDefinition
    {
        /// <summary>
        /// Gets and sets the property Images. 
        /// <para>
        /// A list of images on a tooltip sheet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<SheetImage> Images { get; set; } = AWSConfigs.InitializeCollections ? new List<SheetImage>() : null;

        /// <summary>
        /// Checks to see if the Images property is set.
        /// </summary>
        internal bool IsSetImages() => this.Images != null && (this.Images.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Layouts. 
        /// <para>
        /// Layouts define how the components of a tooltip sheet are arranged.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/types-of-layout.html">Types
        /// of layout</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<Layout> Layouts { get; set; } = AWSConfigs.InitializeCollections ? new List<Layout>() : null;

        /// <summary>
        /// Checks to see if the Layouts property is set.
        /// </summary>
        internal bool IsSetLayouts() => this.Layouts != null && (this.Layouts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the tooltip sheet. This name is displayed on the sheet's tab in the Quick
        /// console.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SheetId. 
        /// <para>
        /// The unique identifier of a tooltip sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string SheetId { get; set; }

        /// <summary>
        /// Checks to see if the SheetId property is set.
        /// </summary>
        internal bool IsSetSheetId() => this.SheetId != null;

        /// <summary>
        /// Gets and sets the property TextBoxes. 
        /// <para>
        /// The text boxes that are on a tooltip sheet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<SheetTextBox> TextBoxes { get; set; } = AWSConfigs.InitializeCollections ? new List<SheetTextBox>() : null;

        /// <summary>
        /// Checks to see if the TextBoxes property is set.
        /// </summary>
        internal bool IsSetTextBoxes() => this.TextBoxes != null && (this.TextBoxes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Visuals. 
        /// <para>
        /// A list of the visuals that are on a tooltip sheet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Visual> Visuals { get; set; } = AWSConfigs.InitializeCollections ? new List<Visual>() : null;

        /// <summary>
        /// Checks to see if the Visuals property is set.
        /// </summary>
        internal bool IsSetVisuals() => this.Visuals != null && (this.Visuals.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
