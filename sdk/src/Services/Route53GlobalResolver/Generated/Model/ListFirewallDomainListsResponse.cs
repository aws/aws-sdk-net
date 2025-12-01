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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
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
namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// This is the response object from the ListFirewallDomainLists operation.
    /// </summary>
    public partial class ListFirewallDomainListsResponse : AmazonWebServiceResponse
    {
        private List<FirewallDomainListsItem> _firewallDomainLists = AWSConfigs.InitializeCollections ? new List<FirewallDomainListsItem>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FirewallDomainLists. 
        /// <para>
        /// List of the DNS Firewall domain lists.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FirewallDomainListsItem> FirewallDomainLists
        {
            get { return this._firewallDomainLists; }
            set { this._firewallDomainLists = value; }
        }

        // Check to see if FirewallDomainLists property is set
        internal bool IsSetFirewallDomainLists()
        {
            return this._firewallDomainLists != null && (this._firewallDomainLists.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token used for large sets of results that can't be returned in a single
        /// response. Provide this token in the next call to get the results not returned in this
        /// call.
        /// </para>
        /// </summary>
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