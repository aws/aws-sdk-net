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
    /// Configures the display properties of the given text.
    /// </summary>
    public partial class FontConfiguration
    {
        /// <summary>
        /// Gets and sets the property FontColor. 
        /// <para>
        /// Determines the color of the text.
        /// </para>
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// Checks to see if the FontColor property is set.
        /// </summary>
        internal bool IsSetFontColor() => this.FontColor != null;

        /// <summary>
        /// Gets and sets the property FontDecoration. 
        /// <para>
        /// Determines the appearance of decorative lines on the text.
        /// </para>
        /// </summary>
        public FontDecoration FontDecoration { get; set; }

        /// <summary>
        /// Checks to see if the FontDecoration property is set.
        /// </summary>
        internal bool IsSetFontDecoration() => this.FontDecoration != null;

        /// <summary>
        /// Gets and sets the property FontFamily. 
        /// <para>
        /// The font family that you want to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FontFamily { get; set; }

        /// <summary>
        /// Checks to see if the FontFamily property is set.
        /// </summary>
        internal bool IsSetFontFamily() => this.FontFamily != null;

        /// <summary>
        /// Gets and sets the property FontSize. 
        /// <para>
        /// The option that determines the text display size.
        /// </para>
        /// </summary>
        public FontSize FontSize { get; set; }

        /// <summary>
        /// Checks to see if the FontSize property is set.
        /// </summary>
        internal bool IsSetFontSize() => this.FontSize != null;

        /// <summary>
        /// Gets and sets the property FontStyle. 
        /// <para>
        /// Determines the text display face that is inherited by the given font family.
        /// </para>
        /// </summary>
        public FontStyle FontStyle { get; set; }

        /// <summary>
        /// Checks to see if the FontStyle property is set.
        /// </summary>
        internal bool IsSetFontStyle() => this.FontStyle != null;

        /// <summary>
        /// Gets and sets the property FontWeight. 
        /// <para>
        /// The option that determines the text display weight, or boldness.
        /// </para>
        /// </summary>
        public FontWeight FontWeight { get; set; }

        /// <summary>
        /// Checks to see if the FontWeight property is set.
        /// </summary>
        internal bool IsSetFontWeight() => this.FontWeight != null;
    }
}
