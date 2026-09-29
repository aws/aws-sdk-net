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
    /// The border options for a table border.
    /// </summary>
    public partial class TableBorderOptions
    {
        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// The color of a table border.
        /// </para>
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Checks to see if the Color property is set.
        /// </summary>
        internal bool IsSetColor() => this.Color != null;

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        /// The style (none, solid) of a table border.
        /// </para>
        /// </summary>
        public TableBorderStyle Style { get; set; }

        /// <summary>
        /// Checks to see if the Style property is set.
        /// </summary>
        internal bool IsSetStyle() => this.Style != null;

        /// <summary>
        /// Gets and sets the property Thickness. 
        /// <para>
        /// The thickness of a table border.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public int? Thickness { get; set; }

        /// <summary>
        /// Checks to see if the Thickness property is set.
        /// </summary>
        internal bool IsSetThickness() => this.Thickness.HasValue;
    }
}
