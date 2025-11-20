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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCoreNetworkPrefixListAssociation operation.
    /// Creates an association between a core network and a prefix list for routing control.
    /// </summary>
    public partial class CreateCoreNetworkPrefixListAssociationRequest : AmazonNetworkManagerRequest
    {
        private string _clientToken;
        private string _coreNetworkId;
        private string _prefixListAlias;
        private string _prefixListArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of the core network to associate with the prefix list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string CoreNetworkId
        {
            get { return this._coreNetworkId; }
            set { this._coreNetworkId = value; }
        }

        // Check to see if CoreNetworkId property is set
        internal bool IsSetCoreNetworkId()
        {
            return this._coreNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListAlias. 
        /// <para>
        /// An optional alias for the prefix list association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string PrefixListAlias
        {
            get { return this._prefixListAlias; }
            set { this._prefixListAlias = value; }
        }

        // Check to see if PrefixListAlias property is set
        internal bool IsSetPrefixListAlias()
        {
            return this._prefixListAlias != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListArn. 
        /// <para>
        /// The ARN of the prefix list to associate with the core network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=500)]
        public string PrefixListArn
        {
            get { return this._prefixListArn; }
            set { this._prefixListArn = value; }
        }

        // Check to see if PrefixListArn property is set
        internal bool IsSetPrefixListArn()
        {
            return this._prefixListArn != null;
        }

    }
}