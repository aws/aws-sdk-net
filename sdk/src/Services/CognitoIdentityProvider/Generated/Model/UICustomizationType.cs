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
    /// A container for the UI customization information for the hosted UI in a user pool.
    /// 
    ///  
    /// <para>
    /// This data type is a response parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPoolClient.html">GetUICustomization</a>.
    /// </para>
    /// </summary>
    public partial class UICustomizationType
    {
        private string _clientId;
        private DateTime? _creationDate;
        private string _css;
        private string _cssVersion;
        private string _imageUrl;
        private DateTime? _lastModifiedDate;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The app client ID for your UI customization. When this value isn't present, the customization
        /// applies to all user pool app clients that don't have client-level settings..
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
        /// Gets and sets the property CSS. 
        /// <para>
        /// The CSS values in the UI customization. To get a template with your UI customization
        /// options, make a <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_GetUiCustomization.html">GetUiCustomization</a>
        /// request.
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
        /// Gets and sets the property CSSVersion. 
        /// <para>
        /// The CSS version number.
        /// </para>
        /// </summary>
        public string CSSVersion
        {
            get { return this._cssVersion; }
            set { this._cssVersion = value; }
        }

        // Check to see if CSSVersion property is set
        internal bool IsSetCSSVersion()
        {
            return this._cssVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ImageUrl. 
        /// <para>
        /// A URL path to the hosted logo image of your UI customization.
        /// </para>
        /// </summary>
        public string ImageUrl
        {
            get { return this._imageUrl; }
            set { this._imageUrl = value; }
        }

        // Check to see if ImageUrl property is set
        internal bool IsSetImageUrl()
        {
            return this._imageUrl != null;
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
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool with hosted UI customizations.
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