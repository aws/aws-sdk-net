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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListAccessors operation. Returns a list of the
    /// accessors and their properties. Accessor objects are containers that have the information
    /// required for token based access to your Ethereum nodes.
    /// </summary>
    public partial class ListAccessorsRequest : AmazonManagedBlockchainRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of accessors to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The blockchain network that the <c>Accessor</c> token is created for.
        /// </para>
        ///  <note> 
        /// <para>
        /// Use the value <c>ETHEREUM_MAINNET_AND_GOERLI</c> for all existing <c>Accessors</c>
        /// tokens that were created before the <c>networkType</c> property was introduced.
        /// </para>
        ///  </note>
        /// </summary>
        public AccessorNetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token that indicates the next set of results to retrieve. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
