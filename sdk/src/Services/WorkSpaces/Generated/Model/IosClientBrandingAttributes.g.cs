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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// The client branding attributes for iOS device types. These attributes are displayed
    /// on the iOS client login screen only.
    /// 
    ///  <important> 
    /// <para>
    /// Client branding attributes are public facing. Ensure you do not include sensitive
    /// information.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class IosClientBrandingAttributes
    {
        /// <summary>
        /// Gets and sets the property ForgotPasswordLink. 
        /// <para>
        /// The forgotten password link. This is the web address that users can go to if they
        /// forget the password for their WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ForgotPasswordLink { get; set; }

        /// <summary>
        /// Checks to see if the ForgotPasswordLink property is set.
        /// </summary>
        internal bool IsSetForgotPasswordLink() => this.ForgotPasswordLink != null;

        /// <summary>
        /// Gets and sets the property LoginMessage. 
        /// <para>
        /// The login message. Specified as a key value pair, in which the key is a locale and
        /// the value is the localized message for that locale. The only key supported is <c>en_US</c>.
        /// The HTML tags supported include the following: <c>a, b, blockquote, br, cite, code,
        /// dd, dl, dt, div, em, i, li, ol, p, pre, q, small, span, strike, strong, sub, sup,
        /// u, ul</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> LoginMessage { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the LoginMessage property is set.
        /// </summary>
        internal bool IsSetLoginMessage() => this.LoginMessage != null && (this.LoginMessage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Logo2xUrl. 
        /// <para>
        /// The @2x version of the logo. This is the higher resolution display that offers a scale
        /// factor of 2.0 (or @2x). The only image format accepted is a binary data object that
        /// is converted from a <c>.png</c> file.
        /// </para>
        ///  <note> 
        /// <para>
        ///  For more information about iOS image size and resolution, see <a href="https://developer.apple.com/design/human-interface-guidelines/ios/icons-and-images/image-size-and-resolution/">Image
        /// Size and Resolution </a> in the <i>Apple Human Interface Guidelines</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Logo2xUrl { get; set; }

        /// <summary>
        /// Checks to see if the Logo2xUrl property is set.
        /// </summary>
        internal bool IsSetLogo2xUrl() => this.Logo2xUrl != null;

        /// <summary>
        /// Gets and sets the property Logo3xUrl. 
        /// <para>
        /// The @3x version of the logo. This is the higher resolution display that offers a scale
        /// factor of 3.0 (or @3x).The only image format accepted is a binary data object that
        /// is converted from a <c>.png</c> file.
        /// </para>
        ///  <note> 
        /// <para>
        ///  For more information about iOS image size and resolution, see <a href="https://developer.apple.com/design/human-interface-guidelines/ios/icons-and-images/image-size-and-resolution/">Image
        /// Size and Resolution </a> in the <i>Apple Human Interface Guidelines</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Logo3xUrl { get; set; }

        /// <summary>
        /// Checks to see if the Logo3xUrl property is set.
        /// </summary>
        internal bool IsSetLogo3xUrl() => this.Logo3xUrl != null;

        /// <summary>
        /// Gets and sets the property LogoUrl. 
        /// <para>
        /// The logo. This is the standard-resolution display that has a 1:1 pixel density (or
        /// @1x), where one pixel is equal to one point. The only image format accepted is a binary
        /// data object that is converted from a <c>.png</c> file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Checks to see if the LogoUrl property is set.
        /// </summary>
        internal bool IsSetLogoUrl() => this.LogoUrl != null;

        /// <summary>
        /// Gets and sets the property SupportEmail. 
        /// <para>
        /// The support email. The company's customer support email address.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// In each platform type, the <c>SupportEmail</c> and <c>SupportLink</c> parameters are
        /// mutually exclusive. You can specify one parameter for each platform type, but not
        /// both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The default email is <c>workspaces-feedback@amazon.com</c>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string SupportEmail { get; set; }

        /// <summary>
        /// Checks to see if the SupportEmail property is set.
        /// </summary>
        internal bool IsSetSupportEmail() => this.SupportEmail != null;

        /// <summary>
        /// Gets and sets the property SupportLink. 
        /// <para>
        /// The support link. The link for the company's customer support page for their WorkSpace.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// In each platform type, the <c>SupportEmail</c> and <c>SupportLink</c> parameters are
        /// mutually exclusive. You can specify one parameter for each platform type, but not
        /// both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The default support link is <c>workspaces-feedback@amazon.com</c>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string SupportLink { get; set; }

        /// <summary>
        /// Checks to see if the SupportLink property is set.
        /// </summary>
        internal bool IsSetSupportLink() => this.SupportLink != null;
    }
}
