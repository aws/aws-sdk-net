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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The authorization code properties of a connection.
    /// </summary>
    public partial class AuthorizationCodeProperties
    {
        private string _authorizationCode;
        private string _redirectUri;

        /// <summary>
        /// Gets and sets the property AuthorizationCode. 
        /// <para>
        /// The authorization code of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string AuthorizationCode
        {
            get { return this._authorizationCode; }
            set { this._authorizationCode = value; }
        }

        // Check to see if AuthorizationCode property is set
        internal bool IsSetAuthorizationCode()
        {
            return this._authorizationCode != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectUri. 
        /// <para>
        /// The redirect URI of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string RedirectUri
        {
            get { return this._redirectUri; }
            set { this._redirectUri = value; }
        }

        // Check to see if RedirectUri property is set
        internal bool IsSetRedirectUri()
        {
            return this._redirectUri != null;
        }

    }
}