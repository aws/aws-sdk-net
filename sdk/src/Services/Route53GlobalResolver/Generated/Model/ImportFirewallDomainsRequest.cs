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
    /// Container for the parameters to the ImportFirewallDomains operation.
    /// Imports a list of domains from an Amazon S3 file into a firewall domain list. The
    /// file should contain one domain per line.
    /// </summary>
    public partial class ImportFirewallDomainsRequest : AmazonRoute53GlobalResolverRequest
    {
        private string _domainFileUrl;
        private string _firewallDomainListId;
        private string _operation;

        /// <summary>
        /// Gets and sets the property DomainFileUrl. 
        /// <para>
        /// The fully qualified URL of the file in Amazon S3 that contains the list of domains
        /// to import. The file should contain one domain per line.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// ID of the DNS Firewall domain list that you want to import the domain list to.
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
        /// This value is <c>REPLACE</c>, and it updates the domain list to match the list of
        /// domains in the imported file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Operation
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