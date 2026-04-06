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
    /// Container for the parameters to the ListManagedFirewallDomainLists operation.
    /// Returns a paginated list of the Amazon Web Services Managed DNS Lists and the categories
    /// for DNS Firewall. The categories are either <c>THREAT</c> or <c>CONTENT</c>.
    /// 
    ///  <important> 
    /// <para>
    /// Route 53 Global Resolver is a global service that supports resolvers in multiple Amazon
    /// Web Services Regions but you must specify the US East (Ohio) Region to create, update,
    /// or otherwise work with Route 53 Global Resolver resources. That is, for example, specify
    /// <c>--region us-east-2</c> on Amazon Web Services CLI commands.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListManagedFirewallDomainListsRequest : AmazonRoute53GlobalResolverRequest
    {
        private string _managedFirewallDomainListType;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ManagedFirewallDomainListType. 
        /// <para>
        /// The category of the Manage DNS list either <c>THREAT</c> or <c>CONTENT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManagedFirewallDomainListType
        {
            get { return this._managedFirewallDomainListType; }
            set { this._managedFirewallDomainListType = value; }
        }

        // Check to see if ManagedFirewallDomainListType property is set
        internal bool IsSetManagedFirewallDomainListType()
        {
            return this._managedFirewallDomainListType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to retrieve in a single call.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token used for large sets of results that can't be returned in a single
        /// response.
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