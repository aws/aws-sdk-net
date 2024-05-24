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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
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
namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Contains credential information for an application.
    /// </summary>
    public partial class Credential
    {
        private ApiKeyCredential _apiKeyCredential;
        private Oauth2Credential _oauth2Credential;

        /// <summary>
        /// Gets and sets the property ApiKeyCredential. 
        /// <para>
        /// Contains API key credential information.
        /// </para>
        /// </summary>
        public ApiKeyCredential ApiKeyCredential
        {
            get { return this._apiKeyCredential; }
            set { this._apiKeyCredential = value; }
        }

        // Check to see if ApiKeyCredential property is set
        internal bool IsSetApiKeyCredential()
        {
            return this._apiKeyCredential != null;
        }

        /// <summary>
        /// Gets and sets the property Oauth2Credential. 
        /// <para>
        /// Contains OAuth2 client credential information.
        /// </para>
        /// </summary>
        public Oauth2Credential Oauth2Credential
        {
            get { return this._oauth2Credential; }
            set { this._oauth2Credential = value; }
        }

        // Check to see if Oauth2Credential property is set
        internal bool IsSetOauth2Credential()
        {
            return this._oauth2Credential != null;
        }

    }
}