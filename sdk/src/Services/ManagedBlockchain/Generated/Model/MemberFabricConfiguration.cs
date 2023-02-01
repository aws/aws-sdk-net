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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Configuration properties for Hyperledger Fabric for a member in a Managed Blockchain
    /// network using the Hyperledger Fabric framework.
    /// </summary>
    public partial class MemberFabricConfiguration
    {
        private string _adminPassword;
        private string _adminUsername;

        /// <summary>
        /// Gets and sets the property AdminPassword. 
        /// <para>
        /// The password for the member's initial administrative user. The <code>AdminPassword</code>
        /// must be at least eight characters long and no more than 32 characters. It must contain
        /// at least one uppercase letter, one lowercase letter, and one digit. It cannot have
        /// a single quotation mark (‘), a double quotation marks (“), a forward slash(/), a backward
        /// slash(\), @, or a space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=8, Max=32)]
        public string AdminPassword
        {
            get { return this._adminPassword; }
            set { this._adminPassword = value; }
        }

        // Check to see if AdminPassword property is set
        internal bool IsSetAdminPassword()
        {
            return this._adminPassword != null;
        }

        /// <summary>
        /// Gets and sets the property AdminUsername. 
        /// <para>
        /// The user name for the member's initial administrative user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public string AdminUsername
        {
            get { return this._adminUsername; }
            set { this._adminUsername = value; }
        }

        // Check to see if AdminUsername property is set
        internal bool IsSetAdminUsername()
        {
            return this._adminUsername != null;
        }

    }
}