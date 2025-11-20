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
    /// This is the response object from the ListCoreNetworkPrefixListAssociations operation.
    /// </summary>
    public partial class ListCoreNetworkPrefixListAssociationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PrefixListAssociation> _prefixListAssociations = AWSConfigs.InitializeCollections ? new List<PrefixListAssociation>() : null;

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

        /// <summary>
        /// Gets and sets the property PrefixListAssociations. 
        /// <para>
        /// The list of prefix list associations for the core network.
        /// </para>
        /// </summary>
        public List<PrefixListAssociation> PrefixListAssociations
        {
            get { return this._prefixListAssociations; }
            set { this._prefixListAssociations = value; }
        }

        // Check to see if PrefixListAssociations property is set
        internal bool IsSetPrefixListAssociations()
        {
            return this._prefixListAssociations != null && (this._prefixListAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}