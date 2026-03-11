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
    /// Container for the parameters to the UpdateManagedLoginBranding operation.
    /// Configures the branding settings for a user pool style. This operation is the programmatic
    /// option for the configuration of a style in the branding editor.
    /// 
    ///  
    /// <para>
    /// Provides values for UI customization in a <c>Settings</c> JSON object and image files
    /// in an <c>Assets</c> array.
    /// </para>
    ///  
    /// <para>
    ///  This operation has a 2-megabyte request-size limit and include the CSS settings and
    /// image assets for your app client. Your branding settings might exceed 2MB in size.
    /// Amazon Cognito doesn't require that you pass all parameters in one request and preserves
    /// existing style settings that you don't specify. If your request is larger than 2MB,
    /// separate it into multiple requests, each with a size smaller than the limit.
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
    public partial class UpdateManagedLoginBrandingRequest : AmazonCognitoIdentityProviderRequest
    {
        private List<AssetType> _assets = AWSConfigs.InitializeCollections ? new List<AssetType>() : null;
        private string _managedLoginBrandingId;
        private Amazon.Runtime.Documents.Document _settings;
        private bool? _useCognitoProvidedValues;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// An array of image files that you want to apply to roles like backgrounds, logos, and
        /// icons. Each object must also indicate whether it is for dark mode, light mode, or
        /// browser-adaptive mode.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public List<AssetType> Assets
        {
            get { return this._assets; }
            set { this._assets = value; }
        }

        // Check to see if Assets property is set
        internal bool IsSetAssets()
        {
            return this._assets != null && (this._assets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManagedLoginBrandingId. 
        /// <para>
        /// The ID of the managed login branding style that you want to update.
        /// </para>
        /// </summary>
        public string ManagedLoginBrandingId
        {
            get { return this._managedLoginBrandingId; }
            set { this._managedLoginBrandingId = value; }
        }

        // Check to see if ManagedLoginBrandingId property is set
        internal bool IsSetManagedLoginBrandingId()
        {
            return this._managedLoginBrandingId != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// A JSON file, encoded as a <c>Document</c> type, with the the settings that you want
        /// to apply to your style.
        /// </para>
        ///  
        /// <para>
        /// The following components are not currently implemented and reserved for future use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>signUp</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instructions</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sessionTimerDisplay</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>languageSelector</c> (for localization, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html#managed-login-localization">Managed
        /// login localization)</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Amazon.Runtime.Documents.Document Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return !this._settings.IsNull();
        }

        /// <summary>
        /// Gets and sets the property UseCognitoProvidedValues. 
        /// <para>
        /// When <c>true</c>, applies the default branding style options. This option reverts
        /// to default style options that are managed by Amazon Cognito. You can modify them later
        /// in the branding editor.
        /// </para>
        ///  
        /// <para>
        /// When you specify <c>true</c> for this option, you must also omit values for <c>Settings</c>
        /// and <c>Assets</c> in the request.
        /// </para>
        /// </summary>
        public bool? UseCognitoProvidedValues
        {
            get { return this._useCognitoProvidedValues; }
            set { this._useCognitoProvidedValues = value; }
        }

        // Check to see if UseCognitoProvidedValues property is set
        internal bool IsSetUseCognitoProvidedValues()
        {
            return this._useCognitoProvidedValues.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that contains the managed login branding style that you want
        /// to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
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