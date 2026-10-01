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
    /// Display options related to tiles on a sheet.
    /// </summary>
    public partial class TileStyle
    {
        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// The background color of a tile.
        /// </para>
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundColor property is set.
        /// </summary>
        internal bool IsSetBackgroundColor() => this.BackgroundColor != null;

        /// <summary>
        /// Gets and sets the property Border. 
        /// <para>
        /// The border around a tile.
        /// </para>
        /// </summary>
        public BorderStyle Border { get; set; }

        /// <summary>
        /// Checks to see if the Border property is set.
        /// </summary>
        internal bool IsSetBorder() => this.Border != null;

        /// <summary>
        /// Gets and sets the property BorderRadius. 
        /// <para>
        /// The border radius of a tile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string BorderRadius { get; set; }

        /// <summary>
        /// Checks to see if the BorderRadius property is set.
        /// </summary>
        internal bool IsSetBorderRadius() => this.BorderRadius != null;

        /// <summary>
        /// Gets and sets the property Padding. 
        /// <para>
        /// The padding of a tile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Padding { get; set; }

        /// <summary>
        /// Checks to see if the Padding property is set.
        /// </summary>
        internal bool IsSetPadding() => this.Padding != null;
    }
}
