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
    /// The configuration of a user pool for username case sensitivity.
    /// </summary>
    public partial class UsernameConfigurationType
    {
        private bool? _caseSensitive;

        /// <summary>
        /// Gets and sets the property CaseSensitive. 
        /// <para>
        /// Specifies whether user name case sensitivity will be applied for all users in the
        /// user pool through Amazon Cognito APIs. For most use cases, set case sensitivity to
        /// <c>False</c> (case insensitive) as a best practice. When usernames and email addresses
        /// are case insensitive, users can sign in as the same user when they enter a different
        /// capitalization of their user name.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <dl> <dt>true</dt> <dd> 
        /// <para>
        /// Enables case sensitivity for all username input. When this option is set to <c>true</c>,
        /// users must sign in using the exact capitalization of their given username, such as
        /// “UserName”. This is the default value.
        /// </para>
        ///  </dd> <dt>false</dt> <dd> 
        /// <para>
        /// Enables case insensitivity for all username input. For example, when this option is
        /// set to <c>false</c>, users can sign in using <c>username</c>, <c>USERNAME</c>, or
        /// <c>UserName</c>. This option also enables both <c>preferred_username</c> and <c>email</c>
        /// alias to be case insensitive, in addition to the <c>username</c> attribute.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? CaseSensitive
        {
            get { return this._caseSensitive; }
            set { this._caseSensitive = value; }
        }

        // Check to see if CaseSensitive property is set
        internal bool IsSetCaseSensitive()
        {
            return this._caseSensitive.HasValue; 
        }

    }
}