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
    /// Attributes of Hyperledger Fabric for a network.
    /// </summary>
    public partial class NetworkFabricAttributes
    {
        private Edition _edition;
        private string _orderingServiceEndpoint;

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// The edition of Amazon Managed Blockchain that Hyperledger Fabric uses. For more information,
        /// see <a href="http://aws.amazon.com/managed-blockchain/pricing/">Amazon Managed Blockchain
        /// Pricing</a>.
        /// </para>
        /// </summary>
        public Edition Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }

        // Check to see if Edition property is set
        internal bool IsSetEdition()
        {
            return this._edition != null;
        }

        /// <summary>
        /// Gets and sets the property OrderingServiceEndpoint. 
        /// <para>
        /// The endpoint of the ordering service for the network.
        /// </para>
        /// </summary>
        public string OrderingServiceEndpoint
        {
            get { return this._orderingServiceEndpoint; }
            set { this._orderingServiceEndpoint = value; }
        }

        // Check to see if OrderingServiceEndpoint property is set
        internal bool IsSetOrderingServiceEndpoint()
        {
            return this._orderingServiceEndpoint != null;
        }

    }
}