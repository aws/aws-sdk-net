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

namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Container for the parameters to the ImportFirewallDomains operation. Imports a list
    /// of domains from an Amazon S3 file into a firewall domain list. The file should contain
    /// one domain per line. <important> <para> Route 53 Global Resolver is a global service
    /// that supports resolvers in multiple Amazon Web Services Regions but you must specify
    /// the US East (Ohio) Region to create, update, or otherwise work with Route 53 Global
    /// Resolver resources. That is, for example, specify <c>--region us-east-2</c> on Amazon
    /// Web Services CLI commands. </para> </important>
    /// </summary>
    public partial class ImportFirewallDomainsRequest : AmazonRoute53GlobalResolverRequest
    {
        /// <summary>
        /// Gets and sets the property DomainFileUrl. 
        /// <para>
        /// The fully qualified URL of the file in Amazon S3 that contains the list of domains
        /// to import. The file should contain one domain per line.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainFileUrl { get; set; }

        /// <summary>
        /// Checks to see if the DomainFileUrl property is set.
        /// </summary>
        internal bool IsSetDomainFileUrl() => this.DomainFileUrl != null;

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// ID of the DNS Firewall domain list that you want to import the domain list to.
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
        /// This value is <c>REPLACE</c>, and it updates the domain list to match the list of
        /// domains in the imported file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;
    }
}
