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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// The client branding attributes to import for iOS device types. These attributes are
    /// displayed on the iOS client login screen.
    /// 
    ///  <important> 
    /// <para>
    /// Client branding attributes are public facing. Ensure you do not include sensitive
    /// information.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class IosImportClientBrandingAttributes
    {
        private string _forgotPasswordLink;
        private Dictionary<string, string> _loginMessage = new Dictionary<string, string>();
        private MemoryStream _logo;
        private MemoryStream _logo2x;
        private MemoryStream _logo3x;
        private string _supportEmail;
        private string _supportLink;

        /// <summary>
        /// Gets and sets the property ForgotPasswordLink. 
        /// <para>
        /// The forgotten password link. This is the web address that users can go to if they
        /// forget the password for their WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ForgotPasswordLink
        {
            get { return this._forgotPasswordLink; }
            set { this._forgotPasswordLink = value; }
        }

        // Check to see if ForgotPasswordLink property is set
        internal bool IsSetForgotPasswordLink()
        {
            return this._forgotPasswordLink != null;
        }

        /// <summary>
        /// Gets and sets the property LoginMessage. 
        /// <para>
        /// The login message. Specified as a key value pair, in which the key is a locale and
        /// the value is the localized message for that locale. The only key supported is <code>en_US</code>.
        /// 
        /// </para>
        /// </summary>
        public Dictionary<string, string> LoginMessage
        {
            get { return this._loginMessage; }
            set { this._loginMessage = value; }
        }

        // Check to see if LoginMessage property is set
        internal bool IsSetLoginMessage()
        {
            return this._loginMessage != null && this._loginMessage.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Logo. 
        /// <para>
        /// The logo. This is the link where users can download the logo image. This is the standard-resolution
        /// display that has a 1:1 pixel density (or @1x), where one pixel is equal to one point.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=447000)]
        public MemoryStream Logo
        {
            get { return this._logo; }
            set { this._logo = value; }
        }

        // Check to see if Logo property is set
        internal bool IsSetLogo()
        {
            return this._logo != null;
        }

        /// <summary>
        /// Gets and sets the property Logo2x. 
        /// <para>
        /// The @2x version of the logo. This is the higher resolution display that offers a scale
        /// factor of 2.0 (or @2x).
        /// </para>
        ///  <note> 
        /// <para>
        ///  For more information about iOS image size and resolution, see <a href="https://developer.apple.com/design/human-interface-guidelines/ios/icons-and-images/image-size-and-resolution/">Image
        /// Size and Resolution </a> in the <i>Apple Human Interface Guidelines</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1770000)]
        public MemoryStream Logo2x
        {
            get { return this._logo2x; }
            set { this._logo2x = value; }
        }

        // Check to see if Logo2x property is set
        internal bool IsSetLogo2x()
        {
            return this._logo2x != null;
        }

        /// <summary>
        /// Gets and sets the property Logo3x. 
        /// <para>
        /// The @3x version of the logo. This is the higher resolution display that offers a scale
        /// factor of 3.0 (or @3x).
        /// </para>
        ///  <note> 
        /// <para>
        ///  For more information about iOS image size and resolution, see <a href="https://developer.apple.com/design/human-interface-guidelines/ios/icons-and-images/image-size-and-resolution/">Image
        /// Size and Resolution </a> in the <i>Apple Human Interface Guidelines</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1770000)]
        public MemoryStream Logo3x
        {
            get { return this._logo3x; }
            set { this._logo3x = value; }
        }

        // Check to see if Logo3x property is set
        internal bool IsSetLogo3x()
        {
            return this._logo3x != null;
        }

        /// <summary>
        /// Gets and sets the property SupportEmail. 
        /// <para>
        /// The support email. The company's customer support email address.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// In each platform type, the <code>SupportEmail</code> and <code>SupportLink</code>
        /// parameters are mutually exclusive. You can specify one parameter for each platform
        /// type, but not both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The default email is <code>workspaces-feedback@amazon.com</code>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string SupportEmail
        {
            get { return this._supportEmail; }
            set { this._supportEmail = value; }
        }

        // Check to see if SupportEmail property is set
        internal bool IsSetSupportEmail()
        {
            return this._supportEmail != null;
        }

        /// <summary>
        /// Gets and sets the property SupportLink. 
        /// <para>
        /// The support link. The link for the company's customer support page for their WorkSpace.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// In each platform type, the <code>SupportEmail</code> and <code>SupportLink</code>
        /// parameters are mutually exclusive. You can specify one parameter for each platform
        /// type, but not both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The default support link is <code>workspaces-feedback@amazon.com</code>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string SupportLink
        {
            get { return this._supportLink; }
            set { this._supportLink = value; }
        }

        // Check to see if SupportLink property is set
        internal bool IsSetSupportLink()
        {
            return this._supportLink != null;
        }

    }
}