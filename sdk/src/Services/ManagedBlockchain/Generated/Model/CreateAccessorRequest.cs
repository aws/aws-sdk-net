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
    /// <important> 
    /// <para>
    /// The token based access feature is in preview release for Ethereum on Amazon Managed
    /// Blockchain and is subject to change. We recommend that you use this feature only with
    /// test scenarios, and not in production environments.
    /// </para>
    ///  </important> 
    /// <para>
    /// Creates a new accessor for use with Managed Blockchain Ethereum nodes. An accessor
    /// object is a container that has the information required for token based access to
    /// your Ethereum nodes.
    /// </para>
    /// </summary>
    public partial class CreateAccessorRequest : AmazonManagedBlockchainRequest
    {
        private AccessorType _accessorType;
        private string _clientRequestToken;

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

    }
}