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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Details new user agents used either at the resource or account level.
    /// </summary>
    public partial class NewUserAgentDetail
    {
        private bool? _isNewForEntireAccount;
        private string _userAgent;

        /// <summary>
        /// Gets and sets the property IsNewForEntireAccount. 
        /// <para>
        /// Checks if the user agent is new for the entire account.
        /// </para>
        /// </summary>
        public bool? IsNewForEntireAccount
        {
            get { return this._isNewForEntireAccount; }
            set { this._isNewForEntireAccount = value; }
        }

        // Check to see if IsNewForEntireAccount property is set
        internal bool IsSetIsNewForEntireAccount()
        {
            return this._isNewForEntireAccount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// New user agent which accessed the resource.
        /// </para>
        /// </summary>
        public string UserAgent
        {
            get { return this._userAgent; }
            set { this._userAgent = value; }
        }

        // Check to see if UserAgent property is set
        internal bool IsSetUserAgent()
        {
            return this._userAgent != null;
        }

    }
}