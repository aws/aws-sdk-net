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
    /// The username configuration type.
    /// </summary>
    public partial class UsernameConfigurationType
    {
        private bool? _caseSensitive;

        /// <summary>
        /// Gets and sets the property CaseSensitive. 
        /// <para>
        /// Specifies whether username case sensitivity will be applied for all users in the user
        /// pool through Cognito APIs.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>True</code> </b>: Enables case sensitivity for all username input. When
        /// this option is set to <code>True</code>, users must sign in using the exact capitalization
        /// of their given username. For example, “UserName”. This is the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>False</code> </b>: Enables case insensitivity for all username input. For
        /// example, when this option is set to <code>False</code>, users will be able to sign
        /// in using either "username" or "Username". This option also enables both <code>preferred_username</code>
        /// and <code>email</code> alias to be case insensitive, in addition to the <code>username</code>
        /// attribute.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool CaseSensitive
        {
            get { return this._caseSensitive.GetValueOrDefault(); }
            set { this._caseSensitive = value; }
        }

        // Check to see if CaseSensitive property is set
        internal bool IsSetCaseSensitive()
        {
            return this._caseSensitive.HasValue; 
        }

    }
}