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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
        private string _browserTabTitle;
        private string _contactButtonText;
        private string _contactLink;
        private string _loadingText;
        private string _loginButtonText;
        private string _loginDescription;
        private string _loginTitle;
        private string _welcomeText;

        /// <summary>
        /// Gets and sets the property BrowserTabTitle. 
        /// <para>
        /// The text displayed in the browser tab title.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public string BrowserTabTitle
        {
            get { return this._browserTabTitle; }
            set { this._browserTabTitle = value; }
        }

        // Check to see if BrowserTabTitle property is set
        internal bool IsSetBrowserTabTitle()
        {
            return this._browserTabTitle != null;
        }

        /// <summary>
        /// Gets and sets the property ContactButtonText. 
        /// <para>
        /// The text displayed on the contact button. This field is optional and defaults to "Contact
        /// us".
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public string ContactButtonText
        {
            get { return this._contactButtonText; }
            set { this._contactButtonText = value; }
        }

        // Check to see if ContactButtonText property is set
        internal bool IsSetContactButtonText()
        {
            return this._contactButtonText != null;
        }

        /// <summary>
        /// Gets and sets the property ContactLink. 
        /// <para>
        /// A contact link URL. The URL must start with <c>https://</c> or <c>mailto:</c>. If
        /// not provided, the contact button will be hidden from the web portal screen.
        /// </para>
        /// </summary>
        public string ContactLink
        {
            get { return this._contactLink; }
            set { this._contactLink = value; }
        }

        // Check to see if ContactLink property is set
        internal bool IsSetContactLink()
        {
            return this._contactLink != null;
        }

        /// <summary>
        /// Gets and sets the property LoadingText. 
        /// <para>
        /// The text displayed during session loading. This field is optional and defaults to
        /// "Loading your session".
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public string LoadingText
        {
            get { return this._loadingText; }
            set { this._loadingText = value; }
        }

        // Check to see if LoadingText property is set
        internal bool IsSetLoadingText()
        {
            return this._loadingText != null;
        }

        /// <summary>
        /// Gets and sets the property LoginButtonText. 
        /// <para>
        /// The text displayed on the login button. This field is optional and defaults to "Sign
        /// In".
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public string LoginButtonText
        {
            get { return this._loginButtonText; }
            set { this._loginButtonText = value; }
        }

        // Check to see if LoginButtonText property is set
        internal bool IsSetLoginButtonText()
        {
            return this._loginButtonText != null;
        }

        /// <summary>
        /// Gets and sets the property LoginDescription. 
        /// <para>
        /// The description text for the login section. This field is optional and defaults to
        /// "Sign in to your session".
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public string LoginDescription
        {
            get { return this._loginDescription; }
            set { this._loginDescription = value; }
        }

        // Check to see if LoginDescription property is set
        internal bool IsSetLoginDescription()
        {
            return this._loginDescription != null;
        }

        /// <summary>
        /// Gets and sets the property LoginTitle. 
        /// <para>
        /// The title text for the login section. This field is optional and defaults to "Sign
        /// In".
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string LoginTitle
        {
            get { return this._loginTitle; }
            set { this._loginTitle = value; }
        }

        // Check to see if LoginTitle property is set
        internal bool IsSetLoginTitle()
        {
            return this._loginTitle != null;
        }

        /// <summary>
        /// Gets and sets the property WelcomeText. 
        /// <para>
        /// The welcome text displayed on the sign-in page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=150)]
        public string WelcomeText
        {
            get { return this._welcomeText; }
            set { this._welcomeText = value; }
        }

        // Check to see if WelcomeText property is set
        internal bool IsSetWelcomeText()
        {
            return this._welcomeText != null;
        }

    }
}