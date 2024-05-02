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
    /// Attributes relevant to a member for the blockchain framework that the Managed Blockchain
    /// network uses.
    /// </summary>
    public partial class MemberFrameworkAttributes
    {
        private MemberFabricAttributes _fabric;

        /// <summary>
        /// Gets and sets the property Fabric. 
        /// <para>
        /// Attributes of Hyperledger Fabric relevant to a member on a Managed Blockchain network
        /// that uses Hyperledger Fabric.
        /// </para>
        /// </summary>
        public MemberFabricAttributes Fabric
        {
            get { return this._fabric; }
            set { this._fabric = value; }
        }

        // Check to see if Fabric property is set
        internal bool IsSetFabric()
        {
            return this._fabric != null;
        }

    }
}