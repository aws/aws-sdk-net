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
    /// The parameters for a web crawler data source.
    /// </summary>
    public partial class WebCrawlerParameters
    {
        /// <summary>
        /// Gets and sets the property LoginPageUrl. 
        /// <para>
        /// The URL of the login page for the web crawler to authenticate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string LoginPageUrl { get; set; }

        /// <summary>
        /// Checks to see if the LoginPageUrl property is set.
        /// </summary>
        internal bool IsSetLoginPageUrl() => this.LoginPageUrl != null;

        /// <summary>
        /// Gets and sets the property PasswordButtonXpath. 
        /// <para>
        /// The XPath expression for locating the password submit button on the login page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PasswordButtonXpath { get; set; }

        /// <summary>
        /// Checks to see if the PasswordButtonXpath property is set.
        /// </summary>
        internal bool IsSetPasswordButtonXpath() => this.PasswordButtonXpath != null;

        /// <summary>
        /// Gets and sets the property PasswordFieldXpath. 
        /// <para>
        /// The XPath expression for locating the password field on the login page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PasswordFieldXpath { get; set; }

        /// <summary>
        /// Checks to see if the PasswordFieldXpath property is set.
        /// </summary>
        internal bool IsSetPasswordFieldXpath() => this.PasswordFieldXpath != null;

        /// <summary>
        /// Gets and sets the property UsernameButtonXpath. 
        /// <para>
        /// The XPath expression for locating the username submit button on the login page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string UsernameButtonXpath { get; set; }

        /// <summary>
        /// Checks to see if the UsernameButtonXpath property is set.
        /// </summary>
        internal bool IsSetUsernameButtonXpath() => this.UsernameButtonXpath != null;

        /// <summary>
        /// Gets and sets the property UsernameFieldXpath. 
        /// <para>
        /// The XPath expression for locating the username field on the login page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string UsernameFieldXpath { get; set; }

        /// <summary>
        /// Checks to see if the UsernameFieldXpath property is set.
        /// </summary>
        internal bool IsSetUsernameFieldXpath() => this.UsernameFieldXpath != null;

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
        [AWSProperty(Required = true)]
        public WebCrawlerAuthType WebCrawlerAuthType { get; set; }

        /// <summary>
        /// Checks to see if the WebCrawlerAuthType property is set.
        /// </summary>
        internal bool IsSetWebCrawlerAuthType() => this.WebCrawlerAuthType != null;

        /// <summary>
        /// Gets and sets the property WebProxyHostName. 
        /// <para>
        /// The hostname of the web proxy server for the web crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string WebProxyHostName { get; set; }

        /// <summary>
        /// Checks to see if the WebProxyHostName property is set.
        /// </summary>
        internal bool IsSetWebProxyHostName() => this.WebProxyHostName != null;

        /// <summary>
        /// Gets and sets the property WebProxyPortNumber. 
        /// <para>
        /// The port number of the web proxy server for the web crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? WebProxyPortNumber { get; set; }

        /// <summary>
        /// Checks to see if the WebProxyPortNumber property is set.
        /// </summary>
        internal bool IsSetWebProxyPortNumber() => this.WebProxyPortNumber.HasValue;
    }
}
