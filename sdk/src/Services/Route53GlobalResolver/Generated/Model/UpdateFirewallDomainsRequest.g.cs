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
    /// Container for the parameters to the UpdateFirewallDomains operation. Updates a DNS
    /// Firewall domain list from an array of specified domains. <important> <para> Route
    /// 53 Global Resolver is a global service that supports resolvers in multiple Amazon
    /// Web Services Regions but you must specify the US East (Ohio) Region to create, update,
    /// or otherwise work with Route 53 Global Resolver resources. That is, for example, specify
    /// <c>--region us-east-2</c> on Amazon Web Services CLI commands. </para> </important>
    /// </summary>
    public partial class UpdateFirewallDomainsRequest : AmazonRoute53GlobalResolverRequest
    {
        /// <summary>
        /// Gets and sets the property Domains. 
        /// <para>
        /// A list of the domains. You can add up to 1000 domains per request.
        /// </para>
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
        /// The ID of the DNS Firewall domain list to which you want to add the domains.
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
        /// The operation for updating the domain list. The allowed values are ADD, REMOVE, and
        /// REPLACE.
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
