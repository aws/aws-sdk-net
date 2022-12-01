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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Information about an email address.
    /// </summary>
    public partial class EmailAddress
    {
        private string _email;
        private bool? _verified;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address.
        /// </para>
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property Verified. 
        /// <para>
        /// Whether the email address has been verified.
        /// </para>
        /// </summary>
        public bool Verified
        {
            get { return this._verified.GetValueOrDefault(); }
            set { this._verified = value; }
        }

        // Check to see if Verified property is set
        internal bool IsSetVerified()
        {
            return this._verified.HasValue; 
        }

    }
}