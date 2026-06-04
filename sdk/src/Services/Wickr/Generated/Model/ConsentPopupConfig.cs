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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Consent popup configuration displayed to users on login.
    /// </summary>
    public partial class ConsentPopupConfig
    {
        private string _closeButtonLabel;
        private string _content;
        private bool? _enabled;
        private string _header;

        /// <summary>
        /// Gets and sets the property CloseButtonLabel. 
        /// <para>
        /// Label for the close button on the consent popup. Maximum 20 characters. Defaults to
        /// "Acknowledge" if not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public string CloseButtonLabel
        {
            get { return this._closeButtonLabel; }
            set { this._closeButtonLabel = value; }
        }

        // Check to see if CloseButtonLabel property is set
        internal bool IsSetCloseButtonLabel()
        {
            return this._closeButtonLabel != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Body content of the consent popup in Markdown format. Maximum 5000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5000)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the consent popup is enabled. When set to true, the popup is displayed to
        /// users on login.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Header. 
        /// <para>
        /// Header text displayed at the top of the consent popup. Maximum 100 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string Header
        {
            get { return this._header; }
            set { this._header = value; }
        }

        // Check to see if Header property is set
        internal bool IsSetHeader()
        {
            return this._header != null;
        }

    }
}