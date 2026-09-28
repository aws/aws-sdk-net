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
    /// Container for the parameters to the GetManagedFirewallDomainList operation. Retrieves
    /// information about an Amazon Web Services-managed firewall domain list. Managed domain
    /// lists contain domains associated with malicious activity, content categories, or specific
    /// threats. <important> <para> Route 53 Global Resolver is a global service that supports
    /// resolvers in multiple Amazon Web Services Regions but you must specify the US East
    /// (Ohio) Region to create, update, or otherwise work with Route 53 Global Resolver resources.
    /// That is, for example, specify <c>--region us-east-2</c> on Amazon Web Services CLI
    /// commands. </para> </important>
    /// </summary>
    public partial class GetManagedFirewallDomainListRequest : AmazonRoute53GlobalResolverRequest
    {
        /// <summary>
        /// Gets and sets the property ManagedFirewallDomainListId. 
        /// <para>
        /// ID of the Managed Domain List.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ManagedFirewallDomainListId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedFirewallDomainListId property is set.
        /// </summary>
        internal bool IsSetManagedFirewallDomainListId() => this.ManagedFirewallDomainListId != null;
    }
}
