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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFirewallDomains operation.
    /// Updates the firewall domain list from an array of domain specifications.
    /// </summary>
    public partial class UpdateFirewallDomainsRequest : AmazonRoute53ResolverRequest
    {
        private List<string> _domains = new List<string>();
        private string _firewallDomainListId;
        private FirewallDomainUpdateOperation _operation;

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
        /// It can optionally start with <code>*</code> (asterisk).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With the exception of the optional starting asterisk, it must only contain the following
        /// characters: <code>A-Z</code>, <code>a-z</code>, <code>0-9</code>, <code>-</code> (hyphen).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It must be from 1-255 characters in length. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Domains
        {
            get { return this._domains; }
            set { this._domains = value; }
        }

        // Check to see if Domains property is set
        internal bool IsSetDomains()
        {
            return this._domains != null && this._domains.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the domain list whose domains you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FirewallDomainListId
        {
            get { return this._firewallDomainListId; }
            set { this._firewallDomainListId = value; }
        }

        // Check to see if FirewallDomainListId property is set
        internal bool IsSetFirewallDomainListId()
        {
            return this._firewallDomainListId != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// What you want DNS Firewall to do with the domains that you are providing: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ADD</code> - Add the domains to the ones that are already in the domain list.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REMOVE</code> - Search the domain list for the domains and remove them from
        /// the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REPLACE</code> - Update the domain list to exactly match the list that you
        /// are providing. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public FirewallDomainUpdateOperation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

    }
}