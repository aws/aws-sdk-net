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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private string _description;
        private Visibility _descriptionVisibility;
        private bool? _enabled;
        private string _linkText;
        private string _linkUrl;
        private Visibility _linkVisibility;
        private string _title;
        private Visibility _titleVisibility;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description text of the message that is displayed on the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Max=120)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DescriptionVisibility. 
        /// <para>
        /// Specifies whether the description of the message is displayed.
        /// </para>
        /// </summary>
        public Visibility DescriptionVisibility
        {
            get { return this._descriptionVisibility; }
            set { this._descriptionVisibility = value; }
        }

        // Check to see if DescriptionVisibility property is set
        internal bool IsSetDescriptionVisibility()
        {
            return this._descriptionVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the custom message is displayed on the visual. When set to <c>true</c>,
        /// the custom message appears in place of the default message. When set to <c>false</c>
        /// or omitted, the default message is displayed.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LinkText. 
        /// <para>
        /// The display text of the hyperlink that is shown in the message.
        /// </para>
        /// </summary>
        [AWSProperty(Max=120)]
        public string LinkText
        {
            get { return this._linkText; }
            set { this._linkText = value; }
        }

        // Check to see if LinkText property is set
        internal bool IsSetLinkText()
        {
            return this._linkText != null;
        }

        /// <summary>
        /// Gets and sets the property LinkUrl. 
        /// <para>
        /// The destination URL of the hyperlink that is shown in the message. Only valid <c>http</c>,
        /// <c>https</c>, and <c>mailto</c> URLs are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Max=120)]
        public string LinkUrl
        {
            get { return this._linkUrl; }
            set { this._linkUrl = value; }
        }

        // Check to see if LinkUrl property is set
        internal bool IsSetLinkUrl()
        {
            return this._linkUrl != null;
        }

        /// <summary>
        /// Gets and sets the property LinkVisibility. 
        /// <para>
        /// Specifies whether the hyperlink in the message is displayed.
        /// </para>
        /// </summary>
        public Visibility LinkVisibility
        {
            get { return this._linkVisibility; }
            set { this._linkVisibility = value; }
        }

        // Check to see if LinkVisibility property is set
        internal bool IsSetLinkVisibility()
        {
            return this._linkVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title text of the message that is displayed on the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Max=120)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property TitleVisibility. 
        /// <para>
        /// Specifies whether the title of the message is displayed.
        /// </para>
        /// </summary>
        public Visibility TitleVisibility
        {
            get { return this._titleVisibility; }
            set { this._titleVisibility = value; }
        }

        // Check to see if TitleVisibility property is set
        internal bool IsSetTitleVisibility()
        {
            return this._titleVisibility != null;
        }

    }
}