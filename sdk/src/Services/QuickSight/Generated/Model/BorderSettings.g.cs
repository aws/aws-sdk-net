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
    /// Border settings configuration for visual elements, including visibility, width, and
    /// color properties.
    /// </summary>
    public partial class BorderSettings
    {
        /// <summary>
        /// Gets and sets the property BorderColor. 
        /// <para>
        /// Color of the border.
        /// </para>
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Checks to see if the BorderColor property is set.
        /// </summary>
        internal bool IsSetBorderColor() => this.BorderColor != null;

        /// <summary>
        /// Gets and sets the property BorderVisibility. 
        /// <para>
        /// Visibility setting for the border.
        /// </para>
        /// </summary>
        public Visibility BorderVisibility { get; set; }

        /// <summary>
        /// Checks to see if the BorderVisibility property is set.
        /// </summary>
        internal bool IsSetBorderVisibility() => this.BorderVisibility != null;

        /// <summary>
        /// Gets and sets the property BorderWidth. 
        /// <para>
        /// Width of the border. Valid range is from 1px to 8px.
        /// </para>
        /// </summary>
        public string BorderWidth { get; set; }

        /// <summary>
        /// Checks to see if the BorderWidth property is set.
        /// </summary>
        internal bool IsSetBorderWidth() => this.BorderWidth != null;
    }
}
