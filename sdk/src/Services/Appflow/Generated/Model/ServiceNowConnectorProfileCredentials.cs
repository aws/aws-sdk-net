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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile credentials required when using ServiceNow.
    /// </summary>
    public partial class ServiceNowConnectorProfileCredentials
    {
        private OAuth2Credentials _oAuth2Credentials;
        private string _password;
        private string _username;

        /// <summary>
        /// Gets and sets the property OAuth2Credentials. 
        /// <para>
        ///  The OAuth 2.0 credentials required to authenticate the user. 
        /// </para>
        /// </summary>
        public OAuth2Credentials OAuth2Credentials
        {
            get { return this._oAuth2Credentials; }
            set { this._oAuth2Credentials = value; }
        }

        // Check to see if OAuth2Credentials property is set
        internal bool IsSetOAuth2Credentials()
        {
            return this._oAuth2Credentials != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        ///  The password that corresponds to the user name. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=512)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        ///  The name of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}