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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Consent popup configuration displayed to users on login.
    /// </summary>
    public partial class ConsentPopupConfig
    {
        /// <summary>
        /// Gets and sets the property CloseButtonLabel. 
        /// <para>
        /// Label for the close button on the consent popup. Maximum 20 characters. Defaults to
        /// "Acknowledge" if not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 20)]
        public string CloseButtonLabel { get; set; }

        /// <summary>
        /// Checks to see if the CloseButtonLabel property is set.
        /// </summary>
        internal bool IsSetCloseButtonLabel() => this.CloseButtonLabel != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Body content of the consent popup in Markdown format. Maximum 5000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 5000)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the consent popup is enabled. When set to true, the popup is displayed to
        /// users on login.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// Header text displayed at the top of the consent popup. Maximum 100 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string Header { get; set; }

        /// <summary>
        /// Checks to see if the Header property is set.
        /// </summary>
        internal bool IsSetHeader() => this.Header != null;
    }
}
