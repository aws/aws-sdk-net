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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Attributes of Hyperledger Fabric for a member in a Managed Blockchain network using
    /// the Hyperledger Fabric framework.
    /// </summary>
    public partial class MemberFabricAttributes
    {
        private string _adminUsername;
        private string _caEndpoint;

        /// <summary>
        /// Gets and sets the property AdminUsername. 
        /// <para>
        /// The user name for the initial administrator user for the member.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
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

        /// <summary>
        /// Gets and sets the property CaEndpoint. 
        /// <para>
        /// The endpoint used to access the member's certificate authority.
        /// </para>
        /// </summary>
        public string CaEndpoint
        {
            get { return this._caEndpoint; }
            set { this._caEndpoint = value; }
        }

        // Check to see if CaEndpoint property is set
        internal bool IsSetCaEndpoint()
        {
            return this._caEndpoint != null;
        }

    }
}