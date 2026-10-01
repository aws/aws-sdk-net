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
    /// A <i>sheet</i>, which is an object that contains a set of visuals that are viewed
    /// together on one page in Quick Sight. Every analysis and dashboard contains at least
    /// one sheet. Each sheet contains at least one visualization widget, for example a chart,
    /// pivot table, or narrative insight. Sheets can be associated with other components,
    /// such as controls, filters, and so on.
    /// </summary>
    public partial class Sheet
    {
        /// <summary>
        /// Gets and sets the property Images. 
        /// <para>
        /// A list of images on a sheet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<SheetImage> Images { get; set; } = AWSConfigs.InitializeCollections ? new List<SheetImage>() : null;

        /// <summary>
        /// Checks to see if the Images property is set.
        /// </summary>
        internal bool IsSetImages() => this.Images != null && (this.Images.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a sheet. This name is displayed on the sheet's tab in the Quick Sight
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
        /// The unique identifier associated with a sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SheetId { get; set; }

        /// <summary>
        /// Checks to see if the SheetId property is set.
        /// </summary>
        internal bool IsSetSheetId() => this.SheetId != null;
    }
}
