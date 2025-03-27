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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the SetUICustomization operation.
    /// Configures UI branding settings for domains with the hosted UI (classic) branding
    /// version. Your user pool must have a domain. Configure a domain with .
    /// 
    ///  
    /// <para>
    /// Set the default configuration for all clients with a <c>ClientId</c> of <c>ALL</c>.
    /// When the <c>ClientId</c> value is an app client ID, the settings you pass in this
    /// request apply to that app client and override the default <c>ALL</c> configuration.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class SetUICustomizationRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _clientId;
        private string _css;
        private MemoryStream _imageFile;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client that you want to customize. To apply a default style to all
        /// app clients not configured with client-level branding, set this parameter value to
        /// <c>ALL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property CSS. 
        /// <para>
        /// A plaintext CSS file that contains the custom fields that you want to apply to your
        /// user pool or app client. To download a template, go to the Amazon Cognito console.
        /// Navigate to your user pool <i>App clients</i> tab, select <i>Login pages</i>, edit
        /// <i>Hosted UI (classic) style</i>, and select the link to <c>CSS template.css</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string CSS
        {
            get { return this._css; }
            set { this._css = value; }
        }

        // Check to see if CSS property is set
        internal bool IsSetCSS()
        {
            return this._css != null;
        }

        /// <summary>
        /// Gets and sets the property ImageFile. 
        /// <para>
        /// The image that you want to set as your login in the classic hosted UI, as a Base64-formatted
        /// binary object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public MemoryStream ImageFile
        {
            get { return this._imageFile; }
            set { this._imageFile = value; }
        }

        // Check to see if ImageFile property is set
        internal bool IsSetImageFile()
        {
            return this._imageFile != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to apply branding to the classic hosted UI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}