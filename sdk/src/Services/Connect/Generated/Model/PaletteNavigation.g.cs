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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains color configuration for navigation elements in a workspace theme.
    /// </summary>
    public partial class PaletteNavigation
    {
        /// <summary>
        /// Gets and sets the property Background. 
        /// <para>
        /// The background color of the navigation area.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string Background { get; set; }

        /// <summary>
        /// Checks to see if the Background property is set.
        /// </summary>
        internal bool IsSetBackground() => this.Background != null;

        /// <summary>
        /// Gets and sets the property InvertActionsColors. 
        /// <para>
        /// Whether to invert the colors of action buttons in the navigation area.
        /// </para>
        /// </summary>
        public bool? InvertActionsColors { get; set; }

        /// <summary>
        /// Checks to see if the InvertActionsColors property is set.
        /// </summary>
        internal bool IsSetInvertActionsColors() => this.InvertActionsColors.HasValue;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text color in the navigation area.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property TextActive. 
        /// <para>
        /// The text color for active navigation items.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string TextActive { get; set; }

        /// <summary>
        /// Checks to see if the TextActive property is set.
        /// </summary>
        internal bool IsSetTextActive() => this.TextActive != null;

        /// <summary>
        /// Gets and sets the property TextBackgroundActive. 
        /// <para>
        /// The background color for active navigation items.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string TextBackgroundActive { get; set; }

        /// <summary>
        /// Checks to see if the TextBackgroundActive property is set.
        /// </summary>
        internal bool IsSetTextBackgroundActive() => this.TextBackgroundActive != null;

        /// <summary>
        /// Gets and sets the property TextBackgroundHover. 
        /// <para>
        /// The background color when hovering over navigation text.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string TextBackgroundHover { get; set; }

        /// <summary>
        /// Checks to see if the TextBackgroundHover property is set.
        /// </summary>
        internal bool IsSetTextBackgroundHover() => this.TextBackgroundHover != null;

        /// <summary>
        /// Gets and sets the property TextHover. 
        /// <para>
        /// The text color when hovering over navigation items.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string TextHover { get; set; }

        /// <summary>
        /// Checks to see if the TextHover property is set.
        /// </summary>
        internal bool IsSetTextHover() => this.TextHover != null;
    }
}
