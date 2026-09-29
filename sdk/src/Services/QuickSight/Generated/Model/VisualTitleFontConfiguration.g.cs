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
    /// Configures the display properties of the visual title.
    /// </summary>
    public partial class VisualTitleFontConfiguration
    {
        /// <summary>
        /// Gets and sets the property FontConfiguration.
        /// </summary>
        public FontConfiguration FontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FontConfiguration property is set.
        /// </summary>
        internal bool IsSetFontConfiguration() => this.FontConfiguration != null;

        /// <summary>
        /// Gets and sets the property TextAlignment. 
        /// <para>
        /// Determines the alignment of visual title.
        /// </para>
        /// </summary>
        public HorizontalTextAlignment TextAlignment { get; set; }

        /// <summary>
        /// Checks to see if the TextAlignment property is set.
        /// </summary>
        internal bool IsSetTextAlignment() => this.TextAlignment != null;

        /// <summary>
        /// Gets and sets the property TextTransform. 
        /// <para>
        /// Determines the text transformation of visual title.
        /// </para>
        /// </summary>
        public TextTransform TextTransform { get; set; }

        /// <summary>
        /// Checks to see if the TextTransform property is set.
        /// </summary>
        internal bool IsSetTextTransform() => this.TextTransform != null;
    }
}
