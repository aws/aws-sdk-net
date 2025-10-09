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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Read-only authentication configuration containing non-sensitive authentication details
    /// for action connectors.
    /// </summary>
    public partial class ReadAuthConfig
    {
        private ReadAuthenticationMetadata _authenticationMetadata;
        private ConnectionAuthType _authenticationType;

        /// <summary>
        /// Gets and sets the property AuthenticationMetadata. 
        /// <para>
        /// The authentication metadata containing configuration details specific to the authentication
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReadAuthenticationMetadata AuthenticationMetadata
        {
            get { return this._authenticationMetadata; }
            set { this._authenticationMetadata = value; }
        }

        // Check to see if AuthenticationMetadata property is set
        internal bool IsSetAuthenticationMetadata()
        {
            return this._authenticationMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The type of authentication being used (BASIC, API_KEY, OAUTH2_CLIENT_CREDENTIALS,
        /// or OAUTH2_AUTHORIZATION_CODE).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionAuthType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

    }
}