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
    /// Details for OAuth 2.0 authorization code grant credentials.
    /// </summary>
    public partial class AuthorizationCodeGrantCredentialsDetails
    {
        private AuthorizationCodeGrantDetails _authorizationCodeGrantDetails;

        /// <summary>
        /// Gets and sets the property AuthorizationCodeGrantDetails. 
        /// <para>
        /// The authorization code grant configuration details.
        /// </para>
        /// </summary>
        public AuthorizationCodeGrantDetails AuthorizationCodeGrantDetails
        {
            get { return this._authorizationCodeGrantDetails; }
            set { this._authorizationCodeGrantDetails = value; }
        }

        // Check to see if AuthorizationCodeGrantDetails property is set
        internal bool IsSetAuthorizationCodeGrantDetails()
        {
            return this._authorizationCodeGrantDetails != null;
        }

    }
}