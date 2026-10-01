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
    /// The application theme.
    /// </summary>
    public partial class ApplicationTheme
    {
        /// <summary>
        /// Gets and sets the property BrandColorPalette. 
        /// <para>
        /// The color palette.
        /// </para>
        /// </summary>
        public BrandColorPalette BrandColorPalette { get; set; }

        /// <summary>
        /// Checks to see if the BrandColorPalette property is set.
        /// </summary>
        internal bool IsSetBrandColorPalette() => this.BrandColorPalette != null;

        /// <summary>
        /// Gets and sets the property BrandElementStyle. 
        /// <para>
        /// The element style.
        /// </para>
        /// </summary>
        public BrandElementStyle BrandElementStyle { get; set; }

        /// <summary>
        /// Checks to see if the BrandElementStyle property is set.
        /// </summary>
        internal bool IsSetBrandElementStyle() => this.BrandElementStyle != null;

        /// <summary>
        /// Gets and sets the property ContextualAccentPalette. 
        /// <para>
        /// The contextual accent palette.
        /// </para>
        /// </summary>
        public ContextualAccentPalette ContextualAccentPalette { get; set; }

        /// <summary>
        /// Checks to see if the ContextualAccentPalette property is set.
        /// </summary>
        internal bool IsSetContextualAccentPalette() => this.ContextualAccentPalette != null;
    }
}
