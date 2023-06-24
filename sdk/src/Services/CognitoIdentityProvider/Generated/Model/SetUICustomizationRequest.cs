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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the SetUICustomization operation.
    /// Sets the user interface (UI) customization information for a user pool's built-in
    /// app UI.
    /// 
    ///  
    /// <para>
    /// You can specify app UI customization settings for a single client (with a specific
    /// <code>clientId</code>) or for all clients (by setting the <code>clientId</code> to
    /// <code>ALL</code>). If you specify <code>ALL</code>, the default configuration is used
    /// for every client that has no previously set UI customization. If you specify UI customization
    /// settings for a particular client, it will no longer return to the <code>ALL</code>
    /// configuration.
    /// </para>
    ///  <note> 
    /// <para>
    /// To use this API, your user pool must have a domain associated with it. Otherwise,
    /// there is no place to host the app's pages, and the service will throw an error.
    /// </para>
    ///  </note>
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
        /// The client ID for the client app.
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
        /// The CSS values in the UI customization.
        /// </para>
        /// </summary>
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
        /// The uploaded logo image for the UI customization.
        /// </para>
        /// </summary>
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
        /// The user pool ID for the user pool.
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