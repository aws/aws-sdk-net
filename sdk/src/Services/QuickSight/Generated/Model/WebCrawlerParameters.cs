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
    /// The parameters for a web crawler data source.
    /// </summary>
    public partial class WebCrawlerParameters
    {
        private string _loginPageUrl;
        private string _passwordButtonXpath;
        private string _passwordFieldXpath;
        private string _usernameButtonXpath;
        private string _usernameFieldXpath;
        private WebCrawlerAuthType _webCrawlerAuthType;
        private string _webProxyHostName;
        private int? _webProxyPortNumber;

        /// <summary>
        /// Gets and sets the property LoginPageUrl. 
        /// <para>
        /// The URL of the login page for the web crawler to authenticate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string LoginPageUrl
        {
            get { return this._loginPageUrl; }
            set { this._loginPageUrl = value; }
        }

        // Check to see if LoginPageUrl property is set
        internal bool IsSetLoginPageUrl()
        {
            return this._loginPageUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PasswordButtonXpath. 
        /// <para>
        /// The XPath expression for locating the password submit button on the login page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PasswordButtonXpath
        {
            get { return this._passwordButtonXpath; }
            set { this._passwordButtonXpath = value; }
        }

        // Check to see if PasswordButtonXpath property is set
        internal bool IsSetPasswordButtonXpath()
        {
            return this._passwordButtonXpath != null;
        }

        /// <summary>
        /// Gets and sets the property PasswordFieldXpath. 
        /// <para>
        /// The XPath expression for locating the password field on the login page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PasswordFieldXpath
        {
            get { return this._passwordFieldXpath; }
            set { this._passwordFieldXpath = value; }
        }

        // Check to see if PasswordFieldXpath property is set
        internal bool IsSetPasswordFieldXpath()
        {
            return this._passwordFieldXpath != null;
        }

        /// <summary>
        /// Gets and sets the property UsernameButtonXpath. 
        /// <para>
        /// The XPath expression for locating the username submit button on the login page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string UsernameButtonXpath
        {
            get { return this._usernameButtonXpath; }
            set { this._usernameButtonXpath = value; }
        }

        // Check to see if UsernameButtonXpath property is set
        internal bool IsSetUsernameButtonXpath()
        {
            return this._usernameButtonXpath != null;
        }

        /// <summary>
        /// Gets and sets the property UsernameFieldXpath. 
        /// <para>
        /// The XPath expression for locating the username field on the login page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string UsernameFieldXpath
        {
            get { return this._usernameFieldXpath; }
            set { this._usernameFieldXpath = value; }
        }

        // Check to see if UsernameFieldXpath property is set
        internal bool IsSetUsernameFieldXpath()
        {
            return this._usernameFieldXpath != null;
        }

        /// <summary>
        /// Gets and sets the property WebCrawlerAuthType. 
        /// <para>
        /// The authentication type for the web crawler. The type can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NO_AUTH</c>: No authentication required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BASIC_AUTH</c>: Basic authentication using username and password.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAML</c>: SAML-based authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FORM</c>: Form-based authentication.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public WebCrawlerAuthType WebCrawlerAuthType
        {
            get { return this._webCrawlerAuthType; }
            set { this._webCrawlerAuthType = value; }
        }

        // Check to see if WebCrawlerAuthType property is set
        internal bool IsSetWebCrawlerAuthType()
        {
            return this._webCrawlerAuthType != null;
        }

        /// <summary>
        /// Gets and sets the property WebProxyHostName. 
        /// <para>
        /// The hostname of the web proxy server for the web crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string WebProxyHostName
        {
            get { return this._webProxyHostName; }
            set { this._webProxyHostName = value; }
        }

        // Check to see if WebProxyHostName property is set
        internal bool IsSetWebProxyHostName()
        {
            return this._webProxyHostName != null;
        }

        /// <summary>
        /// Gets and sets the property WebProxyPortNumber. 
        /// <para>
        /// The port number of the web proxy server for the web crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int? WebProxyPortNumber
        {
            get { return this._webProxyPortNumber; }
            set { this._webProxyPortNumber = value; }
        }

        // Check to see if WebProxyPortNumber property is set
        internal bool IsSetWebProxyPortNumber()
        {
            return this._webProxyPortNumber.HasValue; 
        }

    }
}