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
    /// An image that is located on a sheet.
    /// </summary>
    public partial class SheetImage
    {
        private List<ImageCustomAction> _actions = AWSConfigs.InitializeCollections ? new List<ImageCustomAction>() : null;
        private string _imageContentAltText;
        private ImageInteractionOptions _interactions;
        private SheetImageScalingConfiguration _scaling;
        private string _sheetImageId;
        private SheetImageSource _source;
        private SheetImageTooltipConfiguration _tooltip;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of custom actions that are configured for an image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ImageCustomAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageContentAltText. 
        /// <para>
        /// The alt text for the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ImageContentAltText
        {
            get { return this._imageContentAltText; }
            set { this._imageContentAltText = value; }
        }

        // Check to see if ImageContentAltText property is set
        internal bool IsSetImageContentAltText()
        {
            return this._imageContentAltText != null;
        }

        /// <summary>
        /// Gets and sets the property Interactions. 
        /// <para>
        /// The general image interactions setup for an image.
        /// </para>
        /// </summary>
        public ImageInteractionOptions Interactions
        {
            get { return this._interactions; }
            set { this._interactions = value; }
        }

        // Check to see if Interactions property is set
        internal bool IsSetInteractions()
        {
            return this._interactions != null;
        }

        /// <summary>
        /// Gets and sets the property Scaling. 
        /// <para>
        /// Determines how the image is scaled.
        /// </para>
        /// </summary>
        public SheetImageScalingConfiguration Scaling
        {
            get { return this._scaling; }
            set { this._scaling = value; }
        }

        // Check to see if Scaling property is set
        internal bool IsSetScaling()
        {
            return this._scaling != null;
        }

        /// <summary>
        /// Gets and sets the property SheetImageId. 
        /// <para>
        /// The ID of the sheet image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SheetImageId
        {
            get { return this._sheetImageId; }
            set { this._sheetImageId = value; }
        }

        // Check to see if SheetImageId property is set
        internal bool IsSetSheetImageId()
        {
            return this._sheetImageId != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SheetImageSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// The tooltip to be shown when hovering over the image.
        /// </para>
        /// </summary>
        public SheetImageTooltipConfiguration Tooltip
        {
            get { return this._tooltip; }
            set { this._tooltip = value; }
        }

        // Check to see if Tooltip property is set
        internal bool IsSetTooltip()
        {
            return this._tooltip != null;
        }

    }
}