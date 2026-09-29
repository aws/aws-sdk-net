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
    /// The display options for tile borders for visuals.
    /// </summary>
    public partial class BorderStyle
    {
        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// The option to add color for tile borders for visuals.
        /// </para>
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Checks to see if the Color property is set.
        /// </summary>
        internal bool IsSetColor() => this.Color != null;

        /// <summary>
        /// Gets and sets the property Show. 
        /// <para>
        /// The option to enable display of borders for visuals.
        /// </para>
        /// </summary>
        public bool? Show { get; set; }

        /// <summary>
        /// Checks to see if the Show property is set.
        /// </summary>
        internal bool IsSetShow() => this.Show.HasValue;

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The option to set the width of tile borders for visuals.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width != null;
    }
}
