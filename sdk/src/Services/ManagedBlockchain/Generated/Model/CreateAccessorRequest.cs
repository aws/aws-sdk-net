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
    /// Container for the parameters to the CreateAccessor operation.
    /// Creates a new accessor for use with Managed Blockchain Ethereum nodes. An accessor
    /// contains information required for token based access to your Ethereum nodes.
    /// </summary>
    public partial class CreateAccessorRequest : AmazonManagedBlockchainRequest
    {
        private AccessorType _accessorType;
        private string _clientRequestToken;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AccessorType. 
        /// <para>
        /// The type of accessor.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently accessor type is restricted to <code>BILLING_TOKEN</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessorType AccessorType
        {
            get { return this._accessorType; }
            set { this._accessorType = value; }
        }

        // Check to see if AccessorType property is set
        internal bool IsSetAccessorType()
        {
            return this._accessorType != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// This is a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the operation. An idempotent operation completes no more than once. This identifier
        /// is required only if you make a service request directly using an HTTP client. It is
        /// generated automatically if you use an Amazon Web Services SDK or the Amazon Web Services
        /// CLI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the Accessor.
        /// </para>
        ///  
        /// <para>
        ///  Each tag consists of a key and an optional value. You can specify multiple key-value
        /// pairs in a single request with an overall maximum of 50 tags allowed per resource.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ethereum-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Ethereum Developer Guide</i>, or
        /// <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}