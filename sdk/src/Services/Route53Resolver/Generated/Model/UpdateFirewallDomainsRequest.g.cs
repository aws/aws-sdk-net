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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFirewallDomains operation. Updates the firewall
    /// domain list from an array of domain specifications. <para> For an AutoAllowlist rule's
    /// managed domain list, use <c>ADD</c> to approve observed domains, <c>REMOVE</c> to
    /// stop allowing domains, unless a wildcard entry that's still on the list matches them,
    /// and <c>DENY</c> to dismiss observed domains. <c>REPLACE</c> and <a>ImportFirewallDomains</a>
    /// aren't supported for these lists. </para> <para> DNS Firewall throttles <c>UpdateFirewallDomains</c>
    /// requests based on both the request rate and the total number of domains across your
    /// requests. </para> <para> <b>Best Practice for Updating Domain Lists</b> </para> <para>
    /// If you only need to modify a subset of domains, use the <c>ADD</c> or <c>REMOVE</c>
    /// operations instead of <c>REPLACE</c>. With <c>REPLACE</c>, you send the complete list
    /// you want to end up with, and throttling counts every domain in that request, including
    /// domains that aren't changing, which can use up your available throttling capacity.
    /// </para>
    /// </summary>
    public partial class UpdateFirewallDomainsRequest : AmazonRoute53ResolverRequest
    {
        /// <summary>
        /// Gets and sets the property Domains. 
        /// <para>
        /// A list of domains to use in the update operation.
        /// </para>
        ///  <important> 
        /// <para>
        /// There is a limit of 1000 domains per request.
        /// </para>
        ///  </important> 
        /// <para>
        /// Each domain specification in your domain list must satisfy the following requirements:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It can optionally start with <c>*</c> (asterisk).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With the exception of the optional starting asterisk, it must only contain the following
        /// characters: <c>A-Z</c>, <c>a-z</c>, <c>0-9</c>, <c>-</c> (hyphen).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It must be from 1-255 characters in length. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Domains { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Domains property is set.
        /// </summary>
        internal bool IsSetDomains() => this.Domains != null && (this.Domains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the domain list whose domains you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string FirewallDomainListId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallDomainListId property is set.
        /// </summary>
        internal bool IsSetFirewallDomainListId() => this.FirewallDomainListId != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// What you want DNS Firewall to do with the domains that you are providing: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ADD</c> - Add the domains to the ones that are already in the domain list. For
        /// an AutoAllowlist rule's managed domain list, this also marks the observed domains
        /// as allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REMOVE</c> - Search the domain list for the domains and remove them from the list.
        /// For an AutoAllowlist rule's managed domain list, the rule no longer allows the removed
        /// domains, unless a wildcard entry that's still on the list matches them.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPLACE</c> - Update the domain list to exactly match the list that you are providing.
        /// Not supported for an AutoAllowlist rule's managed domain list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DENY</c> - For an AutoAllowlist rule's managed domain list only, mark the specified
        /// observed domains as denied so that they're no longer listed for review. If a domain
        /// is on the managed domain list, <c>DENY</c> also removes it from the list. Specify
        /// fully qualified domain names. Wildcards aren't accepted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FirewallDomainUpdateOperation Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;
    }
}
