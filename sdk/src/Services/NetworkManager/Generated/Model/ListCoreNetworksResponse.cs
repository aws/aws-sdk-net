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
    /// This is the response object from the ListCoreNetworks operation.
    /// </summary>
    public partial class ListCoreNetworksResponse : AmazonWebServiceResponse
    {
        private List<CoreNetworkSummary> _coreNetworks = AWSConfigs.InitializeCollections ? new List<CoreNetworkSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CoreNetworks. 
        /// <para>
        /// Describes the list of core networks.
        /// </para>
        /// </summary>
        public List<CoreNetworkSummary> CoreNetworks
        {
            get { return this._coreNetworks; }
            set { this._coreNetworks = value; }
        }

        // Check to see if CoreNetworks property is set
        internal bool IsSetCoreNetworks()
        {
            return this._coreNetworks != null && (this._coreNetworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}