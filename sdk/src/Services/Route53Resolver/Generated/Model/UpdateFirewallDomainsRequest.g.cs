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
    /// domain list from an array of domain specifications.
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
        ///  <c>ADD</c> - Add the domains to the ones that are already in the domain list. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REMOVE</c> - Search the domain list for the domains and remove them from the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPLACE</c> - Update the domain list to exactly match the list that you are providing.
        /// 
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
