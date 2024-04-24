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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the ImportFirewallDomains operation.
    /// Imports domain names from a file into a domain list, for use in a DNS firewall rule
    /// group. 
    /// 
    ///  
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
    /// </summary>
    public partial class ImportFirewallDomainsRequest : AmazonRoute53ResolverRequest
    {
        private string _domainFileUrl;
        private string _firewallDomainListId;
        private FirewallDomainImportOperation _operation;

        /// <summary>
        /// Gets and sets the property DomainFileUrl. 
        /// <para>
        /// The fully qualified URL or URI of the file stored in Amazon Simple Storage Service
        /// (Amazon S3) that contains the list of domains to import.
        /// </para>
        ///  
        /// <para>
        /// The file must be in an S3 bucket that's in the same Region as your DNS Firewall. The
        /// file must be a text file and must contain a single domain per line.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string DomainFileUrl
        {
            get { return this._domainFileUrl; }
            set { this._domainFileUrl = value; }
        }

        // Check to see if DomainFileUrl property is set
        internal bool IsSetDomainFileUrl()
        {
            return this._domainFileUrl != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the domain list that you want to modify with the import operation.
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
        /// What you want DNS Firewall to do with the domains that are listed in the file. This
        /// must be set to <c>REPLACE</c>, which updates the domain list to exactly match the
        /// list in the file. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FirewallDomainImportOperation Operation
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