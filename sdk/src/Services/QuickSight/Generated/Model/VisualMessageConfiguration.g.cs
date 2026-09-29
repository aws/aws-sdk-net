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
    /// The configuration for a customizable message displayed on a visual. Supports parameter
    /// substitution in text fields.
    /// </summary>
    public partial class VisualMessageConfiguration
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description text of the message that is displayed on the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DescriptionVisibility. 
        /// <para>
        /// Specifies whether the description of the message is displayed.
        /// </para>
        /// </summary>
        public Visibility DescriptionVisibility { get; set; }

        /// <summary>
        /// Checks to see if the DescriptionVisibility property is set.
        /// </summary>
        internal bool IsSetDescriptionVisibility() => this.DescriptionVisibility != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the custom message is displayed on the visual. When set to <c>true</c>,
        /// the custom message appears in place of the default message. When set to <c>false</c>
        /// or omitted, the default message is displayed.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property LinkText. 
        /// <para>
        /// The display text of the hyperlink that is shown in the message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string LinkText { get; set; }

        /// <summary>
        /// Checks to see if the LinkText property is set.
        /// </summary>
        internal bool IsSetLinkText() => this.LinkText != null;

        /// <summary>
        /// Gets and sets the property LinkUrl. 
        /// <para>
        /// The destination URL of the hyperlink that is shown in the message. Only valid <c>http</c>,
        /// <c>https</c>, and <c>mailto</c> URLs are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// Checks to see if the LinkUrl property is set.
        /// </summary>
        internal bool IsSetLinkUrl() => this.LinkUrl != null;

        /// <summary>
        /// Gets and sets the property LinkVisibility. 
        /// <para>
        /// Specifies whether the hyperlink in the message is displayed.
        /// </para>
        /// </summary>
        public Visibility LinkVisibility { get; set; }

        /// <summary>
        /// Checks to see if the LinkVisibility property is set.
        /// </summary>
        internal bool IsSetLinkVisibility() => this.LinkVisibility != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title text of the message that is displayed on the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property TitleVisibility. 
        /// <para>
        /// Specifies whether the title of the message is displayed.
        /// </para>
        /// </summary>
        public Visibility TitleVisibility { get; set; }

        /// <summary>
        /// Checks to see if the TitleVisibility property is set.
        /// </summary>
        internal bool IsSetTitleVisibility() => this.TitleVisibility != null;
    }
}
