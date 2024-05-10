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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Denotes the user's authentication properties, such as whether it requires a password
    /// to authenticate. Used in output responses.
    /// </summary>
    public partial class AuthenticationMode
    {
        private List<string> _passwords = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private InputAuthenticationType _type;

        /// <summary>
        /// Gets and sets the property Passwords. 
        /// <para>
        /// The password(s) used for authentication
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Passwords
        {
            get { return this._passwords; }
            set { this._passwords = value; }
        }

        // Check to see if Passwords property is set
        internal bool IsSetPasswords()
        {
            return this._passwords != null && (this._passwords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates whether the user requires a password to authenticate. All newly-created
        /// users require a password.
        /// </para>
        /// </summary>
        public InputAuthenticationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}