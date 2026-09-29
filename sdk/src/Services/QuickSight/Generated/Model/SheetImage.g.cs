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
    /// An image that is located on a sheet.
    /// </summary>
    public partial class SheetImage
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of custom actions that are configured for an image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ImageCustomAction> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<ImageCustomAction>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImageContentAltText. 
        /// <para>
        /// The alt text for the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ImageContentAltText { get; set; }

        /// <summary>
        /// Checks to see if the ImageContentAltText property is set.
        /// </summary>
        internal bool IsSetImageContentAltText() => this.ImageContentAltText != null;

        /// <summary>
        /// Gets and sets the property Interactions. 
        /// <para>
        /// The general image interactions setup for an image.
        /// </para>
        /// </summary>
        public ImageInteractionOptions Interactions { get; set; }

        /// <summary>
        /// Checks to see if the Interactions property is set.
        /// </summary>
        internal bool IsSetInteractions() => this.Interactions != null;

        /// <summary>
        /// Gets and sets the property Scaling. 
        /// <para>
        /// Determines how the image is scaled.
        /// </para>
        /// </summary>
        public SheetImageScalingConfiguration Scaling { get; set; }

        /// <summary>
        /// Checks to see if the Scaling property is set.
        /// </summary>
        internal bool IsSetScaling() => this.Scaling != null;

        /// <summary>
        /// Gets and sets the property SheetImageId. 
        /// <para>
        /// The ID of the sheet image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string SheetImageId { get; set; }

        /// <summary>
        /// Checks to see if the SheetImageId property is set.
        /// </summary>
        internal bool IsSetSheetImageId() => this.SheetImageId != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SheetImageSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// The tooltip to be shown when hovering over the image.
        /// </para>
        /// </summary>
        public SheetImageTooltipConfiguration Tooltip { get; set; }

        /// <summary>
        /// Checks to see if the Tooltip property is set.
        /// </summary>
        internal bool IsSetTooltip() => this.Tooltip != null;
    }
}
