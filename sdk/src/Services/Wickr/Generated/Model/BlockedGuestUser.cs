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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Represents a guest user who has been blocked from accessing a Wickr network.
    /// </summary>
    public partial class BlockedGuestUser
    {
        private string _admin;
        private string _modified;
        private string _username;
        private string _usernameHash;

        /// <summary>
        /// Gets and sets the property Admin. 
        /// <para>
        /// The username of the administrator who blocked this guest user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Admin
        {
            get { return this._admin; }
            set { this._admin = value; }
        }

        // Check to see if Admin property is set
        internal bool IsSetAdmin()
        {
            return this._admin != null;
        }

        /// <summary>
        /// Gets and sets the property Modified. 
        /// <para>
        /// The timestamp when the guest user was blocked or last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Modified
        {
            get { return this._modified; }
            set { this._modified = value; }
        }

        // Check to see if Modified property is set
        internal bool IsSetModified()
        {
            return this._modified != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the blocked guest user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property UsernameHash. 
        /// <para>
        /// The unique username hash identifier for the blocked guest user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UsernameHash
        {
            get { return this._usernameHash; }
            set { this._usernameHash = value; }
        }

        // Check to see if UsernameHash property is set
        internal bool IsSetUsernameHash()
        {
            return this._usernameHash != null;
        }

    }
}