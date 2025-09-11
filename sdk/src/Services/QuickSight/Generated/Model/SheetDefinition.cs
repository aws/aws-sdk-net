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
    /// A sheet is an object that contains a set of visuals that are viewed together on one
    /// page in a paginated report. Every analysis and dashboard must contain at least one
    /// sheet.
    /// </summary>
    public partial class SheetDefinition
    {
        private SheetContentType _contentType;
        private VisualCustomActionDefaults _customActionDefaults;
        private string _description;
        private List<FilterControl> _filterControls = AWSConfigs.InitializeCollections ? new List<FilterControl>() : null;
        private List<SheetImage> _images = AWSConfigs.InitializeCollections ? new List<SheetImage>() : null;
        private List<Layout> _layouts = AWSConfigs.InitializeCollections ? new List<Layout>() : null;
        private string _name;
        private List<ParameterControl> _parameterControls = AWSConfigs.InitializeCollections ? new List<ParameterControl>() : null;
        private List<SheetControlLayout> _sheetControlLayouts = AWSConfigs.InitializeCollections ? new List<SheetControlLayout>() : null;
        private string _sheetId;
        private List<SheetTextBox> _textBoxes = AWSConfigs.InitializeCollections ? new List<SheetTextBox>() : null;
        private string _title;
        private List<Visual> _visuals = AWSConfigs.InitializeCollections ? new List<Visual>() : null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The layout content type of the sheet. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PAGINATED</c>: Creates a sheet for a paginated report.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERACTIVE</c>: Creates a sheet for an interactive dashboard.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SheetContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property CustomActionDefaults. 
        /// <para>
        /// A list of visual custom actions for the sheet.
        /// </para>
        /// </summary>
        public VisualCustomActionDefaults CustomActionDefaults
        {
            get { return this._customActionDefaults; }
            set { this._customActionDefaults = value; }
        }

        // Check to see if CustomActionDefaults property is set
        internal bool IsSetCustomActionDefaults()
        {
            return this._customActionDefaults != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property FilterControls. 
        /// <para>
        /// The list of filter controls that are on a sheet.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/filter-controls.html">Adding
        /// filter controls to analysis sheets</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<FilterControl> FilterControls
        {
            get { return this._filterControls; }
            set { this._filterControls = value; }
        }

        // Check to see if FilterControls property is set
        internal bool IsSetFilterControls()
        {
            return this._filterControls != null && (this._filterControls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Images. 
        /// <para>
        /// A list of images on a sheet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<SheetImage> Images
        {
            get { return this._images; }
            set { this._images = value; }
        }

        // Check to see if Images property is set
        internal bool IsSetImages()
        {
            return this._images != null && (this._images.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Layouts. 
        /// <para>
        /// Layouts define how the components of a sheet are arranged.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/types-of-layout.html">Types
        /// of layout</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<Layout> Layouts
        {
            get { return this._layouts; }
            set { this._layouts = value; }
        }

        // Check to see if Layouts property is set
        internal bool IsSetLayouts()
        {
            return this._layouts != null && (this._layouts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the sheet. This name is displayed on the sheet's tab in the QuickSight
        /// console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterControls. 
        /// <para>
        /// The list of parameter controls that are on a sheet.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/parameters-controls.html">Using
        /// a Control with a Parameter in Amazon QuickSight</a> in the <i>Amazon QuickSight User
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<ParameterControl> ParameterControls
        {
            get { return this._parameterControls; }
            set { this._parameterControls = value; }
        }

        // Check to see if ParameterControls property is set
        internal bool IsSetParameterControls()
        {
            return this._parameterControls != null && (this._parameterControls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SheetControlLayouts. 
        /// <para>
        /// The control layouts of the sheet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<SheetControlLayout> SheetControlLayouts
        {
            get { return this._sheetControlLayouts; }
            set { this._sheetControlLayouts = value; }
        }

        // Check to see if SheetControlLayouts property is set
        internal bool IsSetSheetControlLayouts()
        {
            return this._sheetControlLayouts != null && (this._sheetControlLayouts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SheetId. 
        /// <para>
        /// The unique identifier of a sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SheetId
        {
            get { return this._sheetId; }
            set { this._sheetId = value; }
        }

        // Check to see if SheetId property is set
        internal bool IsSetSheetId()
        {
            return this._sheetId != null;
        }

        /// <summary>
        /// Gets and sets the property TextBoxes. 
        /// <para>
        /// The text boxes that are on a sheet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<SheetTextBox> TextBoxes
        {
            get { return this._textBoxes; }
            set { this._textBoxes = value; }
        }

        // Check to see if TextBoxes property is set
        internal bool IsSetTextBoxes()
        {
            return this._textBoxes != null && (this._textBoxes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Visuals. 
        /// <para>
        /// A list of the visuals that are on a sheet. Visual placement is determined by the layout
        /// of the sheet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Visual> Visuals
        {
            get { return this._visuals; }
            set { this._visuals = value; }
        }

        // Check to see if Visuals property is set
        internal bool IsSetVisuals()
        {
            return this._visuals != null && (this._visuals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}