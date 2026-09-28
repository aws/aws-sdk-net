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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Localized text strings for a specific language that customize the web portal.
    /// </summary>
    public partial class LocalizedBrandingStrings
    {
        /// <summary>
        /// Gets and sets the property BrowserTabTitle. 
        /// <para>
        /// The text displayed in the browser tab title.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 25)]
        public string BrowserTabTitle { get; set; }

        /// <summary>
        /// Checks to see if the BrowserTabTitle property is set.
        /// </summary>
        internal bool IsSetBrowserTabTitle() => this.BrowserTabTitle != null;

        /// <summary>
        /// Gets and sets the property ContactButtonText. 
        /// <para>
        /// The text displayed on the contact button. This field is optional and defaults to "Contact
        /// us".
        /// </para>
        /// </summary>
        [AWSProperty(Max = 30)]
        public string ContactButtonText { get; set; }

        /// <summary>
        /// Checks to see if the ContactButtonText property is set.
        /// </summary>
        internal bool IsSetContactButtonText() => this.ContactButtonText != null;

        /// <summary>
        /// Gets and sets the property ContactLink. 
        /// <para>
        /// A contact link URL. The URL must start with <c>https://</c> or <c>mailto:</c>. If
        /// not provided, the contact button will be hidden from the web portal screen.
        /// </para>
        /// </summary>
        public string ContactLink { get; set; }

        /// <summary>
        /// Checks to see if the ContactLink property is set.
        /// </summary>
        internal bool IsSetContactLink() => this.ContactLink != null;

        /// <summary>
        /// Gets and sets the property LoadingText. 
        /// <para>
        /// The text displayed during session loading. This field is optional and defaults to
        /// "Loading your session".
        /// </para>
        /// </summary>
        [AWSProperty(Max = 300)]
        public string LoadingText { get; set; }

        /// <summary>
        /// Checks to see if the LoadingText property is set.
        /// </summary>
        internal bool IsSetLoadingText() => this.LoadingText != null;

        /// <summary>
        /// Gets and sets the property LoginButtonText. 
        /// <para>
        /// The text displayed on the login button. This field is optional and defaults to "Sign
        /// In".
        /// </para>
        /// </summary>
        [AWSProperty(Max = 30)]
        public string LoginButtonText { get; set; }

        /// <summary>
        /// Checks to see if the LoginButtonText property is set.
        /// </summary>
        internal bool IsSetLoginButtonText() => this.LoginButtonText != null;

        /// <summary>
        /// Gets and sets the property LoginDescription. 
        /// <para>
        /// The description text for the login section. This field is optional and defaults to
        /// "Sign in to your session".
        /// </para>
        /// </summary>
        [AWSProperty(Max = 250)]
        public string LoginDescription { get; set; }

        /// <summary>
        /// Checks to see if the LoginDescription property is set.
        /// </summary>
        internal bool IsSetLoginDescription() => this.LoginDescription != null;

        /// <summary>
        /// Gets and sets the property LoginTitle. 
        /// <para>
        /// The title text for the login section. This field is optional and defaults to "Sign
        /// In".
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string LoginTitle { get; set; }

        /// <summary>
        /// Checks to see if the LoginTitle property is set.
        /// </summary>
        internal bool IsSetLoginTitle() => this.LoginTitle != null;

        /// <summary>
        /// Gets and sets the property WelcomeText. 
        /// <para>
        /// The welcome text displayed on the sign-in page.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 150)]
        public string WelcomeText { get; set; }

        /// <summary>
        /// Checks to see if the WelcomeText property is set.
        /// </summary>
        internal bool IsSetWelcomeText() => this.WelcomeText != null;
    }
}
