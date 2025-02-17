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
    /// A managed login branding style that's assigned to a user pool app client.
    /// 
    ///  
    /// <para>
    /// This data type is a response parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateManagedLoginBranding.html">CreateManagedLoginBranding</a>,
    /// <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateManagedLoginBranding.html">UpdateManagedLoginBranding</a>,
    /// <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeManagedLoginBranding.html">DescribeManagedLoginBranding</a>,
    /// and <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeManagedLoginBrandingByClient.html">DescribeManagedLoginBrandingByClient</a>.
    /// </para>
    /// </summary>
    public partial class ManagedLoginBrandingType
    {
        private List<AssetType> _assets = AWSConfigs.InitializeCollections ? new List<AssetType>() : null;
        private DateTime? _creationDate;
        private DateTime? _lastModifiedDate;
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedLoginBrandingId. 
        /// <para>
        /// The ID of the managed login branding style.
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
        /// When true, applies the default branding style options. This option reverts to default
        /// style options that are managed by Amazon Cognito. You can modify them later in the
        /// branding designer.
        /// </para>
        ///  
        /// <para>
        /// When you specify <c>true</c> for this option, you must also omit values for <c>Settings</c>
        /// and <c>Assets</c> in the request.
        /// </para>
        /// </summary>
        public bool UseCognitoProvidedValues
        {
            get { return this._useCognitoProvidedValues.GetValueOrDefault(); }
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
        /// The user pool where the branding style is assigned.
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